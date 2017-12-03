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
    public partial class TransactionDetail : Form
    {
        public TransactionDetail()
        {
            InitializeComponent();
        }

        private void TransactionDetail_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'transactionDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.transactionDataSet.Books);
            // TODO: This line of code loads data into the 'transactionDataSet.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.FillByInnerJoin(this.transactionDataSet.Transactions);

            //Sets height for the books data grid view
            booksDataGridView.Height = Convert.ToInt32(this.Height) - 250;
        }

        private void TransactionDetail_Resize(object sender, EventArgs e)
        {
            //Sets height for the books data grid view
            booksDataGridView.Height = Convert.ToInt32(this.Height) - 250;
        }
    }
}
