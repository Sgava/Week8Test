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
using GalaSoft.MvvmLight.Messaging;
using Week8Test.WPF.ViewModels.InsertGiftCard;

namespace Week8Test.WPF.Views.InsertGiftCard
{
    /// <summary>
    /// Interaction logic for InsertGiftCardView.xaml
    /// </summary>
    public partial class InsertGiftCardView : Window
    {
        public InsertGiftCardView()
        {
            InitializeComponent();
            DataContext = new InsertGiftCardViewModel();
            Messenger.Default.Register<ShowViewMessage>(this, OnShowViewMessage);
        }

        public void OnShowViewMessage(ShowViewMessage msg)
        {
            if (msg.ViewName == "InsertGiftCardView")
            {
                InsertGiftCardView view = new InsertGiftCardView();
                view.DataContext = new InsertGiftCardViewModel();
                view.Show();
                this.Close();
            }
        }
    }
}
