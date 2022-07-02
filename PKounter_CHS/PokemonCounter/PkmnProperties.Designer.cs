namespace PokemonCounter
{
    partial class PkmnProperties
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PkmnProperties));
            this.NMUD_COUNTER = new System.Windows.Forms.NumericUpDown();
            this.LBL_ENCOUNTERS = new System.Windows.Forms.Label();
            this.CB_POKE = new System.Windows.Forms.ComboBox();
            this.CKB_SHINY = new System.Windows.Forms.CheckBox();
            this.CKB_GIF = new System.Windows.Forms.CheckBox();
            this.CKB_ORDER = new System.Windows.Forms.CheckBox();
            this.CB_GEN = new System.Windows.Forms.ComboBox();
            this.LBL_SPECIES = new System.Windows.Forms.Label();
            this.LBL_GEN = new System.Windows.Forms.Label();
            this.LBL_GAME = new System.Windows.Forms.Label();
            this.CB_GAME = new System.Windows.Forms.ComboBox();
            this.TB_SUS = new System.Windows.Forms.TextBox();
            this.TB_ADD = new System.Windows.Forms.TextBox();
            this.LBL_HOTKEYSUB = new System.Windows.Forms.Label();
            this.LBL_HOTKEYADD = new System.Windows.Forms.Label();
            this.BT_APPLY = new System.Windows.Forms.Button();
            this.BT_CANCEL = new System.Windows.Forms.Button();
            this.PNL_MENU = new System.Windows.Forms.Panel();
            this.BT_MINIMIZE = new System.Windows.Forms.Button();
            this.BT_CLOSE = new System.Windows.Forms.Button();
            this.PNL_CONTENT = new System.Windows.Forms.Panel();
            this.BT_ADVANCED = new System.Windows.Forms.Button();
            this.PBX_COMPLETE = new System.Windows.Forms.PictureBox();
            this.BT_LOAD = new System.Windows.Forms.Button();
            this.BT_SAVE = new System.Windows.Forms.Button();
            this.PNL_PREVIEW = new System.Windows.Forms.Panel();
            this.PNL_PREVIEW_UNDERLINE = new System.Windows.Forms.Panel();
            this.LBL_PREVIEW = new System.Windows.Forms.Label();
            this.PNL_PREVIEW_CHILD = new System.Windows.Forms.Panel();
            this.BT_COUNTER_ADD = new System.Windows.Forms.Button();
            this.BT_COUNTER_SUB = new System.Windows.Forms.Button();
            this.LBL_PREVIEW_NAME = new System.Windows.Forms.Label();
            this.LBL_PREVIEW_COUNTER = new System.Windows.Forms.Label();
            this.PBX_PREVIEW = new System.Windows.Forms.PictureBox();
            this.PNL_COUNTER = new System.Windows.Forms.Panel();
            this.PNL_COUNTER_UNDERLINE = new System.Windows.Forms.Panel();
            this.TBL_COUNTER = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_COUNTER = new System.Windows.Forms.Label();
            this.PNL_PICTURE = new System.Windows.Forms.Panel();
            this.PNL_PICTURE_UNDERLINE = new System.Windows.Forms.Panel();
            this.TBL_PICTURE = new System.Windows.Forms.TableLayoutPanel();
            this.LBL_PICTURE = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NMUD_COUNTER)).BeginInit();
            this.PNL_MENU.SuspendLayout();
            this.PNL_CONTENT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_COMPLETE)).BeginInit();
            this.PNL_PREVIEW.SuspendLayout();
            this.PNL_PREVIEW_CHILD.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBX_PREVIEW)).BeginInit();
            this.PNL_COUNTER.SuspendLayout();
            this.TBL_COUNTER.SuspendLayout();
            this.PNL_PICTURE.SuspendLayout();
            this.TBL_PICTURE.SuspendLayout();
            this.SuspendLayout();
            // 
            // NMUD_COUNTER
            // 
            this.NMUD_COUNTER.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.NMUD_COUNTER.Location = new System.Drawing.Point(92, 3);
            this.NMUD_COUNTER.Maximum = new decimal(new int[] {
            -727379969,
            232,
            0,
            0});
            this.NMUD_COUNTER.Name = "NMUD_COUNTER";
            this.NMUD_COUNTER.Size = new System.Drawing.Size(68, 21);
            this.NMUD_COUNTER.TabIndex = 19;
            this.NMUD_COUNTER.ValueChanged += new System.EventHandler(this.NMUD_COUNTER_ValueChanged);
            // 
            // LBL_ENCOUNTERS
            // 
            this.LBL_ENCOUNTERS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_ENCOUNTERS.AutoSize = true;
            this.LBL_ENCOUNTERS.Location = new System.Drawing.Point(3, 7);
            this.LBL_ENCOUNTERS.Name = "LBL_ENCOUNTERS";
            this.LBL_ENCOUNTERS.Size = new System.Drawing.Size(29, 12);
            this.LBL_ENCOUNTERS.TabIndex = 17;
            this.LBL_ENCOUNTERS.Text = "计数";
            // 
            // CB_POKE
            // 
            this.CB_POKE.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CB_POKE.FormattingEnabled = true;
            this.CB_POKE.Location = new System.Drawing.Point(57, 3);
            this.CB_POKE.Name = "CB_POKE";
            this.CB_POKE.Size = new System.Drawing.Size(114, 20);
            this.CB_POKE.TabIndex = 11;
            this.CB_POKE.SelectedIndexChanged += new System.EventHandler(this.CB_POKE_SelectedIndexChanged);
            // 
            // CKB_SHINY
            // 
            this.CKB_SHINY.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CKB_SHINY.AutoSize = true;
            this.CKB_SHINY.Location = new System.Drawing.Point(3, 32);
            this.CKB_SHINY.Name = "CKB_SHINY";
            this.CKB_SHINY.Size = new System.Drawing.Size(48, 16);
            this.CKB_SHINY.TabIndex = 4;
            this.CKB_SHINY.Text = "闪光";
            this.CKB_SHINY.UseVisualStyleBackColor = true;
            this.CKB_SHINY.CheckedChanged += new System.EventHandler(this.CKB_SHINY_CheckedChanged);
            // 
            // CKB_GIF
            // 
            this.CKB_GIF.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CKB_GIF.AutoSize = true;
            this.CKB_GIF.Location = new System.Drawing.Point(3, 59);
            this.CKB_GIF.Name = "CKB_GIF";
            this.CKB_GIF.Size = new System.Drawing.Size(42, 16);
            this.CKB_GIF.TabIndex = 5;
            this.CKB_GIF.Text = "GIF";
            this.CKB_GIF.UseVisualStyleBackColor = true;
            this.CKB_GIF.CheckedChanged += new System.EventHandler(this.CKB_GIF_CheckedChanged);
            // 
            // CKB_ORDER
            // 
            this.CKB_ORDER.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.CKB_ORDER.AutoSize = true;
            this.CKB_ORDER.Location = new System.Drawing.Point(150, 32);
            this.CKB_ORDER.Name = "CKB_ORDER";
            this.CKB_ORDER.Size = new System.Drawing.Size(42, 16);
            this.CKB_ORDER.TabIndex = 13;
            this.CKB_ORDER.Text = "A-Z";
            this.CKB_ORDER.UseVisualStyleBackColor = true;
            this.CKB_ORDER.CheckedChanged += new System.EventHandler(this.CKB_ORDER_CheckedChanged);
            // 
            // CB_GEN
            // 
            this.CB_GEN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CB_GEN.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CB_GEN.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_GEN.ForeColor = System.Drawing.Color.White;
            this.CB_GEN.FormattingEnabled = true;
            this.CB_GEN.Location = new System.Drawing.Point(57, 84);
            this.CB_GEN.Name = "CB_GEN";
            this.CB_GEN.Size = new System.Drawing.Size(114, 20);
            this.CB_GEN.TabIndex = 6;
            this.CB_GEN.SelectedIndexChanged += new System.EventHandler(this.CB_GEN_SelectedIndexChanged);
            // 
            // LBL_SPECIES
            // 
            this.LBL_SPECIES.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_SPECIES.AutoSize = true;
            this.LBL_SPECIES.Location = new System.Drawing.Point(3, 7);
            this.LBL_SPECIES.Name = "LBL_SPECIES";
            this.LBL_SPECIES.Size = new System.Drawing.Size(29, 12);
            this.LBL_SPECIES.TabIndex = 12;
            this.LBL_SPECIES.Text = "种族";
            // 
            // LBL_GEN
            // 
            this.LBL_GEN.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_GEN.AutoSize = true;
            this.LBL_GEN.Location = new System.Drawing.Point(3, 88);
            this.LBL_GEN.Name = "LBL_GEN";
            this.LBL_GEN.Size = new System.Drawing.Size(29, 12);
            this.LBL_GEN.TabIndex = 7;
            this.LBL_GEN.Text = "世代";
            // 
            // LBL_GAME
            // 
            this.LBL_GAME.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_GAME.AutoSize = true;
            this.LBL_GAME.Location = new System.Drawing.Point(3, 117);
            this.LBL_GAME.Name = "LBL_GAME";
            this.LBL_GAME.Size = new System.Drawing.Size(29, 12);
            this.LBL_GAME.TabIndex = 10;
            this.LBL_GAME.Text = "游戏";
            // 
            // CB_GAME
            // 
            this.CB_GAME.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.CB_GAME.BackColor = System.Drawing.SystemColors.ControlDark;
            this.CB_GAME.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_GAME.ForeColor = System.Drawing.Color.White;
            this.CB_GAME.FormattingEnabled = true;
            this.CB_GAME.Location = new System.Drawing.Point(57, 113);
            this.CB_GAME.Name = "CB_GAME";
            this.CB_GAME.Size = new System.Drawing.Size(114, 20);
            this.CB_GAME.TabIndex = 9;
            this.CB_GAME.SelectedIndexChanged += new System.EventHandler(this.CB_GAME_SelectedIndexChanged);
            // 
            // TB_SUS
            // 
            this.TB_SUS.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TB_SUS.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TB_SUS.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_SUS.ForeColor = System.Drawing.Color.White;
            this.TB_SUS.Location = new System.Drawing.Point(92, 57);
            this.TB_SUS.Name = "TB_SUS";
            this.TB_SUS.ReadOnly = true;
            this.TB_SUS.Size = new System.Drawing.Size(114, 20);
            this.TB_SUS.TabIndex = 19;
            this.TB_SUS.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_SUS.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_SUS_KeyDown);
            // 
            // TB_ADD
            // 
            this.TB_ADD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.TB_ADD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.TB_ADD.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_ADD.ForeColor = System.Drawing.Color.White;
            this.TB_ADD.Location = new System.Drawing.Point(92, 30);
            this.TB_ADD.Name = "TB_ADD";
            this.TB_ADD.ReadOnly = true;
            this.TB_ADD.Size = new System.Drawing.Size(114, 20);
            this.TB_ADD.TabIndex = 18;
            this.TB_ADD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_ADD.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TB_ADD_KeyDown);
            // 
            // LBL_HOTKEYSUB
            // 
            this.LBL_HOTKEYSUB.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_HOTKEYSUB.AutoSize = true;
            this.LBL_HOTKEYSUB.Location = new System.Drawing.Point(3, 61);
            this.LBL_HOTKEYSUB.Name = "LBL_HOTKEYSUB";
            this.LBL_HOTKEYSUB.Size = new System.Drawing.Size(83, 12);
            this.LBL_HOTKEYSUB.TabIndex = 17;
            this.LBL_HOTKEYSUB.Text = "热键-减少计数";
            // 
            // LBL_HOTKEYADD
            // 
            this.LBL_HOTKEYADD.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.LBL_HOTKEYADD.AutoSize = true;
            this.LBL_HOTKEYADD.Location = new System.Drawing.Point(3, 34);
            this.LBL_HOTKEYADD.Name = "LBL_HOTKEYADD";
            this.LBL_HOTKEYADD.Size = new System.Drawing.Size(83, 12);
            this.LBL_HOTKEYADD.TabIndex = 16;
            this.LBL_HOTKEYADD.Text = "热键-增加计数";
            // 
            // BT_APPLY
            // 
            this.BT_APPLY.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BT_APPLY.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_APPLY.ForeColor = System.Drawing.Color.White;
            this.BT_APPLY.Location = new System.Drawing.Point(226, 269);
            this.BT_APPLY.Name = "BT_APPLY";
            this.BT_APPLY.Size = new System.Drawing.Size(109, 67);
            this.BT_APPLY.TabIndex = 26;
            this.BT_APPLY.Text = "应用";
            this.BT_APPLY.UseVisualStyleBackColor = false;
            this.BT_APPLY.Click += new System.EventHandler(this.BT_APPLY_Click);
            // 
            // BT_CANCEL
            // 
            this.BT_CANCEL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BT_CANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CANCEL.ForeColor = System.Drawing.Color.White;
            this.BT_CANCEL.Location = new System.Drawing.Point(341, 269);
            this.BT_CANCEL.Name = "BT_CANCEL";
            this.BT_CANCEL.Size = new System.Drawing.Size(107, 67);
            this.BT_CANCEL.TabIndex = 27;
            this.BT_CANCEL.Text = "取消";
            this.BT_CANCEL.UseVisualStyleBackColor = false;
            this.BT_CANCEL.Click += new System.EventHandler(this.BT_CANCEL_Click);
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
            this.PNL_MENU.Size = new System.Drawing.Size(454, 32);
            this.PNL_MENU.TabIndex = 28;
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
            this.BT_MINIMIZE.Location = new System.Drawing.Point(390, 5);
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
            this.BT_CLOSE.Location = new System.Drawing.Point(421, 5);
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
            this.PNL_CONTENT.Controls.Add(this.BT_ADVANCED);
            this.PNL_CONTENT.Controls.Add(this.PBX_COMPLETE);
            this.PNL_CONTENT.Controls.Add(this.BT_LOAD);
            this.PNL_CONTENT.Controls.Add(this.BT_SAVE);
            this.PNL_CONTENT.Controls.Add(this.PNL_PREVIEW);
            this.PNL_CONTENT.Controls.Add(this.PNL_COUNTER);
            this.PNL_CONTENT.Controls.Add(this.PNL_PICTURE);
            this.PNL_CONTENT.Controls.Add(this.BT_CANCEL);
            this.PNL_CONTENT.Controls.Add(this.BT_APPLY);
            this.PNL_CONTENT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_CONTENT.Location = new System.Drawing.Point(0, 32);
            this.PNL_CONTENT.Name = "PNL_CONTENT";
            this.PNL_CONTENT.Size = new System.Drawing.Size(454, 341);
            this.PNL_CONTENT.TabIndex = 29;
            // 
            // BT_ADVANCED
            // 
            this.BT_ADVANCED.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BT_ADVANCED.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ADVANCED.ForeColor = System.Drawing.Color.White;
            this.BT_ADVANCED.Location = new System.Drawing.Point(227, 6);
            this.BT_ADVANCED.Name = "BT_ADVANCED";
            this.BT_ADVANCED.Size = new System.Drawing.Size(106, 28);
            this.BT_ADVANCED.TabIndex = 37;
            this.BT_ADVANCED.Text = "高级设置";
            this.BT_ADVANCED.UseVisualStyleBackColor = false;
            this.BT_ADVANCED.Click += new System.EventHandler(this.BT_ADVANCED_Click);
            // 
            // PBX_COMPLETE
            // 
            this.PBX_COMPLETE.BackColor = System.Drawing.Color.Transparent;
            this.PBX_COMPLETE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBX_COMPLETE.Image = global::PokemonCounter.Properties.Resources.crown_bw;
            this.PBX_COMPLETE.Location = new System.Drawing.Point(366, 5);
            this.PBX_COMPLETE.Name = "PBX_COMPLETE";
            this.PBX_COMPLETE.Size = new System.Drawing.Size(51, 28);
            this.PBX_COMPLETE.TabIndex = 36;
            this.PBX_COMPLETE.TabStop = false;
            this.PBX_COMPLETE.Click += new System.EventHandler(this.PBX_COMPLETE_Click);
            // 
            // BT_LOAD
            // 
            this.BT_LOAD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BT_LOAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_LOAD.ForeColor = System.Drawing.Color.White;
            this.BT_LOAD.Location = new System.Drawing.Point(115, 5);
            this.BT_LOAD.Name = "BT_LOAD";
            this.BT_LOAD.Size = new System.Drawing.Size(106, 28);
            this.BT_LOAD.TabIndex = 35;
            this.BT_LOAD.Text = "读取";
            this.BT_LOAD.UseVisualStyleBackColor = false;
            this.BT_LOAD.Click += new System.EventHandler(this.BT_LOAD_Click);
            // 
            // BT_SAVE
            // 
            this.BT_SAVE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BT_SAVE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_SAVE.ForeColor = System.Drawing.Color.White;
            this.BT_SAVE.Location = new System.Drawing.Point(5, 5);
            this.BT_SAVE.Name = "BT_SAVE";
            this.BT_SAVE.Size = new System.Drawing.Size(106, 28);
            this.BT_SAVE.TabIndex = 34;
            this.BT_SAVE.Text = "保存";
            this.BT_SAVE.UseVisualStyleBackColor = false;
            this.BT_SAVE.Click += new System.EventHandler(this.BT_SAVE_Click);
            // 
            // PNL_PREVIEW
            // 
            this.PNL_PREVIEW.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PNL_PREVIEW.Controls.Add(this.PNL_PREVIEW_UNDERLINE);
            this.PNL_PREVIEW.Controls.Add(this.LBL_PREVIEW);
            this.PNL_PREVIEW.Controls.Add(this.PNL_PREVIEW_CHILD);
            this.PNL_PREVIEW.Location = new System.Drawing.Point(227, 39);
            this.PNL_PREVIEW.Name = "PNL_PREVIEW";
            this.PNL_PREVIEW.Size = new System.Drawing.Size(220, 224);
            this.PNL_PREVIEW.TabIndex = 33;
            // 
            // PNL_PREVIEW_UNDERLINE
            // 
            this.PNL_PREVIEW_UNDERLINE.BackColor = System.Drawing.Color.Black;
            this.PNL_PREVIEW_UNDERLINE.Location = new System.Drawing.Point(8, 25);
            this.PNL_PREVIEW_UNDERLINE.Name = "PNL_PREVIEW_UNDERLINE";
            this.PNL_PREVIEW_UNDERLINE.Size = new System.Drawing.Size(150, 2);
            this.PNL_PREVIEW_UNDERLINE.TabIndex = 32;
            // 
            // LBL_PREVIEW
            // 
            this.LBL_PREVIEW.AutoSize = true;
            this.LBL_PREVIEW.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_PREVIEW.Location = new System.Drawing.Point(7, 7);
            this.LBL_PREVIEW.Name = "LBL_PREVIEW";
            this.LBL_PREVIEW.Size = new System.Drawing.Size(39, 16);
            this.LBL_PREVIEW.TabIndex = 25;
            this.LBL_PREVIEW.Text = "预览";
            // 
            // PNL_PREVIEW_CHILD
            // 
            this.PNL_PREVIEW_CHILD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PNL_PREVIEW_CHILD.Controls.Add(this.BT_COUNTER_ADD);
            this.PNL_PREVIEW_CHILD.Controls.Add(this.BT_COUNTER_SUB);
            this.PNL_PREVIEW_CHILD.Controls.Add(this.LBL_PREVIEW_NAME);
            this.PNL_PREVIEW_CHILD.Controls.Add(this.LBL_PREVIEW_COUNTER);
            this.PNL_PREVIEW_CHILD.Controls.Add(this.PBX_PREVIEW);
            this.PNL_PREVIEW_CHILD.Location = new System.Drawing.Point(10, 32);
            this.PNL_PREVIEW_CHILD.Name = "PNL_PREVIEW_CHILD";
            this.PNL_PREVIEW_CHILD.Size = new System.Drawing.Size(200, 185);
            this.PNL_PREVIEW_CHILD.TabIndex = 23;
            // 
            // BT_COUNTER_ADD
            // 
            this.BT_COUNTER_ADD.BackColor = System.Drawing.Color.LightGray;
            this.BT_COUNTER_ADD.Image = global::PokemonCounter.Properties.Resources.counteradd;
            this.BT_COUNTER_ADD.Location = new System.Drawing.Point(55, 162);
            this.BT_COUNTER_ADD.Name = "BT_COUNTER_ADD";
            this.BT_COUNTER_ADD.Size = new System.Drawing.Size(30, 21);
            this.BT_COUNTER_ADD.TabIndex = 26;
            this.BT_COUNTER_ADD.UseVisualStyleBackColor = false;
            this.BT_COUNTER_ADD.Click += new System.EventHandler(this.BT_COUNTER_ADD_Click);
            // 
            // BT_COUNTER_SUB
            // 
            this.BT_COUNTER_SUB.BackColor = System.Drawing.Color.LightGray;
            this.BT_COUNTER_SUB.Image = global::PokemonCounter.Properties.Resources.countersub;
            this.BT_COUNTER_SUB.Location = new System.Drawing.Point(25, 162);
            this.BT_COUNTER_SUB.Name = "BT_COUNTER_SUB";
            this.BT_COUNTER_SUB.Size = new System.Drawing.Size(30, 21);
            this.BT_COUNTER_SUB.TabIndex = 25;
            this.BT_COUNTER_SUB.UseVisualStyleBackColor = false;
            this.BT_COUNTER_SUB.Click += new System.EventHandler(this.BT_COUNTER_SUB_Click);
            // 
            // LBL_PREVIEW_NAME
            // 
            this.LBL_PREVIEW_NAME.Location = new System.Drawing.Point(25, 0);
            this.LBL_PREVIEW_NAME.Name = "LBL_PREVIEW_NAME";
            this.LBL_PREVIEW_NAME.Size = new System.Drawing.Size(150, 23);
            this.LBL_PREVIEW_NAME.TabIndex = 24;
            this.LBL_PREVIEW_NAME.Text = "宝可梦名字";
            this.LBL_PREVIEW_NAME.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LBL_PREVIEW_COUNTER
            // 
            this.LBL_PREVIEW_COUNTER.Location = new System.Drawing.Point(25, 162);
            this.LBL_PREVIEW_COUNTER.Name = "LBL_PREVIEW_COUNTER";
            this.LBL_PREVIEW_COUNTER.Size = new System.Drawing.Size(150, 23);
            this.LBL_PREVIEW_COUNTER.TabIndex = 23;
            this.LBL_PREVIEW_COUNTER.Text = "计数";
            this.LBL_PREVIEW_COUNTER.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PBX_PREVIEW
            // 
            this.PBX_PREVIEW.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PBX_PREVIEW.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PBX_PREVIEW.Location = new System.Drawing.Point(25, 23);
            this.PBX_PREVIEW.MaximumSize = new System.Drawing.Size(150, 139);
            this.PBX_PREVIEW.Name = "PBX_PREVIEW";
            this.PBX_PREVIEW.Size = new System.Drawing.Size(150, 139);
            this.PBX_PREVIEW.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBX_PREVIEW.TabIndex = 22;
            this.PBX_PREVIEW.TabStop = false;
            // 
            // PNL_COUNTER
            // 
            this.PNL_COUNTER.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.PNL_COUNTER.Controls.Add(this.PNL_COUNTER_UNDERLINE);
            this.PNL_COUNTER.Controls.Add(this.TBL_COUNTER);
            this.PNL_COUNTER.Controls.Add(this.LBL_COUNTER);
            this.PNL_COUNTER.Location = new System.Drawing.Point(5, 218);
            this.PNL_COUNTER.Name = "PNL_COUNTER";
            this.PNL_COUNTER.Size = new System.Drawing.Size(216, 116);
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
            this.TBL_COUNTER.Controls.Add(this.TB_SUS, 1, 2);
            this.TBL_COUNTER.Controls.Add(this.LBL_HOTKEYSUB, 0, 2);
            this.TBL_COUNTER.Controls.Add(this.LBL_HOTKEYADD, 0, 1);
            this.TBL_COUNTER.Controls.Add(this.TB_ADD, 1, 1);
            this.TBL_COUNTER.Controls.Add(this.NMUD_COUNTER, 1, 0);
            this.TBL_COUNTER.Controls.Add(this.LBL_ENCOUNTERS, 0, 0);
            this.TBL_COUNTER.Location = new System.Drawing.Point(8, 29);
            this.TBL_COUNTER.Name = "TBL_COUNTER";
            this.TBL_COUNTER.RowCount = 3;
            this.TBL_COUNTER.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TBL_COUNTER.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TBL_COUNTER.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.TBL_COUNTER.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.TBL_COUNTER.Size = new System.Drawing.Size(209, 81);
            this.TBL_COUNTER.TabIndex = 32;
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
            this.PNL_PICTURE.Location = new System.Drawing.Point(5, 39);
            this.PNL_PICTURE.Name = "PNL_PICTURE";
            this.PNL_PICTURE.Size = new System.Drawing.Size(216, 174);
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
            this.TBL_PICTURE.Controls.Add(this.CB_GEN, 1, 3);
            this.TBL_PICTURE.Controls.Add(this.CB_GAME, 1, 4);
            this.TBL_PICTURE.Controls.Add(this.CKB_GIF, 0, 2);
            this.TBL_PICTURE.Controls.Add(this.LBL_GAME, 0, 4);
            this.TBL_PICTURE.Controls.Add(this.LBL_GEN, 0, 3);
            this.TBL_PICTURE.Controls.Add(this.CKB_SHINY, 0, 1);
            this.TBL_PICTURE.Controls.Add(this.CB_POKE, 1, 0);
            this.TBL_PICTURE.Controls.Add(this.CKB_ORDER, 1, 1);
            this.TBL_PICTURE.Controls.Add(this.LBL_SPECIES, 0, 0);
            this.TBL_PICTURE.Location = new System.Drawing.Point(8, 29);
            this.TBL_PICTURE.Name = "TBL_PICTURE";
            this.TBL_PICTURE.RowCount = 5;
            this.TBL_PICTURE.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TBL_PICTURE.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TBL_PICTURE.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TBL_PICTURE.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TBL_PICTURE.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.5F));
            this.TBL_PICTURE.Size = new System.Drawing.Size(195, 138);
            this.TBL_PICTURE.TabIndex = 32;
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
            // PkmnProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 373);
            this.Controls.Add(this.PNL_CONTENT);
            this.Controls.Add(this.PNL_MENU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PkmnProperties";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = " Properties";
            this.Load += new System.EventHandler(this.PkmnProperties_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NMUD_COUNTER)).EndInit();
            this.PNL_MENU.ResumeLayout(false);
            this.PNL_CONTENT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_COMPLETE)).EndInit();
            this.PNL_PREVIEW.ResumeLayout(false);
            this.PNL_PREVIEW.PerformLayout();
            this.PNL_PREVIEW_CHILD.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PBX_PREVIEW)).EndInit();
            this.PNL_COUNTER.ResumeLayout(false);
            this.PNL_COUNTER.PerformLayout();
            this.TBL_COUNTER.ResumeLayout(false);
            this.TBL_COUNTER.PerformLayout();
            this.PNL_PICTURE.ResumeLayout(false);
            this.PNL_PICTURE.PerformLayout();
            this.TBL_PICTURE.ResumeLayout(false);
            this.TBL_PICTURE.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label LBL_ENCOUNTERS;
        private System.Windows.Forms.Label LBL_SPECIES;
        private System.Windows.Forms.Label LBL_GEN;
        private System.Windows.Forms.Label LBL_GAME;
        private System.Windows.Forms.Label LBL_HOTKEYSUB;
        private System.Windows.Forms.Label LBL_HOTKEYADD;
        private System.Windows.Forms.Button BT_APPLY;
        private System.Windows.Forms.Button BT_CANCEL;
        private System.Windows.Forms.Panel PNL_MENU;
        private System.Windows.Forms.Panel PNL_CONTENT;
        private System.Windows.Forms.Button BT_MINIMIZE;
        private System.Windows.Forms.Button BT_CLOSE;
        public System.Windows.Forms.ComboBox CB_POKE;
        public System.Windows.Forms.CheckBox CKB_SHINY;
        public System.Windows.Forms.CheckBox CKB_GIF;
        public System.Windows.Forms.CheckBox CKB_ORDER;
        public System.Windows.Forms.ComboBox CB_GEN;
        public System.Windows.Forms.ComboBox CB_GAME;
        public System.Windows.Forms.TextBox TB_SUS;
        public System.Windows.Forms.TextBox TB_ADD;
        public System.Windows.Forms.NumericUpDown NMUD_COUNTER;
        private System.Windows.Forms.Panel PNL_COUNTER;
        private System.Windows.Forms.Label LBL_COUNTER;
        private System.Windows.Forms.Panel PNL_PREVIEW_CHILD;
        private System.Windows.Forms.Button BT_COUNTER_ADD;
        private System.Windows.Forms.Button BT_COUNTER_SUB;
        private System.Windows.Forms.Label LBL_PREVIEW_NAME;
        private System.Windows.Forms.Label LBL_PREVIEW_COUNTER;
        private System.Windows.Forms.TableLayoutPanel TBL_COUNTER;
        private System.Windows.Forms.Panel PNL_COUNTER_UNDERLINE;
        private System.Windows.Forms.Panel PNL_PICTURE;
        private System.Windows.Forms.Panel PNL_PICTURE_UNDERLINE;
        private System.Windows.Forms.TableLayoutPanel TBL_PICTURE;
        private System.Windows.Forms.Label LBL_PICTURE;
        private System.Windows.Forms.Panel PNL_PREVIEW;
        private System.Windows.Forms.Panel PNL_PREVIEW_UNDERLINE;
        private System.Windows.Forms.Label LBL_PREVIEW;
        private System.Windows.Forms.Button BT_LOAD;
        private System.Windows.Forms.Button BT_SAVE;
        public System.Windows.Forms.PictureBox PBX_COMPLETE;
        public System.Windows.Forms.PictureBox PBX_PREVIEW;
        private System.Windows.Forms.Button BT_ADVANCED;
    }
}