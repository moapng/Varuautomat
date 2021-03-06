﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Varuautomat
{
    class Logic
    {
        // does not show error message when not enough money correctly...

        public List<Item> ShoppingCart = new List<Item>();
        Products products = new Products();
        public int money = 20;

        public void PrintShoppingCart()
        {
            foreach (Item item in ShoppingCart) { Console.WriteLine(item.name + " " + item.price + ":-"); }
        }

        public void ShowMoney()
        {
            Console.SetCursorPosition(10, 10);
            Console.WriteLine("Money: " + money);
            Console.SetCursorPosition(0, 0);
        }
        public int GetPrice(int price)
        {
            return price;
        }
        public void Clear()
        {
            Console.Clear();
            Console.WriteLine("You don't have enough money, press Enter to continue shopping");
            var keyInput = Console.ReadKey();
            if (keyInput.Key == ConsoleKey.Enter) { Console.Clear(); }
        }

        public void StartMenu()
        {
            Console.Clear();
            ShowMoney();

            Console.WriteLine("1. Add Money \n" +
                "2. Choose Product Category \n" +
                "3. Pay \n" +
                "Q. Quit");
            var keyInput = Console.ReadKey();
            switch (keyInput.Key)
            {
                case ConsoleKey.D1:
                    MoneyMenu();
                    break;
                case ConsoleKey.D2:
                    ChooseCategory();
                    break;
                case ConsoleKey.D3:
                    Payment();
                    break;
                case ConsoleKey.Q:
                    Environment.Exit(0);
                    break;
            }
        }
        public void MoneyMenu()
        {
            Console.Clear();
            ShowMoney();
            Console.WriteLine("Choose desired amount: ");
            Console.WriteLine("1. 1 \n" +
                "2. 2 \n" +
                "3. 5 \n" +
                "4. 10 \n" +
                "5. 20 \n" +
                "6. 50 \n" +
                "Q. Quit");
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
        public void ChooseCategory()
        {
            Console.Clear();
            ShowMoney();
            Console.WriteLine("Please choose a category: ");
            Console.WriteLine("1. Beverages \n" +
                "2. Food \n" +
                "3. Snacks \n" +
                "Q. Quit");
            var keyInput = Console.ReadKey();
            switch (keyInput.Key)
            {
                case ConsoleKey.D1:
                    Console.Clear();
                    products.ShowBeverages();
                    AddToCart(products.beverageList);
                    break;
                case ConsoleKey.D2:
                    Console.Clear();
                    products.ShowFoods();
                    AddToCart(products.foodList);
                    break;
                case ConsoleKey.D3:
                    Console.Clear();
                    products.ShowSnacks();
                    AddToCart(products.snacksList);
                    break;
                case ConsoleKey.Q:
                    StartMenu();
                    break;
            }
            
        }
        public void AddToCart(List<Item> items)
        {
            ShowMoney();
            var keyInput = Console.ReadKey();
            switch (keyInput.Key)
            {
                case ConsoleKey.D1:
                    if (money >= GetPrice(items[0].price))
                    {
                        ShoppingCart.Add(items[0]);
                        money -= GetPrice(items[0].price);
                    }
                    else /*if (money <= GetPrice(items[0].price)) */
                    {
                        Clear();
                    }
                    break;
                case ConsoleKey.D2:
                    if (money >= GetPrice(items[1].price))
                    {
                        ShoppingCart.Add(items[1]);
                        money -= GetPrice(items[1].price);
                    }
                    else /*if (money <= GetPrice(items[1].price)) */
                    {
                        Clear();
                    }
                    break;
                case ConsoleKey.D3:
                    if (money >= GetPrice(items[2].price))
                    {
                        ShoppingCart.Add(items[2]);
                        money -= GetPrice(items[2].price);
                    }
                    else /*if (money <= GetPrice(items[2].price)) */
                    {
                        Clear();
                    }
                    break;
                case ConsoleKey.Q:
                    ChooseCategory();
                    break;
            }
        }
        public void Payment()
        {
            Console.Clear();
            ShowMoney();
            Console.WriteLine("Thank you for your purchase! \n" +
                "These are the items you bought: ");
            PrintShoppingCart();
            Console.Beep();
            Environment.Exit(0);
        }
    }
}
