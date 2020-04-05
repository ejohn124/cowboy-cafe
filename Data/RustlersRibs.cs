/*
 * Author: Emma Johnson
 * Class: RustersRibs
 * Purpose: Implement a class representing the Rustler's Ribs entree
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Rustler's Ribs entree
    /// </summary>
    public class RustlersRibs: Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Price of ribs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// Calories of ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();
                return instructions;
            }
        }

        /// <summary>
        /// Override of to string to correctly display Rustler's Ribs name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
