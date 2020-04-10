/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Cash Control

* Purpose: Represents the controls for the cash 

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
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashControl.xaml
    /// </summary>
    public partial class CashControl : UserControl
    {
        /// <summary>
        /// Making of denomination property
        /// </summary>
        public static readonly DependencyProperty DenominationProperty =
               DependencyProperty.Register(
                   "Denomination",
                   typeof(Bills),
                   typeof(CashControl),
                   new PropertyMetadata(Bills.One)

                   );
        /// <summary>
        /// Bills Denomination
        /// </summary>
        public Bills Denomination
        {

            get
            {
                return (Bills)GetValue(DenominationProperty);
            }
            set
            {
                SetValue(DenominationProperty, value);
            }

        }
        /// <summary>
        /// Making of quantity property
        /// </summary>
        public static readonly DependencyProperty QuantityProperty =
            DependencyProperty.Register(
                "Quantity",
                typeof(int),
                typeof(CashControl),
                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
                );

        /// <summary>
        /// Quantity of bill
        /// </summary>
        public int Quantity
        {
            get => (int)GetValue(QuantityProperty);
            set => SetValue(QuantityProperty, value);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public CashControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Increases the numbers of bill
        /// </summary>
        public void OnIncreaseClicked(object sender, RoutedEventArgs e)
        {

            Quantity++;

        }

        /// <summary>
        /// Decreases the number of bill
        /// </summary>
        public void OnDecreaseClicked(object sender, RoutedEventArgs e)
        {

            Quantity--;

        }
    }
}
