using Newtonsoft.Json;
using System.Collections.Generic;

namespace BlazorPokedex.Models
{
    public class ResultObject
    {
        [JsonProperty("results")]
        public IEnumerable<Pokemon> Pokemons { get; set; }
    }
}
