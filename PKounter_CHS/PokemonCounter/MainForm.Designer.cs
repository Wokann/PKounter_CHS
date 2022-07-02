using System.Windows.Forms;

namespace PokemonCounter
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PNL_MENU = new System.Windows.Forms.Panel();
            this.BT_OPTIONS = new System.Windows.Forms.Button();
            this.BT_MINIMIZE = new System.Windows.Forms.Button();
            this.BT_SUS = new System.Windows.Forms.Button();
            this.BT_CLOSE = new System.Windows.Forms.Button();
            this.BT_ADD = new System.Windows.Forms.Button();
            this.PNL_CONTENT = new System.Windows.Forms.Panel();
            this.TBL_CONTENT = new System.Windows.Forms.TableLayoutPanel();
            this.AutoSaving = new System.Windows.Forms.Timer(this.components);
            this.PNL_MENU.SuspendLayout();
            this.PNL_CONTENT.SuspendLayout();
            this.SuspendLayout();
            // 
            // PNL_MENU
            // 
            this.PNL_MENU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PNL_MENU.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PNL_MENU.Controls.Add(this.BT_OPTIONS);
            this.PNL_MENU.Controls.Add(this.BT_MINIMIZE);
            this.PNL_MENU.Controls.Add(this.BT_SUS);
            this.PNL_MENU.Controls.Add(this.BT_CLOSE);
            this.PNL_MENU.Controls.Add(this.BT_ADD);
            this.PNL_MENU.Dock = System.Windows.Forms.DockStyle.Top;
            this.PNL_MENU.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.PNL_MENU.Location = new System.Drawing.Point(0, 0);
            this.PNL_MENU.Name = "PNL_MENU";
            this.PNL_MENU.Size = new System.Drawing.Size(200, 36);
            this.PNL_MENU.TabIndex = 0;
            this.PNL_MENU.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_menu_MouseDown);
            this.PNL_MENU.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel_menu_MouseMove);
            this.PNL_MENU.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel_menu_MouseUp);
            // 
            // BT_OPTIONS
            // 
            this.BT_OPTIONS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_OPTIONS.BackColor = System.Drawing.Color.Transparent;
            this.BT_OPTIONS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_OPTIONS.ForeColor = System.Drawing.Color.White;
            this.BT_OPTIONS.Image = global::PokemonCounter.Properties.Resources.menu_options;
            this.BT_OPTIONS.Location = new System.Drawing.Point(97, 2);
            this.BT_OPTIONS.Name = "BT_OPTIONS";
            this.BT_OPTIONS.Size = new System.Drawing.Size(36, 30);
            this.BT_OPTIONS.TabIndex = 4;
            this.BT_OPTIONS.UseVisualStyleBackColor = false;
            this.BT_OPTIONS.Click += new System.EventHandler(this.BT_OPTIONS_Click);
            // 
            // BT_MINIMIZE
            // 
            this.BT_MINIMIZE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_MINIMIZE.BackColor = System.Drawing.Color.Transparent;
            this.BT_MINIMIZE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_MINIMIZE.ForeColor = System.Drawing.Color.White;
            this.BT_MINIMIZE.Image = global::PokemonCounter.Properties.Resources.menu_minimize;
            this.BT_MINIMIZE.Location = new System.Drawing.Point(132, 2);
            this.BT_MINIMIZE.Name = "BT_MINIMIZE";
            this.BT_MINIMIZE.Size = new System.Drawing.Size(34, 30);
            this.BT_MINIMIZE.TabIndex = 3;
            this.BT_MINIMIZE.UseVisualStyleBackColor = false;
            this.BT_MINIMIZE.Click += new System.EventHandler(this.BT_MINIMIZE_Click);
            // 
            // BT_SUS
            // 
            this.BT_SUS.BackColor = System.Drawing.Color.Transparent;
            this.BT_SUS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_SUS.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_SUS.ForeColor = System.Drawing.Color.White;
            this.BT_SUS.Image = global::PokemonCounter.Properties.Resources.menu_delete;
            this.BT_SUS.Location = new System.Drawing.Point(48, 2);
            this.BT_SUS.Name = "BT_SUS";
            this.BT_SUS.Size = new System.Drawing.Size(35, 30);
            this.BT_SUS.TabIndex = 2;
            this.BT_SUS.UseVisualStyleBackColor = false;
            this.BT_SUS.Click += new System.EventHandler(this.BT_SUS_Click);
            // 
            // BT_CLOSE
            // 
            this.BT_CLOSE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BT_CLOSE.BackColor = System.Drawing.Color.Transparent;
            this.BT_CLOSE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_CLOSE.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_CLOSE.ForeColor = System.Drawing.Color.White;
            this.BT_CLOSE.Image = global::PokemonCounter.Properties.Resources.menu_close;
            this.BT_CLOSE.Location = new System.Drawing.Point(165, 2);
            this.BT_CLOSE.Name = "BT_CLOSE";
            this.BT_CLOSE.Size = new System.Drawing.Size(32, 30);
            this.BT_CLOSE.TabIndex = 1;
            this.BT_CLOSE.UseVisualStyleBackColor = false;
            this.BT_CLOSE.Click += new System.EventHandler(this.BT_CLOSE_Click);
            // 
            // BT_ADD
            // 
            this.BT_ADD.BackColor = System.Drawing.Color.Transparent;
            this.BT_ADD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.BT_ADD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BT_ADD.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_ADD.ForeColor = System.Drawing.Color.White;
            this.BT_ADD.Image = global::PokemonCounter.Properties.Resources.menu_new;
            this.BT_ADD.Location = new System.Drawing.Point(3, 2);
            this.BT_ADD.Name = "BT_ADD";
            this.BT_ADD.Size = new System.Drawing.Size(39, 30);
            this.BT_ADD.TabIndex = 0;
            this.BT_ADD.UseVisualStyleBackColor = false;
            this.BT_ADD.Click += new System.EventHandler(this.BT_ADD_Click);
            // 
            // PNL_CONTENT
            // 
            this.PNL_CONTENT.BackColor = System.Drawing.Color.White;
            this.PNL_CONTENT.Controls.Add(this.TBL_CONTENT);
            this.PNL_CONTENT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PNL_CONTENT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PNL_CONTENT.Location = new System.Drawing.Point(0, 36);
            this.PNL_CONTENT.Name = "PNL_CONTENT";
            this.PNL_CONTENT.Size = new System.Drawing.Size(200, 181);
            this.PNL_CONTENT.TabIndex = 1;
            // 
            // TBL_CONTENT
            // 
            this.TBL_CONTENT.AutoSize = true;
            this.TBL_CONTENT.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TBL_CONTENT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TBL_CONTENT.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.TBL_CONTENT.ColumnCount = 1;
            this.TBL_CONTENT.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TBL_CONTENT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TBL_CONTENT.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.AddColumns;
            this.TBL_CONTENT.Location = new System.Drawing.Point(0, 0);
            this.TBL_CONTENT.Name = "TBL_CONTENT";
            this.TBL_CONTENT.RowCount = 1;
            this.TBL_CONTENT.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TBL_CONTENT.Size = new System.Drawing.Size(200, 181);
            this.TBL_CONTENT.TabIndex = 4;
            // 
            // AutoSaving
            // 
            this.AutoSaving.Enabled = true;
            this.AutoSaving.Interval = 60000;
            this.AutoSaving.Tick += new System.EventHandler(this.AutoSaving_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 217);
            this.Controls.Add(this.PNL_CONTENT);
            this.Controls.Add(this.PNL_MENU);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "菜单";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.PNL_MENU.ResumeLayout(false);
            this.PNL_CONTENT.ResumeLayout(false);
            this.PNL_CONTENT.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PNL_MENU;
        private System.Windows.Forms.Button BT_ADD;
        private System.Windows.Forms.Panel PNL_CONTENT;
        private System.Windows.Forms.Button BT_CLOSE;
        public System.Windows.Forms.TableLayoutPanel TBL_CONTENT;
        private System.Windows.Forms.Button BT_SUS;
        private System.Windows.Forms.Button BT_MINIMIZE;
        private System.Windows.Forms.Button BT_OPTIONS;
        private Timer AutoSaving;
    }
}

