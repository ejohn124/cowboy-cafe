using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Dakota Double entree
    /// </summary>
    public class DakotaDoubleBurger: Entree
    {
        /// <summary>
        /// Price of the Dakota Double
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.20;
            }
        }

        /// <summary>
        /// Calories of the Dakota Double
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 464;
            }
        }

        /// <summary>
        /// If the Dakota Double has pickles
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// If the Dakota Double has a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// If the Dakota Double has ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// If the Dakota Double has mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// If the Dakota Double has cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// If the Dakota Double Burger has tomato
        /// </summary>
        public bool Tomato { get; set; } = true;


        /// <summary>
        /// If the Dakota Double Burger has mayo
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// If the Dakota Double Burger has lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// Special instructions for the preperation of the Dakota Double Burger
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
                if (!Lettuce) instructions.Add("hold lettuce");
                if (!Mayo) instructions.Add("hold mayo");
                if (!Tomato) instructions.Add("hold tomato");

                return instructions;
            }
        }
    }
}

