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

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainMenu.xaml
    /// </summary>
    public partial class MainMenu : Window
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void Btn_Play_Click(object sender, RoutedEventArgs e)
        {
            WindowManager.wWindow = true;
            WindowManager.w1 = new InitialMenu();
            WindowManager.w1.Show();
            this.Close();
        }

        private void Btn_Instruct_Click(object sender, RoutedEventArgs e)
        {
            WindowManager.inWindow = true;
            WindowManager.iw = new Instructwindow();
            WindowManager.iw.Show();
            this.Close();
        }
    }
}
