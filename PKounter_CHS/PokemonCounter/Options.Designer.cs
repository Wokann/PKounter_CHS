namespace PokemonCounter
{
    partial class Options
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.PNL_CONTENT = new System.Windows.Forms.Panel();
            this.PNL_DISPLAY = new System.Windows.Forms.Panel();
            this.PNL_DISPLAY_UNDERLINE = new System.Windows.Forms.Panel();
            this.CKB_AOT = new System.Windows.Forms.CheckBox();
            this.CKB_OOF = new System.Windows.Forms.CheckBox();
            this.TBL_DISPLAY = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_VERTICAL = new System.Windows.Forms.Label();
            this.CB_VERTICAL = new System.Windows.Forms.ComboBox();
            this.LBL_COLOR_MAIN = new System.Windows.Forms.Label();
            this.PNL_MAINCOLOR = new System.Windows.Forms.Panel();
            this.LBL_COLOR_ACCENT = new System.Windows.Forms.Label();
            this.PNL_ACCENTCOLOR = new System.Windows.Forms.Panel();
            this.LBL_DISPLAY = new System.Windows.Forms.Label();
            this.BT_CANCEL = new System.Windows.Forms.Button();
            this.BT_APPLY = new System.Windows.Forms.Button();
            this.PNL_MENU = new System.Windows.Forms.Panel();
            this.BT_MINIMIZE = new System.Windows.Forms.Button();
            this.BT_CLOSE = new System.Windows.Forms.Button();
            this.CDG_BACKGROUND = new System.Windows.Forms.ColorDialog();
            this.PNL_CONTENT.SuspendLayout();
            this.PNL_DISPLAY.SuspendLayout();
            this.TBL_DISPLAY.SuspendLayout();
            this.PNL_MENU.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_CONTENT
            // 
            this.PNL_CONTENT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PNL_CONTENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_CONTENT.Controls.Add(this.PNL_DISPLAY);
            this.PNL_CONTENT.Controls.Add(this.BT_CANCEL);
            this.PNL_CONTENT.Controls.Add(this.BT_APPLY);
            this.PNL_CONTENT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_CONTENT.Location = new System.Drawing.Point(0, 42);
            this.PNL_CONTENT.Name = "PNL_CONTENT";
            this.PNL_CONTENT.Size = new System.Drawing.Size(283, 204);
            this.PNL_CONTENT.TabIndex = 31;
            // 
            // PNL_DISPLAY
            // 
            this.PNL_DISPLAY.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PNL_DISPLAY.Controls.Add(this.PNL_DISPLAY_UNDERLINE);
            this.PNL_DISPLAY.Controls.Add(this.CKB_AOT);
            this.PNL_DISPLAY.Controls.Add(this.CKB_OOF);
            this.PNL_DISPLAY.Controls.Add(this.TBL_DISPLAY);
            this.PNL_DISPLAY.Controls.Add(this.LBL_DISPLAY);
            this.PNL_DISPLAY.Location = new System.Drawing.Point(6, 2);
            this.PNL_DISPLAY.Name = "PNL_DISPLAY";
            this.PNL_DISPLAY.Size = new System.Drawing.Size(270, 164);
            this.PNL_DISPLAY.TabIndex = 33;
            // 
            // PNL_DISPLAY_UNDERLINE
            // 
            this.PNL_DISPLAY_UNDERLINE.BackColor = System.Drawing.Color.Black;
            this.PNL_DISPLAY_UNDERLINE.Location = new System.Drawing.Point(8, 25);
            this.PNL_DISPLAY_UNDERLINE.Name = "PNL_DISPLAY_UNDERLINE";
            this.PNL_DISPLAY_UNDERLINE.Size = new System.Drawing.Size(150, 2);
            this.PNL_DISPLAY_UNDERLINE.TabIndex = 32;
            // 
            // CKB_AOT
            // 
            this.CKB_AOT.AutoSize = true;
            this.CKB_AOT.Checked = true;
            this.CKB_AOT.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB_AOT.Location = new System.Drawing.Point(16, 39);
            this.CKB_AOT.Name = "CKB_AOT";
            this.CKB_AOT.Size = new System.Drawing.Size(72, 16);
            this.CKB_AOT.TabIndex = 35;
            this.CKB_AOT.Text = "始终前置";
            this.CKB_AOT.UseVisualStyleBackColor = true;
            // 
            // CKB_OOF
            // 
            this.CKB_OOF.Checked = true;
            this.CKB_OOF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CKB_OOF.Location = new System.Drawing.Point(16, 59);
            this.CKB_OOF.Name = "CKB_OOF";
            this.CKB_OOF.Size = new System.Drawing.Size(196, 21);
            this.CKB_OOF.TabIndex = 36;
            this.CKB_OOF.Text = "未在窗口界面也可按快捷键计数";
            this.CKB_OOF.UseVisualStyleBackColor = true;
            // 
            // TBL_DISPLAY
            // 
            this.TBL_DISPLAY.AutoSize = true;
            this.TBL_DISPLAY.ColumnCount = 2;
            this.TBL_DISPLAY.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TBL_DISPLAY.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TBL_DISPLAY.Controls.Add(this.LBL_VERTICAL, 0, 0);
            this.TBL_DISPLAY.Controls.Add(this.CB_VERTICAL, 1, 0);
            this.TBL_DISPLAY.Controls.Add(this.LBL_COLOR_MAIN, 0, 1);
            this.TBL_DISPLAY.Controls.Add(this.PNL_MAINCOLOR, 1, 1);
            this.TBL_DISPLAY.Controls.Add(this.LBL_COLOR_ACCENT, 0, 2);
            this.TBL_DISPLAY.Controls.Add(this.PNL_ACCENTCOLOR, 1, 2);
            this.TBL_DISPLAY.Location = new System.Drawing.Point(10, 83);
            this.TBL_DISPLAY.Name = "TBL_DISPLAY";
            this.TBL_DISPLAY.RowCount = 3;
            this.TBL_DISPLAY.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TBL_DISPLAY.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TBL_DISPLAY.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TBL_DISPLAY.Size = new System.Drawing.Size(249, 78);
            this.TBL_DISPLAY.TabIndex = 32;
            // 
            // LBL_VERTICAL
            // 
            this.LBL_VERTICAL.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_VERTICAL.AutoSize = true;
            this.LBL_VERTICAL.Location = new System.Drawing.Point(3, 7);
            this.LBL_VERTICAL.Name = "LBL_VERTICAL";
            this.LBL_VERTICAL.Size = new System.Drawing.Size(29, 12);
            this.LBL_VERTICAL.TabIndex = 37;
            this.LBL_VERTICAL.Text = "显示";
            // 
            // CB_VERTICAL
            // 
            this.CB_VERTICAL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_VERTICAL.Items.AddRange(new object[] {
            "横向排列",
            "竖向排列"});
            this.CB_VERTICAL.Location = new System.Drawing.Point(103, 3);
            this.CB_VERTICAL.Name = "CB_VERTICAL";
            this.CB_VERTICAL.Size = new System.Drawing.Size(99, 20);
            this.CB_VERTICAL.TabIndex = 0;
            // 
            // LBL_COLOR_MAIN
            // 
            this.LBL_COLOR_MAIN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_COLOR_MAIN.AutoSize = true;
            this.LBL_COLOR_MAIN.Location = new System.Drawing.Point(3, 33);
            this.LBL_COLOR_MAIN.Name = "LBL_COLOR_MAIN";
            this.LBL_COLOR_MAIN.Size = new System.Drawing.Size(41, 12);
            this.LBL_COLOR_MAIN.TabIndex = 36;
            this.LBL_COLOR_MAIN.Text = "主颜色";
            // 
            // PNL_MAINCOLOR
            // 
            this.PNL_MAINCOLOR.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PNL_MAINCOLOR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PNL_MAINCOLOR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PNL_MAINCOLOR.Location = new System.Drawing.Point(103, 29);
            this.PNL_MAINCOLOR.Name = "PNL_MAINCOLOR";
            this.PNL_MAINCOLOR.Size = new System.Drawing.Size(21, 19);
            this.PNL_MAINCOLOR.TabIndex = 39;
            this.PNL_MAINCOLOR.Click += new System.EventHandler(this.PNL_MAINCOLOR_Click);
            // 
            // LBL_COLOR_ACCENT
            // 
            this.LBL_COLOR_ACCENT.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_COLOR_ACCENT.AutoSize = true;
            this.LBL_COLOR_ACCENT.Location = new System.Drawing.Point(3, 59);
            this.LBL_COLOR_ACCENT.Name = "LBL_COLOR_ACCENT";
            this.LBL_COLOR_ACCENT.Size = new System.Drawing.Size(41, 12);
            this.LBL_COLOR_ACCENT.TabIndex = 38;
            this.LBL_COLOR_ACCENT.Text = "强调色";
            // 
            // PNL_ACCENTCOLOR
            // 
            this.PNL_ACCENTCOLOR.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PNL_ACCENTCOLOR.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PNL_ACCENTCOLOR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PNL_ACCENTCOLOR.Location = new System.Drawing.Point(103, 55);
            this.PNL_ACCENTCOLOR.Name = "PNL_ACCENTCOLOR";
            this.PNL_ACCENTCOLOR.Size = new System.Drawing.Size(21, 19);
            this.PNL_ACCENTCOLOR.TabIndex = 40;
            this.PNL_ACCENTCOLOR.Click += new System.EventHandler(this.PNL_ACCENTCOLOR_Click);
            // 
            // LBL_DISPLAY
            // 
            this.LBL_DISPLAY.AutoSize = true;
            this.LBL_DISPLAY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_DISPLAY.Location = new System.Drawing.Point(7, 7);
            this.LBL_DISPLAY.Name = "LBL_DISPLAY";
            this.LBL_DISPLAY.Size = new System.Drawing.Size(39, 16);
            this.LBL_DISPLAY.TabIndex = 25;
            this.LBL_DISPLAY.Text = "设置";
            // 
            // BT_CANCEL
            // 
            this.BT_CANCEL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_CANCEL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BT_CANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CANCEL.ForeColor = System.Drawing.Color.White;
            this.BT_CANCEL.Location = new System.Drawing.Point(142, 168);
            this.BT_CANCEL.Name = "BT_CANCEL";
            this.BT_CANCEL.Size = new System.Drawing.Size(134, 34);
            this.BT_CANCEL.TabIndex = 27;
            this.BT_CANCEL.Text = "取消";
            this.BT_CANCEL.UseVisualStyleBackColor = false;
            this.BT_CANCEL.Click += new System.EventHandler(this.BT_CANCEL_Click);
            // 
            // BT_APPLY
            // 
            this.BT_APPLY.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_APPLY.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BT_APPLY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_APPLY.ForeColor = System.Drawing.Color.White;
            this.BT_APPLY.Location = new System.Drawing.Point(5, 168);
            this.BT_APPLY.Name = "BT_APPLY";
            this.BT_APPLY.Size = new System.Drawing.Size(134, 34);
            this.BT_APPLY.TabIndex = 26;
            this.BT_APPLY.Text = "应用";
            this.BT_APPLY.UseVisualStyleBackColor = false;
            this.BT_APPLY.Click += new System.EventHandler(this.BT_APPLY_Click);
            // 
            // PNL_MENU
            // 
            this.PNL_MENU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PNL_MENU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_MENU.Controls.Add(this.BT_MINIMIZE);
            this.PNL_MENU.Controls.Add(this.BT_CLOSE);
            this.PNL_MENU.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_MENU.Location = new System.Drawing.Point(0, 0);
            this.PNL_MENU.Name = "PNL_MENU";
            this.PNL_MENU.Size = new System.Drawing.Size(283, 42);
            this.PNL_MENU.TabIndex = 30;
            this.PNL_MENU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_menu_MouseDown);
            this.PNL_MENU.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_menu_MouseMove);
            this.PNL_MENU.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_menu_MouseUp);
            // 
            // BT_MINIMIZE
            // 
            this.BT_MINIMIZE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_MINIMIZE.BackColor = System.Drawing.Color.Transparent;
            this.BT_MINIMIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_MINIMIZE.ForeColor = System.Drawing.Color.White;
            this.BT_MINIMIZE.Image = global::PokemonCounter.Properties.Resources.menu_minimize;
            this.BT_MINIMIZE.Location = new System.Drawing.Point(206, 1);
            this.BT_MINIMIZE.Name = "BT_MINIMIZE";
            this.BT_MINIMIZE.Size = new System.Drawing.Size(38, 36);
            this.BT_MINIMIZE.TabIndex = 21;
            this.BT_MINIMIZE.UseVisualStyleBackColor = false;
            this.BT_MINIMIZE.Click += new System.EventHandler(this.BT_MINIMIZE_Click);
            // 
            // BT_CLOSE
            // 
            this.BT_CLOSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_CLOSE.BackColor = System.Drawing.Color.Transparent;
            this.BT_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_CLOSE.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CLOSE.ForeColor = System.Drawing.Color.White;
            this.BT_CLOSE.Image = global::PokemonCounter.Properties.Resources.menu_close;
            this.BT_CLOSE.Location = new System.Drawing.Point(243, 1);
            this.BT_CLOSE.Name = "BT_CLOSE";
            this.BT_CLOSE.Size = new System.Drawing.Size(37, 36);
            this.BT_CLOSE.TabIndex = 20;
            this.BT_CLOSE.UseVisualStyleBackColor = false;
            this.BT_CLOSE.Click += new System.EventHandler(this.BT_CLOSE_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(283, 246);
            this.Controls.Add(this.PNL_CONTENT);
            this.Controls.Add(this.PNL_MENU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "设置";
            this.Load += new System.EventHandler(this.Options_Load);
            this.PNL_CONTENT.ResumeLayout(false);
            this.PNL_DISPLAY.ResumeLayout(false);
            this.PNL_DISPLAY.PerformLayout();
            this.TBL_DISPLAY.ResumeLayout(false);
            this.TBL_DISPLAY.PerformLayout();
            this.PNL_MENU.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_CONTENT;
        private System.Windows.Forms.Panel PNL_DISPLAY;
        private System.Windows.Forms.Panel PNL_DISPLAY_UNDERLINE;
        private System.Windows.Forms.TableLayoutPanel TBL_DISPLAY;
        private System.Windows.Forms.Label LBL_DISPLAY;
        private System.Windows.Forms.Button BT_CANCEL;
        private System.Windows.Forms.Button BT_APPLY;
        private System.Windows.Forms.Panel PNL_MENU;
        private System.Windows.Forms.Button BT_MINIMIZE;
        private System.Windows.Forms.Button BT_CLOSE;
        private System.Windows.Forms.Label LBL_COLOR_MAIN;
        public System.Windows.Forms.Panel PNL_MAINCOLOR;
        private System.Windows.Forms.ColorDialog CDG_BACKGROUND;
        public System.Windows.Forms.CheckBox CKB_AOT;
        public System.Windows.Forms.CheckBox CKB_OOF;
        private System.Windows.Forms.Label LBL_COLOR_ACCENT;
        public System.Windows.Forms.Panel PNL_ACCENTCOLOR;
        private System.Windows.Forms.ComboBox CB_VERTICAL;
        private System.Windows.Forms.Label LBL_VERTICAL;
    }
}