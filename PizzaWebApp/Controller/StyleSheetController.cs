using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PizzaWebApp.Service;

namespace PizzaWebApp.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class StyleSheetController : ControllerBase
    {
        //add Service
        StyleSheetService styleSheetService;
        //add constructor
        public StyleSheetController(StyleSheetService styleSheetService)
        {
            this.styleSheetService=styleSheetService;
        }
        //get Record
        [HttpGet]
        public string Get()
        {
            return styleSheetService.getStyleSheetRecord();
        }
    }
}
