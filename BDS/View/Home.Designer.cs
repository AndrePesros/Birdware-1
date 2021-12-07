
namespace BDS.View
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.iconBtnNvP = new FontAwesome.Sharp.IconButton();
            this.iconBtnHome = new FontAwesome.Sharp.IconButton();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.iconButtonFinalizar = new FontAwesome.Sharp.IconButton();
            this.panelDesktop.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.LightCyan;
            this.panelDesktop.Controls.Add(this.panel5);
            this.panelDesktop.Controls.Add(this.panelTitleBar);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(220, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(962, 671);
            this.panelDesktop.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.labelTitle);
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 75);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(962, 596);
            this.panel5.TabIndex = 15;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.labelTitle.Location = new System.Drawing.Point(327, 424);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(363, 39);
            this.labelTitle.TabIndex = 12;
            this.labelTitle.Text = "SISTEMA BIRDWARE";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.DarkCyan;
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Controls.Add(this.panelShadow);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(0, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(962, 75);
            this.panelTitleBar.TabIndex = 8;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(62, 29);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(45, 17);
            this.lblTitleChildForm.TabIndex = 11;
            this.lblTitleChildForm.Text = "Home";
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelShadow.Location = new System.Drawing.Point(0, 66);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(962, 9);
            this.panelShadow.TabIndex = 9;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.DarkCyan;
            this.panelMenu.Controls.Add(this.iconButtonFinalizar);
            this.panelMenu.Controls.Add(this.iconButton3);
            this.panelMenu.Controls.Add(this.iconBtnNvP);
            this.panelMenu.Controls.Add(this.iconBtnHome);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(220, 671);
            this.panelMenu.TabIndex = 4;
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.btnHome);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(220, 167);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BDS.Properties.Resources.logoBD;
            this.pictureBox1.Location = new System.Drawing.Point(394, 157);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(223, 264);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.DarkCyan;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.IconSize = 34;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(21, 12);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(35, 34);
            this.iconCurrentChildForm.TabIndex = 10;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // iconButton3
            // 
            this.iconButton3.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconButton3.ForeColor = System.Drawing.SystemColors.Window;
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.iconButton3.IconColor = System.Drawing.Color.White;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 32;
            this.iconButton3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton3.Location = new System.Drawing.Point(0, 292);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(220, 65);
            this.iconButton3.TabIndex = 3;
            this.iconButton3.Text = "Pesquisa";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // iconBtnNvP
            // 
            this.iconBtnNvP.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnNvP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnNvP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconBtnNvP.ForeColor = System.Drawing.SystemColors.Window;
            this.iconBtnNvP.IconChar = FontAwesome.Sharp.IconChar.FilePowerpoint;
            this.iconBtnNvP.IconColor = System.Drawing.Color.White;
            this.iconBtnNvP.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnNvP.IconSize = 32;
            this.iconBtnNvP.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnNvP.Location = new System.Drawing.Point(0, 227);
            this.iconBtnNvP.Name = "iconBtnNvP";
            this.iconBtnNvP.Size = new System.Drawing.Size(220, 65);
            this.iconBtnNvP.TabIndex = 2;
            this.iconBtnNvP.Text = "Novo Produto";
            this.iconBtnNvP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnNvP.UseVisualStyleBackColor = true;
            this.iconBtnNvP.Click += new System.EventHandler(this.iconBtnNvP_Click);
            // 
            // iconBtnHome
            // 
            this.iconBtnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconBtnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconBtnHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconBtnHome.ForeColor = System.Drawing.SystemColors.Window;
            this.iconBtnHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconBtnHome.IconColor = System.Drawing.Color.White;
            this.iconBtnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtnHome.IconSize = 35;
            this.iconBtnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconBtnHome.Location = new System.Drawing.Point(0, 167);
            this.iconBtnHome.Name = "iconBtnHome";
            this.iconBtnHome.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconBtnHome.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.iconBtnHome.Size = new System.Drawing.Size(220, 60);
            this.iconBtnHome.TabIndex = 4;
            this.iconBtnHome.Text = "Home   ";
            this.iconBtnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconBtnHome.UseVisualStyleBackColor = true;
            this.iconBtnHome.Click += new System.EventHandler(this.iconBtnHome_Click);
            // 
            // btnHome
            // 
            this.btnHome.Image = ((System.Drawing.Image)(resources.GetObject("btnHome.Image")));
            this.btnHome.Location = new System.Drawing.Point(33, 3);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(151, 164);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            // 
            // iconButtonFinalizar
            // 
            this.iconButtonFinalizar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButtonFinalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButtonFinalizar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.iconButtonFinalizar.ForeColor = System.Drawing.SystemColors.Window;
            this.iconButtonFinalizar.IconChar = FontAwesome.Sharp.IconChar.PowerOff;
            this.iconButtonFinalizar.IconColor = System.Drawing.Color.White;
            this.iconButtonFinalizar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButtonFinalizar.IconSize = 32;
            this.iconButtonFinalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButtonFinalizar.Location = new System.Drawing.Point(0, 606);
            this.iconButtonFinalizar.Name = "iconButtonFinalizar";
            this.iconButtonFinalizar.Size = new System.Drawing.Size(220, 65);
            this.iconButtonFinalizar.TabIndex = 5;
            this.iconButtonFinalizar.Text = "Finalizar";
            this.iconButtonFinalizar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButtonFinalizar.UseVisualStyleBackColor = true;
            this.iconButtonFinalizar.Click += new System.EventHandler(this.iconButtonFinalizar_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1182, 671);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelMenu);
            this.Name = "Home";
            this.Text = "Home";
            this.panelDesktop.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton iconButton3;
        private FontAwesome.Sharp.IconButton iconBtnNvP;
        private FontAwesome.Sharp.IconButton iconBtnHome;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private FontAwesome.Sharp.IconButton iconButtonFinalizar;
    }
}