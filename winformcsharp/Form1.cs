using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace winformcsharp
{
    public partial class Form1 : Form
    {
        [DllImport("testDll1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void pipecommand(string str);

        [DllImport("testDll1.dll", CharSet = CharSet.Ansi)]
        static extern void Strcat(string str1, string str2, StringBuilder newstr);

        [DllImport("testDll1.dll", CharSet = CharSet.Ansi)]
        static extern void Strcpy(StringBuilder str1, string str2);

        [DllImport("testDll1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern void Saysomething(string str);

        [DllImport("testDll1.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int add(int a, int b);

        public Form1()
        {
            InitializeComponent();
            //Form1_Load();
        }

        private void Form1_Load()
        {
            int c = add(100, 20);
            Console.WriteLine("c = ", c);
            StringBuilder sb = new StringBuilder();
            Strcat("Hello", "World", sb);
            statusBar1.Text = sb.ToString();
            Strcpy(sb, "Anything");
            Console.WriteLine("string is " + sb.ToString());
            pipecommand(@"dir c:\");
            Saysomething("What is your name");
            Console.ReadLine();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = add(100, 20);
            Console.WriteLine("c = ", c);
            StringBuilder sb = new StringBuilder();
            Saysomething("What is your name");
            pipecommand(@"dir c:\");
            //Strcat("Hello", "World", sb);
            //Console.WriteLine("Your Username is  ", sb.ToString());
            //Strcpy(sb, "Anything");
            //Console.WriteLine("Your Password is " + sb.ToString());
            //statusBar1.Text = sb.ToString();
        }
    }
}
