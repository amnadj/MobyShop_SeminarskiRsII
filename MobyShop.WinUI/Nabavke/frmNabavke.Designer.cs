namespace MobyShop.WinUI.Nabavke
{
    partial class frmNabavke
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
            this.btnDodajNabavku = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgvStavkeNabavke = new System.Windows.Forms.DataGridView();
            this.StavkeNabavkeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artikal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Proizvodjac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Model = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSkladiste = new System.Windows.Forms.TextBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPDV = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtIznosRacuna = new System.Windows.Forms.TextBox();
            this.txtBrojNabavke = new System.Windows.Forms.TextBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.BrojNabavke = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKontaktOsoba = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNazivDobavljaca = new System.Windows.Forms.TextBox();
            this.cmbNabavke = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.Datum2 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.Datum1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNabavke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDodajNabavku
            // 
            this.btnDodajNabavku.Location = new System.Drawing.Point(512, 49);
            this.btnDodajNabavku.Name = "btnDodajNabavku";
            this.btnDodajNabavku.Size = new System.Drawing.Size(134, 32);
            this.btnDodajNabavku.TabIndex = 19;
            this.btnDodajNabavku.Text = "Nova nabavka";
            this.btnDodajNabavku.UseVisualStyleBackColor = true;
            this.btnDodajNabavku.Click += new System.EventHandler(this.btnDodajNabavku_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dgvStavkeNabavke);
            this.groupBox2.Location = new System.Drawing.Point(29, 258);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(617, 199);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stavke nabavke";
            // 
            // dgvStavkeNabavke
            // 
            this.dgvStavkeNabavke.AllowUserToAddRows = false;
            this.dgvStavkeNabavke.AllowUserToDeleteRows = false;
            this.dgvStavkeNabavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStavkeNabavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeNabavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StavkeNabavkeId,
            this.Artikal,
            this.Proizvodjac,
            this.Model,
            this.Cijena,
            this.Kolicina,
            this.Slika});
            this.dgvStavkeNabavke.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStavkeNabavke.Location = new System.Drawing.Point(3, 16);
            this.dgvStavkeNabavke.Name = "dgvStavkeNabavke";
            this.dgvStavkeNabavke.ReadOnly = true;
            this.dgvStavkeNabavke.Size = new System.Drawing.Size(611, 180);
            this.dgvStavkeNabavke.TabIndex = 0;
            // 
            // StavkeNabavkeId
            // 
            this.StavkeNabavkeId.HeaderText = "StavkeNabavkeId";
            this.StavkeNabavkeId.Name = "StavkeNabavkeId";
            this.StavkeNabavkeId.ReadOnly = true;
            this.StavkeNabavkeId.Visible = false;
            // 
            // Artikal
            // 
            this.Artikal.DataPropertyName = "Artikal";
            this.Artikal.HeaderText = "Artikal";
            this.Artikal.Name = "Artikal";
            this.Artikal.ReadOnly = true;
            // 
            // Proizvodjac
            // 
            this.Proizvodjac.DataPropertyName = "Proizvodjac";
            this.Proizvodjac.HeaderText = "Proizvodjac";
            this.Proizvodjac.Name = "Proizvodjac";
            this.Proizvodjac.ReadOnly = true;
            // 
            // Model
            // 
            this.Model.DataPropertyName = "Model";
            this.Model.HeaderText = "Model";
            this.Model.Name = "Model";
            this.Model.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSkladiste);
            this.groupBox1.Controls.Add(this.txtNapomena);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtPDV);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtIznosRacuna);
            this.groupBox1.Controls.Add(this.txtBrojNabavke);
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BrojNabavke);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(29, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 165);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalji nabavke";
            // 
            // txtSkladiste
            // 
            this.txtSkladiste.Location = new System.Drawing.Point(95, 21);
            this.txtSkladiste.Name = "txtSkladiste";
            this.txtSkladiste.ReadOnly = true;
            this.txtSkladiste.Size = new System.Drawing.Size(178, 20);
            this.txtSkladiste.TabIndex = 13;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(95, 137);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.ReadOnly = true;
            this.txtNapomena.Size = new System.Drawing.Size(178, 20);
            this.txtNapomena.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 140);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Napomena";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(170, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "PDV:";
            // 
            // txtPDV
            // 
            this.txtPDV.Location = new System.Drawing.Point(208, 106);
            this.txtPDV.Name = "txtPDV";
            this.txtPDV.ReadOnly = true;
            this.txtPDV.Size = new System.Drawing.Size(65, 20);
            this.txtPDV.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Iznos racuna:";
            // 
            // txtIznosRacuna
            // 
            this.txtIznosRacuna.Location = new System.Drawing.Point(95, 106);
            this.txtIznosRacuna.Name = "txtIznosRacuna";
            this.txtIznosRacuna.ReadOnly = true;
            this.txtIznosRacuna.Size = new System.Drawing.Size(69, 20);
            this.txtIznosRacuna.TabIndex = 7;
            // 
            // txtBrojNabavke
            // 
            this.txtBrojNabavke.Location = new System.Drawing.Point(95, 51);
            this.txtBrojNabavke.Name = "txtBrojNabavke";
            this.txtBrojNabavke.ReadOnly = true;
            this.txtBrojNabavke.Size = new System.Drawing.Size(178, 20);
            this.txtBrojNabavke.TabIndex = 6;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Enabled = false;
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(95, 77);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(178, 20);
            this.dtpDatum.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Datum:";
            // 
            // BrojNabavke
            // 
            this.BrojNabavke.AutoSize = true;
            this.BrojNabavke.Location = new System.Drawing.Point(18, 54);
            this.BrojNabavke.Name = "BrojNabavke";
            this.BrojNabavke.Size = new System.Drawing.Size(73, 13);
            this.BrojNabavke.TabIndex = 3;
            this.BrojNabavke.Text = "Broj nabavke:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Skladiste:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.txtTelefon);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.txtKontaktOsoba);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.txtNazivDobavljaca);
            this.groupBox3.Location = new System.Drawing.Point(356, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(255, 138);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dobavljac";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(88, 95);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.ReadOnly = true;
            this.txtTelefon.Size = new System.Drawing.Size(161, 20);
            this.txtTelefon.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Kontakt osoba:";
            // 
            // txtKontaktOsoba
            // 
            this.txtKontaktOsoba.Location = new System.Drawing.Point(88, 59);
            this.txtKontaktOsoba.Name = "txtKontaktOsoba";
            this.txtKontaktOsoba.ReadOnly = true;
            this.txtKontaktOsoba.Size = new System.Drawing.Size(161, 20);
            this.txtKontaktOsoba.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Naziv:";
            // 
            // txtNazivDobavljaca
            // 
            this.txtNazivDobavljaca.Location = new System.Drawing.Point(87, 23);
            this.txtNazivDobavljaca.Name = "txtNazivDobavljaca";
            this.txtNazivDobavljaca.ReadOnly = true;
            this.txtNazivDobavljaca.Size = new System.Drawing.Size(162, 20);
            this.txtNazivDobavljaca.TabIndex = 0;
            // 
            // cmbNabavke
            // 
            this.cmbNabavke.FormattingEnabled = true;
            this.cmbNabavke.Location = new System.Drawing.Point(88, 48);
            this.cmbNabavke.Name = "cmbNabavke";
            this.cmbNabavke.Size = new System.Drawing.Size(120, 21);
            this.cmbNabavke.TabIndex = 16;
            this.cmbNabavke.SelectedIndexChanged += new System.EventHandler(this.cmbNabavke_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nabavke:";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(276, 48);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(75, 23);
            this.btnLoad.TabIndex = 14;
            this.btnLoad.Text = "Ucitaj";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // Datum2
            // 
            this.Datum2.AutoSize = true;
            this.Datum2.Location = new System.Drawing.Point(214, 21);
            this.Datum2.Name = "Datum2";
            this.Datum2.Size = new System.Drawing.Size(56, 13);
            this.Datum2.TabIndex = 13;
            this.Datum2.Text = "Datum do:";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(276, 15);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker2.TabIndex = 12;
            // 
            // Datum1
            // 
            this.Datum1.AutoSize = true;
            this.Datum1.Location = new System.Drawing.Point(26, 21);
            this.Datum1.Name = "Datum1";
            this.Datum1.Size = new System.Drawing.Size(56, 13);
            this.Datum1.TabIndex = 11;
            this.Datum1.Text = "Datum od:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(88, 15);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(120, 20);
            this.dateTimePicker1.TabIndex = 10;
            // 
            // frmNabavke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 483);
            this.Controls.Add(this.btnDodajNabavku);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmbNabavke);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.Datum2);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.Datum1);
            this.Controls.Add(this.dateTimePicker1);
            this.Name = "frmNabavke";
            this.Text = "frmNabavke";
            this.Load += new System.EventHandler(this.frmNabavke_Load);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNabavke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDodajNabavku;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgvStavkeNabavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn StavkeNabavkeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Proizvodjac;
        private System.Windows.Forms.DataGridViewTextBoxColumn Model;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSkladiste;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPDV;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtIznosRacuna;
        private System.Windows.Forms.TextBox txtBrojNabavke;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label BrojNabavke;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKontaktOsoba;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNazivDobavljaca;
        private System.Windows.Forms.ComboBox cmbNabavke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label Datum2;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label Datum1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}