using ArchLab5.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ArchLab5
{
    public class UserDetailsVM : INotifyPropertyChanged
    {
        private VkApiClient _client;

        private UserDetails? _userDetails;

        public UserDetails? User {
            get => _userDetails;
            set
            {
                _userDetails = value;
                OnPropertyChanged(nameof(User));
            }
        }
        

        public UserDetailsVM(long id, string token)
        {
            _client = new VkApiClient(token);
            User = _client.GetDetails(id);
        }
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string prop = "")
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
    }
}
