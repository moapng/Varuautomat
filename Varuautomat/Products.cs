using System;
using System.Collections.Generic;
using System.Text;

namespace Varuautomat
{
     class Products
    {
        public List<Item> beverageList = new List<Item> 
            {
                new Item("1. Fanta", 12),
                new Item("2. Sprite", 14),
                new Item("3. Julmust", 16)
            };
        public List<Item> foodList = new List<Item>
            {
                new Item("1. Smörgås", 20),
                new Item("2. Wrap", 25),
                new Item("3. Nudlar", 6)
            };
        public List<Item> snacksList = new List<Item>
            {
                new Item("1. Äpple", 4),
                new Item("2. Muffin", 13),
                new Item("3. Knäckebröd", 9)
            };
        public void ShowBeverages() { foreach (Item item in beverageList) { Console.WriteLine(item.name + " " + item.price + ":-"); } }
        public void ShowFoods() { foreach (Item item in foodList) { Console.WriteLine(item.name + " " + item.price + ":-"); } }
        public void ShowSnacks() { foreach (Item item in snacksList) { Console.WriteLine(item.name + " " + item.price + ":-"); } }
    }
}
