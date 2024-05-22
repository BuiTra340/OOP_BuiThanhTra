using System;
using Bai1.Base;

namespace Bai1
{
    public class Accessory : BaseRow
    {
        public Accessory(int id, string name)
        {
            SetId(id);
            SetName(name);
        }
        public Accessory() { }
    }
}
