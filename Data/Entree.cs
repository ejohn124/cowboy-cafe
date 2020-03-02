/*
 * Author: Emma Johnson
 * Class: Entree
 * Purpose: Implement a base class for the entree items
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class for the entree items
    /// </summary>
    public abstract class Entree: IOrderItem
    {
        /// <summary>
        /// Gets the price of an entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of an entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the special instructions for an entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
