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
    public partial class BookList : Form
    {
        public BookList()
        {
            InitializeComponent();
        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libraryDataSet);
        }

        private void BookList_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libraryDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libraryDataSet.Books);

            //Sets height for the data grid view
            booksDataGridView.Height = Convert.ToInt32(this.Height) - 350;
        }

        private void BookList_Resize(object sender, EventArgs e)
        {
            //Sets height for the data grid view
            booksDataGridView.Height = Convert.ToInt32(this.Height) - 350;
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

                //Searches the database based on search criteria
                if (authorRadio.Checked == true)
                {
                    searchBox = "Author";

                    if (isPresent(authorTextBox, searchBox) == true)
                    {
                        searchText = authorTextBox.Text;

                        this.booksTableAdapter.FillByAuthor(this.libraryDataSet.Books, searchText);
                    }
                }
                else if (titleRadio.Checked == true)
                {
                    searchBox = "Title";

                    if (isPresent(titleTextbox, searchBox) == true)
                    {
                        searchText = titleTextbox.Text;

                        this.booksTableAdapter.FillByTitle(this.libraryDataSet.Books, searchText);
                    }
                }
                else
                {
                    //Error if no search radio is selected
                    MessageBox.Show("Please select a category to search in.");
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

        private void authorRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (authorRadio.Checked == true)
            {
                //Changes enabled values based on radio checked or not
                titleRadio.Checked = false;
                titleTextbox.Enabled = false;
                titleTextbox.Clear();

                authorTextBox.Enabled = true;

                this.AcceptButton = searchButton;
            }
        }

        private void titleRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (titleRadio.Checked == true)
            {
                //Changes enabled values based on radio checked or not
                authorRadio.Checked = false;
                authorTextBox.Enabled = false;
                authorTextBox.Clear();
                titleTextbox.Enabled = true;


                this.AcceptButton = searchButton;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clears search textboxes and fills the table with all data
            authorTextBox.Clear();
            authorTextBox.Enabled = false;
            authorRadio.Checked = false;

            titleTextbox.Clear();
            titleTextbox.Enabled = false;
            titleRadio.Checked = false;

            this.booksTableAdapter.Fill(this.libraryDataSet.Books);
        }

        /*
         * SORT BY... BUTTONS
         */

        private void sortGenreButton_Click(object sender, EventArgs e)
        {
            //Orders the table by genre
            this.booksTableAdapter.OrderByFirstGenre(this.libraryDataSet.Books);
        }

        private void sortOldestBookButton_Click(object sender, EventArgs e)
        {
            //Shows the oldest book in the library
            this.booksTableAdapter.FillByOldestBook(this.libraryDataSet.Books);
        }

        private void sortPublisherButton_Click(object sender, EventArgs e)
        {
            //Orders the table by publisher
            this.booksTableAdapter.OrderByPublisher(this.libraryDataSet.Books);
        }

        /*
         * VALIDATION
         */

        //Checks to see if a value is present
        private bool isPresent(TextBox tb, string searchBox)
        {
            if (tb.Text == "")
            {
                MessageBox.Show("Please enter a value for " + searchBox);
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
