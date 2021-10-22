namespace MobyShop.WinUI.Nabavke
{
    partial class frmNovaNabavka
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnZakljuci = new System.Windows.Forms.Button();
            this.txtPDV = new System.Windows.Forms.TextBox();
            this.txtIznosRacuna = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnListaArtikala = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.cmbSkladista = new System.Windows.Forms.ComboBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.dgvStavkeNabavke = new System.Windows.Forms.DataGridView();
            this.NabavkaStavkeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Artikal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.txtKolicina = new System.Windows.Forms.TextBox();
            this.cmbDobavljaci = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBrojNabavke = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNabavke)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnZakljuci
            // 
            this.btnZakljuci.Location = new System.Drawing.Point(23, 419);
            this.btnZakljuci.Name = "btnZakljuci";
            this.btnZakljuci.Size = new System.Drawing.Size(92, 37);
            this.btnZakljuci.TabIndex = 17;
            this.btnZakljuci.Text = "Zakljuci";
            this.btnZakljuci.UseVisualStyleBackColor = true;
            this.btnZakljuci.Click += new System.EventHandler(this.btnZakljuci_Click);
            // 
            // txtPDV
            // 
            this.txtPDV.Location = new System.Drawing.Point(267, 383);
            this.txtPDV.Name = "txtPDV";
            this.txtPDV.ReadOnly = true;
            this.txtPDV.Size = new System.Drawing.Size(88, 20);
            this.txtPDV.TabIndex = 16;
            // 
            // txtIznosRacuna
            // 
            this.txtIznosRacuna.Location = new System.Drawing.Point(97, 383);
            this.txtIznosRacuna.Name = "txtIznosRacuna";
            this.txtIznosRacuna.ReadOnly = true;
            this.txtIznosRacuna.Size = new System.Drawing.Size(88, 20);
            this.txtIznosRacuna.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Iznos racuna:";
            // 
            // btnListaArtikala
            // 
            this.btnListaArtikala.Location = new System.Drawing.Point(267, 27);
            this.btnListaArtikala.Name = "btnListaArtikala";
            this.btnListaArtikala.Size = new System.Drawing.Size(210, 23);
            this.btnListaArtikala.TabIndex = 25;
            this.btnListaArtikala.Text = "Uvid u listu artikala";
            this.btnListaArtikala.UseVisualStyleBackColor = true;
            this.btnListaArtikala.Click += new System.EventHandler(this.btnListaArtikala_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(222, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "PDV:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Skladiste:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Dobavljac:";
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(82, 30);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(129, 20);
            this.txtSifra.TabIndex = 24;
            // 
            // cmbSkladista
            // 
            this.cmbSkladista.FormattingEnabled = true;
            this.cmbSkladista.Location = new System.Drawing.Point(412, 41);
            this.cmbSkladista.Name = "cmbSkladista";
            this.cmbSkladista.Size = new System.Drawing.Size(179, 21);
            this.cmbSkladista.TabIndex = 11;
            this.cmbSkladista.Validating += new System.ComponentModel.CancelEventHandler(this.cmbSkladista_Validating);
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(118, 68);
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.Size = new System.Drawing.Size(200, 20);
            this.txtNapomena.TabIndex = 5;
            this.txtNapomena.Validating += new System.ComponentModel.CancelEventHandler(this.txtNapomena_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Napomena:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(29, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Kolicina:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Sifra ar:";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(118, 43);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 20);
            this.dtpDatum.TabIndex = 3;
            // 
            // dgvStavkeNabavke
            // 
            this.dgvStavkeNabavke.AllowUserToAddRows = false;
            this.dgvStavkeNabavke.AllowUserToDeleteRows = false;
            this.dgvStavkeNabavke.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStavkeNabavke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvStavkeNabavke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStavkeNabavke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NabavkaStavkeId,
            this.Artikal,
            this.Sifra,
            this.Kolicina,
            this.Cijena});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStavkeNabavke.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvStavkeNabavke.Location = new System.Drawing.Point(23, 94);
            this.dgvStavkeNabavke.Name = "dgvStavkeNabavke";
            this.dgvStavkeNabavke.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStavkeNabavke.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvStavkeNabavke.Size = new System.Drawing.Size(454, 151);
            this.dgvStavkeNabavke.TabIndex = 23;
            // 
            // NabavkaStavkeId
            // 
            this.NabavkaStavkeId.HeaderText = "NabavkaStavkeId";
            this.NabavkaStavkeId.Name = "NabavkaStavkeId";
            this.NabavkaStavkeId.ReadOnly = true;
            this.NabavkaStavkeId.Visible = false;
            // 
            // Artikal
            // 
            this.Artikal.DataPropertyName = "Artikal";
            this.Artikal.HeaderText = "Artikal";
            this.Artikal.Name = "Artikal";
            this.Artikal.ReadOnly = true;
            // 
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Sifra";
            this.Sifra.Name = "Sifra";
            this.Sifra.ReadOnly = true;
            // 
            // Kolicina
            // 
            this.Kolicina.DataPropertyName = "Kolicina";
            this.Kolicina.HeaderText = "Kolicina";
            this.Kolicina.Name = "Kolicina";
            this.Kolicina.ReadOnly = true;
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            this.Cijena.ReadOnly = true;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(267, 56);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(75, 23);
            this.btnDodaj.TabIndex = 22;
            this.btnDodaj.Text = "Dodaj";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // txtKolicina
            // 
            this.txtKolicina.Location = new System.Drawing.Point(82, 56);
            this.txtKolicina.Name = "txtKolicina";
            this.txtKolicina.Size = new System.Drawing.Size(129, 20);
            this.txtKolicina.TabIndex = 21;
            this.txtKolicina.Validating += new System.ComponentModel.CancelEventHandler(this.txtKolicina_Validating);
            // 
            // cmbDobavljaci
            // 
            this.cmbDobavljaci.FormattingEnabled = true;
            this.cmbDobavljaci.Location = new System.Drawing.Point(412, 68);
            this.cmbDobavljaci.Name = "cmbDobavljaci";
            this.cmbDobavljaci.Size = new System.Drawing.Size(179, 21);
            this.cmbDobavljaci.TabIndex = 10;
            this.cmbDobavljaci.Validating += new System.ComponentModel.CancelEventHandler(this.cmbDobavljaci_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Datum nabavke:";
            // 
            // txtBrojNabavke
            // 
            this.txtBrojNabavke.Location = new System.Drawing.Point(118, 17);
            this.txtBrojNabavke.Name = "txtBrojNabavke";
            this.txtBrojNabavke.Size = new System.Drawing.Size(67, 20);
            this.txtBrojNabavke.TabIndex = 1;
            this.txtBrojNabavke.Validating += new System.ComponentModel.CancelEventHandler(this.txtBrojNabavke_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Broj nabavke:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnZakljuci);
            this.groupBox1.Controls.Add(this.txtPDV);
            this.groupBox1.Controls.Add(this.txtIznosRacuna);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.cmbSkladista);
            this.groupBox1.Controls.Add(this.cmbDobavljaci);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtNapomena);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpDatum);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBrojNabavke);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(32, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(611, 474);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nabavka";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnListaArtikala);
            this.groupBox2.Controls.Add(this.txtSifra);
            this.groupBox2.Controls.Add(this.dgvStavkeNabavke);
            this.groupBox2.Controls.Add(this.btnDodaj);
            this.groupBox2.Controls.Add(this.txtKolicina);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(0, 107);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 262);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Stavke nabavke";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmNovaNabavka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 524);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmNovaNabavka";
            this.Text = "frmNovaNabavka";
            this.Load += new System.EventHandler(this.frmNovaNabavka_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStavkeNabavke)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnZakljuci;
        private System.Windows.Forms.TextBox txtPDV;
        private System.Windows.Forms.TextBox txtIznosRacuna;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnListaArtikala;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.ComboBox cmbSkladista;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.DataGridView dgvStavkeNabavke;
        private System.Windows.Forms.DataGridViewTextBoxColumn NabavkaStavkeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artikal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kolicina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.TextBox txtKolicina;
        private System.Windows.Forms.ComboBox cmbDobavljaci;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBrojNabavke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}