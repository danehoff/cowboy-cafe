/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Transactions 

* Purpose: Represents the transactions types based on the button clikced.

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
using CowboyCafe.Data.Sides;
using CowboyCafe.Data.Drinks;
using CowboyCafe.Data.Enums;
using CashRegister;
using PointOfSale.Customize;
using PointOfSale.Customization;
using PointOfSale.ExtensionMethods;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for Transactions.xaml
    /// </summary>
    public partial class Transactions : UserControl
    {
        /// <summary>
        /// constructor
        /// </summary>
        public Transactions(Order curOrder)
        {
            InitializeComponent();
            data = curOrder;
        }

        /// <summary>
        /// Order data on summary control
        /// </summary>
        Order data;

        /// <summary>
        /// Processes the transaction and either prints out a receipt or returns the user a error
        /// </summary>
        private void CreditButton_Click(object sender, RoutedEventArgs e)
        {
            ReceiptPrinter receipt = new ReceiptPrinter();
            CardTerminal card = new CardTerminal();
            DateTime now = DateTime.Now;

            ///string[] s = data.Prices;

            switch (card.ProcessTransaction(data.TaxedSubtotal).ToString())
            {

                /// + now + "\n" + data.Items + "\n" + data.ItemPrices + "\n" + data.Subtotal + "\n" + data.TaxedSubtotal + "\n" + "Credit Transaction."
                case "Success":
                    receipt.Print(data.OrderNumber.ToString() + "\n");
                    receipt.Print(now + "\n");
                    foreach (IOrderItem item in data.Items)
                    {
                        ///foreach(string s in itemPrices)
                        ///{
                        
                            receipt.Print(item + "\n");
                            ///receipt.Print(str + "\n");

                        ///}
                    }
                    ////+ "   " + str 
                    receipt.Print("Subtotal = " + data.Subtotal + "\n");
                    receipt.Print("Taxed Total = " + data.TaxedSubtotal + "\n");
                    receipt.Print("Credit Transaction.  \n");
                    break;
                case "InsufficientFunds":
                    MessageBox.Show("Error: Insufficient Funds. There is not enough funds on the card.");
                    break;
                case "CancelledCard":
                    MessageBox.Show("Error: Card Cancelled. This card is no longer in order and has been cancelled.");
                    break;
                case "ReadError":
                    MessageBox.Show("Error: Read Error. Please try the card again.");
                    break;
                case "Unknown Error":
                    MessageBox.Show("Error: Unknown Error. Please try the card again.");
                    break;
            }

        }
        /// <summary>
        /// Swaps screens to the drawer to add and remove cash.
        /// </summary>
        private void CashButton_Click(object sender, RoutedEventArgs e)
        {

            var orderControl = this.FindAncestor<OrderControl>();
            CashRegisterControl screen = new CashRegisterControl();
            orderControl?.SwapScreen(screen);

        }

        /// <summary>
        /// Sends the user back to the menu screen to fix any issues with the order
        /// </summary>
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            MenuItemSelectionControl menu = new MenuItemSelectionControl();

            orderControl?.SwapScreen(menu);

        }



    }
}
