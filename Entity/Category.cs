using System;
using Bai1.Base;

namespace Bai1
{
    internal class Category : BaseRow
    {
        public int id;
        public string name;
        public Category(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Category() { }

        public override void PrintData()
        {
            Console.WriteLine("id: " + id);
            Console.WriteLine("name: " + name);
        }

        public override int GetId() => id;

        public override void SetId(int _id) => id = _id;
    }
}
