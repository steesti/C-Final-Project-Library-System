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
    public partial class Member : Form
    {
        public Member()
        {
            InitializeComponent();
        }

        private void membersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.membersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);           
        }

        private void Member_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Members' table. You can move, or remove it, as needed.
            this.membersTableAdapter.Fill(this.libraryDataSet.Members);

            //Sets height for the data grid view
            membersDataGridView.Height = Convert.ToInt32(this.Height) - 350;
        }

        private void Member_Resize(object sender, EventArgs e)
        {
            //Sets height for the data grid view
            membersDataGridView.Height = Convert.ToInt32(this.Height) - 350;
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
                int memID = 0;

                //Searches the database based on search criteria
                if (memberIDRadio.Checked == true)
                {
                    searchBox = "Member ID";

                    //Test validation and output if valid
                    if (isPresent(memberIDTextbox, searchBox) == true)
                    {
                        if (isInt(memberIDTextbox, searchBox) == true)
                        {
                            searchText = memberIDTextbox.Text;
                            memID = Convert.ToInt32(searchText);

                            this.membersTableAdapter.FillByMemberID(this.libraryDataSet.Members, memID);
                        }
                    }
                }
                else if (firstNameRadio.Checked == true)
                {
                    searchBox = "First Name";

                    //Test validation and output if valid
                    if (isPresent(firstNameTextbox, searchBox) == true)
                    {
                        searchText = firstNameTextbox.Text;

                        this.membersTableAdapter.FillByFirstName(this.libraryDataSet.Members, searchText);
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

        private void memberIDRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (memberIDRadio.Checked == true)
            {
                //Changes enabled values based on radio checked or not
                firstNameRadio.Checked = false;
                firstNameTextbox.Enabled = false;
                firstNameTextbox.Clear();

                memberIDTextbox.Enabled = true;

                this.AcceptButton = searchButton;
            }
        }

        private void firstNameRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (firstNameRadio.Checked == true)
            {
                //Changes enabled values based on radio checked or not
                memberIDRadio.Checked = false;
                memberIDTextbox.Enabled = false;
                memberIDTextbox.Clear();

                firstNameTextbox.Enabled = true;

                this.AcceptButton = searchButton;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears search textboxes and fills the table with all data
            memberIDTextbox.Clear();
            memberIDTextbox.Enabled = false;
            memberIDRadio.Checked = false;

            firstNameTextbox.Clear();
            firstNameTextbox.Enabled = false;
            firstNameRadio.Checked = false;

            this.membersTableAdapter.Fill(this.libraryDataSet.Members);
        }

        /*
         * SORT BY... BUTTONS
         */

        private void sortLastNameButton_Click(object sender, EventArgs e)
        {
            //Orders the members by last name
            this.membersTableAdapter.OrderByLastName(this.libraryDataSet.Members);
        }

        private void sortStateButton_Click(object sender, EventArgs e)
        {
            //Order the members by state
            this.membersTableAdapter.OrderByState(this.libraryDataSet.Members);
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
