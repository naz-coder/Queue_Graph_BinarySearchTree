using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class IntBinarySearchTree
    {
        private IntNode root;
        public IntBinarySearchTree()
        {
            root = null;
        }

        public IntBinarySearchTree(IntNode node)
        {
            root = node;
        }

        public void InsertInt(int item)
        {
            InsertIntNode(item, ref root);
        }

        private void InsertIntNode(int item, ref IntNode node)
        {
            if(node == null)
            {
                node = new IntNode(item);
            }
            else if(item < node.Data)
            {
                InsertIntNode(item, ref node.Left);
            }
            else if(item > node.Data)
            {
                InsertIntNode(item, ref node.Right);
            }
        }

        public int Count()
        {
            return Count(root);
        }

        private int Count(IntNode node)
        {
            if(node == null)
            {
                return 0;
            }
            return Count(node.Left) + Count(node.Right) + 1;
        }

        public string PreOrder()
        {
            return PreOrder(root);
        }

        private string PreOrder(IntNode node)
        {
            string result = "";
            if (node == null)
            {
                return "";
            }
            result += $"{node.Data}, ";
            result += PreOrder(node.Left);
            result += PreOrder(node.Right);
            return result;
        }

        public string InOrder()
        {
            return InOrder(root);
        }

        private string InOrder(IntNode node)
        {
            string result = "";
            if(node == null)
            {
                return "";
            }
            result += InOrder(node.Left);
            result += $"{node.Data}, ";
            result += InOrder(node.Right);
            return result;
        }

        public string PostOrder()
        {
            return PostOrder(root);
        }

        private string PostOrder(IntNode node)
        {
            string result = "";
            if(node == null)
            {
                return "";
            }
            result += PostOrder(node.Left);
            result += PostOrder(node.Right);
            result += $"{node.Data}, ";
            return result;
        }
    }
}
