// Author: Tymoshchuk Maksym
// Created On : 31/05/2023
// Last Modified On :
// Description: Candy class.
// Project: Module2_HW3_26052023

namespace Module2_HW3_30052023
{
    using System;

    /// <summary>
    /// Candy.
    /// </summary>
    public abstract class Candy : Gift
    {
        public Candy()
        {
            Console.WriteLine("caled Candy");
        }
    }
}