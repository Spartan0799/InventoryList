using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryList
{
    class Program
    {

        public class Items
        {
            public string name;
            public int pos;
            public Items next = null;

            public Items(string name, int pos)
            {
                this.name = name;
                this.pos = pos;
                
            }
        }
        static void Main(string[] args)
        {

            Items Item1 = new Items("Knife", 0);
            Items Item2 = new Items("Arrow", 1);
            Items Item3 = new Items("Dagger", 2);
            Items Item4 = new Items("Whip", 3);
            Items Item5 = new Items("Shield", 4);
            Items Item6 = new Items("Spear", 5);
            Items Item7 = new Items("Sword", 6);
            Items Item8 = new Items("Rapier", 7);
            Items Item9 = new Items("Stick", 8);
            Items Item10 = new Items("Ballast", 9);

            Item1.next = Item2;
            Item2.next = Item3;
            Item3.next = Item4;
            Item4.next = Item5;
            Item5.next = Item6;
            Item6.next = Item7;
            Item7.next = Item8;
            Item8.next = Item9;
            Item9.next = Item10;


            Console.WriteLine("Inventory items: Knife, Arrow, Dagger, Whip, Shield, Spear, Sword, Rapier, Stick and Ballast");
            Console.WriteLine("Type the item you want to pick up");
            string ItemToSearch = Console.ReadLine();
            Items currentItem = Item1;
            Items previousItem;

                    while (currentItem != null)
                    {
                        if (ItemToSearch == currentItem.name)
                        {
                            Console.WriteLine("The item has been found, his position is " + currentItem.pos);
                            break;
                        }
                        else
                        {
                            Console.WriteLine(ItemToSearch + " isn't " + currentItem.name);
                        }

                        previousItem = currentItem;
                        currentItem = currentItem.next;
                    }

            Console.ReadKey();
        }
    }
}
