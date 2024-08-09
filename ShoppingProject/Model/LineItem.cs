using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Model
{
    public class LineItem
    {
        private int _id;
        private int _quantity;
        public Product Product;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public int quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        public LineItem(int id, int quantity, Product product)
        {
            _id = id;
            _quantity = quantity;
            Product = product;
        }

        public static double CalculateLineItemCost(LineItem item)
        {
            double result = item.Product.GetDiscountPrice(item.Product.ProductPrice, item.Product.ProductDiscountPrice) * item.quantity;
            return result;

        }


    }
}
