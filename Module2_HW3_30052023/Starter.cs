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
            const int CountGifts = 15;
            const int StartRand = 1;
            const int StopRand = 16;

            Gift[] gifts = new Gift[CountGifts];
            Random random = new Random();

            // наполнение коробки подарками в случайном порядке
            for (int i = 0; i < gifts.Length; i++)
            {
                gifts[i] = BL.FillGiftBox(random.Next(StartRand, StopRand));
            }

        }
    }
}
