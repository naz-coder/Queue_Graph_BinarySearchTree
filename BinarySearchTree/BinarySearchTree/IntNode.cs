using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class IntNode
    {
        private int data;
        public IntNode Left, Right;

        public IntNode(int item)
        {
            data = item;
            Left = null;
            Right = null;
        }

        public int Data
        {
            get { return data; }
            set { data = value; }
        }
    }
}
