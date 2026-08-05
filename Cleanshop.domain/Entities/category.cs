using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Cleanshop.domain.Entities;

public class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = string.Empty;

    [JsonIgnore]
    public List<Product> Products { get; set; } = new();

}

