using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Texas Triple Burger entree
    /// </summary>
    public class TexasTripleBurger: Entree
    {
        /// <summary>
        /// Price of the Texas Triple
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// Calories of the Texas Triple
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 698;
            }
        }

        /// <summary>
        /// If the Texas Triple has pickles
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// If the Texas Triple has a bun
        /// </summary>
        public bool Bun { get; set; } = true;

        /// <summary>
        /// If the Texas Triple has ketchup
        /// </summary>
        public bool Ketchup { get; set; } = true;

        /// <summary>
        /// If the Texas Triple has mustard
        /// </summary>
        public bool Mustard { get; set; } = true;

        /// <summary>
        /// If the Texas Triple has cheese
        /// </summary>
        public bool Cheese { get; set; } = true;

        /// <summary>
        /// If the Texas Triple has tomato
        /// </summary>
        public bool Tomato { get; set; } = true;


        /// <summary>
        /// If the Texas Triple has mayo
        /// </summary>
        public bool Mayo { get; set; } = true;

        /// <summary>
        /// If the Texas Triple has lettuce
        /// </summary>
        public bool Lettuce { get; set; } = true;

        /// <summary>
        /// If the Texas Triple has an egg
        /// </summary>
        public bool Egg { get; set; } = true;

        /// <summary>
        /// If the Texas Triple has bacon
        /// </summary>
        public bool Bacon { get; set; } = true;

        /// <summary>
        /// Special instructions for the preperation of the Texas Triple
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
                if (!Egg) instructions.Add("hold egg");
                if (!Bacon) instructions.Add("hold bacon");

                return instructions;
            }
        }
    }
}
