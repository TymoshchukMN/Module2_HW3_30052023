// Author: Tymoshchuk Maksym
// Created On : 31/05/2023
// Last Modified On :
// Description: Starter
// Project: Module2_HW3_26052023

namespace Module2_HW3_30052023
{
    using System;

    /// <summary>
    /// BL.
    /// </summary>
    public class BL
    {
        /// <summary>
        /// Returm gift.
        /// </summary>
        /// <param name="num">
        /// rand num.
        /// </param>
        /// <returns>
        /// gidt.
        /// </returns>
        public static Gift FillGiftBox(int num)
        {
            switch (num)
            {
                case 1:
                    return new HazelnutChocolate();
                case 2:
                    return new Almond();
                case 3:
                    return new Bar();
                case 4:
                    return new Porous();
                case 5:
                    return new OrangeCaramel();
                case 6:
                    return new RusberryCaramel();
                case 7:
                    return new Biscuit();
                case 8:
                    return new Shortbread();
            }

            return null;
        }
    }
}
