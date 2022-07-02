namespace PokemonCounter
{
    partial class PkmnLoad
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PkmnLoad));
            this.PNL_MENU = new System.Windows.Forms.Panel();
            this.BT_MINIMIZE = new System.Windows.Forms.Button();
            this.BT_CLOSE = new System.Windows.Forms.Button();
            this.PNL_CONTENT = new System.Windows.Forms.Panel();
            this.BT_DELETE = new System.Windows.Forms.Button();
            this.DGV_PKMN = new System.Windows.Forms.DataGridView();
            this.CMS_DGV = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BT_CANCEL = new System.Windows.Forms.Button();
            this.BT_LOAD = new System.Windows.Forms.Button();
            this.DGV_Caught = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGV_Icon = new System.Windows.Forms.DataGridViewImageColumn();
            this.DGV_Dexnmb = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Encounters = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_counterRatio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_alpha = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGV_pkmnIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_genIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_gameIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_shiny = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGV_animated = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGV_autosave = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGV_addHotkey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_subHotkey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_resetHotkey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_exportCounter = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGV_exportFileCounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_importPicture = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.DGV_importFilePicture = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PNL_MENU.SuspendLayout();
            this.PNL_CONTENT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PKMN)).BeginInit();
            this.CMS_DGV.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_MENU
            // 
            this.PNL_MENU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PNL_MENU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_MENU.Controls.Add(this.BT_MINIMIZE);
            this.PNL_MENU.Controls.Add(this.BT_CLOSE);
            this.PNL_MENU.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_MENU.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PNL_MENU.Location = new System.Drawing.Point(0, 0);
            this.PNL_MENU.Name = "PNL_MENU";
            this.PNL_MENU.Size = new System.Drawing.Size(383, 44);
            this.PNL_MENU.TabIndex = 1;
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
            this.BT_MINIMIZE.Location = new System.Drawing.Point(299, 6);
            this.BT_MINIMIZE.Name = "BT_MINIMIZE";
            this.BT_MINIMIZE.Size = new System.Drawing.Size(34, 31);
            this.BT_MINIMIZE.TabIndex = 3;
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
            this.BT_CLOSE.Location = new System.Drawing.Point(339, 6);
            this.BT_CLOSE.Name = "BT_CLOSE";
            this.BT_CLOSE.Size = new System.Drawing.Size(39, 31);
            this.BT_CLOSE.TabIndex = 1;
            this.BT_CLOSE.UseVisualStyleBackColor = false;
            this.BT_CLOSE.Click += new System.EventHandler(this.BT_CLOSE_Click);
            // 
            // PNL_CONTENT
            // 
            this.PNL_CONTENT.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.PNL_CONTENT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_CONTENT.Controls.Add(this.BT_DELETE);
            this.PNL_CONTENT.Controls.Add(this.DGV_PKMN);
            this.PNL_CONTENT.Controls.Add(this.BT_CANCEL);
            this.PNL_CONTENT.Controls.Add(this.BT_LOAD);
            this.PNL_CONTENT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_CONTENT.Location = new System.Drawing.Point(0, 44);
            this.PNL_CONTENT.Name = "PNL_CONTENT";
            this.PNL_CONTENT.Size = new System.Drawing.Size(383, 330);
            this.PNL_CONTENT.TabIndex = 2;
            // 
            // BT_DELETE
            // 
            this.BT_DELETE.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BT_DELETE.Enabled = false;
            this.BT_DELETE.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_DELETE.ForeColor = System.Drawing.Color.White;
            this.BT_DELETE.Location = new System.Drawing.Point(11, 294);
            this.BT_DELETE.Name = "BT_DELETE";
            this.BT_DELETE.Size = new System.Drawing.Size(115, 28);
            this.BT_DELETE.TabIndex = 31;
            this.BT_DELETE.Text = "删除";
            this.BT_DELETE.UseVisualStyleBackColor = false;
            this.BT_DELETE.Click += new System.EventHandler(this.BT_DELETE_Click);
            // 
            // DGV_PKMN
            // 
            this.DGV_PKMN.AllowUserToAddRows = false;
            this.DGV_PKMN.AllowUserToDeleteRows = false;
            this.DGV_PKMN.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DGV_PKMN.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGV_PKMN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_PKMN.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGV_PKMN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV_PKMN.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DGV_Caught,
            this.DGV_Icon,
            this.DGV_Dexnmb,
            this.DGV_Name,
            this.DGV_Encounters,
            this.DGV_counterRatio,
            this.ID,
            this.DGV_alpha,
            this.DGV_pkmnIndex,
            this.DGV_genIndex,
            this.DGV_gameIndex,
            this.DGV_shiny,
            this.DGV_animated,
            this.DGV_autosave,
            this.DGV_addHotkey,
            this.DGV_subHotkey,
            this.DGV_resetHotkey,
            this.DGV_exportCounter,
            this.DGV_exportFileCounter,
            this.DGV_importPicture,
            this.DGV_importFilePicture});
            this.DGV_PKMN.ContextMenuStrip = this.CMS_DGV;
            this.DGV_PKMN.Location = new System.Drawing.Point(11, 5);
            this.DGV_PKMN.Name = "DGV_PKMN";
            this.DGV_PKMN.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            this.DGV_PKMN.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DGV_PKMN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DGV_PKMN.Size = new System.Drawing.Size(357, 281);
            this.DGV_PKMN.StandardTab = true;
            this.DGV_PKMN.TabIndex = 30;
            this.DGV_PKMN.CellMouseUp += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DGV_PKMN_CellMouseUp);
            // 
            // CMS_DGV
            // 
            this.CMS_DGV.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.refreshToolStripMenuItem});
            this.CMS_DGV.Name = "CMS_DGV";
            this.CMS_DGV.Size = new System.Drawing.Size(146, 26);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Image = global::PokemonCounter.Properties.Resources.refresh;
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.refreshToolStripMenuItem.Text = "刷新";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // BT_CANCEL
            // 
            this.BT_CANCEL.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BT_CANCEL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CANCEL.ForeColor = System.Drawing.Color.White;
            this.BT_CANCEL.Location = new System.Drawing.Point(253, 294);
            this.BT_CANCEL.Name = "BT_CANCEL";
            this.BT_CANCEL.Size = new System.Drawing.Size(115, 28);
            this.BT_CANCEL.TabIndex = 29;
            this.BT_CANCEL.Text = "取消";
            this.BT_CANCEL.UseVisualStyleBackColor = false;
            this.BT_CANCEL.Click += new System.EventHandler(this.BT_CANCEL_Click);
            // 
            // BT_LOAD
            // 
            this.BT_LOAD.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BT_LOAD.Enabled = false;
            this.BT_LOAD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_LOAD.ForeColor = System.Drawing.Color.White;
            this.BT_LOAD.Location = new System.Drawing.Point(132, 294);
            this.BT_LOAD.Name = "BT_LOAD";
            this.BT_LOAD.Size = new System.Drawing.Size(115, 28);
            this.BT_LOAD.TabIndex = 28;
            this.BT_LOAD.Text = "读取";
            this.BT_LOAD.UseVisualStyleBackColor = false;
            this.BT_LOAD.Click += new System.EventHandler(this.BT_LOAD_Click);
            // 
            // DGV_Caught
            // 
            this.DGV_Caught.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DGV_Caught.HeaderText = "已捕获";
            this.DGV_Caught.MinimumWidth = 25;
            this.DGV_Caught.Name = "DGV_Caught";
            this.DGV_Caught.ReadOnly = true;
            this.DGV_Caught.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Caught.Width = 49;
            // 
            // DGV_Icon
            // 
            this.DGV_Icon.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DGV_Icon.HeaderText = "图标";
            this.DGV_Icon.Name = "DGV_Icon";
            this.DGV_Icon.ReadOnly = true;
            this.DGV_Icon.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Icon.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DGV_Icon.Width = 56;
            // 
            // DGV_Dexnmb
            // 
            this.DGV_Dexnmb.HeaderText = "编号";
            this.DGV_Dexnmb.Name = "DGV_Dexnmb";
            this.DGV_Dexnmb.ReadOnly = true;
            this.DGV_Dexnmb.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Dexnmb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DGV_Dexnmb.Width = 50;
            // 
            // DGV_Name
            // 
            this.DGV_Name.HeaderText = "名字";
            this.DGV_Name.Name = "DGV_Name";
            this.DGV_Name.ReadOnly = true;
            this.DGV_Name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DGV_Encounters
            // 
            this.DGV_Encounters.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.DGV_Encounters.HeaderText = "相遇";
            this.DGV_Encounters.Name = "DGV_Encounters";
            this.DGV_Encounters.ReadOnly = true;
            this.DGV_Encounters.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_Encounters.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.DGV_Encounters.Width = 37;
            // 
            // DGV_counterRatio
            // 
            this.DGV_counterRatio.HeaderText = "计数每次+/-";
            this.DGV_counterRatio.Name = "DGV_counterRatio";
            this.DGV_counterRatio.ReadOnly = true;
            this.DGV_counterRatio.Visible = false;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // DGV_alpha
            // 
            this.DGV_alpha.HeaderText = "alpha";
            this.DGV_alpha.Name = "DGV_alpha";
            this.DGV_alpha.ReadOnly = true;
            this.DGV_alpha.Visible = false;
            // 
            // DGV_pkmnIndex
            // 
            this.DGV_pkmnIndex.HeaderText = "宝可梦索引";
            this.DGV_pkmnIndex.Name = "DGV_pkmnIndex";
            this.DGV_pkmnIndex.ReadOnly = true;
            this.DGV_pkmnIndex.Visible = false;
            // 
            // DGV_genIndex
            // 
            this.DGV_genIndex.HeaderText = "世代索引";
            this.DGV_genIndex.Name = "DGV_genIndex";
            this.DGV_genIndex.ReadOnly = true;
            this.DGV_genIndex.Visible = false;
            // 
            // DGV_gameIndex
            // 
            this.DGV_gameIndex.HeaderText = "游戏索引";
            this.DGV_gameIndex.Name = "DGV_gameIndex";
            this.DGV_gameIndex.ReadOnly = true;
            this.DGV_gameIndex.Visible = false;
            // 
            // DGV_shiny
            // 
            this.DGV_shiny.HeaderText = "闪光";
            this.DGV_shiny.Name = "DGV_shiny";
            this.DGV_shiny.ReadOnly = true;
            this.DGV_shiny.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_shiny.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DGV_shiny.Visible = false;
            // 
            // DGV_animated
            // 
            this.DGV_animated.HeaderText = "是否动图";
            this.DGV_animated.Name = "DGV_animated";
            this.DGV_animated.ReadOnly = true;
            this.DGV_animated.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_animated.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DGV_animated.Visible = false;
            // 
            // DGV_autosave
            // 
            this.DGV_autosave.HeaderText = "自动保存";
            this.DGV_autosave.Name = "DGV_autosave";
            this.DGV_autosave.ReadOnly = true;
            this.DGV_autosave.Visible = false;
            // 
            // DGV_addHotkey
            // 
            this.DGV_addHotkey.HeaderText = "热键-增加计数";
            this.DGV_addHotkey.Name = "DGV_addHotkey";
            this.DGV_addHotkey.ReadOnly = true;
            this.DGV_addHotkey.Visible = false;
            // 
            // DGV_subHotkey
            // 
            this.DGV_subHotkey.HeaderText = "热键-减少计数";
            this.DGV_subHotkey.Name = "DGV_subHotkey";
            this.DGV_subHotkey.ReadOnly = true;
            this.DGV_subHotkey.Visible = false;
            // 
            // DGV_resetHotkey
            // 
            this.DGV_resetHotkey.HeaderText = "热键-重置";
            this.DGV_resetHotkey.Name = "DGV_resetHotkey";
            this.DGV_resetHotkey.ReadOnly = true;
            this.DGV_resetHotkey.Visible = false;
            // 
            // DGV_exportCounter
            // 
            this.DGV_exportCounter.HeaderText = "导出计数";
            this.DGV_exportCounter.Name = "DGV_exportCounter";
            this.DGV_exportCounter.ReadOnly = true;
            this.DGV_exportCounter.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DGV_exportCounter.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.DGV_exportCounter.Visible = false;
            // 
            // DGV_exportFileCounter
            // 
            this.DGV_exportFileCounter.HeaderText = "导出计数文件";
            this.DGV_exportFileCounter.Name = "DGV_exportFileCounter";
            this.DGV_exportFileCounter.ReadOnly = true;
            this.DGV_exportFileCounter.Visible = false;
            // 
            // DGV_importPicture
            // 
            this.DGV_importPicture.HeaderText = "导入图片";
            this.DGV_importPicture.Name = "DGV_importPicture";
            this.DGV_importPicture.ReadOnly = true;
            this.DGV_importPicture.Visible = false;
            // 
            // DGV_importFilePicture
            // 
            this.DGV_importFilePicture.HeaderText = "导入图片文件";
            this.DGV_importFilePicture.Name = "DGV_importFilePicture";
            this.DGV_importFilePicture.ReadOnly = true;
            this.DGV_importFilePicture.Visible = false;
            // 
            // PkmnLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 374);
            this.Controls.Add(this.PNL_CONTENT);
            this.Controls.Add(this.PNL_MENU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PkmnLoad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "读取";
            this.Load += new System.EventHandler(this.PkmnLoad_Load);
            this.PNL_MENU.ResumeLayout(false);
            this.PNL_CONTENT.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGV_PKMN)).EndInit();
            this.CMS_DGV.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_MENU;
        private System.Windows.Forms.Button BT_MINIMIZE;
        private System.Windows.Forms.Button BT_CLOSE;
        private System.Windows.Forms.Panel PNL_CONTENT;
        private System.Windows.Forms.Button BT_CANCEL;
        private System.Windows.Forms.Button BT_LOAD;
        private System.Windows.Forms.DataGridView DGV_PKMN;
        private System.Windows.Forms.Button BT_DELETE;
        private System.Windows.Forms.ContextMenuStrip CMS_DGV;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_Caught;
        private System.Windows.Forms.DataGridViewImageColumn DGV_Icon;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Dexnmb;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Encounters;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_counterRatio;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_alpha;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_pkmnIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_genIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_gameIndex;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_shiny;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_animated;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_autosave;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_addHotkey;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_subHotkey;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_resetHotkey;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_exportCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_exportFileCounter;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DGV_importPicture;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_importFilePicture;
    }
}