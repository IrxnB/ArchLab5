using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArchLab5
{
    class FriendsWindowVM : INotifyPropertyChanged
    {
        private VkApiClient _client;
        private List<FriendListItem> _friends;
        private FriendListItem _selectedFriend;
        public string Token { get; set; }

        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string prop = "") 
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));


        public FriendListItem SelectedFriend
        {
            get => _selectedFriend;
            set
            {
                _selectedFriend = value;
                OnPropertyChanged(nameof(SelectedFriend));
            }
        }
        public List<FriendListItem> FriendList
        {
            get => _friends;
            set {
                _friends = value;
                OnPropertyChanged(nameof(FriendList));
            }
        }

        public FriendsWindowVM(string token) {
            Token = token;
            _client = new VkApiClient(token);
            FriendList = _client.GetFriendsRequest();
            SelectedFriend = FriendList.FirstOrDefault();
        }

        
    }
}
