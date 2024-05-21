using System;
using Bai1.Base;

namespace Bai1
{
    internal class Accessory : BaseRow
    {
        public int id;
        public string name;
        public Accessory(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public Accessory() { }

        public override void PrintData()
        {
            Console.WriteLine("id: " + id);
            Console.WriteLine("name: " + name);
        }

        public override int GetId() => id;

        public override void SetId(int _id) => id = _id;
    }
}
