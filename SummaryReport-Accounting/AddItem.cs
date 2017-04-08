using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.IO;

namespace SummaryReport_Accounting
{
    public partial class AddItem : MetroForm
    {


        public AddItem()
        {
            InitializeComponent();
        }

        private void _addButton_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText(MainMenu.appRootDir + "/Item Names/ItemNames.csv"))
            {

                if (_itemName.Text != null)
                {
                    sw.Write(Environment.NewLine + _itemName.Text);
                }

            }
            this.Close();
        }

        private void _cancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
