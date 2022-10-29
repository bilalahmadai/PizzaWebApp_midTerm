using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace PizzaWebApp.Service
{
    public class StyleSheetService
    {
        //env
        public IWebHostEnvironment WebHostEnvironment { get; set; }
        //contructor
        public StyleSheetService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        //address data file
        public string fileAddress
        {
            get
            {
                return Path.Combine(WebHostEnvironment.WebRootPath, "data", "stylesheet.css");
            }
        }
        //get data
        public string getStyleSheetRecord()
        {
            using(var filestream = File.OpenText(fileAddress))
            {
                return filestream.ReadToEnd();
            }
        }
    }
}
