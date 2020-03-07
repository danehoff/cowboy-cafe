/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Jerked Soda

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
using System.Windows.Shapes;
using CowboyCafe.Data;

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

        ///public OnMenuISBClick(object,REA args)
        ///{

        ///if(DataContext is Order data)
        ///{

        ///data.Add(new Order());

        ////}

        ///}

        /// public void SwapScreen(FrameworkElement element)
        ///{


        ///  ContainerVisual.Child = element;

        ///}
        ///void OnMenuISBClick(object o, RoutedEventArgs args)
        ///{
        /// if (DataContext is Order data)
        ///{
        ///  data.Add(new Order());
        ///}

        /// }

        /// void OnMenuISBClick(object o, RoutedEventArgs args)
        ///{

        /// var orderControl = this.FindAncestor<OrderControl>();

        /// if (DataContext is Order data)
        /// {
        /// if(o is Button button)
        /// {

        /// switch (button.Tag)
        ///{

        ///case "CowpokeChili":
        /// var item = new CowpokeChili();
        ///var screen = new CowpokeChiliCustomize();
        ///screen.DataContext = item;
        ///Order.Add(item);
        /// orderControl?.SwapScreen(screen);
        /// break;

        /// }

        /// }

        /// data.Add(new Order());

        ///}

        ///}



        /// <summary>
        /// Adds Angry Chicken to the order list.
        /// </summary>
        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new AngryChicken());

            }
        }

        /// <summary>
        /// Adds Cowpoke chill to the order list.
        /// </summary>
        private void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new CowpokeChili());

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
            if (DataContext is Order data)
            {

                data.Add(new PecosPulledPork());

            }
        }

        /// <summary>
        /// Adds Trail burger to the order list.
        /// </summary>
        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new TrailBurger());

            }
        }

        /// <summary>
        /// Adds Dakota Double Burger to the order list.
        /// </summary>
        private void AddDakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new DakotaDoubleBurger());

            }
        }

        /// <summary>
        /// Adds texas Triple burger to the order list.
        /// </summary>
        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new TexasTripleBurger());

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
            if (DataContext is Order data)
            {

                data.Add(new JerkedSoda());

            }
        }

        /// <summary>
        /// Adds Texas Tea to the order list.
        /// </summary>
        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new TexasTea());

            }
        }

        /// <summary>
        /// Adds cowboy Coffee to the order list.
        /// </summary>
        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new CowboyCoffee());

            }
        }

        /// <summary>
        /// Adds Water to the order list.
        /// </summary>
        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {

            if (DataContext is Order data)
            {

                data.Add(new Water());

            }

        }
    }
}
