using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Water : Drink
    {

        /// <summary>
        /// The price of the water
        /// </summary>
        public override double Price
        {
            get
            {
                return 0.12;
            }
        }

        /// <summary>
        /// The calories of the water
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 0;
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
        /// If the drink gets ice
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
