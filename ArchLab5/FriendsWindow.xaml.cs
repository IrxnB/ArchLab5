using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ArchLab5
{
    /// <summary>
    /// Interaction logic for FriendsWindow.xaml
    /// </summary>
    public partial class FriendsWindow : Window
    {
        public FriendsWindow(string? token)
        {
            DataContext = new FriendsWindowVM(token);
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var context = (FriendsWindowVM)DataContext;
            new UserDetailsWindow(context.SelectedFriend.id, context.Token).Show();
        }
    }
}
