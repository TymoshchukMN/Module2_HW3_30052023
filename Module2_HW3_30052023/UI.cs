// Author: Tymoshchuk Maksym
// Created On : 30/05/2023
// Last Modified On :
// Description: HazelnutChocolate
// Project: Module2_HW3_26052023

namespace Module2_HW3_30052023
{
    using System;

    /// <summary>
    /// User interface.
    /// </summary>
    internal class UI
    {
        public static void PrintGiftBox(GiftBox giftBox)
        {
            for (int i = 0; i < giftBox.Gifts.Length; i++)
            {
                Console.WriteLine();
            }
        }
    }
}
