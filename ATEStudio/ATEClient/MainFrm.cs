using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ATEClient
{
    public partial class MainFrm : Form
    {
        public MainFrm()
        {
            InitializeComponent();
            string msg1 = Code.HttpMethods.HttpGet("http://localhost:1851/API/Box1");
            string msg2 = Code.HttpMethods.HttpGet("http://localhost:1851/API/Box2");
            string msg3 = Code.HttpMethods.HttpGet("http://localhost:1851/API/Box3");
            string msg4 = Code.HttpMethods.HttpGet("http://localhost:1851/API/Box4");
            string msg5 = Code.HttpMethods.HttpGet("http://localhost:1851/API/Box5");
            string msg6 = Code.HttpMethods.HttpGet("http://localhost:1851/API/Box6");
            textBox1.Text = msg1.Substring(52);
            textBox2.Text = msg2.Substring(52);
            textBox3.Text = msg3.Substring(52);
            textBox4.Text = msg4.Substring(52);
            textBox5.Text = msg5.Substring(52);
            textBox6.Text = msg6.Substring(52);
        }
    }
}
