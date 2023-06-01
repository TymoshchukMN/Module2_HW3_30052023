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
        /// <param name="gift">
        /// box.
        /// </param>
        public static void PrintGifts(Gift[] gift)
        {
            ChangeColor("Not grouped Gifts:\n", ConsoleColor.Yellow);
            Console.WriteLine("Weight\tGift:\n");
            for (int i = 0; i < gift.Length; i++)
            {
                Console.WriteLine($"{gift[i].Weight}\t{gift[i]}");
            }
        }

        /// <summary>
        /// Print gift box.
        /// </summary>
        /// <param name="giftBox">
        /// box.
        /// </param>
        public static void PrintGiftBox(GiftBox giftBox)
        {
            Console.WriteLine("\nGift box:\n");
            ChangeColor(
                "Count:\tWeight summury:\tWeight one:\tGifts:\n",
                ConsoleColor.Yellow);

            for (int i = 0; i < giftBox.GroupedGifts.Length; i++)
            {
                Console.WriteLine(giftBox.GroupedGifts[i]);
            }

            ChangeColor(
                $"\n\nSummary weight:\t{giftBox.GetSummaryWeight} gramm",
                ConsoleColor.Cyan);
        }

        /// <summary>
        /// Chenge color item.
        /// </summary>
        /// <param name="str">
        /// str for print.
        /// </param>
        /// <param name="newColor">
        /// new color.
        /// </param>
        private static void ChangeColor(string str, ConsoleColor newColor)
        {
            ConsoleColor def = Console.ForegroundColor;
            Console.ForegroundColor = newColor;
            Console.Write(str);
            Console.ForegroundColor = def;
        }
    }
}
