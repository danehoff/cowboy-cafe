﻿/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Cowpoke Chili

* Purpose:Holds the values for the texas triple burger's ingredients, attributes, and the special instructions for preparation.

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Triple Burger entree
    /// </summary>
    public class TexasTripleBurger : Entree
    {

        /// <summary>
        /// The price of the Texas Triple Burger.
        /// </summary>
        public override double Price
        {
            get
            {
                return 6.45;
            }
        }

        /// <summary>
        /// The calories of the Texas Triple Burger.
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 698;
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
        /// Default bool set to true as the tomato.
        /// </summary>
        private bool tomato = true;

        /// <summary>
        /// If the burger has tomato.
        /// </summary>
        public bool Tomato
        {

            get
            {

                return tomato;

            }
            set
            {

                tomato = value;

            }

        }

        /// <summary>
        /// Default bool set to true as the lettuce.
        /// </summary>
        private bool lettuce = true;

        /// <summary>
        /// If the burger has lettuce.
        /// </summary>
        public bool Lettuce
        {

            get
            {

                return lettuce;

            }
            set
            {

                lettuce = value;

            }

        }

        /// <summary>
        /// Default bool set to true as the mayo.
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// If the burger has mayo.
        /// </summary>
        public bool Mayo
        {

            get
            {

                return mayo;

            }
            set
            {

                mayo = value;

            }

        }

        /// <summary>
        /// Default bool set to true as the bacon.
        /// </summary>
        private bool bacon = true;

        /// <summary>
        /// if the burger has bacon.
        /// </summary>
        public bool Bacon
        {

            get
            {

                return bacon;

            }
            set
            {

                bacon = value;

            }

        }

        /// <summary>
        /// Default bool set to true as the egg.
        /// </summary>
        private bool egg = true;

        /// <summary>
        /// If the burger has egg.
        /// </summary>
        public bool Egg
        {

            get
            {

                return egg;

            }
            set
            {

                egg = value;

            }

        }

        /// <summary>
        /// Special instructions for the preparation of the burger.
        /// </summary>
        public override List<string> SpecialInstructions
        {

            get
            {
                var instructions = new List<string>();

                if (!bun) instructions.Add("hold bun");
                if (!ketchup) instructions.Add("hold ketchup");
                if (!mustard) instructions.Add("hold mustard");
                if (!pickle) instructions.Add("hold pickle");
                if (!cheese) instructions.Add("hold cheese");
                if (!tomato) instructions.Add("hold tomato");
                if (!lettuce) instructions.Add("hold lettuce");
                if (!mayo) instructions.Add("hold mayo");
                if (!bacon) instructions.Add("hold bacon");
                if (!egg) instructions.Add("hold egg");

                return instructions;

            }
        }

    }
}
