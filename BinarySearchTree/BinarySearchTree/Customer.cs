using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Customer : IComparable
    {
        private string name;
        private int age;
        private string address;
        private float amountOwed;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public float AmountOwed
        {
            get { return amountOwed; }
            set { amountOwed = value; }
        }

        public Customer(string name, int age, string address, float amountOwed)
        {
            Name = name;
            Age = age;
            Address = address;
            AmountOwed = amountOwed;
        }

        public string GetInformation()
        {
            return $"Customer {name} is {age} years old and lives at {address}. He owes {amountOwed}";
        }

        public int CompareTo(object obj)
        {
            Customer otherCustomer = obj as Customer;
            return name.CompareTo(otherCustomer.Name);
        }
    }
}
