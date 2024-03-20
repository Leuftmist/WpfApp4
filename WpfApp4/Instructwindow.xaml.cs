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
    /// Interaction logic for Instructwindow.xaml
    /// </summary>
    public partial class Instructwindow : Window
    {
        public Instructwindow()
        {
            InitializeComponent();
        }

        private void Btn_back_Click(object sender, RoutedEventArgs e)
        {
            WindowManager.mainmenu = true;
            WindowManager.main = new MainMenu();
            WindowManager.main.Show();
            this.Close();
        }
    }
}
