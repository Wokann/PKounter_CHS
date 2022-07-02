namespace PokemonCounter
{
    partial class PkmnProperties2
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
            this.PNL_MENU = new System.Windows.Forms.Panel();
            this.BT_MINIMIZE = new System.Windows.Forms.Button();
            this.BT_CLOSE = new System.Windows.Forms.Button();
            this.PNL_CONTENT = new System.Windows.Forms.Panel();
            this.PNL_HUNT = new System.Windows.Forms.Panel();
            this.PNL_HUNT_UNDERLINE = new System.Windows.Forms.Panel();
            this.TBL_HUNT = new System.Windows.Forms.TableLayoutPanel();
            this.CKB_AUTOSAVE = new System.Windows.Forms.CheckBox();
            this.LBL_HUNT = new System.Windows.Forms.Label();
            this.PNL_COUNTER = new System.Windows.Forms.Panel();
            this.PNL_COUNTER_UNDERLINE = new System.Windows.Forms.Panel();
            this.TBL_COUNTER = new System.Windows.Forms.TableLayoutPanel();
            this.TB_RESET = new System.Windows.Forms.TextBox();
            this.LBL_HOTKEYRESET = new System.Windows.Forms.Label();
            this.CKB_EXPORT_COUNTER = new System.Windows.Forms.CheckBox();
            this.TB_PATH_COUNTER = new System.Windows.Forms.TextBox();
            this.NMUD_RATIO = new System.Windows.Forms.NumericUpDown();
            this.LBL_RATIO = new System.Windows.Forms.Label();
            this.LBL_COUNTER = new System.Windows.Forms.Label();
            this.PNL_PICTURE = new System.Windows.Forms.Panel();
            this.PNL_PICTURE_UNDERLINE = new System.Windows.Forms.Panel();
            this.TBL_PICTURE = new System.Windows.Forms.TableLayoutPanel();
            this.TB_PATH_PICTURE = new System.Windows.Forms.TextBox();
            this.CKB_IMPORT_PICTURE = new System.Windows.Forms.CheckBox();
            this.LBL_PICTURE = new System.Windows.Forms.Label();
            this.BT_CANCEL = new System.Windows.Forms.Button();
            this.BT_APPLY = new System.Windows.Forms.Button();
            this.PNL_MENU.SuspendLayout();
            this.PNL_CONTENT.SuspendLayout();
            this.PNL_HUNT.SuspendLayout();
            this.TBL_HUNT.SuspendLayout();
            this.PNL_COUNTER.SuspendLayout();
            this.TBL_COUNTER.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NMUD_RATIO)).BeginInit();
            this.PNL_PICTURE.SuspendLayout();
            this.TBL_PICTURE.SuspendLayout();
            this.SuspendLayout();
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
            this.PNL_MENU.Size = new System.Drawing.Size(461, 32);
            this.PNL_MENU.TabIndex = 46;
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
            this.BT_MINIMIZE.Location = new System.Drawing.Point(397, 5);
            this.BT_MINIMIZE.Name = "BT_MINIMIZE";
            this.BT_MINIMIZE.Size = new System.Drawing.Size(25, 23);
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
            this.BT_CLOSE.Location = new System.Drawing.Point(428, 5);
            this.BT_CLOSE.Name = "BT_CLOSE";
            this.BT_CLOSE.Size = new System.Drawing.Size(25, 23);
            this.BT_CLOSE.TabIndex = 20;
            this.BT_CLOSE.UseVisualStyleBackColor = false;
            this.BT_CLOSE.Click += new System.EventHandler(this.BT_CLOSE_Click);
            // 
            // PNL_CONTENT
            // 
            this.PNL_CONTENT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PNL_CONTENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_CONTENT.Controls.Add(this.PNL_HUNT);
            this.PNL_CONTENT.Controls.Add(this.PNL_COUNTER);
            this.PNL_CONTENT.Controls.Add(this.PNL_PICTURE);
            this.PNL_CONTENT.Controls.Add(this.BT_CANCEL);
            this.PNL_CONTENT.Controls.Add(this.BT_APPLY);
            this.PNL_CONTENT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_CONTENT.Location = new System.Drawing.Point(0, 32);
            this.PNL_CONTENT.Name = "PNL_CONTENT";
            this.PNL_CONTENT.Size = new System.Drawing.Size(461, 163);
            this.PNL_CONTENT.TabIndex = 47;
            // 
            // PNL_HUNT
            // 
            this.PNL_HUNT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PNL_HUNT.Controls.Add(this.PNL_HUNT_UNDERLINE);
            this.PNL_HUNT.Controls.Add(this.TBL_HUNT);
            this.PNL_HUNT.Controls.Add(this.LBL_HUNT);
            this.PNL_HUNT.Location = new System.Drawing.Point(7, 3);
            this.PNL_HUNT.Name = "PNL_HUNT";
            this.PNL_HUNT.Size = new System.Drawing.Size(220, 73);
            this.PNL_HUNT.TabIndex = 34;
            // 
            // PNL_HUNT_UNDERLINE
            // 
            this.PNL_HUNT_UNDERLINE.BackColor = System.Drawing.Color.Black;
            this.PNL_HUNT_UNDERLINE.Location = new System.Drawing.Point(8, 25);
            this.PNL_HUNT_UNDERLINE.Name = "PNL_HUNT_UNDERLINE";
            this.PNL_HUNT_UNDERLINE.Size = new System.Drawing.Size(150, 2);
            this.PNL_HUNT_UNDERLINE.TabIndex = 32;
            // 
            // TBL_HUNT
            // 
            this.TBL_HUNT.AutoSize = true;
            this.TBL_HUNT.ColumnCount = 1;
            this.TBL_HUNT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TBL_HUNT.Controls.Add(this.CKB_AUTOSAVE, 0, 0);
            this.TBL_HUNT.Location = new System.Drawing.Point(8, 29);
            this.TBL_HUNT.Name = "TBL_HUNT";
            this.TBL_HUNT.RowCount = 1;
            this.TBL_HUNT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TBL_HUNT.Size = new System.Drawing.Size(195, 32);
            this.TBL_HUNT.TabIndex = 32;
            // 
            // CKB_AUTOSAVE
            // 
            this.CKB_AUTOSAVE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CKB_AUTOSAVE.AutoSize = true;
            this.CKB_AUTOSAVE.Location = new System.Drawing.Point(3, 8);
            this.CKB_AUTOSAVE.Name = "CKB_AUTOSAVE";
            this.CKB_AUTOSAVE.Size = new System.Drawing.Size(72, 16);
            this.CKB_AUTOSAVE.TabIndex = 34;
            this.CKB_AUTOSAVE.Text = "自动保存";
            this.CKB_AUTOSAVE.UseVisualStyleBackColor = true;
            // 
            // LBL_HUNT
            // 
            this.LBL_HUNT.AutoSize = true;
            this.LBL_HUNT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_HUNT.Location = new System.Drawing.Point(7, 7);
            this.LBL_HUNT.Name = "LBL_HUNT";
            this.LBL_HUNT.Size = new System.Drawing.Size(39, 16);
            this.LBL_HUNT.TabIndex = 25;
            this.LBL_HUNT.Text = "捕获";
            // 
            // PNL_COUNTER
            // 
            this.PNL_COUNTER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PNL_COUNTER.Controls.Add(this.PNL_COUNTER_UNDERLINE);
            this.PNL_COUNTER.Controls.Add(this.TBL_COUNTER);
            this.PNL_COUNTER.Controls.Add(this.LBL_COUNTER);
            this.PNL_COUNTER.Location = new System.Drawing.Point(233, 3);
            this.PNL_COUNTER.Name = "PNL_COUNTER";
            this.PNL_COUNTER.Size = new System.Drawing.Size(220, 114);
            this.PNL_COUNTER.TabIndex = 29;
            // 
            // PNL_COUNTER_UNDERLINE
            // 
            this.PNL_COUNTER_UNDERLINE.BackColor = System.Drawing.Color.Black;
            this.PNL_COUNTER_UNDERLINE.Location = new System.Drawing.Point(8, 25);
            this.PNL_COUNTER_UNDERLINE.Name = "PNL_COUNTER_UNDERLINE";
            this.PNL_COUNTER_UNDERLINE.Size = new System.Drawing.Size(150, 2);
            this.PNL_COUNTER_UNDERLINE.TabIndex = 32;
            // 
            // TBL_COUNTER
            // 
            this.TBL_COUNTER.AutoSize = true;
            this.TBL_COUNTER.ColumnCount = 2;
            this.TBL_COUNTER.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TBL_COUNTER.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TBL_COUNTER.Controls.Add(this.TB_RESET, 1, 2);
            this.TBL_COUNTER.Controls.Add(this.LBL_HOTKEYRESET, 0, 2);
            this.TBL_COUNTER.Controls.Add(this.CKB_EXPORT_COUNTER, 0, 0);
            this.TBL_COUNTER.Controls.Add(this.TB_PATH_COUNTER, 1, 0);
            this.TBL_COUNTER.Controls.Add(this.NMUD_RATIO, 1, 1);
            this.TBL_COUNTER.Controls.Add(this.LBL_RATIO, 0, 1);
            this.TBL_COUNTER.Location = new System.Drawing.Point(8, 29);
            this.TBL_COUNTER.Name = "TBL_COUNTER";
            this.TBL_COUNTER.RowCount = 3;
            this.TBL_COUNTER.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TBL_COUNTER.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TBL_COUNTER.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TBL_COUNTER.Size = new System.Drawing.Size(215, 81);
            this.TBL_COUNTER.TabIndex = 32;
            // 
            // TB_RESET
            // 
            this.TB_RESET.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TB_RESET.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TB_RESET.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_RESET.ForeColor = System.Drawing.Color.White;
            this.TB_RESET.Location = new System.Drawing.Point(80, 57);
            this.TB_RESET.Name = "TB_RESET";
            this.TB_RESET.ReadOnly = true;
            this.TB_RESET.Size = new System.Drawing.Size(114, 20);
            this.TB_RESET.TabIndex = 34;
            this.TB_RESET.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_RESET.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_RESET_KeyDown);
            // 
            // LBL_HOTKEYRESET
            // 
            this.LBL_HOTKEYRESET.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_HOTKEYRESET.AutoSize = true;
            this.LBL_HOTKEYRESET.Location = new System.Drawing.Point(3, 61);
            this.LBL_HOTKEYRESET.Name = "LBL_HOTKEYRESET";
            this.LBL_HOTKEYRESET.Size = new System.Drawing.Size(59, 12);
            this.LBL_HOTKEYRESET.TabIndex = 33;
            this.LBL_HOTKEYRESET.Text = "热键-重置";
            // 
            // CKB_EXPORT_COUNTER
            // 
            this.CKB_EXPORT_COUNTER.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CKB_EXPORT_COUNTER.AutoSize = true;
            this.CKB_EXPORT_COUNTER.Location = new System.Drawing.Point(3, 5);
            this.CKB_EXPORT_COUNTER.Name = "CKB_EXPORT_COUNTER";
            this.CKB_EXPORT_COUNTER.Size = new System.Drawing.Size(48, 16);
            this.CKB_EXPORT_COUNTER.TabIndex = 34;
            this.CKB_EXPORT_COUNTER.Text = "导出";
            this.CKB_EXPORT_COUNTER.UseVisualStyleBackColor = true;
            this.CKB_EXPORT_COUNTER.Click += new System.EventHandler(this.CKB_EXPORT_COUNTER_Click);
            // 
            // TB_PATH_COUNTER
            // 
            this.TB_PATH_COUNTER.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TB_PATH_COUNTER.BackColor = System.Drawing.SystemColors.Control;
            this.TB_PATH_COUNTER.Location = new System.Drawing.Point(80, 3);
            this.TB_PATH_COUNTER.Name = "TB_PATH_COUNTER";
            this.TB_PATH_COUNTER.ReadOnly = true;
            this.TB_PATH_COUNTER.Size = new System.Drawing.Size(114, 21);
            this.TB_PATH_COUNTER.TabIndex = 36;
            // 
            // NMUD_RATIO
            // 
            this.NMUD_RATIO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NMUD_RATIO.Location = new System.Drawing.Point(80, 30);
            this.NMUD_RATIO.Name = "NMUD_RATIO";
            this.NMUD_RATIO.Size = new System.Drawing.Size(68, 21);
            this.NMUD_RATIO.TabIndex = 37;
            // 
            // LBL_RATIO
            // 
            this.LBL_RATIO.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_RATIO.AutoSize = true;
            this.LBL_RATIO.Location = new System.Drawing.Point(3, 34);
            this.LBL_RATIO.Name = "LBL_RATIO";
            this.LBL_RATIO.Size = new System.Drawing.Size(71, 12);
            this.LBL_RATIO.TabIndex = 38;
            this.LBL_RATIO.Text = "计数每次+/-";
            // 
            // LBL_COUNTER
            // 
            this.LBL_COUNTER.AutoSize = true;
            this.LBL_COUNTER.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_COUNTER.Location = new System.Drawing.Point(7, 7);
            this.LBL_COUNTER.Name = "LBL_COUNTER";
            this.LBL_COUNTER.Size = new System.Drawing.Size(39, 16);
            this.LBL_COUNTER.TabIndex = 25;
            this.LBL_COUNTER.Text = "计数";
            // 
            // PNL_PICTURE
            // 
            this.PNL_PICTURE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PNL_PICTURE.Controls.Add(this.PNL_PICTURE_UNDERLINE);
            this.PNL_PICTURE.Controls.Add(this.TBL_PICTURE);
            this.PNL_PICTURE.Controls.Add(this.LBL_PICTURE);
            this.PNL_PICTURE.Location = new System.Drawing.Point(7, 83);
            this.PNL_PICTURE.Name = "PNL_PICTURE";
            this.PNL_PICTURE.Size = new System.Drawing.Size(220, 73);
            this.PNL_PICTURE.TabIndex = 33;
            // 
            // PNL_PICTURE_UNDERLINE
            // 
            this.PNL_PICTURE_UNDERLINE.BackColor = System.Drawing.Color.Black;
            this.PNL_PICTURE_UNDERLINE.Location = new System.Drawing.Point(8, 25);
            this.PNL_PICTURE_UNDERLINE.Name = "PNL_PICTURE_UNDERLINE";
            this.PNL_PICTURE_UNDERLINE.Size = new System.Drawing.Size(150, 2);
            this.PNL_PICTURE_UNDERLINE.TabIndex = 32;
            // 
            // TBL_PICTURE
            // 
            this.TBL_PICTURE.AutoSize = true;
            this.TBL_PICTURE.ColumnCount = 2;
            this.TBL_PICTURE.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TBL_PICTURE.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TBL_PICTURE.Controls.Add(this.TB_PATH_PICTURE, 1, 0);
            this.TBL_PICTURE.Controls.Add(this.CKB_IMPORT_PICTURE, 0, 0);
            this.TBL_PICTURE.Location = new System.Drawing.Point(8, 29);
            this.TBL_PICTURE.Name = "TBL_PICTURE";
            this.TBL_PICTURE.RowCount = 1;
            this.TBL_PICTURE.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TBL_PICTURE.Size = new System.Drawing.Size(195, 32);
            this.TBL_PICTURE.TabIndex = 32;
            // 
            // TB_PATH_PICTURE
            // 
            this.TB_PATH_PICTURE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TB_PATH_PICTURE.BackColor = System.Drawing.SystemColors.Control;
            this.TB_PATH_PICTURE.Location = new System.Drawing.Point(57, 5);
            this.TB_PATH_PICTURE.Name = "TB_PATH_PICTURE";
            this.TB_PATH_PICTURE.ReadOnly = true;
            this.TB_PATH_PICTURE.Size = new System.Drawing.Size(100, 21);
            this.TB_PATH_PICTURE.TabIndex = 35;
            // 
            // CKB_IMPORT_PICTURE
            // 
            this.CKB_IMPORT_PICTURE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CKB_IMPORT_PICTURE.AutoSize = true;
            this.CKB_IMPORT_PICTURE.Location = new System.Drawing.Point(3, 8);
            this.CKB_IMPORT_PICTURE.Name = "CKB_IMPORT_PICTURE";
            this.CKB_IMPORT_PICTURE.Size = new System.Drawing.Size(48, 16);
            this.CKB_IMPORT_PICTURE.TabIndex = 34;
            this.CKB_IMPORT_PICTURE.Text = "导入";
            this.CKB_IMPORT_PICTURE.UseVisualStyleBackColor = true;
            this.CKB_IMPORT_PICTURE.Click += new System.EventHandler(this.CKB_IMPORT_PICTURE_Click);
            // 
            // LBL_PICTURE
            // 
            this.LBL_PICTURE.AutoSize = true;
            this.LBL_PICTURE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PICTURE.Location = new System.Drawing.Point(7, 7);
            this.LBL_PICTURE.Name = "LBL_PICTURE";
            this.LBL_PICTURE.Size = new System.Drawing.Size(39, 16);
            this.LBL_PICTURE.TabIndex = 25;
            this.LBL_PICTURE.Text = "图片";
            // 
            // BT_CANCEL
            // 
            this.BT_CANCEL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BT_CANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CANCEL.ForeColor = System.Drawing.Color.White;
            this.BT_CANCEL.Location = new System.Drawing.Point(346, 122);
            this.BT_CANCEL.Name = "BT_CANCEL";
            this.BT_CANCEL.Size = new System.Drawing.Size(107, 34);
            this.BT_CANCEL.TabIndex = 27;
            this.BT_CANCEL.Text = "取消";
            this.BT_CANCEL.UseVisualStyleBackColor = false;
            this.BT_CANCEL.Click += new System.EventHandler(this.BT_CANCEL_Click);
            // 
            // BT_APPLY
            // 
            this.BT_APPLY.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BT_APPLY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_APPLY.ForeColor = System.Drawing.Color.White;
            this.BT_APPLY.Location = new System.Drawing.Point(233, 122);
            this.BT_APPLY.Name = "BT_APPLY";
            this.BT_APPLY.Size = new System.Drawing.Size(107, 34);
            this.BT_APPLY.TabIndex = 26;
            this.BT_APPLY.Text = "应用";
            this.BT_APPLY.UseVisualStyleBackColor = false;
            this.BT_APPLY.Click += new System.EventHandler(this.BT_APPLY_Click);
            // 
            // PkmnProperties2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 195);
            this.Controls.Add(this.PNL_CONTENT);
            this.Controls.Add(this.PNL_MENU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PkmnProperties2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PkmnProperties2";
            this.PNL_MENU.ResumeLayout(false);
            this.PNL_CONTENT.ResumeLayout(false);
            this.PNL_HUNT.ResumeLayout(false);
            this.PNL_HUNT.PerformLayout();
            this.TBL_HUNT.ResumeLayout(false);
            this.TBL_HUNT.PerformLayout();
            this.PNL_COUNTER.ResumeLayout(false);
            this.PNL_COUNTER.PerformLayout();
            this.TBL_COUNTER.ResumeLayout(false);
            this.TBL_COUNTER.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NMUD_RATIO)).EndInit();
            this.PNL_PICTURE.ResumeLayout(false);
            this.PNL_PICTURE.PerformLayout();
            this.TBL_PICTURE.ResumeLayout(false);
            this.TBL_PICTURE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel PNL_MENU;
        private System.Windows.Forms.Button BT_MINIMIZE;
        private System.Windows.Forms.Button BT_CLOSE;
        private System.Windows.Forms.Panel PNL_CONTENT;
        private System.Windows.Forms.Panel PNL_COUNTER;
        private System.Windows.Forms.Panel PNL_COUNTER_UNDERLINE;
        private System.Windows.Forms.TableLayoutPanel TBL_COUNTER;
        public System.Windows.Forms.CheckBox CKB_EXPORT_COUNTER;
        public System.Windows.Forms.TextBox TB_PATH_COUNTER;
        private System.Windows.Forms.Label LBL_COUNTER;
        private System.Windows.Forms.Panel PNL_PICTURE;
        private System.Windows.Forms.Panel PNL_PICTURE_UNDERLINE;
        private System.Windows.Forms.TableLayoutPanel TBL_PICTURE;
        private System.Windows.Forms.Label LBL_PICTURE;
        private System.Windows.Forms.Button BT_CANCEL;
        private System.Windows.Forms.Button BT_APPLY;
        private System.Windows.Forms.Label LBL_RATIO;
        public System.Windows.Forms.TextBox TB_PATH_PICTURE;
        public System.Windows.Forms.CheckBox CKB_IMPORT_PICTURE;
        public System.Windows.Forms.NumericUpDown NMUD_RATIO;
        private System.Windows.Forms.Panel PNL_HUNT;
        private System.Windows.Forms.Panel PNL_HUNT_UNDERLINE;
        private System.Windows.Forms.TableLayoutPanel TBL_HUNT;
        public System.Windows.Forms.CheckBox CKB_AUTOSAVE;
        private System.Windows.Forms.Label LBL_HUNT;
        public System.Windows.Forms.TextBox TB_RESET;
        private System.Windows.Forms.Label LBL_HOTKEYRESET;
    }
}