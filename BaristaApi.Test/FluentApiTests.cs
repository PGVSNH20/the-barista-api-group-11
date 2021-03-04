using Xunit;

namespace BaristaApi.Tests
{
    public class FluentApiTests 
    {
        [Fact]
        public void When_AddingWaterAndBeans_Expect_Espresso(){
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
    }
}