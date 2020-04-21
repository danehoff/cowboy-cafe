/*

* Author: Dane Hoffman

* Edited by: (If you are not the original author like the CowpokeChili class)

* Class name: Menu

* Purpose: Represents the Making of the menu on our website.

*/
using System;
using System.Collections.Generic;
using System.Text;
using CowboyCafe.Data;
using CowboyCafe.Data.Sides;
using CowboyCafe.Data.Drinks;
using CowboyCafe.Data.Enums;
using CowboyCafe.Data.Entrees;

namespace CowboyCafe.Data
{
    public static class Menu
    {

        /// <summary>
        /// Makes list of entrees
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Entrees() 
        {

            List<IOrderItem> entrees = new List<IOrderItem>();
            entrees.Add(new AngryChicken());
            entrees.Add(new CowpokeChili());
            entrees.Add(new DakotaDoubleBurger());
            entrees.Add(new PecosPulledPork());
            entrees.Add(new RustlersRibs());
            entrees.Add(new TexasTripleBurger());
            entrees.Add(new TrailBurger());
            return entrees;

        }

        /// <summary>
        /// Makes List of sides
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Sides() 
        {

            List<IOrderItem> sides = new List<IOrderItem>();
            sides.Add(new BakedBeans());
            sides.Add(new ChiliCheeseFries());
            sides.Add(new CornDodgers());
            sides.Add(new PanDeCampo());
            return sides;

        }

        /// <summary>
        /// Makes list of drinks
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> Drinks() 
        {

            List<IOrderItem> drinks = new List<IOrderItem>();
            drinks.Add(new Water());
            drinks.Add(new TexasTea());
            drinks.Add(new CowboyCoffee());
            drinks.Add(new JerkedSoda());
            return drinks;

        }

        /// <summary>
        /// Makes list the Complete menu
        /// </summary>
        /// <returns></returns>
        public static IEnumerable<IOrderItem> CompleteMenu() 
        {

            List<IOrderItem> items = new List<IOrderItem>();
            items.Add(new AngryChicken());
            items.Add(new CowpokeChili());
            items.Add(new DakotaDoubleBurger());
            items.Add(new PecosPulledPork());
            items.Add(new RustlersRibs());
            items.Add(new TexasTripleBurger());
            items.Add(new TrailBurger());
            items.Add(new BakedBeans());
            items.Add(new ChiliCheeseFries());
            items.Add(new CornDodgers());
            items.Add(new PanDeCampo());
            items.Add(new Water());
            items.Add(new TexasTea());
            items.Add(new CowboyCoffee());
            items.Add(new JerkedSoda());
            return items;

        }

    }
}
