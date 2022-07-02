using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Net;

namespace PokemonCounter
{
    public partial class PkmnLoad : Form
    {
        public PkmnLoad()
        {
            InitializeComponent();
        }
        private void PkmnLoad_Load(object sender, EventArgs e)
        {
            formatMenu();
            updateColors();
            LoadHuntsDGV();
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
            this.Dispose();
        }
        private void BT_MINIMIZE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        
        private void BT_CANCEL_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void BT_DELETE_Click(object sender, EventArgs e)
        {
            List<int> huntIds = new List<int>();
            
            for (int i = 0; i < DGV_PKMN.SelectedRows.Count; i++)
            {
                huntIds.Add(Convert.ToInt32(DGV_PKMN.SelectedRows[i].Cells["ID"].Value));
            }
            if (DGV_PKMN.SelectedRows.Count == 0)
            {
                for (int i = 0; i < DGV_PKMN.SelectedCells.Count; i++)
                {
                    huntIds.Add(Convert.ToInt32(DGV_PKMN.Rows[DGV_PKMN.SelectedCells[i].RowIndex].Cells["ID"].Value));
                }
            }
            if (huntIds.Count > 0) Lib.DeleteHunt(huntIds.ToArray());
            LoadHuntsDGV();
        }
        private void BT_LOAD_Click(object sender, EventArgs e)
        {
            LoadHuntProperties(DGV_PKMN.SelectedCells[0].RowIndex);
            this.Dispose();
        }
        private void LoadHuntProperties(int SelectedRow)
        {
            Lib.Completed = Convert.ToBoolean(DGV_PKMN.Rows[SelectedRow].Cells["DGV_Caught"].Value);
            if (Convert.ToBoolean(DGV_PKMN.Rows[SelectedRow].Cells["DGV_Caught"].Value)) Lib.properties[0].PBX_COMPLETE.Image = Properties.Resources.crown_color;
            else Lib.properties[0].PBX_COMPLETE.Image = Properties.Resources.crown_bw;
            
            Lib.properties[0].NMUD_COUNTER.Value = Convert.ToDecimal(DGV_PKMN.Rows[SelectedRow].Cells["DGV_Encounters"].Value);
            Lib.properties[0].CKB_ORDER.Checked = Convert.ToBoolean(DGV_PKMN.Rows[SelectedRow].Cells["DGV_alpha"].Value);
            Lib.properties[0].CB_POKE.SelectedIndex = Convert.ToInt32(DGV_PKMN.Rows[SelectedRow].Cells["DGV_pkmnIndex"].Value);
            Lib.properties[0].CB_GEN.SelectedIndex = Convert.ToInt32(DGV_PKMN.Rows[SelectedRow].Cells["DGV_genIndex"].Value);
            Lib.properties[0].CB_GAME.SelectedIndex = Convert.ToInt32(DGV_PKMN.Rows[SelectedRow].Cells["DGV_gameIndex"].Value);
            Lib.properties[0].CKB_SHINY.Checked = Convert.ToBoolean(DGV_PKMN.Rows[SelectedRow].Cells["DGV_shiny"].Value);
            Lib.properties[0].CKB_GIF.Checked = Convert.ToBoolean(DGV_PKMN.Rows[SelectedRow].Cells["DGV_animated"].Value);
            Lib.properties[0].TB_ADD.Text = DGV_PKMN.Rows[SelectedRow].Cells["DGV_addHotkey"].Value.ToString();
            Lib.properties[0].TB_SUS.Text = DGV_PKMN.Rows[SelectedRow].Cells["DGV_subHotkey"].Value.ToString();

            Lib.actualHuntID = Convert.ToInt32(DGV_PKMN.Rows[SelectedRow].Cells["ID"].Value);
            Lib.hotkeyReset = DGV_PKMN.Rows[SelectedRow].Cells["DGV_resetHotkey"].Value.ToString();
            Lib.autosave = Convert.ToBoolean(DGV_PKMN.Rows[SelectedRow].Cells["DGV_autosave"].Value);

            Lib.exportedCounter = Convert.ToBoolean(DGV_PKMN.Rows[SelectedRow].Cells["DGV_exportCounter"].Value);
            Lib.exportedFileCounter = DGV_PKMN.Rows[SelectedRow].Cells["DGV_exportFileCounter"].Value.ToString();
            
            Lib.importedPicture = Convert.ToBoolean(DGV_PKMN.Rows[SelectedRow].Cells["DGV_importPicture"].Value);
            Lib.importedFilePicture = DGV_PKMN.Rows[SelectedRow].Cells["DGV_importFilePicture"].Value.ToString();

            Lib.counterRatio = Convert.ToDecimal(DGV_PKMN.Rows[SelectedRow].Cells["DGV_counterRatio"].Value);

            if (Convert.ToBoolean(DGV_PKMN.Rows[SelectedRow].Cells["DGV_importPicture"].Value)) Lib.properties[0].PBX_PREVIEW.ImageLocation = DGV_PKMN.Rows[SelectedRow].Cells["DGV_importFilePicture"].Value.ToString();
            else Lib.properties[0].UpdatePic(Lib.properties[0].PBX_PREVIEW);
        }

        private void LoadHuntsDGV()
        {
            string jsonData = Lib.ReadData(Lib.dataFile);
            if (jsonData.Length > 5)
            {
                BT_DELETE.Enabled = true;
                BT_LOAD.Enabled = true;
                Lib.FillHunts(jsonData, DGV_PKMN);
            }
            else
            {
                DGV_PKMN.Rows.Clear();
                BT_DELETE.Enabled = false;
                BT_LOAD.Enabled = false;
            }
        }
        private void updateColors()
        {
            PNL_MENU.BackColor = Lib.ColorMain;
            PNL_CONTENT.BackColor = Lib.ColorAccent;
        }

        private void refreshToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadHuntsDGV();
        }

        private void DGV_PKMN_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            List<int> SelectedRows = new List<int>();
            SelectedRows.Clear();
            for (int i = 0; i < DGV_PKMN.SelectedCells.Count; i++)
            {
                if (!SelectedRows.Contains(DGV_PKMN.SelectedCells[i].RowIndex)) SelectedRows.Add(DGV_PKMN.SelectedCells[i].RowIndex);
            }
            if (SelectedRows.Count == 1)
            {
                BT_LOAD.Enabled = true;
            }
            else if (SelectedRows.Count == 0)
            {
                BT_DELETE.Enabled = false;
                BT_LOAD.Enabled = false;
            }
            else
            {
                BT_LOAD.Enabled = false;
            }
        }
    }
}
