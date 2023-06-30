// Author: Tymoshchuk Maksym
// Created On : 30/05/2023
// Last Modified On :
// Description: HazelnutChocolate
// Project: Module2_HW3_26052023

namespace Module2_HW3_30052023
{
    using System;

    /// <summary>
    /// HazelnutChocolate.
    /// </summary>
    public sealed class HazelnutChocolate : NutChocolate
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="HazelnutChocolate"/> class.
        /// </summary>
        public HazelnutChocolate()
        {
            Weight = 150;
            MainComponent = Components.Hazelnut;
        }
    }
}