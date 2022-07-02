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
    public partial class PkmnProperties2 : Form
    {
        public PkmnProperties2()
        {
            InitializeComponent();
            formatMenu();
            updateColors();
        }
        private void PkmnProperties2_Load(object sender, EventArgs e)
        {

        }
        
        private void CKB_IMPORT_PICTURE_Click(object sender, EventArgs e)
        {
            if (CKB_IMPORT_PICTURE.Checked)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = false;
                ofd.Title = "选择要从中导入的图片";
                ofd.Filter = "PNG files|*.png|JPG files|*.jpg|GIF files|*.gif";
                ofd.ShowDialog();
                if (ofd.FileName == "")
                {
                    CKB_IMPORT_PICTURE.Checked = false;
                }
                else
                {
                    TB_PATH_PICTURE.Text = ofd.FileName;
                }

            }
            else
            {
                TB_PATH_PICTURE.Text = "";
            }
        }
        private void CKB_EXPORT_COUNTER_Click(object sender, EventArgs e)
        {
            if (CKB_EXPORT_COUNTER.Checked)
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Multiselect = false;
                ofd.Title = "选择要导出到的 txt 文件";
                ofd.Filter = "TXT files|*.txt";
                ofd.ShowDialog();
                if (ofd.FileName == "")
                {
                    CKB_EXPORT_COUNTER.Checked = false;
                }
                else
                {
                    TB_PATH_COUNTER.Text = ofd.FileName;
                }
            }
            else
            {
                CKB_EXPORT_COUNTER.Checked = false;
                TB_PATH_COUNTER.Text = "";
            }
        }

        private void BT_MINIMIZE_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void BT_CLOSE_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void BT_CANCEL_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void BT_APPLY_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            Lib.autosave = CKB_AUTOSAVE.Checked;
            Lib.counterRatio = NMUD_RATIO.Value;
            Lib.hotkeyReset = TB_RESET.Text;

            Lib.exportedCounter = CKB_EXPORT_COUNTER.Checked;
            Lib.exportedFileCounter = TB_PATH_COUNTER.Text;

            Lib.importedPicture = CKB_IMPORT_PICTURE.Checked;
            Lib.importedFilePicture = TB_PATH_PICTURE.Text;

            if (CKB_IMPORT_PICTURE.Checked) Lib.properties[0].PBX_PREVIEW.ImageLocation = TB_PATH_PICTURE.Text;
            
            this.Dispose();
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

        private void TB_RESET_KeyDown(object sender, KeyEventArgs e)
        {
            Keys modifierKeys = e.Modifiers;
            Keys pressedKey = e.KeyData ^ modifierKeys;
            var converter = new KeysConverter();
            TB_RESET.Text = converter.ConvertToString(e.KeyData);
        }
    }
}
