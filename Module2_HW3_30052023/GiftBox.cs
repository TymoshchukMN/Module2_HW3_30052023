// Author: Tymoshchuk Maksym
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
        private const int GiftsBoxSize = 15;
        private Gift[] _gifts;
        private string[] _groupedGifts = new string[0];

        /// <summary>
        /// Initializes a new instance of the <see cref="GiftBox"/> class.
        /// </summary>
        public GiftBox()
        {
            const int StartRand = 1;
            const int StopRand = 8;

            _gifts = new Gift[GiftsBoxSize];
            Random random = new Random();

            // наполнение коробки подарками в случайном порядке
            for (int i = 0; i < GiftsBoxSize; i++)
            {
                int randNUm = random.Next(StartRand, StopRand);
                _gifts[i] = FillGiftBox(randNUm);
                Console.WriteLine($"{i} - {_gifts[i]}");
            }

            GroupdGifts();
        }

        /// <summary>
        /// Gets gifts box.
        /// </summary>
        public Gift[] Gifts
        {
            get { return _gifts; }
        }

        public string[] GroupedGifts
        {
            get
            {
                return _groupedGifts;
            }
        }

        /// <summary>
        /// Calculate summary weught gifts.
        /// </summary>
        /// <returns>
        /// Weight.
        /// </returns>
        public int CalculateWightGiftBox()
        {
            int weight = 0;

            for (int i = 0; i < _gifts.Length; i++)
            {
                weight += _gifts[i].Weight;
            }

            return weight;
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

        private void GroupdGifts()
        {

            int n = _gifts.Length;

            for (int i = 0; i < n; i++)
            {
                bool isDuplicate = false;
                for (int j = 0; j < i; j++)
                {
                    if (_gifts[i].ToString() == _gifts[j].ToString())
                    {
                        isDuplicate = true;
                        break;
                    }
                }

                if (!isDuplicate)
                {
                    Array.Resize(ref _groupedGifts, _groupedGifts.Length + 1);
                    _groupedGifts[_groupedGifts.Length - 1] = _gifts[i].ToString();
                    Console.WriteLine(_gifts[i]);
                }

                for (int i = 0; i < _groupedGifts.Length; i++)
                {

                }
            }

        }
    }
}