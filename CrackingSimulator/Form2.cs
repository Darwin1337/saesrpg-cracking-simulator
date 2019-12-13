using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrackingSimulator
{
    public partial class Form2 : Form
    {
        int b;

        private string maxSetValue;

        public string MaxSetValue
        {
            get { return maxSetValue; }
            set { maxSetValue = value; }
        }

        public Form2(int a)
        {
            InitializeComponent();
            b = a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MaxSetValue = textBox1.Text;

            if (IsDigitsOnly(MaxSetValue))
            {
                if (Convert.ToDecimal(MaxSetValue) > 999999999)
                {
                    MaxSetValue = "999999999";
                }
                else
                {
                    MaxSetValue = MaxSetValue;
                }
            }

            else if (isDigitPresent(MaxSetValue))
            {
                MaxSetValue = Regex.Replace(MaxSetValue, "[^0-9]", "");
                if (Convert.ToDecimal(MaxSetValue) > 999999999)
                {
                    MaxSetValue = "999999999";
                }
                else
                {
                    MaxSetValue = MaxSetValue;
                }
            }
            else
            {
                MaxSetValue = "1000000";
            }
            this.Dispose();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBox1.Text = "" + b;
            textBox1.Focus();
        }

        bool IsDigitsOnly(string str)
        {
            foreach (char c in str)
            {
                if (c < '0' || c > '9')
                    return false;
            }

            return true;
        }

        bool isDigitPresent(string a)
        {
            if (a.Any(c => char.IsDigit(c)))
                return true ;
            return false;
        }
    }
}
