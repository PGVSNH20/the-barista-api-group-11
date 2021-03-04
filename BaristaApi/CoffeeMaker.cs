using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    public class CoffeeMaker
    {
        public Beverage beverage;
        public CoffeeMaker StartBrewingCoffee()
        {
            beverage = new Beverage("Coffee");
            return this;
        }
        public CoffeeMaker AddWater()
        {
            beverage.AddIngredient(new (20, "Water"));
            return this;
        }
        public CoffeeMaker AddBeans()
        {
            beverage.AddIngredient(new (5, "Coffee Beans"));
            return this;
        }
        public CoffeeMaker AddCream()
        {
            beverage.AddIngredient(new (5, "Cream"));
            return this;
        }
        public CoffeeMaker AddALittleBitOfMilk()
        {
            beverage.AddIngredient(new (5, "Milk"));
            return this;
        }
        public CoffeeMaker AddALotOfMilk()
        {
            beverage.AddIngredient(new (15, "Milk"));
            return this;
        }
        public Beverage FinishBrewing()
        {
            Console.WriteLine($"A cup of {beverage.CupType}");
            foreach(Ingredient i in beverage.Ingredients)
            {
                Console.WriteLine($"\t with {i.Amount}cl of {i.Type}");
            }
            return beverage;
        }
    }
}
