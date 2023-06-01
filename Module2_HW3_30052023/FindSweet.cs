// Author: Tymoshchuk Maksym
// Created On : 1/06/2023
// Last Modified On :
// Description: FindSweet in gift box
// Project: Module2_HW3_26052023

namespace Module2_HW3_30052023
{
    using System;

    /// <summary>
    /// FindSweet.
    /// </summary>
    public static class FindSweet
    {
        /// <summary>
        /// Find particular gift.
        /// </summary>
        /// <param name="gifts">
        /// array with gifts.
        /// </param>
        /// <param name="sweetName">
        /// Name of sweet.
        /// </param>
        /// <returns>
        /// Finded array.
        /// </returns>
        public static Gift[] FindGift(this Gift[] gifts, string sweetName)
        {
            Gift[] gift = new Gift[0];

            for (int i = 0; i < gifts.Length; i++)
            {
                if (gifts[i].ToString() == sweetName)
                {
                    Array.Resize(ref gift, gift.Length + 1);
                    gift[gift.Length - 1] = gifts[i];
                }
            }

            return gift;
        }
    }
}
