﻿using System;
namespace ConsoleUI
{
	public class Motorcycle : Vehicle
	{
        /* 
        * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle //DONE
        * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle //DONE
        * Provide the implementations for the abstract methods //DONE
        * Only in the Motorcycle class will you override the virtual drive method //DONE
       */

        public bool HasSideCar { get; set; }
        public bool HasTrunk { get; set; }

        public override void DriveVirtual()
        {
            Console.WriteLine($"{GetType().Name} is virtually in drive");
        }

        public override void DriveAbstract()
        {
            Console.WriteLine($"The Motorcycle is on the move!");
        }

        
    }
}

