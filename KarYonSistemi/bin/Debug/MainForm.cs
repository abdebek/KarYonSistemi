using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace KarYonSistemi
{
    internal partial class MainForm : Form
    {
        private List<Urun> urunler = new List<Urun>();
        private List<Gonderi> gonderiler = new List<Gonderi>();
        private List<GonderiHizmetSaglayicisi> gonderiHizmetSaglayicisi = new List<GonderiHizmetSaglayicisi> {
            ArasKargo.Temsilci,
            PTTKargo.Temsilci,
            YurticiKargo.Temsilci
        };

        private IGonderiHizmetSaglayicisi secilenGonderiHizmetSaglayicisi;

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }

        public MainForm()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);

            // Örnek verileri oluşturur
            OrnekVerileriYukle();

            // Oluşturulan örnek verileri DataGridView (Tablo) ve ComboBox'a yükler
            GonderilmemisUrunleriGrideBagla();
            GonderileriGrideBagla();

            // Gönderilmemiş ürünleri ComboBox'a yükler
            GonderilmemisUrunleriComboBoxaBagla();
            KargoSaglayicilariniComboBoxaBagla();
        }

        private async void OrnekVerileriYukle()
        {
            // Örnek verileri yükle
            TohumVerileri.OrnekUrunleriEkle(urunler);
            TohumVerileri.OrnekGonderileriEkle(gonderiler);

            // Örnek gönderileri kargoya ver
            foreach (var gonderi in gonderiler)
            {
                KargoyaVer(gonderi);
            };
        }

        private async void KargoyaVer(Gonderi gonderi)
        {
            var secilenGonderiHizmetSaglayicisi = GetDeliveryService(gonderi.KargoNo);
            await secilenGonderiHizmetSaglayicisi.KargoGonder(gonderi);

            GonderileriGrideBagla();
        }

        // Gönderilmemiş ürünleri getir
        private List<Urun> GonderilmemisUrunleriGetir()
        {
            List<Urun> gonderilmemisUrunler = new List<Urun>();
            foreach (var urun in urunler)
            {
                if (!gonderiler.Exists(p => p.UrunNo == urun.SeriNo))
                {
                    gonderilmemisUrunler.Add(urun);
                }
            }

            return gonderilmemisUrunler;
        }

        private void GonderilmemisUrunleriGrideBagla()
        {
            // Manually set the display index for each column
            dataGridViewProducts.DataSource = null; // Reset 
            dataGridViewProducts.DataSource = GonderilmemisUrunleriGetir();
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
            dataGridViewShippingHistory.CellFormatting += dataGridViewShippingHistory_CellFormatting;
            dataGridViewShippingHistory.DataSource = gonderiler;
            dataGridViewShippingHistory.Columns["UrunNo"].DisplayIndex = 0;
            dataGridViewShippingHistory.Columns["UrunNo"].HeaderText = "Ürün Seri Numarası";
            dataGridViewShippingHistory.Columns["KargoNo"].DisplayIndex = 1;
            dataGridViewShippingHistory.Columns["KargoNo"].HeaderText = "Kargo Şirketi";
            dataGridViewShippingHistory.Columns["Gonderici"].DisplayIndex = 2;
            dataGridViewShippingHistory.Columns["Gonderici"].HeaderText = "Gönderen";
            dataGridViewShippingHistory.Columns["Alici"].DisplayIndex = 3;
            dataGridViewShippingHistory.Columns["Alici"].HeaderText = "Alıcı";
            dataGridViewShippingHistory.Columns["TeslimEdildi"].DisplayIndex = 4;
            dataGridViewShippingHistory.Columns["TeslimEdildi"].HeaderText = "Gönderi Durumu";
            dataGridViewShippingHistory.Columns["TeslimEdildi"].ReadOnly = true;
            dataGridViewShippingHistory.RowTemplate.MinimumHeight = 40;

            // Hide unwanted columns
            dataGridViewShippingHistory.Columns["SeriNo"].Visible = false;
            dataGridViewShippingHistory.Columns["Silinmis"].Visible = false;
        }

        // Bind products to ComboBox
        private void GonderilmemisUrunleriComboBoxaBagla()
        {
            comboBoxProductId.DataSource = null;
            comboBoxProductId.DataSource = GonderilmemisUrunleriGetir();
            comboBoxProductId.DisplayMember = "Adi";
            comboBoxProductId.ValueMember = "SeriNo";

            // Set the default selected item to none
            comboBoxProductId.SelectedIndex = -1;
            comboBoxProductId.Text = "Ürün seçiniz";
        }

        // Bind cargos to ComboBox
        private void KargoSaglayicilariniComboBoxaBagla()
        {
            comboBoxCargoId.DataSource = null;
            comboBoxCargoId.DataSource = gonderiHizmetSaglayicisi;
            comboBoxCargoId.DisplayMember = "Adi";
            comboBoxCargoId.ValueMember = "SeriNo";

            // Set the default selected item to none
            comboBoxCargoId.SelectedIndex = -1;
            comboBoxCargoId.Text = "Kargo seçiniz";
        }

        private void dataGridViewShippingHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // cargoId column formatting
            if (dataGridViewShippingHistory.Columns[e.ColumnIndex].Name == "KargoNo" && e.Value is int)
            {
                int cargoId = (int)e.Value;
                e.Value = gonderiHizmetSaglayicisi.Find(p => p.SeriNo == cargoId)?.Adi ?? "Bilinmiyor";
                e.FormattingApplied = true; // Indicate that the formatting is applied
            }

            // productId column formatting

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

        private GonderiHizmetSaglayicisi GetDeliveryService(int kargoNo)
        {
            switch (kargoNo)
            {
                case 0:
                    return ArasKargo.Temsilci;
                case 1:
                    return PTTKargo.Temsilci;
                case 2:
                    return YurticiKargo.Temsilci;
                default:
                    return null;
            }
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
                var urunFiyati = decimal.Parse(fiyati);

                Urun urun = new Urun(
                    urunler.Count + 1,
                    urunAdi,
                    urunFiyati
                    );

                // Ürünü listeye ekle
                urunler.Insert(0, urun);

                // Grid'i ve ComboBox'u yenile
                GonderilmemisUrunleriGrideBagla();
                GonderilmemisUrunleriComboBoxaBagla();

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
                var gonderi = gonderiler.Find(p => p.UrunNo == urunNo);
                if (gonderi == null)
                {
                    return;
                }

                var urunAdi = urunler.Find(p => p.SeriNo == gonderi.UrunNo)?.Adi ?? "";
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
            var gonderiAdi = textBox1.Text;
            var AliciAdi = textBox2.Text;
            if (string.IsNullOrEmpty(gonderiAdi) ||
                string.IsNullOrEmpty(AliciAdi))
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

                var gonderi = new Gonderi(
                    id: gonderiler.Count + 1,
                    kargoNo: secilenKargo.SeriNo,
                    urunNo: secilenUrun.SeriNo,
                    gondericiAdi: gonderiAdi,
                    aliciAdi: AliciAdi
                    );

                //Gonderi listesine ekle
                gonderiler.Insert(0, gonderi);

                // Gönderilmiş ürünü From'dan kaldır
                GonderilmisUrunuFormdanKaldir();

                // Refresh the DataGridView and Products ComboBox
                GonderileriGrideBagla();
                GonderilmemisUrunleriGrideBagla();

                // Send the cargo
                secilenGonderiHizmetSaglayicisi = GetDeliveryService(secilenKargo.SeriNo);
                await secilenGonderiHizmetSaglayicisi.KargoGonder(gonderi);

                // Refresh the DataGridView and Products ComboBox again
                GonderileriGrideBagla();
                GonderilmemisUrunleriGrideBagla();
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