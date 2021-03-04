using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaristaApi
{
    class MilkshakeMachine
    {
          
         public Beverage beverage;
             public MilkshakeMachine Shaker()
             {
                 beverage = new Beverage("Milkshake");
                 return this;
             }
             public MilkshakeMachine AddSyrup(string flavour)
             {
                 beverage.AddIngredient(new (10, $"{flavour}-Syrup"));
                 return this;
             }
             public MilkshakeMachine AddSprinkles(string flavour)
             {
                 beverage.AddIngredient(new (5, $"Sprinkles - {flavour}"));
                 return this;
             }
             public MilkshakeMachine AddIceCream(string flavour)
             {
                 beverage.AddIngredient(new (50, $"Icecream - {flavour}"));
                 return this;
             }
             public MilkshakeMachine AddALittleBitOfMilk(string MilkType)
             {
                 beverage.AddIngredient(new (5, $"{MilkType}-Milk"));
                 return this;
             }
             public MilkshakeMachine AddALotOfMilk(string MilkType)
             {
                 beverage.AddIngredient(new (15, $"{MilkType}-Milk"));
                 return this;
             }
             public Beverage FinishShaking()
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

