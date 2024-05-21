﻿using Bai1.Base;
using System;
namespace Bai1
{
    internal class Product : BaseRow
    {
        public int id;
        public string name;
        public int category;
        public Product(int _id, string _name, int _category)
        {
            id = _id;
            name = _name;
            category = _category;
        }
        public Product() { }

        public override void PrintData()
        {
            Console.WriteLine("id: " + id);
            Console.WriteLine("name: " + name);
            Console.WriteLine("categoryId: " + category);
        }

        public override int GetId() => id;

        public override void SetId(int _id) => id = _id;
    }
}
