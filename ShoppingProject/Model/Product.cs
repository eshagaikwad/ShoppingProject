using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingProject.Model
{
    public class Product
    {
        private int _productId;
        private string _productName;
        private double _productPrice;
        private double _productDiscountPrice;

        public int ProductId
        {
            get { return _productId; }
            set { _productId = value; }
        }
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        public double ProductPrice
        {
            get { return _productPrice; }
            set { _productPrice = value; }
        }
        public double ProductDiscountPrice
        {
            get { return _productDiscountPrice; }
            set { _productDiscountPrice = value; }
        }
        public Product(int ID, string name, double price, double discount)
        {
            _productId = ID;
            _productName = name;
            _productPrice = price;
            _productDiscountPrice = discount;
        }

        public double GetDiscountPrice(double price, double discount)
        {

            double afterDiscount = price - price * discount / 100;
            return afterDiscount;

        }
    }
}

