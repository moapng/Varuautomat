using System;
using System.Collections.Generic;
using System.Text;

namespace Varuautomat
{
    class Logic
    {
        public List<Item> ShoppingCart = new List<Item>();
        Program prog = new Program();
        public int money;
        public Logic()
        {
        }
        public void ShowStartMenu()
        {
            Console.WriteLine("1. Add Money \n" +
                "2. Choose Product Category \n" +
                "3. Pay \n" +
                "Q. Quit");
        }
        public void StartMenu()
        {
            var keyInput = Console.ReadKey();
            switch (keyInput.Key)
            {
                case ConsoleKey.D1:
                    ShowMoneyMenu();
                    MoneyMenu();
                    break;
                case ConsoleKey.D2:
                    ShowCategories();
                    ChooseCategory();
                    break;
                case ConsoleKey.D3:
                    break;
                case ConsoleKey.Q:
                    break;
            }
        }

        public void ShowMoneyMenu()
        {
            Console.WriteLine("Choose desired amount: ");
            Console.WriteLine("1. 1 \n" +
                "2. 2 \n" +
                "3. 5 \n" +
                "4. 10 \n" +
                "5. 20 \n" +
                "6. 50 \n" +
                "Q. Quit");
        }
        public void MoneyMenu()
        {
            var keyInput = Console.ReadKey();
            do
            {
                switch (keyInput.Key)
                {
                    case ConsoleKey.D1:
                        money += 1;
                        break;
                    case ConsoleKey.D2:
                        money += 2;
                        break;
                    case ConsoleKey.D3:
                        money += 5;
                        break;
                    case ConsoleKey.D4:
                        money += 10;
                        break;
                    case ConsoleKey.D5:
                        money += 20;
                        break;
                    case ConsoleKey.D6:
                        money += 50;
                        break;

                }
            } while (keyInput.Key != ConsoleKey.Q);
        }
        public void ShowCategories()
        {
            Console.WriteLine("Please choose a category: ");
            Console.WriteLine("1. Beverages \n" +
                "2. Food \n" +
                "3. Snacks \n" +
                "Q. Quit");
        }
        public void ChooseCategory()
        {
            var keyInput = Console.ReadKey();
            switch (keyInput.Key)
            {
                case ConsoleKey.D1:
                    prog.ShowBeverages();
                    break;
                case ConsoleKey.D2:
                    prog.ShowFoods();
                    break;
                case ConsoleKey.D3:
                    prog.ShowSnacks();
                    break;
                case ConsoleKey.Q:
                    ShowCategories();
                    break;
            }
        }
        public void AddToCart()
        {
            var keyInput = Console.ReadKey();
            switch (keyInput.Key)
            {
                case ConsoleKey.D1: //aidsss
                    break;
                case ConsoleKey.D2:
                    break;
                case ConsoleKey.D3:
                    break;
                case ConsoleKey.Q:
                    break;
            }
        }
    }
}
