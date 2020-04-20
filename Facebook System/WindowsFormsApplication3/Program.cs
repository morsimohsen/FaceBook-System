using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{


    public static class Globals
    {
        public static string emails2;
        public static string emails;
        public static string PP;
        public static string  imgloc;
        public static string FN;
        public static string FN2;
        public static string BA;
        public static bool check;
        public static bool check2;
        public static string like;
        public static string like1;
        public static string like2;
        public static string like3;
        public static string like_group;
        public static string like1_group;
        public static int count=0;
        public static int seen = 0;
        public static string constt;
        public static int countt = 0;
        public static int seenn = 0;
        public static int counttt = 0;
        public static int seennn = 0;
        public static string consttt;
        public static string consttt1;











    }
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new home());
        }
    }
}
