﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Ribs entree
    /// </summary>
    public class RustlersRibs
    {

        /// <summary>
        /// The price of the Ribs
        /// </summary>
        public double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the Ribs
        /// </summary>
        public uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the ribs.
        /// </summary>
        public List<string> SpecialInstructions
        {

            get
            {
                var instructions = new List<string>();
                return instructions;
            }
        }
    }
}
