using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaWebApp.Model;
using PizzaWebApp.Service;
using System.Collections.Generic;

namespace PizzaWebApp.Pages
{
    public class PizzaMenuModel : PageModel
    {
        JsonFilePizzaService PizzaService;

        // Need variable for Book Record
        public IEnumerable<Pizza> Pizza;

        public PizzaMenuModel(JsonFilePizzaService pizzaService)
        {
            PizzaService = pizzaService;
            
        }

        public void OnGet()
        {
            Pizza = PizzaService.getPizzaRecord();
        }
    }
}
