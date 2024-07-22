using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class CustomerBinarySearchTree
    {
        private CustomerNode root;
        
        public CustomerBinarySearchTree()
        {
            root = null;
        }

        public CustomerBinarySearchTree(CustomerNode node)
        {
            root = node;
        }

        public void InsertCustomer(Customer customer)
        {
            InsertCustomerNode(customer, ref root);
        }

        private void InsertCustomerNode(Customer customer, ref CustomerNode node)
        {
            if(node == null)
            {
                node = new CustomerNode(customer);
            }
            else if(customer.CompareTo(node.Data) < 0)
            {
                InsertCustomerNode(customer, ref node.Left);
            }
            else if(customer.CompareTo(node.Data) > 0)
            {
                InsertCustomerNode(customer, ref node.Right);
            }
        }

        public int Count()
        {
            return Count(root);
        }

        private int Count(CustomerNode node)
        {
            if (node == null)
            {
                return 0;
            }
            return Count(node.Left) + Count(node.Right) + 1;
        }

        public Customer FindCustomerByName(string name)
        {
            return FindCustomerByName(name, root);
        }

        private Customer FindCustomerByName(string name, CustomerNode node)
        {
            Customer customer;
            if(node == null)
            {
                customer = null;
            }
            else if(name.CompareTo(node.Data.Name) < 0)
            {
                customer = FindCustomerByName(name, node.Left);
            }
            else if(name.CompareTo(node.Data.Name) > 0)
            {
                customer = FindCustomerByName(name, node.Right);
            }
            else
            {
                customer = node.Data;
            }
            return customer;
        }
    }
}
