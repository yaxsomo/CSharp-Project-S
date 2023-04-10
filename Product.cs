using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcomDesktop
{
    internal class Product
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string Suppliers { get; set; }
        public string Category { get; set; }


        public Product(int myId,string myName, float myPrice, int myQuantity, string mySupplier, string myCategory)
        {
            Id = myId;
            Name = myName;
            Price = myPrice;
            Quantity = myQuantity;
            Suppliers = mySupplier;
            Category = myCategory;

        }


    }
}
