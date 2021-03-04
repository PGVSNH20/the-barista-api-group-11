using System;
using System.Collections.Generic;

public interface IBeverage{
	List<Ingredient> Ingredients { get; }
    string CupType { get; }
    IBeverage AddIngredient(Ingredient newIngredient);

    public IBeverage ServeBeverage();

}
public class Ingredient
{
    public Ingredient(int amount, string type)
    {
        Amount = amount;
        Type = type;
    }
    public int Amount { get; set; }
    public string Type { get; set; }
}

class Beverage : IBeverage
{
    public List<Ingredient> Ingredients { get; set; }

    public string CupType => this.Name;
    private string Name { get; set; }
    public Beverage(string name)
    {
        Name = name;
        Ingredients = new List<Ingredient>();
    }

    public IBeverage AddIngredient(Ingredient newIngredient)
    {
        this.Ingredients.Add(newIngredient);
        return this;
    }

    public IBeverage ServeBeverage()
    {
        Console.WriteLine($"A cup of {this.Name}.");
        foreach (Ingredient ingredient in Ingredients)
        {
            Console.WriteLine($"\twith some {ingredient.Amount} of the {ingredient.Type}");
        }
        return this;
    }
}
/*
class GreenTea : IBeverage
{
    public List<Ingredient> Ingredients { get; set; }
    public string CupType => this.GetType().ToString();
    public GreenTea()
    {
        Ingredients = new List<Ingredient>();
    }
    public IBeverage AddIngredient(Ingredient newIngredient)
    {
        this.Ingredients.Add(newIngredient);
        return this;
    }
    public IBeverage WhatIsThis()
    {
        Console.WriteLine($"A cup of {this.CupType}.");
        foreach (Ingredient ingredient in Ingredients)
        {
            Console.WriteLine($"\twith some {ingredient.Amount} of the {ingredient.Type}");
        }
        return this;
    }
}

class Juice : IBeverage
{
    public List<Ingredient> Ingredients { get; set; }
    public string CupType => this.GetType().ToString();
    public Juice()
    {
        Ingredients = new List<Ingredient>();
    }
    public IBeverage AddIngredient(Ingredient newIngredient)
    {
        this.Ingredients.Add(newIngredient);
        return this;
    }
    public IBeverage WhatIsThis()
    {
        Console.WriteLine($"A cup of {this.CupType}.");
        foreach (Ingredient ingredient in Ingredients)
        {
            Console.WriteLine($"\twith some {ingredient.Amount} of the {ingredient.Type}");
        }
        return this;
    }
} 


class Coffee : IBeverage
{
    public List<Ingredient> Ingredients { get; set; }
    public string CupType => this.GetType().ToString();
    public Coffee()
    {
        Ingredients = new List<Ingredient>();
    }
    public Coffee AddWater(Ingredient newIngredient)
    {
        if (newIngredient.Type.ToLower() == "water")
            this.Ingredients.Add(newIngredient);
        return this;
    }
    public Coffee AddBeans(Ingredient newIngredient)
    {
        if (newIngredient.Type.ToLower() == "beans")
            this.Ingredients.Add(newIngredient);
        return this;
    }
    public IBeverage AddIngredient(Ingredient newIngredient)
    {
        this.Ingredients.Add(newIngredient);
        return this;
    }
    public IBeverage WhatIsThis()
    {
        Console.WriteLine($"A cup of {this.CupType}.");
        foreach (Ingredient ingredient in Ingredients)
        {
            Console.WriteLine($"\twith some {ingredient.Amount} of the {ingredient.Type}");
        }
        return this;
    }
}

*/