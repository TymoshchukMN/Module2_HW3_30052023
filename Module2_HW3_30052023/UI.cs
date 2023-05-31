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
        /// <summary>
        /// Print gift box.
        /// </summary>
        /// <param name="giftBox">
        /// box.
        /// </param>
        public static void PrintGiftBox(GiftBox giftBox)
        {
            int n = giftBox.Gifts.Length;

            for (int i = 0; i < n; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (giftBox.Gifts[i].ToString() == giftBox.Gifts[j].ToString())
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Console.WriteLine(giftBox.Gifts[i]);
                }

            }

            Console.WriteLine();
        }
    }
}
