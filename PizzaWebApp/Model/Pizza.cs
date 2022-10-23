using System.Text.Json.Serialization;
using System.Text.Json;

namespace PizzaWebApp.Model
{
    public class Pizza
    {
        [JsonPropertyName("id")]
        public int pizza_id { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }

        [JsonPropertyName("price")]
        public string price { get; set; }

        [JsonPropertyName("desc")]
        public string desc { get; set; }

        [JsonPropertyName("image")]
        public string image { get; set; }

        public override string ToString()
        {

            return JsonSerializer.Serialize<Pizza>(this);
        }
    }
}
