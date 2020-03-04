/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Order Control

* Purpose: Represents the operations of our order control
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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public OrderControl()
        {

            InitializeComponent();
            
        }

        /// <summary>
        /// Adds Angry Chicken to the ordered list
        /// </summary>
        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new AngryChicken());
        }
        /// <summary>
        /// Adds Cowpoke Chili to the ordered list
        /// </summary>
        
        private void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CowpokeChili());
        }

        /// <summary>
        /// Adds Rustler's Ribs to the ordered list
        /// </summary>
        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new RustlersRibs());
        }

        /// <summary>
        /// Adds Pecos Pulled Pork to the ordered list
        /// </summary>
        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new PecosPulledPork());
        }

        /// <summary>
        /// Adds Trail Burger to the ordered list
        /// </summary>
        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TrailBurger());
        }

        /// <summary>
        /// Adds Dakota Double Burger to the ordered list
        /// </summary>
        private void AddDakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new DakotaDoubleBurger());
        }

        /// <summary>
        /// Adds Texas Triple Burger to the ordered list
        /// </summary>
        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TexasTripleBurger());
        }

        /// <summary>
        /// Adds Chili Cheese Fries to the ordered list
        /// </summary> 
        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new ChiliCheeseFries());
        }

        /// <summary>
        /// Adds Corn Dodgers to the ordered list
        /// </summary>
        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CornDodgers());
        }

        /// <summary>
        /// Adds Pan de Campo to the ordered list
        /// </summary>
        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new PanDeCampo());
        }

        /// <summary>
        /// Adds Baked Beans to the ordered list
        /// </summary>
        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new BakedBeans());
        }
        /// <summary>
        /// Adds Jerked Soda to the ordered list
        /// </summary>
        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new JerkedSoda());
        }

        /// <summary>
        /// Adds Texas Tea to the ordered list
        /// </summary>
        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new TexasTea());
        }

        /// <summary>
        /// Adds Cowboy Coffee to the ordered list
        /// </summary>
        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new CowboyCoffee());
        }
        /// <summary>
        /// Adds Water to the order list
        /// </summary>
        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {
            OrderList.Items.Add(new Water());
        }
    }
}
