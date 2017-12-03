namespace CIS_466_Final_Project
{
    partial class Check_inCheck_outForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Check_inCheck_outForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.isbnTextbox = new System.Windows.Forms.TextBox();
            this.memberIDTextbox = new System.Windows.Forms.TextBox();
            this.employeeIDTextbox = new System.Windows.Forms.TextBox();
            this.checkInButton = new System.Windows.Forms.Button();
            this.cicoLabel = new System.Windows.Forms.Label();
            this.checkOutButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Employee ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Member ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "ISBN";
            // 
            // isbnTextbox
            // 
            this.isbnTextbox.Location = new System.Drawing.Point(172, 48);
            this.isbnTextbox.Name = "isbnTextbox";
            this.isbnTextbox.Size = new System.Drawing.Size(129, 20);
            this.isbnTextbox.TabIndex = 0;
            this.isbnTextbox.Leave += new System.EventHandler(this.isbnTextbox_Leave);
            // 
            // memberIDTextbox
            // 
            this.memberIDTextbox.Location = new System.Drawing.Point(172, 120);
            this.memberIDTextbox.Name = "memberIDTextbox";
            this.memberIDTextbox.Size = new System.Drawing.Size(129, 20);
            this.memberIDTextbox.TabIndex = 2;
            this.memberIDTextbox.Leave += new System.EventHandler(this.memberIDTextbox_Leave);
            // 
            // employeeIDTextbox
            // 
            this.employeeIDTextbox.Location = new System.Drawing.Point(172, 84);
            this.employeeIDTextbox.Name = "employeeIDTextbox";
            this.employeeIDTextbox.Size = new System.Drawing.Size(129, 20);
            this.employeeIDTextbox.TabIndex = 1;
            this.employeeIDTextbox.Leave += new System.EventHandler(this.employeeIDTextbox_Leave);
            // 
            // checkInButton
            // 
            this.checkInButton.Location = new System.Drawing.Point(93, 155);
            this.checkInButton.Name = "checkInButton";
            this.checkInButton.Size = new System.Drawing.Size(100, 52);
            this.checkInButton.TabIndex = 3;
            this.checkInButton.Text = "Check-in";
            this.checkInButton.UseVisualStyleBackColor = true;
            this.checkInButton.Click += new System.EventHandler(this.checkInButton_Click);
            // 
            // cicoLabel
            // 
            this.cicoLabel.AutoSize = true;
            this.cicoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cicoLabel.Location = new System.Drawing.Point(12, 9);
            this.cicoLabel.Name = "cicoLabel";
            this.cicoLabel.Size = new System.Drawing.Size(206, 24);
            this.cicoLabel.TabIndex = 5;
            this.cicoLabel.Text = "Check-in / Check-out";
            // 
            // checkOutButton
            // 
            this.checkOutButton.Location = new System.Drawing.Point(199, 155);
            this.checkOutButton.Name = "checkOutButton";
            this.checkOutButton.Size = new System.Drawing.Size(100, 52);
            this.checkOutButton.TabIndex = 4;
            this.checkOutButton.Text = "Check-out";
            this.checkOutButton.UseVisualStyleBackColor = true;
            this.checkOutButton.Click += new System.EventHandler(this.checkOutButton_Click);
            // 
            // Check_inCheck_outForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(313, 226);
            this.Controls.Add(this.checkOutButton);
            this.Controls.Add(this.cicoLabel);
            this.Controls.Add(this.checkInButton);
            this.Controls.Add(this.employeeIDTextbox);
            this.Controls.Add(this.memberIDTextbox);
            this.Controls.Add(this.isbnTextbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Check_inCheck_outForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "USM Library";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox isbnTextbox;
        private System.Windows.Forms.TextBox memberIDTextbox;
        private System.Windows.Forms.TextBox employeeIDTextbox;
        private System.Windows.Forms.Button checkInButton;
        private System.Windows.Forms.Label cicoLabel;
        private System.Windows.Forms.Button checkOutButton;
    }
}