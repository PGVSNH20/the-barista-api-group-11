using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeverage newCup = new Juice();
            newCup.AddIngredient(new Ingredient(20, "water"))
                .AddIngredient(new Ingredient(5, "apple")).WhatIsThis();
            IBeverage secondCup = new Coffee()
                                    .AddWater(new Ingredient(10, "Water"))
                                    .AddBeans(new Ingredient(5, "beans"))
                                    .AddIngredient(new Ingredient(5, "milk"))
                                    .WhatIsThis();
            IBeverage starbucksCoffee = new Coffee()
                                    .AddWater(new Ingredient(10, "Water"))
                                    .AddBeans(new Ingredient(5, "beans"))
                                    .AddIngredient(new Ingredient(5, "milk"))
                                    .AddIngredient(new Ingredient(500, "sugar"))
                                    .WhatIsThis();
            // Test push this
            /* pseudo-code
            Espresso espresso = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 5 && b.Sort = CoffeSorts.Robusta).ToBravage();
            //espresso is type of Espresso

            Latte latte = new Espresso().AddWater(20).AddBeans(b => b.AmountInG = 7 && b.Sort = CoffeSorts.Robusta).AddMilk().ToBravage();
            //latte is type of Latte
             */
        }
    }
}
