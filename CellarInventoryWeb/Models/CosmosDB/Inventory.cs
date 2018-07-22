using Newtonsoft.Json;

namespace CellarInventoryWeb
{
    public class Inventory
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
        public string Manufacturer { get; set; }
        public string ItemName { get; set; }
        public string ItemType { get; set; }    
        public int Year { get; set; }
        public int Quantity { get; set; } 
        public override string ToString()
        
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}