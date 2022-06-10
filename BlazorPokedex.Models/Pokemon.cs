﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace BlazorPokedex.Models
{
    public class Pokemon
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("type")]
        public List<Type> Types { get; set; }
        [JsonProperty("sprites")]
        public List<Sprite> Sprites { get; set; }
    }
}
