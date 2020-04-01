/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Menu Item Selection Control

* Purpose: Represents the buttons for the order items

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
using System.ComponentModel;
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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {
        public MenuItemSelectionControl()
        {
            InitializeComponent();
        }


        ///void OnMenuISBClick(object o, RoutedEventArgs args)
        ///{
            ///if (DataContext is Order data)
            ///{
               /// data.Add(new Order());
            ///}

        ///}

        ///void OnMenuISBClick(object o, RoutedEventArgs args)
        ///{

            ///var orderControl = this.FindAncestor<OrderControl>();

            ///if (DataContext is Order data)
            ///{
                ///if(o is Button button)
                ///{

                    ///switch (button.Tag)
                    ///{

                        ///case "CowpokeChili":
                        ///var item = new CowpokeChili();
                        ///var screen = new CowpokeChiliCustomize();
                        ///screen.DataContext = item;
                        ///Order.Add(item);
                        ///orderControl?.SwapScreen(screen);
                        ///break;

                    ///}

                ///}

                ///data.Add(new Order());

            ///}

        ////}



        /// <summary>
        /// Adds Angry Chicken to the order list.
        /// </summary>
        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {

                IOrderItem item = new AngryChicken();
                var screen = new AngryChickenCustomize();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);


            }
        }

        /// <summary>
        /// Adds Cowpoke chill to the order list.
        /// </summary>
        private void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
         
            if (DataContext is Order order)
            {

                IOrderItem item = new CowpokeChili();
                var screen = new CowpokeChiliCustomize();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);

                
            }
        }


        /// <summary>
        /// Adds Rustlers ribs to the order list.
        /// </summary>
        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {

            if (DataContext is Order data)
            {

                data.Add(new RustlersRibs());

            }

        }

        /// <summary>
        /// Adds Pecos pulled pork to the order list.
        /// </summary>
        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {

                IOrderItem item = new PecosPulledPork();
                var screen = new PecosPulledPorkCustomize();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);


            }
        }

        /// <summary>
        /// Adds Trail burger to the order list.
        /// </summary>
        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {

                IOrderItem item = new TrailBurger();
                var screen = new TrailBurgerCustomize();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);


            }
        }

        /// <summary>
        /// Adds Dakota Double Burger to the order list.
        /// </summary>
        private void AddDakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {

                IOrderItem item = new DakotaDoubleBurger();
                var screen = new DakotaDoubleBurgerCustomize();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);


            }
        }

        /// <summary>
        /// Adds texas Triple burger to the order list.
        /// </summary>
        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {

                IOrderItem item = new TexasTripleBurger();
                var screen = new TexasTripleBurgerCustomize();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);


            }
        }

        /// <summary>
        /// Adds CC Fries to the order list.
        /// </summary>
        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new ChiliCheeseFries());

            }
        }

        /// <summary>
        /// Adds corn dodgers to the order list.
        /// </summary>
        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new CornDodgers());

            }
        }

        /// <summary>
        /// Adds Pan de Campo to the order list.
        /// </summary>
        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new PanDeCampo());

            }
        }

        /// <summary>
        /// Adds Baked beans to the order list.
        /// </summary>
        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new BakedBeans());

            }
        }

        /// <summary>
        /// Adds jerked soda to the order list.
        /// </summary>
        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {

                IOrderItem item = new JerkedSoda();
                var screen = new JerkedSodaCustomize();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);


            }
        }

        /// <summary>
        /// Adds Texas Tea to the order list.
        /// </summary>
        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {

                IOrderItem item = new TexasTea();
                var screen = new TexasTeaCustomize();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);


            }
        }

        /// <summary>
        /// Adds cowboy Coffee to the order list.
        /// </summary>
        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {

                IOrderItem item = new CowboyCoffee();
                var screen = new CowboyCoffeeCustomize();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);


            }
        }

        /// <summary>
        /// Adds Water to the order list.
        /// </summary>
        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {

            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order order)
            {

                IOrderItem item = new Water();
                var screen = new WaterCustomize();
                screen.DataContext = item;
                order.Add(item);
                orderControl?.SwapScreen(screen);


            }

        }
    }
}
