namespace Pizzeria;

public class Pizza  
{
    private string[] availableIngredients = { "Cheese", "Pepperoni", "Ham", "Pineapple", "Mushrooms" };

 
    public void OrderPizza()
    {
        Console.WriteLine("A normal pizza has been delivered!");
    }
    
    
    public void OrderPizza(string[] ingredients)
    {
        foreach (string ingredient in ingredients)
        {
            if (!IngredientExists(ingredient))
            {
                Console.WriteLine($"Sorry, the ingredient {ingredient} is not valid.");
                return;
            }
        }

        Console.WriteLine("The pizza has been delivered!");
    }


    public void OrderPizza(bool extraCheese)
    {
        if (extraCheese)
        {
            Console.WriteLine("A normal pizza with extra cheese has been delivered!");
        }
        else
        {
            Console.WriteLine("A normal pizza has been delivered!");
        }
    }

   
    private bool IngredientExists(string ingredient)
    {
        foreach (string item in availableIngredients)
        {
            if (item == ingredient)
            {
                return true;
            }
        }
        return false;
    }
}