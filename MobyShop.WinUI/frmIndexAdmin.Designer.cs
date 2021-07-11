namespace MobyShop.WinUI
{
    partial class frmIndexAdmin
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.artikliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaArtikalaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviArtikalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.korisniciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ListaKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKorisnikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.klijentiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaKlijenataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviKlijentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dobavljaciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDobavljačaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.noviDobavljačToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.skladištaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaSkladištaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.novoSkladišteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.izvještajiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 431);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(632, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artikliToolStripMenuItem,
            this.korisniciToolStripMenuItem,
            this.klijentiToolStripMenuItem,
            this.dobavljaciToolStripMenuItem,
            this.skladištaToolStripMenuItem,
            this.izvještajiToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(632, 27);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // artikliToolStripMenuItem
            // 
            this.artikliToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaArtikalaToolStripMenuItem,
            this.noviArtikalToolStripMenuItem});
            this.artikliToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.artikliToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.artikliToolStripMenuItem.Name = "artikliToolStripMenuItem";
            this.artikliToolStripMenuItem.Size = new System.Drawing.Size(64, 23);
            this.artikliToolStripMenuItem.Text = "Artikli";
            // 
            // listaArtikalaToolStripMenuItem
            // 
            this.listaArtikalaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.listaArtikalaToolStripMenuItem.Name = "listaArtikalaToolStripMenuItem";
            this.listaArtikalaToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.listaArtikalaToolStripMenuItem.Text = "Lista artikala";
            this.listaArtikalaToolStripMenuItem.Click += new System.EventHandler(this.listaArtikalaToolStripMenuItem_Click);
            // 
            // noviArtikalToolStripMenuItem
            // 
            this.noviArtikalToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.noviArtikalToolStripMenuItem.Name = "noviArtikalToolStripMenuItem";
            this.noviArtikalToolStripMenuItem.Size = new System.Drawing.Size(167, 24);
            this.noviArtikalToolStripMenuItem.Text = "Novi artikal";
            this.noviArtikalToolStripMenuItem.Click += new System.EventHandler(this.noviArtikalToolStripMenuItem_Click);
            // 
            // korisniciToolStripMenuItem
            // 
            this.korisniciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ListaKorisnikaToolStripMenuItem,
            this.noviKorisnikToolStripMenuItem});
            this.korisniciToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.korisniciToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.korisniciToolStripMenuItem.Name = "korisniciToolStripMenuItem";
            this.korisniciToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.korisniciToolStripMenuItem.Text = "Korisnici";
            // 
            // ListaKorisnikaToolStripMenuItem
            // 
            this.ListaKorisnikaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.ListaKorisnikaToolStripMenuItem.Name = "ListaKorisnikaToolStripMenuItem";
            this.ListaKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.ListaKorisnikaToolStripMenuItem.Text = "Lista korisnika";
            this.ListaKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.ListaKorisnikaToolStripMenuItem_Click_1);
            // 
            // noviKorisnikToolStripMenuItem
            // 
            this.noviKorisnikToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.noviKorisnikToolStripMenuItem.Name = "noviKorisnikToolStripMenuItem";
            this.noviKorisnikToolStripMenuItem.Size = new System.Drawing.Size(178, 24);
            this.noviKorisnikToolStripMenuItem.Text = "Novi korisnik";
            this.noviKorisnikToolStripMenuItem.Click += new System.EventHandler(this.noviKorisnikToolStripMenuItem_Click);
            // 
            // klijentiToolStripMenuItem
            // 
            this.klijentiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaKlijenataToolStripMenuItem,
            this.noviKlijentToolStripMenuItem});
            this.klijentiToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.klijentiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.klijentiToolStripMenuItem.Name = "klijentiToolStripMenuItem";
            this.klijentiToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.klijentiToolStripMenuItem.Text = "Klijenti";
            // 
            // listaKlijenataToolStripMenuItem
            // 
            this.listaKlijenataToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.listaKlijenataToolStripMenuItem.Name = "listaKlijenataToolStripMenuItem";
            this.listaKlijenataToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.listaKlijenataToolStripMenuItem.Text = "Lista klijenata";
            this.listaKlijenataToolStripMenuItem.Click += new System.EventHandler(this.listaKlijenataToolStripMenuItem_Click);
            // 
            // noviKlijentToolStripMenuItem
            // 
            this.noviKlijentToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.noviKlijentToolStripMenuItem.Name = "noviKlijentToolStripMenuItem";
            this.noviKlijentToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.noviKlijentToolStripMenuItem.Text = "Novi klijent";
            this.noviKlijentToolStripMenuItem.Click += new System.EventHandler(this.noviKlijentToolStripMenuItem_Click);
            // 
            // dobavljaciToolStripMenuItem
            // 
            this.dobavljaciToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaDobavljačaToolStripMenuItem,
            this.noviDobavljačToolStripMenuItem});
            this.dobavljaciToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.dobavljaciToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.dobavljaciToolStripMenuItem.Name = "dobavljaciToolStripMenuItem";
            this.dobavljaciToolStripMenuItem.Size = new System.Drawing.Size(93, 23);
            this.dobavljaciToolStripMenuItem.Text = "Dobavljači";
            // 
            // listaDobavljačaToolStripMenuItem
            // 
            this.listaDobavljačaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.listaDobavljačaToolStripMenuItem.Name = "listaDobavljačaToolStripMenuItem";
            this.listaDobavljačaToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.listaDobavljačaToolStripMenuItem.Text = "Lista dobavljača";
            this.listaDobavljačaToolStripMenuItem.Click += new System.EventHandler(this.listaDobavljačaToolStripMenuItem_Click);
            // 
            // noviDobavljačToolStripMenuItem
            // 
            this.noviDobavljačToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.noviDobavljačToolStripMenuItem.Name = "noviDobavljačToolStripMenuItem";
            this.noviDobavljačToolStripMenuItem.Size = new System.Drawing.Size(189, 24);
            this.noviDobavljačToolStripMenuItem.Text = "Novi dobavljač";
            this.noviDobavljačToolStripMenuItem.Click += new System.EventHandler(this.noviDobavljačToolStripMenuItem_Click);
            // 
            // skladištaToolStripMenuItem
            // 
            this.skladištaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listaSkladištaToolStripMenuItem,
            this.novoSkladišteToolStripMenuItem});
            this.skladištaToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.skladištaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.skladištaToolStripMenuItem.Name = "skladištaToolStripMenuItem";
            this.skladištaToolStripMenuItem.Size = new System.Drawing.Size(84, 23);
            this.skladištaToolStripMenuItem.Text = "Skladišta";
            // 
            // listaSkladištaToolStripMenuItem
            // 
            this.listaSkladištaToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.listaSkladištaToolStripMenuItem.Name = "listaSkladištaToolStripMenuItem";
            this.listaSkladištaToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.listaSkladištaToolStripMenuItem.Text = "Lista skladišta";
            this.listaSkladištaToolStripMenuItem.Click += new System.EventHandler(this.listaSkladištaToolStripMenuItem_Click);
            // 
            // novoSkladišteToolStripMenuItem
            // 
            this.novoSkladišteToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.novoSkladišteToolStripMenuItem.Name = "novoSkladišteToolStripMenuItem";
            this.novoSkladišteToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.novoSkladišteToolStripMenuItem.Text = "Novo skladište";
            this.novoSkladišteToolStripMenuItem.Click += new System.EventHandler(this.NovoSkladišteToolStripMenuItem_Click);
            // 
            // izvještajiToolStripMenuItem
            // 
            this.izvještajiToolStripMenuItem.Font = new System.Drawing.Font("Corbel", 12F, System.Drawing.FontStyle.Bold);
            this.izvještajiToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.izvještajiToolStripMenuItem.Name = "izvještajiToolStripMenuItem";
            this.izvještajiToolStripMenuItem.Size = new System.Drawing.Size(81, 23);
            this.izvještajiToolStripMenuItem.Text = "Izvještaji";
            this.izvještajiToolStripMenuItem.Click += new System.EventHandler(this.izvještajiToolStripMenuItem_Click);
            // 
            // frmIndexAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "frmIndexAdmin";
            this.Text = "frmIndexAdmin";
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem artikliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaArtikalaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviArtikalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem korisniciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ListaKorisnikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKorisnikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem klijentiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaKlijenataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviKlijentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dobavljaciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDobavljačaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noviDobavljačToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem skladištaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaSkladištaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem novoSkladišteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem izvještajiToolStripMenuItem;
    }
}



