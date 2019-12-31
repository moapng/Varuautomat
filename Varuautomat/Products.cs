using System;
using System.Collections.Generic;
using System.Text;

namespace Varuautomat
{
    class Products
    {
        public List<Item> beverageList = new List<Item>
            {
                new Item("Fanta", 12),
                new Item("Sprite", 14),
                new Item("Julmust", 16)
            };
        public List<Item> foodList = new List<Item>
            {
                new Item("Smörgås", 20),
                new Item("Wrap", 25),
                new Item("Nudlar", 6)
            };
        public List<Item> snacksList = new List<Item>
            {
                new Item("Äpple", 4),
                new Item("Muffin", 13),
                new Item("Knäckebröd", 9)
            };
        public void ShowBeverages()
        {
            int i = 1;
            Console.Clear();
            Console.WriteLine("Please Choose an Item: ");
            foreach (Item item in beverageList) { Console.WriteLine(i + " " + item.name + " " + item.price + ":-"); i++; }
        }
        public void ShowFoods()
        {
            int i = 1;
            Console.Clear();
            Console.WriteLine("Please Choose an Item: ");
            foreach (Item item in foodList) { Console.WriteLine(i + " " + item.name + " " + item.price + ":-"); i++; }
        }
        public void ShowSnacks()
        {
            int i = 1;
            Console.Clear();
            Console.WriteLine("Please Choose an Item: ");
            foreach (Item item in snacksList) { Console.WriteLine(i + " " + item.name + " " + item.price + ":-"); i++; }
        }
    }
}
