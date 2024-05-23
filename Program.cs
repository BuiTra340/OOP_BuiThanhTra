using Bai1.dao;
using Bai1.demo;
using System;

namespace Bai1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Database db = Database.InitializeDatabase(5);
            Accessory accessory2 = new Accessory(2, "New Accessory2");
            Accessory accessory3 = new Accessory(3, "New Accessory3");
            AccessoryDaoDemo accessoryDaoDemo = new AccessoryDaoDemo();
            Console.WriteLine("Data Origin ---------------");
            for (int i = 0; i < db.accessoryTable.Length; i++)
                db.accessoryTable[i].PrintData();

            Console.WriteLine("Insert 2 Object ---------------");
            Database db2 = Database.InitializeDatabase(5);
            accessoryDaoDemo.InsertTest(accessory2);
            accessoryDaoDemo.InsertTest(accessory3);
            Console.WriteLine("aaaa " + db.accessoryTable.Length);
            Console.WriteLine("aaaa " + db2.accessoryTable.Length);
            for (int i = 0; i < db.accessoryTable.Length; i++)
                db.accessoryTable[i].PrintData();

            Console.WriteLine("Update Object index 3---------------");
            Accessory accessoryUpdate = new Accessory(2, "New Update");
            accessoryDaoDemo.UpdateTest(accessoryUpdate);
            for (int i = 0; i < db.accessoryTable.Length; i++)
                db.accessoryTable[i].PrintData();

            Console.WriteLine("Delete 1 Object index 5---------------");
            Accessory accessoryDelete = new Accessory(4, "Delete");
            accessoryDaoDemo.DeleteTest(accessoryDelete);
            for (int i = 0; i < db.accessoryTable.Length; i++)
                db.accessoryTable[i].PrintData();

            Console.WriteLine("Find All ---------------");
            Accessory[] allAccessories = accessoryDaoDemo.FindAllTest(accessory2) as Accessory[];
            for (int i = 0; i < allAccessories.Length; i++)
                allAccessories[i].PrintData();

            Console.WriteLine("Find By Id 3---------------");
            object currentObject = accessoryDaoDemo.FindByIdTest(3, accessory2);
            checkAndShowObject(currentObject);

            Console.WriteLine("Find By Name accessory1---------------");
            currentObject = accessoryDaoDemo.FindByNameTest("accessory1", accessory2);
            checkAndShowObject(currentObject);
            Console.ReadKey();
        }

        static void checkAndShowObject(object currentObject)
        {
            if (currentObject == null)
            {
                Console.WriteLine("can't find objet");
                return;
            }
            if (currentObject is Category category)
                category.PrintData();
            else if (currentObject is Product product)
                product.PrintData();
            else if (currentObject is Accessory accessory)
                accessory.PrintData();
        }
    }
}
