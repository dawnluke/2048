using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2048
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            int[,] a = new int[4, 4];
            a[0, 0] = 0;
            a[0, 1] = 0;
            a[0, 2] = 0;
            a[0, 3] = 0;
            a[1, 0] = 0;
            a[1, 1] = 0;
            a[1, 2] = 0;
            a[1, 3] = 0;
            a[2, 0] = 0;
            a[2, 1] = 0;
            a[2, 2] = 0;
            a[2, 3] = 0;
            a[3, 0] = 0;
            a[3, 1] = 0;
            a[3, 2] = 0;
            a[3, 3] = 0;
        }
    }
}
