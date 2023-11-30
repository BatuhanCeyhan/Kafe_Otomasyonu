using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExcelApp = Microsoft.Office.Interop.Excel;

namespace kafe.WinUI
{
    public partial class frmPersonelMain : Form
    {
        public frmPersonelMain()
        {
            InitializeComponent();
            grb_MasaTasi.Visible = false;
            grb_Siparis.Visible = false;
            grb_Adisyon.Visible = false;
            grb_Menu.Visible = false;

        }

        private void btn_MasaTasi_Click(object sender, EventArgs e)
        {
            grb_MasaTasi.Visible = true;
            grb_Siparis.Visible = false;
            grb_Adisyon.Visible = false;
            grb_Menu.Visible = false;
        }

        private void btn_SiparisAlma_Click(object sender, EventArgs e)
        {
            grb_Siparis.Visible = true;
            grb_MasaTasi.Visible = false;
            grb_Adisyon.Visible = false;
            grb_Menu.Visible = false;
        }

        private void btn_Adisyon_Click(object sender, EventArgs e)
        {
            grb_Adisyon.Visible = true;
            grb_MasaTasi.Visible = false;
            grb_Siparis.Visible = false;
            grb_Menu.Visible = false;
        }

        private void btn_Menu_Click(object sender, EventArgs e)
        {
            grb_Menu.Visible = true;
            grb_Siparis.Visible = false;
            grb_Adisyon.Visible = false;
            grb_MasaTasi.Visible = false;
        }

        private void btn_MasaTasi_Geri_Click(object sender, EventArgs e)
        {
            grb_MasaTasi.Visible = false;
        }

        private void btn_Adisyon_Geri_Click(object sender, EventArgs e)
        {
            grb_Adisyon.Visible = false;
        }

        private void btn_Menu_Geri_Click(object sender, EventArgs e)
        {
            grb_Menu.Visible = false;
        }

        private void btn_Siparis_Geri_Click(object sender, EventArgs e)
        {
            grb_Siparis.Visible = false;
        }

        private void btn_Cikis_Click(object sender, EventArgs e)
        {
            frmgiris frmgiris = FormFactory.CreatefrmGiris();

            frmgiris.Show();
            this.Hide();
        }

        private void btn_Tasi_Click(object sender, EventArgs e)
        {


        }
        public DataTable ToDataTable(ExcelApp.Range range, int rows, int cols)
        {
            DataTable table = new DataTable();
            for (int i = 1; i <= rows; i++)
            {
                if (i == 1)
                { // ilk satırı Sutun Adları olarak kullanıldığından
                  // bunları Sutün Adları Olarak Kaydediyoruz.
                    for (int j = 1; j <= cols; j++)
                    {
                        //Sütunların içeriği boş mu kontrolü yapılmaktadır.
                        if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                            table.Columns.Add(range.Cells[i, j].Value2.ToString());
                        else //Boş olduğunda Kaçınsı Sutünsa Adı veriliyor.
                            table.Columns.Add(j.ToString() + ".Sütun");
                    }
                    continue;
                }
                //Yukarıda Sütunlar eklendi
                // onun şemasına göre yeni bir satır oluşturuyoruz. 
                //Okunan verileri yan yana sıralamak için
                var yeniSatir = table.NewRow();
                for (int j = 1; j <= cols; j++)
                {
                    //Sütunların içeriği boş mu kontrolü yapılmaktadır.
                    if (range.Cells[i, j] != null && range.Cells[i, j].Value2 != null)
                        yeniSatir[j - 1] = range.Cells[i, j].Value2.ToString();
                    else // İçeriği boş hücrede hata vermesini önlemek için
                        yeniSatir[j - 1] = String.Empty;
                }
                table.Rows.Add(yeniSatir);
            }
            return table;
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            string DosyaYolu;
            string DosyaAdi;
            DataTable dt;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Excel Dosyası | *.xls; *.xlsx; *.xlsm";
            if (file.ShowDialog() == DialogResult.OK)
            {
                if (file.ShowDialog() == DialogResult.OK)
                {
                    DosyaYolu = file.FileName;// seçilen dosyanın tüm yolunu verir
                    DosyaAdi = file.SafeFileName;// seçilen dosyanın adını verir.
                    ExcelApp.Application excelApp = new ExcelApp.Application();
                    if (excelApp == null)
                    { //Excel Yüklümü Kontrolü Yapılmaktadır.
                        MessageBox.Show("Excel yüklü değil.");
                        return;
                    }
                    //Excel Dosyası Açılıyor.
                    ExcelApp.Workbook excelBook = excelApp.Workbooks.Open(DosyaYolu);
                    //Excel Dosyasının Sayfası Seçilir.
                    ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
                    //Excel Dosyasının ne kadar satır ve sütun kaplıyorsa tüm alanları alır.
                    ExcelApp.Range excelRange = excelSheet.UsedRange;
                    int satirSayisi = excelRange.Rows.Count; //Sayfanın satır sayısını alır.
                    int sutunSayisi = excelRange.Columns.Count;//Sayfanın sütun sayısını alır.
                    dt = ToDataTable(excelRange, satirSayisi, sutunSayisi);
                    dgv_Menu.DataSource = dt;
                    dgv_Menu.Refresh();
                    //Okuduktan Sonra Excel Uygulamasını Kapatıyoruz.
                    excelApp.Quit();
                    System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
                }
                else
                {
                    MessageBox.Show("Dosya Seçilemedi.");
                }
            }    
    }   }

}
