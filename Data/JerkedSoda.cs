/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Jerked Soda

* Purpose: Represents the sizes for the entrees and sizes.

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class JerkedSoda : Drink
    {

        public override double Price
        {

            get
            {

                switch (Size)
                {

                    case Size.Large:
                        return 2.59;

                    case Size.Medium:
                        return 2.10;

                    case Size.Small:
                        return 1.59;

                    default:
                        throw new NotImplementedException("Unknown Price.");

                }

            }

        }

        /// <summary>
        /// The calories of the Soda
        /// </summary>
        public override uint Calories
        {
            get
            {

                switch (Size)
                {

                    case Size.Large:
                        return 198;

                    case Size.Medium:
                        return 146;

                    case Size.Small:
                        return 110;

                    default:
                        throw new NotImplementedException("Unknown Size.");

                }

            }
        }

        
        public SodaFlavor Flavor
        {

            get
            {

                return Flavor;

            }
            set
            {

                Flavor = value;


            }


        }

        /// <summary>
        /// Default bool set to true as the pickle.
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// If the burger has pickle.
        /// </summary>
        public bool Ice
        {


            get { return ice; }
            set { ice = value; }

        }

        public override List<string> SpecialInstructions
        {

            get
            {

                var instructions = new List<string>();
                if (!Ice) instructions.Add("hold ice");
                return instructions;

            }
        }

    }
}
