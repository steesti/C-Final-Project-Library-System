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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void booklistBt_Click(object sender, EventArgs e)
        {
            //Creates BookList Form
            BookList bookList = new BookList();
            bookList.ShowDialog();
        }

        private void employeeBt_Click(object sender, EventArgs e)
        {
            //Creates Employee Form
            Employee employee = new Employee();
            employee.ShowDialog();
        }

        private void memberBt_Click(object sender, EventArgs e)
        {
            //Creates Member Form
            Member member = new Member();
            member.ShowDialog();
        }

        private void transactionHistBt_Click(object sender, EventArgs e)
        {
            //Creates Transaction Form
            Transaction transaction = new Transaction();
            transaction.ShowDialog();
        }

        private void transactionCICOBt_Click(object sender, EventArgs e)
        {
            //Creates Check-in/Out Form
            Check_inCheck_outForm cico = new Check_inCheck_outForm();
            cico.ShowDialog();
        }
    }
}
