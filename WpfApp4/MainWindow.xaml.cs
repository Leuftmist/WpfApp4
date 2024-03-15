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
using System.Windows.Threading;

namespace WpfApp4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Random rnd  = new Random();
        int decidisplay = 0;
        int[] binarynums = new int[8];
        int score = 0;
        DispatcherTimer _dt = null;
        DispatcherTimer _dt1 = null;
        int rounds = 1;
        int num = 0;
        string timer = "";
        int newtimer = 60;
        public MainWindow()
        {
            InitializeComponent();
            for (int x = 0; x < binarynums.Length; x++)
            {
                binarynums[x] = 0;
            }
            decidisplay = rnd.Next(0, 255);
            tbox_DecimalDisplay.Text = decidisplay.ToString();
            timer = "60";
            _dt = new DispatcherTimer();
            _dt.Interval = new TimeSpan(0, 0, 0, 1, 0) ;
            _dt.Tick += _dt_tick;
            _dt.Start();
            
        }
        private void _dt_tick(object sender, EventArgs e)
        {
            //MessageBox.Show("Hello");
            num = int.Parse(Tb_Timer.Text.ToString());
            num--;
            Tb_Timer.Text = num.ToString();
            if (num == 0)
            {
                MessageBox.Show("You lose, loser");
                Application.Current.Shutdown();
            }
        }

        private void Btn_128_Click(object sender, RoutedEventArgs e)
        {
            if (binarynums[0] == 0)
            {
                binarynums[0] = 128;
                tbox_128.Text = "1";
            }
            else
            {
                binarynums[0] = 0;
                tbox_128.Text = "0";
            }
            
            
        }

        private void Btn_64_Click(object sender, RoutedEventArgs e)
        {
            if (binarynums[1] == 0)
            {
                binarynums[1] = 64;
                tbox_64.Text = "1";
            }
            else
            {
                binarynums[1] = 0;
                tbox_64.Text = "0";
            }
        }

        private void Btn_32_Click(object sender, RoutedEventArgs e)
        {
            if (binarynums[2] == 0)
            {
                binarynums[2] = 32;
                tbox_32.Text = "1";
            }
            else
            {
                binarynums[2] = 0;
                tbox_32.Text = "0";
            }
        }

        private void Btn_16_Click(object sender, RoutedEventArgs e)
        {
            if (binarynums[3] == 0)
            {
                binarynums[3] = 16;
                tbox_16.Text = "1";
            }
            else
            {
                binarynums[3] = 0;
                tbox_16.Text = "0";
            }
        }

        private void Btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (binarynums[4] == 0)
            {
                binarynums[4] = 8;
                tbox_8.Text = "1";
            }
            else
            {
                binarynums[4] = 0;
                tbox_8.Text = "0";
            }
        }

        private void Btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (binarynums[5] == 0)
            {
                binarynums[5] = 4;
                tbox_4.Text = "1";
            }
            else
            {
                binarynums[5] = 0;
                tbox_4.Text = "0";
            }
        }

        private void Btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (binarynums[6] == 0)
            {
                binarynums[6] = 2;
                tbox_2.Text = "1";
            }
            else
            {
                binarynums[6] = 0;
                tbox_2.Text = "0";
            }
        }

        private void Btn_1_Click(object sender, RoutedEventArgs e)
        {
            if (binarynums[7] == 0)
            {
                binarynums[7] = 1;
                tbox_1.Text = "1";
            }
            else
            {
                binarynums[7] = 0;
                tbox_1.Text = "0";
            }
        }

        private void Btn_Submit_Click(object sender, RoutedEventArgs e)
        {
            int total = 0;
            for(int x = 0; x < binarynums.Length; x++)
            {
                total = total + binarynums[x];
            }
            if(total == decidisplay)
            {
                score++;
                TB_Score.Text = "Score: " + score;
                for(int x = 0;x < binarynums.Length; x++)
                {
                    binarynums[x] = 0;
                }
                tbox_1.Text = "0";
                tbox_2.Text = "0";
                tbox_4.Text = "0";
                tbox_8.Text = "0";
                tbox_16.Text = "0";
                tbox_32.Text = "0";
                tbox_64.Text = "0";
                tbox_128.Text = "0";
                decidisplay = rnd.Next(0, 255);
                tbox_DecimalDisplay.Text = decidisplay.ToString();
                if(newtimer > 20)
                {
                    newtimer = newtimer - 4;
                }
                string s = "";
                s = newtimer.ToString();
                Tb_Timer.Text = s;
                rounds++;
                
            }
            else
            {
                MessageBox.Show("WRONG FUCKER!");
            }
        }
    }
}
