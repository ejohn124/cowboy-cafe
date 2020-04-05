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

        /// <summary>
        /// Flavor of the Jerked Soda
        /// </summary>
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

        /// <summary>
        /// Override of to string to correctly display Jerked Soda name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string completedDrink = "Jerked Soda";
            switch (Flavor)
            {
                case SodaFlavor.CreamSoda:
                    completedDrink = "Cream Soda " + completedDrink;
                    break;
                case SodaFlavor.OrangeSoda:
                    completedDrink = "Orange Soda" + completedDrink;
                    break;
                case SodaFlavor.Sarsparilla:
                    completedDrink = "Sarsparilla " + completedDrink;
                    break;
                case SodaFlavor.RootBeer:
                    completedDrink = "Root Beer " + completedDrink;
                    break;
                case SodaFlavor.BirchBeer:
                    completedDrink = "Birch Beer " + completedDrink;
                    break;
            }
            switch (Size)
            {
                case Size.Large:
                    completedDrink = "Large " + completedDrink;
                    break;
                case Size.Medium:
                    completedDrink = "Medium " + completedDrink;
                    break;
                case Size.Small:
                    completedDrink = "Small " + completedDrink;
                    break;
                default:
                    throw new NotImplementedException("Unknown size");
            }


            return completedDrink;
        }

    }
}
