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
using System.Windows.Navigation;
using System.Windows.Shapes;
using VkNet;
using VkNet.Model;
using Application = System.Windows.Application;

namespace VKApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static VkApi API { get; } = new();

        private Profile profile = new();

        public MainWindow()
        {
            InitializeComponent();
            Application.Current.MainWindow.WindowState = WindowState.Maximized;

            CurrentPage.Content = profile;
            Authorize();
            profile.LoadUpPage(1);
        }

        public void Authorize()
        {
            API.Authorize(new ApiAuthParams
            {
                AccessToken = "67359bde67359bde67359bde17675346366673567359bde3ceb792bba3e958c8d4c25a0"
            });
        }
    }
}
