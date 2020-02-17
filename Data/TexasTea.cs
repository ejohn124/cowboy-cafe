/*
 * Author: Emma Johnson
 * Class: TexasTea
 * Purpose: Implement class representing the Texas Tea drink
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Texas Tea drink
    /// </summary>
    public class TexasTea: Drink
    {
        /// <summary>
        /// If the tea is sweet
        /// </summary>
        public bool Sweet { get; set; } = true;

        /// <summary>
        /// If the tea has lemon
        /// </summary>
        public bool Lemon { get; set; } = false;

        /// <summary>
        /// Calories of a Texas Tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        if (Sweet)
                        {
                            return 10;
                        }
                        return 5;
                    case (Size.Medium):
                        if (Sweet)
                        {
                            return 22;
                        }
                        return 11;
                    case (Size.Large):
                        if (Sweet)
                        {
                            return 36;
                        }
                        return 18;
                    default:
                        throw new NotImplementedException("Unknown size");
                }

            }
        }

        /// <summary>
        /// Price of Texas Tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 1.00;
                    case (Size.Medium):
                        return 1.50;
                    case (Size.Large):
                        return 2.00;
                    default:
                        throw new NotImplementedException("Unknown size");
                }

            }
        }

        /// <summary>
        /// Special instructions for the preperation of a Texas Tea
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

    }
}
