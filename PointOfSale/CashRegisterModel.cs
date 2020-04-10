/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Cash Register Model

* Purpose: Represents the adding and removal of coins and bills.

*/
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;

namespace PointOfSale
{
    public class CashRegisterModel : INotifyPropertyChanged
    {
        /// <summary>
        /// Property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Drawer to keeep consistent number of cash
        /// </summary>
        static CashDrawer drawer = new CashDrawer();

        /// <summary>
        /// Number of each instance of money.
        /// </summary>
        private int pennysQuant = 0;
        private int quartersQuant = 0;
        private int nickelsQuant = 0;
        private int dimesQuant = 0;
        private int halfQuartersQuant = 0;
        private int dollarsQuant = 0;
        private int onesQuant = 0;
        private int twosQuant = 0;
        private int fivesQuant = 0;
        private int tensQuant = 0;
        private int twentysQuant = 0;
        private int fiftysQuant = 0;
        private int hundredsQuant = 0;


        /// <summary>
        /// Gets the total value within the drawer
        /// </summary>
        public double TotalValue => drawer.TotalValue;

        /// <summary>
        /// Gets and sets the number of pennies in the drawer
        /// </summary>
        public int Pennies
        {

            get => pennysQuant;

            set
            {

                if (pennysQuant == value || value < 0) return;

                int quantity = value - pennysQuant;
                pennysQuant = value;
                if (quantity > 0) drawer.AddCoin(Coins.Penny, quantity);
                else drawer.RemoveCoin(Coins.Penny, -quantity);
                InvokePropertyChanged("Pennies");

            }

        }
        /// <summary>
        /// Gets and sets the number of quarters in the drawer
        /// </summary>
        public int Quarters
        {

            get => quartersQuant;

            set
            {

                if (quartersQuant == value || value < 0) return;

                int quantity = value - quartersQuant;
                quartersQuant = value;
                if (quantity > 0) drawer.AddCoin(Coins.Quarter, quantity);
                else drawer.RemoveCoin(Coins.Quarter, -quantity);
                InvokePropertyChanged("Quarters");

            }

        }

        /// <summary>
        /// Gets and sets the number of nickels in the drawer
        /// </summary>
        public int Nickels
        {

            get => nickelsQuant;

            set
            {

                if (nickelsQuant == value || value < 0) return;

                int quantity = value - nickelsQuant;
                nickelsQuant = value;
                if (quantity > 0) drawer.AddCoin(Coins.Nickel, quantity);
                else drawer.RemoveCoin(Coins.Nickel, -quantity);
                InvokePropertyChanged("Nickels");

            }

        }

        /// <summary>
        /// Gets and sets the number of dimes in the drawer
        /// </summary>
        public int Dimes
        {

            get => dimesQuant;

            set
            {

                if (dimesQuant == value || value < 0) return;

                int quantity = value - dimesQuant;
                dimesQuant = value;
                if (quantity > 0) drawer.AddCoin(Coins.Dime, quantity);
                else drawer.RemoveCoin(Coins.Dime, -quantity);
                InvokePropertyChanged("Dimes");

            }

        }

        /// <summary>
        /// Gets and sets the number of =halfdollars in the drawer
        /// </summary>
        public int HalfDollars
        {

            get => halfQuartersQuant;

            set
            {

                if (halfQuartersQuant == value || value < 0) return;

                int quantity = value - halfQuartersQuant;
                halfQuartersQuant = value;
                if (quantity > 0) drawer.AddCoin(Coins.HalfDollar, quantity);
                else drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                InvokePropertyChanged("HalfDollars");

            }

        }

        /// <summary>
        /// Gets and sets the number of dollars in the drawer
        /// </summary>
        public int Dollars
        {

            get => dollarsQuant;

            set
            {

                if (dollarsQuant == value || value < 0) return;

                int quantity = value - dollarsQuant;
                dollarsQuant = value;
                if (quantity > 0) drawer.AddCoin(Coins.Dollar, quantity);
                else drawer.RemoveCoin(Coins.Dollar, -quantity);
                InvokePropertyChanged("Dollars");

            }

        }

        /// <summary>
        /// Gets and sets the number of ones in the drawer
        /// </summary>
        public int Ones
        {

            get => onesQuant;

            set
            {

                if (onesQuant == value || value < 0) return;
                int quantity = value - onesQuant;
                onesQuant = value;

                
                if (quantity > 0) drawer.AddBill(Bills.One, quantity);
                else drawer.RemoveBill(Bills.One, -quantity);
                InvokePropertyChanged("Ones");

            }

        }

        /// <summary>
        /// Gets and sets the number of twos in the drawer
        /// </summary>
        public int Twos
        {

            get => twosQuant;

            set
            {

                if (twosQuant == value || value < 0) return;

                int quantity = value - twosQuant;
                twosQuant = value;
                if (quantity > 0) drawer.AddBill(Bills.Two, quantity);
                else drawer.RemoveBill(Bills.Two, -quantity);
                InvokePropertyChanged("Twos");

            }

        }

        /// <summary>
        /// Gets and sets the number of fives in the drawer
        /// </summary>
        public int Fives
        {

            get => fivesQuant;

            set
            {

                if (fivesQuant == value || value < 0) return;

                int quantity = value - fivesQuant;
                fivesQuant = value;
                if (quantity > 0) drawer.AddBill(Bills.Five, quantity);
                else drawer.RemoveBill(Bills.Five, -quantity);
                InvokePropertyChanged("Fives");

            }

        }

        /// <summary>
        /// Gets and sets the number of tens in the drawer
        /// </summary>
        public int Tens
        {

            get => tensQuant;

            set
            {

                if (tensQuant == value || value < 0) return;

                int quantity = value - tensQuant;
                tensQuant = value;
                if (quantity > 0) drawer.AddBill(Bills.Ten, quantity);
                else drawer.RemoveBill(Bills.Ten, -quantity);
                InvokePropertyChanged("Tens");

            }

        }

        /// <summary>
        /// Gets and sets the number of twenties in the drawer
        /// </summary>
        public int Twenties
        {

            get => twentysQuant;

            set
            {

                if (twentysQuant == value || value < 0) return;

                int quantity = value - twentysQuant;
                twentysQuant = value;
                if (quantity > 0) drawer.AddBill(Bills.Twenty, quantity);
                else drawer.RemoveBill(Bills.Twenty, -quantity);
                InvokePropertyChanged("Twentys");

            }

        }

        /// <summary>
        /// Gets and sets the number of fifties in the drawer
        /// </summary>
        public int Fifties
        {

            get => fiftysQuant;

            set
            {

                if (fiftysQuant == value || value < 0) return;

                int quantity = value - fiftysQuant;
                fiftysQuant = value;
                if (quantity > 0) drawer.AddBill(Bills.Fifty, quantity);
                else drawer.RemoveBill(Bills.Fifty, -quantity);
                InvokePropertyChanged("Fiftys");

            }

        }

        /// <summary>
        /// Gets and sets the number of hundreds in the drawer
        /// </summary>
        public int Hundreds
        {

            get => hundredsQuant;

            set
            {

                if (hundredsQuant == value || value < 0) return;

                int quantity = value - hundredsQuant;
                hundredsQuant = value;
                if (quantity > 0) drawer.AddBill(Bills.Hundred, quantity);
                else drawer.RemoveBill(Bills.Hundred, -quantity);
                InvokePropertyChanged("Hundreds");

            }

        }

        /// <summary>
        /// Property Changed
        /// </summary>
        void InvokePropertyChanged(string denomination)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));

        }


    }
}
