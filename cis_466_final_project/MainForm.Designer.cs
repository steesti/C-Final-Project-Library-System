namespace CIS_466_Final_Project
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.booklistBt = new System.Windows.Forms.Button();
            this.employeeBt = new System.Windows.Forms.Button();
            this.memberBt = new System.Windows.Forms.Button();
            this.transactionHistBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.transactionCICOBt = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // booklistBt
            // 
            this.booklistBt.Location = new System.Drawing.Point(55, 205);
            this.booklistBt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.booklistBt.Name = "booklistBt";
            this.booklistBt.Size = new System.Drawing.Size(202, 96);
            this.booklistBt.TabIndex = 0;
            this.booklistBt.Text = "Book List";
            this.booklistBt.UseVisualStyleBackColor = true;
            this.booklistBt.Click += new System.EventHandler(this.booklistBt_Click);
            // 
            // employeeBt
            // 
            this.employeeBt.Location = new System.Drawing.Point(268, 205);
            this.employeeBt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.employeeBt.Name = "employeeBt";
            this.employeeBt.Size = new System.Drawing.Size(202, 96);
            this.employeeBt.TabIndex = 1;
            this.employeeBt.Text = "Employee Information";
            this.employeeBt.UseVisualStyleBackColor = true;
            this.employeeBt.Click += new System.EventHandler(this.employeeBt_Click);
            // 
            // memberBt
            // 
            this.memberBt.Location = new System.Drawing.Point(480, 205);
            this.memberBt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.memberBt.Name = "memberBt";
            this.memberBt.Size = new System.Drawing.Size(202, 96);
            this.memberBt.TabIndex = 2;
            this.memberBt.Text = "Member Information";
            this.memberBt.UseVisualStyleBackColor = true;
            this.memberBt.Click += new System.EventHandler(this.memberBt_Click);
            // 
            // transactionHistBt
            // 
            this.transactionHistBt.Location = new System.Drawing.Point(693, 205);
            this.transactionHistBt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.transactionHistBt.Name = "transactionHistBt";
            this.transactionHistBt.Size = new System.Drawing.Size(202, 96);
            this.transactionHistBt.TabIndex = 3;
            this.transactionHistBt.Text = "Transaction History";
            this.transactionHistBt.UseVisualStyleBackColor = true;
            this.transactionHistBt.Click += new System.EventHandler(this.transactionHistBt_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Elephant", 26.14286F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(649, 83);
            this.label1.TabIndex = 4;
            this.label1.Text = "USM LIBRARY";
            // 
            // transactionCICOBt
            // 
            this.transactionCICOBt.Location = new System.Drawing.Point(717, 44);
            this.transactionCICOBt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.transactionCICOBt.Name = "transactionCICOBt";
            this.transactionCICOBt.Size = new System.Drawing.Size(178, 83);
            this.transactionCICOBt.TabIndex = 5;
            this.transactionCICOBt.Text = "Check-in / Check-out ";
            this.transactionCICOBt.UseVisualStyleBackColor = true;
            this.transactionCICOBt.Click += new System.EventHandler(this.transactionCICOBt_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(946, 342);
            this.Controls.Add(this.transactionCICOBt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.transactionHistBt);
            this.Controls.Add(this.memberBt);
            this.Controls.Add(this.employeeBt);
            this.Controls.Add(this.booklistBt);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button booklistBt;
        private System.Windows.Forms.Button employeeBt;
        private System.Windows.Forms.Button memberBt;
        private System.Windows.Forms.Button transactionHistBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button transactionCICOBt;
    }
}

