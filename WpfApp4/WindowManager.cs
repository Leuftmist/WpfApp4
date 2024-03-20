using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp4
{
    internal class WindowManager
    {
        public static MainWindow mw = null;
        public static InitialMenu w1 = null;
        public static Endingscreen e1 = null;
        public static writescore ws = null;
        public static Instructwindow iw = null;
        public static MainMenu main = null;

        public static bool mWindow = false;
        public static bool wWindow = false;
        public static bool eWindow = false;
        public static bool wrWindow = false;
        public static bool inWindow = false;
        public static bool mainmenu = false;

        public static string message = "";
        public static bool easymode = false;
        public static int score = 0;
    }
}
