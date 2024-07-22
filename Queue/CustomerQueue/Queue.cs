using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerQueue
{
    internal class Queue
    {
        private Customer[] customers;
        private int tail = -1;
        private int count = 0;
        private int head = 0;
        private int size;

        public Customer[] Customers
        {
            get{
                return customers;
            }
        }

        public Queue(int size) {
            this.size = size;
            customers = new Customer[size];    
        }
        public void Enqueue(Customer customer)
        {
            if(count < size)
            {
                tail = (tail + 1) % size;
                customers[tail] = customer;
                count++;
                return;
            }
            throw new Exception("New Customers cannot be added because queue is filled");
        }
        public Customer Dequeue()
        {
            if (count != 0)
            {
                Customer customer = customers[head];
                customers[head] = null;
                head = (head + 1) % size;
                count--;
                return customer;
            }
            throw new Exception("All customers has been dequeued from");
        }

        public Customer Peek()
        {
            if(count > 0)
            {
                return customers[head];
            }
            throw new Exception("Customer Queue is empty.");
        }

        public float TotalAmountOwed()
        {
            float total = 0;
            for (int i = 0; i < size; i++)
            {
                if (customers[i] != null)
                {
                    total += customers[i].AmountOwed;
                }
            }
            return total;
        }

        public Customer BiggestDebtor()
        {
            if (count > 0)
            {
                Customer customer = null;
                float biggestAmountOwed = 0;

                for (int i = 0; i < size; i++)
                {
                    if (customers[i] != null)
                    {
                        Customer cus = (Customer)customers[i];
                        if (cus.AmountOwed > biggestAmountOwed)
                        {
                            biggestAmountOwed = cus.AmountOwed;
                            customer = cus;
                        }
                    }
                }
                return customer;
            }
            throw new Exception("Cannot get customer owing the biggest amount as queue is empty");
        }
    }
}
