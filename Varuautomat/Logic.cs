using System;
using System.Collections.Generic;
using System.Text;

namespace Varuautomat
{
    class Logic
    {
        public List<Item> ShoppingCart = new List<Item>();
        Products products = new Products();
        public void PrintShoppingCart()
        {
            foreach (Item item in ShoppingCart) { Console.WriteLine(item.name + item.price); }
        }

        public void ShowMoney()
        {
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("Money: " + money);
        }
        public int money;
        public int change;
        public int total;


        public int GetTotal()
        {
            foreach (Item item in ShoppingCart) { total += item.price; }
            return total;
        }
        public Logic()
        {
        }
        public void ShowStartMenu()
        {
            Console.Clear();
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
                    Console.WriteLine("Thank you for your purchase!");
                    break;
                case ConsoleKey.Q:
                    Environment.Exit(0);
                    break;
            }
        }

        public void ShowMoneyMenu()
        {
            Console.Clear();
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
        }
        public void ShowCategories()
        {
            Console.Clear();
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
                    products.ShowBeverages();
                    AddToCart(products.beverageList);
                    break;
                case ConsoleKey.D2:
                    products.ShowFoods();
                    AddToCart(products.foodList);
                    break;
                case ConsoleKey.D3:
                    products.ShowSnacks();
                    AddToCart(products.snacksList);
                    break;
                case ConsoleKey.Q:
                    ShowCategories();
                    break;
            }
        }
        public void AddToCart(List<Item> items)
        {
            var keyInput = Console.ReadKey();
            switch (keyInput.Key)
            {
                case ConsoleKey.D1:
                    if (money > GetTotal())
                    {
                        ShoppingCart.Add(items[0]);
                        money -= GetTotal();
                    }
                    break;
                case ConsoleKey.D2:
                    if (money > GetTotal())
                    {
                        ShoppingCart.Add(items[1]);
                        money -= GetTotal();
                    }
                    break;
                case ConsoleKey.D3:
                    if (money > GetTotal())
                    {
                        ShoppingCart.Add(items[2]);
                        money -= GetTotal();
                    }
                    break;
                case ConsoleKey.Q:
                    ChooseCategory();
                    break;
            }
        }
    }
}
