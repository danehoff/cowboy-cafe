/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Texxas Tea

* Purpose: Represents the Texas tea including calories, price, lemon, and ice.

*/
using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// Base Class for the Texas Tea class
    /// </summary>
    public class TexasTea: Drink
    {
        /// <summary>
        /// Default bool set to false representing sweet tea.
        /// </summary>
        private bool sweet = true;
        /// <summary>
        /// Whether or not the tea is sweet or not.
        /// </summary>
        public bool Sweet
        {

            get { return sweet; }
            set { 
                sweet = value;
                NotifyPropertyChanged("Sweet");
            }

        }

        /// <summary>
        /// Prices for the Tea based on size
        /// </summary>
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
                        throw new NotImplementedException("Unknown Size.");

                }

            }

        }

        /// <summary>
        /// The total calories in the Tea based on size.
        /// </summary>
        public override uint Calories
        {
            get
            {
                if(sweet != true)
                {

                    switch (Size)
                    {

                        case Size.Large:
                            return 18;

                        case Size.Medium:
                            return 11;

                        case Size.Small:
                            return 5;

                        default:
                            throw new NotImplementedException("Unknown Size.");

                    }

                }

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

        /// <summary>
        /// Default bool set to false representing lemon.
        /// </summary>
        private bool lemon = false;
        /// <summary>
        /// Whether or not the tea gets a lemon.
        /// </summary>
        public bool Lemon
        {

            get { return lemon; }
            set { 
                lemon = value;
                NotifyPropertyChanged("Lemon");
            }

        }

        /// <summary>
        /// Default bool set to true as the ice.
        /// </summary>
        private bool ice = true;
        /// <summary>
        /// If the tea gets ice.
        /// </summary>
        public override bool Ice
        {


            get { return ice; }
            set { 
                ice = value; 
                NotifyPropertyChanged("Ice");
            }

        }

        /// <summary>
        /// Instructions including whether to add ice and or a lemon as well.
        /// </summary>
        public override List<string> SpecialInstructions
        {

            get
            {

                var instructions = new List<string>();
                if (!ice) instructions.Add("Hold Ice");
                if (lemon) instructions.Add("Add Lemon");
                return instructions;

            }
        }
        /// <summary>
        /// Readable string representing drink Texas Tea.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            switch (Size)
            {

                case Size.Large:
                    if (Sweet) return "Large Texas Sweet Tea";
                    return "Large Texas Plain Tea";

                case Size.Medium:
                    if (Sweet) return "Medium Texas Sweet Tea";
                    return "Medium Texas Plain Tea";

                case Size.Small:
                    if (Sweet) return "Small Texas Sweet Tea";
                    return "Small Texas Plain Tea";

                default:
                    throw new NotImplementedException();

            }
        }
    }
}
