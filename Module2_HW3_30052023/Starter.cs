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

            // печать не сгруппировавнной коробки со сладостями.
            UI.PrintGifts(giftBox.Gifts);

            // сортировка по имени, реализована с помощью интерефейса
            // IComparable в базововм классе
            Array.Sort(giftBox.Gifts);
            UI.PrintGifts(giftBox.Gifts);

            // сортировка по весу сладости
            giftBox.SortByWeight();
            UI.PrintGifts(giftBox.Gifts);

            // печать сгруппированной коробки со сладостями
            UI.PrintGiftBox(giftBox);
            giftBox.CalculateWightGiftBox();

            Console.ReadKey();
        }
    }
}
