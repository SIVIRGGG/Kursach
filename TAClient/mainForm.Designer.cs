namespace TAClient
{
    partial class mainForm
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbReport = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGo = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnSalesDelete = new System.Windows.Forms.Button();
            this.ctrSalesSumma = new System.Windows.Forms.NumericUpDown();
            this.bsSales = new System.Windows.Forms.BindingSource(this.components);
            this.dbDataSet = new TAClient.dbDataSet();
            this.btnSalesNew = new System.Windows.Forms.Button();
            this.btnSalesSave = new System.Windows.Forms.Button();
            this.btnSalesCancel = new System.Windows.Forms.Button();
            this.ctrSalesRetail = new System.Windows.Forms.ComboBox();
            this.bsRetails = new System.Windows.Forms.BindingSource(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.ctrSalesPayment = new System.Windows.Forms.ComboBox();
            this.bsPayments = new System.Windows.Forms.BindingSource(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ctrSalesQuantity = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.ctrSalesProduct = new System.Windows.Forms.ComboBox();
            this.bsProducts = new System.Windows.Forms.BindingSource(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.ctrSalesDates = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ctrSalesId = new System.Windows.Forms.TextBox();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btnProductsDelete = new System.Windows.Forms.Button();
            this.btnProductsNew = new System.Windows.Forms.Button();
            this.btnProductsSave = new System.Windows.Forms.Button();
            this.btnProductsCancel = new System.Windows.Forms.Button();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.btnPlansDelete = new System.Windows.Forms.Button();
            this.btnPlansNew = new System.Windows.Forms.Button();
            this.btnPlansSave = new System.Windows.Forms.Button();
            this.btnPlansCancel = new System.Windows.Forms.Button();
            this.dgvPlans = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.btnCategoriesDelete = new System.Windows.Forms.Button();
            this.btnCategoriesNew = new System.Windows.Forms.Button();
            this.btnCategoriesSave = new System.Windows.Forms.Button();
            this.btnCategoriesCancel = new System.Windows.Forms.Button();
            this.dgvCategories = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.btnUnitsDelete = new System.Windows.Forms.Button();
            this.btnUnitsNew = new System.Windows.Forms.Button();
            this.btnUnitsSave = new System.Windows.Forms.Button();
            this.btnUnitsCancel = new System.Windows.Forms.Button();
            this.dgvUnits = new System.Windows.Forms.DataGridView();
            this.bsCategories = new System.Windows.Forms.BindingSource(this.components);
            this.bsUnits = new System.Windows.Forms.BindingSource(this.components);
            this.bsPlans = new System.Windows.Forms.BindingSource(this.components);
            this.ctrProductUnit = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.ctrProductCategory = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.ctrProductId = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ctrProductName = new System.Windows.Forms.TextBox();
            this.ctrPlansSumma = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.ctrPlansYear = new System.Windows.Forms.NumericUpDown();
            this.label16 = new System.Windows.Forms.Label();
            this.ctrPlansMonth = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.ctrCategoriesName = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.ctrCategoriesId = new System.Windows.Forms.TextBox();
            this.ctrUnitsName = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.ctrUnitsId = new System.Windows.Forms.TextBox();
            this.dgvSalesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSalesDates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSalesProduct = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvSalesQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSalesSumma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductsCategory = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvProductsUnit = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dgvPlansYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPlansMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvPlansSumma = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategoriesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvCategoriesName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUnitsId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUnitsName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ctrSalesSumma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSales)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPayments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrSalesQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlans)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrPlansSumma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrPlansYear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrPlansMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbYear
            // 
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Location = new System.Drawing.Point(77, 31);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(121, 21);
            this.cmbYear.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Параметры формирования отчета";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Год:";
            // 
            // cmbReport
            // 
            this.cmbReport.FormattingEnabled = true;
            this.cmbReport.Items.AddRange(new object[] {
            "Выполнение плана по затратам",
            "Затраты в сопоставимых ценах",
            "Затраты по товарно-групповой структуре",
            "Затраты в разрезе форм оплаты",
            "Затраты по формам торговли",
            "Ритмичность затрат",
            "Сезонность затрат",
            "Средняя сумма затрат"});
            this.cmbReport.Location = new System.Drawing.Point(77, 58);
            this.cmbReport.Name = "cmbReport";
            this.cmbReport.Size = new System.Drawing.Size(388, 21);
            this.cmbReport.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Вид отчета:";
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(77, 86);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(121, 23);
            this.btnGo.TabIndex = 5;
            this.btnGo.Text = "Сформировать";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(784, 482);
            this.tabControl1.TabIndex = 6;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.btnGo);
            this.tabPage1.Controls.Add(this.cmbYear);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cmbReport);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(776, 456);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Отчеты";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(776, 456);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Продажи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnSalesDelete);
            this.splitContainer1.Panel1.Controls.Add(this.ctrSalesSumma);
            this.splitContainer1.Panel1.Controls.Add(this.btnSalesNew);
            this.splitContainer1.Panel1.Controls.Add(this.btnSalesSave);
            this.splitContainer1.Panel1.Controls.Add(this.btnSalesCancel);
            this.splitContainer1.Panel1.Controls.Add(this.ctrSalesRetail);
            this.splitContainer1.Panel1.Controls.Add(this.label10);
            this.splitContainer1.Panel1.Controls.Add(this.ctrSalesPayment);
            this.splitContainer1.Panel1.Controls.Add(this.label9);
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.ctrSalesQuantity);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.ctrSalesProduct);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.ctrSalesDates);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.ctrSalesId);
            this.splitContainer1.Panel1MinSize = 100;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvSales);
            this.splitContainer1.Size = new System.Drawing.Size(770, 450);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnSalesDelete
            // 
            this.btnSalesDelete.Location = new System.Drawing.Point(614, 74);
            this.btnSalesDelete.Name = "btnSalesDelete";
            this.btnSalesDelete.Size = new System.Drawing.Size(75, 23);
            this.btnSalesDelete.TabIndex = 18;
            this.btnSalesDelete.Text = "Удалить";
            this.btnSalesDelete.UseVisualStyleBackColor = true;
            this.btnSalesDelete.Click += new System.EventHandler(this.btnSalesDelete_Click);
            // 
            // ctrSalesSumma
            // 
            this.ctrSalesSumma.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsSales, "summa", true));
            this.ctrSalesSumma.DecimalPlaces = 2;
            this.ctrSalesSumma.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ctrSalesSumma.Location = new System.Drawing.Point(201, 29);
            this.ctrSalesSumma.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.ctrSalesSumma.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.ctrSalesSumma.Name = "ctrSalesSumma";
            this.ctrSalesSumma.Size = new System.Drawing.Size(138, 20);
            this.ctrSalesSumma.TabIndex = 17;
            this.ctrSalesSumma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctrSalesSumma.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // bsSales
            // 
            this.bsSales.DataMember = "sales";
            this.bsSales.DataSource = this.dbDataSet;
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnSalesNew
            // 
            this.btnSalesNew.Location = new System.Drawing.Point(533, 74);
            this.btnSalesNew.Name = "btnSalesNew";
            this.btnSalesNew.Size = new System.Drawing.Size(75, 23);
            this.btnSalesNew.TabIndex = 16;
            this.btnSalesNew.Text = "Новый";
            this.btnSalesNew.UseVisualStyleBackColor = true;
            this.btnSalesNew.Click += new System.EventHandler(this.btnSalesNew_Click);
            // 
            // btnSalesSave
            // 
            this.btnSalesSave.Location = new System.Drawing.Point(452, 74);
            this.btnSalesSave.Name = "btnSalesSave";
            this.btnSalesSave.Size = new System.Drawing.Size(75, 23);
            this.btnSalesSave.TabIndex = 15;
            this.btnSalesSave.Text = "Сохранить";
            this.btnSalesSave.UseVisualStyleBackColor = true;
            this.btnSalesSave.Click += new System.EventHandler(this.btnSalesSave_Click);
            // 
            // btnSalesCancel
            // 
            this.btnSalesCancel.Location = new System.Drawing.Point(695, 74);
            this.btnSalesCancel.Name = "btnSalesCancel";
            this.btnSalesCancel.Size = new System.Drawing.Size(75, 23);
            this.btnSalesCancel.TabIndex = 14;
            this.btnSalesCancel.Text = "Отмена";
            this.btnSalesCancel.UseVisualStyleBackColor = true;
            this.btnSalesCancel.Click += new System.EventHandler(this.btnSalesCancel_Click);
            // 
            // ctrSalesRetail
            // 
            this.ctrSalesRetail.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsSales, "retail", true));
            this.ctrSalesRetail.DataSource = this.bsRetails;
            this.ctrSalesRetail.DisplayMember = "name";
            this.ctrSalesRetail.FormattingEnabled = true;
            this.ctrSalesRetail.Location = new System.Drawing.Point(598, 28);
            this.ctrSalesRetail.Name = "ctrSalesRetail";
            this.ctrSalesRetail.Size = new System.Drawing.Size(167, 21);
            this.ctrSalesRetail.TabIndex = 13;
            this.ctrSalesRetail.ValueMember = "id";
            // 
            // bsRetails
            // 
            this.bsRetails.DataMember = "retails";
            this.bsRetails.DataSource = this.dbDataSet;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(539, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 12;
            this.label10.Text = "Продажа";
            // 
            // ctrSalesPayment
            // 
            this.ctrSalesPayment.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsSales, "payment", true));
            this.ctrSalesPayment.DataSource = this.bsPayments;
            this.ctrSalesPayment.DisplayMember = "name";
            this.ctrSalesPayment.FormattingEnabled = true;
            this.ctrSalesPayment.Location = new System.Drawing.Point(390, 28);
            this.ctrSalesPayment.Name = "ctrSalesPayment";
            this.ctrSalesPayment.Size = new System.Drawing.Size(143, 21);
            this.ctrSalesPayment.TabIndex = 11;
            this.ctrSalesPayment.ValueMember = "id";
            // 
            // bsPayments
            // 
            this.bsPayments.DataMember = "payments";
            this.bsPayments.DataSource = this.dbDataSet;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(342, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Оплата";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(153, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Затраты";
            // 
            // ctrSalesQuantity
            // 
            this.ctrSalesQuantity.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsSales, "quantity", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "N0"));
            this.ctrSalesQuantity.Location = new System.Drawing.Point(47, 30);
            this.ctrSalesQuantity.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctrSalesQuantity.Name = "ctrSalesQuantity";
            this.ctrSalesQuantity.Size = new System.Drawing.Size(100, 20);
            this.ctrSalesQuantity.TabIndex = 7;
            this.ctrSalesQuantity.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctrSalesQuantity.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Кол-во";
            // 
            // ctrSalesProduct
            // 
            this.ctrSalesProduct.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsSales, "product", true));
            this.ctrSalesProduct.DataSource = this.bsProducts;
            this.ctrSalesProduct.DisplayMember = "name";
            this.ctrSalesProduct.FormattingEnabled = true;
            this.ctrSalesProduct.Location = new System.Drawing.Point(390, 3);
            this.ctrSalesProduct.Name = "ctrSalesProduct";
            this.ctrSalesProduct.Size = new System.Drawing.Size(375, 21);
            this.ctrSalesProduct.TabIndex = 5;
            this.ctrSalesProduct.ValueMember = "id";
            // 
            // bsProducts
            // 
            this.bsProducts.DataMember = "products";
            this.bsProducts.DataSource = this.dbDataSet;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(342, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Товар";
            // 
            // ctrSalesDates
            // 
            this.ctrSalesDates.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsSales, "dates", true, System.Windows.Forms.DataSourceUpdateMode.OnValidation, null, "d"));
            this.ctrSalesDates.Location = new System.Drawing.Point(201, 4);
            this.ctrSalesDates.Name = "ctrSalesDates";
            this.ctrSalesDates.Size = new System.Drawing.Size(138, 20);
            this.ctrSalesDates.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(153, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Дата";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Код";
            // 
            // ctrSalesId
            // 
            this.ctrSalesId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsSales, "id", true));
            this.ctrSalesId.Location = new System.Drawing.Point(47, 4);
            this.ctrSalesId.Name = "ctrSalesId";
            this.ctrSalesId.ReadOnly = true;
            this.ctrSalesId.Size = new System.Drawing.Size(100, 20);
            this.ctrSalesId.TabIndex = 0;
            this.ctrSalesId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AutoGenerateColumns = false;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvSalesId,
            this.dgvSalesDates,
            this.dgvSalesProduct,
            this.dgvSalesQuantity,
            this.dgvSalesSumma});
            this.dgvSales.DataSource = this.bsSales;
            this.dgvSales.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSales.Location = new System.Drawing.Point(0, 0);
            this.dgvSales.MultiSelect = false;
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(770, 346);
            this.dgvSales.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer2);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(776, 456);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Товары";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.ctrProductName);
            this.splitContainer2.Panel1.Controls.Add(this.label14);
            this.splitContainer2.Panel1.Controls.Add(this.ctrProductUnit);
            this.splitContainer2.Panel1.Controls.Add(this.label11);
            this.splitContainer2.Panel1.Controls.Add(this.ctrProductCategory);
            this.splitContainer2.Panel1.Controls.Add(this.label12);
            this.splitContainer2.Panel1.Controls.Add(this.label13);
            this.splitContainer2.Panel1.Controls.Add(this.ctrProductId);
            this.splitContainer2.Panel1.Controls.Add(this.btnProductsDelete);
            this.splitContainer2.Panel1.Controls.Add(this.btnProductsNew);
            this.splitContainer2.Panel1.Controls.Add(this.btnProductsSave);
            this.splitContainer2.Panel1.Controls.Add(this.btnProductsCancel);
            this.splitContainer2.Panel1MinSize = 100;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dgvProducts);
            this.splitContainer2.Size = new System.Drawing.Size(776, 456);
            this.splitContainer2.SplitterDistance = 101;
            this.splitContainer2.TabIndex = 1;
            // 
            // btnProductsDelete
            // 
            this.btnProductsDelete.Location = new System.Drawing.Point(617, 75);
            this.btnProductsDelete.Name = "btnProductsDelete";
            this.btnProductsDelete.Size = new System.Drawing.Size(75, 23);
            this.btnProductsDelete.TabIndex = 20;
            this.btnProductsDelete.Text = "Удалить";
            this.btnProductsDelete.UseVisualStyleBackColor = true;
            this.btnProductsDelete.Click += new System.EventHandler(this.btnProductsDelete_Click);
            // 
            // btnProductsNew
            // 
            this.btnProductsNew.Location = new System.Drawing.Point(455, 76);
            this.btnProductsNew.Name = "btnProductsNew";
            this.btnProductsNew.Size = new System.Drawing.Size(75, 23);
            this.btnProductsNew.TabIndex = 19;
            this.btnProductsNew.Text = "Новый";
            this.btnProductsNew.UseVisualStyleBackColor = true;
            this.btnProductsNew.Click += new System.EventHandler(this.btnProductsNew_Click);
            // 
            // btnProductsSave
            // 
            this.btnProductsSave.Location = new System.Drawing.Point(536, 76);
            this.btnProductsSave.Name = "btnProductsSave";
            this.btnProductsSave.Size = new System.Drawing.Size(75, 23);
            this.btnProductsSave.TabIndex = 18;
            this.btnProductsSave.Text = "Сохранить";
            this.btnProductsSave.UseVisualStyleBackColor = true;
            this.btnProductsSave.Click += new System.EventHandler(this.btnProductsSave_Click);
            // 
            // btnProductsCancel
            // 
            this.btnProductsCancel.Location = new System.Drawing.Point(698, 75);
            this.btnProductsCancel.Name = "btnProductsCancel";
            this.btnProductsCancel.Size = new System.Drawing.Size(75, 23);
            this.btnProductsCancel.TabIndex = 17;
            this.btnProductsCancel.Text = "Отмена";
            this.btnProductsCancel.UseVisualStyleBackColor = true;
            this.btnProductsCancel.Click += new System.EventHandler(this.btnProductsCancel_Click);
            // 
            // dgvProducts
            // 
            this.dgvProducts.AllowUserToAddRows = false;
            this.dgvProducts.AllowUserToDeleteRows = false;
            this.dgvProducts.AutoGenerateColumns = false;
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvProductsId,
            this.dgvProductsName,
            this.dgvProductsCategory,
            this.dgvProductsUnit});
            this.dgvProducts.DataSource = this.bsProducts;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProducts.Location = new System.Drawing.Point(0, 0);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.ReadOnly = true;
            this.dgvProducts.Size = new System.Drawing.Size(776, 351);
            this.dgvProducts.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.splitContainer3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(776, 456);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "План";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.ctrPlansMonth);
            this.splitContainer3.Panel1.Controls.Add(this.label17);
            this.splitContainer3.Panel1.Controls.Add(this.ctrPlansSumma);
            this.splitContainer3.Panel1.Controls.Add(this.label15);
            this.splitContainer3.Panel1.Controls.Add(this.ctrPlansYear);
            this.splitContainer3.Panel1.Controls.Add(this.label16);
            this.splitContainer3.Panel1.Controls.Add(this.btnPlansDelete);
            this.splitContainer3.Panel1.Controls.Add(this.btnPlansNew);
            this.splitContainer3.Panel1.Controls.Add(this.btnPlansSave);
            this.splitContainer3.Panel1.Controls.Add(this.btnPlansCancel);
            this.splitContainer3.Panel1MinSize = 100;
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.dgvPlans);
            this.splitContainer3.Size = new System.Drawing.Size(776, 456);
            this.splitContainer3.SplitterDistance = 101;
            this.splitContainer3.TabIndex = 1;
            // 
            // btnPlansDelete
            // 
            this.btnPlansDelete.Location = new System.Drawing.Point(617, 76);
            this.btnPlansDelete.Name = "btnPlansDelete";
            this.btnPlansDelete.Size = new System.Drawing.Size(75, 23);
            this.btnPlansDelete.TabIndex = 20;
            this.btnPlansDelete.Text = "Удалить";
            this.btnPlansDelete.UseVisualStyleBackColor = true;
            this.btnPlansDelete.Click += new System.EventHandler(this.btnPlansDelete_Click);
            // 
            // btnPlansNew
            // 
            this.btnPlansNew.Location = new System.Drawing.Point(455, 76);
            this.btnPlansNew.Name = "btnPlansNew";
            this.btnPlansNew.Size = new System.Drawing.Size(75, 23);
            this.btnPlansNew.TabIndex = 19;
            this.btnPlansNew.Text = "Новый";
            this.btnPlansNew.UseVisualStyleBackColor = true;
            this.btnPlansNew.Click += new System.EventHandler(this.btnPlansNew_Click);
            // 
            // btnPlansSave
            // 
            this.btnPlansSave.Location = new System.Drawing.Point(536, 76);
            this.btnPlansSave.Name = "btnPlansSave";
            this.btnPlansSave.Size = new System.Drawing.Size(75, 23);
            this.btnPlansSave.TabIndex = 18;
            this.btnPlansSave.Text = "Сохранить";
            this.btnPlansSave.UseVisualStyleBackColor = true;
            this.btnPlansSave.Click += new System.EventHandler(this.btnPlansSave_Click);
            // 
            // btnPlansCancel
            // 
            this.btnPlansCancel.Location = new System.Drawing.Point(698, 76);
            this.btnPlansCancel.Name = "btnPlansCancel";
            this.btnPlansCancel.Size = new System.Drawing.Size(75, 23);
            this.btnPlansCancel.TabIndex = 17;
            this.btnPlansCancel.Text = "Отмена";
            this.btnPlansCancel.UseVisualStyleBackColor = true;
            this.btnPlansCancel.Click += new System.EventHandler(this.btnPlansCancel_Click);
            // 
            // dgvPlans
            // 
            this.dgvPlans.AllowUserToAddRows = false;
            this.dgvPlans.AllowUserToDeleteRows = false;
            this.dgvPlans.AutoGenerateColumns = false;
            this.dgvPlans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPlans.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvPlansYear,
            this.dgvPlansMonth,
            this.dgvPlansSumma});
            this.dgvPlans.DataSource = this.bsPlans;
            this.dgvPlans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlans.Location = new System.Drawing.Point(0, 0);
            this.dgvPlans.Name = "dgvPlans";
            this.dgvPlans.ReadOnly = true;
            this.dgvPlans.Size = new System.Drawing.Size(776, 351);
            this.dgvPlans.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.splitContainer4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(776, 456);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Категории";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 0);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.ctrCategoriesName);
            this.splitContainer4.Panel1.Controls.Add(this.label18);
            this.splitContainer4.Panel1.Controls.Add(this.label19);
            this.splitContainer4.Panel1.Controls.Add(this.ctrCategoriesId);
            this.splitContainer4.Panel1.Controls.Add(this.btnCategoriesDelete);
            this.splitContainer4.Panel1.Controls.Add(this.btnCategoriesNew);
            this.splitContainer4.Panel1.Controls.Add(this.btnCategoriesSave);
            this.splitContainer4.Panel1.Controls.Add(this.btnCategoriesCancel);
            this.splitContainer4.Panel1MinSize = 100;
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.dgvCategories);
            this.splitContainer4.Size = new System.Drawing.Size(776, 456);
            this.splitContainer4.SplitterDistance = 101;
            this.splitContainer4.TabIndex = 1;
            // 
            // btnCategoriesDelete
            // 
            this.btnCategoriesDelete.Location = new System.Drawing.Point(616, 75);
            this.btnCategoriesDelete.Name = "btnCategoriesDelete";
            this.btnCategoriesDelete.Size = new System.Drawing.Size(75, 23);
            this.btnCategoriesDelete.TabIndex = 20;
            this.btnCategoriesDelete.Text = "Удалить";
            this.btnCategoriesDelete.UseVisualStyleBackColor = true;
            this.btnCategoriesDelete.Click += new System.EventHandler(this.btnCategoriesDelete_Click);
            // 
            // btnCategoriesNew
            // 
            this.btnCategoriesNew.Location = new System.Drawing.Point(454, 75);
            this.btnCategoriesNew.Name = "btnCategoriesNew";
            this.btnCategoriesNew.Size = new System.Drawing.Size(75, 23);
            this.btnCategoriesNew.TabIndex = 19;
            this.btnCategoriesNew.Text = "Новый";
            this.btnCategoriesNew.UseVisualStyleBackColor = true;
            this.btnCategoriesNew.Click += new System.EventHandler(this.btnCategoriesNew_Click);
            // 
            // btnCategoriesSave
            // 
            this.btnCategoriesSave.Location = new System.Drawing.Point(535, 75);
            this.btnCategoriesSave.Name = "btnCategoriesSave";
            this.btnCategoriesSave.Size = new System.Drawing.Size(75, 23);
            this.btnCategoriesSave.TabIndex = 18;
            this.btnCategoriesSave.Text = "Сохранить";
            this.btnCategoriesSave.UseVisualStyleBackColor = true;
            this.btnCategoriesSave.Click += new System.EventHandler(this.btnCategoriesSave_Click);
            // 
            // btnCategoriesCancel
            // 
            this.btnCategoriesCancel.Location = new System.Drawing.Point(697, 75);
            this.btnCategoriesCancel.Name = "btnCategoriesCancel";
            this.btnCategoriesCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCategoriesCancel.TabIndex = 17;
            this.btnCategoriesCancel.Text = "Отмена";
            this.btnCategoriesCancel.UseVisualStyleBackColor = true;
            this.btnCategoriesCancel.Click += new System.EventHandler(this.btnCategoriesCancel_Click);
            // 
            // dgvCategories
            // 
            this.dgvCategories.AllowUserToAddRows = false;
            this.dgvCategories.AllowUserToDeleteRows = false;
            this.dgvCategories.AutoGenerateColumns = false;
            this.dgvCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvCategoriesId,
            this.dgvCategoriesName});
            this.dgvCategories.DataSource = this.bsCategories;
            this.dgvCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategories.Location = new System.Drawing.Point(0, 0);
            this.dgvCategories.Name = "dgvCategories";
            this.dgvCategories.ReadOnly = true;
            this.dgvCategories.Size = new System.Drawing.Size(776, 351);
            this.dgvCategories.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.splitContainer5);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(776, 456);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Единицы измерения";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(0, 0);
            this.splitContainer5.Name = "splitContainer5";
            this.splitContainer5.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.ctrUnitsName);
            this.splitContainer5.Panel1.Controls.Add(this.label20);
            this.splitContainer5.Panel1.Controls.Add(this.label21);
            this.splitContainer5.Panel1.Controls.Add(this.ctrUnitsId);
            this.splitContainer5.Panel1.Controls.Add(this.btnUnitsDelete);
            this.splitContainer5.Panel1.Controls.Add(this.btnUnitsNew);
            this.splitContainer5.Panel1.Controls.Add(this.btnUnitsSave);
            this.splitContainer5.Panel1.Controls.Add(this.btnUnitsCancel);
            this.splitContainer5.Panel1MinSize = 100;
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.dgvUnits);
            this.splitContainer5.Size = new System.Drawing.Size(776, 456);
            this.splitContainer5.SplitterDistance = 101;
            this.splitContainer5.TabIndex = 1;
            // 
            // btnUnitsDelete
            // 
            this.btnUnitsDelete.Location = new System.Drawing.Point(616, 75);
            this.btnUnitsDelete.Name = "btnUnitsDelete";
            this.btnUnitsDelete.Size = new System.Drawing.Size(75, 23);
            this.btnUnitsDelete.TabIndex = 20;
            this.btnUnitsDelete.Text = "Удалить";
            this.btnUnitsDelete.UseVisualStyleBackColor = true;
            this.btnUnitsDelete.Click += new System.EventHandler(this.btnUnitsDelete_Click);
            // 
            // btnUnitsNew
            // 
            this.btnUnitsNew.Location = new System.Drawing.Point(454, 75);
            this.btnUnitsNew.Name = "btnUnitsNew";
            this.btnUnitsNew.Size = new System.Drawing.Size(75, 23);
            this.btnUnitsNew.TabIndex = 19;
            this.btnUnitsNew.Text = "Новый";
            this.btnUnitsNew.UseVisualStyleBackColor = true;
            this.btnUnitsNew.Click += new System.EventHandler(this.btnUnitsNew_Click);
            // 
            // btnUnitsSave
            // 
            this.btnUnitsSave.Location = new System.Drawing.Point(535, 75);
            this.btnUnitsSave.Name = "btnUnitsSave";
            this.btnUnitsSave.Size = new System.Drawing.Size(75, 23);
            this.btnUnitsSave.TabIndex = 18;
            this.btnUnitsSave.Text = "Сохранить";
            this.btnUnitsSave.UseVisualStyleBackColor = true;
            this.btnUnitsSave.Click += new System.EventHandler(this.btnUnitsSave_Click);
            // 
            // btnUnitsCancel
            // 
            this.btnUnitsCancel.Location = new System.Drawing.Point(697, 75);
            this.btnUnitsCancel.Name = "btnUnitsCancel";
            this.btnUnitsCancel.Size = new System.Drawing.Size(75, 23);
            this.btnUnitsCancel.TabIndex = 17;
            this.btnUnitsCancel.Text = "Отмена";
            this.btnUnitsCancel.UseVisualStyleBackColor = true;
            this.btnUnitsCancel.Click += new System.EventHandler(this.btnUnitsCancel_Click);
            // 
            // dgvUnits
            // 
            this.dgvUnits.AllowUserToAddRows = false;
            this.dgvUnits.AllowUserToDeleteRows = false;
            this.dgvUnits.AutoGenerateColumns = false;
            this.dgvUnits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvUnitsId,
            this.dgvUnitsName});
            this.dgvUnits.DataSource = this.bsUnits;
            this.dgvUnits.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUnits.Location = new System.Drawing.Point(0, 0);
            this.dgvUnits.Name = "dgvUnits";
            this.dgvUnits.ReadOnly = true;
            this.dgvUnits.Size = new System.Drawing.Size(776, 351);
            this.dgvUnits.TabIndex = 0;
            // 
            // bsCategories
            // 
            this.bsCategories.DataMember = "categories";
            this.bsCategories.DataSource = this.dbDataSet;
            // 
            // bsUnits
            // 
            this.bsUnits.DataMember = "units";
            this.bsUnits.DataSource = this.dbDataSet;
            // 
            // bsPlans
            // 
            this.bsPlans.DataMember = "plans";
            this.bsPlans.DataSource = this.dbDataSet;
            // 
            // ctrProductUnit
            // 
            this.ctrProductUnit.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProducts, "unit", true));
            this.ctrProductUnit.DataSource = this.bsUnits;
            this.ctrProductUnit.DisplayMember = "name";
            this.ctrProductUnit.FormattingEnabled = true;
            this.ctrProductUnit.Location = new System.Drawing.Point(618, 33);
            this.ctrProductUnit.Name = "ctrProductUnit";
            this.ctrProductUnit.Size = new System.Drawing.Size(156, 21);
            this.ctrProductUnit.TabIndex = 26;
            this.ctrProductUnit.ValueMember = "id";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(503, 37);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(109, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Единица измерения";
            // 
            // ctrProductCategory
            // 
            this.ctrProductCategory.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.bsProducts, "category", true));
            this.ctrProductCategory.DataSource = this.bsCategories;
            this.ctrProductCategory.DisplayMember = "name";
            this.ctrProductCategory.FormattingEnabled = true;
            this.ctrProductCategory.Location = new System.Drawing.Point(247, 33);
            this.ctrProductCategory.Name = "ctrProductCategory";
            this.ctrProductCategory.Size = new System.Drawing.Size(250, 21);
            this.ctrProductCategory.TabIndex = 24;
            this.ctrProductCategory.ValueMember = "id";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(158, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Категория";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(26, 13);
            this.label13.TabIndex = 22;
            this.label13.Text = "Код";
            // 
            // ctrProductId
            // 
            this.ctrProductId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducts, "id", true));
            this.ctrProductId.Location = new System.Drawing.Point(52, 7);
            this.ctrProductId.Name = "ctrProductId";
            this.ctrProductId.ReadOnly = true;
            this.ctrProductId.Size = new System.Drawing.Size(100, 20);
            this.ctrProductId.TabIndex = 21;
            this.ctrProductId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(158, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(83, 13);
            this.label14.TabIndex = 27;
            this.label14.Text = "Наименование";
            // 
            // ctrProductName
            // 
            this.ctrProductName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsProducts, "name", true));
            this.ctrProductName.Location = new System.Drawing.Point(247, 7);
            this.ctrProductName.Name = "ctrProductName";
            this.ctrProductName.Size = new System.Drawing.Size(527, 20);
            this.ctrProductName.TabIndex = 28;
            // 
            // ctrPlansSumma
            // 
            this.ctrPlansSumma.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsPlans, "summa", true));
            this.ctrPlansSumma.DecimalPlaces = 2;
            this.ctrPlansSumma.Location = new System.Drawing.Point(343, 7);
            this.ctrPlansSumma.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.ctrPlansSumma.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ctrPlansSumma.Name = "ctrPlansSumma";
            this.ctrPlansSumma.Size = new System.Drawing.Size(138, 20);
            this.ctrPlansSumma.TabIndex = 24;
            this.ctrPlansSumma.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctrPlansSumma.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(296, 9);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 13);
            this.label15.TabIndex = 23;
            this.label15.Text = "Затраты";
            // 
            // ctrPlansYear
            // 
            this.ctrPlansYear.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsPlans, "year", true));
            this.ctrPlansYear.Location = new System.Drawing.Point(38, 7);
            this.ctrPlansYear.Maximum = new decimal(new int[] {
            2100,
            0,
            0,
            0});
            this.ctrPlansYear.Minimum = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            this.ctrPlansYear.Name = "ctrPlansYear";
            this.ctrPlansYear.Size = new System.Drawing.Size(100, 20);
            this.ctrPlansYear.TabIndex = 22;
            this.ctrPlansYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctrPlansYear.Value = new decimal(new int[] {
            2013,
            0,
            0,
            0});
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(25, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Год";
            // 
            // ctrPlansMonth
            // 
            this.ctrPlansMonth.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.bsPlans, "month", true));
            this.ctrPlansMonth.Location = new System.Drawing.Point(190, 7);
            this.ctrPlansMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.ctrPlansMonth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ctrPlansMonth.Name = "ctrPlansMonth";
            this.ctrPlansMonth.Size = new System.Drawing.Size(100, 20);
            this.ctrPlansMonth.TabIndex = 26;
            this.ctrPlansMonth.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ctrPlansMonth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(144, 10);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 25;
            this.label17.Text = "Месяц";
            // 
            // ctrCategoriesName
            // 
            this.ctrCategoriesName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCategories, "name", true));
            this.ctrCategoriesName.Location = new System.Drawing.Point(248, 6);
            this.ctrCategoriesName.Name = "ctrCategoriesName";
            this.ctrCategoriesName.Size = new System.Drawing.Size(527, 20);
            this.ctrCategoriesName.TabIndex = 32;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(159, 9);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(83, 13);
            this.label18.TabIndex = 31;
            this.label18.Text = "Наименование";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(5, 9);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(26, 13);
            this.label19.TabIndex = 30;
            this.label19.Text = "Код";
            // 
            // ctrCategoriesId
            // 
            this.ctrCategoriesId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsCategories, "id", true));
            this.ctrCategoriesId.Location = new System.Drawing.Point(53, 6);
            this.ctrCategoriesId.Name = "ctrCategoriesId";
            this.ctrCategoriesId.ReadOnly = true;
            this.ctrCategoriesId.Size = new System.Drawing.Size(100, 20);
            this.ctrCategoriesId.TabIndex = 29;
            this.ctrCategoriesId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // ctrUnitsName
            // 
            this.ctrUnitsName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUnits, "name", true));
            this.ctrUnitsName.Location = new System.Drawing.Point(246, 9);
            this.ctrUnitsName.Name = "ctrUnitsName";
            this.ctrUnitsName.Size = new System.Drawing.Size(527, 20);
            this.ctrUnitsName.TabIndex = 32;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(157, 12);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(83, 13);
            this.label20.TabIndex = 31;
            this.label20.Text = "Наименование";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 12);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(26, 13);
            this.label21.TabIndex = 30;
            this.label21.Text = "Код";
            // 
            // ctrUnitsId
            // 
            this.ctrUnitsId.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bsUnits, "id", true));
            this.ctrUnitsId.Location = new System.Drawing.Point(51, 9);
            this.ctrUnitsId.Name = "ctrUnitsId";
            this.ctrUnitsId.ReadOnly = true;
            this.ctrUnitsId.Size = new System.Drawing.Size(100, 20);
            this.ctrUnitsId.TabIndex = 29;
            this.ctrUnitsId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgvSalesId
            // 
            this.dgvSalesId.DataPropertyName = "id";
            this.dgvSalesId.HeaderText = "Код";
            this.dgvSalesId.Name = "dgvSalesId";
            this.dgvSalesId.ReadOnly = true;
            this.dgvSalesId.Width = 50;
            // 
            // dgvSalesDates
            // 
            this.dgvSalesDates.DataPropertyName = "dates";
            this.dgvSalesDates.HeaderText = "Дата";
            this.dgvSalesDates.Name = "dgvSalesDates";
            this.dgvSalesDates.ReadOnly = true;
            // 
            // dgvSalesProduct
            // 
            this.dgvSalesProduct.DataPropertyName = "product";
            this.dgvSalesProduct.DataSource = this.bsProducts;
            this.dgvSalesProduct.DisplayMember = "name";
            this.dgvSalesProduct.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dgvSalesProduct.FillWeight = 300F;
            this.dgvSalesProduct.HeaderText = "Товар";
            this.dgvSalesProduct.Name = "dgvSalesProduct";
            this.dgvSalesProduct.ReadOnly = true;
            this.dgvSalesProduct.ValueMember = "id";
            this.dgvSalesProduct.Width = 300;
            // 
            // dgvSalesQuantity
            // 
            this.dgvSalesQuantity.DataPropertyName = "quantity";
            this.dgvSalesQuantity.HeaderText = "Количество";
            this.dgvSalesQuantity.Name = "dgvSalesQuantity";
            this.dgvSalesQuantity.ReadOnly = true;
            // 
            // dgvSalesSumma
            // 
            this.dgvSalesSumma.DataPropertyName = "summa";
            this.dgvSalesSumma.HeaderText = "Затраты";
            this.dgvSalesSumma.Name = "dgvSalesSumma";
            this.dgvSalesSumma.ReadOnly = true;
            // 
            // dgvProductsId
            // 
            this.dgvProductsId.DataPropertyName = "id";
            this.dgvProductsId.HeaderText = "Код";
            this.dgvProductsId.Name = "dgvProductsId";
            this.dgvProductsId.ReadOnly = true;
            this.dgvProductsId.Width = 75;
            // 
            // dgvProductsName
            // 
            this.dgvProductsName.DataPropertyName = "name";
            this.dgvProductsName.HeaderText = "Наименование";
            this.dgvProductsName.Name = "dgvProductsName";
            this.dgvProductsName.ReadOnly = true;
            this.dgvProductsName.Width = 250;
            // 
            // dgvProductsCategory
            // 
            this.dgvProductsCategory.DataPropertyName = "category";
            this.dgvProductsCategory.DataSource = this.bsCategories;
            this.dgvProductsCategory.DisplayMember = "name";
            this.dgvProductsCategory.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dgvProductsCategory.HeaderText = "Категория";
            this.dgvProductsCategory.Name = "dgvProductsCategory";
            this.dgvProductsCategory.ReadOnly = true;
            this.dgvProductsCategory.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductsCategory.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvProductsCategory.ValueMember = "id";
            this.dgvProductsCategory.Width = 200;
            // 
            // dgvProductsUnit
            // 
            this.dgvProductsUnit.DataPropertyName = "unit";
            this.dgvProductsUnit.DataSource = this.bsUnits;
            this.dgvProductsUnit.DisplayMember = "name";
            this.dgvProductsUnit.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.ComboBox;
            this.dgvProductsUnit.HeaderText = "Единица измерения";
            this.dgvProductsUnit.Name = "dgvProductsUnit";
            this.dgvProductsUnit.ReadOnly = true;
            this.dgvProductsUnit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductsUnit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dgvProductsUnit.ValueMember = "id";
            this.dgvProductsUnit.Width = 150;
            // 
            // dgvPlansYear
            // 
            this.dgvPlansYear.DataPropertyName = "year";
            this.dgvPlansYear.HeaderText = "Год";
            this.dgvPlansYear.Name = "dgvPlansYear";
            this.dgvPlansYear.ReadOnly = true;
            // 
            // dgvPlansMonth
            // 
            this.dgvPlansMonth.DataPropertyName = "month";
            this.dgvPlansMonth.HeaderText = "Месяц";
            this.dgvPlansMonth.Name = "dgvPlansMonth";
            this.dgvPlansMonth.ReadOnly = true;
            // 
            // dgvPlansSumma
            // 
            this.dgvPlansSumma.DataPropertyName = "summa";
            this.dgvPlansSumma.HeaderText = "Затраты";
            this.dgvPlansSumma.Name = "dgvPlansSumma";
            this.dgvPlansSumma.ReadOnly = true;
            this.dgvPlansSumma.Width = 200;
            // 
            // dgvCategoriesId
            // 
            this.dgvCategoriesId.DataPropertyName = "id";
            this.dgvCategoriesId.HeaderText = "Код";
            this.dgvCategoriesId.Name = "dgvCategoriesId";
            this.dgvCategoriesId.ReadOnly = true;
            // 
            // dgvCategoriesName
            // 
            this.dgvCategoriesName.DataPropertyName = "name";
            this.dgvCategoriesName.HeaderText = "Наименование";
            this.dgvCategoriesName.Name = "dgvCategoriesName";
            this.dgvCategoriesName.ReadOnly = true;
            this.dgvCategoriesName.Width = 400;
            // 
            // dgvUnitsId
            // 
            this.dgvUnitsId.DataPropertyName = "id";
            this.dgvUnitsId.HeaderText = "Код";
            this.dgvUnitsId.Name = "dgvUnitsId";
            this.dgvUnitsId.ReadOnly = true;
            // 
            // dgvUnitsName
            // 
            this.dgvUnitsName.DataPropertyName = "name";
            this.dgvUnitsName.HeaderText = "Наименование";
            this.dgvUnitsName.Name = "dgvUnitsName";
            this.dgvUnitsName.ReadOnly = true;
            this.dgvUnitsName.Width = 400;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 482);
            this.Controls.Add(this.tabControl1);
            this.Name = "mainForm";
            this.Text = "Мониторинг и планирование логистических затрат";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ctrSalesSumma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSales)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPayments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrSalesQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel1.PerformLayout();
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlans)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategories)).EndInit();
            this.tabPage6.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel1.PerformLayout();
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsUnits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPlans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrPlansSumma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrPlansYear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrPlansMonth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbReport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGo;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.BindingSource bsSales;
        private System.Windows.Forms.BindingSource bsProducts;
        private System.Windows.Forms.BindingSource bsCategories;
        private System.Windows.Forms.BindingSource bsUnits;
        private System.Windows.Forms.BindingSource bsPlans;
        private System.Windows.Forms.BindingSource bsRetails;
        private System.Windows.Forms.BindingSource bsPayments;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.DataGridView dgvPlans;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.DataGridView dgvCategories;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.DataGridView dgvUnits;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Label label4;
        private dbDataSet dbDataSet;
        private System.Windows.Forms.DateTimePicker ctrSalesDates;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ctrSalesProduct;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown ctrSalesQuantity;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox ctrSalesRetail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox ctrSalesPayment;
        private System.Windows.Forms.Button btnSalesNew;
        private System.Windows.Forms.Button btnSalesSave;
        private System.Windows.Forms.Button btnSalesCancel;
        private System.Windows.Forms.Button btnProductsNew;
        private System.Windows.Forms.Button btnProductsSave;
        private System.Windows.Forms.Button btnProductsCancel;
        private System.Windows.Forms.Button btnPlansNew;
        private System.Windows.Forms.Button btnPlansSave;
        private System.Windows.Forms.Button btnPlansCancel;
        private System.Windows.Forms.Button btnCategoriesNew;
        private System.Windows.Forms.Button btnCategoriesSave;
        private System.Windows.Forms.Button btnCategoriesCancel;
        private System.Windows.Forms.Button btnUnitsNew;
        private System.Windows.Forms.Button btnUnitsSave;
        private System.Windows.Forms.Button btnUnitsCancel;
        private System.Windows.Forms.NumericUpDown ctrSalesSumma;
        private System.Windows.Forms.Button btnSalesDelete;
        private System.Windows.Forms.TextBox ctrSalesId;
        private System.Windows.Forms.Button btnProductsDelete;
        private System.Windows.Forms.Button btnPlansDelete;
        private System.Windows.Forms.Button btnCategoriesDelete;
        private System.Windows.Forms.Button btnUnitsDelete;
        private System.Windows.Forms.TextBox ctrProductName;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox ctrProductUnit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox ctrProductCategory;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox ctrProductId;
        private System.Windows.Forms.NumericUpDown ctrPlansMonth;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown ctrPlansSumma;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown ctrPlansYear;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ctrCategoriesName;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox ctrCategoriesId;
        private System.Windows.Forms.TextBox ctrUnitsName;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox ctrUnitsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSalesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSalesDates;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvSalesProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSalesQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSalesSumma;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvProductsName;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvProductsCategory;
        private System.Windows.Forms.DataGridViewComboBoxColumn dgvProductsUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPlansYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPlansMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPlansSumma;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategoriesId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvCategoriesName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUnitsId;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUnitsName;

    }
}

