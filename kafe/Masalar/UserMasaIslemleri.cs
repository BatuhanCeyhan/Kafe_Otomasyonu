using kafe.WinUI.Personel;
using Kafe.Bussinuss.Abstract;
using Kafe.Bussinuss.Concrete;
using Kafe.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kafe.WinUI.Masalar
{
    public partial class UserMasaIslemleri : UserControl
    {
        public Masa Masa1 { get; set; }
        IMasaBs masaBs;

        public UserMasaIslemleri(IMasaBs _masabs)
        {
            this.Load += UserMasaIslemleri_Load;
            masaBs = _masabs;
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Masa1 == null)
            {
                Masa MasaEkleme = new Masa();
                MasaEkleme.MasaAdi = txtMasaAdi.Text;

                masaBs.Insert(MasaEkleme);
                VerileriCekme();
                MessageBox.Show("Masa Kaydoldu");
            }
            else
            {
                Masa MasaGuncelleme = Masa1;
                MasaGuncelleme.MasaAdi = txtMasaAdi.Text;
                masaBs.Update(MasaGuncelleme);
                VerileriCekme();
                MessageBox.Show("Masa Güncellenmiştir");
            }
        }
        public void VerileriCekme()
        {
            dataGridView1.DataSource = masaBs.GetAll();
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[2].Visible = false;
            dataGridView1.Columns[3].Visible = false;
        }

        private void UserMasaIslemleri_Load(object sender, EventArgs e)
        {
            VerileriCekme();

            if (Masa1 == null)
            {
                button1.Text = "Kaydet";
            }
            else
            {
                txtMasaAdi.Text = Masa1.MasaAdi;
                button1.Text = "Güncelle";
                label2.Text = "Masa Güncelleme";
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Masa masa = dataGridView1.SelectedRows[0].DataBoundItem as Masa;
            if (masa != null)
            {

                DialogResult dr = MessageBox.Show($"{masa.MasaAdi}  Kullanıcısı Silinecek Emin Misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Masa SilinecekPersonel = masaBs.Get(x => x.ID == masa.ID);
                    masaBs.Delete(SilinecekPersonel);
                    VerileriCekme();

                    MessageBox.Show("Kayıt Başarı İle Silindi.");
                }
                else
                {
                    MessageBox.Show("İşlem İptal Edildi.");
                }
            }

        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Masa Masa = dataGridView1.SelectedRows[0].DataBoundItem as Masa;
            Panel panel = this.Parent as Panel;

            panel.Controls.Clear();

            UserMasaIslemleri userMasaIslemleri = FormFactory.CreateUserMasaIslemleri();

            userMasaIslemleri.Masa1 = Masa;
            panel.Controls.Add(userMasaIslemleri);
        }

        private void bilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Masa masa = dataGridView1.SelectedRows[0].DataBoundItem as Masa;
            Panel panel = this.Parent as Panel;
            panel.Controls.Clear();

            UserMasaBilgi userMasaBilgi = FormFactory.CreateUserMasaBilgi();

            userMasaBilgi.MasaBilgi = masa;
            panel.Controls.Add(userMasaBilgi);
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {


            Masa Masa = dataGridView1.SelectedRows[0].DataBoundItem as Masa;
            Panel panel = this.Parent as Panel;

            panel.Controls.Clear();

            UserMasaIslemleri userMasaIslemleri = FormFactory.CreateUserMasaIslemleri();

            userMasaIslemleri.Masa1 = Masa;
            panel.Controls.Add(userMasaIslemleri);
        }
    }
}
