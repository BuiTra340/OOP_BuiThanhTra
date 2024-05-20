using Bai1.dao;
using Bai1.demo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProductDemo product = new ProductDemo();
            //product.createProductTest();
            //product.printProduct();

            Database database = new Database(1);
            database.productTable[0] = new Product(1, "pro1", 1);
            string name = "product";
            Product product = new Product(1,"pro2",2);

            //Console.WriteLine("Insert 1:success, 0: fail -----> "+database.insertTable(name, product));
            //Console.WriteLine("Select " + database.selectTable(name,product));
            //Console.WriteLine("Update " + database.updateTable(name, product));
            //Console.WriteLine("Delete " + database.deleteTable(name, product));


            database.truncateTable(name);
            Console.WriteLine("After Truncate Length = " + database.productTable.Length);
            Console.ReadKey();
        }
    }
}
