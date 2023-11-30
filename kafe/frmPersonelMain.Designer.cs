namespace kafe.WinUI
{
    partial class frmPersonelMain
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
            grb_Menu = new GroupBox();
            btnExcel = new Button();
            btn_Menu_Geri = new Button();
            dgv_Menu = new DataGridView();
            grb_Adisyon = new GroupBox();
            btn_Adisyon_Geri = new Button();
            btn_Adisyon_Odeme = new Button();
            dataGridView1 = new DataGridView();
            label12 = new Label();
            label11 = new Label();
            cmb_Adisyon_Masa = new ComboBox();
            label10 = new Label();
            grb_Siparis = new GroupBox();
            checkBox4 = new CheckBox();
            checkBox3 = new CheckBox();
            checkBox2 = new CheckBox();
            checkBox1 = new CheckBox();
            btn_Siparis_Geri = new Button();
            dataGridView_Siparis = new DataGridView();
            btn_Siparis_Sil = new Button();
            btn_Siparis_Ekle = new Button();
            cmb_Tatli = new ComboBox();
            cmb_Sandvic = new ComboBox();
            cmb_Mesrubatlar = new ComboBox();
            cmb_Kahve = new ComboBox();
            cmb_Sogukİcecek = new ComboBox();
            cmb_Sicakİcecek = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            cmb_MasaNumarasi = new ComboBox();
            label1 = new Label();
            grb_MasaTasi = new GroupBox();
            btn_MasaTasi_Geri = new Button();
            dataGridView_Masa_Tasi = new DataGridView();
            btn_Tasi = new Button();
            cmb_TasınılanMasa = new ComboBox();
            cmb_TasinacakMasa = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            btn_Adisyon = new Button();
            btn_Cikis = new Button();
            btn_Menu = new Button();
            btn_MasaTasi = new Button();
            btn_SiparisAlma = new Button();
            openFileDialog1 = new OpenFileDialog();
            grb_Menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_Menu).BeginInit();
            grb_Adisyon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            grb_Siparis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Siparis).BeginInit();
            grb_MasaTasi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Masa_Tasi).BeginInit();
            SuspendLayout();
            // 
            // grb_Menu
            // 
            grb_Menu.Controls.Add(btnExcel);
            grb_Menu.Controls.Add(btn_Menu_Geri);
            grb_Menu.Controls.Add(dgv_Menu);
            grb_Menu.Location = new Point(1027, 12);
            grb_Menu.Name = "grb_Menu";
            grb_Menu.Size = new Size(754, 476);
            grb_Menu.TabIndex = 24;
            grb_Menu.TabStop = false;
            grb_Menu.Text = "Menü";
            grb_Menu.UseWaitCursor = true;
            // 
            // btnExcel
            // 
            btnExcel.Location = new Point(297, 417);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(94, 29);
            btnExcel.TabIndex = 2;
            btnExcel.Text = "Dosyayı Aç";
            btnExcel.UseVisualStyleBackColor = true;
            btnExcel.UseWaitCursor = true;
            btnExcel.Click += btnExcel_Click;
            // 
            // btn_Menu_Geri
            // 
            btn_Menu_Geri.Location = new Point(413, 417);
            btn_Menu_Geri.Name = "btn_Menu_Geri";
            btn_Menu_Geri.Size = new Size(94, 29);
            btn_Menu_Geri.TabIndex = 1;
            btn_Menu_Geri.Text = "Geri";
            btn_Menu_Geri.UseVisualStyleBackColor = true;
            btn_Menu_Geri.UseWaitCursor = true;
            btn_Menu_Geri.Click += btn_Menu_Geri_Click;
            // 
            // dgv_Menu
            // 
            dgv_Menu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_Menu.Location = new Point(38, 49);
            dgv_Menu.Name = "dgv_Menu";
            dgv_Menu.RowHeadersWidth = 51;
            dgv_Menu.RowTemplate.Height = 29;
            dgv_Menu.Size = new Size(709, 335);
            dgv_Menu.TabIndex = 0;
            dgv_Menu.UseWaitCursor = true;
            // 
            // grb_Adisyon
            // 
            grb_Adisyon.Controls.Add(btn_Adisyon_Geri);
            grb_Adisyon.Controls.Add(btn_Adisyon_Odeme);
            grb_Adisyon.Controls.Add(dataGridView1);
            grb_Adisyon.Controls.Add(label12);
            grb_Adisyon.Controls.Add(label11);
            grb_Adisyon.Controls.Add(cmb_Adisyon_Masa);
            grb_Adisyon.Controls.Add(label10);
            grb_Adisyon.Location = new Point(235, 477);
            grb_Adisyon.Name = "grb_Adisyon";
            grb_Adisyon.Size = new Size(760, 476);
            grb_Adisyon.TabIndex = 25;
            grb_Adisyon.TabStop = false;
            grb_Adisyon.Text = "Adisyon";
            grb_Adisyon.UseWaitCursor = true;
            // 
            // btn_Adisyon_Geri
            // 
            btn_Adisyon_Geri.Location = new Point(129, 195);
            btn_Adisyon_Geri.Name = "btn_Adisyon_Geri";
            btn_Adisyon_Geri.Size = new Size(94, 29);
            btn_Adisyon_Geri.TabIndex = 6;
            btn_Adisyon_Geri.Text = "Geri";
            btn_Adisyon_Geri.UseVisualStyleBackColor = true;
            btn_Adisyon_Geri.UseWaitCursor = true;
            btn_Adisyon_Geri.Click += btn_Adisyon_Geri_Click;
            // 
            // btn_Adisyon_Odeme
            // 
            btn_Adisyon_Odeme.Location = new Point(129, 151);
            btn_Adisyon_Odeme.Name = "btn_Adisyon_Odeme";
            btn_Adisyon_Odeme.Size = new Size(94, 29);
            btn_Adisyon_Odeme.TabIndex = 5;
            btn_Adisyon_Odeme.Text = "Ödeme";
            btn_Adisyon_Odeme.UseVisualStyleBackColor = true;
            btn_Adisyon_Odeme.UseWaitCursor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(348, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(390, 397);
            dataGridView1.TabIndex = 4;
            dataGridView1.UseWaitCursor = true;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(142, 102);
            label12.Name = "label12";
            label12.Size = new Size(58, 20);
            label12.TabIndex = 3;
            label12.Text = "label12";
            label12.UseWaitCursor = true;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(76, 102);
            label11.Name = "label11";
            label11.Size = new Size(62, 20);
            label11.TabIndex = 2;
            label11.Text = "Toplam:";
            label11.UseWaitCursor = true;
            // 
            // cmb_Adisyon_Masa
            // 
            cmb_Adisyon_Masa.FormattingEnabled = true;
            cmb_Adisyon_Masa.Location = new Point(129, 49);
            cmb_Adisyon_Masa.Name = "cmb_Adisyon_Masa";
            cmb_Adisyon_Masa.Size = new Size(151, 28);
            cmb_Adisyon_Masa.TabIndex = 1;
            cmb_Adisyon_Masa.UseWaitCursor = true;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(76, 52);
            label10.Name = "label10";
            label10.Size = new Size(47, 20);
            label10.TabIndex = 0;
            label10.Text = "Masa:";
            label10.UseWaitCursor = true;
            // 
            // grb_Siparis
            // 
            grb_Siparis.Controls.Add(checkBox4);
            grb_Siparis.Controls.Add(checkBox3);
            grb_Siparis.Controls.Add(checkBox2);
            grb_Siparis.Controls.Add(checkBox1);
            grb_Siparis.Controls.Add(btn_Siparis_Geri);
            grb_Siparis.Controls.Add(dataGridView_Siparis);
            grb_Siparis.Controls.Add(btn_Siparis_Sil);
            grb_Siparis.Controls.Add(btn_Siparis_Ekle);
            grb_Siparis.Controls.Add(cmb_Tatli);
            grb_Siparis.Controls.Add(cmb_Sandvic);
            grb_Siparis.Controls.Add(cmb_Mesrubatlar);
            grb_Siparis.Controls.Add(cmb_Kahve);
            grb_Siparis.Controls.Add(cmb_Sogukİcecek);
            grb_Siparis.Controls.Add(cmb_Sicakİcecek);
            grb_Siparis.Controls.Add(label7);
            grb_Siparis.Controls.Add(label6);
            grb_Siparis.Controls.Add(label5);
            grb_Siparis.Controls.Add(label4);
            grb_Siparis.Controls.Add(label3);
            grb_Siparis.Controls.Add(label2);
            grb_Siparis.Controls.Add(cmb_MasaNumarasi);
            grb_Siparis.Controls.Add(label1);
            grb_Siparis.Location = new Point(1027, 511);
            grb_Siparis.Name = "grb_Siparis";
            grb_Siparis.Size = new Size(760, 462);
            grb_Siparis.TabIndex = 23;
            grb_Siparis.TabStop = false;
            grb_Siparis.Text = "Sipariş";
            grb_Siparis.UseWaitCursor = true;
            // 
            // checkBox4
            // 
            checkBox4.AutoSize = true;
            checkBox4.Location = new Point(181, 310);
            checkBox4.Name = "checkBox4";
            checkBox4.Size = new Size(60, 24);
            checkBox4.TabIndex = 20;
            checkBox4.Text = "Orta";
            checkBox4.UseVisualStyleBackColor = true;
            checkBox4.UseWaitCursor = true;
            // 
            // checkBox3
            // 
            checkBox3.AutoSize = true;
            checkBox3.Location = new Point(247, 310);
            checkBox3.Name = "checkBox3";
            checkBox3.Size = new Size(70, 24);
            checkBox3.TabIndex = 19;
            checkBox3.Text = "Büyük";
            checkBox3.UseVisualStyleBackColor = true;
            checkBox3.UseWaitCursor = true;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(111, 310);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(70, 24);
            checkBox2.TabIndex = 18;
            checkBox2.Text = "Küçük";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.UseWaitCursor = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(46, 310);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(66, 24);
            checkBox1.TabIndex = 17;
            checkBox1.Text = "Birim";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.UseWaitCursor = true;
            // 
            // btn_Siparis_Geri
            // 
            btn_Siparis_Geri.Location = new Point(179, 411);
            btn_Siparis_Geri.Name = "btn_Siparis_Geri";
            btn_Siparis_Geri.Size = new Size(94, 29);
            btn_Siparis_Geri.TabIndex = 7;
            btn_Siparis_Geri.Text = "Geri";
            btn_Siparis_Geri.UseVisualStyleBackColor = true;
            btn_Siparis_Geri.UseWaitCursor = true;
            btn_Siparis_Geri.Click += btn_Siparis_Geri_Click;
            // 
            // dataGridView_Siparis
            // 
            dataGridView_Siparis.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Siparis.Location = new Point(376, 26);
            dataGridView_Siparis.Name = "dataGridView_Siparis";
            dataGridView_Siparis.RowHeadersWidth = 51;
            dataGridView_Siparis.RowTemplate.Height = 29;
            dataGridView_Siparis.Size = new Size(354, 405);
            dataGridView_Siparis.TabIndex = 16;
            dataGridView_Siparis.UseWaitCursor = true;
            // 
            // btn_Siparis_Sil
            // 
            btn_Siparis_Sil.Location = new Point(223, 358);
            btn_Siparis_Sil.Name = "btn_Siparis_Sil";
            btn_Siparis_Sil.Size = new Size(94, 29);
            btn_Siparis_Sil.TabIndex = 15;
            btn_Siparis_Sil.Text = "Sil";
            btn_Siparis_Sil.UseVisualStyleBackColor = true;
            btn_Siparis_Sil.UseWaitCursor = true;
            // 
            // btn_Siparis_Ekle
            // 
            btn_Siparis_Ekle.Location = new Point(111, 358);
            btn_Siparis_Ekle.Name = "btn_Siparis_Ekle";
            btn_Siparis_Ekle.Size = new Size(94, 29);
            btn_Siparis_Ekle.TabIndex = 14;
            btn_Siparis_Ekle.Text = "Ekle";
            btn_Siparis_Ekle.UseVisualStyleBackColor = true;
            btn_Siparis_Ekle.UseWaitCursor = true;
            // 
            // cmb_Tatli
            // 
            cmb_Tatli.FormattingEnabled = true;
            cmb_Tatli.Location = new Point(179, 260);
            cmb_Tatli.Name = "cmb_Tatli";
            cmb_Tatli.Size = new Size(151, 28);
            cmb_Tatli.TabIndex = 13;
            cmb_Tatli.UseWaitCursor = true;
            // 
            // cmb_Sandvic
            // 
            cmb_Sandvic.FormattingEnabled = true;
            cmb_Sandvic.Location = new Point(179, 226);
            cmb_Sandvic.Name = "cmb_Sandvic";
            cmb_Sandvic.Size = new Size(151, 28);
            cmb_Sandvic.TabIndex = 12;
            cmb_Sandvic.UseWaitCursor = true;
            // 
            // cmb_Mesrubatlar
            // 
            cmb_Mesrubatlar.FormattingEnabled = true;
            cmb_Mesrubatlar.Location = new Point(179, 194);
            cmb_Mesrubatlar.Name = "cmb_Mesrubatlar";
            cmb_Mesrubatlar.Size = new Size(151, 28);
            cmb_Mesrubatlar.TabIndex = 11;
            cmb_Mesrubatlar.UseWaitCursor = true;
            // 
            // cmb_Kahve
            // 
            cmb_Kahve.FormattingEnabled = true;
            cmb_Kahve.Location = new Point(179, 160);
            cmb_Kahve.Name = "cmb_Kahve";
            cmb_Kahve.Size = new Size(151, 28);
            cmb_Kahve.TabIndex = 10;
            cmb_Kahve.UseWaitCursor = true;
            // 
            // cmb_Sogukİcecek
            // 
            cmb_Sogukİcecek.FormattingEnabled = true;
            cmb_Sogukİcecek.Location = new Point(179, 125);
            cmb_Sogukİcecek.Name = "cmb_Sogukİcecek";
            cmb_Sogukİcecek.Size = new Size(151, 28);
            cmb_Sogukİcecek.TabIndex = 9;
            cmb_Sogukİcecek.UseWaitCursor = true;
            // 
            // cmb_Sicakİcecek
            // 
            cmb_Sicakİcecek.FormattingEnabled = true;
            cmb_Sicakİcecek.Location = new Point(179, 91);
            cmb_Sicakİcecek.Name = "cmb_Sicakİcecek";
            cmb_Sicakİcecek.Size = new Size(151, 28);
            cmb_Sicakİcecek.TabIndex = 8;
            cmb_Sicakİcecek.UseWaitCursor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(59, 94);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 7;
            label7.Text = "Sıcak İçecekler:";
            label7.UseWaitCursor = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(87, 226);
            label6.Name = "label6";
            label6.Size = new Size(80, 20);
            label6.TabIndex = 6;
            label6.Text = "Sandviçler:";
            label6.UseWaitCursor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(111, 260);
            label5.Name = "label5";
            label5.Size = new Size(56, 20);
            label5.TabIndex = 5;
            label5.Text = "Tatlılar:";
            label5.UseWaitCursor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(98, 160);
            label4.Name = "label4";
            label4.Size = new Size(69, 20);
            label4.TabIndex = 4;
            label4.Text = "Kahveler:";
            label4.UseWaitCursor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(76, 193);
            label3.Name = "label3";
            label3.Size = new Size(91, 20);
            label3.TabIndex = 3;
            label3.Text = "Meşrubatlar:";
            label3.UseWaitCursor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 127);
            label2.Name = "label2";
            label2.Size = new Size(114, 20);
            label2.TabIndex = 2;
            label2.Text = "Soğuk Kahveler:";
            label2.UseWaitCursor = true;
            // 
            // cmb_MasaNumarasi
            // 
            cmb_MasaNumarasi.FormattingEnabled = true;
            cmb_MasaNumarasi.Location = new Point(179, 49);
            cmb_MasaNumarasi.Name = "cmb_MasaNumarasi";
            cmb_MasaNumarasi.Size = new Size(151, 28);
            cmb_MasaNumarasi.TabIndex = 1;
            cmb_MasaNumarasi.UseWaitCursor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 49);
            label1.Name = "label1";
            label1.Size = new Size(114, 20);
            label1.TabIndex = 0;
            label1.Text = "Masa Numarası:";
            label1.UseWaitCursor = true;
            // 
            // grb_MasaTasi
            // 
            grb_MasaTasi.Controls.Add(btn_MasaTasi_Geri);
            grb_MasaTasi.Controls.Add(dataGridView_Masa_Tasi);
            grb_MasaTasi.Controls.Add(btn_Tasi);
            grb_MasaTasi.Controls.Add(cmb_TasınılanMasa);
            grb_MasaTasi.Controls.Add(cmb_TasinacakMasa);
            grb_MasaTasi.Controls.Add(label9);
            grb_MasaTasi.Controls.Add(label8);
            grb_MasaTasi.Location = new Point(247, 9);
            grb_MasaTasi.Name = "grb_MasaTasi";
            grb_MasaTasi.Size = new Size(774, 462);
            grb_MasaTasi.TabIndex = 26;
            grb_MasaTasi.TabStop = false;
            grb_MasaTasi.Text = "Masa Taşı";
            grb_MasaTasi.UseWaitCursor = true;
            // 
            // btn_MasaTasi_Geri
            // 
            btn_MasaTasi_Geri.Location = new Point(173, 194);
            btn_MasaTasi_Geri.Name = "btn_MasaTasi_Geri";
            btn_MasaTasi_Geri.Size = new Size(94, 29);
            btn_MasaTasi_Geri.TabIndex = 6;
            btn_MasaTasi_Geri.Text = "Geri";
            btn_MasaTasi_Geri.UseVisualStyleBackColor = true;
            btn_MasaTasi_Geri.UseWaitCursor = true;
            btn_MasaTasi_Geri.Click += btn_MasaTasi_Geri_Click;
            // 
            // dataGridView_Masa_Tasi
            // 
            dataGridView_Masa_Tasi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView_Masa_Tasi.Location = new Point(405, 26);
            dataGridView_Masa_Tasi.Name = "dataGridView_Masa_Tasi";
            dataGridView_Masa_Tasi.RowHeadersWidth = 51;
            dataGridView_Masa_Tasi.RowTemplate.Height = 29;
            dataGridView_Masa_Tasi.Size = new Size(300, 262);
            dataGridView_Masa_Tasi.TabIndex = 5;
            dataGridView_Masa_Tasi.UseWaitCursor = true;
            // 
            // btn_Tasi
            // 
            btn_Tasi.Location = new Point(173, 152);
            btn_Tasi.Name = "btn_Tasi";
            btn_Tasi.Size = new Size(94, 29);
            btn_Tasi.TabIndex = 4;
            btn_Tasi.Text = "Taşı";
            btn_Tasi.UseVisualStyleBackColor = true;
            btn_Tasi.UseWaitCursor = true;
            btn_Tasi.Click += btn_Tasi_Click;
            // 
            // cmb_TasınılanMasa
            // 
            cmb_TasınılanMasa.FormattingEnabled = true;
            cmb_TasınılanMasa.Location = new Point(206, 94);
            cmb_TasınılanMasa.Name = "cmb_TasınılanMasa";
            cmb_TasınılanMasa.Size = new Size(151, 28);
            cmb_TasınılanMasa.TabIndex = 3;
            cmb_TasınılanMasa.UseWaitCursor = true;
            // 
            // cmb_TasinacakMasa
            // 
            cmb_TasinacakMasa.FormattingEnabled = true;
            cmb_TasinacakMasa.Location = new Point(206, 46);
            cmb_TasinacakMasa.Name = "cmb_TasinacakMasa";
            cmb_TasinacakMasa.Size = new Size(151, 28);
            cmb_TasinacakMasa.TabIndex = 2;
            cmb_TasinacakMasa.UseWaitCursor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(87, 49);
            label9.Name = "label9";
            label9.Size = new Size(113, 20);
            label9.TabIndex = 1;
            label9.Text = "Taşınacak Masa:";
            label9.UseWaitCursor = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(93, 102);
            label8.Name = "label8";
            label8.Size = new Size(107, 20);
            label8.TabIndex = 0;
            label8.Text = "Taşınılan Masa:";
            label8.UseWaitCursor = true;
            // 
            // btn_Adisyon
            // 
            btn_Adisyon.Location = new Point(22, 215);
            btn_Adisyon.Name = "btn_Adisyon";
            btn_Adisyon.Size = new Size(125, 73);
            btn_Adisyon.TabIndex = 22;
            btn_Adisyon.Text = "Adisyon";
            btn_Adisyon.UseVisualStyleBackColor = true;
            btn_Adisyon.UseWaitCursor = true;
            btn_Adisyon.Click += btn_Adisyon_Click;
            // 
            // btn_Cikis
            // 
            btn_Cikis.Location = new Point(22, 398);
            btn_Cikis.Name = "btn_Cikis";
            btn_Cikis.Size = new Size(125, 73);
            btn_Cikis.TabIndex = 21;
            btn_Cikis.Text = "Çıkış";
            btn_Cikis.UseVisualStyleBackColor = true;
            btn_Cikis.UseWaitCursor = true;
            btn_Cikis.Click += btn_Cikis_Click;
            // 
            // btn_Menu
            // 
            btn_Menu.Location = new Point(22, 305);
            btn_Menu.Name = "btn_Menu";
            btn_Menu.Size = new Size(125, 73);
            btn_Menu.TabIndex = 20;
            btn_Menu.Text = "Menü";
            btn_Menu.UseVisualStyleBackColor = true;
            btn_Menu.UseWaitCursor = true;
            btn_Menu.Click += btn_Menu_Click;
            // 
            // btn_MasaTasi
            // 
            btn_MasaTasi.Location = new Point(22, 126);
            btn_MasaTasi.Name = "btn_MasaTasi";
            btn_MasaTasi.Size = new Size(125, 73);
            btn_MasaTasi.TabIndex = 19;
            btn_MasaTasi.Text = "Masa Taşı";
            btn_MasaTasi.UseVisualStyleBackColor = true;
            btn_MasaTasi.UseWaitCursor = true;
            btn_MasaTasi.Click += btn_MasaTasi_Click;
            // 
            // btn_SiparisAlma
            // 
            btn_SiparisAlma.Location = new Point(22, 38);
            btn_SiparisAlma.Name = "btn_SiparisAlma";
            btn_SiparisAlma.Size = new Size(125, 73);
            btn_SiparisAlma.TabIndex = 18;
            btn_SiparisAlma.Text = "Sipariş Alma";
            btn_SiparisAlma.UseVisualStyleBackColor = true;
            btn_SiparisAlma.UseWaitCursor = true;
            btn_SiparisAlma.Click += btn_SiparisAlma_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmPersonelMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 1016);
            Controls.Add(grb_Menu);
            Controls.Add(grb_Adisyon);
            Controls.Add(grb_Siparis);
            Controls.Add(grb_MasaTasi);
            Controls.Add(btn_Adisyon);
            Controls.Add(btn_Cikis);
            Controls.Add(btn_Menu);
            Controls.Add(btn_MasaTasi);
            Controls.Add(btn_SiparisAlma);
            Name = "frmPersonelMain";
            Text = "frmPersonelMain";
            grb_Menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv_Menu).EndInit();
            grb_Adisyon.ResumeLayout(false);
            grb_Adisyon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            grb_Siparis.ResumeLayout(false);
            grb_Siparis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Siparis).EndInit();
            grb_MasaTasi.ResumeLayout(false);
            grb_MasaTasi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView_Masa_Tasi).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grb_Menu;
        private Button btn_Menu_Geri;
        private DataGridView dgv_Menu;
        private GroupBox grb_Adisyon;
        private Button btn_Adisyon_Geri;
        private Button btn_Adisyon_Odeme;
        private DataGridView dataGridView1;
        private Label label12;
        private Label label11;
        private ComboBox cmb_Adisyon_Masa;
        private Label label10;
        private GroupBox grb_Siparis;
        private CheckBox checkBox4;
        private CheckBox checkBox3;
        private CheckBox checkBox2;
        private CheckBox checkBox1;
        private Button btn_Siparis_Geri;
        private DataGridView dataGridView_Siparis;
        private Button btn_Siparis_Sil;
        private Button btn_Siparis_Ekle;
        private ComboBox cmb_Tatli;
        private ComboBox cmb_Sandvic;
        private ComboBox cmb_Mesrubatlar;
        private ComboBox cmb_Kahve;
        private ComboBox cmb_Sogukİcecek;
        private ComboBox cmb_Sicakİcecek;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private ComboBox cmb_MasaNumarasi;
        private Label label1;
        private GroupBox grb_MasaTasi;
        private Button btn_MasaTasi_Geri;
        private DataGridView dataGridView_Masa_Tasi;
        private Button btn_Tasi;
        private ComboBox cmb_TasınılanMasa;
        private ComboBox cmb_TasinacakMasa;
        private Label label9;
        private Label label8;
        private Button btn_Adisyon;
        private Button btn_Cikis;
        private Button btn_Menu;
        private Button btn_MasaTasi;
        private Button btn_SiparisAlma;
        private Button btnExcel;
        private OpenFileDialog openFileDialog1;
    }
}