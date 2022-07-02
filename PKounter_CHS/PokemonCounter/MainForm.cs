using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Runtime.InteropServices;
using System.Diagnostics;

namespace PokemonCounter
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            formatMenu();
            Lib.gHook = new GlobalKeyboardHook();
            Lib.gHook.KeyDown += new KeyEventHandler(Lib.gHook_KeyDown);
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
                Lib.gHook.HookedKeys.Add(key);
            Lib.gHook.hook();
            loadConfig();
            PNL_MENU.BackColor = Lib.ColorMain;
            if (!File.Exists(Lib.dataFile)) File.Create(Lib.dataFile).Close();
            TBL_CONTENT.Dock = DockStyle.None;
            TBL_CONTENT.Controls.Clear();
            AddCell();
            this.Height = PNL_MENU.Height + TBL_CONTENT.Height;
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
        
        private void BT_CLOSE_Click(object sender, EventArgs e)
        {
            AutoSaving.Enabled = false;
            Lib.UpdateHunts();
            this.Close();
        }
        private void BT_ADD_Click(object sender, EventArgs e)
        {
            AddCell();
        }
        private void BT_SUS_Click(object sender, EventArgs e)
        {
            DeleteCell();
        }
        private void BT_MINIMIZE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BT_OPTIONS_Click(object sender, EventArgs e)
        {
            Options opt = new Options();
            opt.TopMost = this.TopMost;
            opt.ShowDialog();
            opt.Dispose();
        }

        private void AddCell()
        {
            if (TBL_CONTENT.Controls.Count < 8 )
            {
                int huntID = 1;
                string jsonData = Lib.ReadData();
                List<Lib.Hunt> Hunts = new List<Lib.Hunt>();
                if (jsonData != "") Hunts = JsonConvert.DeserializeObject<List<Lib.Hunt>>(jsonData);
                if (Hunts.Count > 0) huntID = Hunts[Hunts.Count - 1].ID + 1;

                Lib.Hunt newHunt = new Lib.Hunt();
                newHunt.ID = huntID;
                newHunt.autosave = false;
                newHunt.pkmnIndex = 0;
                newHunt.alpha = false;
                newHunt.shiny = true;
                newHunt.animated = true;
                newHunt.genIndex = 5;
                newHunt.gameIndex = 0;
                newHunt.complete = false;
                newHunt.counterRatio = 1;
                newHunt.addHotkey = "";
                newHunt.subHotkey = "";
                newHunt.resetHotkey = "";
                newHunt.exportCounter = false;
                newHunt.importPicture = false;
                newHunt.exportFileCounter = "";
                newHunt.importFilePicture= "";

                Panel subpanelpokemon = new Panel();
                subpanelpokemon.Height = 200;
                subpanelpokemon.Width = 200;
                
                PictureBox pkmnpic = new PictureBox();
                pkmnpic.Height = 150;
                pkmnpic.Width = 150;
                pkmnpic.BorderStyle = BorderStyle.FixedSingle;
                pkmnpic.Left = Convert.ToInt32(Convert.ToDouble(subpanelpokemon.Width) / 2 - Convert.ToDouble(pkmnpic.Width) / 2);
                pkmnpic.Top = Convert.ToInt32(Convert.ToDouble(subpanelpokemon.Height) / 2 - Convert.ToDouble(pkmnpic.Height) / 2);
                pkmnpic.SizeMode = PictureBoxSizeMode.Zoom;
                newHunt.pic = pkmnpic;
                subpanelpokemon.Controls.Add(pkmnpic);
                
                Label pkmnname = new Label();
                pkmnname.Left = pkmnpic.Left;
                pkmnname.Width = pkmnpic.Width;
                pkmnname.Height = 25;
                pkmnname.AutoSize = false;
                pkmnname.TextAlign = ContentAlignment.MiddleLeft;
                pkmnname.Text = "宝可梦名字";
                //pkmnname.Font = new Font(pkmnname.Font, FontStyle.Bold);
                newHunt.pkmnName = pkmnname;
                subpanelpokemon.Controls.Add(pkmnname);

                Label counter = new Label();
                counter.Left = pkmnpic.Left + 60;
                counter.Top = pkmnpic.Top + pkmnpic.Height;
                counter.Width = pkmnpic.Width - 60;
                counter.Height = 25;
                counter.AutoSize = false;
                counter.TextAlign = ContentAlignment.MiddleRight;
                counter.Text = "次数";
                //counter.Font = new Font(counter.Font, FontStyle.Bold);
                newHunt.counter = counter;
                subpanelpokemon.Controls.Add(counter);

                Button counter_sub = new Button();
                counter_sub.Top = pkmnpic.Top + pkmnpic.Height;
                counter_sub.Left = pkmnpic.Left;
                counter_sub.Height = 25;
                counter_sub.Width = 30;
                counter_sub.Image = Properties.Resources.countersub;
                //counter_sub.Enabled = false;
                counter_sub.BackColor = Color.LightGray;
                newHunt.counterSub = counter_sub;
                subpanelpokemon.Controls.Add(counter_sub);

                Button counter_add = new Button();
                counter_add.Top = pkmnpic.Top + pkmnpic.Height;
                counter_add.Left = pkmnpic.Left + counter_sub.Width;
                counter_add.Height = 25;
                counter_add.Width = 30;
                counter_add.Image = Properties.Resources.counteradd;
                //counter_add.Enabled = false;
                counter_add.BackColor = Color.LightGray;
                newHunt.counterAdd = counter_add;
                subpanelpokemon.Controls.Add(counter_add);

                pkmnpic.MouseHover          += (s, e) => 
                {
                    pkmnpic.BackColor = Color.LightBlue;
                };
                pkmnpic.MouseLeave          += (s, e) => 
                {
                    pkmnpic.BackColor = Color.Transparent;
                };
                counter_add.Click           += new EventHandler(CounterAddClick);
                counter_sub.Click           += new EventHandler(CounterSubClick);
                pkmnpic.Click               += new EventHandler(PKMNPIC_Click);
                counter.TextChanged         += new EventHandler(COUNTER_TextChanged);

                TBL_CONTENT.Height += subpanelpokemon.Height;
                TBL_CONTENT.Width += subpanelpokemon.Width;
                TBL_CONTENT.Controls.Add(subpanelpokemon);
                Lib.HuntsList.Add(newHunt);
                if (Lib.Vertical) this.TBL_CONTENT.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
                else this.TBL_CONTENT.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
                this.Width = TBL_CONTENT.Width;
                this.Height = PNL_MENU.Height + TBL_CONTENT.Height;
            }
        }
        private void DeleteCell()
        {
            if (TBL_CONTENT.Controls.Count > 1)
            {
                Lib.HuntsList.RemoveAt(TBL_CONTENT.Controls.Count - 1);
                TBL_CONTENT.Controls.RemoveAt(TBL_CONTENT.Controls.Count - 1);
                this.Width = TBL_CONTENT.Width;
            }
        }
        
        private void PKMNPIC_Click(object sender, EventArgs e)
        {
            PictureBox pokemonpicpanel = sender as PictureBox;
            int Actual = TBL_CONTENT.Controls.IndexOf(pokemonpicpanel.Parent);
            OpenProperties(Actual);
        }
        private void CounterAddClick(object sender, EventArgs e)
        {
            Button counterAdd = sender as Button;
            int Actual = TBL_CONTENT.Controls.IndexOf(counterAdd.Parent);
            Label counter = Lib.HuntsList[Actual].counter;
            if (Regex.IsMatch(counter.Text, @"^\d"))
            {
                Lib.HuntsList[Actual].counter.Text = (Convert.ToInt32(Lib.HuntsList[Actual].counter.Text) + 
                    Convert.ToInt32(Lib.HuntsList[Actual].counterRatio)).ToString();
            }
            else Lib.HuntsList[Actual].counter.Text = "0";
        }
        private void CounterSubClick(object sender, EventArgs e)
        {
            Button counterAdd = sender as Button;
            int Actual = TBL_CONTENT.Controls.IndexOf(counterAdd.Parent);
            Label counter = Lib.HuntsList[Actual].counter;
            if (Regex.IsMatch(counter.Text, @"^\d"))
            {
                Lib.HuntsList[Actual].counter.Text = (Convert.ToInt32(Lib.HuntsList[Actual].counter.Text) -
                    Convert.ToInt32(Lib.HuntsList[Actual].counterRatio)).ToString();
                if (Convert.ToInt32(Lib.HuntsList[Actual].counter.Text) < 0) Lib.HuntsList[Actual].counter.Text = "0";
            }
            else Lib.HuntsList[Actual].counter.Text = "0";
        }
        
        private void OpenProperties(int Actual)
        {
            PkmnProperties Pkmn = new PkmnProperties();
            Pkmn.TopMost = this.TopMost;
            Lib.Visor = Actual;
            
            // SETTING POKEMON LIST ORDER
            Pkmn.CKB_ORDER.Checked = Lib.HuntsList[Actual].alpha;

            // SETTING POKEMON NAME
            Pkmn.CB_POKE.SelectedIndex = Lib.HuntsList[Actual].pkmnIndex;

            // SETTING GEN AND GAME
            Pkmn.CB_GEN.SelectedIndex = Lib.HuntsList[Actual].genIndex;
            Pkmn.CB_GAME.SelectedIndex = Lib.HuntsList[Actual].gameIndex;

            // SETTING ALL CHECKBOXES (SHINY, GIF...)
            Pkmn.CKB_SHINY.Checked = Lib.HuntsList[Actual].shiny;
            Pkmn.CKB_GIF.Checked = Lib.HuntsList[Actual].animated;
            if (Regex.IsMatch(Lib.HuntsList[Actual].counter.Text, @"^\d"))
                Pkmn.NMUD_COUNTER.Value = Convert.ToDecimal(Lib.HuntsList[Actual].counter.Text);
            
            Pkmn.TB_ADD.Text = Lib.HuntsList[Actual].addHotkey;
            Pkmn.TB_SUS.Text = Lib.HuntsList[Actual].subHotkey;
            if (Lib.HuntsList[Actual].complete)
                Pkmn.PBX_COMPLETE.Image = Properties.Resources.crown_color;
            else
                Pkmn.PBX_COMPLETE.Image = Properties.Resources.crown_bw;
            Lib.Completed = Lib.HuntsList[Actual].complete;
            Lib.actualHuntID = Lib.HuntsList[Actual].ID;
            Lib.autosave = Lib.HuntsList[Actual].autosave;
            Lib.hotkeyReset = Lib.HuntsList[Actual].resetHotkey;
            Lib.counterRatio = Lib.HuntsList[Actual].counterRatio;
            if (Lib.HuntsList[Actual].importPicture) Pkmn.PBX_PREVIEW.ImageLocation = Lib.HuntsList[Actual].importFilePicture;
            Lib.importedPicture = Lib.HuntsList[Actual].importPicture;
            Lib.importedFilePicture = Lib.HuntsList[Actual].importFilePicture;
            Lib.exportedCounter = Lib.HuntsList[Actual].exportCounter;
            Lib.exportedFileCounter = Lib.HuntsList[Actual].exportFileCounter;
            Lib.properties.Add(Pkmn);
            Pkmn.ShowDialog();
        }
        private void COUNTER_TextChanged(object sender, EventArgs e)
        {
            Label item = sender as Label;
            if (Lib.HuntsList[TBL_CONTENT.Controls.IndexOf(item.Parent)].exportCounter)
            {
                string counterexportfile = Lib.HuntsList[TBL_CONTENT.Controls.IndexOf(item.Parent)].exportFileCounter;
                File.WriteAllText(counterexportfile, item.Text);
            };
        }
        private void formatMenu()
        {
            BT_ADD.FlatAppearance.BorderSize = 0;
            BT_ADD.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BT_ADD.FlatAppearance.MouseOverBackColor = Color.Transparent;

            BT_SUS.FlatAppearance.BorderSize = 0;
            BT_SUS.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BT_SUS.FlatAppearance.MouseOverBackColor = Color.Transparent;

            BT_MINIMIZE.FlatAppearance.BorderSize = 0;
            BT_MINIMIZE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BT_MINIMIZE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            BT_CLOSE.FlatAppearance.BorderSize = 0;
            BT_CLOSE.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BT_CLOSE.FlatAppearance.MouseOverBackColor = Color.Transparent;

            BT_OPTIONS.FlatAppearance.BorderSize = 0;
            BT_OPTIONS.FlatAppearance.MouseDownBackColor = Color.Transparent;
            BT_OPTIONS.FlatAppearance.MouseOverBackColor = Color.Transparent;
        }
        private void loadConfig()
        {
            if (!File.Exists(Lib.configFile)) File.Create(Lib.configFile).Close();
            else
            {
                string jsonData = Lib.ReadData(Lib.configFile);
                if (jsonData != "")
                {
                    Lib.fileConfig cnf = JsonConvert.DeserializeObject<Lib.fileConfig>(jsonData);
                    Lib.ColorMain = cnf.Main;
                    Lib.ColorAccent = cnf.Accent;
                    Lib.Vertical = cnf.Vertical;
                    Lib.OOF = cnf.OOF;
                    this.TopMost = cnf.AOT;
                    if (!cnf.OOF)
                    {
                        Lib.gHook.unhook();
                        this.KeyDown += Lib.MainForm_KeyDown;
                    }
                }
            }
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Lib.gHook.unhook();
        }

        private void AutoSaving_Tick(object sender, EventArgs e)
        {
            AutoSaving.Enabled = false;
            Lib.UpdateHunts();
            AutoSaving.Enabled = true;
        }
    }
}
