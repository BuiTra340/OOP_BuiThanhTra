using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai1.demo
{
    public class ProductDemo : Product
    {
        public ProductDemo() { }

        /*
         * Tạo ra một đối tượng Product có đầy đủ thông tin
         */
        public Product CreateProductTest()
        {
            Product productTest = new Product(1,"product1",1);
            return productTest;
        }

        /*
         * Hiển thị thông tin của đối tượng Product vừa tạo
         */
        public void PrintData(Product product)
        {
            product.PrintData();
        }
    }
}
