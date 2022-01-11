using System.Text.Json.Serialization;

namespace dotnet6.Controllers;

public class Demo
{
    [JsonIgnore] 
    public string Secret { get; set; }
        
    public string Plain { get; set; }
}

