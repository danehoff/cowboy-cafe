using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class TexasTea: Drink
    {

        public override double Price
        {

            get
            {

                switch (Size)
                {

                    case Size.Large:
                        return 2.00;

                    case Size.Medium:
                        return 1.50;

                    case Size.Small:
                        return 1.00;

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
                        return 36;

                    case Size.Medium:
                        return 22;

                    case Size.Small:
                        return 10;

                    default:
                        throw new NotImplementedException("Unknown Size.");

                }

            }
        }

        private bool lemon = false;
        public bool Lemon
        {

            get { return lemon; }
            set { lemon = value; }

        }

        /// <summary>
        /// Default bool set to true as the ice.
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
                if (!Ice) instructions.Add("Hold ice");
                if (!Lemon) instructions.Add("Add Lemon");
                return instructions;

            }
        }

    }
}
