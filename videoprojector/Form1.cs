using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace videoprojector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
            string u = Application.LocalUserAppDataPath;
            Text = u;
            //u = "C:\\_documente\\proiecte2\\videoprojector\\videoprojector\\mediaelement - master\\demo\\index.html";
            u = "file:///C:/_documente/proiecte2/videoprojector/videoprojector/mediaelement-master/demo/index.html";
            Text += " " + u;
            webBrowser1.Navigate(new Uri(u));




        }
    }
}
