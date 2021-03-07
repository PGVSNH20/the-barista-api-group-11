using Xunit;

namespace BaristaApi.Tests
{
    public class FluentApiTests 
    {
        [Fact]
        public void When_Using_CoffeeMaker_Expect_Coffee(){
            //Pseudo code
            var coffeMachine = new CoffeeMaker();
            var beverage = coffeMachine
                            .StartBrewingCoffee()
                            .AddWater()
                            .AddBeans()
                            .FinishBrewing();
            // Assert
            Assert.Equal("Coffee", beverage.CupType);
        }

        [Fact]
        public void When_Using_JuicePress_Expect_Juice()
        {
            var juicePress = new JuicePress();
            var beverage = juicePress
                            .StartMixingJuice()
                            .AddOrange()
                            .FinishMixing();
            Assert.Equal("Juice", beverage.CupType);
        }

        [Fact]
        public void When_Using_MilkshakeMachine_Expect_Milkshake()
        {
            var milkshakeMachine = new MilkshakeMachine();
            var beverage = milkshakeMachine
                            .Shaker()
                            .AddIceCream("Strawberry")
                            .AddALotOfMilk("Chocolate")
                            .FinishShaking();
            Assert.Equal("Milkshake", beverage.CupType);
        }
        [Fact]
        public void When_Adding_Milk_To_Coffee_Expect_Milk_In_Ingredients_List()
        {
            var coffeMachine = new CoffeeMaker();
            var beverage = coffeMachine
                            .StartBrewingCoffee()
                            .AddWater()
                            .AddBeans()
                            .AddALotOfMilk()
                            .FinishBrewing();
            Assert.True(beverage.Ingredients[2].Type.ToLower() == "milk");
        }

        [Fact]
        public void Expect_Apple_In_Ingredients_When_Adding_Apple_To_Juice()
        {
            var juicePress = new JuicePress();
            var beverage = juicePress
                            .StartMixingJuice()
                            .AddOrange()
                            .AddApple()
                            .AddWater()
                            .FinishMixing();
            var containsApple = false;
            foreach (var ingredient in beverage.Ingredients)
            {
                if (!containsApple)
                {
                    if (ingredient.Type.ToLower() == "apple")
                        containsApple = true;
                }
            }
            Assert.True(containsApple);
        }
    }
}