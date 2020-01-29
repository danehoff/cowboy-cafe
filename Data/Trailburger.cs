using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the TrailBurger entree
    /// </summary>
    public class TrailBurger
    {

        /// <summary>
        /// The price of the burger
        /// </summary>
        public double Price
        {
            get
            {
                return 4.50;
            }
        }

        /// <summary>
        /// The calories of the burger
        /// </summary>
        public uint Calories
        {
            get
            {
                return 288;
            }
        }

        /// <summary>
        /// Default bool set to true as the bun.
        /// </summary>
        private bool bun = true;

        /// <summary>
        /// If the burger has a bun.
        /// </summary>
        public bool Bun
        {

            get
            {

                return bun;

            }
            set
            {

                bun = value;


            }

        }

        /// <summary>
        /// Default bool set to true as the ketchup.
        /// </summary>
        private bool ketchup = true;

        /// <summary>
        /// If the burger has ketchup.
        /// </summary>
        public bool Ketchup
        {

            get
            {

                return ketchup;

            }
            set
            {

                ketchup = value;

            }

        }

        /// <summary>
        /// Default bool set to true as the mustard.
        /// </summary>
        private bool mustard = true;

        /// <summary>
        /// If the burger has mustard.
        /// </summary>
        public bool Mustard
        {

            get
            {

                return mustard;

            }
            set
            {

                mustard = value;

            }

        }

        /// <summary>
        /// Default bool set to true as the pickle.
        /// </summary>
        private bool pickle = true;

        /// <summary>
        /// If the burger has pickle.
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
        /// Default bool set to true as the cheese.
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// If the burger has cheese.
        /// </summary>
        public bool Cheese
        {

            get
            {

                return cheese;

            }
            set
            {

                cheese = value;

            }

        }

        /// <summary>
        /// Special instructions for the preparation of the burger
        /// </summary>
        public List<string> SpecialInstructions
        {

            get
            {
                var instructions = new List<string>();

                if (!bun) instructions.Add("hold bun");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");

                return instructions;

            }
        }

    }
}
