using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class CustomerNode
    {
        private Customer data;
        public CustomerNode Left, Right;

        public CustomerNode(Customer item)
        {
            data = item;
            Left = null;
            Right = null;
        }

        public Customer Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
