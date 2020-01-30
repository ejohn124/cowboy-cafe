using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork
    {
        /// <summary>
        /// Price of Pecos Pulled Pork
        /// </summary>
        public double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// Calories of Pecos Pulled Pork
        /// </summary>
        public uint Calories
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
        public List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Bread) instructions.Add("hold bread");
                if (!Pickle) instructions.Add("hold pickle");

                return instructions;
            }
        }
    }
}
