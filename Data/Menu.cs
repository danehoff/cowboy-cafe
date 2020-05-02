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

        /// <summary>
        /// Filters our search to find the entered value
        /// </summary>
        /// <param name="food">Items of food</param>
        /// <param name="name">Name entered</param>
        /// <returns>Items with searched name</returns>
        public static IEnumerable<IOrderItem> FilterSearch(IEnumerable<IOrderItem> food, string name)
        {

            if (name == null || name == "")
            {

                return food;

            }

            List<IOrderItem> searchedFood = new List<IOrderItem>();

            foreach (IOrderItem allFood in food)
            {
                if (allFood.ToString().Contains(name, StringComparison.CurrentCultureIgnoreCase))
                {
                    searchedFood.Add(allFood);
                }
            }


            return searchedFood;
        }

        /// <summary>
        /// Filters food by the calorie value
        /// </summary>
        /// <param name="foods">list of foods</param>
        /// <param name="min">Min calorie value</param>
        /// <param name="max">Max calorie value</param>
        /// <returns>Fodds in the range of calories</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> foods, uint? min, uint? max)
        {

            if (min == null && max == null) return foods;
            var results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem food in foods)
                {
                    if (food.Calories <= max) results.Add(food);
                }
                return results;
            }
            if (max == null)
            {
                foreach (IOrderItem food in foods)
                {
                     if (food.Calories >= min) results.Add(food);
                }
                return results;
            }

            foreach (IOrderItem food in foods)
            {
                if (food.Calories >= min && food.Calories <= max)
                {
                    results.Add(food);
                }
            }
            return results;

        }

        /// <summary>
        /// Filters food by prices
        /// </summary>
        /// <param name="foods">List of items</param>
        /// <param name="min">Min price of food</param>
        /// <param name="max">Max price of food</param>
        /// <returns>Food within price range</returns>
        public static IEnumerable<IOrderItem> FilterByPrices(IEnumerable<IOrderItem> foods, double? min, double? max)
        {

            if (min == null && max == null) return foods;
            var results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem food in foods)
                {
                    if (food.Price <= max) results.Add(food);
                }
                return results;
            }
            if (max == null)
            {
                foreach (IOrderItem food in foods)
                {
                    if (food.Price >= min) results.Add(food);
                }
                return results;
            }

            foreach (IOrderItem food in foods)
            {
                if (food.Price >= min && food.Price <= max)
                {
                    results.Add(food);
                }
            }
            return results;

        }

    }
}
