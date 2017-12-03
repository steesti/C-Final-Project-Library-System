namespace CIS_466_Final_Project
{
    partial class Member
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Member));
            this.libraryDataSet = new CIS_466_Final_Project.LibraryDataSet();
            this.membersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.membersTableAdapter = new CIS_466_Final_Project.LibraryDataSetTableAdapters.MembersTableAdapter();
            this.tableAdapterManager = new CIS_466_Final_Project.LibraryDataSetTableAdapters.TableAdapterManager();
            this.membersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
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
            this.membersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.membersDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.searchGroupBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.firstNameTextbox = new System.Windows.Forms.TextBox();
            this.memberIDTextbox = new System.Windows.Forms.TextBox();
            this.firstNameRadio = new System.Windows.Forms.RadioButton();
            this.memberIDRadio = new System.Windows.Forms.RadioButton();
            this.sortGroupBox = new System.Windows.Forms.GroupBox();
            this.sortLastNameButton = new System.Windows.Forms.Button();
            this.sortStateButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingNavigator)).BeginInit();
            this.membersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).BeginInit();
            this.searchGroupBox.SuspendLayout();
            this.sortGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // libraryDataSet
            // 
            this.libraryDataSet.DataSetName = "LibraryDataSet";
            this.libraryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // membersBindingSource
            // 
            this.membersBindingSource.DataMember = "Members";
            this.membersBindingSource.DataSource = this.libraryDataSet;
            // 
            // membersTableAdapter
            // 
            this.membersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = null;
            this.tableAdapterManager.EmployeesTableAdapter = null;
            this.tableAdapterManager.MembersTableAdapter = this.membersTableAdapter;
            this.tableAdapterManager.TransactionsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = CIS_466_Final_Project.LibraryDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // membersBindingNavigator
            // 
            this.membersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.membersBindingNavigator.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.membersBindingNavigator.BindingSource = this.membersBindingSource;
            this.membersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.membersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.membersBindingNavigator.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.membersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.membersBindingNavigatorSaveItem});
            this.membersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.membersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.membersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.membersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.membersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.membersBindingNavigator.Name = "membersBindingNavigator";
            this.membersBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.membersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.membersBindingNavigator.Size = new System.Drawing.Size(1987, 35);
            this.membersBindingNavigator.TabIndex = 0;
            this.membersBindingNavigator.Text = "bindingNavigator1";
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
            // membersBindingNavigatorSaveItem
            // 
            this.membersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.membersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("membersBindingNavigatorSaveItem.Image")));
            this.membersBindingNavigatorSaveItem.Name = "membersBindingNavigatorSaveItem";
            this.membersBindingNavigatorSaveItem.Size = new System.Drawing.Size(32, 32);
            this.membersBindingNavigatorSaveItem.Text = "Save Data";
            this.membersBindingNavigatorSaveItem.Click += new System.EventHandler(this.membersBindingNavigatorSaveItem_Click);
            // 
            // membersDataGridView
            // 
            this.membersDataGridView.AutoGenerateColumns = false;
            this.membersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.membersDataGridView.DataSource = this.membersBindingSource;
            this.membersDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.membersDataGridView.Location = new System.Drawing.Point(0, 35);
            this.membersDataGridView.Margin = new System.Windows.Forms.Padding(6);
            this.membersDataGridView.Name = "membersDataGridView";
            this.membersDataGridView.Size = new System.Drawing.Size(1987, 613);
            this.membersDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "MemberID";
            this.dataGridViewTextBoxColumn1.HeaderText = "MemberID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "First_Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "First_Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Last_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last_Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Phone";
            this.dataGridViewTextBoxColumn4.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Email";
            this.dataGridViewTextBoxColumn5.HeaderText = "Email";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Address";
            this.dataGridViewTextBoxColumn6.HeaderText = "Address";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "City";
            this.dataGridViewTextBoxColumn7.HeaderText = "City";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "State";
            this.dataGridViewTextBoxColumn8.HeaderText = "State";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Zip";
            this.dataGridViewTextBoxColumn9.HeaderText = "Zip";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "DOB";
            this.dataGridViewTextBoxColumn10.HeaderText = "DOB";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // searchGroupBox
            // 
            this.searchGroupBox.Controls.Add(this.clearButton);
            this.searchGroupBox.Controls.Add(this.searchButton);
            this.searchGroupBox.Controls.Add(this.firstNameTextbox);
            this.searchGroupBox.Controls.Add(this.memberIDTextbox);
            this.searchGroupBox.Controls.Add(this.firstNameRadio);
            this.searchGroupBox.Controls.Add(this.memberIDRadio);
            this.searchGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.searchGroupBox.Location = new System.Drawing.Point(0, 740);
            this.searchGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.searchGroupBox.Name = "searchGroupBox";
            this.searchGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.searchGroupBox.Size = new System.Drawing.Size(1987, 222);
            this.searchGroupBox.TabIndex = 2;
            this.searchGroupBox.TabStop = false;
            this.searchGroupBox.Text = "Search By...";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(398, 52);
            this.clearButton.Margin = new System.Windows.Forms.Padding(6);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 140);
            this.clearButton.TabIndex = 5;
            this.clearButton.Text = "Clear and Reset";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(204, 150);
            this.searchButton.Margin = new System.Windows.Forms.Padding(6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(183, 42);
            this.searchButton.TabIndex = 4;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // firstNameTextbox
            // 
            this.firstNameTextbox.Enabled = false;
            this.firstNameTextbox.Location = new System.Drawing.Point(204, 100);
            this.firstNameTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.firstNameTextbox.Name = "firstNameTextbox";
            this.firstNameTextbox.Size = new System.Drawing.Size(180, 29);
            this.firstNameTextbox.TabIndex = 3;
            // 
            // memberIDTextbox
            // 
            this.memberIDTextbox.Enabled = false;
            this.memberIDTextbox.Location = new System.Drawing.Point(204, 52);
            this.memberIDTextbox.Margin = new System.Windows.Forms.Padding(6);
            this.memberIDTextbox.Name = "memberIDTextbox";
            this.memberIDTextbox.Size = new System.Drawing.Size(180, 29);
            this.memberIDTextbox.TabIndex = 2;
            // 
            // firstNameRadio
            // 
            this.firstNameRadio.AutoSize = true;
            this.firstNameRadio.Location = new System.Drawing.Point(42, 105);
            this.firstNameRadio.Margin = new System.Windows.Forms.Padding(6);
            this.firstNameRadio.Name = "firstNameRadio";
            this.firstNameRadio.Size = new System.Drawing.Size(131, 29);
            this.firstNameRadio.TabIndex = 1;
            this.firstNameRadio.TabStop = true;
            this.firstNameRadio.Text = "First Name";
            this.firstNameRadio.UseVisualStyleBackColor = true;
            this.firstNameRadio.CheckedChanged += new System.EventHandler(this.firstNameRadio_CheckedChanged);
            // 
            // memberIDRadio
            // 
            this.memberIDRadio.AutoSize = true;
            this.memberIDRadio.Location = new System.Drawing.Point(42, 54);
            this.memberIDRadio.Margin = new System.Windows.Forms.Padding(6);
            this.memberIDRadio.Name = "memberIDRadio";
            this.memberIDRadio.Size = new System.Drawing.Size(143, 29);
            this.memberIDRadio.TabIndex = 0;
            this.memberIDRadio.TabStop = true;
            this.memberIDRadio.Text = "Members ID";
            this.memberIDRadio.UseVisualStyleBackColor = true;
            this.memberIDRadio.CheckedChanged += new System.EventHandler(this.memberIDRadio_CheckedChanged);
            // 
            // sortGroupBox
            // 
            this.sortGroupBox.Controls.Add(this.sortLastNameButton);
            this.sortGroupBox.Controls.Add(this.sortStateButton);
            this.sortGroupBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.sortGroupBox.Location = new System.Drawing.Point(0, 518);
            this.sortGroupBox.Margin = new System.Windows.Forms.Padding(6);
            this.sortGroupBox.Name = "sortGroupBox";
            this.sortGroupBox.Padding = new System.Windows.Forms.Padding(6);
            this.sortGroupBox.Size = new System.Drawing.Size(1987, 222);
            this.sortGroupBox.TabIndex = 6;
            this.sortGroupBox.TabStop = false;
            this.sortGroupBox.Text = "Sort By...";
            // 
            // sortLastNameButton
            // 
            this.sortLastNameButton.Location = new System.Drawing.Point(29, 50);
            this.sortLastNameButton.Margin = new System.Windows.Forms.Padding(6);
            this.sortLastNameButton.Name = "sortLastNameButton";
            this.sortLastNameButton.Size = new System.Drawing.Size(150, 140);
            this.sortLastNameButton.TabIndex = 7;
            this.sortLastNameButton.Text = "Last Name";
            this.sortLastNameButton.UseVisualStyleBackColor = true;
            this.sortLastNameButton.Click += new System.EventHandler(this.sortLastNameButton_Click);
            // 
            // sortStateButton
            // 
            this.sortStateButton.Location = new System.Drawing.Point(191, 50);
            this.sortStateButton.Margin = new System.Windows.Forms.Padding(6);
            this.sortStateButton.Name = "sortStateButton";
            this.sortStateButton.Size = new System.Drawing.Size(150, 140);
            this.sortStateButton.TabIndex = 6;
            this.sortStateButton.Text = "State";
            this.sortStateButton.UseVisualStyleBackColor = true;
            this.sortStateButton.Click += new System.EventHandler(this.sortStateButton_Click);
            // 
            // Member
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1987, 962);
            this.Controls.Add(this.sortGroupBox);
            this.Controls.Add(this.searchGroupBox);
            this.Controls.Add(this.membersDataGridView);
            this.Controls.Add(this.membersBindingNavigator);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Member";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Members";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Member_Load);
            this.Resize += new System.EventHandler(this.Member_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.libraryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.membersBindingNavigator)).EndInit();
            this.membersBindingNavigator.ResumeLayout(false);
            this.membersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersDataGridView)).EndInit();
            this.searchGroupBox.ResumeLayout(false);
            this.searchGroupBox.PerformLayout();
            this.sortGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private LibraryDataSet libraryDataSet;
        private System.Windows.Forms.BindingSource membersBindingSource;
        private LibraryDataSetTableAdapters.MembersTableAdapter membersTableAdapter;
        private LibraryDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator membersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton membersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView membersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.GroupBox searchGroupBox;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox firstNameTextbox;
        private System.Windows.Forms.TextBox memberIDTextbox;
        private System.Windows.Forms.RadioButton firstNameRadio;
        private System.Windows.Forms.RadioButton memberIDRadio;
        private System.Windows.Forms.GroupBox sortGroupBox;
        private System.Windows.Forms.Button sortLastNameButton;
        private System.Windows.Forms.Button sortStateButton;
    }
}