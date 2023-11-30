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
    public partial class UserMasalar : UserControl
    {
        IMasaBs masabs;
        public UserMasalar(IMasaBs _masabs)
        {
            this.Load += UserMasalar_Load;
            masabs = _masabs;
            InitializeComponent();
        }

        public void VerileriCek()
        {
            dataGridView1.DataSource = masabs.GetAll();
        }

        private void UserMasalar_Load(object sender, EventArgs e)
        {
            VerileriCek();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Masa masa = dataGridView1.SelectedRows[0].DataBoundItem as Masa;
            if (masa != null)
            {

                DialogResult dr = MessageBox.Show($"{masa.MasaAdi}  Kullanıcısı Silinecek Emin Misiniz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (dr == DialogResult.Yes)
                {
                    Masa SilinecekPersonel = masabs.Get(x => x.ID == masa.ID);
                    masabs.Delete(SilinecekPersonel);
                    VerileriCek();

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

        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Panel panel = this.Parent as Panel;
            panel.Controls.Clear();

            UserMasaIslemleri userMasaIslemleri = FormFactory.CreateUserMasaIslemleri();
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

            Masa masa = dataGridView1.SelectedRows[0].DataBoundItem as Masa;
            Panel panel = this.Parent as Panel;
            panel.Controls.Clear();

            UserMasaBilgi userMasaBilgi = FormFactory.CreateUserMasaBilgi();

            userMasaBilgi.MasaBilgi = masa;
            panel.Controls.Add(userMasaBilgi);
        }
    }
}
