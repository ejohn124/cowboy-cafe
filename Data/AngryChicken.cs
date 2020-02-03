﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken
    {
        /// <summary>
        /// Price of Angry Chicken
        /// </summary>
        public double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// Calories of the Angry Chicken
        /// </summary>
        public uint Calories
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
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!Pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }
    }
}