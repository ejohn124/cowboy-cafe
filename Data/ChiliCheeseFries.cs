﻿/*
 * Author: Emma Johnson
 * Class: Chili Cheese Fries
 * Purpose: To implement a class representing the chili cheese fries side
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Chili Cheese Fries side
    /// </summary>
    public class ChiliCheeseFries: Side
    {
        /// <summary>
        /// Calories of the Chili Cheese Fries
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 610;
                    case Size.Medium:
                        return 524;
                    case Size.Small:
                        return 433;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
                
            }
        }

        /// <summary>
        /// Price of the Chili Cheese Fries
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 3.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Small:
                        return 1.99;
                    default:
                        throw new NotImplementedException("Unknown size");
                }
            }
        }

        /// <summary>
        /// Override of to string to correctly display Chili Cheese Fries name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Chili Cheese Fries";
        }

        public override List<String> SpecialInstructions => throw new NotImplementedException();
    }
}
