﻿using System;
using System.Collections;
using System.Collections.Generic;

namespace Varuautomat
{
    class Program
    {


        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            Logic logic = new Logic();


            while (true)
            {
                logic.StartMenu();
            }

        }

    }
}
