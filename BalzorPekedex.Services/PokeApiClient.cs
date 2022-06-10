using BlazorPokedex.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorPokedex.Services
{
    public class PokeApiClient : IPokeApiClient
    {
        private HttpClient _httpClient;
        public PokeApiClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Pokemon>> GetAllPokemons()
        {
            var pokemonList = JsonConvert.DeserializeObject<ResultObject>(await _httpClient.GetStringAsync($"pokemon?offset=0&limit=24"));

            var resutlList = new List<Pokemon>();

            foreach (var poke in pokemonList.Pokemons)
            {
                resutlList.Add(await GetPokemon(poke.Name));
            }

            return resutlList;
        }

        public async Task<Pokemon> GetPokemon(string name)
        {
            return JsonConvert.DeserializeObject<Pokemon>(await _httpClient.GetStringAsync($"pokemon/{name}"));

        }
    }
}
