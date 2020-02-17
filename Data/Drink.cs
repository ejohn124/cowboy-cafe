/*
 * Author: Emma Johnson
 * Class: Drink
 * Purpose: Implement a base drink class for drinks
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Base class for Drink items
    /// </summary>
    public abstract class Drink
    {
        /// <summary>
        /// Calories of a drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Price of drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Size of drink
        /// </summary>
        public Size Size { get; set; } = Size.Small;

        /// <summary>
        /// Special instructions for the preperation of a drink
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// If a drink has ice
        /// </summary>
        public virtual bool Ice { get; set; } = true;
    }
}
