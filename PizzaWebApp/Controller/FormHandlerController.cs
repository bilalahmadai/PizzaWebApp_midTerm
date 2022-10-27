using Microsoft.AspNetCore.Mvc;
using PizzaWebApp.Model;
using PizzaWebApp.Service;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;

namespace PizzaWebApp.Controller
{
    [Route("[controller]")]
    public class FormHandlerController : ControllerBase
    {
        JsonFilePizzaService PizzaService;

        public FormHandlerController(JsonFilePizzaService pizzaService)
        {
            PizzaService = pizzaService;
        }
        [HttpGet]
        public string Get(int id, string name, string price , string desc, string image)
        {
            Pizza obj = new Pizza();
            obj.pizza_id = id;
            obj.name = name;
            obj.price = price;
            obj.desc = desc;
            obj.image = image;
            


            IEnumerable<Pizza> pizzaData=PizzaService.getPizzaRecord();
            List<Pizza> listOfPizza= pizzaData.ToList();
            listOfPizza.Add(obj);

            return JsonSerializer.Serialize<List<Pizza>>(listOfPizza);
            
        }
    }
}
