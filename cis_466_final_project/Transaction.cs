using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CIS_466_Final_Project
{
    public partial class Transaction : Form
    {
        public Transaction()
        {
            InitializeComponent();
        }

        private void Transaction_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transactionDataSet.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.FillByInnerJoin(this.transactionDataSet.Transactions);

            //Sets height for the data grid view
            transactionsDataGridView.Height = Convert.ToInt32(this.Height) - 130;
        }

        private void Transaction_Resize(object sender, EventArgs e)
        {
            //Sets height for the data grid view
            transactionsDataGridView.Height = Convert.ToInt32(this.Height) - 130;
        }

        private void viewDetailsButton_Click(object sender, EventArgs e)
        {
            //Create transaction detail from
            TransactionDetail transactionDetail = new TransactionDetail();
            transactionDetail.ShowDialog();
        }
    }
}
