namespace kafe.WinUI.Personel
{
    partial class UserPersonelislemleri
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            txtPersonelSifre = new TextBox();
            label9 = new Label();
            txtPersonelKullanici = new TextBox();
            label8 = new Label();
            dataGridView1 = new DataGridView();
            label7 = new Label();
            btnKaydet = new Button();
            dtpPersonelIseBaslama = new DateTimePicker();
            txtPersonelSoyadi = new TextBox();
            txtPersonelMaas = new TextBox();
            txtPersonelNotlar = new TextBox();
            txtPersonelAdi = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnFotograf = new Button();
            lblPersonel = new Label();
            pbFotograf = new PictureBox();
            openFileDialog1 = new OpenFileDialog();
            contextMenuStrip1 = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            bilgilerToolStripMenuItem = new ToolStripMenuItem();
            cmbPersonelId = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbFotograf).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPersonelSifre
            // 
            txtPersonelSifre.Location = new Point(557, 167);
            txtPersonelSifre.Name = "txtPersonelSifre";
            txtPersonelSifre.Size = new Size(250, 27);
            txtPersonelSifre.TabIndex = 41;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(426, 172);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 40;
            label9.Text = "Personel Şifre:";
            // 
            // txtPersonelKullanici
            // 
            txtPersonelKullanici.Location = new Point(557, 134);
            txtPersonelKullanici.Name = "txtPersonelKullanici";
            txtPersonelKullanici.Size = new Size(250, 27);
            txtPersonelKullanici.TabIndex = 39;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(426, 139);
            label8.Name = "label8";
            label8.Size = new Size(127, 20);
            label8.TabIndex = 38;
            label8.Text = "Personel Kullanıcı:";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 464);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1175, 371);
            dataGridView1.TabIndex = 37;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(426, 205);
            label7.Name = "label7";
            label7.Size = new Size(114, 20);
            label7.TabIndex = 35;
            label7.Text = "Personel Görevi:";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(840, 205);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(112, 41);
            btnKaydet.TabIndex = 34;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // dtpPersonelIseBaslama
            // 
            dtpPersonelIseBaslama.Location = new Point(557, 233);
            dtpPersonelIseBaslama.Name = "dtpPersonelIseBaslama";
            dtpPersonelIseBaslama.Size = new Size(250, 27);
            dtpPersonelIseBaslama.TabIndex = 33;
            // 
            // txtPersonelSoyadi
            // 
            txtPersonelSoyadi.Location = new Point(557, 101);
            txtPersonelSoyadi.Name = "txtPersonelSoyadi";
            txtPersonelSoyadi.Size = new Size(250, 27);
            txtPersonelSoyadi.TabIndex = 32;
            // 
            // txtPersonelMaas
            // 
            txtPersonelMaas.Location = new Point(557, 266);
            txtPersonelMaas.Name = "txtPersonelMaas";
            txtPersonelMaas.Size = new Size(250, 27);
            txtPersonelMaas.TabIndex = 31;
            // 
            // txtPersonelNotlar
            // 
            txtPersonelNotlar.Location = new Point(557, 299);
            txtPersonelNotlar.Multiline = true;
            txtPersonelNotlar.Name = "txtPersonelNotlar";
            txtPersonelNotlar.Size = new Size(250, 136);
            txtPersonelNotlar.TabIndex = 30;
            // 
            // txtPersonelAdi
            // 
            txtPersonelAdi.Location = new Point(557, 68);
            txtPersonelAdi.Name = "txtPersonelAdi";
            txtPersonelAdi.Size = new Size(250, 27);
            txtPersonelAdi.TabIndex = 29;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(488, 298);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 28;
            label6.Text = "Notlar:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(491, 267);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 27;
            label5.Text = "Maaşı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 236);
            label4.Name = "label4";
            label4.Size = new Size(188, 20);
            label4.TabIndex = 26;
            label4.Text = "Personel İşe Başlama Tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(426, 106);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 25;
            label3.Text = "Personel Soyadı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(448, 75);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 24;
            label2.Text = "Personel Adı:";
            // 
            // btnFotograf
            // 
            btnFotograf.Location = new Point(145, 309);
            btnFotograf.Name = "btnFotograf";
            btnFotograf.Size = new Size(100, 54);
            btnFotograf.TabIndex = 23;
            btnFotograf.Text = "Fotoğraf Seç";
            btnFotograf.UseVisualStyleBackColor = true;
            btnFotograf.Click += btnFotograf_Click;
            // 
            // lblPersonel
            // 
            lblPersonel.AutoSize = true;
            lblPersonel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPersonel.Location = new Point(435, 13);
            lblPersonel.Name = "lblPersonel";
            lblPersonel.Size = new Size(246, 41);
            lblPersonel.TabIndex = 22;
            lblPersonel.Text = "Personel Ekleme";
            // 
            // pbFotograf
            // 
            pbFotograf.BorderStyle = BorderStyle.FixedSingle;
            pbFotograf.Location = new Point(104, 103);
            pbFotograf.Name = "pbFotograf";
            pbFotograf.Size = new Size(178, 200);
            pbFotograf.TabIndex = 21;
            pbFotograf.TabStop = false;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem, güncelleToolStripMenuItem, bilgilerToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(136, 76);
            // 
            // silToolStripMenuItem
            // 
            silToolStripMenuItem.Name = "silToolStripMenuItem";
            silToolStripMenuItem.Size = new Size(135, 24);
            silToolStripMenuItem.Text = "Sil";
            silToolStripMenuItem.Click += silToolStripMenuItem_Click;
            // 
            // güncelleToolStripMenuItem
            // 
            güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            güncelleToolStripMenuItem.Size = new Size(135, 24);
            güncelleToolStripMenuItem.Text = "Güncelle";
            güncelleToolStripMenuItem.Click += güncelleToolStripMenuItem_Click;
            // 
            // bilgilerToolStripMenuItem
            // 
            bilgilerToolStripMenuItem.Name = "bilgilerToolStripMenuItem";
            bilgilerToolStripMenuItem.Size = new Size(135, 24);
            bilgilerToolStripMenuItem.Text = "Bilgiler";
            bilgilerToolStripMenuItem.Click += bilgilerToolStripMenuItem_Click;
            // 
            // cmbPersonelId
            // 
            cmbPersonelId.FormattingEnabled = true;
            cmbPersonelId.Items.AddRange(new object[] { "Admin", "Personel" });
            cmbPersonelId.Location = new Point(557, 200);
            cmbPersonelId.Name = "cmbPersonelId";
            cmbPersonelId.Size = new Size(250, 28);
            cmbPersonelId.TabIndex = 42;
            // 
            // UserPersonelislemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(cmbPersonelId);
            Controls.Add(txtPersonelSifre);
            Controls.Add(label9);
            Controls.Add(txtPersonelKullanici);
            Controls.Add(label8);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(btnKaydet);
            Controls.Add(dtpPersonelIseBaslama);
            Controls.Add(txtPersonelSoyadi);
            Controls.Add(txtPersonelMaas);
            Controls.Add(txtPersonelNotlar);
            Controls.Add(txtPersonelAdi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnFotograf);
            Controls.Add(lblPersonel);
            Controls.Add(pbFotograf);
            Name = "UserPersonelislemleri";
            Size = new Size(1175, 835);
            Load += UserPersonelislemleri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbFotograf).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPersonelSifre;
        private Label label9;
        private TextBox txtPersonelKullanici;
        private Label label8;
        private DataGridView dataGridView1;
        private Label label7;
        private Button btnKaydet;
        private DateTimePicker dtpPersonelIseBaslama;
        private TextBox txtPersonelSoyadi;
        private TextBox txtPersonelMaas;
        private TextBox txtPersonelNotlar;
        private TextBox txtPersonelAdi;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button btnFotograf;
        private Label lblPersonel;
        private PictureBox pbFotograf;
        private OpenFileDialog openFileDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private ToolStripMenuItem bilgilerToolStripMenuItem;
        private ComboBox cmbPersonelId;
    }
}
