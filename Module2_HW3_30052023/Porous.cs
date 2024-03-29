﻿// Author: Tymoshchuk Maksym
// Created On : 31/05/2023
// Last Modified On :
// Description: Porous
// Project: Module2_HW3_26052023

namespace Module2_HW3_30052023
{
    using System;

    /// <summary>
    /// Porous.
    /// </summary>
    public sealed class Porous : MilkChocolate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Porous"/> class.
        /// </summary>
        public Porous()
        {
            Weight = 110;
            MainComponent = Components.BlowingAgent;
        }
    }
}
