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
    /// Interaction logic for InitialMenu.xaml
    /// </summary>
    public partial class InitialMenu : Window
    {
        string userinput = "";
        public InitialMenu()
        {
            InitializeComponent();
            //if (!WindowManager.mWindow)
            //{
            //    WindowManager.w1 = this;
            //    WindowManager.mWindow = true;
            //}
            //WindowManager.w1 = this;
            //WindowManager.wWindow = true;
        }

        private void Btn_Submit_Click(object sender, RoutedEventArgs e)
        {

            if (!WindowManager.mWindow)
            {
                
                WindowManager.mWindow = true;
                WindowManager.message = userinput;
                WindowManager.mw = new MainWindow();
                WindowManager.mw.Show();
                this.Close();
            }
            //else
            //{
            //    WindowManager.mw.Focus();
            //}
        }
        
        private void CB_easy_Checked(object sender, RoutedEventArgs e)
        {
            string easy = "";
            easy = "More time and Sum is displayed on the side to help. 90 seconds";
            TB_Description.Text = easy;
            userinput = "easy";
        }

        private void CB_Intermediate_Checked(object sender, RoutedEventArgs e)
        {
            string normal = "";
            normal = "Default setup, sum is invisible and 60 seconds";
            TB_Description.Text = normal;
            userinput = "normal";
        }

        private void CB_Hard_Checked(object sender, RoutedEventArgs e)
        {
            string hard = "";
            hard = "Harder setup, involves addition, 60 seconds";
            TB_Description.Text = hard;
            userinput = "hard";
        }
    }
}
