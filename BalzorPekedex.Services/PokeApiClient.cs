using BlazorPokedex.Models;
using System;
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
        public Task<IEnumerable<Pokemon>> GetAllPokemons()
        {
            throw new NotImplementedException();
        }

        public Task<Pokemon> GetPokemon()
        {
            throw new NotImplementedException();
        }
    }
}
