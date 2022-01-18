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
using VkNet.Enums.Filters;

namespace VKApp
{
    /// <summary>
    /// Логика взаимодействия для Profile.xaml
    /// </summary>
    public partial class Profile : Page
    {
        public Profile()
        {
            InitializeComponent();
        }

        public void LoadUpPage(long id)
        {
            // showing the avatar
            var data = MainWindow.API.Users.Get(new long[] { id }, ProfileFields.Photo100).FirstOrDefault();
            if (data == null)
                throw new Exception("user is null");

            BitmapImage userImage = Utils.GetBitmapFromURL(data.Photo100);
            UserImage.Source = userImage;
        }
    }
}
