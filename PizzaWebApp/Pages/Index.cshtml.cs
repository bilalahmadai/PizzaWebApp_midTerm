using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using PizzaWebApp.Model;
using PizzaWebApp.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzaWebApp.Pages
{
    public class IndexModel : PageModel
    {
        JsonFilePizzaService PizzaService;

        // Need variable for Book Record
        public IEnumerable<Pizza> Pizza;

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger, JsonFilePizzaService services)
        {
            _logger = logger;
            //---added----------
            PizzaService = services;
        }

        public void OnGet()
        {
            //--------added---
            Pizza = PizzaService.getPizzaRecord();
        }
    }
}
