/*
 * Author: Emma Johnson
 * Class: PecosPulledPork
 * Purpose: Implement a class representing the Pecos Pulled Pork entree
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork: Entree
    {
        /// <summary>
        /// Price of Pecos Pulled Pork
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// Calories of Pecos Pulled Pork
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// If Pecos Pulled Pork has pickles
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// If Pecos Pulled Pork has bread
        /// </summary>
        public bool Bread { get; set; } = true;

        /// <summary>
        /// Special instructions for the preparation for Pecos Pulled Pork
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Bread) instructions.Add("hold bread");
                if (!Pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }

        /// <summary>
        /// Override of to string to correctly display Pecos Pulled Pork name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }
    }
}
