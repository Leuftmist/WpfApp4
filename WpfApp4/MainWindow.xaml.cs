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
        int easytimer = 90;
        string userinput = "";
        int easytotal = 0;
        int x = 0;
        int y = 0;
        int total = 0;
        public MainWindow()
        {

            InitializeComponent();
            userinput = WindowManager.message.ToString();
            //MessageBox.Show(WindowManager.message.ToString());
            InitialMenu initialMenus = new InitialMenu();
            if (userinput == "easy")
            {
                timer = "90";
                Tb_Timer.Text = "90";
                Tb_easysum.Visibility = Visibility.Visible;
                _dt1 = new DispatcherTimer();
                _dt1.Interval = new TimeSpan(0, 0, 0, 0, 1);
                _dt1.Tick += _dt1_tick;
                _dt1.Start();
            }
            else
            {
                timer = "60";
            }
            for (int x = 0; x < binarynums.Length; x++)
            {
                binarynums[x] = 0;
            }
            if (userinput == "hard")
            {
                x = rnd.Next(0, 128);
                y = rnd.Next(0, 127);
                tbox_DecimalDisplay.Visibility = Visibility.Collapsed;
                tbox_DecimalDisplay_Hard.Visibility = Visibility.Visible;
                tbox_DecimalDisplay_Hard.Text = x.ToString() + " + " + y.ToString();

            }
            else
            {
                decidisplay = rnd.Next(0, 255);
                tbox_DecimalDisplay.Text = decidisplay.ToString();
            }
            
            _dt = new DispatcherTimer();
            _dt.Interval = new TimeSpan(0, 0, 0, 1, 0) ;
            _dt.Tick += _dt_tick;
            _dt.Start();
            
        }
        public MainWindow(string message)
        {
            InitializeComponent();
            this.Title = WindowManager.message.ToString();
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
                WindowManager.wrWindow = true;
                WindowManager.score = score;
                WindowManager.ws = new writescore();
                WindowManager.ws.Show();
                this.Close();
                //Application.Current.Shutdown();
                //initializes end screen and closes this window
            }
        }
        private void _dt1_tick(object sender, EventArgs e)
        {
            if (userinput == "easy")
            {
                int totals = 0;
                for (int x = 0; x < binarynums.Length; x++)
                {
                    totals = totals + binarynums[x];
                }
                Tb_easysum.Text = totals.ToString();
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
            
            
            for(int x = 0; x < binarynums.Length; x++)
            {
                total = total + binarynums[x];
            }
            if (userinput == "hard")
            {
                if(total == x + y)
                {
                    score++;
                    TB_Score.Text = "Score: " + score;
                    for (int x = 0; x < binarynums.Length; x++)
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
                    x = rnd.Next(0, 128);
                    y = rnd.Next(0, 127);
                    tbox_DecimalDisplay_Hard.Text = x.ToString() + " + " + y.ToString();
                    if (newtimer > 20)
                    {
                        newtimer = newtimer - 4;

                    }
                    string s = newtimer.ToString();
                    Tb_Timer.Text = s;
                }
                else
                {
                    MessageBox.Show("WRONG FUCKER!");
                }
            }
            else
            {
                if (total == decidisplay)
                {
                    score++;
                    TB_Score.Text = "Score: " + score;
                    for (int x = 0; x < binarynums.Length; x++)
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
                    if (userinput == "easy")
                    {
                        if (easytimer > 30)
                        {
                            easytimer = easytimer - 6;
                            string s = "";
                            s = easytimer.ToString();
                            Tb_Timer.Text = s;
                        }
                    }
                    else
                    {
                        if (newtimer > 20)
                        {
                            newtimer = newtimer - 4;

                        }
                        string s = "";
                        s = newtimer.ToString();
                        Tb_Timer.Text = s;
                    }

                    rounds++;
                }
                else
                {
                    MessageBox.Show("WRONG FUCKER!");
                }

            }
            
        }

        
    }
}
