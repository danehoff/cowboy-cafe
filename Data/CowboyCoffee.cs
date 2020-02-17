using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {

        public override double Price
        {

            get
            {

                switch (Size)
                {

                    case Size.Large:
                        return 1.60;

                    case Size.Medium:
                        return 1.10;

                    case Size.Small:
                        return 0.60;

                    default:
                        throw new NotImplementedException("Unknown Price.");

                }

            }

        }

        /// <summary>
        /// The calories of the coffee
        /// </summary>
        public override uint Calories
        {
            get
            {

                switch (Size)
                {

                    case Size.Large:
                        return 7;

                    case Size.Medium:
                        return 5;

                    case Size.Small:
                        return 3;

                    default:
                        throw new NotImplementedException("Unknown Size.");

                }

            }
        }

        private bool cream = false;
        public bool RoomForCream
        {

            get { return cream; }
            set { cream = value; }

        }

        private bool decaf = false;
        public bool Decaf
        {

            get { return decaf; }
            set { decaf = value; }

        }

        /// <summary>
        /// Default bool set to true as the pickle.
        /// </summary>
        private bool ice = false;

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
                if (!Ice) instructions.Add("Add ice");
                if (!RoomForCream) instructions.Add("Room for Cream");
                return instructions;

            }
        }

    }
}
