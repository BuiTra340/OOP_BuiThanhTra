using System;
using System.Collections.Generic;

namespace Bai1.Base
{
    public abstract class BaseRow : IEntity
    {
        public int id { get; set; }
        public string name{ get; set; }

        /*
         * Hiển thị Id và Name của đối tượng
         */
        public virtual void PrintData()
        {
            Console.WriteLine("Id: " + id);
            Console.WriteLine("Name: "+ name);
        }
    }
}
