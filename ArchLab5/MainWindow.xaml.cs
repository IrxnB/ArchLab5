using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ArchLab5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string _oauthPathStart;
        private string _appID;
        private string _oauthPathEnd;
        public MainWindow()
        {
            _oauthPathStart = ArchLab5.Resources.OauthPathStart;
            _appID = ArchLab5.Resources.AppID;
            _oauthPathEnd = ArchLab5.Resources.OauthPathEnd;
            InitializeComponent();
            Browser.Load(_oauthPathStart + _appID + _oauthPathEnd);
        }

        private void Browser_AddressChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            var path = new Uri(e.NewValue.ToString()!);

            if(path.Host == ArchLab5.Resources.TokenResponseStartsWith)
            {
                var queryString = path.Fragment.Trim('#');
                var queryParams = HttpUtility.ParseQueryString(queryString);
                var token = queryParams.Get("access_token");
                var userId = queryParams.Get("user_id");
                new FriendsWindow(token).Show();
            }
        }
    }
}
