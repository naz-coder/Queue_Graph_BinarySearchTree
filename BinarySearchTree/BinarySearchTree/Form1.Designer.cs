namespace BinarySearchTree
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.addNumberTextBox = new System.Windows.Forms.TextBox();
            this.addNumberToTreeButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.totalItemsLabel = new System.Windows.Forms.Label();
            this.preOrderButton = new System.Windows.Forms.Button();
            this.inOrderButton = new System.Windows.Forms.Button();
            this.postOrderButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.traverseLabel = new System.Windows.Forms.Label();
            this.totalCustomersLabel = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addCustomerButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.amountOwedTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.amountOwedLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.ageLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number to Add";
            // 
            // addNumberTextBox
            // 
            this.addNumberTextBox.Location = new System.Drawing.Point(64, 62);
            this.addNumberTextBox.Name = "addNumberTextBox";
            this.addNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.addNumberTextBox.TabIndex = 1;
            // 
            // addNumberToTreeButton
            // 
            this.addNumberToTreeButton.Location = new System.Drawing.Point(56, 97);
            this.addNumberToTreeButton.Name = "addNumberToTreeButton";
            this.addNumberToTreeButton.Size = new System.Drawing.Size(116, 23);
            this.addNumberToTreeButton.TabIndex = 2;
            this.addNumberToTreeButton.Text = "Add Number to Tree";
            this.addNumberToTreeButton.UseVisualStyleBackColor = true;
            this.addNumberToTreeButton.Click += new System.EventHandler(this.addNumberToTreeButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Number Of Items";
            // 
            // totalItemsLabel
            // 
            this.totalItemsLabel.AutoSize = true;
            this.totalItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItemsLabel.Location = new System.Drawing.Point(104, 191);
            this.totalItemsLabel.Name = "totalItemsLabel";
            this.totalItemsLabel.Size = new System.Drawing.Size(23, 25);
            this.totalItemsLabel.TabIndex = 11;
            this.totalItemsLabel.Text = "0";
            // 
            // preOrderButton
            // 
            this.preOrderButton.Location = new System.Drawing.Point(253, 36);
            this.preOrderButton.Name = "preOrderButton";
            this.preOrderButton.Size = new System.Drawing.Size(75, 23);
            this.preOrderButton.TabIndex = 12;
            this.preOrderButton.Text = "PreOrder";
            this.preOrderButton.UseVisualStyleBackColor = true;
            this.preOrderButton.Click += new System.EventHandler(this.preOrderButton_Click);
            // 
            // inOrderButton
            // 
            this.inOrderButton.Location = new System.Drawing.Point(400, 36);
            this.inOrderButton.Name = "inOrderButton";
            this.inOrderButton.Size = new System.Drawing.Size(75, 23);
            this.inOrderButton.TabIndex = 13;
            this.inOrderButton.Text = "InOrder";
            this.inOrderButton.UseVisualStyleBackColor = true;
            this.inOrderButton.Click += new System.EventHandler(this.inOrderButton_Click);
            // 
            // postOrderButton
            // 
            this.postOrderButton.Location = new System.Drawing.Point(547, 36);
            this.postOrderButton.Name = "postOrderButton";
            this.postOrderButton.Size = new System.Drawing.Size(75, 23);
            this.postOrderButton.TabIndex = 14;
            this.postOrderButton.Text = "PostOrder";
            this.postOrderButton.UseVisualStyleBackColor = true;
            this.postOrderButton.Click += new System.EventHandler(this.postOrderButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(405, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Traverse In:";
            // 
            // traverseLabel
            // 
            this.traverseLabel.AutoSize = true;
            this.traverseLabel.Location = new System.Drawing.Point(437, 107);
            this.traverseLabel.Name = "traverseLabel";
            this.traverseLabel.Size = new System.Drawing.Size(0, 13);
            this.traverseLabel.TabIndex = 16;
            // 
            // totalCustomersLabel
            // 
            this.totalCustomersLabel.AutoSize = true;
            this.totalCustomersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCustomersLabel.Location = new System.Drawing.Point(362, 570);
            this.totalCustomersLabel.Name = "totalCustomersLabel";
            this.totalCustomersLabel.Size = new System.Drawing.Size(0, 25);
            this.totalCustomersLabel.TabIndex = 27;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(294, 540);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Total Number Of Customers";
            // 
            // addCustomerButton
            // 
            this.addCustomerButton.Location = new System.Drawing.Point(76, 573);
            this.addCustomerButton.Name = "addCustomerButton";
            this.addCustomerButton.Size = new System.Drawing.Size(91, 23);
            this.addCustomerButton.TabIndex = 25;
            this.addCustomerButton.Text = "Add Customer";
            this.addCustomerButton.UseVisualStyleBackColor = true;
            this.addCustomerButton.Click += new System.EventHandler(this.addCustomerButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 519);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 24;
            this.label4.Text = "AmountOwed";
            // 
            // amountOwedTextBox
            // 
            this.amountOwedTextBox.Location = new System.Drawing.Point(125, 513);
            this.amountOwedTextBox.Name = "amountOwedTextBox";
            this.amountOwedTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountOwedTextBox.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 465);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 22;
            this.label6.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(125, 459);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 411);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Age";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(125, 405);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(29, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Name";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(125, 351);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 17;
            // 
            // amountOwedLabel
            // 
            this.amountOwedLabel.AutoSize = true;
            this.amountOwedLabel.Location = new System.Drawing.Point(703, 491);
            this.amountOwedLabel.Name = "amountOwedLabel";
            this.amountOwedLabel.Size = new System.Drawing.Size(10, 13);
            this.amountOwedLabel.TabIndex = 36;
            this.amountOwedLabel.Text = "-";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(703, 452);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(10, 13);
            this.addressLabel.TabIndex = 35;
            this.addressLabel.Text = "-";
            // 
            // ageLabel
            // 
            this.ageLabel.AutoSize = true;
            this.ageLabel.Location = new System.Drawing.Point(703, 413);
            this.ageLabel.Name = "ageLabel";
            this.ageLabel.Size = new System.Drawing.Size(10, 13);
            this.ageLabel.TabIndex = 34;
            this.ageLabel.Text = "-";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(703, 374);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(10, 13);
            this.nameLabel.TabIndex = 33;
            this.nameLabel.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(587, 493);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "AmountOwed";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(587, 453);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(587, 413);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 30;
            this.label11.Text = "Age";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(587, 373);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 29;
            this.label12.Text = "Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(791, 347);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(78, 23);
            this.searchButton.TabIndex = 28;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(638, 349);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(139, 20);
            this.searchTextBox.TabIndex = 37;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 613);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.amountOwedLabel);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.ageLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.totalCustomersLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addCustomerButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.amountOwedTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.traverseLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.postOrderButton);
            this.Controls.Add(this.inOrderButton);
            this.Controls.Add(this.preOrderButton);
            this.Controls.Add(this.totalItemsLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.addNumberToTreeButton);
            this.Controls.Add(this.addNumberTextBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addNumberTextBox;
        private System.Windows.Forms.Button addNumberToTreeButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label totalItemsLabel;
        private System.Windows.Forms.Button preOrderButton;
        private System.Windows.Forms.Button inOrderButton;
        private System.Windows.Forms.Button postOrderButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label traverseLabel;
        private System.Windows.Forms.Label totalCustomersLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addCustomerButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox amountOwedTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label amountOwedLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label ageLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchTextBox;
    }
}

