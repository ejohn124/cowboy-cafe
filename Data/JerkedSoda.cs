/*
 * Author: Emma Johnson
 * Class: JerkedSoda
 * Purpose: Implement a class representing the Jerked Soda drink
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Jerked Soda
    /// </summary>
    public class JerkedSoda: Drink
    {
        /// <summary>
        /// Calories of a Jerked Soda
        /// </summary>
        public override uint Calories {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 110;
                    case (Size.Medium):
                        return 145;
                    case (Size.Large):
                        return 198;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
                    
            }
        }

        /// <summary>
        /// Price of Jerked Soda
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 1.59;
                    case (Size.Medium):
                        return 2.10;
                    case (Size.Large):
                        return 2.59;
                    default:
                        throw new NotImplementedException("Unknown size");
                }

            }
        }

        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// Special instructions for the preperation of a Jerked Soda
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                return instructions;
            }
        }

    }
}
