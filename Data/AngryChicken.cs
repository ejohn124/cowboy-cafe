/*
 * Author: Emma Johnson
 * Class: Angry Chicken
 * Purpose: Implement class representing the Angry Chicken entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken: Entree
    {

        /// <summary>
        /// Price of Angry Chicken
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// Calories of the Angry Chicken
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 190;
            }
        }

        /// <summary>
        /// If the Angry Chicken has pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        private bool bread = true;

        /// <summary>
        /// If the Angry Chicken has bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set { bread = value; }
        }

        /// <summary>
        /// Special instructions for the preperation of the Angry Chicken
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!Pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

        /// <summary>
        /// Override of to string to correctly display Angry Chicken name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Angry Chicken";
        }
    }
}
