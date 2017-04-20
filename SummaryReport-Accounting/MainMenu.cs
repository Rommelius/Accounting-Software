using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using Word = Microsoft.Office.Interop.Word;
using System.Data;
using System.IO;
using System.Collections.Generic;
using System.Globalization;
using SummaryReport_Accounting.Properties;
using System.Drawing.Printing;

namespace SummaryReport_Accounting
{
    public partial class MainMenu : MetroForm
    {
        DateTime date = DateTime.Now;
        private List<ItemInfo> listItem = new List<ItemInfo>();
        //public static string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).Parent.Parent.FullName;
        public static string appRootDir = new DirectoryInfo(Environment.CurrentDirectory).FullName;

        List<string> listItemNames = new List<string>();
        public MainMenu()
        {
            InitializeComponent();
            _dateLabel.Text = date.ToLongDateString();

            loadItemNames();

        }

        private void loadItemNames()
        {
            using (StreamReader sr = new StreamReader(appRootDir + "/Item Names/ItemNames.csv"))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    listItemNames.Add(line);
                }

                foreach (string item in listItemNames)
                {
                    _itemList.Items.Add(item);
                }
            }

        }

        private void _addItemButton_Click(object sender, EventArgs e)
        {
            this.tableBindingSource.AddNew();


            //double _GSTAmount, _doubleItemAmount;
            //if (_itemAmount.Text == "" || _itemList.SelectedItem == null)
            //{
            //    MetroFramework.MetroMessageBox.Show(this, "", "Please fill in the details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
            //else
            //{
            //    if (_gstCheckbox.Checked)
            //    {
            //        double.TryParse(_itemAmount.Text, out _GSTAmount);
            //        _GSTAmount = (_GSTAmount / 100) * 10;
            //    }
            //    else
            //    {
            //        _GSTAmount = 0.00;
            //    }

            //    if (_itemAmount.Text == "")
            //    {
            //        _itemAmount.Text = "0.00";
            //    }
            //    double.TryParse(_itemAmount.Text, out _doubleItemAmount);

            //    ItemInfo item = new ItemInfo()
            //    {
            //        Item_Description = _itemList.Text,
            //        Amount = String.Format("{0:C}", _doubleItemAmount),
            //        GST = String.Format("{0:C}", _GSTAmount),
            //    };
            //    listItem.Add(item);


            //    //_dataGridView.DataSource = null;
            //    //_dataGridView.DataSource = listItem;

            //    //DataGridViewColumn column1 = _dataGridView.Columns[0];
            //    //column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //    //column1.HeaderText = "Item Description";


            //    //DataGridViewColumn column2 = _dataGridView.Columns[1];
            //    //column2.Width = 150;
            //    //DataGridViewColumn column3 = _dataGridView.Columns[2];
            //    //column3.Width = 150;

            //    _totalAmountExpenses.Text = String.Format("{0:C}", _dataGridView.Rows.Cast<DataGridViewRow>()
            //    .Sum(
            //        t => double.Parse(t.Cells[1].Value.ToString(), NumberStyles.Currency)

            //        ));

            //    _totalGST.Text = String.Format("{0:C}", _dataGridView.Rows.Cast<DataGridViewRow>()
            //    .Sum(
            //        t => double.Parse(t.Cells[2].Value.ToString(), NumberStyles.Currency)

            //        ));

            //    _totalAmountExpenseswithGST.Text = String.Format("{0:C}", _dataGridView.Rows.Cast<DataGridViewRow>()
            //    .Sum(
            //        t => double.Parse(t.Cells[1].Value.ToString(), NumberStyles.Currency) + double.Parse(t.Cells[2].Value.ToString(), NumberStyles.Currency)

            //        ));

            //    _itemList.SelectedItem = null;
            //    _itemAmount.Text = "";
            //    _gstCheckbox.Checked = false;
            //}
        }

        private void _deleteItemButton_Click(object sender, EventArgs e)
        {
            int index = _dataGridView.CurrentCell.RowIndex;

            listItem.RemoveAt(index);

            //_dataGridView.DataSource = null;
            //_dataGridView.DataSource = listItem;

            //DataGridViewColumn column1 = _dataGridView.Columns[0];
            //column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            //column1.HeaderText = "Item Description";


            //DataGridViewColumn column2 = _dataGridView.Columns[1];
            //column2.Width = 150;
            //DataGridViewColumn column3 = _dataGridView.Columns[2];
            //column3.Width = 150;

            _totalAmountExpenses.Text = String.Format("{0:C}", _dataGridView.Rows.Cast<DataGridViewRow>()
            .Sum(
                t => double.Parse(t.Cells[1].Value.ToString(), NumberStyles.Currency)

                ));

            _totalGST.Text = String.Format("{0:C}", _dataGridView.Rows.Cast<DataGridViewRow>()
            .Sum(
                t => double.Parse(t.Cells[2].Value.ToString(), NumberStyles.Currency)

                ));

            _totalAmountExpenseswithGST.Text = String.Format("{0:C}", _dataGridView.Rows.Cast<DataGridViewRow>()
            .Sum(
                t => double.Parse(t.Cells[1].Value.ToString(), NumberStyles.Currency) + double.Parse(t.Cells[2].Value.ToString(), NumberStyles.Currency)

                ));


        }

        private void _totalAmountExpenses_TextChanged(object sender, EventArgs e)
        {
            _eftposAmount.Enabled = true;
            _registerAmount.Enabled = true;
            _dailySubmit_btn.Enabled = true;
        }

        private void _totalIncome_TextChanged(object sender, EventArgs e)
        {
            double totalProfitGST;
            totalProfitGST = double.Parse(_totalIncome.Text, NumberStyles.Currency) - double.Parse(_totalAmountExpenseswithGST.Text, NumberStyles.Currency);
            _totalProfitGST.Text = String.Format("{0:C}", totalProfitGST);


            double totalProfit;
            totalProfit = double.Parse(_totalIncome.Text, NumberStyles.Currency) - double.Parse(_totalAmountExpenses.Text, NumberStyles.Currency);

            _totalProfit.Text = String.Format("{0:C}", totalProfit);

            _createReport.Enabled = true;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printDocument1.DefaultPageSettings.PaperSize = new System.Drawing.Printing.PaperSize("PaperA4", 840, 1180);

            e.Graphics.DrawString(date.ToLongDateString(), new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(30, 30));

            e.Graphics.DrawString("LAM'S DISCOUNT", new Font("Tw Cen MT Condensed", 45, FontStyle.Bold), Brushes.Red, new Point(225, 60));
            e.Graphics.DrawString("TOBACCONIST", new Font("Tw Cen MT Condensed", 45, FontStyle.Bold), Brushes.Red, new Point(252, 110));
            e.Graphics.DrawString("169 Melton Rd, Nundah QLD 4012", new Font("Tw Cen MT Condensed", 18, FontStyle.Bold), Brushes.Black, new Point(265, 170));
            e.Graphics.DrawString("(07) 3266 2824", new Font("Tw Cen MT Condensed", 18, FontStyle.Bold), Brushes.Black, new Point(350, 195));

            e.Graphics.DrawLine(Pens.Black, 20, 230, 810, 230);
            e.Graphics.DrawString("Items", new Font("Segoe UI", 14, FontStyle.Bold), Brushes.Black, new Point(30, 235));
            e.Graphics.DrawString("Amount", new Font("Segoe UI", 14, FontStyle.Bold), Brushes.Black, new Point(550, 235));
            e.Graphics.DrawString("GST", new Font("Segoe UI", 14, FontStyle.Bold), Brushes.Black, new Point(720, 235));
            e.Graphics.DrawLine(Pens.Black,20,265,810, 265);

            int yPos = 287;

            foreach (var i in listItem)
            {
                e.Graphics.DrawString(i.Item_Description, new Font("Segoe UI", 12, FontStyle.Regular), Brushes.Black, new Point(30, yPos));
                e.Graphics.DrawString(i.Amount.ToString(), new Font("Segoe UI", 12, FontStyle.Regular), Brushes.Black, new Point(550, yPos));
                e.Graphics.DrawString(i.GST.ToString(), new Font("Segoe UI", 12, FontStyle.Regular), Brushes.Black, new Point(720, yPos));

                yPos += 25;
            }

            e.Graphics.DrawLine(Pens.Black, 20, yPos+20, 810, yPos+20);
            e.Graphics.DrawString("Subtotal:     " + _totalAmountExpenses.Text, new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(550, yPos + 40));
            e.Graphics.DrawString("Total GST:     " + _totalGST.Text, new Font("Segoe UI", 14, FontStyle.Regular), Brushes.Black, new Point(541, yPos + 70));
            e.Graphics.DrawString("Total Amount of Expenses:     " + _totalAmountExpenseswithGST.Text, new Font("Segoe UI", 14, FontStyle.Bold), Brushes.Black, new Point(377, yPos + 100));


            e.Graphics.DrawString("Total Income:", new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Black, new Point(20, yPos + 140));
            e.Graphics.DrawString("Total Profit w/o GST:" , new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Black, new Point(20, yPos + 170));
            e.Graphics.DrawString("Total Profit w/ GST:", new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Black, new Point(20, yPos + 200));

            e.Graphics.DrawString(_totalIncome.Text, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Black, new Point(270, yPos + 140));
            e.Graphics.DrawString(_totalProfit.Text, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Black, new Point(270, yPos + 170));
            e.Graphics.DrawString(_totalProfitGST.Text, new Font("Segoe UI", 16, FontStyle.Bold), Brushes.Black, new Point(270, yPos + 200));
        }

        private void _previewReport_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void _dailySubmit_btn_Click(object sender, EventArgs e)
        {
            double totalIncome;
            totalIncome = double.Parse(_registerAmount.Text, NumberStyles.Currency) + double.Parse(_eftposAmount.Text, NumberStyles.Currency);

            _totalIncome.Text = String.Format("{0:C}", totalIncome);

            //prompt to print

            DialogResult result = MetroFramework.MetroMessageBox.Show(this, "", "Would you like to print the report?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {

               
                printDocument1.PrinterSettings.PrintFileName = "test123.pdf";
                printDocument1.Print();
            }

        }

        private void _createReport_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog1 = new PrintDialog();
            printDialog1.Document = printDocument1;
            printDocument1.DocumentName = date.Month.ToString() + date.Day.ToString();
            DialogResult result = printDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                printDocument1.Print();
            }



        }

        private void _addItemBtn_Click(object sender, EventArgs e)
        {
            AddItem frm = new AddItem();
            DialogResult result = frm.ShowDialog();
            if (result==DialogResult.Cancel)
            {
                _itemList.Items.Clear();
                listItemNames.Clear();
                loadItemNames();
            }
        }

        private void tableBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dailyDBDataSet);

        }

        private void tableBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.tableBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dailyDBDataSet);

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dailyDBDataSet.Table' table. You can move, or remove it, as needed.
            this.tableTableAdapter.Fill(this.dailyDBDataSet.Table);

        }
    }
}
