/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Order Summary Control

* Purpose: Represents the operations of our order summary control.
*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;
using PointOfSale.Customize;
using PointOfSale.Customization;
using PointOfSale.ExtensionMethods;
using CowboyCafe.Data.Sides;
using CowboyCafe.Data.Drinks;
using CowboyCafe.Data.Enums;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        public OrderSummaryControl()
        {
            InitializeComponent();
        }


        
        /// <summary>
        /// Swaps screen for instructions on items ordered
        /// </summary>
        private void OrderList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            foreach (object items in e.AddedItems)
            {

                if(items is AngryChicken)
                {
                    var screen = new AngryChickenCustomize();
                    screen.DataContext = items;
                    orderControl?.SwapScreen(screen);

                }
                else if(items is CowboyCoffee)
                {
                    var screen = new CowboyCoffeeCustomize();
                    screen.DataContext = items;
                    orderControl?.SwapScreen(screen);

                }
                else if (items is CowpokeChili)
                {
                    var screen = new CowpokeChiliCustomize();
                    screen.DataContext = items;
                    orderControl?.SwapScreen(screen);

                }
                else if (items is JerkedSoda)
                {
                    var screen = new JerkedSodaCustomize();
                    screen.DataContext = items;
                    orderControl?.SwapScreen(screen);

                }
                else if (items is DakotaDoubleBurger)
                {
                    var screen = new DakotaDoubleBurgerCustomize();
                    screen.DataContext = items;
                    orderControl?.SwapScreen(screen);

                }
                else if (items is PecosPulledPork)
                {
                    var screen = new PecosPulledPorkCustomize();
                    screen.DataContext = items;
                    orderControl?.SwapScreen(screen);

                }
                else if (items is TexasTea)
                {
                    var screen = new TexasTeaCustomize();
                    screen.DataContext = items;
                    orderControl?.SwapScreen(screen);

                }
                else if (items is TexasTripleBurger)
                {
                    var screen = new TexasTripleBurgerCustomize();
                    screen.DataContext = items;
                    orderControl?.SwapScreen(screen);

                }
                else if (items is TrailBurger)
                {
                    var screen = new TrailBurgerCustomize();
                    screen.DataContext = items;
                    orderControl?.SwapScreen(screen);

                }
                else  if (items is Water)
                {


                    var screen = new WaterCustomize();
                    screen.DataContext = items;
                    orderControl?.SwapScreen(screen);


                }
            }
            

        }

        /// <summary>
        /// Deletes the object within the list when the X button is clicked
        /// </summary>
        public void OnDeleteItemButtonClicked(object sender, RoutedEventArgs e)
        {
            
            if (DataContext is Order data)
            {
                if (sender is Button button)
                {
                    if(button.DataContext is IOrderItem item)
                        data.Remove(item);

                }
            }

        }

    }
}
