namespace CustomerQueue
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
            this.nameForm = new System.Windows.Forms.TextBox();
            this.ageForm = new System.Windows.Forms.TextBox();
            this.addressForm = new System.Windows.Forms.TextBox();
            this.enqueueBtn = new System.Windows.Forms.Button();
            this.dequeueBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.amountOwedForm = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.customersTable = new System.Windows.Forms.DataGridView();
            this.biggestDebtorBtn = new System.Windows.Forms.Button();
            this.peekBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersTable)).BeginInit();
            this.SuspendLayout();
            // 
            // nameForm
            // 
            this.nameForm.Location = new System.Drawing.Point(14, 53);
            this.nameForm.Name = "nameForm";
            this.nameForm.Size = new System.Drawing.Size(228, 20);
            this.nameForm.TabIndex = 0;
            this.nameForm.TextChanged += new System.EventHandler(this.nameForm_textBox);
            // 
            // ageForm
            // 
            this.ageForm.Location = new System.Drawing.Point(14, 101);
            this.ageForm.Name = "ageForm";
            this.ageForm.Size = new System.Drawing.Size(228, 20);
            this.ageForm.TabIndex = 1;
            this.ageForm.TextChanged += new System.EventHandler(this.ageForm_textBox);
            // 
            // addressForm
            // 
            this.addressForm.Location = new System.Drawing.Point(14, 148);
            this.addressForm.Multiline = true;
            this.addressForm.Name = "addressForm";
            this.addressForm.Size = new System.Drawing.Size(228, 55);
            this.addressForm.TabIndex = 2;
            this.addressForm.TextChanged += new System.EventHandler(this.addressForm_textBox);
            // 
            // enqueueBtn
            // 
            this.enqueueBtn.BackColor = System.Drawing.Color.DarkSlateGray;
            this.enqueueBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enqueueBtn.ForeColor = System.Drawing.Color.Transparent;
            this.enqueueBtn.Location = new System.Drawing.Point(14, 280);
            this.enqueueBtn.Name = "enqueueBtn";
            this.enqueueBtn.Size = new System.Drawing.Size(108, 23);
            this.enqueueBtn.TabIndex = 3;
            this.enqueueBtn.Text = "Enqueue Customer";
            this.enqueueBtn.UseVisualStyleBackColor = false;
            this.enqueueBtn.Click += new System.EventHandler(this.enqueueBtnClick);
            // 
            // dequeueBtn
            // 
            this.dequeueBtn.BackColor = System.Drawing.Color.Crimson;
            this.dequeueBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.dequeueBtn.Location = new System.Drawing.Point(408, 437);
            this.dequeueBtn.Name = "dequeueBtn";
            this.dequeueBtn.Size = new System.Drawing.Size(108, 23);
            this.dequeueBtn.TabIndex = 4;
            this.dequeueBtn.Text = "Dequeue Customer";
            this.dequeueBtn.UseVisualStyleBackColor = false;
            this.dequeueBtn.Click += new System.EventHandler(this.dequeueBtnClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Total Amount Owed:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label2.Location = new System.Drawing.Point(11, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(248, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter Customer Details to Enqueue";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.label3.Location = new System.Drawing.Point(16, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Customer List:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 12);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label8);
            this.splitContainer1.Panel1.Controls.Add(this.addressForm);
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.ageForm);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.amountOwedForm);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.enqueueBtn);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.nameForm);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.customersTable);
            this.splitContainer1.Panel2.Controls.Add(this.biggestDebtorBtn);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.peekBtn);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.dequeueBtn);
            this.splitContainer1.Size = new System.Drawing.Size(837, 617);
            this.splitContainer1.SplitterDistance = 297;
            this.splitContainer1.TabIndex = 11;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label8.Location = new System.Drawing.Point(11, 213);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Customer Amount Owed:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label7.Location = new System.Drawing.Point(11, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Customer Address:";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label6.Location = new System.Drawing.Point(11, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Customer Age:";
            // 
            // amountOwedForm
            // 
            this.amountOwedForm.Location = new System.Drawing.Point(14, 226);
            this.amountOwedForm.Name = "amountOwedForm";
            this.amountOwedForm.Size = new System.Drawing.Size(228, 20);
            this.amountOwedForm.TabIndex = 8;
            this.amountOwedForm.TextChanged += new System.EventHandler(this.amountOwedForm_textBox);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightSlateGray;
            this.label5.Location = new System.Drawing.Point(11, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Customer Name:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // customersTable
            // 
            this.customersTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersTable.Location = new System.Drawing.Point(19, 88);
            this.customersTable.Name = "customersTable";
            this.customersTable.Size = new System.Drawing.Size(497, 331);
            this.customersTable.TabIndex = 16;
            this.customersTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersTable_CellContentClick);
            // 
            // biggestDebtorBtn
            // 
            this.biggestDebtorBtn.BackColor = System.Drawing.Color.DimGray;
            this.biggestDebtorBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.biggestDebtorBtn.Location = new System.Drawing.Point(223, 437);
            this.biggestDebtorBtn.Name = "biggestDebtorBtn";
            this.biggestDebtorBtn.Size = new System.Drawing.Size(108, 23);
            this.biggestDebtorBtn.TabIndex = 15;
            this.biggestDebtorBtn.Text = "Biggest Debtor";
            this.biggestDebtorBtn.UseVisualStyleBackColor = false;
            this.biggestDebtorBtn.Click += new System.EventHandler(this.BiggestDebtorBtnClick);
            // 
            // peekBtn
            // 
            this.peekBtn.BackColor = System.Drawing.Color.LightSlateGray;
            this.peekBtn.ForeColor = System.Drawing.SystemColors.Info;
            this.peekBtn.Location = new System.Drawing.Point(19, 437);
            this.peekBtn.Name = "peekBtn";
            this.peekBtn.Size = new System.Drawing.Size(108, 23);
            this.peekBtn.TabIndex = 14;
            this.peekBtn.Text = "Peek Customer";
            this.peekBtn.UseVisualStyleBackColor = false;
            this.peekBtn.Click += new System.EventHandler(this.PeekBtnClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1089, 651);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.customersTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameForm;
        private System.Windows.Forms.TextBox ageForm;
        private System.Windows.Forms.TextBox addressForm;
        private System.Windows.Forms.Button enqueueBtn;
        private System.Windows.Forms.Button dequeueBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox amountOwedForm;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button biggestDebtorBtn;
        private System.Windows.Forms.Button peekBtn;
        private System.Windows.Forms.DataGridView customersTable;
    }
}

