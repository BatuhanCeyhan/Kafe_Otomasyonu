namespace kafe.WinUI.Personel
{
    partial class UserPersonelBilgi
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
            lblPersonel = new Label();
            pbFotograf = new PictureBox();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            eKLEToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)pbFotograf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtPersonelSifre
            // 
            txtPersonelSifre.Enabled = false;
            txtPersonelSifre.Location = new Point(643, 191);
            txtPersonelSifre.Name = "txtPersonelSifre";
            txtPersonelSifre.Size = new Size(250, 27);
            txtPersonelSifre.TabIndex = 61;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(512, 196);
            label9.Name = "label9";
            label9.Size = new Size(101, 20);
            label9.TabIndex = 60;
            label9.Text = "Personel Şifre:";
            // 
            // txtPersonelKullanici
            // 
            txtPersonelKullanici.Enabled = false;
            txtPersonelKullanici.Location = new Point(643, 158);
            txtPersonelKullanici.Name = "txtPersonelKullanici";
            txtPersonelKullanici.Size = new Size(250, 27);
            txtPersonelKullanici.TabIndex = 59;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(512, 163);
            label8.Name = "label8";
            label8.Size = new Size(127, 20);
            label8.TabIndex = 58;
            label8.Text = "Personel Kullanıcı:";
            // 
            // dtpPersonelIseBaslama
            // 
            dtpPersonelIseBaslama.Enabled = false;
            dtpPersonelIseBaslama.Location = new Point(643, 224);
            dtpPersonelIseBaslama.Name = "dtpPersonelIseBaslama";
            dtpPersonelIseBaslama.Size = new Size(250, 27);
            dtpPersonelIseBaslama.TabIndex = 54;
            // 
            // txtPersonelSoyadi
            // 
            txtPersonelSoyadi.Enabled = false;
            txtPersonelSoyadi.Location = new Point(643, 125);
            txtPersonelSoyadi.Name = "txtPersonelSoyadi";
            txtPersonelSoyadi.Size = new Size(250, 27);
            txtPersonelSoyadi.TabIndex = 53;
            // 
            // txtPersonelMaas
            // 
            txtPersonelMaas.Enabled = false;
            txtPersonelMaas.Location = new Point(643, 257);
            txtPersonelMaas.Name = "txtPersonelMaas";
            txtPersonelMaas.Size = new Size(250, 27);
            txtPersonelMaas.TabIndex = 52;
            // 
            // txtPersonelNotlar
            // 
            txtPersonelNotlar.Enabled = false;
            txtPersonelNotlar.Location = new Point(643, 290);
            txtPersonelNotlar.Multiline = true;
            txtPersonelNotlar.Name = "txtPersonelNotlar";
            txtPersonelNotlar.Size = new Size(250, 136);
            txtPersonelNotlar.TabIndex = 51;
            // 
            // txtPersonelAdi
            // 
            txtPersonelAdi.Enabled = false;
            txtPersonelAdi.Location = new Point(643, 92);
            txtPersonelAdi.Name = "txtPersonelAdi";
            txtPersonelAdi.Size = new Size(250, 27);
            txtPersonelAdi.TabIndex = 50;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(574, 289);
            label6.Name = "label6";
            label6.Size = new Size(54, 20);
            label6.TabIndex = 49;
            label6.Text = "Notlar:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(577, 258);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 48;
            label5.Text = "Maaşı:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(440, 227);
            label4.Name = "label4";
            label4.Size = new Size(188, 20);
            label4.TabIndex = 47;
            label4.Text = "Personel İşe Başlama Tarihi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(512, 130);
            label3.Name = "label3";
            label3.Size = new Size(116, 20);
            label3.TabIndex = 46;
            label3.Text = "Personel Soyadı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(534, 99);
            label2.Name = "label2";
            label2.Size = new Size(94, 20);
            label2.TabIndex = 45;
            label2.Text = "Personel Adı:";
            // 
            // lblPersonel
            // 
            lblPersonel.AutoSize = true;
            lblPersonel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPersonel.Location = new Point(418, 34);
            lblPersonel.Name = "lblPersonel";
            lblPersonel.Size = new Size(210, 41);
            lblPersonel.TabIndex = 43;
            lblPersonel.Text = "Personel Bilgi";
            // 
            // pbFotograf
            // 
            pbFotograf.BorderStyle = BorderStyle.FixedSingle;
            pbFotograf.Location = new Point(163, 109);
            pbFotograf.Name = "pbFotograf";
            pbFotograf.Size = new Size(178, 200);
            pbFotograf.TabIndex = 42;
            pbFotograf.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(3, 467);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1140, 341);
            dataGridView1.TabIndex = 62;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem, güncelleToolStripMenuItem, eKLEToolStripMenuItem });
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
            // eKLEToolStripMenuItem
            // 
            eKLEToolStripMenuItem.Name = "eKLEToolStripMenuItem";
            eKLEToolStripMenuItem.Size = new Size(135, 24);
            eKLEToolStripMenuItem.Text = "Ekle";
            eKLEToolStripMenuItem.Click += eKLEToolStripMenuItem_Click;
            // 
            // UserPersonelBilgi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(dataGridView1);
            Controls.Add(txtPersonelSifre);
            Controls.Add(label9);
            Controls.Add(txtPersonelKullanici);
            Controls.Add(label8);
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
            Controls.Add(lblPersonel);
            Controls.Add(pbFotograf);
            Name = "UserPersonelBilgi";
            Size = new Size(1146, 808);
            Load += UserPersonelBilgi_Load;
            ((System.ComponentModel.ISupportInitialize)pbFotograf).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPersonelSifre;
        private Label label9;
        private TextBox txtPersonelKullanici;
        private Label label8;
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
        private Label lblPersonel;
        private PictureBox pbFotograf;
        private DataGridView dataGridView1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private ToolStripMenuItem eKLEToolStripMenuItem;
    }
}
