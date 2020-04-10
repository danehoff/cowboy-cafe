/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Cowpoke Chili

* Purpose:Holds the values for the pecos pulled pork's entree ingredients, attributes, and the special instructions for preparation.

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data.Entrees
{
    /// <summary>
    /// A class representing the Pulled Pork entree
    /// </summary>
    public class PecosPulledPork : Entree
    {

        /// <summary>
        /// The price of the pulled pork sandwich
        /// </summary>
        public override double Price
        {
            get
            {
                return 5.88;
            }
        }

        /// <summary>
        /// The calories of the pulled pork sandwich
        /// </summary>
        public override uint Calories
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
                NotifyPropertyChanged("Bread");


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
                NotifyPropertyChanged("Pickle");

            }

        }

        /// <summary>
        /// Special instructions for the preparation of the sandwich
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
        /// Readable string representing entree Pecos Pulled Pork.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }

    }
}
