using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    public class JuicePress
    {
        
            public Beverage beverage;
            public JuicePress StartMixingJuice()
            {
                beverage = new Beverage("Juice");
                return this;
            }
            public JuicePress AddOrange()
            {
                beverage.AddIngredient(new (20, "Orange"));
                return this;
            }
            public JuicePress AddApple()
            {
                beverage.AddIngredient(new (10, "Apple"));
                return this;
            }
            public JuicePress AddWater()
            {
                beverage.AddIngredient(new (10, "Water"));
                return this;
            }
            public JuicePress AddALittleBitOfWater()
            {
                beverage.AddIngredient(new (5, "Water"));
                return this;
            }
            public JuicePress AddIce()
            {
                beverage.AddIngredient(new (5, "Ice"));
                return this;
            }
            public Beverage FinishMixing()
            {
                Console.WriteLine($"A cup of {beverage.CupType}");
                foreach (Ingredient i in beverage.Ingredients)
                {
                    Console.WriteLine($"\t with {i.Amount}cl of {i.Type}");
                }
                return beverage;
            }
        }
}
