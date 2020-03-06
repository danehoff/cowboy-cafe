﻿using System;
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

        private void AddAngryChickenButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new AngryChicken());

            }
        }

        private void AddCowpokeChiliButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new CowpokeChili());

            }
        }

        private void AddRustlersRibsButton_Click(object sender, RoutedEventArgs e)
        {

            if (DataContext is Order data)
            {

                data.Add(new RustlersRibs());

            }

        }

        private void AddPecosPulledPorkButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new PecosPulledPork());

            }
        }

        private void AddTrailBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new TrailBurger());

            }
        }

        private void AddDakotaDoubleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new DakotaDoubleBurger());

            }
        }

        private void AddTexasTripleBurgerButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new TexasTripleBurger());

            }
        }

        private void AddChiliCheeseFriesButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new ChiliCheeseFries());

            }
        }

        private void AddCornDodgersButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new CornDodgers());

            }
        }

        private void AddPanDeCampoButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new PanDeCampo());

            }
        }

        private void AddBakedBeansButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new BakedBeans());

            }
        }

        private void AddJerkedSodaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new JerkedSoda());

            }
        }

        private void AddTexasTeaButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new TexasTea());

            }
        }

        private void AddCowboyCoffeeButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {

                data.Add(new CowboyCoffee());

            }
        }

        private void AddWaterButton_Click(object sender, RoutedEventArgs e)
        {

            if (DataContext is Order data)
            {

                data.Add(new Water());

            }

        }
    }
}
