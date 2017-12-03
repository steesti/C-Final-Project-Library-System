namespace CIS_466_Final_Project
{
    partial class BookList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookList));
            this.booksBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.libraryDataSet = new CIS_466_Final_Project.LibraryDataSet();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.booksBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.booksDataGridView = new System.Windows.Forms.DataGridView();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.printDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondGenreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sectionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.availableDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.searchBookGroupBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.titleRadio = new System.Windows.Forms.RadioButton();
            this.authorRadio = new System.Windows.Forms.RadioButton();
            this.searchButton = new System.Windows.Forms.Button();
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.authorTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.sortByGroupBox = new System.Windows.Forms.GroupBox();
            this.sortPublisherButton = new System.Windows.Forms.Button();
            this.sortOldestBookButton = new System.Windows.Forms.Button();
            this.sortGenreButton = new System.Windows.Forms.Button();
            this.booksTableAdapter = new CIS_466_Final_Project.LibraryDataSetTableAdapters.BooksTableAdapter();
            this.tableAdapterManager = new CIS_466_Final_Project.LibraryDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingNavigator)).BeginInit();
            this.booksBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).BeginInit();
            this.searchBookGroupBox.SuspendLayout();
            this.sortByGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // booksBindingNavigator
            // 
            this.booksBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.booksBindingNavigator.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.booksBindingNavigator.BindingSource = this.booksBindingSource;
            this.booksBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.booksBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.booksBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.booksBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.booksBindingNavigatorSaveItem});
            this.booksBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.booksBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.booksBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.booksBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.booksBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.booksBindingNavigator.Name = "booksBindingNavigator";
            this.booksBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.booksBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.booksBindingNavigator.Size = new System.Drawing.Size(1987, 35);
            this.booksBindingNavigator.TabIndex = 0;
            this.booksBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.libraryDataSet;
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(61, 32);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(88, 35);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 35);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(32, 32);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 35);
            // 
            // booksBindingNavigatorSaveItem
            // 
            this.booksBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.booksBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("booksBindingNavigatorSaveItem.Image")));
            this.booksBindingNavigatorSaveItem.Name = "booksBindingNavigatorSaveItem";
            this.booksBindingNavigatorSaveItem.Size = new System.Drawing.Size(32, 32);
            this.booksBindingNavigatorSaveItem.Text = "Save Data";
            this.booksBindingNavigatorSaveItem.Click += new System.EventHandler(this.booksBindingNavigatorSaveItem_Click);
            // 
            // booksDataGridView
            // 
            this.booksDataGridView.AutoGenerateColumns = false;
            this.booksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iSBNDataGridViewTextBoxColumn,
            this.titleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.printDateDataGridViewTextBoxColumn,
            this.firstGenreDataGridViewTextBoxColumn,
            this.secondGenreDataGridViewTextBoxColumn,
            this.sectionDataGridViewTextBoxColumn,
            this.availableDataGridViewCheckBoxColumn});
            this.booksDataGridView.DataSource = this.booksBindingSource;
            this.booksDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.booksDataGridView.Location = new System.Drawing.Point(0, 35);
            this.booksDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.booksDataGridView.Name = "booksDataGridView";
            this.booksDataGridView.Size = new System.Drawing.Size(1987, 593);
            this.booksDataGridView.TabIndex = 1;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // titleDataGridViewTextBoxColumn
            // 
            this.titleDataGridViewTextBoxColumn.DataPropertyName = "Title";
            this.titleDataGridViewTextBoxColumn.HeaderText = "Title";
            this.titleDataGridViewTextBoxColumn.Name = "titleDataGridViewTextBoxColumn";
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            // 
            // printDateDataGridViewTextBoxColumn
            // 
            this.printDateDataGridViewTextBoxColumn.DataPropertyName = "Print_Date";
            this.printDateDataGridViewTextBoxColumn.HeaderText = "Print_Date";
            this.printDateDataGridViewTextBoxColumn.Name = "printDateDataGridViewTextBoxColumn";
            // 
            // firstGenreDataGridViewTextBoxColumn
            // 
            this.firstGenreDataGridViewTextBoxColumn.DataPropertyName = "First_Genre";
            this.firstGenreDataGridViewTextBoxColumn.HeaderText = "First_Genre";
            this.firstGenreDataGridViewTextBoxColumn.Name = "firstGenreDataGridViewTextBoxColumn";
            // 
            // secondGenreDataGridViewTextBoxColumn
            // 
            this.secondGenreDataGridViewTextBoxColumn.DataPropertyName = "Second_Genre";
            this.secondGenreDataGridViewTextBoxColumn.HeaderText = "Second_Genre";
            this.secondGenreDataGridViewTextBoxColumn.Name = "secondGenreDataGridViewTextBoxColumn";
            // 
            // sectionDataGridViewTextBoxColumn
            // 
            this.sectionDataGridViewTextBoxColumn.DataPropertyName = "Section";
            this.sectionDataGridViewTextBoxColumn.HeaderText = "Section";
            this.sectionDataGridViewTextBoxColumn.Name = "sectionDataGridViewTextBoxColumn";
            // 
            // availableDataGridViewCheckBoxColumn
            // 
            this.availableDataGridViewCheckBoxColumn.DataPropertyName = "Available";
            this.availableDataGridViewCheckBoxColumn.HeaderText = "Available";
            this.availableDataGridViewCheckBoxColumn.Name = "availableDataGridViewCheckBoxColumn";
            // 
            // searchBookGroupBox
            // 
            this.searchBookGroupBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.searchBookGroupBox.Controls.Add(this.clearButton);
            this.searchBookGroupBox.Controls.Add(this.titleRadio);
            this.searchBookGroupBox.Controls.Add(this.authorRadio);
            this.searchBookGroupBox.Controls.Add(this.searchButton);
            this.searchBookGroupBox.Controls.Add(this.titleTextbox);
            this.searchBookGroupBox.Controls.Add(this.authorTextBox);
            this.searchBookGroupBox.Controls.Add(this.label1);
            this.searchBookGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchBookGroupBox.Location = new System.Drawing.Point(0, 733);
            this.searchBookGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.searchBookGroupBox.Name = "searchBookGroupBox";
            this.searchBookGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.searchBookGroupBox.Size = new System.Drawing.Size(1987, 229);
            this.searchBookGroupBox.TabIndex = 2;
            this.searchBookGroupBox.TabStop = false;
            this.searchBookGroupBox.Text = "Search by...";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(348, 48);
            this.clearButton.Margin = new System.Windows.Forms.Padding(6);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(158, 144);
            this.clearButton.TabIndex = 7;
            this.clearButton.Text = "Clear and Reset";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // titleRadio
            // 
            this.titleRadio.AutoSize = true;
            this.titleRadio.Location = new System.Drawing.Point(40, 103);
            this.titleRadio.Margin = new System.Windows.Forms.Padding(6);
            this.titleRadio.Name = "titleRadio";
            this.titleRadio.Size = new System.Drawing.Size(74, 29);
            this.titleRadio.TabIndex = 6;
            this.titleRadio.TabStop = true;
            this.titleRadio.Text = "Title";
            this.titleRadio.UseVisualStyleBackColor = true;
            this.titleRadio.CheckedChanged += new System.EventHandler(this.titleRadio_CheckedChanged);
            // 
            // authorRadio
            // 
            this.authorRadio.AutoSize = true;
            this.authorRadio.Location = new System.Drawing.Point(40, 52);
            this.authorRadio.Margin = new System.Windows.Forms.Padding(6);
            this.authorRadio.Name = "authorRadio";
            this.authorRadio.Size = new System.Drawing.Size(95, 29);
            this.authorRadio.TabIndex = 5;
            this.authorRadio.TabStop = true;
            this.authorRadio.Text = "Author";
            this.authorRadio.UseVisualStyleBackColor = true;
            this.authorRadio.CheckedChanged += new System.EventHandler(this.authorRadio_CheckedChanged);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(154, 150);
            this.searchButton.Margin = new System.Windows.Forms.Padding(6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(183, 42);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // titleTextbox
            // 
            this.titleTextbox.Enabled = false;
            this.titleTextbox.Location = new System.Drawing.Point(154, 102);
            this.titleTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(180, 29);
            this.titleTextbox.TabIndex = 4;
            // 
            // authorTextBox
            // 
            this.authorTextBox.Enabled = false;
            this.authorTextBox.Location = new System.Drawing.Point(154, 50);
            this.authorTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.authorTextBox.Name = "authorTextBox";
            this.authorTextBox.Size = new System.Drawing.Size(180, 29);
            this.authorTextBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // sortByGroupBox
            // 
            this.sortByGroupBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sortByGroupBox.Controls.Add(this.sortPublisherButton);
            this.sortByGroupBox.Controls.Add(this.sortOldestBookButton);
            this.sortByGroupBox.Controls.Add(this.sortGenreButton);
            this.sortByGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sortByGroupBox.Location = new System.Drawing.Point(0, 504);
            this.sortByGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.sortByGroupBox.Name = "sortByGroupBox";
            this.sortByGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.sortByGroupBox.Size = new System.Drawing.Size(1987, 229);
            this.sortByGroupBox.TabIndex = 3;
            this.sortByGroupBox.TabStop = false;
            this.sortByGroupBox.Text = "Sort by...";
            // 
            // sortPublisherButton
            // 
            this.sortPublisherButton.Location = new System.Drawing.Point(370, 46);
            this.sortPublisherButton.Margin = new System.Windows.Forms.Padding(6);
            this.sortPublisherButton.Name = "sortPublisherButton";
            this.sortPublisherButton.Size = new System.Drawing.Size(158, 148);
            this.sortPublisherButton.TabIndex = 3;
            this.sortPublisherButton.Text = "Publisher";
            this.sortPublisherButton.UseVisualStyleBackColor = true;
            this.sortPublisherButton.Click += new System.EventHandler(this.sortPublisherButton_Click);
            // 
            // sortOldestBookButton
            // 
            this.sortOldestBookButton.Location = new System.Drawing.Point(202, 48);
            this.sortOldestBookButton.Margin = new System.Windows.Forms.Padding(6);
            this.sortOldestBookButton.Name = "sortOldestBookButton";
            this.sortOldestBookButton.Size = new System.Drawing.Size(158, 144);
            this.sortOldestBookButton.TabIndex = 2;
            this.sortOldestBookButton.Text = "Oldest Book";
            this.sortOldestBookButton.UseVisualStyleBackColor = true;
            this.sortOldestBookButton.Click += new System.EventHandler(this.sortOldestBookButton_Click);
            // 
            // sortGenreButton
            // 
            this.sortGenreButton.Location = new System.Drawing.Point(33, 48);
            this.sortGenreButton.Margin = new System.Windows.Forms.Padding(6);
            this.sortGenreButton.Name = "sortGenreButton";
            this.sortGenreButton.Size = new System.Drawing.Size(158, 144);
            this.sortGenreButton.TabIndex = 0;
            this.sortGenreButton.Text = "First Genre";
            this.sortGenreButton.UseVisualStyleBackColor = true;
            this.sortGenreButton.Click += new System.EventHandler(this.sortGenreButton_Click);
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = null;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CIS_466_Final_Project.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1987, 962);
            this.Controls.Add(this.sortByGroupBox);
            this.Controls.Add(this.searchBookGroupBox);
            this.Controls.Add(this.booksDataGridView);
            this.Controls.Add(this.booksBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BookList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book List";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BookList_Load);
            this.Resize += new System.EventHandler(this.BookList_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingNavigator)).EndInit();
            this.booksBindingNavigator.ResumeLayout(false);
            this.booksBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataGridView)).EndInit();
            this.searchBookGroupBox.ResumeLayout(false);
            this.searchBookGroupBox.PerformLayout();
            this.sortByGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private LibraryDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator booksBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton booksBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView booksDataGridView;
        private System.Windows.Forms.GroupBox searchBookGroupBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.RadioButton titleRadio;
        private System.Windows.Forms.RadioButton authorRadio;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox titleTextbox;
        private System.Windows.Forms.TextBox authorTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox sortByGroupBox;
        private System.Windows.Forms.Button sortGenreButton;
        private System.Windows.Forms.Button sortOldestBookButton;
        private System.Windows.Forms.Button sortPublisherButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn printDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondGenreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sectionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn availableDataGridViewCheckBoxColumn;
    }
}