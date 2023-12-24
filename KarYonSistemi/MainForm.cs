using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace KarYonSistemi
{
    internal partial class MainForm : Form
    {
        private List<Product> products = new List<Product>();
        private List<ShipmentInfo> shipments = new List<ShipmentInfo>();
        private List<Cargo> cargos = new List<Cargo>();
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

        private void LoadSampleData()
        {
            // Load sample products
            products.Add(new Product { Id = 1, Name = "Laptop", Price = 1000 });
            products.Add(new Product { Id = 2, Name = "Smartphone", Price = 500 });

            // Load sample cargos
            cargos.Add(new Cargo { Id = 1, Name = "PTT Kargo", PhoneNumber = "444 1 788", Address = "PTT Merkez Müdürlüğü" });
            cargos.Add(new Cargo { Id = 2, Name = "Aras Kargo", PhoneNumber = "444 2 277", Address = "Aras Kargo Merkez Müdürlüğü" });
            cargos.Add(new Cargo { Id = 3, Name = "Yurtiçi Kargo", PhoneNumber = "444 06 06", Address = "Yurtiçi Kargo Merkez Müdürlüğü" });

            // Load sample shipments
            shipments.Add(new ShipmentInfo { Id = 1, ProductId = 1, CargoId = 3, SenderName = "Sender1", ReceiverName = "Receiver1", });
            shipments.Add(new ShipmentInfo { Id = 2, ProductId = 2, CargoId = 2, SenderName = "Sender2", ReceiverName = "Receiver2", });

            // Set the delivery status for the sample shipments
            foreach (var shipment in shipments)
            {
                shipment.SetDeliveryStatus(true);
            }
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
            dataGridViewProducts.Columns["Name"].DisplayIndex = 1;
            dataGridViewProducts.Columns["Price"].DisplayIndex = 2;
            dataGridViewProducts.Columns["IsDeleted"].Visible = false;
        }

        private void BindShipmentsDataToGrid()
        {
            dataGridViewShippingHistory.DataSource = null;
            dataGridViewShippingHistory.DataSource = shipments;
            dataGridViewShippingHistory.Columns["ProductId"].DisplayIndex = 0;
            dataGridViewShippingHistory.Columns["ProductId"].HeaderText = "Product Id";
            dataGridViewShippingHistory.Columns["CargoId"].DisplayIndex = 1;
            dataGridViewShippingHistory.Columns["CargoId"].HeaderText = "Cargo Id";
            dataGridViewShippingHistory.Columns["SenderName"].DisplayIndex = 2;
            dataGridViewShippingHistory.Columns["SenderName"].HeaderText = "Sender Name";
            dataGridViewShippingHistory.Columns["ReceiverName"].DisplayIndex = 3;
            dataGridViewShippingHistory.Columns["ReceiverName"].HeaderText = "Receiver Name";
            dataGridViewShippingHistory.Columns["IsDelivered"].DisplayIndex = 4;
            dataGridViewShippingHistory.Columns["IsDelivered"].HeaderText = "Is Delivered";
            dataGridViewShippingHistory.Columns["IsDelivered"].ReadOnly = true;
            dataGridViewShippingHistory.Columns["IsDelivered"].ToolTipText = "Delivered: Checked";

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
            comboBoxCargoId.DataSource = cargos;
            comboBoxCargoId.DisplayMember = "Name";
            comboBoxCargoId.ValueMember = "Id";

            // Set the default selected item to none
            comboBoxCargoId.SelectedIndex = -1;
            comboBoxCargoId.Text = "Kargo seçiniz";
        }

        private void resetDeliveryStatusBoard()
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
            textBox1.Text = "";
            textBox2.Text = "";
            comboBoxProductId.SelectedIndex = -1;
            comboBoxProductId.Text = "Ürün seçiniz";
            comboBoxCargoId.SelectedIndex = -1;
            comboBoxCargoId.Text = "Kargo seçiniz";
        }

        private DeliveryService GetDeliveryService(int cargoId)
        {
            switch (cargoId)
            {
                case 2:
                    return ArasKargo.Instance;
                case 3:
                    return YurticiKargo.Instance;
                default:
                    return PTTKargo.Instance;
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
            resetDeliveryStatusBoard();

            if (string.IsNullOrEmpty(textBoxProductId.Text))
            {
                return;
            }

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
                Cargo selectedCargo = comboBoxCargoId.SelectedItem as Cargo;

                if (selectedProduct == null || selectedCargo == null)
                {
                    return;
                }

                var shipment = new ShipmentInfo
                {
                    Id = shipments.Count + 1,
                    ProductId = selectedProduct.Id,
                    CargoId = selectedCargo.Id,
                    SenderName = senderName,
                    ReceiverName = receiverName,
                };

                // Update the shipment list
                shipments.Add(shipment);
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

            decimal productPrice = decimal.Parse(textBoxProductPrice.Text);

            // Create a new product
            Product product = new Product
            {
                Id = products.Count + 1,
                Name = productName,
                Price = productPrice
            };

            // Add product to the list
            products.Add(product);

            // Refresh the DataGridView and ComboBox
            BindProductsDataToGrid();
            BindProductsToComboBox();
            ResetProdcutForm();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}