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
        private int _weight;

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

        /// <summary>
        /// Gets summary weight of box.
        /// </summary>
        public int GetSummaryWeight
        {
            get
            {
                return _weight;
            }
        }

        /// <summary>
        /// Gets grouped gifts with count elements.
        /// </summary>
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
        public void CalculateWightGiftBox()
        {
            int weight = 0;

            for (int i = 0; i < _gifts.Length; i++)
            {
                weight += _gifts[i].Weight;
            }

            _weight = weight;
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

        /// <summary>
        /// Group gifts and calculate count.
        /// </summary>
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
                    _groupedGifts[_groupedGifts.Length - 1]
                        = $"{_gifts[i].Weight}:{_gifts[i]}";
                }
            }

            for (int i = 0; i < _groupedGifts.Length; i++)
            {
                int countCpecificGifts = 0;
                int weightGift = 0;
                for (int j = 0; j < _gifts.Length; j++)
                {
                    string giftForCompaire = _groupedGifts[i].Split(':')[1];
                    if (giftForCompaire == _gifts[j].ToString())
                    {
                        ++countCpecificGifts;
                        if (weightGift == 0)
                        {
                            weightGift = _gifts[j].Weight;
                        }
                    }
                }

                weightGift = weightGift * countCpecificGifts;
                string strWeifhtOneGift = _groupedGifts[i].Split(':')[0];
                string gift = _groupedGifts[i].Split(':')[1];

                _groupedGifts[i] = $"{countCpecificGifts}\t{weightGift}\t\t{strWeifhtOneGift}\t\t{gift}";
            }

            Array.Sort(_groupedGifts);
            Array.Reverse(_groupedGifts);
        }
    }
}