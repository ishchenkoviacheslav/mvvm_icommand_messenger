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
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();

            Messenger.Default.Register<GoToPageMessage>
            (
                 this,
                 (action) => ReceiveMessage(action)
            );
        }
        private object ReceiveMessage(GoToPageMessage action)
        {
            MessageBox.Show(action.PageName);
            //StringBuilder sb = new StringBuilder("/Views/");
            //sb.Append(action.PageName);
            //sb.Append(".xaml");
            // (NavigationService.GetNavigationService(new DependencyObject())).Navigate(new System.Uri(sb.ToString(), System.UriKind.Relative));
            return null;
        }
    }
}
