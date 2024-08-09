using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Model
{
    public class Customer
    {
        private int _customerId;
        private string _customerName;

        List<Order> orders = new List<Order>();
        public int CustomerId { get { return _customerId; } set { _customerId = value; } }
        public string CustomerName { get { return _customerName; } set { _customerName = value; } }

        public Customer(int id, string name)
        {
            _customerId = id;
            _customerName = name;

        }


    }
}
