using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace PokemonCounter
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }
        private void Options_Load(object sender, EventArgs e)
        {
            formatMenu();
            updateColors();
            CKB_AOT.Checked = this.TopMost;
            CKB_OOF.Checked = Lib.OOF;
            if (Lib.Vertical)
            {
                CB_VERTICAL.SelectedIndex = CB_VERTICAL.Items.IndexOf("竖向排列");
            }
                
            else CB_VERTICAL.SelectedIndex = CB_VERTICAL.Items.IndexOf("横向排列");
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
        private void BT_CANCEL_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void BT_MINIMIZE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BT_APPLY_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].TopMost = CKB_AOT.Checked;
            Lib.ColorMain = PNL_MAINCOLOR.BackColor;
            Lib.ColorAccent = PNL_ACCENTCOLOR.BackColor;
            Lib.OOF = CKB_OOF.Checked;
            if (CB_VERTICAL.SelectedIndex == CB_VERTICAL.Items.IndexOf("竖向排列"))
            {
                Lib.Vertical = true;
                Lib.mainForms[0].TBL_CONTENT.GrowStyle = TableLayoutPanelGrowStyle.AddRows;
                Lib.mainForms[0].Width = Lib.mainForms[0].TBL_CONTENT.Width;
                Lib.mainForms[0].Height = PNL_MENU.Height + Lib.mainForms[0].TBL_CONTENT.Height;
            }
            else
            {
                Lib.Vertical = false;
                Lib.mainForms[0].TBL_CONTENT.GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
                Lib.mainForms[0].Width = Lib.mainForms[0].TBL_CONTENT.Width;
                Lib.mainForms[0].Height = PNL_MENU.Height + Lib.mainForms[0].TBL_CONTENT.Height;
            }
            Application.OpenForms[0].KeyDown -= new KeyEventHandler(Lib.MainForm_KeyDown);
            Lib.gHook.unhook();
            if (CKB_OOF.Checked) Lib.gHook.hook();
            else Application.OpenForms[0].KeyDown += new KeyEventHandler(Lib.MainForm_KeyDown);

            
            Lib.fileConfig cnf = new Lib.fileConfig();
            cnf.Main = Lib.ColorMain;
            cnf.Accent = Lib.ColorAccent;
            cnf.AOT = CKB_AOT.Checked;
            cnf.OOF = CKB_OOF.Checked;
            if (CB_VERTICAL.SelectedIndex == CB_VERTICAL.Items.IndexOf("竖向排列")) cnf.Vertical = true;
            else cnf.Vertical = false;
            string jsonData = JsonConvert.SerializeObject(cnf);
            
            File.WriteAllText(Lib.configFile, jsonData);
            for (int i = 0; i < Application.OpenForms.Count; i++)
            {
                Application.OpenForms[i].Controls["PNL_MENU"].BackColor = Lib.ColorMain;
                Application.OpenForms[i].Controls["PNL_CONTENT"].BackColor = Lib.ColorAccent;
            }
            this.Dispose();
        }

        private void PNL_MAINCOLOR_Click(object sender, EventArgs e)
        {
            CDG_BACKGROUND.ShowDialog();
            PNL_MAINCOLOR.BackColor = CDG_BACKGROUND.Color;
        }
        private void PNL_ACCENTCOLOR_Click(object sender, EventArgs e)
        {
            CDG_BACKGROUND.ShowDialog();
            PNL_ACCENTCOLOR.BackColor = CDG_BACKGROUND.Color;
        }

        private void updateColors()
        {
            PNL_MENU.BackColor = Lib.ColorMain;
            PNL_CONTENT.BackColor = Lib.ColorAccent;
            PNL_MAINCOLOR.BackColor = Lib.ColorMain;
            PNL_ACCENTCOLOR.BackColor = Lib.ColorAccent;
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
