// Author: Tymoshchuk Maksym
// Created On : 31/05/2023
// Last Modified On :
// Description: base class.
// Project: Module2_HW3_26052023

namespace Module2_HW3_30052023
{
    using System;

    /// <summary>
    /// Base class.
    /// </summary>
    public class Gift : IComparable
    {
        /// <summary>
        /// gift weight.
        /// </summary>
        private int _weight;
        private Components _mainComponent;

        /// <summary>
        /// Gets or sets weight.
        /// </summary>
        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

        /// <summary>
        /// Gets or sets main Component.
        /// </summary>
        public Components MainComponent
        {
            get { return _mainComponent; }
            set { _mainComponent = value; }
        }

        public static implicit operator Gift(string gift)
        {
            return new Gift();
        }

        /// <summary>
        /// override ToString.
        /// </summary>
        /// <returns>
        /// string.
        /// </returns>
        public override string ToString()
        {
            return this.GetType().Name;
        }

        /// <summary>
        /// Compare objects.
        /// </summary>
        /// <param name="obj">
        /// Object for compairing.
        /// </param>
        /// <returns>
        /// true/false
        /// </returns>
        public int CompareTo(object obj)
        {
            return this.ToString().CompareTo(obj.ToString());
        }
    }
}