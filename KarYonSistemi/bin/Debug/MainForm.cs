using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading.Tasks;

namespace KarYonSistemi
{
    internal partial class MainForm : Form
    {
        private List<Product> products = new List<Product>();
        private List<ShipmentInfo> shipments = new List<ShipmentInfo>();
        private List<DeliveryService> deliveryServices = new List<DeliveryService> {
            ArasKargo.Instance,
            PTTKargo.Instance,
            YurticiKargo.Instance
        };

        private IDeliveryService currentDeliveryService;

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }

        public MainForm()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);

            // Load sample data or connect to a database
            LoadSampleData();

            // Bind data to DataGridViews
            BindProductsDataToGrid();
            BindShipmentsDataToGrid();

            // Bind data to ComboBox
            BindProductsToComboBox();
            BindCargosToComboBox();
        }

        private async void LoadSampleData()
        {
            // Load sample products
            products.Add(new Product(1, "Bilgisayar", 1000));
            products.Add(new Product(2, "Ayakkabı", 500));
            products.Add(new Product(3, "Tablet", 300));
            products.Add(new Product(4, "Telefon", 200));
            products.Add(new Product(5, "Kulaklık", 100));
            products.Add(new Product(6, "Klavye", 50));
            products.Add(new Product(7, "Mouse", 25));
            products.Add(new Product(8, "Kablo", 10));
            products.Add(new Product(9, "Kalem", 5));
            products.Add(new Product(10, "Silgi", 2));
            products.Add(new Product(11, "Defter", 1));
            products.Add(new Product(12, "Kalemtraş", 0.5m));
            products.Add(new Product(13, "Kurşun Kalem", 0.25m));
            products.Add(new Product(14, "Kalem Ucu", 0.1m));
            products.Add(new Product(15, "Kalem Kutusu", 0.05m));
            products.Add(new Product(16, "Kalem Açacağı", 0.025m));
            products.Add(new Product(17, "Kalem Silgisi", 0.0125m));
            products.Add(new Product(18, "Kalemtraş Silgisi", 0.00625m));


            // Load sample shipments
            shipments.Add(new ShipmentInfo(1, 1, 3, "Ali", "Ahmet"));
            shipments.Add(new ShipmentInfo(2, 2, 2, "Adem", "Aslan"));
            shipments.Add(new ShipmentInfo(3, 0, 1, "Ayşe", "Aysun"));
            shipments.Add(new ShipmentInfo(4, 1, 4, "Bilal", "Berk"));
            shipments.Add(new ShipmentInfo(6, 0, 6, "Cem", "Ceyda"));
            shipments.Add(new ShipmentInfo(7, 1, 9, "Can", "Cemre"));
            shipments.Add(new ShipmentInfo(8, 2, 12, "Derya", "Deniz"));
            shipments.Add(new ShipmentInfo(9, 0, 11, "Dilek", "Dilan"));
            shipments.Add(new ShipmentInfo(10, 1, 13, "Ece", "Ebru"));
            shipments.Add(new ShipmentInfo(11, 2, 7, "Emre", "Eren"));

            // Set the delivery status for the sample shipments, use parallel foreach
            foreach (var shipment in shipments)
            {
                SendCargo(shipment);
            };
        }

        private async void SendCargo(ShipmentInfo shipment)
        {
            var deliveryService = GetDeliveryService(shipment.CargoId);
            await deliveryService.SendCargo(shipment);

            BindShipmentsDataToGrid();
        }

        // Get products that has not been shipped yet
        private List<Product> GetAvailableProducts()
        {
            List<Product> availableProducts = new List<Product>();
            foreach (var product in products)
            {
                if (!shipments.Exists(p => p.ProductId == product.Id))
                {
                    availableProducts.Add(product);
                }
            }

            return availableProducts;
        }

        private void BindProductsDataToGrid()
        {
            // Manually set the display index for each column
            dataGridViewProducts.DataSource = null; // Reset 
            dataGridViewProducts.DataSource = GetAvailableProducts();
            dataGridViewProducts.Columns["Id"].DisplayIndex = 0;
            dataGridViewProducts.Columns["Id"].HeaderText = "Ürün Seri Numarası";
            dataGridViewProducts.Columns["Name"].DisplayIndex = 1;
            dataGridViewProducts.Columns["Name"].HeaderText = "Ürün Adı";
            dataGridViewProducts.Columns["Price"].DisplayIndex = 2;
            dataGridViewProducts.Columns["Price"].HeaderText = "Ürün Fıyatı";
            dataGridViewProducts.Columns["Price"].DisplayIndex = 2;
            dataGridViewProducts.Columns["IsDeleted"].Visible = false;
            dataGridViewProducts.RowTemplate.MinimumHeight = 40;
        }

        private void BindShipmentsDataToGrid()
        {
            dataGridViewShippingHistory.DataSource = null;
            dataGridViewShippingHistory.CellFormatting += dataGridViewShippingHistory_CellFormatting;
            dataGridViewShippingHistory.DataSource = shipments;
            dataGridViewShippingHistory.Columns["ProductId"].DisplayIndex = 0;
            dataGridViewShippingHistory.Columns["ProductId"].HeaderText = "Ürün Seri Numarası";
            dataGridViewShippingHistory.Columns["CargoId"].DisplayIndex = 1;
            dataGridViewShippingHistory.Columns["CargoId"].HeaderText = "Kargo Şirketi";
            dataGridViewShippingHistory.Columns["SenderName"].DisplayIndex = 2;
            dataGridViewShippingHistory.Columns["SenderName"].HeaderText = "Gönderen";
            dataGridViewShippingHistory.Columns["ReceiverName"].DisplayIndex = 3;
            dataGridViewShippingHistory.Columns["ReceiverName"].HeaderText = "Alıcı";
            dataGridViewShippingHistory.Columns["IsDelivered"].DisplayIndex = 4;
            dataGridViewShippingHistory.Columns["IsDelivered"].HeaderText = "Gönderi Durumu";
            dataGridViewShippingHistory.Columns["IsDelivered"].ReadOnly = true;
            dataGridViewShippingHistory.RowTemplate.MinimumHeight = 40;

            // Hide unwanted columns
            dataGridViewShippingHistory.Columns["Id"].Visible = false;
            dataGridViewShippingHistory.Columns["IsDeleted"].Visible = false;
        }

        // Bind products to ComboBox
        private void BindProductsToComboBox()
        {
            comboBoxProductId.DataSource = null;
            comboBoxProductId.DataSource = GetAvailableProducts();
            comboBoxProductId.DisplayMember = "Name";
            comboBoxProductId.ValueMember = "Id";

            // Set the default selected item to none
            comboBoxProductId.SelectedIndex = -1;
            comboBoxProductId.Text = "Ürün seçiniz";
        }

        // Bind cargos to ComboBox
        private void BindCargosToComboBox()
        {
            comboBoxCargoId.DataSource = null;
            comboBoxCargoId.DataSource = deliveryServices;
            comboBoxCargoId.DisplayMember = "Name";
            comboBoxCargoId.ValueMember = "Id";

            // Set the default selected item to none
            comboBoxCargoId.SelectedIndex = -1;
            comboBoxCargoId.Text = "Kargo seçiniz";
        }

        private void dataGridViewShippingHistory_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            // cargoId column formatting
            if (dataGridViewShippingHistory.Columns[e.ColumnIndex].Name == "CargoId" && e.Value is int)
            {
                int cargoId = (int)e.Value;
                e.Value = deliveryServices.Find(p => p.Id == cargoId)?.Name ?? "Bilinmiyor";
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

        private void ResetShipmentForm()
        {
            comboBoxProductId.SelectedIndex = -1;
            comboBoxProductId.Text = "Ürün seçiniz";
        }

        private DeliveryService GetDeliveryService(int cargoId)
        {
            switch (cargoId)
            {
                case 0:
                    return ArasKargo.Instance;
                case 1:
                    return PTTKargo.Instance;
                case 2:
                    return YurticiKargo.Instance;
                default:
                    return null;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                var productId = Int32.Parse(textBoxProductId.Text);
                var shipment = shipments.Find(p => p.ProductId == productId);
                if (shipment == null)
                {
                    return;
                }

                var productName = products.Find(p => p.Id == shipment.ProductId)?.Name ?? "";
                var deliveryStatus = shipment.IsDelivered ? "Teslim Edilmiştir." : "Kargoda";
                label2.Text = string.Join(": ", label2.Text, productName);
                label3.Text = string.Join(": ", label3.Text, deliveryStatus);
                label4.Text = string.Join(": ", label4.Text, shipment.SenderName);
                label5.Text = string.Join(": ", label5.Text, shipment.ReceiverName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private async void button2_Click(object sender, EventArgs e)
        {
            var senderName = textBox1.Text;
            var receiverName = textBox2.Text;
            if (string.IsNullOrEmpty(senderName) ||
                string.IsNullOrEmpty(receiverName))
            {
                return;
            }

            try
            {
                Product selectedProduct = comboBoxProductId.SelectedItem as Product;
                DeliveryService selectedCargo = comboBoxCargoId.SelectedItem as DeliveryService;

                if (selectedProduct == null || selectedCargo == null)
                {
                    return;
                }

                var shipment = new ShipmentInfo(
                    id: shipments.Count + 1,
                    cargoId: selectedCargo.Id,
                    productId: selectedProduct.Id,
                    senderName: senderName,
                    receiverName: receiverName
                    );

                // Update the shipment to the top of the list
                shipments.Insert(0, shipment);

                // Reset the form
                ResetShipmentForm();

                // Refresh the DataGridView and Products ComboBox
                BindShipmentsDataToGrid();
                BindProductsDataToGrid();

                // Send the cargo
                currentDeliveryService = GetDeliveryService(selectedCargo.Id);
                await currentDeliveryService.SendCargo(shipment);

                // Refresh the DataGridView and Products ComboBox again
                BindShipmentsDataToGrid();
                BindProductsDataToGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnAddToCatalog_Click(object sender, EventArgs e)
        {
            var productName = textBoxProductName.Text;
            var price = textBoxProductPrice.Text;
            if (string.IsNullOrEmpty(productName) || string.IsNullOrEmpty(price))
            {
                return;
            }
            try
            {
                // use try safe parse
                var productPrice = decimal.Parse(price);

                // Create a new product
                Product product = new Product(
                    products.Count + 1,
                    productName,
                    productPrice
                    );

                // Add product to the top of the list
                products.Insert(0, product);

                // Refresh the DataGridView and ComboBox
                BindProductsDataToGrid();
                BindProductsToComboBox();
                ResetProdcutForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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
    }
}