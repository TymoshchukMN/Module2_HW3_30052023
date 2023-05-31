// Author: Tymoshchuk Maksym
// Created On : 31/05/2023
// Last Modified On :
// Description: Starter
// Project: Module2_HW3_26052023

namespace Module2_HW3_30052023
{
    using System;

    /// <summary>
    /// Started class.
    /// </summary>
    public class Starter
    {
        /// <summary>
        /// Initializes static members of the <see cref="Starter"/> class.
        /// Lounch prohramm.
        /// </summary>
        public static void Run()
        {
            GiftBox giftBox = new GiftBox();
            giftBox.CalculateWightGiftBox();
            UI.PrintGiftBox(giftBox);
            Console.ReadKey();
        }
    }
}
