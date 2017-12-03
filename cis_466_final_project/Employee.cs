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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void employeesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Employees' table. You can move, or remove it, as needed.
            this.employeesTableAdapter.Fill(this.libraryDataSet.Employees);

            //Sets height for the data grid view
            employeesDataGridView.Height = Convert.ToInt32(this.Height) - 350;
        }

        private void Employee_Resize(object sender, EventArgs e)
        {
            //Sets height for the data grid view
            employeesDataGridView.Height = Convert.ToInt32(this.Height) - 350;
        }

        /*
         * SEARCH BY... BUTTONS
         */

        private void searchButton_Click(object sender, EventArgs e)
        {
            try
            {
                //Declare variables
                string searchBox = "", searchText = "";
                int empID = 0;

                //Searches the database based on search criteria
                if (employeeIDRadio.Checked == true)
                {
                    searchBox = "Employee ID";

                    //Test validation and output if valid
                    if (isPresent(employeeIDTextbox, searchBox) == true)
                    {
                        if (isInt(employeeIDTextbox, searchBox) == true)
                        {
                            searchText = employeeIDTextbox.Text;
                            empID = Convert.ToInt32(searchText);

                            this.employeesTableAdapter.FillByEmployeeID(this.libraryDataSet.Employees, empID);
                        }
                    }
                }
                else if (lastNameRadio.Checked == true)
                {
                    searchBox = "Last Name";

                    //Test validation and output if valid
                    if (isPresent(lastNameTextbox, searchBox) == true)
                    {
                        searchText = lastNameTextbox.Text;

                        this.employeesTableAdapter.FillByLastName(this.libraryDataSet.Employees, searchText);
                    }
                }
                else
                {
                    //Error if no search radio is selected
                    MessageBox.Show("Please select a category to search in.");
                }
            }
            //Catches incorrectly formatted input
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

        private void employeeIDRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (employeeIDRadio.Checked == true)
            {
                //Changes enabled values based on radio checked or not
                lastNameRadio.Checked = false;
                lastNameTextbox.Enabled = false;
                lastNameTextbox.Clear();

                employeeIDTextbox.Enabled = true;

                this.AcceptButton = searchButton;
            }
        }

        private void lastNameRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (lastNameRadio.Checked == true)
            {
                //Changes enabled values based on radio checked or not
                employeeIDRadio.Checked = false;
                employeeIDTextbox.Enabled = false;
                employeeIDTextbox.Clear();

                lastNameTextbox.Enabled = true;

                this.AcceptButton = searchButton;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears search textboxes and fills the table with all data
            employeeIDTextbox.Clear();
            employeeIDTextbox.Enabled = false;
            employeeIDRadio.Checked = false;

            lastNameTextbox.Clear();
            lastNameTextbox.Enabled = false;
            lastNameRadio.Checked = false;

            this.employeesTableAdapter.Fill(this.libraryDataSet.Employees);
        }

        /*
         * SORT BY... BUTTONS
         */

        private void sortFirstNameButton_Click(object sender, EventArgs e)
        {
            //Order the employees by first name
            this.employeesTableAdapter.OrderByFirstName(this.libraryDataSet.Employees);
        }

        private void sortCityButton_Click(object sender, EventArgs e)
        {
            //Order the employees by city
            this.employeesTableAdapter.OrderByCity(this.libraryDataSet.Employees);
        }

        private void sortOldestButton_Click(object sender, EventArgs e)
        {
            //Fill the table with the oldest employee
            this.employeesTableAdapter.FillByOldestEmployee(this.libraryDataSet.Employees);
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
