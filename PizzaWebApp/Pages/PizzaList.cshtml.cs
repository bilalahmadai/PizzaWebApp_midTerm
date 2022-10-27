using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PizzaWebApp.Model;
using PizzaWebApp.Service;
using System.Collections.Generic;

namespace PizzaWebApp.Pages
{
    public class PizzaListModel : PageModel
    {
        JsonFilePizzaService PizzaService;
        public IEnumerable<Pizza> Pizza;
        // public BookListModel{

        //}
        //public void OnGet()
        //{
        //    Pizza = PizzaService.getPizzaRecord();
        //}
    }
}
