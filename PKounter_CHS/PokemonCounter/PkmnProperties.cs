using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PokemonCounter
{
    public partial class PkmnProperties : Form
    {
        public PkmnProperties()
        {
            InitializeComponent();
            formatMenu();
            updateColors();
            CB_POKE.Items.Clear();
            Array.Sort(Lib.PkmnNamesSortedList, StringComparer.InvariantCulture);
            if (!Lib.PkmnNamesNumberedList[0].StartsWith("0")) PokemonNames.PkmnNamesNumbered(Lib.PkmnNamesNumberedList);
            CB_POKE.Items.AddRange(Lib.PkmnNamesNumberedList);
            CB_POKE.SelectedIndex = 0;
            UpdateGens();
            CB_GEN.SelectedIndex = 0;
            UpdateGames();
            CB_GAME.SelectedIndex = 0;
        }
        private void PkmnProperties_Load(object sender, EventArgs e)
        {
            
        }
        
        private void UpdateGens()
        {
            CB_GEN.Items.Clear();
            int[] PkmnMax = { 151, 251, 386, 493, 649, 807 };
            for (int i = 0; i < PkmnMax.Length; i++)
            {
                if (!CKB_ORDER.Checked & (CB_POKE.SelectedIndex + 1) <= PkmnMax[i]) { CB_GEN.Items.Add("GEN " + (i + 1)); }
                else if (CKB_ORDER.Checked & Array.IndexOf(Lib.PkmnNamesList, CB_POKE.SelectedItem) + 1 <= PkmnMax[i]) { CB_GEN.Items.Add("GEN " + (i + 1)); }
            }
        }
        private void UpdateGames()
        {
            CB_GAME.Items.Clear();
            CB_GAME.Items.AddRange(Lib.GamesList[Convert.ToInt32(CB_GEN.SelectedItem.ToString().Substring(3)) - 1]);
        }
        public void UpdatePic(PictureBox FrameToUpdate)
        {
            if (Lib.importedPicture)
            {
                PBX_PREVIEW.ImageLocation = Lib.importedFilePicture;
                return;
            }
            if (CB_POKE.SelectedIndex >= 0)
            {
                string picpath = "";
                int gen = Convert.ToInt32(CB_GEN.SelectedItem.ToString().Substring(4));
                string pokedexnmb = "";
                if (CKB_ORDER.Checked) pokedexnmb = (Array.IndexOf(Lib.PkmnNamesList, Lib.PkmnNamesSortedList[CB_POKE.SelectedIndex]) + 1).ToString();
                else pokedexnmb = (Array.IndexOf(Lib.PkmnNamesList, Lib.PkmnNamesList[CB_POKE.SelectedIndex]) + 1).ToString();

                string url_serebii = "https://www.serebii.net/"; // 1st, 2nd, 6th & 7th gen static sprites
                string url_pokemondb = "https://img.pokemondb.net/sprites/"; // 3rd - 6th gen static sprites + 5th gen gifs
                string url_emeraldShinyGifs = "https://raw.githubusercontent.com/danigarpal97/EmeraldShinyGifs/master/";
                string url_showdown = "https://play.pokemonshowdown.com/sprites/"; // 6th - 7th gen sprites
                string url_pkmnnet = "http://pkmn.net/sprites/"; // 2nd gen gifs (white bg) + 3rd gen normal gifs
                string url_bulbapedia = "https://bulbapedia.bulbagarden.net/wiki/File:Spr_"; // 

                // GEN1、2
                if (gen < 3 ) 
                {
                    if (!CKB_GIF.Checked) //非动图
                    {
                        picpath = url_serebii;

                        while (pokedexnmb.Length < 3) pokedexnmb = "0" + pokedexnmb;

                        // 闪光
                        if (CKB_SHINY.Checked) 
                        {
                            picpath += "Shiny/";
                            if (CB_GAME.SelectedItem.ToString() == "金") picpath += "Gold/"; // GAME
                            else if (CB_GAME.SelectedItem.ToString() == "银") picpath += "Silver/"; // GAME
                            else if (CB_GAME.SelectedItem.ToString() == "水晶") picpath += "Crystal/"; // GAME
                            else picpath += CB_GAME.SelectedItem.ToString() + "/"; // GAME
                        }

                        //普通
                        else
                        {
                            picpath += "pokearth/sprites/";
                            if (CB_GAME.SelectedItem.ToString() == "红/蓝") picpath += "rb/"; // GAME
                            else if (CB_GAME.SelectedItem.ToString() == "绿") picpath += "green/"; // GAME
                            else if (CB_GAME.SelectedItem.ToString() == "黄") picpath += "yellow/"; // GAME
                            else if (CB_GAME.SelectedItem.ToString() == "金") picpath += "gold/"; // GAME
                            else if (CB_GAME.SelectedItem.ToString() == "银") picpath += "silver/"; // GAME
                            else if (CB_GAME.SelectedItem.ToString() == "水晶") picpath += "crystal/"; // GAME
                            else picpath += CB_GAME.SelectedItem.ToString().ToLower() + "/";
                        }
                        picpath += pokedexnmb;
                        picpath += ".png";
                    }
                    else//动图，仅水晶
                    {
                        picpath = url_pkmnnet;

                        //闪光
                        if (gen == 2 && CKB_SHINY.Checked) picpath += "shinycrystal/";

                        //普通
                        else if (gen == 2 && !CKB_SHINY.Checked) picpath += "crystal/"; 
                        else picpath += CB_GAME.SelectedItem.ToString().ToLower() + "/";

                        picpath += pokedexnmb;
                        if (CKB_GIF.Checked) picpath += ".gif";
                        else picpath += ".png";
                    }
                }

                //  GEN3
                else if (gen == 3 )
                {
                    if (!CKB_GIF.Checked) //非动图
                    {
                        picpath = url_pokemondb;
                        if (CB_GAME.SelectedItem.ToString() == "绿宝石") picpath += "emerald/"; // GAME
                        else if (CB_GAME.SelectedItem.ToString() == "红宝石/蓝宝石") picpath += "ruby-sapphire/"; // GAME
                        else if (CB_GAME.SelectedItem.ToString() == "火红/叶绿") picpath += "firered-leafgreen/"; // GAME
                        else picpath += CB_GAME.SelectedItem.ToString().ToLower().Replace('/', '-') + "/"; // GAME

                        if (CKB_SHINY.Checked) picpath += "shiny/"; // SHINY
                        else picpath += "normal/";

                        if (CKB_ORDER.Checked) picpath += Lib.PkmnEngNamesSortedList[CB_POKE.SelectedIndex].ToLower(); // NAME
                        else picpath += Lib.PkmnEngNamesList[CB_POKE.SelectedIndex].ToLower();

                        picpath += ".png";
                    }
                    else //动图，仅绿宝石
                    {
                        //普通
                        if(!CKB_SHINY.Checked)
                        {
                            picpath = url_pkmnnet;
                            if ( CB_GAME.SelectedItem.ToString() == "绿宝石") picpath += "emerald/"; // GAME
                            else picpath += CB_GAME.SelectedItem.ToString().ToLower() + "/";
                            picpath += pokedexnmb + ".gif";
                        }
                        //闪光
                        else
                        {
                            picpath = url_emeraldShinyGifs;
                            picpath += pokedexnmb + ".gif";
                        }
                    }
                }

                // GEN4、5
                else if (gen > 3 && gen < 6 && !CKB_GIF.Checked || gen == 5)
                {
                    picpath = url_pokemondb;
                    //gen4
                    if (CB_GAME.SelectedItem.ToString() == "钻石/珍珠") picpath += "diamond-pearl/"; // GAME
                    else if (CB_GAME.SelectedItem.ToString() == "白金") picpath += "platinum/"; // GAME
                    else if (CB_GAME.SelectedItem.ToString() == "心金/魂银") picpath += "heartgold-soulsilver/"; // GAME
                    //gen5
                    else if (CB_GAME.SelectedItem.ToString() == "黑/白") picpath += "black-white/"; // GAME
                    else picpath += CB_GAME.SelectedItem.ToString().ToLower().Replace('/', '-') + "/"; // GAME

                    //动图（仅5代）
                    if (CKB_GIF.Checked) picpath += "anim/"; // GIF (1ST PART)

                    //非动图
                    //闪光
                    if (CKB_SHINY.Checked) picpath += "shiny/"; // SHINY
                    //普通
                    else picpath += "normal/";

                    if (CKB_ORDER.Checked) picpath += Lib.PkmnEngNamesSortedList[CB_POKE.SelectedIndex].ToLower(); // NAME
                    else picpath += Lib.PkmnEngNamesList[CB_POKE.SelectedIndex].ToLower();

                    if (CKB_GIF.Checked) picpath += ".gif"; // GIF (2ND PART)
                    else picpath += ".png";
                }

                // GEN6、7
                else if (gen > 5 )
                {
                    // 非动图
                    if (!CKB_GIF.Checked)
                    {
                        picpath = url_serebii;

                        while (pokedexnmb.Length < 3) pokedexnmb = "0" + pokedexnmb;
                        //闪光
                        if (CKB_SHINY.Checked) // SHINY
                        {
                            picpath += "Shiny/SM/";
                        }

                        //普通
                        else
                        {
                            picpath += "sunmoon/pokemon/";
                        }
                        picpath += pokedexnmb;
                        picpath += ".png";
                    }

                    //动图
                    else 
                    {
                        string[] NormalNameExceptions =
{
                        "Nidoranm",
                        "Farfetchd",
                        "MrMime",
                        "Hooh",
                        "Mimejr",
                        "TypeNull",
                        "Jangmoo",
                        "Hakamoo",
                        "Kommoo",
                        "TapuKoko",
                        "TapuLele",
                        "TapuBulu",
                        "TapuFini"
                    };
                        int[] NormalPositionExceptions =
                        {
                        31,
                        82,
                        121,
                        249,
                        438,
                        771,
                        781,
                        782,
                        783,
                        784,
                        785,
                        786,
                        787
                    };
                        string[] ShinyNameExceptions =
                        {
                        "NidoranF",
                        "NidoranM",
                        "Farfetchd",
                        "MrMime",
                        "Mime_jr",
                        "TypeNull",
                        "Jangmoo",
                        "Hakamoo",
                        "Kommoo",
                        "TapuKoko",
                        "TapuLele",
                        "TapuBulu",
                        "TapuFini"
                    };
                        int[] ShinyPositionExceptions =
                        {
                        28,
                        31,
                        82,
                        121,
                        438,
                        771,
                        781,
                        782,
                        783,
                        784,
                        785,
                        786,
                        787
                    };

                        string[] normalNames = Lib.PkmnNameException(Lib.PkmnEngNamesList, NormalPositionExceptions, NormalNameExceptions);
                        string[] shinyNames = Lib.PkmnNameException(Lib.PkmnEngNamesList, ShinyPositionExceptions, ShinyNameExceptions);

                        picpath = url_showdown;

                        //闪光
                        if (CKB_SHINY.Checked) // SHINY
                        {
                            picpath += "xyani-shiny/";
                            picpath += shinyNames[Convert.ToInt32(pokedexnmb) - 1].ToLower();
                        }

                        //普通
                        else
                        {
                            picpath += "xyani/";
                            picpath += normalNames[Convert.ToInt32(pokedexnmb) - 1].ToLower();
                        }
                        picpath += ".gif";
                        if (pokedexnmb == "803")
                        {
                            if (CKB_SHINY.Checked) picpath = "https://projectpokemon.org/home/uploads/monthly_2017_12/PoipoleShiny-Animated.gif.c9da4c69598b0ca62f625f434c3ad0f0.gif";
                            else picpath = "https://projectpokemon.org/home/uploads/monthly_2017_12/5a2babee957e7_PoipoleAnimated.gif.eac71fa1b3d822518314560dc17be994.gif";
                        }
                    }
                }

                FrameToUpdate.ImageLocation = picpath;
            }
        }

        private void CB_POKE_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_GEN.SelectedIndex >= 0)
            {
                string oldGen = CB_GEN.SelectedItem.ToString();
                UpdateGens();
                if (CB_GEN.Items.Contains(oldGen)) CB_GEN.SelectedIndex = CB_GEN.Items.IndexOf(oldGen);
                else CB_GEN.SelectedIndex = 0;
            }
            else UpdateGens();
            if (CKB_ORDER.Checked)
            {
                string dexnmb = (Array.IndexOf(Lib.PkmnNamesList, CB_POKE.SelectedItem.ToString()) + 1).ToString();
                while (dexnmb.Length < 3) dexnmb = "0" + dexnmb;
                LBL_PREVIEW_NAME.Text = dexnmb + " - " + CB_POKE.SelectedItem.ToString();
            }
            else LBL_PREVIEW_NAME.Text = CB_POKE.SelectedItem.ToString();
        }
        private void CB_GEN_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_GAME.SelectedIndex >= 0)
            {
                string oldGame = CB_GAME.SelectedItem.ToString();
                UpdateGames();
                if (CB_GAME.Items.Contains(oldGame)) CB_GAME.SelectedIndex = CB_GAME.Items.IndexOf(oldGame);
                else CB_GAME.SelectedIndex = 0;
            }
            else UpdateGames();
        }
        private void CB_GAME_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CB_GEN.SelectedItem.ToString() == "GEN 1") { CKB_SHINY.Checked = false; CKB_SHINY.Enabled = false; }
            else {  CKB_SHINY.Enabled = true; }
            if (CB_GAME.SelectedItem.ToString() == "水晶" || CB_GAME.SelectedItem.ToString() == "绿宝石" || Convert.ToInt32(CB_GEN.SelectedItem.ToString().Substring(4)) >= 5) CKB_GIF.Enabled = true;
            else { CKB_GIF.Checked = false; CKB_GIF.Enabled = false; }
            UpdatePic(PBX_PREVIEW);
        }

        private void CKB_ORDER_CheckedChanged(object sender, EventArgs e)
        {
            if (CKB_ORDER.Checked)
            {
                CB_POKE.Items.Clear();
                CB_POKE.Items.AddRange(Lib.PkmnNamesSortedList);
                CB_POKE.SelectedIndex = 0;
            }
            else
            {
                CB_POKE.Items.Clear();
                CB_POKE.Items.AddRange(Lib.PkmnNamesNumberedList);
                CB_POKE.SelectedIndex = 0;
            }
            UpdatePic(PBX_PREVIEW);
        }
        private void CKB_SHINY_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePic(PBX_PREVIEW);
        }
        private void CKB_GIF_CheckedChanged(object sender, EventArgs e)
        {
            UpdatePic(PBX_PREVIEW);
        }

        private void TB_ADD_KeyDown(object sender, KeyEventArgs e)
        {
            Keys modifierKeys = e.Modifiers;
            Keys pressedKey = e.KeyData ^ modifierKeys;
            var converter = new KeysConverter();
            TB_ADD.Text = converter.ConvertToString(e.KeyData);
        }
        private void TB_SUS_KeyDown(object sender, KeyEventArgs e)
        {
            Keys modifierKeys = e.Modifiers;
            Keys pressedKey = e.KeyData ^ modifierKeys;
            var converter = new KeysConverter();
            TB_SUS.Text = converter.ConvertToString(e.KeyData);
        }

        private void BT_MINIMIZE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BT_CLOSE_Click(object sender, EventArgs e)
        {
            Lib.properties.Clear();
            this.Dispose();
        }
        private void BT_CANCEL_Click(object sender, EventArgs e)
        {
            Lib.properties.Clear();
            this.Dispose();
        }
        private void BT_ADVANCED_Click(object sender, EventArgs e)
        {
            PkmnProperties2 pkmn = new PkmnProperties2();
            pkmn.TopMost = this.TopMost;
            pkmn.CKB_EXPORT_COUNTER.Checked = Lib.exportedCounter;
            pkmn.CKB_IMPORT_PICTURE.Checked = Lib.importedPicture;
            pkmn.CKB_AUTOSAVE.Checked = Lib.autosave;
            pkmn.TB_PATH_COUNTER.Text = Lib.exportedFileCounter;
            pkmn.TB_PATH_PICTURE.Text = Lib.importedFilePicture;
            pkmn.TB_RESET.Text = Lib.hotkeyReset;
            pkmn.NMUD_RATIO.Value = Lib.counterRatio;

            pkmn.ShowDialog();
        }
        private void BT_APPLY_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Lib.HuntsList[Lib.Visor].ID = Lib.actualHuntID;
            Lib.HuntsList[Lib.Visor].resetHotkey = Lib.hotkeyReset;
            Lib.HuntsList[Lib.Visor].autosave = Lib.autosave;

            Lib.HuntsList[Lib.Visor].addHotkey = TB_ADD.Text;
            Lib.HuntsList[Lib.Visor].subHotkey = TB_SUS.Text;
            Lib.HuntsList[Lib.Visor].pic.ImageLocation = PBX_PREVIEW.ImageLocation;

            Lib.HuntsList[Lib.Visor].counter.Text = NMUD_COUNTER.Value.ToString();
            Lib.HuntsList[Lib.Visor].counterRatio = Lib.counterRatio;

            Lib.HuntsList[Lib.Visor].genIndex = CB_GEN.SelectedIndex;
            Lib.HuntsList[Lib.Visor].gameIndex = CB_GAME.SelectedIndex;

            Lib.HuntsList[Lib.Visor].pkmnIndex = CB_POKE.SelectedIndex;
            Lib.HuntsList[Lib.Visor].alpha = CKB_ORDER.Checked;
            Lib.HuntsList[Lib.Visor].shiny = CKB_SHINY.Checked;
            Lib.HuntsList[Lib.Visor].animated = CKB_GIF.Checked;
            Lib.HuntsList[Lib.Visor].complete = Lib.Completed;
            
            Lib.HuntsList[Lib.Visor].exportCounter = Lib.exportedCounter;
            Lib.HuntsList[Lib.Visor].exportFileCounter = Lib.exportedFileCounter;

            Lib.HuntsList[Lib.Visor].importPicture = Lib.importedPicture;
            Lib.HuntsList[Lib.Visor].importFilePicture = Lib.importedFilePicture;

            if (CKB_ORDER.Checked)
            {
                string dexnmb = (Array.IndexOf(Lib.PkmnNamesList, CB_POKE.SelectedItem.ToString()) + 1).ToString();
                while (dexnmb.Length < 3) dexnmb = "0" + dexnmb;
                Lib.HuntsList[Lib.Visor].pkmnName.Text = dexnmb + " - " + CB_POKE.SelectedItem.ToString();
            }
            else Lib.HuntsList[Lib.Visor].pkmnName.Text = CB_POKE.SelectedItem.ToString();
            
            Lib.properties.Clear();
            this.Dispose();
        }
        private void BT_COUNTER_ADD_Click(object sender, EventArgs e)
        {
            NMUD_COUNTER.Value += Lib.counterRatio;
        }
        private void BT_COUNTER_SUB_Click(object sender, EventArgs e)
        {
            if (NMUD_COUNTER.Value - Lib.counterRatio < 0) NMUD_COUNTER.Value = 0;
            else NMUD_COUNTER.Value -= Lib.counterRatio;
        }
        private void BT_LOAD_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            PkmnLoad loadForm = new PkmnLoad();
            loadForm.TopMost = this.TopMost;
            loadForm.ShowDialog();
            loadForm.Dispose();
        }
        private void BT_SAVE_Click(object sender, EventArgs e)
        {
            int huntID = Lib.actualHuntID;
            bool autoSave = Lib.autosave;
            int genIndex = CB_GEN.SelectedIndex;
            int gameIndex = CB_GAME.SelectedIndex;
            int pkmnIndex = CB_POKE.SelectedIndex;
            decimal counterValue = NMUD_COUNTER.Value;
            decimal counterRatio = Lib.counterRatio;

            bool alpha = CKB_ORDER.Checked;
            bool shiny = CKB_SHINY.Checked;
            bool animated = CKB_GIF.Checked;
            bool complete = Lib.Completed;

            string addHotkey = TB_ADD.Text;
            string subHotkey = TB_SUS.Text;
            string resetHotkey = Lib.hotkeyReset;
            
            bool exportCounter = Lib.exportedCounter;
            string exportFileCounter = Lib.exportedFileCounter;

            bool importPicture = Lib.importedPicture;
            string importFilePicture = Lib.importedFilePicture;
            Lib.SaveHunt(huntID, autoSave, genIndex, gameIndex, pkmnIndex, counterValue, counterRatio, alpha, shiny, animated,
                complete, addHotkey, subHotkey, resetHotkey, exportCounter, exportFileCounter, importPicture, importFilePicture);
        }

        // WINDOW MOVING
        private bool mouseDown;
        private Point lastLocation;

        private void panel_menu_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }
        private void panel_menu_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }
        private void panel_menu_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }
        
        private void NMUD_COUNTER_ValueChanged(object sender, EventArgs e)
        {
            LBL_PREVIEW_COUNTER.Text = NMUD_COUNTER.Value.ToString();
        }
        private void PBX_COMPLETE_Click(object sender, EventArgs e)
        {
            if (Lib.Completed)
            {
                PBX_COMPLETE.Image = Properties.Resources.crown_bw;
                Lib.Completed = !Lib.Completed;
            }
            else
            {
                PBX_COMPLETE.Image = Properties.Resources.crown_color;
                Lib.Completed = !Lib.Completed;
            }
        }
        private void updateColors()
        {
            PNL_MENU.BackColor = Lib.ColorMain;
            PNL_CONTENT.BackColor = Lib.ColorAccent;
        }
        private void formatMenu()
        {
            BT_MINIMIZE.FlatAppearance.BorderSize = 0;
            BT_MINIMIZE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BT_MINIMIZE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            BT_CLOSE.FlatAppearance.BorderSize = 0;
            BT_CLOSE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BT_CLOSE.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
    }
}
