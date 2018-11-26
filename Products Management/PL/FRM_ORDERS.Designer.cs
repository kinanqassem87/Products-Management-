namespace Products_Management.PL
{
    partial class FRM_ORDERS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSellerName = new System.Windows.Forms.TextBox();
            this.dtpOrder = new System.Windows.Forms.DateTimePicker();
            this.txtOrderDesc = new System.Windows.Forms.TextBox();
            this.txtOrderId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnGetCustomer = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.txtLName = new System.Windows.Forms.TextBox();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.txtCustID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvOrder = new System.Windows.Forms.DataGridView();
            this.btnRowDelete = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnNewOrder = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnPrintOrder = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.txtIDProduct = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPriceOne = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPriceAll = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtLastPrice = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSelect = new System.Windows.Forms.Button();
            this.picCustomer = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSellerName);
            this.groupBox1.Controls.Add(this.dtpOrder);
            this.groupBox1.Controls.Add(this.txtOrderDesc);
            this.groupBox1.Controls.Add(this.txtOrderId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(390, 172);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "بيانات الفاتورة:";
            // 
            // txtSellerName
            // 
            this.txtSellerName.Location = new System.Drawing.Point(6, 129);
            this.txtSellerName.Name = "txtSellerName";
            this.txtSellerName.ReadOnly = true;
            this.txtSellerName.Size = new System.Drawing.Size(297, 20);
            this.txtSellerName.TabIndex = 7;
            // 
            // dtpOrder
            // 
            this.dtpOrder.Location = new System.Drawing.Point(6, 103);
            this.dtpOrder.Name = "dtpOrder";
            this.dtpOrder.Size = new System.Drawing.Size(297, 20);
            this.dtpOrder.TabIndex = 1;
            // 
            // txtOrderDesc
            // 
            this.txtOrderDesc.Location = new System.Drawing.Point(6, 51);
            this.txtOrderDesc.Multiline = true;
            this.txtOrderDesc.Name = "txtOrderDesc";
            this.txtOrderDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOrderDesc.Size = new System.Drawing.Size(297, 46);
            this.txtOrderDesc.TabIndex = 0;
            // 
            // txtOrderId
            // 
            this.txtOrderId.Location = new System.Drawing.Point(123, 25);
            this.txtOrderId.Name = "txtOrderId";
            this.txtOrderId.ReadOnly = true;
            this.txtOrderId.Size = new System.Drawing.Size(180, 20);
            this.txtOrderId.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "اسم البائع:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "تاريخ البيع:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "وصف الفاتورة:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "رقم الفاتورة:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.picCustomer);
            this.groupBox2.Controls.Add(this.btnGetCustomer);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Controls.Add(this.txtTel);
            this.groupBox2.Controls.Add(this.txtLName);
            this.groupBox2.Controls.Add(this.txtFname);
            this.groupBox2.Controls.Add(this.txtCustID);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(408, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(390, 172);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "بيانات العميل:";
            // 
            // btnGetCustomer
            // 
            this.btnGetCustomer.Location = new System.Drawing.Point(131, 23);
            this.btnGetCustomer.Name = "btnGetCustomer";
            this.btnGetCustomer.Size = new System.Drawing.Size(39, 23);
            this.btnGetCustomer.TabIndex = 0;
            this.btnGetCustomer.Text = "...";
            this.btnGetCustomer.UseVisualStyleBackColor = true;
            this.btnGetCustomer.Click += new System.EventHandler(this.btnGetCustomer_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 130);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(170, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(131, 104);
            this.txtTel.Name = "txtTel";
            this.txtTel.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(170, 20);
            this.txtTel.TabIndex = 8;
            // 
            // txtLName
            // 
            this.txtLName.Location = new System.Drawing.Point(131, 78);
            this.txtLName.Name = "txtLName";
            this.txtLName.ReadOnly = true;
            this.txtLName.Size = new System.Drawing.Size(170, 20);
            this.txtLName.TabIndex = 7;
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(131, 52);
            this.txtFname.Name = "txtFname";
            this.txtFname.ReadOnly = true;
            this.txtFname.Size = new System.Drawing.Size(170, 20);
            this.txtFname.TabIndex = 6;
            // 
            // txtCustID
            // 
            this.txtCustID.Location = new System.Drawing.Point(176, 26);
            this.txtCustID.Name = "txtCustID";
            this.txtCustID.ReadOnly = true;
            this.txtCustID.Size = new System.Drawing.Size(125, 20);
            this.txtCustID.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(307, 133);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "الايميل:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(307, 107);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "رقم الهاتف:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(307, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "الاسم الاخير:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(307, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "الاسم الاول:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(307, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "معرف العميل: ";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Controls.Add(this.txtLastPrice);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.txtDiscount);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.txtPriceAll);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.txtQty);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.txtPriceOne);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.txtProductName);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.txtIDProduct);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.dgvOrder);
            this.groupBox3.Controls.Add(this.btnSelect);
            this.groupBox3.Location = new System.Drawing.Point(12, 190);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(786, 306);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "المنتجات:";
            // 
            // dgvOrder
            // 
            this.dgvOrder.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrder.ColumnHeadersVisible = false;
            this.dgvOrder.Location = new System.Drawing.Point(3, 77);
            this.dgvOrder.MultiSelect = false;
            this.dgvOrder.Name = "dgvOrder";
            this.dgvOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrder.Size = new System.Drawing.Size(780, 223);
            this.dgvOrder.TabIndex = 0;
            // 
            // btnRowDelete
            // 
            this.btnRowDelete.Location = new System.Drawing.Point(18, 502);
            this.btnRowDelete.Name = "btnRowDelete";
            this.btnRowDelete.Size = new System.Drawing.Size(181, 23);
            this.btnRowDelete.TabIndex = 3;
            this.btnRowDelete.Text = "حذف السطر المحدد";
            this.btnRowDelete.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(589, 505);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "المجموع:";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(645, 502);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(153, 20);
            this.txtTotal.TabIndex = 5;
            // 
            // btnNewOrder
            // 
            this.btnNewOrder.Location = new System.Drawing.Point(500, 28);
            this.btnNewOrder.Name = "btnNewOrder";
            this.btnNewOrder.Size = new System.Drawing.Size(95, 23);
            this.btnNewOrder.TabIndex = 6;
            this.btnNewOrder.Text = "عملية بيع جديدة";
            this.btnNewOrder.UseVisualStyleBackColor = true;
            this.btnNewOrder.Click += new System.EventHandler(this.btnNewOrder_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.btnPrintOrder);
            this.groupBox4.Controls.Add(this.btnSave);
            this.groupBox4.Controls.Add(this.btnNewOrder);
            this.groupBox4.Location = new System.Drawing.Point(36, 531);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(759, 57);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "العمليات:";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(197, 28);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(95, 23);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "خروج";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnPrintOrder
            // 
            this.btnPrintOrder.Enabled = false;
            this.btnPrintOrder.Location = new System.Drawing.Point(298, 28);
            this.btnPrintOrder.Name = "btnPrintOrder";
            this.btnPrintOrder.Size = new System.Drawing.Size(95, 23);
            this.btnPrintOrder.TabIndex = 8;
            this.btnPrintOrder.Text = "طباعة الفاتورة";
            this.btnPrintOrder.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.Location = new System.Drawing.Point(399, 28);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(95, 23);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "حفظ العملية";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Silver;
            this.label11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label11.Location = new System.Drawing.Point(672, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 23);
            this.label11.TabIndex = 1;
            this.label11.Text = "معرف المنتج";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtIDProduct
            // 
            this.txtIDProduct.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIDProduct.Location = new System.Drawing.Point(672, 51);
            this.txtIDProduct.Name = "txtIDProduct";
            this.txtIDProduct.ReadOnly = true;
            this.txtIDProduct.Size = new System.Drawing.Size(70, 20);
            this.txtIDProduct.TabIndex = 2;
            this.txtIDProduct.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtProductName
            // 
            this.txtProductName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtProductName.Location = new System.Drawing.Point(536, 51);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.ReadOnly = true;
            this.txtProductName.Size = new System.Drawing.Size(137, 20);
            this.txtProductName.TabIndex = 4;
            this.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.BackColor = System.Drawing.Color.Silver;
            this.label12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label12.Location = new System.Drawing.Point(536, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 23);
            this.label12.TabIndex = 3;
            this.label12.Text = "اسم المنتج";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPriceOne
            // 
            this.txtPriceOne.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPriceOne.Location = new System.Drawing.Point(437, 51);
            this.txtPriceOne.Name = "txtPriceOne";
            this.txtPriceOne.Size = new System.Drawing.Size(100, 20);
            this.txtPriceOne.TabIndex = 6;
            this.txtPriceOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Silver;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Location = new System.Drawing.Point(437, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(100, 23);
            this.label13.TabIndex = 5;
            this.label13.Text = "سعر المفرد";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtQty
            // 
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.Location = new System.Drawing.Point(338, 51);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 20);
            this.txtQty.TabIndex = 8;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Silver;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Location = new System.Drawing.Point(338, 29);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(100, 23);
            this.label14.TabIndex = 7;
            this.label14.Text = "الكمية";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPriceAll
            // 
            this.txtPriceAll.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPriceAll.Location = new System.Drawing.Point(232, 51);
            this.txtPriceAll.Name = "txtPriceAll";
            this.txtPriceAll.ReadOnly = true;
            this.txtPriceAll.Size = new System.Drawing.Size(107, 20);
            this.txtPriceAll.TabIndex = 10;
            this.txtPriceAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Silver;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Location = new System.Drawing.Point(232, 29);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 23);
            this.label15.TabIndex = 9;
            this.label15.Text = "السعر الكلي";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDiscount
            // 
            this.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDiscount.Location = new System.Drawing.Point(126, 51);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(107, 20);
            this.txtDiscount.TabIndex = 12;
            this.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Silver;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Location = new System.Drawing.Point(126, 29);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 23);
            this.label16.TabIndex = 11;
            this.label16.Text = "نسبة الخصم %";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtLastPrice
            // 
            this.txtLastPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastPrice.Location = new System.Drawing.Point(6, 51);
            this.txtLastPrice.Name = "txtLastPrice";
            this.txtLastPrice.ReadOnly = true;
            this.txtLastPrice.Size = new System.Drawing.Size(121, 20);
            this.txtLastPrice.TabIndex = 14;
            this.txtLastPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.Silver;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Location = new System.Drawing.Point(6, 29);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(121, 23);
            this.label17.TabIndex = 13;
            this.label17.Text = "السعر الاجمالي";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Silver;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Location = new System.Drawing.Point(739, 29);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 23);
            this.label18.TabIndex = 15;
            this.label18.Text = "اختيار";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(743, 53);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(37, 18);
            this.btnSelect.TabIndex = 16;
            this.btnSelect.Text = "...";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // picCustomer
            // 
            this.picCustomer.Location = new System.Drawing.Point(6, 19);
            this.picCustomer.Name = "picCustomer";
            this.picCustomer.Size = new System.Drawing.Size(119, 141);
            this.picCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCustomer.TabIndex = 11;
            this.picCustomer.TabStop = false;
            // 
            // FRM_ORDERS
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 594);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnRowDelete);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FRM_ORDERS";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "عملية البيع";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrder)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSellerName;
        private System.Windows.Forms.DateTimePicker dtpOrder;
        private System.Windows.Forms.TextBox txtOrderDesc;
        private System.Windows.Forms.TextBox txtOrderId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picCustomer;
        private System.Windows.Forms.Button btnGetCustomer;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.TextBox txtLName;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.TextBox txtCustID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvOrder;
        private System.Windows.Forms.Button btnRowDelete;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnNewOrder;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPrintOrder;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtIDProduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtPriceOne;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtPriceAll;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtLastPrice;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSelect;
    }
}