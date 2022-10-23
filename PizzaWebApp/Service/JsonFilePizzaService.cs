using Microsoft.AspNetCore.Hosting;
using PizzaWebApp.Model;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace PizzaWebApp.Service
{
    public class JsonFilePizzaService
    {
        public IWebHostEnvironment WebHostEnvironment { get; set; }
       
        public JsonFilePizzaService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public string fileAddress
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "pizza.json");
            }
        }
        

        public IEnumerable<Pizza> getPizzaRecord()
        {
            using (var filestream = File.OpenText(fileAddress))
            {

                return JsonSerializer.Deserialize<Pizza[]>(filestream.ReadToEnd());
            }
        }
    }
}
