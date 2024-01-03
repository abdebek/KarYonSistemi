using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace KarYonSistemi
{
    /// <summary>
    /// KarYönSistemi: Kargo Yönetim Sistemi uygaması için ana form (ekran).
    /// </summary>
    /// <seealso cref="System.Windows.Forms.Form" />
    internal partial class AnaForm : Form
    {
        private GonderiYonetimSistemi gonderiYonetimSistemi = GonderiYonetimSistemi.Temsilci;

        private void MainForm_Load(object sender, System.EventArgs e)
        {
        }

        public AnaForm()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);

            OrnekGonderileriKargoyaVer();

            // Oluşturulan örnek verileri DataGridView (Tablo) ve ComboBox'a yükler
            GridleriYenile();

            // Gönderilmemiş ürünleri ComboBox'a yükler
            MevcutUrunleriComboBoxaBagla();
            KargoSaglayicilariniComboBoxaBagla();
        }

        private void GridleriYenile()
        {
            GonderileriGrideBagla();
            MevcutUrunleriGrideBagla();
        }

        private void OrnekGonderileriKargoyaVer()
        {
            // Örnek gönderileri kargoya ver
            foreach (var gonderi in gonderiYonetimSistemi.gonderiler)
            {
                KargoyaVer(gonderi);
            };
        }

        private async void KargoyaVer(Gonderi gonderi)
        {
            await gonderiYonetimSistemi.KargoyaVer(gonderi);
            GonderileriGrideBagla();
        }

        // Gönderilmemiş ürünleri getir
        private List<Urun> MevcutUrunleriGetir()
        {
            return gonderiYonetimSistemi.MevcutUrunleriGetir();
        }

        private void MevcutUrunleriGrideBagla()
        {
            dataGridViewProducts.DataSource = null; // Önce temizle 
            dataGridViewProducts.DataSource = MevcutUrunleriGetir();
            dataGridViewProducts.Columns["SeriNo"].DisplayIndex = 0;
            dataGridViewProducts.Columns["SeriNo"].HeaderText = "Ürün Seri Numarası";
            dataGridViewProducts.Columns["Adi"].DisplayIndex = 1;
            dataGridViewProducts.Columns["Adi"].HeaderText = "Ürün Adı";
            dataGridViewProducts.Columns["Fiyati"].DisplayIndex = 2;
            dataGridViewProducts.Columns["Fiyati"].HeaderText = "Ürün Fıyatı";
            dataGridViewProducts.Columns["Fiyati"].DisplayIndex = 2;
            dataGridViewProducts.Columns["Silinmis"].Visible = false;
            dataGridViewProducts.RowTemplate.MinimumHeight = 40;
        }

        private void GonderileriGrideBagla()
        {
            dataGridViewShippingHistory.DataSource = null;
            dataGridViewShippingHistory.CellFormatting += DataGridViewShippingHistory_CellFormatting;
            dataGridViewShippingHistory.DataSource = gonderiYonetimSistemi.gonderiler;

            // Gösterilmemesi gereken sütunları gizle
            dataGridViewShippingHistory.Columns["SeriNo"].Visible = false;
            dataGridViewShippingHistory.Columns["Silinmis"].Visible = false;

            dataGridViewShippingHistory.Columns["UrunNo"].DisplayIndex = 0;
            dataGridViewShippingHistory.Columns["KargoNo"].DisplayIndex = 1;
            dataGridViewShippingHistory.Columns["Gonderici"].DisplayIndex = 2;
            dataGridViewShippingHistory.Columns["Alici"].DisplayIndex = 3;
            dataGridViewShippingHistory.Columns["TeslimEdildi"].DisplayIndex = 4;

            dataGridViewShippingHistory.Columns["UrunNo"].HeaderText = "Ürün Seri Numarası";
            dataGridViewShippingHistory.Columns["KargoNo"].HeaderText = "Kargo Şirketi";
            dataGridViewShippingHistory.Columns["Gonderici"].HeaderText = "Gönderen";
            dataGridViewShippingHistory.Columns["Alici"].HeaderText = "Alıcı";
            dataGridViewShippingHistory.Columns["TeslimEdildi"].HeaderText = "Gönderi Durumu";
            dataGridViewShippingHistory.Columns["TeslimEdildi"].ReadOnly = true;
            dataGridViewShippingHistory.RowTemplate.MinimumHeight = 40;
        }

        private void MevcutUrunleriComboBoxaBagla()
        {
            comboBoxProductId.DataSource = null;
            comboBoxProductId.DataSource = MevcutUrunleriGetir();
            comboBoxProductId.DisplayMember = "Adi";
            comboBoxProductId.ValueMember = "SeriNo";

            // Seçili ürünü sıfırla
            comboBoxProductId.SelectedIndex = -1;
            comboBoxProductId.Text = "Ürün seçiniz";
        }

        private void KargoSaglayicilariniComboBoxaBagla()
        {
            comboBoxCargoId.DataSource = null;
            comboBoxCargoId.DataSource = gonderiYonetimSistemi.gonderiHizmetSaglayicileri;
            comboBoxCargoId.DisplayMember = "Adi";
            comboBoxCargoId.ValueMember = "SeriNo";

            // Seçili ürünü sıfırla
            comboBoxCargoId.SelectedIndex = -1;
            comboBoxCargoId.Text = "Kargo seçiniz";
        }

        private void DataGridViewShippingHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // KargoNo sütununu ayarla
            if (dataGridViewShippingHistory.Columns[e.ColumnIndex].Name == "KargoNo" && e.Value is short)
            {
                var cargoId = (short)e.Value;
                e.Value = gonderiYonetimSistemi.GonderiHizmetSaglayicisiBul(cargoId)?.Adi ?? "Bilinmiyor";
                e.FormattingApplied = true;
            }
        }

        private void ResetDeliveryStatusBoard()
        {
            label2.Text = label2.Text.Split(':')[0];
            label3.Text = label3.Text.Split(':')[0];
            label4.Text = label4.Text.Split(':')[0];
            label5.Text = label5.Text.Split(':')[0];
        }

        private void ResetProdcutForm()
        {
            textBoxProductName.Text = "";
            textBoxProductPrice.Text = "";
        }

        private void GonderilmisUrunuFormdanKaldir()
        {
            comboBoxProductId.SelectedIndex = -1;
            comboBoxProductId.Text = "Ürün seçiniz";
        }

        private void btnAddToCatalog_Click(object sender, EventArgs e)
        {
            var urunAdi = textBoxProductName.Text;
            var fiyati = textBoxProductPrice.Text;
            if (string.IsNullOrEmpty(urunAdi) || string.IsNullOrEmpty(fiyati))
            {
                return;
            }
            try
            {
                decimal urunFiyati = decimal.Parse(fiyati);
                int urunSeriNo = gonderiYonetimSistemi.urunler.Count + 1;
                Urun urun = new Urun(urunSeriNo, urunAdi, urunFiyati);

                // Ürünü listeye ekle
                gonderiYonetimSistemi.UrunEkle(urun);

                // Grid'i ve ComboBox'u yenile
                MevcutUrunleriGrideBagla();
                MevcutUrunleriComboBoxaBagla();

                // Formu sıfırla
                ResetProdcutForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Reset any previous changes if available
            ResetDeliveryStatusBoard();

            if (string.IsNullOrEmpty(textBoxProductId.Text))
            {
                return;
            }

            try
            {
                var urunNo = Int32.Parse(textBoxProductId.Text);
                var gonderi = gonderiYonetimSistemi.UrunNumarasiylaGonderiBul(urunNo);
                if (gonderi == null)
                {
                    return;
                }

                var urunAdi = gonderiYonetimSistemi.UrunBul(gonderi.UrunNo)?.Adi ?? "";
                var teslimatDurumu = gonderi.TeslimEdildi ? "Teslim Edilmiştir." : "Kargoda";
                label2.Text = string.Join(": ", label2.Text, urunAdi);
                label3.Text = string.Join(": ", label3.Text, teslimatDurumu);
                label4.Text = string.Join(": ", label4.Text, gonderi.Gonderici);
                label5.Text = string.Join(": ", label5.Text, gonderi.Alici);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            var gondericiAdi = textBox1.Text;
            var aliciAdi = textBox2.Text;
            if (string.IsNullOrEmpty(gondericiAdi) ||
                string.IsNullOrEmpty(aliciAdi))
            {
                return;
            }

            try
            {
                Urun secilenUrun = comboBoxProductId.SelectedItem as Urun;
                GonderiHizmetSaglayicisi secilenKargo = comboBoxCargoId.SelectedItem as GonderiHizmetSaglayicisi;

                if (secilenUrun == null || secilenKargo == null)
                {
                    return;
                }

                int gonderiSeriNo = gonderiYonetimSistemi.gonderiler.Count + 1;
                Gonderi gonderi = new Gonderi(
                        gonderiSeriNo,
                        secilenKargo.SeriNo,
                        secilenUrun.SeriNo,
                        gondericiAdi,
                        aliciAdi
                    );

                //Gonderi listesine ekle
                gonderiYonetimSistemi.GonderiEkle(gonderi);

                // Gönderilmiş ürünü From'dan kaldır
                GonderilmisUrunuFormdanKaldir();

                // Gridleri yenile
                GridleriYenile();
                MevcutUrunleriComboBoxaBagla();

                // Kargoya ver
                KargoyaVer(gonderi);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        #region Auto generated code, that has not been touched

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewShippingHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxProductId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxCargoId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        #endregion
    }
}