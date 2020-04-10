/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Coin Control

* Purpose: Has all the controls for the coins.

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
    /// Interaction logic for CoinControl.xaml
    /// </summary>
    public partial class CoinControl : UserControl
    {
        /// <summary>
        /// Making a denomination Property
        /// </summary>
        public static readonly DependencyProperty DenominationProperty =
            DependencyProperty.Register(
                "Denomination",
                typeof(Coins),
                typeof(CoinControl),
                new PropertyMetadata(Coins.Penny)
                );
        /// <summary>
        /// Coin Denomination
        /// </summary>
        public Coins Denomination
        {

            get
            {
                return (Coins)GetValue(DenominationProperty);
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
                typeof(CoinControl),
                new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault)
                );

        /// <summary>
        /// Quantity of coins
        /// </summary>
        public int Quantity
        {
            get => (int)GetValue(QuantityProperty);
            set => SetValue(QuantityProperty, value);
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public CoinControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Increases the number of coin
        /// </summary>
        public void OnIncreaseClicked(object sender, RoutedEventArgs e)
        {

            Quantity++;

        }

        /// <summary>
        /// Decreases the number of coin
        /// </summary>
        public void OnDecreaseClicked(object sender, RoutedEventArgs e)
        {

            Quantity--;

        }
    }
}
