using System;

namespace Products
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Products hat = new Products();
            hat.Name = "Hat";
            hat.Description = "Hat";
            hat.UnitInPrice = 5.9;
            hat.UnitInStock = 5;

            Products atkı = new Products();
            atkı.Name = "atkı";
            atkı.Description = "atkı";
            atkı.UnitInPrice = 9;
            atkı.UnitInStock = 12;


            ProductManager productManager = new ProductManager();
            //productManager.Add(atkı);
            for (int i = 0; i < 2; i++) {
                atkı.UnitInStock = productManager.Remove(atkı);
            }


        }
    }
}
