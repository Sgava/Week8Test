using GalaSoft.MvvmLight.Messaging;
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
using Week8Test.WPF.Messages;
using Week8Test.WPF.ViewModels.Home;

namespace Week8Test.WPF.Views.Home
{
    /// <summary>
    /// Interaction logic for HomePageView.xaml
    /// </summary>
    public partial class HomePageView : Window
    {
        
        public HomePageView()
        {
            InitializeComponent();
            DataContext = new HomePageViewModel();
            Messenger.Default.Register<ShowViewMessage>(this, OnShowViewMessage);
        }

        private void OnShowViewMessage(ShowViewMessage msg)
        {
            if (msg.ViewName == "homepageview")
            {
                HomePageView view = new HomePageView();
                view.DataContext = new HomePageViewModel();
                view.Show();
            }
        }
    }
}
