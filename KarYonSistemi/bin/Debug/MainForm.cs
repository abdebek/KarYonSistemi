using System.Collections.Generic;
using System;
using System.Windows.Forms;
using System.Drawing;

namespace KarTeYoSis
{
    internal partial class MainForm : Form
    {
        private List<Product> products = new List<Product>();
        private List<ShipmentInfo> shipments = new List<ShipmentInfo>();
        private IDeliveryService currentDeliveryService;

        private void MainForm_Load(object sender, System.EventArgs e)
        {

        }


        public MainForm()
        {
            InitializeComponent();
            Icon = Icon.ExtractAssociatedIcon(System.Reflection.Assembly.GetExecutingAssembly().Location);

            // Initialize your cargo companies
            currentDeliveryService = new PTTKargo();

            // Load sample data or connect to a database
            LoadSampleData();

            // Bind data to DataGridViews
            BindProductData();
            BindShipmentData();
        }

        private void LoadSampleData()
        {
            // Load sample products
            products.Add(new Product { Id = 1, Name = "Laptop", Price = 1000 });
            products.Add(new Product { Id = 2, Name = "Smartphone", Price = 500 });

            // Load sample shipments
            shipments.Add(new ShipmentInfo { Id = 1, ProductId = 1, SenderName = "Sender1", ReceiverName = "Receiver1" });
            shipments.Add(new ShipmentInfo { Id = 2, ProductId = 2, SenderName = "Sender2", ReceiverName = "Receiver2" });
        }

        private void BindProductData()
        {
            dataGridViewProducts.DataSource = products;
        }

        private void BindShipmentData()
        {
            dataGridViewShippingHistory.DataSource = shipments;
        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            // // Get product name and price from textboxes
            // string productName = textBoxProductName.Text;
            // decimal productPrice = decimal.Parse(textBoxProductPrice.Text);

            // // Create a new product
            // Product product = new Product
            // {
            //     Id = products.Count + 1,
            //     Name = productName,
            //     Price = productPrice
            // };

            // // Add product to the list
            // products.Add(product);

            // // Refresh the DataGridView
            // BindProductData();
        }


        private void buttonShipProduct_Click(object sender, EventArgs e)
        {
            // Get selected product
            //Product selectedProduct = (Product)dataGridViewProducts.SelectedRows[0].DataBoundItem;

            //Get sender and receiver names from textboxes
            //string senderName = textBoxSenderName.Text;
            //string receiverName = textBoxReceiverName.Text;

            //Create a new shipment
            //ShipmentInfo shipment = new ShipmentInfo
            //{
            //    Id = shipments.Count + 1,
            //    ProductId = selectedProduct.Id,
            //    SenderName = senderName,
            //    ReceiverName = receiverName
            //};

            //Add shipment to the list
            //shipments.Add(shipment);

            //Refresh the DataGridView
            //BindShipmentData();

            //Ship the product
            //currentDeliveryService.SendCargo(shipment);
        }


        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void resetDeliveryStatusBoard()
        {
            label2.Text = label2.Text.Split(':')[0];
            label3.Text = label3.Text.Split(':')[0];
            label4.Text = label4.Text.Split(':')[0];
            label5.Text = label5.Text.Split(':')[0];

        }
        private void button1_Click(object sender, EventArgs e)
        {
            // Reset any previous changes if available
            resetDeliveryStatusBoard();

            var productId = Int32.Parse(textBoxProductId.Text);
            var shipment = shipments.Find(p => p.ProductId == productId);
            if (shipment == null)
            {
                return;
            }

            var productName = products.Find(p => p.Id == shipment.ProductId)?.Name ?? "";
            var deliveryStatus = shipment.isDelivered ? "Teslim Edilmiştir." : "Kargoda";
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

        private void button2_Click(object sender, EventArgs e)
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
    }
}