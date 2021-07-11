namespace MobyShop.WinUI
{
    partial class frmIndexProdavac
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
            this.SideMenuPanel = new System.Windows.Forms.Panel();
            this.IzvjestajiSubMenuPanel = new System.Windows.Forms.Panel();
            this.btnPregledIzvjestaja = new System.Windows.Forms.Button();
            this.btnIzvjestaji = new System.Windows.Forms.Button();
            this.NarudzbeSubMenuPanel = new System.Windows.Forms.Panel();
            this.btnListaNarudzbi = new System.Windows.Forms.Button();
            this.btnNarudzbe = new System.Windows.Forms.Button();
            this.NabavkeSubMenuPanel = new System.Windows.Forms.Panel();
            this.btnNovaNabavka = new System.Windows.Forms.Button();
            this.btnDetaljiNabavke = new System.Windows.Forms.Button();
            this.btnNabavke = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.options = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.detaljiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.oKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SideMenuPanel.SuspendLayout();
            this.IzvjestajiSubMenuPanel.SuspendLayout();
            this.NarudzbeSubMenuPanel.SuspendLayout();
            this.NabavkeSubMenuPanel.SuspendLayout();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.options.SuspendLayout();
            this.SuspendLayout();
            // 
            // SideMenuPanel
            // 
            this.SideMenuPanel.AutoScroll = true;
            this.SideMenuPanel.BackColor = System.Drawing.Color.White;
            this.SideMenuPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SideMenuPanel.Controls.Add(this.IzvjestajiSubMenuPanel);
            this.SideMenuPanel.Controls.Add(this.btnIzvjestaji);
            this.SideMenuPanel.Controls.Add(this.NarudzbeSubMenuPanel);
            this.SideMenuPanel.Controls.Add(this.btnNarudzbe);
            this.SideMenuPanel.Controls.Add(this.NabavkeSubMenuPanel);
            this.SideMenuPanel.Controls.Add(this.btnNabavke);
            this.SideMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideMenuPanel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.SideMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.SideMenuPanel.Name = "SideMenuPanel";
            this.SideMenuPanel.Size = new System.Drawing.Size(279, 629);
            this.SideMenuPanel.TabIndex = 2;
            // 
            // IzvjestajiSubMenuPanel
            // 
            this.IzvjestajiSubMenuPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.IzvjestajiSubMenuPanel.Controls.Add(this.btnPregledIzvjestaja);
            this.IzvjestajiSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.IzvjestajiSubMenuPanel.ForeColor = System.Drawing.Color.DimGray;
            this.IzvjestajiSubMenuPanel.Location = new System.Drawing.Point(0, 258);
            this.IzvjestajiSubMenuPanel.Name = "IzvjestajiSubMenuPanel";
            this.IzvjestajiSubMenuPanel.Size = new System.Drawing.Size(275, 40);
            this.IzvjestajiSubMenuPanel.TabIndex = 11;
            // 
            // btnPregledIzvjestaja
            // 
            this.btnPregledIzvjestaja.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPregledIzvjestaja.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPregledIzvjestaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregledIzvjestaja.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnPregledIzvjestaja.ForeColor = System.Drawing.Color.Black;
            this.btnPregledIzvjestaja.Location = new System.Drawing.Point(0, 0);
            this.btnPregledIzvjestaja.Name = "btnPregledIzvjestaja";
            this.btnPregledIzvjestaja.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnPregledIzvjestaja.Size = new System.Drawing.Size(275, 40);
            this.btnPregledIzvjestaja.TabIndex = 0;
            this.btnPregledIzvjestaja.Text = "Pregled izvjestaja";
            this.btnPregledIzvjestaja.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPregledIzvjestaja.UseVisualStyleBackColor = false;
            this.btnPregledIzvjestaja.Click += new System.EventHandler(this.btnPregledIzvjestaja_Click);
            // 
            // btnIzvjestaji
            // 
            this.btnIzvjestaji.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIzvjestaji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIzvjestaji.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnIzvjestaji.ForeColor = System.Drawing.Color.Black;
            this.btnIzvjestaji.Location = new System.Drawing.Point(0, 213);
            this.btnIzvjestaji.Name = "btnIzvjestaji";
            this.btnIzvjestaji.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnIzvjestaji.Size = new System.Drawing.Size(275, 45);
            this.btnIzvjestaji.TabIndex = 10;
            this.btnIzvjestaji.Text = "Izvjestaji";
            this.btnIzvjestaji.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIzvjestaji.UseVisualStyleBackColor = true;
            this.btnIzvjestaji.Click += new System.EventHandler(this.btnIzvjestaji_Click);
            // 
            // NarudzbeSubMenuPanel
            // 
            this.NarudzbeSubMenuPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NarudzbeSubMenuPanel.Controls.Add(this.btnListaNarudzbi);
            this.NarudzbeSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NarudzbeSubMenuPanel.ForeColor = System.Drawing.Color.DimGray;
            this.NarudzbeSubMenuPanel.Location = new System.Drawing.Point(0, 171);
            this.NarudzbeSubMenuPanel.Name = "NarudzbeSubMenuPanel";
            this.NarudzbeSubMenuPanel.Size = new System.Drawing.Size(275, 42);
            this.NarudzbeSubMenuPanel.TabIndex = 9;
            // 
            // btnListaNarudzbi
            // 
            this.btnListaNarudzbi.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnListaNarudzbi.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListaNarudzbi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListaNarudzbi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnListaNarudzbi.ForeColor = System.Drawing.Color.Black;
            this.btnListaNarudzbi.Location = new System.Drawing.Point(0, 0);
            this.btnListaNarudzbi.Name = "btnListaNarudzbi";
            this.btnListaNarudzbi.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnListaNarudzbi.Size = new System.Drawing.Size(275, 42);
            this.btnListaNarudzbi.TabIndex = 0;
            this.btnListaNarudzbi.Text = "Lista narudzbi";
            this.btnListaNarudzbi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListaNarudzbi.UseVisualStyleBackColor = false;
            this.btnListaNarudzbi.Click += new System.EventHandler(this.btnListaNarudzbi_Click);
            // 
            // btnNarudzbe
            // 
            this.btnNarudzbe.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNarudzbe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNarudzbe.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNarudzbe.ForeColor = System.Drawing.Color.Black;
            this.btnNarudzbe.Location = new System.Drawing.Point(0, 126);
            this.btnNarudzbe.Name = "btnNarudzbe";
            this.btnNarudzbe.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNarudzbe.Size = new System.Drawing.Size(275, 45);
            this.btnNarudzbe.TabIndex = 8;
            this.btnNarudzbe.Text = "Narudzbe";
            this.btnNarudzbe.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNarudzbe.UseVisualStyleBackColor = true;
            this.btnNarudzbe.Click += new System.EventHandler(this.btnNarudzbe_Click);
            // 
            // NabavkeSubMenuPanel
            // 
            this.NabavkeSubMenuPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.NabavkeSubMenuPanel.Controls.Add(this.btnNovaNabavka);
            this.NabavkeSubMenuPanel.Controls.Add(this.btnDetaljiNabavke);
            this.NabavkeSubMenuPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NabavkeSubMenuPanel.ForeColor = System.Drawing.Color.DimGray;
            this.NabavkeSubMenuPanel.Location = new System.Drawing.Point(0, 45);
            this.NabavkeSubMenuPanel.Name = "NabavkeSubMenuPanel";
            this.NabavkeSubMenuPanel.Size = new System.Drawing.Size(275, 81);
            this.NabavkeSubMenuPanel.TabIndex = 4;
            // 
            // btnNovaNabavka
            // 
            this.btnNovaNabavka.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnNovaNabavka.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNovaNabavka.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNovaNabavka.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNovaNabavka.ForeColor = System.Drawing.Color.Black;
            this.btnNovaNabavka.Location = new System.Drawing.Point(0, 40);
            this.btnNovaNabavka.Name = "btnNovaNabavka";
            this.btnNovaNabavka.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnNovaNabavka.Size = new System.Drawing.Size(275, 41);
            this.btnNovaNabavka.TabIndex = 1;
            this.btnNovaNabavka.Text = "Nova nabavka";
            this.btnNovaNabavka.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovaNabavka.UseVisualStyleBackColor = false;
            this.btnNovaNabavka.Click += new System.EventHandler(this.btnNovaNabavka_Click);
            // 
            // btnDetaljiNabavke
            // 
            this.btnDetaljiNabavke.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDetaljiNabavke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDetaljiNabavke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetaljiNabavke.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnDetaljiNabavke.ForeColor = System.Drawing.Color.Black;
            this.btnDetaljiNabavke.Location = new System.Drawing.Point(0, 0);
            this.btnDetaljiNabavke.Name = "btnDetaljiNabavke";
            this.btnDetaljiNabavke.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.btnDetaljiNabavke.Size = new System.Drawing.Size(275, 40);
            this.btnDetaljiNabavke.TabIndex = 0;
            this.btnDetaljiNabavke.Text = "Pregled detalja nabavke";
            this.btnDetaljiNabavke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDetaljiNabavke.UseVisualStyleBackColor = false;
            this.btnDetaljiNabavke.Click += new System.EventHandler(this.btnDetaljiNabavke_Click);
            // 
            // btnNabavke
            // 
            this.btnNabavke.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNabavke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNabavke.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnNabavke.ForeColor = System.Drawing.Color.Black;
            this.btnNabavke.Location = new System.Drawing.Point(0, 0);
            this.btnNabavke.Name = "btnNabavke";
            this.btnNabavke.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnNabavke.Size = new System.Drawing.Size(275, 45);
            this.btnNabavke.TabIndex = 3;
            this.btnNabavke.Text = "Nabavke";
            this.btnNabavke.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNabavke.UseVisualStyleBackColor = true;
            this.btnNabavke.Click += new System.EventHandler(this.btnNabavke_Click);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.Color.White;
            this.panelChildForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelChildForm.Controls.Add(this.pictureBox1);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(279, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(773, 629);
            this.panelChildForm.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::MobyShop.WinUI.Properties.Resources.MobyShop;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(769, 625);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // options
            // 
            this.options.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.detaljiToolStripMenuItem,
            this.oKToolStripMenuItem});
            this.options.Name = "options";
            this.options.Size = new System.Drawing.Size(108, 48);
            // 
            // detaljiToolStripMenuItem
            // 
            this.detaljiToolStripMenuItem.Name = "detaljiToolStripMenuItem";
            this.detaljiToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.detaljiToolStripMenuItem.Text = "Detalji";
            // 
            // oKToolStripMenuItem
            // 
            this.oKToolStripMenuItem.Name = "oKToolStripMenuItem";
            this.oKToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.oKToolStripMenuItem.Text = "OK";
            // 
            // frmIndexProdavac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 629);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.SideMenuPanel);
            this.Name = "frmIndexProdavac";
            this.Text = "frmIndexProdavac";
            this.Load += new System.EventHandler(this.frmIndexProdavac_Load);
            this.SideMenuPanel.ResumeLayout(false);
            this.IzvjestajiSubMenuPanel.ResumeLayout(false);
            this.NarudzbeSubMenuPanel.ResumeLayout(false);
            this.NabavkeSubMenuPanel.ResumeLayout(false);
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.options.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel SideMenuPanel;
        private System.Windows.Forms.Panel IzvjestajiSubMenuPanel;
        private System.Windows.Forms.Button btnPregledIzvjestaja;
        private System.Windows.Forms.Button btnIzvjestaji;
        private System.Windows.Forms.Panel NarudzbeSubMenuPanel;
        private System.Windows.Forms.Button btnListaNarudzbi;
        private System.Windows.Forms.Button btnNarudzbe;
        private System.Windows.Forms.Panel NabavkeSubMenuPanel;
        private System.Windows.Forms.Button btnNovaNabavka;
        private System.Windows.Forms.Button btnDetaljiNabavke;
        private System.Windows.Forms.Button btnNabavke;
        private System.Windows.Forms.Panel panelChildForm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip options;
        private System.Windows.Forms.ToolStripMenuItem detaljiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem oKToolStripMenuItem;
    }
}