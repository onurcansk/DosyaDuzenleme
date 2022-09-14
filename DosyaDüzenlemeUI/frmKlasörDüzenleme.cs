using DosyaDüzenleme.Dosyaİşlemleri;
using DosyaDüzenleme.DosyaTürleri;
using DosyaDüzenleme.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DosyaDüzenlemeUI
{
    public partial class frmKlasörDüzenleme : Form
    {
        public frmKlasörDüzenleme()
        {
            InitializeComponent();
        }
        Dosyalar dosyalar;
        Dosyaİşlemleri dosyaİşlemleri;
        private void button2_Click(object sender, EventArgs e)
        {

            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtDüzenlenecekKlasörYolu.Text = folderBrowserDialog.SelectedPath;
            }
        }


        private void btnKlasördekiDosyalarıBul_Click(object sender, EventArgs e)
        {
            try
            {
                dosyalar.TümDosyalarıAl(txtDüzenlenecekKlasörYolu.Text);
                ListVieveItemsEkleme();
            }
            catch (ListedeÜrünYokException ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void ListVieveItemsEkleme()
        {
            listView1.Items.Clear();
            string açıklama;
            string erişimTarihi;
            if (dosyalar.Count > 0)
            {
                foreach (var item in dosyalar)
                {


                    if (item.Açıklama == null)
                    {
                        açıklama = "Henüz açıklama girilmedi.";
                    }
                    else
                    {
                        açıklama = item.Açıklama;
                    }

                    if (item.GeçerlilikTarihi == default)
                    {
                        erişimTarihi = "Erişim tarihi belirtilmedi.";
                    }
                    else
                    {
                        erişimTarihi = item.GeçerlilikTarihi.ToString("dd/MM/yyyy");
                    }
                    string[] dizi = { "", item.DosyaAdı, açıklama, erişimTarihi, item.DosyaBoyutu.ToString(), item.OluşturmaTarihi.ToString("dd/MM/yyyy") };

                    ListViewItem listViewItem = new ListViewItem(dizi);
                    listView1.Items.Add(listViewItem);
                }
            }


        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string açıklama = txtDosyaAçıklaması.Text;
            DateTime date = dtpKullanımTarihi.Value;

            int index = listView1.SelectedIndices[0];
            dosyalar[index].Açıklama = açıklama;
            dosyalar[index].GeçerlilikTarihi = date;
            ListVieveItemsEkleme();

        }

        private void frmKlasörDüzenleme_Load(object sender, EventArgs e)
        {
            dosyalar = new Dosyalar();
            dosyaİşlemleri = new Dosyaİşlemleri();
            ListVieveItemsEkleme();
        }

        private void btnKlasörle_Click(object sender, EventArgs e)
        {
            dosyaİşlemleri = new Dosyaİşlemleri();
            dosyaİşlemleri.İlgiliKlasöreAyır();
            MessageBox.Show("Klasörleme işlemi tamamlandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTarihiGeçenleriTaşı_Click(object sender, EventArgs e)
        {
            try
            {
                
                Dosya dosya = dosyaİşlemleri.ErişimTarihiGeçenleriTaşı();
                foreach (ListViewItem item in listView1.Items)
                {
                    if (item.SubItems[1].Text==dosya.DosyaAdı)
                    {
                        listView1.Items.Remove(item);
                    }
                    
                }
                MessageBox.Show("Erişim tarihi geçenler başarıyla taşındı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (ErişimTarihiGeçenDosyaBulunamadıException ex)
            {
                MessageBox.Show(ex.Message, "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
