using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Model
{
    public class Order
    {
        private int _id;
        private DateTime _date;

        private List<LineItem> _items = new List<LineItem>();

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public DateTime Date
        {
            get { return _date; }
            set { _date = value; }
        }

        public List<LineItem> Items
        {
            get { return _items; }
            set { _items = value; }

        }

        public Order(int id, DateTime date)
        {
            _id = id;
            _date = date;

        }

        public void AddItem(LineItem item)
        {
            _items.Add(item);
        }

        public double CalculateOrderPrice()
        {
            double orderPrice = 0;
            foreach (var item in Items)
            {
                orderPrice += LineItem.CalculateLineItemCost(item);

            }
            return orderPrice;

        }




    }
}
