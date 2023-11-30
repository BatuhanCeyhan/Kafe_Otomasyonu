namespace kafe.WinUI.Urunler
{
    partial class UserUrunBilgileri
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
            dataGridView1 = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            silToolStripMenuItem = new ToolStripMenuItem();
            güncelleToolStripMenuItem = new ToolStripMenuItem();
            ekleToolStripMenuItem = new ToolStripMenuItem();
            lblPersonel = new Label();
            pbFotograf = new PictureBox();
            cmbUrunSinifi = new ComboBox();
            txtNasilYapilir = new TextBox();
            label4 = new Label();
            cmbUrunBoyutu = new ComboBox();
            txtUcret = new TextBox();
            txtUrunAdi = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbFotograf).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.ContextMenuStrip = contextMenuStrip1;
            dataGridView1.Location = new Point(3, 378);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1071, 407);
            dataGridView1.TabIndex = 79;
            dataGridView1.DoubleClick += dataGridView1_DoubleClick;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { silToolStripMenuItem, güncelleToolStripMenuItem, ekleToolStripMenuItem });
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
            // ekleToolStripMenuItem
            // 
            ekleToolStripMenuItem.Name = "ekleToolStripMenuItem";
            ekleToolStripMenuItem.Size = new Size(135, 24);
            ekleToolStripMenuItem.Text = "Ekle";
            ekleToolStripMenuItem.Click += ekleToolStripMenuItem_Click;
            // 
            // lblPersonel
            // 
            lblPersonel.AutoSize = true;
            lblPersonel.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            lblPersonel.Location = new Point(410, 10);
            lblPersonel.Name = "lblPersonel";
            lblPersonel.Size = new Size(207, 41);
            lblPersonel.TabIndex = 64;
            lblPersonel.Text = "Ürün Bilgileri";
            // 
            // pbFotograf
            // 
            pbFotograf.BorderStyle = BorderStyle.FixedSingle;
            pbFotograf.Location = new Point(96, 83);
            pbFotograf.Name = "pbFotograf";
            pbFotograf.Size = new Size(178, 200);
            pbFotograf.TabIndex = 63;
            pbFotograf.TabStop = false;
            // 
            // cmbUrunSinifi
            // 
            cmbUrunSinifi.Enabled = false;
            cmbUrunSinifi.FormattingEnabled = true;
            cmbUrunSinifi.Location = new Point(607, 124);
            cmbUrunSinifi.Name = "cmbUrunSinifi";
            cmbUrunSinifi.Size = new Size(250, 28);
            cmbUrunSinifi.TabIndex = 89;
            // 
            // txtNasilYapilir
            // 
            txtNasilYapilir.Enabled = false;
            txtNasilYapilir.Location = new Point(607, 244);
            txtNasilYapilir.Multiline = true;
            txtNasilYapilir.Name = "txtNasilYapilir";
            txtNasilYapilir.Size = new Size(250, 98);
            txtNasilYapilir.TabIndex = 88;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(518, 246);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 87;
            label4.Text = "Nasıl Yapılır:";
            // 
            // cmbUrunBoyutu
            // 
            cmbUrunBoyutu.Enabled = false;
            cmbUrunBoyutu.FormattingEnabled = true;
            cmbUrunBoyutu.Location = new Point(607, 203);
            cmbUrunBoyutu.Name = "cmbUrunBoyutu";
            cmbUrunBoyutu.Size = new Size(250, 28);
            cmbUrunBoyutu.TabIndex = 86;
            // 
            // txtUcret
            // 
            txtUcret.Enabled = false;
            txtUcret.Location = new Point(607, 163);
            txtUcret.Name = "txtUcret";
            txtUcret.Size = new Size(250, 27);
            txtUcret.TabIndex = 85;
            // 
            // txtUrunAdi
            // 
            txtUrunAdi.Enabled = false;
            txtUrunAdi.Location = new Point(607, 83);
            txtUrunAdi.Name = "txtUrunAdi";
            txtUrunAdi.Size = new Size(250, 27);
            txtUrunAdi.TabIndex = 84;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(515, 207);
            label6.Name = "label6";
            label6.Size = new Size(93, 20);
            label6.TabIndex = 83;
            label6.Text = "Ürün Boyutu:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(557, 168);
            label5.Name = "label5";
            label5.Size = new Size(51, 20);
            label5.TabIndex = 82;
            label5.Text = "Ücreti:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(528, 127);
            label3.Name = "label3";
            label3.Size = new Size(80, 20);
            label3.TabIndex = 81;
            label3.Text = "Ürün Sınıfı:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(538, 90);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 80;
            label2.Text = "Ürün Adı:";
            // 
            // UserUrunBilgileri
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(cmbUrunSinifi);
            Controls.Add(txtNasilYapilir);
            Controls.Add(label4);
            Controls.Add(cmbUrunBoyutu);
            Controls.Add(txtUcret);
            Controls.Add(txtUrunAdi);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(dataGridView1);
            Controls.Add(lblPersonel);
            Controls.Add(pbFotograf);
            Name = "UserUrunBilgileri";
            Size = new Size(1077, 785);
            Load += UserUrunBilgileri_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbFotograf).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblPersonel;
        private PictureBox pbFotograf;
        private ComboBox cmbUrunSinifi;
        private TextBox txtNasilYapilir;
        private Label label4;
        private ComboBox cmbUrunBoyutu;
        private TextBox txtUcret;
        private TextBox txtUrunAdi;
        private Label label6;
        private Label label5;
        private Label label3;
        private Label label2;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem silToolStripMenuItem;
        private ToolStripMenuItem güncelleToolStripMenuItem;
        private ToolStripMenuItem ekleToolStripMenuItem;
    }
}
