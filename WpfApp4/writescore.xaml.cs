using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for writescore.xaml
    /// </summary>
    public partial class writescore : Window
    {
        public writescore()
        {
            InitializeComponent();
        }

        private void Btn_Submit_Click(object sender, RoutedEventArgs e)
        {
            string name = "";
            string score = "";
            int num = 0;
            num = WindowManager.score;
            score = num.ToString();
            name = score + TB_scorewrite.Text;
            List<string> strings = new List<string>();
            using (StreamWriter sw = new StreamWriter(name + ".txt"))
            {
                for(int x = 0; x < 10; x++)
                {
                    sw.WriteLine(strings[x]);
                }
            }
        }
    }
}
