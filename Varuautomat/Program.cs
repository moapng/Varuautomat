using System;
using System.Collections;
using System.Collections.Generic;

namespace Varuautomat
{
    class Program
    {
        Logic logic = new Logic();

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
        public void Main(string[] args)
        {
            do
            {
                logic.ShowStartMenu();
                logic.StartMenu();
            } while (true); //testing loop
        }
        public void ShowBeverages() { foreach (Item item in beverageList) { Console.WriteLine(item.name + " " + item.price + ":-"); } }
        public void ShowFoods() { foreach (Item item in foodList) { Console.WriteLine(item.name + " " + item.price + ":-"); } }
        public void ShowSnacks() { foreach (Item item in snacksList) { Console.WriteLine(item.name + " " + item.price + ":-"); } }


    }
}
