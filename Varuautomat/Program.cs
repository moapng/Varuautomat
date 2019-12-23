using System;
using System.Collections;
using System.Collections.Generic;

namespace Varuautomat
{
    class Program
    {


        static void Main(string[] args)
        {
            Logic logic = new Logic();

            do
            {
                logic.ShowStartMenu();
                logic.StartMenu();
                logic.PrintShoppingCart();

            } while (true); //testing loop
        }



    }
}
