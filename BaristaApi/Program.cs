using System;

namespace BaristaApi
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeverage cupOfJuice = new Beverage("Apple Juice");

            cupOfJuice = cupOfJuice.AddIngredient(new (20, "water"))
                .AddIngredient(new (5, "apple")).ServeBeverage();

            IBeverage cupOfCoffee = new Beverage("Coffee")
                                    .AddIngredient(new (10, "Water"))
                                    .AddIngredient(new (5, "beans"))
                                    .AddIngredient(new (5, "milk"))
                                    .ServeBeverage();

            IBeverage starbucksCoffee = new Beverage("Starbucks sugar in water")
                                    .AddIngredient(new (10, "Water"))
                                    .AddIngredient(new (5, "beans"))
                                    .AddIngredient(new (5, "milk"))
                                    .AddIngredient(new (500, "sugar"))
                                    .ServeBeverage();

            CoffeeMaker newCoffeMaker = new CoffeeMaker();
            Beverage newCoffee = newCoffeMaker
                                    .StartBrewingCoffee()
                                    .AddWater()
                                    .AddBeans()
                                    .AddALittleBitOfMilk()
                                    .FinishBrewing();
            
            JuicePress newJuicePress = new JuicePress();
            Beverage newGlassOfJuice = newJuicePress
                                        .StartMixingJuice()
                                        .AddApple()
                                        .AddOrange()
                                        .AddALittleBitOfWater()
                                        .AddIce()
                                        .FinishMixing();

            MilkshakeMachine newMilkshakeMachine = new MilkshakeMachine();
            Beverage milkshakeMaster5000 = newMilkshakeMachine
                                            .Shaker()
                                            .AddIceCream("Chocolate")
                                            .AddSyrup("Chocolate")
                                            .AddSprinkles("Chocolate")
                                            .FinishShaking();
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
