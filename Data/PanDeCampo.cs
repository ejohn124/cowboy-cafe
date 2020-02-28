/*
 * Author: Emma Johnson
 * Class: Pan de Campo
 * Purpose: Class to represent the Pan de Campo side
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Pan de Campo side
    /// </summary>
    public class PanDeCampo: Side
    {
        /// <summary>
        /// Calories of Pan de Campo
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Large:
                        return 367;
                    case Size.Medium:
                        return 269;
                    case Size.Small:
                        return 227;
                    default:
                        throw new NotImplementedException("Unknown size");
                }

            }
        }

        /// <summary>
        /// Price of Pan de Campo
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
        /// Override of to string to correctly display Pan De Campo name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pan De Campo";
        }
    }
}
