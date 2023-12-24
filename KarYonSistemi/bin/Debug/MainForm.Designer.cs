namespace KarTeYoSis
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label16 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheckDeliveryStatus = new System.Windows.Forms.Button();
            this.textBoxProductId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dataGridViewShippingHistory = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnStartShipping = new System.Windows.Forms.Button();
            this.comboBoxCargoId = new System.Windows.Forms.ComboBox();
            this.comboBoxProductId = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.label11 = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnAddToCatalog = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxProductPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShippingHistory)).BeginInit();
            this.flowLayoutPanel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.flowLayoutPanel5.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(6);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel7);
            this.splitContainer1.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel3);
            this.splitContainer1.Panel2.Controls.Add(this.panel6);
            this.splitContainer1.Panel2.Controls.Add(this.flowLayoutPanel5);
            this.splitContainer1.Size = new System.Drawing.Size(1884, 1061);
            this.splitContainer1.SplitterDistance = 861;
            this.splitContainer1.SplitterWidth = 9;
            this.splitContainer1.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel7.BackColor = System.Drawing.SystemColors.Window;
            this.panel7.Controls.Add(this.label16);
            this.panel7.Controls.Add(this.pictureBox1);
            this.panel7.Controls.Add(this.label12);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 865);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(861, 196);
            this.panel7.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(344, 82);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(420, 25);
            this.label16.TabIndex = 2;
            this.label16.Text = "KarYonSistemi: Kargo Yönetim Sistemi";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(26, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(260, 134);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(475, 124);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(147, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Hizmetinizde";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(859, 859);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel2.Controls.Add(this.panel1);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(853, 215);
            this.flowLayoutPanel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnCheckDeliveryStatus);
            this.panel1.Controls.Add(this.textBoxProductId);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 197);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(3, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 132);
            this.panel2.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(452, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Reciver Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(452, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Sender Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Delivery Status:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Name:";
            // 
            // btnCheckDeliveryStatus
            // 
            this.btnCheckDeliveryStatus.Location = new System.Drawing.Point(209, 42);
            this.btnCheckDeliveryStatus.Name = "btnCheckDeliveryStatus";
            this.btnCheckDeliveryStatus.Size = new System.Drawing.Size(255, 36);
            this.btnCheckDeliveryStatus.TabIndex = 2;
            this.btnCheckDeliveryStatus.Text = "Check Delivery Status";
            this.btnCheckDeliveryStatus.UseVisualStyleBackColor = true;
            this.btnCheckDeliveryStatus.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxProductId
            // 
            this.textBoxProductId.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductId.Location = new System.Drawing.Point(15, 41);
            this.textBoxProductId.Name = "textBoxProductId";
            this.textBoxProductId.Size = new System.Drawing.Size(179, 36);
            this.textBoxProductId.TabIndex = 1;
            this.textBoxProductId.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Shipment Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.panel4);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 224);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(856, 632);
            this.flowLayoutPanel4.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Info;
            this.panel4.Controls.Add(this.dataGridViewShippingHistory);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(853, 626);
            this.panel4.TabIndex = 0;
            // 
            // dataGridViewShippingHistory
            // 
            this.dataGridViewShippingHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShippingHistory.Location = new System.Drawing.Point(0, 40);
            this.dataGridViewShippingHistory.Name = "dataGridViewShippingHistory";
            this.dataGridViewShippingHistory.Size = new System.Drawing.Size(850, 597);
            this.dataGridViewShippingHistory.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Info;
            this.label7.Location = new System.Drawing.Point(15, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 25);
            this.label7.TabIndex = 5;
            this.label7.Text = "Shipment History";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.panel9);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 865);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1118, 235);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.SystemColors.Window;
            this.panel9.CausesValidation = false;
            this.panel9.Controls.Add(this.label15);
            this.panel9.Controls.Add(this.label14);
            this.panel9.Controls.Add(this.label13);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(1112, 229);
            this.panel9.TabIndex = 0;
            this.panel9.Paint += new System.Windows.Forms.PaintEventHandler(this.panel9_Paint);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(42, 121);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(865, 25);
            this.label15.TabIndex = 9;
            this.label15.Text = "KarYonSistemi uygulamasını indirip kendi bilgisayarınızda kurulumunu yapmaktır.";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(31, 34);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(908, 25);
            this.label14.TabIndex = 8;
            this.label14.Text = "Kargolarınızın gönderi ve teslimati ile alakalı tüm adımları takip etmek artık ço" +
    "k kolay:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(109, 79);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(719, 25);
            this.label13.TabIndex = 2;
            this.label13.Text = "Yapmanız gereken tek şey, en gelişmiş kargo yönetim sistemi olan ";
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnStartShipping);
            this.panel3.Controls.Add(this.comboBoxCargoId);
            this.panel3.Controls.Add(this.comboBoxProductId);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Location = new System.Drawing.Point(6, 133);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1004, 91);
            this.panel3.TabIndex = 0;
            // 
            // btnStartShipping
            // 
            this.btnStartShipping.Location = new System.Drawing.Point(728, 53);
            this.btnStartShipping.Name = "btnStartShipping";
            this.btnStartShipping.Size = new System.Drawing.Size(199, 34);
            this.btnStartShipping.TabIndex = 4;
            this.btnStartShipping.Text = "Start Shipping";
            this.btnStartShipping.UseVisualStyleBackColor = true;
            this.btnStartShipping.Click += new System.EventHandler(this.button2_Click);
            // 
            // comboBoxCargoId
            // 
            this.comboBoxCargoId.FormattingEnabled = true;
            this.comboBoxCargoId.Location = new System.Drawing.Point(378, 55);
            this.comboBoxCargoId.Name = "comboBoxCargoId";
            this.comboBoxCargoId.Size = new System.Drawing.Size(284, 33);
            this.comboBoxCargoId.TabIndex = 3;
            this.comboBoxCargoId.Text = "Select a Cargo Company";
            // 
            // comboBoxProductId
            // 
            this.comboBoxProductId.FormattingEnabled = true;
            this.comboBoxProductId.Location = new System.Drawing.Point(18, 55);
            this.comboBoxProductId.Name = "comboBoxProductId";
            this.comboBoxProductId.Size = new System.Drawing.Size(312, 33);
            this.comboBoxProductId.TabIndex = 2;
            this.comboBoxProductId.Text = "Select a Cargo Product";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Ship a Product";
            // 
            // panel6
            // 
            this.panel6.AutoSize = true;
            this.panel6.BackColor = System.Drawing.SystemColors.Info;
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.dataGridViewProducts);
            this.panel6.Controls.Add(this.label11);
            this.panel6.Location = new System.Drawing.Point(3, 230);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1010, 632);
            this.panel6.TabIndex = 0;
            // 
            // panel8
            // 
            this.panel8.AutoSize = true;
            this.panel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel8.Location = new System.Drawing.Point(0, 632);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1010, 0);
            this.panel8.TabIndex = 10;
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(3, 43);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.Size = new System.Drawing.Size(1004, 586);
            this.dataGridViewProducts.TabIndex = 7;
            this.dataGridViewProducts.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(16, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(209, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Available Products";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.panel5);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 6);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(1007, 121);
            this.flowLayoutPanel5.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnAddToCatalog);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Controls.Add(this.textBoxProductPrice);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.textBoxProductName);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(995, 113);
            this.panel5.TabIndex = 0;
            // 
            // btnAddToCatalog
            // 
            this.btnAddToCatalog.Location = new System.Drawing.Point(728, 48);
            this.btnAddToCatalog.Name = "btnAddToCatalog";
            this.btnAddToCatalog.Size = new System.Drawing.Size(199, 34);
            this.btnAddToCatalog.TabIndex = 5;
            this.btnAddToCatalog.Text = "Add To Catalog";
            this.btnAddToCatalog.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(460, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 25);
            this.label10.TabIndex = 9;
            this.label10.Text = "Price:";
            // 
            // textBoxProductPrice
            // 
            this.textBoxProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductPrice.Location = new System.Drawing.Point(539, 46);
            this.textBoxProductPrice.Name = "textBoxProductPrice";
            this.textBoxProductPrice.Size = new System.Drawing.Size(114, 36);
            this.textBoxProductPrice.TabIndex = 8;
            this.textBoxProductPrice.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(167, 25);
            this.label9.TabIndex = 7;
            this.label9.Text = "Product Name:";
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxProductName.Location = new System.Drawing.Point(186, 46);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(251, 36);
            this.textBoxProductName.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 4);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(235, 25);
            this.label8.TabIndex = 1;
            this.label8.Text = "Product Management";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1884, 1061);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "KarYönSistemi: Kargo Yönetim Sistemi";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShippingHistory)).EndInit();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBoxCargoId;
        private System.Windows.Forms.ComboBox comboBoxProductId;
        private System.Windows.Forms.Button btnStartShipping;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxProductPrice;
        private System.Windows.Forms.Button btnAddToCatalog;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.DataGridView dataGridViewShippingHistory;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheckDeliveryStatus;
        private System.Windows.Forms.TextBox textBoxProductId;
        private System.Windows.Forms.Label label1;
    }
}

