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
            var data = new Order();
            this.DataContext = data;
        }

        /// <summary>
        /// Takes you back to teh item selection control.
        /// </summary>
        private void ItemSelectionButton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        /// <summary>
        /// Cancels the order being taken
        /// </summary>
        private void CancelOrderButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }


        /// <summary>
        /// Completes the current order
        /// </summary>
        private void CompleteOrderButton_Click(object sender, RoutedEventArgs e)
        {
            this.DataContext = new Order();
        }
    }
}
