using Bai1.Base;
using System;
namespace Bai1
{
    public class Product : BaseRow
    {
        public int categoryId { get;set; }
        public Product(int id, string name, int categoryId)
        {
            this.id = id;
            this.name = name;
            this.categoryId = categoryId;
        }
        public Product() { }

        /*
         * Hiển thị thông tin của đối tượng Product
         */
        public override void PrintData()
        {
            base.PrintData();
            Console.WriteLine("categoryId: " + categoryId);
        }
    }
}
