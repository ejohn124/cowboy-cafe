using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Trail Burger entree
    /// </summary>
    public class TrailBurger: Entree
    {
        /// <summary>
        /// Price of the Trail Burger
        /// </summary>
        public override double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// Calories of the Trail Burger
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 288;
            }
        }

        /// <summary>
        /// If the Trail Burger has pickles
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// If the Trail Burger has a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// If the Trail Burger has ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// If the Trail Burger has mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// If the Trail Burger has cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// Special instructions for the preperation of the Trail Burger
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Bun) instructions.Add("hold bun");
                if (!Pickle) instructions.Add("hold pickle");
                if (!Ketchup) instructions.Add("hold ketchup");
                if (!Mustard) instructions.Add("hold mustard");
                if (!Cheese) instructions.Add("hold cheese");

                return instructions;
            }
        }
    }
}
