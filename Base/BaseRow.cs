using System;
using System.Collections.Generic;

namespace Bai1.Base
{
    public abstract class BaseRow : IEntity
    {
        protected int id;
        protected string name;

        /*
         * Lấy Id của đối tượng
         */
        public virtual int GetId()
        {
            return id;
        }

        /*
         * Thay đổi Id của đối tượng
         */
        public virtual void SetId(int id)
        {
            this.id = id;
        }

        /*
         * Lấy Name của đối tượng
         */
        public virtual string GetName()
        {
            return name;
        }

        /*
         * Thay đổi Name của đối tượng
         */
        public virtual void SetName(string name)
        {
            this.name = name;
        }

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
