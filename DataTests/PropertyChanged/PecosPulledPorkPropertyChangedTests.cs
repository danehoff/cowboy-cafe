﻿using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data.Entrees;
using System.ComponentModel;

namespace CowboyCafe.DataTests.PropertyChanged
{
    public class PecosPulledPorkPropertyChangedTests
    {

        [Fact]
        public void PecosPulledPorkShouldImplementINotifyPropertyChanged()
        {

            var pork = new PecosPulledPork();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(pork);

        }

        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForBread()
        {

            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Bread", () =>
            {
                pork.Bread = false;
            });

        }

        [Fact]
        public void ChangingBreadShouldInvokePropertyChangedForSpecialInstructions()
        {

            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () =>
            {
                pork.Bread = false;
            });

        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForPickle()
        {

            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "Pickle", () =>
            {
                pork.Pickle = false;
            });

        }

        [Fact]
        public void ChangingPickleShouldInvokePropertyChangedForSpecialInstructions()
        {

            var pork = new PecosPulledPork();
            Assert.PropertyChanged(pork, "SpecialInstructions", () =>
            {
                pork.Pickle = false;
            });

        }

    }
}
