using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using CowboyCafe.Data;
using CowboyCafe.Data.Entrees;
using CowboyCafe.Data.Enums;

namespace Website.Pages
{
    public class IndexModel : PageModel
    {
        /// <summary>
        /// Reader for Model
        /// </summary>
        private readonly ILogger<IndexModel> _logger;

        /// <summary>
        /// The information put into the search bar
        /// </summary>
        [BindProperty (SupportsGet = true)]
        public string SearchTerms { get; set; }

        /// <summary>
        /// Holds the food categories
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public string [] FoodCat { get; set; }

        /// <summary>
        /// Holds our entrees list
        /// </summary>
        public IEnumerable<IOrderItem> Entrees { get; set; }

        /// <summary>
        /// Holds our drinks list
        /// </summary>
        public IEnumerable<IOrderItem> Drinks { get; set; }

        /// <summary>
        /// Holds our sides list
        /// </summary>
        public IEnumerable<IOrderItem> Sides { get; set; }


        public IEnumerable<SodaFlavor> Flavors { get; set; }

        public IEnumerable<IOrderItem> AllFood { get; set; }

        /// <summary>
        /// Value of the current lowest calorie item
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public uint? CaloriesMin { get; set; }

        /// <summary>
        /// Cvalue of teh current max calorie item
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public uint? CaloriesMax { get; set; }

        /// <summary>
        /// Current min price of items
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PricesMin { get; set; }

        /// <summary>
        /// Current max price of items
        /// 
        /// </summary>
        [BindProperty(SupportsGet = true)]
        public double? PricesMax { get; set; }

        [BindProperty(SupportsGet = true)]
        public string [] CategoryType { get; set; }


        /// <summary>
        /// Reads index model
        /// </summary>
        /// <param name="logger"></param>
        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// Gets these for the model
        /// </summary>
        public void OnGet(double? PricesMin, double? PricesMax, uint? CaloriesMin, uint? CaloriesMax)
        {
            
            this.PricesMax = PricesMax;
            this.PricesMin = PricesMin;
            this.CaloriesMax = CaloriesMax;
            this.CaloriesMin = CaloriesMin;
            

            SearchTerms = Request.Query["SearchTerms"];
            FoodCat = Request.Query["FoodCat"];

            
            this.Entrees = Menu.Entrees();
            this.Drinks = Menu.Drinks();
            this.Sides = Menu.Sides();
            this.Flavors = Menu.JerkedFlavor();
            /*
            Entrees = Menu.FilterSearch(Entrees, SearchTerms);
            Sides = Menu.FilterSearch(Sides, SearchTerms);
            Drinks = Menu.FilterSearch(Drinks, SearchTerms);
            Entrees = Menu.FilterByCalories(Entrees, CaloriesMin, CaloriesMax);
            Sides = Menu.FilterByCalories(Sides, CaloriesMin, CaloriesMax);
            Drinks = Menu.FilterByCalories(Drinks, CaloriesMin, CaloriesMax);
            Entrees = Menu.FilterByPrices(Entrees, PricesMin, PricesMax);
            Sides = Menu.FilterByPrices(Sides, PricesMin, PricesMax);
            Drinks = Menu.FilterByPrices(Drinks, PricesMin, PricesMax);
            */

            AllFood = Menu.CompleteMenu();

            
            if (SearchTerms != null)
            {

                AllFood = AllFood.Where(food => food.ToString().Contains(SearchTerms, StringComparison.InvariantCultureIgnoreCase));

            }

            if(FoodCat != null)
            {

                AllFood = AllFood.Where(food => food.ToString().Contains(FoodCat.ToString(), StringComparison.InvariantCultureIgnoreCase));

            }

            if(PricesMin != null && PricesMax != null)
            {

                AllFood = AllFood.Where(food => food.Price.ToString().Contains(PricesMin.ToString(), StringComparison.InvariantCultureIgnoreCase));
                AllFood = AllFood.Where(food => food.Price.ToString().Contains(PricesMax.ToString(), StringComparison.InvariantCultureIgnoreCase));
            
            }

            if (CaloriesMin != null && CaloriesMax != null)
            {

                AllFood = AllFood.Where(food => food.Calories.ToString().Contains(CaloriesMin.ToString(), StringComparison.InvariantCultureIgnoreCase));
                AllFood = AllFood.Where(food => food.Calories.ToString().Contains(CaloriesMax.ToString(), StringComparison.InvariantCultureIgnoreCase));
            }
            

        }



    }
}
