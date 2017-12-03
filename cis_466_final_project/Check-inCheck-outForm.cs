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
    public partial class Check_inCheck_outForm : Form
    {
        public Check_inCheck_outForm()
        {
            InitializeComponent();
        }

        /*
         * FOCUS LEAVE EVENTS
         */

        //Checks if the ISBN exists after the user leaves the ISBN textbox
        private void isbnTextbox_Leave(object sender, EventArgs e)
        {
            //Declare variables
            int isbn = 0;
            isbn = SetISBN(isbnTextbox);

            //Create table adapters needed to verify if ISBN exists
            LibraryDataSetTableAdapters.BooksTableAdapter booksTableAdapter1;
            booksTableAdapter1 = new LibraryDataSetTableAdapters.BooksTableAdapter();

            //Determines if the ISBN exists
            if (isbn != 0)
            {
                if (booksTableAdapter1.ExistingISBN(isbn) == isbn)
                {
                }
                else
                {
                    MessageBox.Show("Please enter an existing ISBN.");
                    isbnTextbox.Focus();
                }
            }
        }

        //Checks if the EmployeeID exists after the user leaves the EmployeeID textbox
        private void employeeIDTextbox_Leave(object sender, EventArgs e)
        {
            //Declare variables
            int empID = 0;
            empID = SetEmployeeID(employeeIDTextbox);

            //Create table adapters needed to verify if EmployeeID exists
            LibraryDataSetTableAdapters.EmployeesTableAdapter employeeTableAdapter1;
            employeeTableAdapter1 = new LibraryDataSetTableAdapters.EmployeesTableAdapter();

            //Determines if the EmployeeID exists
            if (empID != 0)
            {
                if (employeeTableAdapter1.AvailabilityEmployee(empID) == empID)
                {
                }
                else
                {
                    MessageBox.Show("Please enter an existing employee ID.");
                    employeeIDTextbox.Focus();
                }
            }
        }

        //Checks if the MemberID exists after the user leaves the MemberID textbox
        private void memberIDTextbox_Leave(object sender, EventArgs e)
        {
            //Declare variables
            int memID = 0;
            memID = SetMemberID(memberIDTextbox);

            //Create table adapters needed to verify if MemberID exists
            LibraryDataSetTableAdapters.MembersTableAdapter membersTableAdapter1;
            membersTableAdapter1 = new LibraryDataSetTableAdapters.MembersTableAdapter();

            //Determines if the MemberID exists
            if (memID != 0)
            {
                if (membersTableAdapter1.AvailibilityMember(memID) == memID)
                {
                }
                else
                {
                    MessageBox.Show("Please enter an existing member ID.");
                    memberIDTextbox.Focus();
                }
            }
        }

        /*
         * BUTTON CLICK METHODS
         */

        private void checkInButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare variables
                int isbn = 0, empID = 0, memID = 0;

                //Set int values
                isbn = SetISBN(isbnTextbox);

                if (isbn != 0)
                {
                    empID = SetEmployeeID(employeeIDTextbox);

                    if (empID != 0)
                    {
                        memID = SetMemberID(memberIDTextbox);
                    }
                }

                //Create table adapters for data validation
                LibraryDataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter1;
                transactionsTableAdapter1 = new LibraryDataSetTableAdapters.TransactionsTableAdapter();

                LibraryDataSetTableAdapters.BooksTableAdapter booksTableAdapter1;
                booksTableAdapter1 = new LibraryDataSetTableAdapters.BooksTableAdapter();

                //If the book is not checked out it will ask for a book that is and vice versa
                if (booksTableAdapter1.AvailabilityISBN(isbn) == false)
                {
                    MessageBox.Show("Your book has been returned." + "\n" +
                        "Thank You.");
                    transactionsTableAdapter1.InsertQuery(isbn, empID, memID);
                    booksTableAdapter1.UpdateQueryCheckIn(isbn, isbn);
                }
                else
                {
                    MessageBox.Show("Please enter a valid checked out ISBN.");
                }
            }
            //Catches incorrectly formated input
            catch (FormatException)
            {
                MessageBox.Show("A format exception has occured.", "Entry error.");
            }
            //Catches overflow values
            catch (OverflowException)
            {
                MessageBox.Show("An overflow exception has occured.", "Entry error.");
            }
            //Catches all other exceptions
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }

        private void checkOutButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare variables
                int isbn = 0, empID = 0, memID = 0;

                //Set int values
                isbn = SetISBN(isbnTextbox);

                if (isbn != 0)
                {
                    empID = SetEmployeeID(employeeIDTextbox);

                    if (empID != 0)
                    {
                        memID = SetMemberID(memberIDTextbox);
                    }
                }
                
                //Create table adapters for data validation
                LibraryDataSetTableAdapters.TransactionsTableAdapter transactionsTableAdapter1;
                transactionsTableAdapter1 = new LibraryDataSetTableAdapters.TransactionsTableAdapter();

                LibraryDataSetTableAdapters.BooksTableAdapter booksTableAdapter1;
                booksTableAdapter1 = new LibraryDataSetTableAdapters.BooksTableAdapter();

                //If the book is checked out it will ask for a book that is not and vice versa
                if (booksTableAdapter1.AvailabilityISBN(isbn) == true)
                {
                    MessageBox.Show("Please bring your book back within three weeks." + "\n" +
                        "Thank You.");
                    transactionsTableAdapter1.InsertQuery(isbn, empID, memID);
                    booksTableAdapter1.UpdateQueryCheckOut(isbn, isbn);
                }
                else
                {
                    MessageBox.Show("Please enter a valid checked in ISBN.");
                }
            }
            //Catches incorrectly formated input
            catch (FormatException)
            {
                MessageBox.Show("A format exception has occured.", "Entry error.");
            }
            //Catches overflow values
            catch (OverflowException)
            {
                MessageBox.Show("An overflow exception has occured.", "Entry error.");
            }
            //Catches all other exceptions
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n\n" +
                    ex.GetType().ToString() + "\n" +
                    ex.StackTrace, "Exception");
            }
        }

        /*
         * VALUE SETTING METHODS
         */

        //Sets the ISBN integer
        private int SetISBN(TextBox tb)
        {
            //Set isbn int
            string searchBox = "ISBN";
            int isbn = 0;

            if (isPresent(isbnTextbox, searchBox) == true)
            {
                if (isInt(isbnTextbox, searchBox) == true)
                {
                    isbn = Convert.ToInt32(isbnTextbox.Text);
                }
                else
                {
                    isbnTextbox.Focus();
                    isbnTextbox.Clear();
                }
            }
            else
            {
                isbnTextbox.Focus();
            }

            return isbn;
        }

        //Sets the EmployeeID integer
        private int SetEmployeeID(TextBox tb)
        {
            //Set employee id int
            string searchBox = "Employee ID";
            int empID = 0;

            if (isPresent(tb, searchBox) == true)
            {
                if (isInt(tb, searchBox) == true)
                {
                    empID = Convert.ToInt32(employeeIDTextbox.Text);
                }
                else
                {
                    employeeIDTextbox.Focus();
                    employeeIDTextbox.Clear();
                }
            }
            else
            {
                employeeIDTextbox.Focus();
            }

            return empID;
        }

        //Sets the MemberID integer
        private int SetMemberID(TextBox tb)
        {
            //Set member id int
            string searchBox = "Member ID";
            int memID = 0;

            if (isPresent(tb, searchBox) == true)
            {
                if (isInt(tb, searchBox) == true)
                {
                    memID = Convert.ToInt32(memberIDTextbox.Text);
                }
                else
                {
                    memberIDTextbox.Focus();
                    memberIDTextbox.Clear();
                }
            }
            else
            {
                memberIDTextbox.Focus();
            }

            return memID;
        }

        /*
         * VALIDATION METHODS
         */

        //Checks to see if a value is present
        private bool isPresent(TextBox tb, string searchBox)
        {
            if (tb.Text == "")
            {
                //Error message
                MessageBox.Show("Please enter a value for " + searchBox);
                return false;
            }
            else
            {
                return true;
            }
        }

        //Checks to see if value is an integer
        private bool isInt(TextBox tb, string searchBox)
        {
            if (!(Int32.TryParse(tb.Text, out int test)))
            {
                //Error message
                MessageBox.Show(searchBox + " must be a whole number.");
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

