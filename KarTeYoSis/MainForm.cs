using System.Collections.Generic;
using System;
using System.Windows.Forms;

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

            // Initialize your cargo companies
            currentDeliveryService = new PTTKargo();

            // Load sample data or connect to a database
            LoadSampleData();

            // Bind data to DataGridViews
            // BindProductData();
            // BindShipmentData();
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

/**
        private void BindProductData()
        {
            dgvProducts.DataSource = products;
        }

        private void BindShipmentData()
        {
            dgvShipments.DataSource = shipments;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            // Create and add a new product
            Product newProduct = new Product
            {
                Id = products.Count + 1,
                Name = txtProductName.Text,
                Price = Convert.ToDecimal(txtProductPrice.Text)
            };

            products.Add(newProduct);

            // Refresh the product DataGridView
            BindProductData();
        }

        private void btnShipProduct_Click(object sender, EventArgs e)
        {
            // Create and add a new shipment
            ShipmentInfo newShipment = new ShipmentInfo
            {
                Id = shipments.Count + 1,
                ProductId = Convert.ToInt32(txtShippedProductId.Text),
                SenderName = txtSenderName.Text,
                ReceiverName = txtReceiverName.Text
            };

            shipments.Add(newShipment);

            // Use the current cargo company to send the cargo
            currentDeliveryService.SendCargo(newShipment);

            // Refresh the shipment DataGridView
            BindShipmentData();
        }

        private void btnCheckDeliveryStatus_Click(object sender, EventArgs e)
        {
            int shipmentId = Convert.ToInt32(txtShipmentId.Text);

            // Check the delivery status using the current cargo company
            bool isDelivered = currentDeliveryService.CheckDeliveryStatus(shipmentId);

            MessageBox.Show($"Delivery Status: {isDelivered}");
        }

        private void cmbCargoCompany_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Set the current delivery service based on the selected cargo company
            switch (cmbCargoCompany.SelectedItem.ToString())
            {
                case "Aras Kargo":
                    currentDeliveryService = new ArasKargo();
                    break;
                case "PTT Kargo":
                    currentDeliveryService = new PTTKargo();
                    break;
                case "Yurtici Kargo":
                    currentDeliveryService = new YurticiKargo();
                    break;
                default:
                    // Handle other cases or set a default delivery service
                    break;
            }
        }

        **/
    }
}