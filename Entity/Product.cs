using Bai1.Base;
using System;
namespace Bai1
{
    public class Product : BaseRow
    {
        public int categoryId;
        public Product(int id, string name, int categoryId)
        {
            SetId(id);
            SetName(name);
            this.categoryId = categoryId;
        }
        public Product() { }

        /*
         * Lấy giá trị CategoryId của đối tượng Product
         */
        public int GetCategoryId()
        {
            return categoryId;
        }

        /*
         * Thay đổi CategoryId của đối tượng Product
         */
        public void SetCategoryId(int CategoryId)
        {
            this.categoryId = CategoryId;
        }

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
