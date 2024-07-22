using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySearchTree
{
    public partial class Form1 : Form
    {
        private IntBinarySearchTree intBST;
        private CustomerBinarySearchTree custBST;
        public Form1()
        {
            InitializeComponent();
            intBST = new IntBinarySearchTree();
            custBST = new CustomerBinarySearchTree();
        }

        private void addNumberToTreeButton_Click(object sender, EventArgs e)
        {
            string text = addNumberTextBox.Text;
            if(text == "")
            {
                return;
            }
            addNumberTextBox.Text = "";
            int number = Convert.ToInt32(text);
            intBST.InsertInt(number);
            totalItemsLabel.Text = intBST.Count().ToString();
        }

        private void preOrderButton_Click(object sender, EventArgs e)
        {
            traverseLabel.Text = intBST.PreOrder();
        }

        private void inOrderButton_Click(object sender, EventArgs e)
        {
            traverseLabel.Text = intBST.InOrder();
        }

        private void postOrderButton_Click(object sender, EventArgs e)
        {
            traverseLabel.Text = intBST.PostOrder();
        }

        private void addCustomerButton_Click(object sender, EventArgs e)
        {
            if (ageTextBox.Text == "" || amountOwedTextBox.Text == "")
            {
                return;
            }
            string name = nameTextBox.Text;
            int age = Convert.ToInt32(ageTextBox.Text);
            string address = addressTextBox.Text;
            float amountOwed = Convert.ToSingle(amountOwedTextBox.Text);

            Customer customer = new Customer(name, age, address, amountOwed);
            int countBeforeInsert = custBST.Count();
            custBST.InsertCustomer(customer);
            int countAfterInsert = custBST.Count();

            if(countBeforeInsert == countAfterInsert)
            {
                return;
            }

            nameTextBox.Text = "";
            ageTextBox.Text = "";
            addressTextBox.Text = "";
            amountOwedTextBox.Text = "";

            totalCustomersLabel.Text = countAfterInsert.ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if(searchTextBox.Text == "")
            {
                return;
            }
            string searchText = searchTextBox.Text;
            Customer customer = custBST.FindCustomerByName(searchText);
            if(customer == null)
            {
                FillInLabelTexts("", "", "", "");
                return;
            }

            FillInLabelTexts(customer.Name, customer.Age.ToString(), customer.Address, customer.AmountOwed.ToString());
        }

        private void FillInLabelTexts(string name, string age, string address, string amountOwed)
        {
            nameLabel.Text = name;
            ageLabel.Text = age;
            addressLabel.Text = address;
            amountOwedLabel.Text = amountOwed;
        }
    }
}
