﻿using System;
namespace ConsoleUI
{
	public abstract class Vehicle
	{
        /*
        * Create an abstract class called Vehicle// DONE
        * The vehicle class shall have three string properties Year, Make, and Model //DONE
        * Set the defaults to something generic in the Vehicle class // DONE
        * Vehicle shall have an abstract method called DriveAbstract with no implementation //DONE
        * Vehicle shall have a virtual method called DriveVirtual with a base implementation. //DONE
        */

        public int Year { get; set; } = 1;
        public string Make { get; set; } = "Default Make";
        public string Model { get; set; } = "Default Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual()
        {
            Console.WriteLine($" {GetType().Name} is on the move!");
        }
       



    }
}

