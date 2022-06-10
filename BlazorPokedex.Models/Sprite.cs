using Newtonsoft.Json;

namespace BlazorPokedex.Models
{
    public class Sprite
    {
        // Las etiquetas se ponen por que el nombre que hemos dado en c#
        // no coincide con el nombre de la etiqueta del json y sino no se puede deserializar
        [JsonProperty("front_default")]
        public string Front { get; set; }
        [JsonProperty("back_default")]
        public string Back { get; set; }
    }
}