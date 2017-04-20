namespace SummaryReport_Accounting
{
    partial class MainMenu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Label item_DescriptionLabel;
            System.Windows.Forms.Label amountLabel;
            System.Windows.Forms.Label gSTLabel;
            this._mainPanel = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel4 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel7 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this._totalAmountExpenseswithGST = new MetroFramework.Controls.MetroLabel();
            this.metroPanel6 = new MetroFramework.Controls.MetroPanel();
            this._totalIncome = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this._labelTotalAmount = new MetroFramework.Controls.MetroLabel();
            this._totalAmountExpenses = new MetroFramework.Controls.MetroLabel();
            this._labelTotalGST = new MetroFramework.Controls.MetroLabel();
            this._totalGST = new MetroFramework.Controls.MetroLabel();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel5 = new MetroFramework.Controls.MetroPanel();
            this.metroPanel8 = new MetroFramework.Controls.MetroPanel();
            this._previewReport = new MetroFramework.Controls.MetroButton();
            this._createReport = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this._totalProfitGST = new MetroFramework.Controls.MetroLabel();
            this._dailySubmit_btn = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this._totalProfit = new MetroFramework.Controls.MetroLabel();
            this._eftposAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this._registerAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this._addItemButton = new MetroFramework.Controls.MetroButton();
            this._deleteItemButton = new MetroFramework.Controls.MetroButton();
            this._gstCheckbox = new MetroFramework.Controls.MetroCheckBox();
            this._itemAmount = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroPanel9 = new MetroFramework.Controls.MetroPanel();
            this._addItemBtn = new MetroFramework.Controls.MetroButton();
            this._itemList = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this._dateLabel = new MetroFramework.Controls.MetroLabel();
            this._bottomButtonsPanel = new MetroFramework.Controls.MetroPanel();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this._dataGridView = new MetroFramework.Controls.MetroGrid();
            this.dailyDBDataSet = new SummaryReport_Accounting.dailyDBDataSet();
            this.tableBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableTableAdapter = new SummaryReport_Accounting.dailyDBDataSetTableAdapters.TableTableAdapter();
            this.tableAdapterManager = new SummaryReport_Accounting.dailyDBDataSetTableAdapters.TableAdapterManager();
            this.itemDescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gSTDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.metroPanel10 = new MetroFramework.Controls.MetroPanel();
            this.item_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.gSTTextBox = new System.Windows.Forms.TextBox();
            item_DescriptionLabel = new System.Windows.Forms.Label();
            amountLabel = new System.Windows.Forms.Label();
            gSTLabel = new System.Windows.Forms.Label();
            this._mainPanel.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            this.metroPanel4.SuspendLayout();
            this.metroPanel7.SuspendLayout();
            this.metroPanel6.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.metroPanel5.SuspendLayout();
            this.metroPanel8.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.metroPanel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).BeginInit();
            this.metroPanel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // _mainPanel
            // 
            this._mainPanel.Controls.Add(this.metroPanel1);
            this._mainPanel.Controls.Add(this.metroPanel2);
            this._mainPanel.Controls.Add(this._bottomButtonsPanel);
            this._mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._mainPanel.HorizontalScrollbarBarColor = true;
            this._mainPanel.HorizontalScrollbarHighlightOnWheel = false;
            this._mainPanel.HorizontalScrollbarSize = 10;
            this._mainPanel.Location = new System.Drawing.Point(20, 60);
            this._mainPanel.Name = "_mainPanel";
            this._mainPanel.Size = new System.Drawing.Size(1859, 950);
            this._mainPanel.TabIndex = 0;
            this._mainPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._mainPanel.VerticalScrollbarBarColor = true;
            this._mainPanel.VerticalScrollbarHighlightOnWheel = false;
            this._mainPanel.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.Controls.Add(this._dataGridView);
            this.metroPanel1.Controls.Add(this.metroPanel4);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(453, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1406, 896);
            this.metroPanel1.TabIndex = 7;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroPanel4
            // 
            this.metroPanel4.Controls.Add(this.metroPanel7);
            this.metroPanel4.Controls.Add(this.metroPanel6);
            this.metroPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel4.HorizontalScrollbarBarColor = true;
            this.metroPanel4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel4.HorizontalScrollbarSize = 10;
            this.metroPanel4.Location = new System.Drawing.Point(0, 816);
            this.metroPanel4.Name = "metroPanel4";
            this.metroPanel4.Size = new System.Drawing.Size(1406, 80);
            this.metroPanel4.TabIndex = 3;
            this.metroPanel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel4.VerticalScrollbarBarColor = true;
            this.metroPanel4.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel4.VerticalScrollbarSize = 10;
            // 
            // metroPanel7
            // 
            this.metroPanel7.Controls.Add(this.metroLabel7);
            this.metroPanel7.Controls.Add(this._totalAmountExpenseswithGST);
            this.metroPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel7.HorizontalScrollbarBarColor = true;
            this.metroPanel7.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel7.HorizontalScrollbarSize = 10;
            this.metroPanel7.Location = new System.Drawing.Point(0, 40);
            this.metroPanel7.Name = "metroPanel7";
            this.metroPanel7.Size = new System.Drawing.Size(1406, 40);
            this.metroPanel7.TabIndex = 4;
            this.metroPanel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel7.VerticalScrollbarBarColor = true;
            this.metroPanel7.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel7.VerticalScrollbarSize = 10;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Dock = System.Windows.Forms.DockStyle.Right;
            this.metroLabel7.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel7.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel7.Location = new System.Drawing.Point(1037, 0);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(313, 25);
            this.metroLabel7.TabIndex = 19;
            this.metroLabel7.Text = "Total Amount of Expenses with GST:";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroLabel7.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _totalAmountExpenseswithGST
            // 
            this._totalAmountExpenseswithGST.AutoSize = true;
            this._totalAmountExpenseswithGST.Dock = System.Windows.Forms.DockStyle.Right;
            this._totalAmountExpenseswithGST.FontSize = MetroFramework.MetroLabelSize.Tall;
            this._totalAmountExpenseswithGST.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this._totalAmountExpenseswithGST.Location = new System.Drawing.Point(1350, 0);
            this._totalAmountExpenseswithGST.Name = "_totalAmountExpenseswithGST";
            this._totalAmountExpenseswithGST.Size = new System.Drawing.Size(56, 25);
            this._totalAmountExpenseswithGST.TabIndex = 18;
            this._totalAmountExpenseswithGST.Text = "$0.00";
            this._totalAmountExpenseswithGST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._totalAmountExpenseswithGST.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel6
            // 
            this.metroPanel6.Controls.Add(this._totalIncome);
            this.metroPanel6.Controls.Add(this.metroLabel5);
            this.metroPanel6.Controls.Add(this._labelTotalAmount);
            this.metroPanel6.Controls.Add(this._totalAmountExpenses);
            this.metroPanel6.Controls.Add(this._labelTotalGST);
            this.metroPanel6.Controls.Add(this._totalGST);
            this.metroPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel6.HorizontalScrollbarBarColor = true;
            this.metroPanel6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel6.HorizontalScrollbarSize = 10;
            this.metroPanel6.Location = new System.Drawing.Point(0, 0);
            this.metroPanel6.Name = "metroPanel6";
            this.metroPanel6.Size = new System.Drawing.Size(1406, 40);
            this.metroPanel6.TabIndex = 2;
            this.metroPanel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel6.VerticalScrollbarBarColor = true;
            this.metroPanel6.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel6.VerticalScrollbarSize = 10;
            // 
            // _totalIncome
            // 
            this._totalIncome.AutoSize = true;
            this._totalIncome.Dock = System.Windows.Forms.DockStyle.Left;
            this._totalIncome.FontSize = MetroFramework.MetroLabelSize.Tall;
            this._totalIncome.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this._totalIncome.Location = new System.Drawing.Point(125, 0);
            this._totalIncome.Name = "_totalIncome";
            this._totalIncome.Size = new System.Drawing.Size(56, 25);
            this._totalIncome.TabIndex = 18;
            this._totalIncome.Text = "$0.00";
            this._totalIncome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._totalIncome.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._totalIncome.TextChanged += new System.EventHandler(this._totalIncome_TextChanged);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroLabel5.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel5.Location = new System.Drawing.Point(0, 0);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(125, 25);
            this.metroLabel5.TabIndex = 19;
            this.metroLabel5.Text = "Total Income:";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _labelTotalAmount
            // 
            this._labelTotalAmount.AutoSize = true;
            this._labelTotalAmount.Dock = System.Windows.Forms.DockStyle.Right;
            this._labelTotalAmount.FontSize = MetroFramework.MetroLabelSize.Tall;
            this._labelTotalAmount.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this._labelTotalAmount.Location = new System.Drawing.Point(964, 0);
            this._labelTotalAmount.Name = "_labelTotalAmount";
            this._labelTotalAmount.Size = new System.Drawing.Size(234, 25);
            this._labelTotalAmount.TabIndex = 17;
            this._labelTotalAmount.Text = "Total Amount of Expenses:";
            this._labelTotalAmount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._labelTotalAmount.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _totalAmountExpenses
            // 
            this._totalAmountExpenses.AutoSize = true;
            this._totalAmountExpenses.Dock = System.Windows.Forms.DockStyle.Right;
            this._totalAmountExpenses.FontSize = MetroFramework.MetroLabelSize.Tall;
            this._totalAmountExpenses.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this._totalAmountExpenses.Location = new System.Drawing.Point(1198, 0);
            this._totalAmountExpenses.Name = "_totalAmountExpenses";
            this._totalAmountExpenses.Size = new System.Drawing.Size(56, 25);
            this._totalAmountExpenses.TabIndex = 16;
            this._totalAmountExpenses.Text = "$0.00";
            this._totalAmountExpenses.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._totalAmountExpenses.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._totalAmountExpenses.TextChanged += new System.EventHandler(this._totalAmountExpenses_TextChanged);
            // 
            // _labelTotalGST
            // 
            this._labelTotalGST.AutoSize = true;
            this._labelTotalGST.Dock = System.Windows.Forms.DockStyle.Right;
            this._labelTotalGST.FontSize = MetroFramework.MetroLabelSize.Tall;
            this._labelTotalGST.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this._labelTotalGST.Location = new System.Drawing.Point(1254, 0);
            this._labelTotalGST.Name = "_labelTotalGST";
            this._labelTotalGST.Size = new System.Drawing.Size(96, 25);
            this._labelTotalGST.TabIndex = 21;
            this._labelTotalGST.Text = "Total GST:";
            this._labelTotalGST.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this._labelTotalGST.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _totalGST
            // 
            this._totalGST.AutoSize = true;
            this._totalGST.Dock = System.Windows.Forms.DockStyle.Right;
            this._totalGST.FontSize = MetroFramework.MetroLabelSize.Tall;
            this._totalGST.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this._totalGST.Location = new System.Drawing.Point(1350, 0);
            this._totalGST.Name = "_totalGST";
            this._totalGST.Size = new System.Drawing.Size(56, 25);
            this._totalGST.TabIndex = 20;
            this._totalGST.Text = "$0.00";
            this._totalGST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._totalGST.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel2
            // 
            this.metroPanel2.Controls.Add(this.metroPanel5);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(453, 896);
            this.metroPanel2.TabIndex = 6;
            this.metroPanel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroPanel5
            // 
            this.metroPanel5.AutoSize = true;
            this.metroPanel5.Controls.Add(this.metroPanel10);
            this.metroPanel5.Controls.Add(this.metroPanel8);
            this.metroPanel5.Controls.Add(this.metroLabel6);
            this.metroPanel5.Controls.Add(this._totalProfitGST);
            this.metroPanel5.Controls.Add(this._dailySubmit_btn);
            this.metroPanel5.Controls.Add(this.metroLabel9);
            this.metroPanel5.Controls.Add(this._totalProfit);
            this.metroPanel5.Controls.Add(this._eftposAmount);
            this.metroPanel5.Controls.Add(this.metroLabel2);
            this.metroPanel5.Controls.Add(this._registerAmount);
            this.metroPanel5.Controls.Add(this.metroLabel1);
            this.metroPanel5.Controls.Add(this.metroPanel3);
            this.metroPanel5.Controls.Add(this._gstCheckbox);
            this.metroPanel5.Controls.Add(this._itemAmount);
            this.metroPanel5.Controls.Add(this.metroLabel4);
            this.metroPanel5.Controls.Add(this.metroPanel9);
            this.metroPanel5.Controls.Add(this.metroLabel3);
            this.metroPanel5.Controls.Add(this._dateLabel);
            this.metroPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel5.HorizontalScrollbarBarColor = true;
            this.metroPanel5.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel5.HorizontalScrollbarSize = 10;
            this.metroPanel5.Location = new System.Drawing.Point(0, 0);
            this.metroPanel5.Name = "metroPanel5";
            this.metroPanel5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 10);
            this.metroPanel5.Size = new System.Drawing.Size(453, 896);
            this.metroPanel5.TabIndex = 3;
            this.metroPanel5.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel5.VerticalScrollbarBarColor = true;
            this.metroPanel5.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel5.VerticalScrollbarSize = 10;
            // 
            // metroPanel8
            // 
            this.metroPanel8.Controls.Add(this._previewReport);
            this.metroPanel8.Controls.Add(this._createReport);
            this.metroPanel8.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel8.HorizontalScrollbarBarColor = true;
            this.metroPanel8.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel8.HorizontalScrollbarSize = 10;
            this.metroPanel8.Location = new System.Drawing.Point(10, 655);
            this.metroPanel8.Name = "metroPanel8";
            this.metroPanel8.Size = new System.Drawing.Size(433, 71);
            this.metroPanel8.TabIndex = 25;
            this.metroPanel8.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel8.VerticalScrollbarBarColor = true;
            this.metroPanel8.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel8.VerticalScrollbarSize = 10;
            // 
            // _previewReport
            // 
            this._previewReport.Dock = System.Windows.Forms.DockStyle.Left;
            this._previewReport.FontSize = MetroFramework.MetroButtonSize.Medium;
            this._previewReport.Location = new System.Drawing.Point(0, 0);
            this._previewReport.Name = "_previewReport";
            this._previewReport.Size = new System.Drawing.Size(216, 71);
            this._previewReport.Style = MetroFramework.MetroColorStyle.Green;
            this._previewReport.TabIndex = 24;
            this._previewReport.Text = "Preview Report";
            this._previewReport.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._previewReport.UseSelectable = true;
            this._previewReport.Click += new System.EventHandler(this._previewReport_Click);
            // 
            // _createReport
            // 
            this._createReport.Dock = System.Windows.Forms.DockStyle.Right;
            this._createReport.Enabled = false;
            this._createReport.Location = new System.Drawing.Point(216, 0);
            this._createReport.Name = "_createReport";
            this._createReport.Size = new System.Drawing.Size(217, 71);
            this._createReport.Style = MetroFramework.MetroColorStyle.Green;
            this._createReport.TabIndex = 23;
            this._createReport.Text = "Create Report";
            this._createReport.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._createReport.UseSelectable = true;
            this._createReport.Click += new System.EventHandler(this._createReport_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroLabel6.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel6.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel6.Location = new System.Drawing.Point(10, 726);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(433, 40);
            this.metroLabel6.TabIndex = 24;
            this.metroLabel6.Text = "Total Profit including GST:";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel6.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _totalProfitGST
            // 
            this._totalProfitGST.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._totalProfitGST.FontSize = MetroFramework.MetroLabelSize.Tall;
            this._totalProfitGST.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this._totalProfitGST.Location = new System.Drawing.Point(10, 766);
            this._totalProfitGST.Name = "_totalProfitGST";
            this._totalProfitGST.Size = new System.Drawing.Size(433, 40);
            this._totalProfitGST.TabIndex = 23;
            this._totalProfitGST.Text = "$0.00";
            this._totalProfitGST.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._totalProfitGST.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _dailySubmit_btn
            // 
            this._dailySubmit_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this._dailySubmit_btn.Enabled = false;
            this._dailySubmit_btn.Location = new System.Drawing.Point(10, 447);
            this._dailySubmit_btn.Name = "_dailySubmit_btn";
            this._dailySubmit_btn.Size = new System.Drawing.Size(433, 54);
            this._dailySubmit_btn.Style = MetroFramework.MetroColorStyle.Green;
            this._dailySubmit_btn.TabIndex = 21;
            this._dailySubmit_btn.Text = "Submit";
            this._dailySubmit_btn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._dailySubmit_btn.UseSelectable = true;
            this._dailySubmit_btn.Click += new System.EventHandler(this._dailySubmit_btn_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroLabel9.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel9.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel9.Location = new System.Drawing.Point(10, 806);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(433, 40);
            this.metroLabel9.TabIndex = 20;
            this.metroLabel9.Text = "Total Profit excluding GST:";
            this.metroLabel9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _totalProfit
            // 
            this._totalProfit.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._totalProfit.FontSize = MetroFramework.MetroLabelSize.Tall;
            this._totalProfit.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this._totalProfit.Location = new System.Drawing.Point(10, 846);
            this._totalProfit.Name = "_totalProfit";
            this._totalProfit.Size = new System.Drawing.Size(433, 40);
            this._totalProfit.TabIndex = 19;
            this._totalProfit.Text = "$0.00";
            this._totalProfit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this._totalProfit.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _eftposAmount
            // 
            // 
            // 
            // 
            this._eftposAmount.CustomButton.Image = null;
            this._eftposAmount.CustomButton.Location = new System.Drawing.Point(405, 2);
            this._eftposAmount.CustomButton.Name = "";
            this._eftposAmount.CustomButton.Size = new System.Drawing.Size(25, 25);
            this._eftposAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._eftposAmount.CustomButton.TabIndex = 1;
            this._eftposAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._eftposAmount.CustomButton.UseSelectable = true;
            this._eftposAmount.CustomButton.Visible = false;
            this._eftposAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this._eftposAmount.Enabled = false;
            this._eftposAmount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this._eftposAmount.Lines = new string[0];
            this._eftposAmount.Location = new System.Drawing.Point(10, 417);
            this._eftposAmount.MaxLength = 32767;
            this._eftposAmount.Name = "_eftposAmount";
            this._eftposAmount.PasswordChar = '\0';
            this._eftposAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._eftposAmount.SelectedText = "";
            this._eftposAmount.SelectionLength = 0;
            this._eftposAmount.SelectionStart = 0;
            this._eftposAmount.ShortcutsEnabled = true;
            this._eftposAmount.Size = new System.Drawing.Size(433, 30);
            this._eftposAmount.TabIndex = 16;
            this._eftposAmount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._eftposAmount.UseSelectable = true;
            this._eftposAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._eftposAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel2.Location = new System.Drawing.Point(10, 377);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(433, 40);
            this.metroLabel2.TabIndex = 14;
            this.metroLabel2.Text = "EFTPOS Amount:";
            this.metroLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel2.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _registerAmount
            // 
            // 
            // 
            // 
            this._registerAmount.CustomButton.Image = null;
            this._registerAmount.CustomButton.Location = new System.Drawing.Point(405, 2);
            this._registerAmount.CustomButton.Name = "";
            this._registerAmount.CustomButton.Size = new System.Drawing.Size(25, 25);
            this._registerAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._registerAmount.CustomButton.TabIndex = 1;
            this._registerAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._registerAmount.CustomButton.UseSelectable = true;
            this._registerAmount.CustomButton.Visible = false;
            this._registerAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this._registerAmount.Enabled = false;
            this._registerAmount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this._registerAmount.Lines = new string[0];
            this._registerAmount.Location = new System.Drawing.Point(10, 347);
            this._registerAmount.MaxLength = 32767;
            this._registerAmount.Name = "_registerAmount";
            this._registerAmount.PasswordChar = '\0';
            this._registerAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._registerAmount.SelectedText = "";
            this._registerAmount.SelectionLength = 0;
            this._registerAmount.SelectionStart = 0;
            this._registerAmount.ShortcutsEnabled = true;
            this._registerAmount.Size = new System.Drawing.Size(433, 30);
            this._registerAmount.TabIndex = 17;
            this._registerAmount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._registerAmount.UseSelectable = true;
            this._registerAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._registerAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel1
            // 
            this.metroLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.Location = new System.Drawing.Point(10, 307);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(433, 40);
            this.metroLabel1.TabIndex = 15;
            this.metroLabel1.Text = "Register Amount:";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel3
            // 
            this.metroPanel3.Controls.Add(this._addItemButton);
            this.metroPanel3.Controls.Add(this._deleteItemButton);
            this.metroPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(10, 253);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(433, 54);
            this.metroPanel3.TabIndex = 18;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            // 
            // _addItemButton
            // 
            this._addItemButton.Dock = System.Windows.Forms.DockStyle.Left;
            this._addItemButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this._addItemButton.Location = new System.Drawing.Point(0, 0);
            this._addItemButton.Name = "_addItemButton";
            this._addItemButton.Size = new System.Drawing.Size(216, 54);
            this._addItemButton.Style = MetroFramework.MetroColorStyle.Green;
            this._addItemButton.TabIndex = 15;
            this._addItemButton.Text = "ADD";
            this._addItemButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._addItemButton.UseSelectable = true;
            this._addItemButton.Click += new System.EventHandler(this._addItemButton_Click);
            // 
            // _deleteItemButton
            // 
            this._deleteItemButton.Dock = System.Windows.Forms.DockStyle.Right;
            this._deleteItemButton.FontSize = MetroFramework.MetroButtonSize.Medium;
            this._deleteItemButton.Location = new System.Drawing.Point(216, 0);
            this._deleteItemButton.Name = "_deleteItemButton";
            this._deleteItemButton.Size = new System.Drawing.Size(217, 54);
            this._deleteItemButton.Style = MetroFramework.MetroColorStyle.Green;
            this._deleteItemButton.TabIndex = 14;
            this._deleteItemButton.Text = "DELETE";
            this._deleteItemButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._deleteItemButton.UseSelectable = true;
            this._deleteItemButton.Click += new System.EventHandler(this._deleteItemButton_Click);
            // 
            // _gstCheckbox
            // 
            this._gstCheckbox.Dock = System.Windows.Forms.DockStyle.Top;
            this._gstCheckbox.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this._gstCheckbox.Location = new System.Drawing.Point(10, 210);
            this._gstCheckbox.Name = "_gstCheckbox";
            this._gstCheckbox.Size = new System.Drawing.Size(433, 43);
            this._gstCheckbox.Style = MetroFramework.MetroColorStyle.Green;
            this._gstCheckbox.TabIndex = 10;
            this._gstCheckbox.Text = "GST";
            this._gstCheckbox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._gstCheckbox.UseSelectable = true;
            // 
            // _itemAmount
            // 
            // 
            // 
            // 
            this._itemAmount.CustomButton.Image = null;
            this._itemAmount.CustomButton.Location = new System.Drawing.Point(405, 2);
            this._itemAmount.CustomButton.Name = "";
            this._itemAmount.CustomButton.Size = new System.Drawing.Size(25, 25);
            this._itemAmount.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this._itemAmount.CustomButton.TabIndex = 1;
            this._itemAmount.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this._itemAmount.CustomButton.UseSelectable = true;
            this._itemAmount.CustomButton.Visible = false;
            this._itemAmount.Dock = System.Windows.Forms.DockStyle.Top;
            this._itemAmount.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this._itemAmount.Lines = new string[0];
            this._itemAmount.Location = new System.Drawing.Point(10, 180);
            this._itemAmount.MaxLength = 32767;
            this._itemAmount.Name = "_itemAmount";
            this._itemAmount.PasswordChar = '\0';
            this._itemAmount.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this._itemAmount.SelectedText = "";
            this._itemAmount.SelectionLength = 0;
            this._itemAmount.SelectionStart = 0;
            this._itemAmount.ShortcutsEnabled = true;
            this._itemAmount.Size = new System.Drawing.Size(433, 30);
            this._itemAmount.TabIndex = 12;
            this._itemAmount.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._itemAmount.UseSelectable = true;
            this._itemAmount.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this._itemAmount.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel4
            // 
            this.metroLabel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel4.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel4.Location = new System.Drawing.Point(10, 140);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(433, 40);
            this.metroLabel4.TabIndex = 8;
            this.metroLabel4.Text = "Amount:";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel4.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroPanel9
            // 
            this.metroPanel9.Controls.Add(this._addItemBtn);
            this.metroPanel9.Controls.Add(this._itemList);
            this.metroPanel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroPanel9.HorizontalScrollbarBarColor = true;
            this.metroPanel9.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel9.HorizontalScrollbarSize = 10;
            this.metroPanel9.Location = new System.Drawing.Point(10, 110);
            this.metroPanel9.Name = "metroPanel9";
            this.metroPanel9.Size = new System.Drawing.Size(433, 30);
            this.metroPanel9.TabIndex = 26;
            this.metroPanel9.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel9.VerticalScrollbarBarColor = true;
            this.metroPanel9.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel9.VerticalScrollbarSize = 10;
            // 
            // _addItemBtn
            // 
            this._addItemBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this._addItemBtn.Location = new System.Drawing.Point(330, 0);
            this._addItemBtn.Name = "_addItemBtn";
            this._addItemBtn.Size = new System.Drawing.Size(103, 30);
            this._addItemBtn.TabIndex = 9;
            this._addItemBtn.Text = "Add Item";
            this._addItemBtn.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._addItemBtn.UseSelectable = true;
            this._addItemBtn.Click += new System.EventHandler(this._addItemBtn_Click);
            // 
            // _itemList
            // 
            this._itemList.Dock = System.Windows.Forms.DockStyle.Left;
            this._itemList.FormattingEnabled = true;
            this._itemList.ItemHeight = 24;
            this._itemList.Location = new System.Drawing.Point(0, 0);
            this._itemList.Name = "_itemList";
            this._itemList.Size = new System.Drawing.Size(330, 30);
            this._itemList.TabIndex = 8;
            this._itemList.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._itemList.UseSelectable = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.metroLabel3.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(10, 70);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(433, 40);
            this.metroLabel3.TabIndex = 6;
            this.metroLabel3.Text = "Item:";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLabel3.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _dateLabel
            // 
            this._dateLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this._dateLabel.FontSize = MetroFramework.MetroLabelSize.Tall;
            this._dateLabel.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this._dateLabel.Location = new System.Drawing.Point(10, 0);
            this._dateLabel.Name = "_dateLabel";
            this._dateLabel.Size = new System.Drawing.Size(433, 70);
            this._dateLabel.TabIndex = 5;
            this._dateLabel.Text = "DATE";
            this._dateLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // _bottomButtonsPanel
            // 
            this._bottomButtonsPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._bottomButtonsPanel.HorizontalScrollbarBarColor = true;
            this._bottomButtonsPanel.HorizontalScrollbarHighlightOnWheel = false;
            this._bottomButtonsPanel.HorizontalScrollbarSize = 10;
            this._bottomButtonsPanel.Location = new System.Drawing.Point(0, 896);
            this._bottomButtonsPanel.Name = "_bottomButtonsPanel";
            this._bottomButtonsPanel.Size = new System.Drawing.Size(1859, 54);
            this._bottomButtonsPanel.TabIndex = 3;
            this._bottomButtonsPanel.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._bottomButtonsPanel.VerticalScrollbarBarColor = true;
            this._bottomButtonsPanel.VerticalScrollbarHighlightOnWheel = false;
            this._bottomButtonsPanel.VerticalScrollbarSize = 10;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToDeleteRows = false;
            this._dataGridView.AllowUserToResizeRows = false;
            this._dataGridView.AutoGenerateColumns = false;
            this._dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this._dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._dataGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.itemDescriptionDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.gSTDataGridViewTextBoxColumn});
            this._dataGridView.DataSource = this.tableBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this._dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this._dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGridView.EnableHeadersVisualStyles = false;
            this._dataGridView.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this._dataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            this._dataGridView.Location = new System.Drawing.Point(0, 0);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.ReadOnly = true;
            this._dataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(198)))), ((int)(((byte)(247)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this._dataGridView.RowHeadersVisible = false;
            this._dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            this._dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this._dataGridView.RowTemplate.Height = 24;
            this._dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._dataGridView.Size = new System.Drawing.Size(1406, 816);
            this._dataGridView.Style = MetroFramework.MetroColorStyle.Blue;
            this._dataGridView.TabIndex = 4;
            this._dataGridView.Theme = MetroFramework.MetroThemeStyle.Dark;
            this._dataGridView.UseCustomBackColor = true;
            this._dataGridView.UseCustomForeColor = true;
            // 
            // dailyDBDataSet
            // 
            this.dailyDBDataSet.DataSetName = "dailyDBDataSet";
            this.dailyDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableBindingSource
            // 
            this.tableBindingSource.DataMember = "Table";
            this.tableBindingSource.DataSource = this.dailyDBDataSet;
            // 
            // tableTableAdapter
            // 
            this.tableTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.TableTableAdapter = this.tableTableAdapter;
            this.tableAdapterManager.UpdateOrder = SummaryReport_Accounting.dailyDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // itemDescriptionDataGridViewTextBoxColumn
            // 
            this.itemDescriptionDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.itemDescriptionDataGridViewTextBoxColumn.DataPropertyName = "Item Description";
            this.itemDescriptionDataGridViewTextBoxColumn.HeaderText = "Item Description";
            this.itemDescriptionDataGridViewTextBoxColumn.Name = "itemDescriptionDataGridViewTextBoxColumn";
            this.itemDescriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            this.amountDataGridViewTextBoxColumn.ReadOnly = true;
            this.amountDataGridViewTextBoxColumn.Width = 150;
            // 
            // gSTDataGridViewTextBoxColumn
            // 
            this.gSTDataGridViewTextBoxColumn.DataPropertyName = "GST";
            this.gSTDataGridViewTextBoxColumn.HeaderText = "GST";
            this.gSTDataGridViewTextBoxColumn.Name = "gSTDataGridViewTextBoxColumn";
            this.gSTDataGridViewTextBoxColumn.ReadOnly = true;
            this.gSTDataGridViewTextBoxColumn.Width = 150;
            // 
            // metroPanel10
            // 
            this.metroPanel10.AutoScroll = true;
            this.metroPanel10.Controls.Add(item_DescriptionLabel);
            this.metroPanel10.Controls.Add(this.item_DescriptionTextBox);
            this.metroPanel10.Controls.Add(amountLabel);
            this.metroPanel10.Controls.Add(this.amountTextBox);
            this.metroPanel10.Controls.Add(gSTLabel);
            this.metroPanel10.Controls.Add(this.gSTTextBox);
            this.metroPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel10.HorizontalScrollbar = true;
            this.metroPanel10.HorizontalScrollbarBarColor = true;
            this.metroPanel10.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel10.HorizontalScrollbarSize = 10;
            this.metroPanel10.Location = new System.Drawing.Point(10, 501);
            this.metroPanel10.Name = "metroPanel10";
            this.metroPanel10.Size = new System.Drawing.Size(433, 154);
            this.metroPanel10.TabIndex = 27;
            this.metroPanel10.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.metroPanel10.VerticalScrollbar = true;
            this.metroPanel10.VerticalScrollbarBarColor = true;
            this.metroPanel10.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel10.VerticalScrollbarSize = 10;
            // 
            // item_DescriptionLabel
            // 
            item_DescriptionLabel.AutoSize = true;
            item_DescriptionLabel.ForeColor = System.Drawing.Color.Transparent;
            item_DescriptionLabel.Location = new System.Drawing.Point(82, 26);
            item_DescriptionLabel.Name = "item_DescriptionLabel";
            item_DescriptionLabel.Size = new System.Drawing.Size(113, 17);
            item_DescriptionLabel.TabIndex = 2;
            item_DescriptionLabel.Text = "Item Description:";
            // 
            // item_DescriptionTextBox
            // 
            this.item_DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Item Description", true));
            this.item_DescriptionTextBox.Location = new System.Drawing.Point(201, 23);
            this.item_DescriptionTextBox.Name = "item_DescriptionTextBox";
            this.item_DescriptionTextBox.Size = new System.Drawing.Size(100, 22);
            this.item_DescriptionTextBox.TabIndex = 3;
            // 
            // amountLabel
            // 
            amountLabel.AutoSize = true;
            amountLabel.ForeColor = System.Drawing.Color.Transparent;
            amountLabel.Location = new System.Drawing.Point(82, 54);
            amountLabel.Name = "amountLabel";
            amountLabel.Size = new System.Drawing.Size(60, 17);
            amountLabel.TabIndex = 4;
            amountLabel.Text = "Amount:";
            // 
            // amountTextBox
            // 
            this.amountTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "Amount", true));
            this.amountTextBox.Location = new System.Drawing.Point(201, 51);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 22);
            this.amountTextBox.TabIndex = 5;
            // 
            // gSTLabel
            // 
            gSTLabel.AutoSize = true;
            gSTLabel.ForeColor = System.Drawing.Color.Transparent;
            gSTLabel.Location = new System.Drawing.Point(82, 82);
            gSTLabel.Name = "gSTLabel";
            gSTLabel.Size = new System.Drawing.Size(41, 17);
            gSTLabel.TabIndex = 6;
            gSTLabel.Text = "GST:";
            // 
            // gSTTextBox
            // 
            this.gSTTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tableBindingSource, "GST", true));
            this.gSTTextBox.Location = new System.Drawing.Point(201, 79);
            this.gSTTextBox.Name = "gSTTextBox";
            this.gSTTextBox.Size = new System.Drawing.Size(100, 22);
            this.gSTTextBox.TabIndex = 7;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1899, 1030);
            this.Controls.Add(this._mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainMenu";
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this._mainPanel.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel4.ResumeLayout(false);
            this.metroPanel7.ResumeLayout(false);
            this.metroPanel7.PerformLayout();
            this.metroPanel6.ResumeLayout(false);
            this.metroPanel6.PerformLayout();
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.metroPanel5.ResumeLayout(false);
            this.metroPanel8.ResumeLayout(false);
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dailyDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tableBindingSource)).EndInit();
            this.metroPanel10.ResumeLayout(false);
            this.metroPanel10.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel _mainPanel;
        private MetroFramework.Controls.MetroPanel _bottomButtonsPanel;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroPanel metroPanel4;
        private MetroFramework.Controls.MetroPanel metroPanel5;
        private MetroFramework.Controls.MetroLabel _dateLabel;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroCheckBox _gstCheckbox;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox _itemAmount;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroTextBox _eftposAmount;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox _registerAmount;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroButton _addItemButton;
        private MetroFramework.Controls.MetroButton _deleteItemButton;
        private MetroFramework.Controls.MetroPanel metroPanel7;
        private MetroFramework.Controls.MetroPanel metroPanel6;
        private MetroFramework.Controls.MetroLabel _totalIncome;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel _labelTotalAmount;
        private MetroFramework.Controls.MetroLabel _totalAmountExpenses;
        private MetroFramework.Controls.MetroLabel metroLabel9;
        private MetroFramework.Controls.MetroLabel _totalProfit;
        private MetroFramework.Controls.MetroButton _dailySubmit_btn;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel _totalProfitGST;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroLabel _totalAmountExpenseswithGST;
        private MetroFramework.Controls.MetroLabel _labelTotalGST;
        private MetroFramework.Controls.MetroLabel _totalGST;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private MetroFramework.Controls.MetroPanel metroPanel8;
        private MetroFramework.Controls.MetroButton _previewReport;
        private MetroFramework.Controls.MetroButton _createReport;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private MetroFramework.Controls.MetroPanel metroPanel9;
        private MetroFramework.Controls.MetroButton _addItemBtn;
        private MetroFramework.Controls.MetroComboBox _itemList;
        private MetroFramework.Controls.MetroGrid _dataGridView;
        private dailyDBDataSet dailyDBDataSet;
        private System.Windows.Forms.BindingSource tableBindingSource;
        private dailyDBDataSetTableAdapters.TableTableAdapter tableTableAdapter;
        private dailyDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemDescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gSTDataGridViewTextBoxColumn;
        private MetroFramework.Controls.MetroPanel metroPanel10;
        private System.Windows.Forms.TextBox item_DescriptionTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox gSTTextBox;
    }
}

