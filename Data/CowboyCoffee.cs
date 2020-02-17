/*
 * Author: Emma Johnson
 * Class: CowboyCoffee
 * Purpose: Implement a class representing the cowboy coffee drink
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Cowboy Coffee drink
    /// </summary>
    public class CowboyCoffee: Drink
    {

        /// <summary>
        /// If there is room for cream in the coffee
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Calories of Coffee
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 3;
                    case (Size.Medium):
                        return 5;
                    case (Size.Large):
                        return 7;
                    default:
                        throw new NotImplementedException("Unknown size");
                }

            }
        }

        /// <summary>
        /// Price of Coffee
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return .60;
                    case (Size.Medium):
                        return 1.10;
                    case (Size.Large):
                        return 1.60;
                    default:
                        throw new NotImplementedException("Unknown size");
                }

            }
        }

        /// <summary>
        /// If ice is added to the coffee
        /// </summary>
        public override bool Ice { get; set; } = false;
        /// <summary>
        /// Special instructions for the preperation of a Cowboy Coffee
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");
                return instructions;
            }
        }

    }
}
