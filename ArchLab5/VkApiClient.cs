using ArchLab5.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ArchLab5
{
    public class VkApiClient
    {
        private HttpClient _client;

        public VkApiClient(string token)
        {
            _client = new HttpClient();
            _client.BaseAddress = new Uri("https://api.vk.com/method/");
            _client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
        }

        public List<FriendListItem>? GetFriendsRequest()
        {
            return _client
                ?.GetFromJsonAsync<FriendListResponseWrapper>(
                    "friends.get?fields=name&v=5.154"
                    )
                ?.Result
                ?.response
                .items;
        }

        public UserDetails? GetDetails(long id)
        {
            return _client
                ?.GetFromJsonAsync<UserDetailsResponseWrapper>(
                    $"users.get?user_ids={id}&fields=country,city,bdate&v=5.154"
                )
                ?.Result
                ?.response.
                FirstOrDefault();
        }
    }
}
