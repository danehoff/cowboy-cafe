/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Cowpoke Chili

* Purpose:Holds the values for the rustler's ribs entree ingredients, attributes, and the special instructions for preparation.

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data.Entrees
{
    /// <summary>
    /// A class representing the Ribs entree
    /// </summary>
    public class RustlersRibs : Entree
    {

        /// <summary>
        /// The price of the Ribs
        /// </summary>
        public override double Price
        {
            get
            {
                return 7.50;
            }
        }

        /// <summary>
        /// The calories of the Ribs
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 894;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the ribs.
        /// </summary>
        public override List<string> SpecialInstructions
        {

            get
            {
                var instructions = new List<string>();
                return instructions;
            }
        }
        /// <summary>
        /// Readable string representing entree Rustler's Ribs.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Rustler's Ribs";
        }
    }
}
