using System;
using System.Collections.Generic;
using System.Text;

namespace Classes_Exercise_01
{
    public class Product
    {
        private long _productID;
        private int _productCount;

        public Product()
        {
            _productCount++;
        }

        public Product(long productID, string name, double price, int categoryID, bool onSale, int stockLevel)
        {
            _productID = productID;
            _productCount++;
            Name = name;
            Price = price;
            CategoryID = categoryID;
            OnSale = onSale;
            StockLevel = stockLevel;
        }

        public string Name { get; set; }
        public double Price { get; set; }
        public int CategoryID { get; set; }
        public bool OnSale { get; set; }
        public int StockLevel { get; set; }

        public long GetProductId()
        {
            return _productID;
        }

        public long SetProductId(long productId)
        {
            _productID = productId;
            return _productID;
        }

        public long GetProductCount()
        {
            return _productCount;
        }
    }
}
