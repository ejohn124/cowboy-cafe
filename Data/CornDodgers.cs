/*
 * Author: Emma Johnson
 * Class: Corn Dodgers
 * Purpose: Implement a class representing the Corn Dodgers side
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing Corn Dodgers
    /// </summary>
    public class CornDodgers: Side
    {
        /// <summary>
        /// Calories of Corn Dodgers
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 717;
                    case Size.Medium:
                        return 685;
                    case Size.Small:
                        return 512;
                    default:
                        throw new NotImplementedException("Unknown size");
                }

            }
        }

        /// <summary>
        /// Price of Corn Dodgers
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 1.99;
                    case Size.Medium:
                        return 1.79;
                    case Size.Small:
                        return 1.59;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
                
            }
        }

        /// <summary>
        /// Override of to string to correctly display Corn Dodgers name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (Size)
            {
                case Size.Large:
                    return "Large Corn Dodgers";
                case Size.Medium:
                    return "Medium Corn Dodgers";
                case Size.Small:
                    return "Small Corn Dodgers";
                default:
                    throw new NotImplementedException("Unknown size");
            }
        }

        public override List<String> SpecialInstructions => throw new NotImplementedException();
    }
}
