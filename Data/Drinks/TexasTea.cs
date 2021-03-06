﻿/*
 * Author: Emma Johnson
 * Class: TexasTea
 * Purpose: Implement class representing the Texas Tea drink
 */
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Class representing the Texas Tea drink
    /// </summary>
    public class TexasTea: Drink, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private bool sweet = true;
        /// <summary>
        /// If the tea is sweet
        /// </summary>
        public bool Sweet
        {
            get { return sweet; }
            set
            {
                sweet = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Sweet"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        private bool lemon = false;
        /// <summary>
        /// If the tea has lemon
        /// </summary>
        public bool Lemon
        {
            get { return lemon; }
            set
            {
                lemon = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Lemon"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
            }
        }

        /// <summary>
        /// Calories of a Texas Tea
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        if (Sweet)
                        {
                            return 10;
                        }
                        return 5;
                    case (Size.Medium):
                        if (Sweet)
                        {
                            return 22;
                        }
                        return 11;
                    case (Size.Large):
                        if (Sweet)
                        {
                            return 36;
                        }
                        return 18;
                    default:
                        throw new NotImplementedException("Unknown size");
                }

            }
        }

        /// <summary>
        /// Price of Texas Tea
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case (Size.Small):
                        return 1.00;
                    case (Size.Medium):
                        return 1.50;
                    case (Size.Large):
                        return 2.00;
                    default:
                        throw new NotImplementedException("Unknown size");
                }

            }
        }

        /// <summary>
        /// Special instructions for the preperation of a Texas Tea
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                var instructions = new List<string>();

                if (!Ice) instructions.Add("Hold Ice");
                if (lemon) instructions.Add("Add Lemon");
                if (!sweet) instructions.Add("Unsweetend");
                return instructions;
            }
        }

        /// <summary>
        /// Override of to string to correctly display Texas Tea Name
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            string item = "Texas Tea";
            switch (Size)
            {
                case Size.Large:
                    item = "Large " + item;
                    break;
                case Size.Medium:
                    item = "Medium " + item;
                    break;
                case Size.Small:
                    item = "Small " + item;
                    break;
                default:
                    throw new NotImplementedException("Unknown size");
            }
            if (!sweet) return "Unsweetend" + item;
            return item;
        }

    }
}
