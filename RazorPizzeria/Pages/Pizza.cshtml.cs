using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> fakePizzaDB = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageTitle = "Margerita",
                PizzaName="Margerita",
                BasePrice=100,
                TomatoSauce=true,
                Cheese=true,
                FinalPrice=110
            },
            new PizzasModel()
            {
                ImageTitle = "Bolognese",
                PizzaName="Bolognese",
                BasePrice=100,
                TomatoSauce=true,
                Cheese=true,
                Beef=true,
                FinalPrice=115
            },
            new PizzasModel()
            {
                ImageTitle = "Hawaiian",
                PizzaName="Hawaiian",
                BasePrice=100,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                Pineapple=true,
                FinalPrice=120
            },
            new PizzasModel()
            {
                ImageTitle = "Carbonara",
                PizzaName="Carbonara",
                BasePrice=100,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                Mushroom=true,
                FinalPrice=120
            },
            new PizzasModel()
            {
                ImageTitle = "MeatFeast",
                PizzaName="MeatFeast",
                BasePrice=100,
                TomatoSauce=true,
                Cheese=true,
                Ham=true,
                Beef=true,
                FinalPrice=120
            },
            new PizzasModel()
            {
                ImageTitle = "Mushroom",
                PizzaName="Mushroom",
                BasePrice=100,
                TomatoSauce=true,
                Cheese=true,
                Mushroom=true,
                FinalPrice=115
            },
            new PizzasModel()
            {
                ImageTitle = "Pepperoni",
                PizzaName="Pepperoni",
                BasePrice=100,
                TomatoSauce=true,
                Cheese=true,
                Peperoni=true,
                FinalPrice=115
            },
            new PizzasModel()
            {
                ImageTitle = "Seafood",
                PizzaName="Seafood",
                BasePrice=100,
                TomatoSauce=true,
                Cheese=true,
                Tuna=true,
                FinalPrice=115
            },
            new PizzasModel()
            {
                ImageTitle = "Vegetarian",
                PizzaName="Vegetarian",
                BasePrice=100,
                TomatoSauce=true,
                Cheese=true,
                Mushroom=true,
                Pineapple=true,
                FinalPrice=120
            }
        };
        public void OnGet()
        {
        }
    }
}
