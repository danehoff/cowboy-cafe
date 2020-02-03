﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pulled Pork entree
    /// </summary>
    public class PecosPulledPork
    {

        /// <summary>
        /// The price of the pulled pork sandwich
        /// </summary>
        public double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the pulled pork sandwich
        /// </summary>
        public uint Calories
        {
            get
            {
                return 528;
            }
        }

        /// <summary>
        /// Default bool set to true as the bread.
        /// </summary>
        private bool bread = true;

        /// <summary>
        /// If the sandwich has bread.
        /// </summary>
        public bool Bread
        {

            get
            {

                return bread;

            }
            set
            {

                bread = value;


            }

        }

        /// <summary>
        /// Default bool set to true as the pickle.
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// If the sandwich has pickle.
        /// </summary>
        public bool Pickle
        {


            get
            {

                return pickle;

            }
            set
            {

                pickle = value;

            }

        }

        /// <summary>
        /// Special instructions for the preparation of the sandwich
        /// </summary>
        public List<string> SpecialInstructions
        {

            get
            {
                var instructions = new List<string>();

                if (!bread) instructions.Add("hold bread");
                if (!pickle) instructions.Add("hold pickle");

                return instructions;

            }
        }

    }
}