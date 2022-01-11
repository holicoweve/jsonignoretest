using Newtonsoft.Json;

namespace dotnet2.Controllers
{
    public class Demo
    {
        [JsonIgnore] 
        public string Secret { get; set; }
        
        public string Plain { get; set; }
    }
}

