using System;
using Bai1.Base;

namespace Bai1
{
    public class Category : BaseRow
    {
        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Category() { }
    }
}
