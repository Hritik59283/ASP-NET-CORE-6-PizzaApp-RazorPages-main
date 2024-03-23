using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Model;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>() {
        new PizzasModel() { ImageTitle = "Margerita", PizzaName = "Margerita", BasePrice = 200, TomatoSauce = true, Cheese = true, FinalPrice = 400 },
        new PizzasModel() { ImageTitle = "Bolognese", PizzaName = "Bolognese", BasePrice = 200, TomatoSauce=true, Cheese = true, Beef = true, FinalPrice = 500 },
        new PizzasModel() { ImageTitle = "Hawaiian", PizzaName = "Hawaiian", BasePrice = 200, TomatoSauce = true, Cheese = true, Ham = true, Pineapple = true, FinalPrice = 1500 },
        new PizzasModel() { ImageTitle = "Carbonara", PizzaName = "Carbonara", BasePrice = 200, TomatoSauce = true, Cheese = true, Ham = true, Mushroom = true, FinalPrice = 600 },
        new PizzasModel() { ImageTitle = "MeatFeast", PizzaName = "MeatFeast", BasePrice = 200, TomatoSauce = true, Cheese = true, Ham = true, Beef = true, FinalPrice = 600 },
        new PizzasModel() { ImageTitle = "Mushroom", PizzaName = "Mushroom", BasePrice = 200, TomatoSauce = true, Cheese = true, Mushroom = true, FinalPrice = 500 },
        new PizzasModel() { ImageTitle = "Pepperoni", PizzaName = "Pepperoni", BasePrice = 200, TomatoSauce = true, Cheese = true, Peperoni = true, FinalPrice = 500 },
        new PizzasModel() { ImageTitle = "Seafood", PizzaName = "Seafood", BasePrice = 200, TomatoSauce = true, Cheese = true, Tuna = true, FinalPrice = 500 },
        new PizzasModel() { ImageTitle = "Vegetarian", PizzaName = "Vegetarian", BasePrice = 200, TomatoSauce = true, Cheese = true, Mushroom = true, Pineapple = true, FinalPrice = 1200 },
        };
        public void OnGet()
        {
        }
    }
}
