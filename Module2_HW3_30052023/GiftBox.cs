﻿// Author: Tymoshchuk Maksym
// Created On : 31/05/2023
// Last Modified On :
// Description: Starter
// Project: Module2_HW3_26052023

namespace Module2_HW3_30052023
{
    using System;

    /// <summary>
    /// GiftBox.
    /// </summary>
    public class GiftBox
    {
        private const int CountGifts = 15;
        private Gift[] _gifts;

        /// <summary>
        /// Initializes a new instance of the <see cref="GiftBox"/> class.
        /// </summary>
        public GiftBox()
        {
            const int StartRand = 1;
            const int StopRand = 16;

            _gifts = new Gift[CountGifts];
            Random random = new Random();

            // наполнение коробки подарками в случайном порядке
            for (int i = 0; i < _gifts.Length; i++)
            {
                _gifts[i] = FillGiftBox(random.Next(StartRand, StopRand));
            }
        }

        /// <summary>
        /// Gets or sets gifts box.
        /// </summary>
        public Gift[] Gifts
        {
            get { return _gifts; }
            private set { _gifts = value; }
        }

        /// <summary>
        /// Returm gift.
        /// </summary>
        /// <param name="num">
        /// rand num.
        /// </param>
        /// <returns>
        /// gidt.
        /// </returns>
        private Gift FillGiftBox(int num)
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