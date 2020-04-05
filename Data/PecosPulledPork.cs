/*
 * Author: Emma Johnson
 * Class: PecosPulledPork
 * Purpose: Implement a class representing the Pecos Pulled Pork entree
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork: Entree, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
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

        private bool pickle = true;
        /// <summary>
        /// If Pecos Pulled Pork has pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Pickle"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool bread = true;
        /// <summary>
        /// If Pecos Pulled Pork has bread
        /// </summary>
        public bool Bread
        {
            get { return bread; }
            set
            {
                bread = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Bread"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Special instructions for the preparation for Pecos Pulled Pork
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

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
