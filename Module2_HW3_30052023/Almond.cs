// Author: Tymoshchuk Maksym
// Created On : 30/05/2023
// Last Modified On :
// Description: Almond
// Project: Module2_HW3_26052023

namespace Module2_HW3_30052023
{
    using System;

    /// <summary>
    /// Almond.
    /// </summary>
    public sealed class Almond : NutChocolate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Almond"/> class.
        /// </summary>
        public Almond()
        {
            Weight = 170;
            MainComponent = Components.Almond;
        }
    }
}