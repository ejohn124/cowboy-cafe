/*
 * Author: Emma Johnson
 * Class: Water
 * Purpose: Implement class representing water
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class that represents water as a drink
    /// </summary>
    public class Water: Drink
    {
        /// <summary>
        /// If lemon is added to the water
        /// </summary>
        public bool Lemon { get; set; } = false;
        /// <summary>
        /// Calories of a water
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
            }
        }

        /// <summary>
        /// Price of Water
        /// </summary>
        public override double Price
        {
            get
            {
                return .12;
            }
        }

        /// <summary>
        /// Special instructions for the preperation of a Jerked Soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (Lemon) instructions.Add("Add Lemon");
                return instructions;
            }
        }

        /// <summary>
        /// Override of to string to correctly display Water name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string item = "Water";
            switch (Size)
            {
                case Size.Large:
                    return "Large " + item;
                case Size.Medium:
                    return "Medium " + item;
                case Size.Small:
                    return "Small " + item;
                default:
                    throw new NotImplementedException("Unknown size");
            }
        }

    }
}
