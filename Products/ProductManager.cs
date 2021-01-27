using System;
using System.Collections.Generic;
using System.Text;

namespace Products
{
   public class ProductManager
    {
        //CRUD Create,Read,Update,Delete
        public void Add(Products products) {

            Console.WriteLine(products.Name + " eklendi."+
                "\nDescrition: "+products.Description+
                "\nPrice: " + products.UnitInPrice);
        }
        public int Remove(Products products) {
            products.UnitInStock = products.UnitInStock - 1;
            Console.WriteLine(products.Name +" ürünü için stok güncellendi. Yeni stok sayısı: " + products.UnitInStock);
            return products.UnitInStock;
        }
    }
}
