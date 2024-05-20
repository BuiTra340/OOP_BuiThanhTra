using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1.demo
{
    internal class ProductDemo : Product
    {
        public ProductDemo(int _id, string _name, int _category) : base(_id, _name, _category)
        {
             
        }
        public ProductDemo() { }
        public void createProductTest()
        {
            Console.Write("Enter id: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Enter name: ");
            name = Console.ReadLine();
            Console.Write("Enter category id: ");
            category = int.Parse(Console.ReadLine());
        }
        public void printProduct()
        {
            Console.WriteLine("id: "+ id);
            Console.WriteLine("name: "+ name);
            Console.WriteLine("category: "+ category);
        }
    }
}
