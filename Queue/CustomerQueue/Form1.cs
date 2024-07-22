using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerQueue
{
    public partial class Form1 : Form
    {
        private Queue customerQueue;
        public Form1()
        {
            customerQueue = new Queue(10);
            InitializeComponent();
        }
        /*Total Amount Owed*/
        private void label1_Click(object sender, EventArgs e){}

        /*Enqueue button*/
        private void enqueueBtnClick(object sender, EventArgs e)
        {
            try
            {
                if (this.nameForm.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter customer's name");
                    return;
                }
                if (this.ageForm.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter customer's age");
                    return;
                }
                if (this.addressForm.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter customer's address");
                    return;
                }
                if (this.amountOwedForm.Text.Trim() == "")
                {
                    MessageBox.Show("Please enter customer's amount owned");
                    return;
                }
                float amountOwed = 0;
                float.TryParse(this.amountOwedForm.Text, out amountOwed);
                Customer newCustomer = new Customer(this.nameForm.Text, int.Parse(this.ageForm.Text), this.addressForm.Text, int.Parse(this.amountOwedForm.Text));
                customerQueue.Enqueue(newCustomer);
                this.nameForm.Text = "";
                this.ageForm.Text = "";
                this.addressForm.Text = "";
                this.amountOwedForm.Text = "";
                StartCustomerTableData();
                MessageBox.Show($"Customer has been enqueued successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /*Dequeue button*/
        private void dequeueBtnClick(object sender, EventArgs e)
        {
            try
            {
                Customer customer = customerQueue.Dequeue();
                StartCustomerTableData();
                MessageBox.Show($"The Customer: {customer.Name} has been dequeued successfully");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void nameForm_textBox(object sender, EventArgs e){}

        private void ageForm_textBox(object sender, EventArgs e){}

        private void addressForm_textBox(object sender, EventArgs e){}

        private void amountOwedForm_textBox(object sender, EventArgs e){}

        private void Form1_Load(object sender, EventArgs e){}
        /*Peek button*/
        private void PeekBtnClick(object sender, EventArgs e)
        {
            try
            {
                Customer customer = customerQueue.Peek();
                MessageBox.Show(customer.GetInformation());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*Biggest Debtor button*/
        private void BiggestDebtorBtnClick(object sender, EventArgs e)
        {
            try
            {
                Customer customer = customerQueue.BiggestDebtor();
                MessageBox.Show(customer.GetInformation());
            }
            catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        public void StartCustomerTableData()
        {
            if (customersTable.Columns.Count > 0)
            {
                customersTable.Columns.Clear();
            }
            var dataTab = new DataTable();
            customersTable.DataSource = dataTab;
            dataTab.Columns.Add("Name", typeof(string));
            dataTab.Columns.Add("Age", typeof(int));
            dataTab.Columns.Add("Address", typeof(string));
            dataTab.Columns.Add("Amount Owed", typeof(float));
            label1.Text = $"Total Amount Owed: {customerQueue.TotalAmountOwed()}";
            foreach (Customer customer in customerQueue.Customers)
                if (customer != null)
                    dataTab.Rows.Add(customer.Name, customer.Age, customer.Address, customer.AmountOwed);
        }

        private void label2_Click(object sender, EventArgs e){}
        private void label3_Click(object sender, EventArgs e){}
        private void label5_Click(object sender, EventArgs e){}
        private void label8_Click(object sender, EventArgs e){}
        private void label7_Click(object sender, EventArgs e){}

        private void customersTable_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}