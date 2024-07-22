using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerQueue
{
    internal class Customer
    {
        /*Customer attributes i.e members of the customer class*/
        public string name;
        public int age;
        public string address;
        public float amountOwed;

        public Customer(string name, int age, string address, float amountOwed)
        {
            Name = name;
            Age = age;
            Address = address;
            AmountOwed = amountOwed;
        }

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


        public string GetInformation()
        {
            return $"Name: {Name}, Age: {Age}, Address: {Address}, Amount Owed: {AmountOwed}";
        }

       

    }
    }

