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
    public class Gift:IComparable
    {
        /// <summary>
        /// gift weight.
        /// </summary>
        private int _weight;

        /// <summary>
        /// Gets or sets weight.
        /// </summary>
        public int Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }

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