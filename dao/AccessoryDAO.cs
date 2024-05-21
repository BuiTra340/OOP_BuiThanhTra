using Bai1.dao;
using System;

namespace Bai1.demo
{
    internal class AccessoryDAO
    {
        Database db;
        public AccessoryDAO()
        {
            db = new Database(1);
            db.accessoryTable[0] = new Accessory(1, "accessory1");
        }
        public int Insert(Accessory row) => db.InsertTable("accessory", row);
        public int Update(Accessory row) => db.UpdateTable("accessory", row);
        public bool Delete(Accessory row) => db.DeleteTable("accessory", row);
        public Array FindAll() => db.SelectTable("accessory", null);
        public object FindById(string name)
        {
            for (int i = 0; i < db.accessoryTable.Length; i++)
            {
                if (db.accessoryTable[i].name.Equals(string.Empty)) continue;
                if (db.accessoryTable[i].GetId().Equals(int.Parse(name)))
                    return db.accessoryTable[i];
            }
            return null;
        }
        public object FindByName(string name)
        {
            for (int i = 0; i < db.accessoryTable.Length; i++)
            {
                if (db.accessoryTable[i].name.Equals(string.Empty)) continue;
                if (db.accessoryTable[i].name.Equals(name))
                    return db.accessoryTable[i];
            }
            return null;
        }
    }
}
