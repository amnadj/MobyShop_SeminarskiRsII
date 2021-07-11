namespace MobyShop.WinUI.Narudzbe
{
    partial class frmNarudzbeDetalji
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
            this.groupbox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.NarudzbaStavkaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artikal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Popust = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbSkladista = new System.Windows.Forms.ComboBox();
            this.btnZakljuci = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKlijent = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIznossaPdv = new System.Windows.Forms.TextBox();
            this.txtIznosbezPdv = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbOtkazano = new System.Windows.Forms.CheckBox();
            this.cbStatus = new System.Windows.Forms.CheckBox();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.txtBrojNarudzbe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupbox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupbox2
            // 
            this.groupbox2.Controls.Add(this.dataGridView1);
            this.groupbox2.Location = new System.Drawing.Point(24, 218);
            this.groupbox2.Name = "groupbox2";
            this.groupbox2.Size = new System.Drawing.Size(549, 226);
            this.groupbox2.TabIndex = 7;
            this.groupbox2.TabStop = false;
            this.groupbox2.Text = "Stavke narudzbe";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NarudzbaStavkaId,
            this.Artikal,
            this.Sifra,
            this.Cijena,
            this.Kolicina,
            this.Popust});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(543, 207);
            this.dataGridView1.TabIndex = 0;
            // 
            // NarudzbaStavkaId
            // 
            this.NarudzbaStavkaId.DataPropertyName = "NarudzbaStavkaId";
            this.NarudzbaStavkaId.HeaderText = "NarudzbaStavkaId";
            this.NarudzbaStavkaId.Name = "NarudzbaStavkaId";
            this.NarudzbaStavkaId.ReadOnly = true;
            this.NarudzbaStavkaId.Visible = false;
            // 
            // Artikal
            // 
            this.Artikal.DataPropertyName = "Naziv";
            this.Artikal.HeaderText = "Naziv artikla";
            this.Artikal.Name = "Artikal";
            this.Artikal.ReadOnly = true;
            // 
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Sifra artikla";
            this.Sifra.Name = "Sifra";
            this.Sifra.ReadOnly = true;
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
            // Popust
            // 
            this.Popust.DataPropertyName = "Popust";
            this.Popust.HeaderText = "Popust";
            this.Popust.Name = "Popust";
            this.Popust.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbSkladista);
            this.groupBox1.Controls.Add(this.btnZakljuci);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtKlijent);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtIznossaPdv);
            this.groupBox1.Controls.Add(this.txtIznosbezPdv);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbOtkazano);
            this.groupBox1.Controls.Add(this.cbStatus);
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Controls.Add(this.txtBrojNarudzbe);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(546, 190);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Detalji narudzbe";
            // 
            // cmbSkladista
            // 
            this.cmbSkladista.FormattingEnabled = true;
            this.cmbSkladista.Location = new System.Drawing.Point(373, 52);
            this.cmbSkladista.Name = "cmbSkladista";
            this.cmbSkladista.Size = new System.Drawing.Size(157, 21);
            this.cmbSkladista.TabIndex = 17;
            // 
            // btnZakljuci
            // 
            this.btnZakljuci.Location = new System.Drawing.Point(373, 128);
            this.btnZakljuci.Name = "btnZakljuci";
            this.btnZakljuci.Size = new System.Drawing.Size(157, 31);
            this.btnZakljuci.TabIndex = 16;
            this.btnZakljuci.Text = "Zakljuci narudzbu";
            this.btnZakljuci.UseVisualStyleBackColor = true;
            this.btnZakljuci.Click += new System.EventHandler(this.btnZakljuci_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Skladiste:";
            // 
            // txtKlijent
            // 
            this.txtKlijent.Location = new System.Drawing.Point(373, 20);
            this.txtKlijent.Name = "txtKlijent";
            this.txtKlijent.ReadOnly = true;
            this.txtKlijent.Size = new System.Drawing.Size(157, 20);
            this.txtKlijent.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Klijent:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Iznos bez PDV:";
            // 
            // txtIznossaPdv
            // 
            this.txtIznossaPdv.Location = new System.Drawing.Point(117, 139);
            this.txtIznossaPdv.Name = "txtIznossaPdv";
            this.txtIznossaPdv.ReadOnly = true;
            this.txtIznossaPdv.Size = new System.Drawing.Size(157, 20);
            this.txtIznossaPdv.TabIndex = 10;
            // 
            // txtIznosbezPdv
            // 
            this.txtIznosbezPdv.Location = new System.Drawing.Point(117, 113);
            this.txtIznosbezPdv.Name = "txtIznosbezPdv";
            this.txtIznosbezPdv.ReadOnly = true;
            this.txtIznosbezPdv.Size = new System.Drawing.Size(157, 20);
            this.txtIznosbezPdv.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Iznos sa PDV:";
            // 
            // cbOtkazano
            // 
            this.cbOtkazano.AutoSize = true;
            this.cbOtkazano.Enabled = false;
            this.cbOtkazano.Location = new System.Drawing.Point(202, 85);
            this.cbOtkazano.Name = "cbOtkazano";
            this.cbOtkazano.Size = new System.Drawing.Size(72, 17);
            this.cbOtkazano.TabIndex = 7;
            this.cbOtkazano.Text = "Otkazano";
            this.cbOtkazano.UseVisualStyleBackColor = true;
            // 
            // cbStatus
            // 
            this.cbStatus.AutoSize = true;
            this.cbStatus.Enabled = false;
            this.cbStatus.Location = new System.Drawing.Point(117, 85);
            this.cbStatus.Name = "cbStatus";
            this.cbStatus.Size = new System.Drawing.Size(56, 17);
            this.cbStatus.TabIndex = 5;
            this.cbStatus.Text = "Status";
            this.cbStatus.UseVisualStyleBackColor = true;
            // 
            // dtpDatum
            // 
            this.dtpDatum.Enabled = false;
            this.dtpDatum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDatum.Location = new System.Drawing.Point(117, 53);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(157, 20);
            this.dtpDatum.TabIndex = 3;
            // 
            // txtBrojNarudzbe
            // 
            this.txtBrojNarudzbe.Location = new System.Drawing.Point(117, 24);
            this.txtBrojNarudzbe.Name = "txtBrojNarudzbe";
            this.txtBrojNarudzbe.ReadOnly = true;
            this.txtBrojNarudzbe.Size = new System.Drawing.Size(157, 20);
            this.txtBrojNarudzbe.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj narudzbe:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum:";
            // 
            // frmNarudzbeDetalji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 457);
            this.Controls.Add(this.groupbox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNarudzbeDetalji";
            this.Text = "frmNarudzbeDetalji";
            this.Load += new System.EventHandler(this.frmNarudzbeDetalji_Load);
            this.groupbox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupbox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NarudzbaStavkaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Popust;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbSkladista;
        private System.Windows.Forms.Button btnZakljuci;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKlijent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIznossaPdv;
        private System.Windows.Forms.TextBox txtIznosbezPdv;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbOtkazano;
        private System.Windows.Forms.CheckBox cbStatus;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.TextBox txtBrojNarudzbe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}