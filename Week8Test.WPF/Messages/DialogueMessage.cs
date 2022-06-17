using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Week8Test.WPF.Messages
{
    public class DialogueMessage
    {
        public string Content { get; set; } = null;
        public string Title { get; set; } = "Dialogue";
        public MessageBoxImage Icon { get; set; } = MessageBoxImage.Information;
        public MessageBoxButton button { get; set; } = MessageBoxButton.OK;
    }
}
