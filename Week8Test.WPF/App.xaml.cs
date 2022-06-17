using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Week8Test.CORE;
using Week8Test.CORE.BusinessLayer;
using Week8Test.CORE.Interfaces;
using Week8Test.Repository;
using Week8Test.WPF.Messages;

namespace Week8Test.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            DependencyContainer.Register<IBusinessLayer, MainBusinessLayer>();
            DependencyContainer.Register<IRepositoryGiftCard, RepositoryGiftCard>();

            Messenger.Default.Register<DialogueMessage>(this, OnDialogueMessage);
        }

        private void OnDialogueMessage(DialogueMessage msg)
        {
            var result = MessageBox.Show(msg.Content,
                                         msg.Title,
                                         msg.button,
                                         msg.Icon
                                         );
        }
    }
}
