﻿using System.Collections.Generic;
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
            // currentDeliveryService = new PTTKargo();

            // Load sample data or connect to a database
            // LoadSampleData();

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

    }
}