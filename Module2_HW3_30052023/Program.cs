// Author: Tymoshchuk Maksym
// Created On : 30/05/2023
// Last Modified On :
// Description: main program
// Project: Module2_HW3_26052023

namespace Module2_HW3_30052023
{
    using System;

    /// <summary>
    /// Started program.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Sign-in point.
        /// </summary>
        /// <param name="args">
        /// passed args.
        /// </param>
        private static void Main(string[] args)
        {
            Gift gift = new Gift();

            gift.Weight = 20;

            HazelnutChocolate hazelnut = new HazelnutChocolate();

            hazelnut.Weight = 30;
            Console.WriteLine($"hazelnut.Weight = {hazelnut.Weight}, gift.Weight = {gift.Weight}");

            Console.ReadKey();
        }
    }
}
