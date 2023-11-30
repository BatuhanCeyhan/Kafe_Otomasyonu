namespace kafe.Urunler
{
    partial class UserUrunIslemleri
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            btnKaydet = new Button();
            txtUcret = new TextBox();
            txtUrunAdi = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            btnFotograf = new Button();
            label1 = new Label();
            pbfotograf = new PictureBox();
            cmbUrunBoyutu = new ComboBox();
            label4 = new Label();
            txtNasilYapilir = new TextBox();
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            bilgiToolStripMenuItem = new ToolStripMenuItem();
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            cmbUrunSinifi = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pbfotograf).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(571, 385);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(112, 41);
            btnKaydet.TabIndex = 27;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // txtUcret
            // 
            txtUcret.Location = new Point(501, 187);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(250, 27);
            txtUcret.TabIndex = 24;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Location = new Point(501, 109);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(250, 27);
            txtUrunAdi.TabIndex = 22;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(409, 227);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 21;
            label6.Text = "Ürün Boyutu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(451, 192);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 20;
            label5.Text = "Ücreti:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(422, 150);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 18;
            label3.Text = "Ürün Sınıfı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(432, 116);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 17;
            label2.Text = "Ürün Adı:";
            // 
            // btnFotograf
            // 
            btnFotograf.Location = new Point(89, 315);
            btnFotograf.Name = "btnFotograf";
            btnFotograf.Size = new Size(100, 54);
            btnFotograf.TabIndex = 16;
            btnFotograf.Text = "Fotoğraf Seç";
            btnFotograf.UseVisualStyleBackColor = true;
            btnFotograf.Click += btnFotograf_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(319, 26);
            label1.Name = "label1";
            label1.Size = new Size(217, 41);
            label1.TabIndex = 15;
            label1.Text = "Ürün İşlemleri";
            // 
            // pbfotograf
            // 
            pbfotograf.BorderStyle = BorderStyle.FixedSingle;
            pbfotograf.Location = new Point(48, 109);
            pbfotograf.Name = "pbfotograf";
            pbfotograf.Size = new Size(178, 200);
            pbfotograf.TabIndex = 14;
            pbfotograf.TabStop = false;
            // 
            // cmbUrunBoyutu
            // 
            cmbUrunBoyutu.FormattingEnabled = true;
            cmbUrunBoyutu.Items.AddRange(new object[] { "Küçük", "Orta", "Birim", "Büyük" });
            cmbUrunBoyutu.Location = new Point(501, 223);
            cmbUrunBoyutu.Name = "cmbUrunBoyutu";
            cmbUrunBoyutu.Size = new Size(250, 28);
            cmbUrunBoyutu.TabIndex = 28;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(412, 259);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 29;
            label4.Text = "Nasıl Yapılır:";
            // 
            // txtNasilYapilir
            // 
            txtNasilYapilir.Location = new Point(501, 257);
            txtNasilYapilir.Multiline = true;
            txtNasilYapilir.Name = "txtNasilYapilir";
            txtNasilYapilir.Size = new Size(250, 98);
            txtNasilYapilir.TabIndex = 30;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(0, 524);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(912, 149);
            dataGridView1.TabIndex = 32;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem, bilgiToolStripMenuItem, güncelleToolStripMenuItem });
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
            // bilgiToolStripMenuItem
            // 
            bilgiToolStripMenuItem.Name = "bilgiToolStripMenuItem";
            bilgiToolStripMenuItem.Size = new Size(135, 24);
            bilgiToolStripMenuItem.Text = "Bilgi";
            bilgiToolStripMenuItem.Click += bilgiToolStripMenuItem_Click;
            // 
            // güncelleToolStripMenuItem
            // 
            güncelleToolStripMenuItem.Name = "güncelleToolStripMenuItem";
            güncelleToolStripMenuItem.Size = new Size(135, 24);
            güncelleToolStripMenuItem.Text = "Güncelle";
            güncelleToolStripMenuItem.Click += güncelleToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // cmbUrunSinifi
            // 
            cmbUrunSinifi.FormattingEnabled = true;
            cmbUrunSinifi.Items.AddRange(new object[] { "Soğuk İçecek", "Meşrubat", "Kahveler", "Sıcak İçecekler", "Tatlılar", "Sandviç" });
            cmbUrunSinifi.Location = new Point(501, 147);
            cmbUrunSinifi.Name = "cmbUrunSinifi";
            cmbUrunSinifi.Size = new Size(250, 28);
            cmbUrunSinifi.TabIndex = 34;
            // 
            // UserUrunIslemleri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbUrunSinifi);
            Controls.Add(dataGridView1);
            Controls.Add(txtNasilYapilir);
            Controls.Add(label4);
            Controls.Add(cmbUrunBoyutu);
            Controls.Add(btnKaydet);
            Controls.Add(txtUcret);
            Controls.Add(txtUrunAdi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(btnFotograf);
            Controls.Add(label1);
            Controls.Add(pbfotograf);
            Name = "UserUrunIslemleri";
            Size = new Size(915, 676);
            Load += UserUrunIslemleri_Load;
            ((System.ComponentModel.ISupportInitialize)pbfotograf).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private TextBox txtUcret;
        private TextBox txtUrunAdi;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private Button btnFotograf;
        private Label label1;
        private PictureBox pbfotograf;
        private ComboBox cmbUrunBoyutu;
        private Label label4;
        private TextBox txtNasilYapilir;
        private DataGridView dataGridView1;
        private OpenFileDialog openFileDialog1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem bilgiToolStripMenuItem;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private ComboBox cmbUrunSinifi;
    }
}
