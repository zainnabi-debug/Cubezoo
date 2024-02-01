using Cubezoo_Interface.IUserDirectory;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;

namespace Cubezoo_BusinessLogic.UserDirectory
{
    public class UserDirectoryBL : IUserDirectory
    {
        private readonly HttpClient _httpClient;
        private readonly CancellationToken _cancellationToken = default;

        public UserDirectoryBL(IConfiguration configuration, IHttpClientFactory factory)
        {
            _httpClient = factory.CreateClient();
        }

        public async Task<List<Cubezoo_Models.DTO.UserDirectory>> GetUserDirectoriesAsync()
        {
            var apiUrl = "https://jsonplaceholder.typicode.com/users";
            var response = await _httpClient.GetAsync(apiUrl, _cancellationToken).ConfigureAwait(false);

            var model = new List<Cubezoo_Models.DTO.UserDirectory>();

            if (!response.IsSuccessStatusCode) return model;
            await using var stream = await response.Content.ReadAsStreamAsync();
            model.AddRange(await JsonSerializer.DeserializeAsync<List<Cubezoo_Models.DTO.UserDirectory>>(stream, cancellationToken: _cancellationToken));
            return model;
        }
    }
}
