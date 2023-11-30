using kafe.Personel;
using kafe.Urunler;
using kafe.WinUI;
using kafe.WinUI.Masalar;
using kafe.WinUI.Personel;
using kafe.WinUI.Urunler;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kafe
{
    public partial class frmAdminMain : Form
    {
        public frmAdminMain()
        {
            InitializeComponent();
        }

        private void personelEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserPersoneller userPersoneller = FormFactory.CreateUserPersoneller();
            panel1.Controls.Add(userPersoneller);
        }

        private void personelEklemeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserPersonelislemleri userPersonelislemleri = FormFactory.CreateUserPersonelislemleri();
            panel1.Controls.Add(userPersonelislemleri);
        }



        private void personelGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserPersonelislemleri userPersonelislemleri = FormFactory.CreateUserPersonelislemleri();
            panel1.Controls.Add(userPersonelislemleri);


        }

        private void masalarınTümüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserMasalar userMasalar = FormFactory.CreateUserMasalar();
            panel1.Controls.Add(userMasalar);
        }

        private void masaEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserMasaIslemleri userMasaİslemleri = FormFactory.CreateUserMasaIslemleri();
            panel1.Controls.Add(userMasaİslemleri);
        }

        private void masaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserMasaIslemleri userMasaİslemleri = FormFactory.CreateUserMasaIslemleri();
            panel1.Controls.Add(userMasaİslemleri);
        }

        private void masaGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserMasaIslemleri userMasaİslemleri = FormFactory.CreateUserMasaIslemleri();
            panel1.Controls.Add(userMasaİslemleri);
        }

        private void ürünEklemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserUrunIslemleri userUrunIslemleri = FormFactory.CreateUserUrunislemleri();
            panel1.Controls.Add(userUrunIslemleri);
        }

        private void ürünSilmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserUrunIslemleri userUrunIslemleri = FormFactory.CreateUserUrunislemleri();
            panel1.Controls.Add(userUrunIslemleri);
        }

        private void ürünGüncellemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserUrunIslemleri userUrunIslemleri = FormFactory.CreateUserUrunislemleri();
            panel1.Controls.Add(userUrunIslemleri);
        }

        private void ürünlerinTümüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserUrunler userUrunler = FormFactory.CreateUserUrunler();
            panel1.Controls.Add(userUrunler);
        }

        private void personelBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserPersonelBilgi userPersonelBilgi = FormFactory.CreatUserPersonelBilgisi();
            panel1.Controls.Add(userPersonelBilgi);
        }

        private void masaBilgiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserMasaBilgi userMasaBilgi = FormFactory.CreateUserMasaBilgi();
            panel1.Controls.Add(userMasaBilgi);
        }

        private void ürünBilgileriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            UserUrunBilgileri userUrunBilgileri =FormFactory.CreateUserUrunBilgileri();
            panel1.Controls.Add(userUrunBilgileri);
        }
    }
}
