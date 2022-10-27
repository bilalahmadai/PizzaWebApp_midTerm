using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaWebApp.Model;
using PizzaWebApp.Service;
using System.Collections.Generic;


/// working as bridge user or server and DB data
/// 
namespace PizzaWebApp.Controller
{
    [Route("[controller]")]
    [ApiController]
    public class PizzaRecordController : ControllerBase
    {
        JsonFilePizzaService PizzaService;
        public PizzaRecordController(JsonFilePizzaService pizzaService)
        {
            this.PizzaService = pizzaService;
        }

        [HttpGet]
        public IEnumerable<Pizza> Get()
        {
            return PizzaService.getPizzaRecord();
        }
    }
}
