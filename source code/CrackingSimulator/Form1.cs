using System;
using System.Diagnostics;
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
    public partial class Form1 : Form
    {
        List<string> numEntered = new List<string>(); // Stores all entered numbers
        int numGenerated, tries = 0, maxNumber = 1000000, count = 0; // Number generated / Keeps track of the amount of tries the user has had / Limit for generated number / Counter for label characters
        string result; // Converts all the numbers entered by the user and stores them in a string
        decimal resultInt; // Converts the above string to decimal
        bool none = false, timer = false; bool seeNumber = false, numShown = false; // Checks if screen is empty / checks if timers are running / Checks if the the user is able to see number / Checks if user has checked and seen the number

        // Timer

        Timer t1;
        Stopwatch s1;
        TimeSpan timeSpan;

        public Form1()
        {
            InitializeComponent();
        }

        private void Generate()
        {
            Random rnd = new Random();
            numGenerated = rnd.Next(maxNumber + 1);
        } // Generates random number when called

        private void Form1_Load(object sender, EventArgs e)
        {
            label6.Text = "Number generated! You can start guessing...";
            checkBox1.Enabled = false;
            label2.Text = "";
            label11.Text = "Reliable crack: ✔";
            bunifuMetroTextbox1.Enabled = false;
            bunifuMaterialTextbox1.Enabled = false;
            bunifuMaterialTextbox2.Enabled = false;
            bunifuMaterialTextbox3.Enabled = false;
            bunifuMaterialTextbox4.Enabled = false;
            none = true;
            numShown = false;
            Generate();
            label3.Text = "Timer: 0.000 seconds";
            label4.Text = "Guesses: 0"; 
            if (maxNumber == 1000000)
            {
                label5.Text = "Maximum number: " + maxNumber.ToString("#,##0") + " (default)";
            }
            else
            {
                label5.Text = "Maximum number: " + maxNumber.ToString("#,##0");
            }
            button13.Enabled = false;
            this.KeyPreview = true;

            // Timer

            s1 = new Stopwatch();
            t1 = new Timer();
            t1.Interval = 1;
            t1.Tick += timer1_Tick;
            t1.Start();

        } // Statements that get called when the form is executed

        private void Form1_KeyDown(object sender, KeyEventArgs e) // Mapping keyboard keys
        {
            if (e.KeyCode == Keys.NumPad0 || e.KeyCode == Keys.D0) // Button 0
                button10.PerformClick();
            if (e.KeyCode == Keys.NumPad1 || e.KeyCode == Keys.D1) // Button 1
                button1.PerformClick();
            if (e.KeyCode == Keys.NumPad2 || e.KeyCode == Keys.D2) // Button 2
                button2.PerformClick();
            if (e.KeyCode == Keys.NumPad3 || e.KeyCode == Keys.D3) // Button 3
                button3.PerformClick();
            if (e.KeyCode == Keys.NumPad4 || e.KeyCode == Keys.D4) // Button 4
                button4.PerformClick();
            if (e.KeyCode == Keys.NumPad5 || e.KeyCode == Keys.D5) // Button 5
                button5.PerformClick();
            if (e.KeyCode == Keys.NumPad6 || e.KeyCode == Keys.D6) // Button 6
                button6.PerformClick();
            if (e.KeyCode == Keys.NumPad7 || e.KeyCode == Keys.D7) // Button 7
                button7.PerformClick();
            if (e.KeyCode == Keys.NumPad8 || e.KeyCode == Keys.D8) // Button 8
                button8.PerformClick();
            if (e.KeyCode == Keys.NumPad9 || e.KeyCode == Keys.D9) // Button 9
                button9.PerformClick();
            if (e.KeyCode == Keys.Enter) // Enter Button
                button11.PerformClick();
            if (e.KeyCode == Keys.Back || e.KeyCode == Keys.Delete) // Backspace Button
                button12.PerformClick();
            if (e.KeyCode == Keys.Space) // SpaceBar Button
                button13.PerformClick();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!timer)
            {
                s1.Start();
                timer = true;
                button14.Enabled = false;
            }

            if (none)
            {
                label6.Text = "";
                count++;
                label1.Text = "1";
                numEntered.Add("1");
                none = false;
                seeNumber = true;
                checkBox1.Enabled = true;
            }
            else
            {
                numEntered.Add("1");
                count++;
                result = String.Join("", numEntered.ToArray());
                label1.Text = Convert.ToDecimal(result).ToString("#,##0");
            }
            label3.Focus();

        } // Button 1

        private void button2_Click(object sender, EventArgs e)
        {
            if (!timer)
            {
                s1.Start();
                timer = true;
                button14.Enabled = false;
            }

            if (none)
            {
                label6.Text = "";
                count++;
                label1.Text = "2";
                numEntered.Add("2");
                none = false;
                seeNumber = true;
                checkBox1.Enabled = true;
            }
            else
            {
                numEntered.Add("2");
                count++;
                result = String.Join("", numEntered.ToArray());
                label1.Text = Convert.ToDecimal(result).ToString("#,##0");
            }
            label3.Focus();
        } // Button 2

        private void button3_Click(object sender, EventArgs e)
        {
            if (!timer)
            {
                s1.Start();
                timer = true;
                button14.Enabled = false;
            }

            if (none)
            {
                label6.Text = "";
                count++;
                label1.Text = "3";
                numEntered.Add("3");
                none = false;
                seeNumber = true;
                checkBox1.Enabled = true;
            }
            else
            {
                numEntered.Add("3");
                count++;
                result = String.Join("", numEntered.ToArray());
                label1.Text = Convert.ToDecimal(result).ToString("#,##0");
            }
            label3.Focus();
        } // Button 3

        private void button4_Click(object sender, EventArgs e)
        {
            if (!timer)
            {
                s1.Start();
                timer = true;
                button14.Enabled = false;
            }

            if (none)
            {
                label6.Text = "";
                count++;
                label1.Text = "4";
                numEntered.Add("4");
                none = false;
                seeNumber = true;
                checkBox1.Enabled = true;
            }
            else
            {
                numEntered.Add("4");
                count++;
                result = String.Join("", numEntered.ToArray());
                label1.Text = Convert.ToDecimal(result).ToString("#,##0");
            }
            label3.Focus();
        } // Button 4

        private void button5_Click(object sender, EventArgs e)
        {
            if (!timer)
            {
                s1.Start();
                timer = true;
                button14.Enabled = false;
            }

            if (none)
            {
                label6.Text = "";
                count++;
                label1.Text = "5";
                numEntered.Add("5");
                none = false;
                seeNumber = true;
                checkBox1.Enabled = true;
            }
            else
            {
                numEntered.Add("5");
                count++;
                result = String.Join("", numEntered.ToArray());
                label1.Text = Convert.ToDecimal(result).ToString("#,##0");
            }
            label3.Focus();
        } // Button 5

        private void button6_Click(object sender, EventArgs e)
        {
            if (!timer)
            {
                s1.Start();
                timer = true;
                button14.Enabled = false;
            }

            if (none)
            {
                label6.Text = "";
                count++;
                label1.Text = "6";
                numEntered.Add("6");
                none = false;
                seeNumber = true;
                checkBox1.Enabled = true;
            }
            else
            {
                numEntered.Add("6");
                count++;
                result = String.Join("", numEntered.ToArray());
                label1.Text = Convert.ToDecimal(result).ToString("#,##0");
            }
            label3.Focus();
        } // Button 6

        private void button7_Click(object sender, EventArgs e)
        {
            if (!timer)
            {
                s1.Start();
                timer = true;
                button14.Enabled = false;
            }

            if (none)
            {
                label6.Text = "";
                count++;
                label1.Text = "7";
                numEntered.Add("7");
                none = false;
                seeNumber = true;
                checkBox1.Enabled = true;
            }
            else
            {
                numEntered.Add("7");
                count++;
                result = String.Join("", numEntered.ToArray());
                label1.Text = Convert.ToDecimal(result).ToString("#,##0");
            }
            label3.Focus();
        } // Button 7

        private void button8_Click(object sender, EventArgs e)
        {
            if (!timer)
            {
                s1.Start();
                timer = true;
                button14.Enabled = false;
            }

            if (none)
            {
                label6.Text = "";
                count++;
                label1.Text = "8";
                numEntered.Add("8");
                none = false;
                seeNumber = true;
                checkBox1.Enabled = true;
            }
            else
            {
                numEntered.Add("8");
                count++;
                result = String.Join("", numEntered.ToArray());
                label1.Text = Convert.ToDecimal(result).ToString("#,##0");
            }
            label3.Focus();
        } // Button 8

        private void button9_Click(object sender, EventArgs e)
        {
            if (!timer)
            {
                s1.Start();
                timer = true;
                button14.Enabled = false;
            }

            if (none)
            {
                label6.Text = "";
                count++;
                label1.Text = "9";
                numEntered.Add("9");
                none = false;
                seeNumber = true;
                checkBox1.Enabled = true;
            }
            else
            {
                numEntered.Add("9");
                count++;
                result = String.Join("", numEntered.ToArray());
                label1.Text = Convert.ToDecimal(result).ToString("#,##0");
            }
            label3.Focus();
        } // Button 9

        private void button10_Click(object sender, EventArgs e)
        {
            if (!timer)
            {
                s1.Start();
                timer = true;
                button14.Enabled = false;
            }

            if (none)
            {
                label6.Text = "";
                count++;
                label1.Text = "0";
                numEntered.Add("0");
                none = false;
                seeNumber = true;
                checkBox1.Enabled = true;
            }
            else
            {
                numEntered.Add("0");
                count++;
                result = String.Join("", numEntered.ToArray());
                label1.Text = Convert.ToDecimal(result).ToString("#,##0");
            }
            label3.Focus();
        } // Button 0

        private void button11_Click(object sender, EventArgs e)
        {
            count = 0;
            if (maxNumber == 1000000)
            {
                label5.Text = "Maximum number: " + maxNumber.ToString("#,##0") + " (default)";
            }
            else
            {
                label5.Text = "Maximum number: " + maxNumber.ToString("#,##0");
            }

            if (timer)
            {
                button14.Enabled = false;
            }
            else
            {
                button14.Enabled = true;
            }

            if (!numEntered.Any())
            {
                none = true;
                label6.Text = "Please, enter any number!";
            }
            else
            {
                none = false;
                result = String.Join("", numEntered.ToArray());
                resultInt = Convert.ToDecimal(result);

                if (resultInt > numGenerated)
                {
                    label1.Text = "Lower!";
                    none = true;
                    tries++;
                }
                if (resultInt < numGenerated)
                {
                    label1.Text = "Higher!";
                    none = true;
                    tries++;
                }
                if (resultInt == numGenerated)
                {
                    // Lock all buttons

                    label2.Text = "";
                    checkBox1.Enabled = false;
                    checkBox1.Checked = false;
                    seeNumber = false;
                    tries++;
                    button1.Enabled = false;
                    button2.Enabled = false;
                    button3.Enabled = false;
                    button4.Enabled = false;
                    button5.Enabled = false;
                    button6.Enabled = false;
                    button7.Enabled = false;
                    button8.Enabled = false;
                    button9.Enabled = false;
                    button10.Enabled = false;
                    button11.Enabled = false;
                    button12.Enabled = false;
                    button14.Enabled = true;
                    s1.Stop();
                    timeSpan = s1.Elapsed;
                    string result = timeSpan.TotalSeconds.ToString();
                    label1.Text = "Correct! Number: " + numGenerated;
                    if (tries > 1)
                    {
                        label6.Text = "You took " + result.Substring(0, result.Length - 4) + " seconds with " + tries + " guesses!";
                    }
                    else
                    {
                        label6.Text = "You took " + result.Substring(0, result.Length - 4) + " seconds with " + tries + " guess!";
                    }
                    timer = false;
                    none = true;
                    button13.Enabled = true;
                }

                numEntered.Clear();
            }
            if (tries > 1)
                label4.Text = "Guesses: " + tries;
            else
                label4.Text = "Guesses: " + tries;
        } // 'GO' Button

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                System.Environment.Exit(1);
            }
        } // Exit Button

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        } // Minimize Button

        private void button12_Click(object sender, EventArgs e)
        {
            if (count > 0)
            {
                count--;
            }
            else if (count == 0 || count < 0)
            {
                count = 0;
                none = true;
            }
            if (numEntered.Any())
            {
                numEntered.RemoveAt(numEntered.Count - 1);
                result = String.Join("", numEntered.ToArray());
                if (numEntered.Count > 0)
                {
                    label1.Text = Convert.ToDecimal(result).ToString("#,##0");
                }
                else
                {
                    label1.Text = "";
                }
            }
        } // 'DEL'Button

        private void button14_Click(object sender, EventArgs e)
        {
            label3.Focus();
            int num1 = maxNumber;
            Form2 f2 = new Form2(maxNumber);
            if (f2.ShowDialog() == DialogResult.OK)
                maxNumber = Convert.ToInt32(f2.MaxSetValue);
            Generate();
            if (Convert.ToInt32(f2.MaxSetValue) == 1000000 || maxNumber == 1000000)
            {
                label5.Text = "Maximum number: 1 000 000 (default)";
            }
            else
            {
                label5.Text = "Maximum number: " + Convert.ToInt32(f2.MaxSetValue).ToString("#,##0");
            }

        } // 'Settings' Button

        private void button13_Click(object sender, EventArgs e) // 'NEW NUMBER' Button
        {
            s1.Reset();
            tries = 0;

            // Unlock all buttons

            numShown = false;
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = false;

            label1.Text = "";
            label6.Text = "New number generated! Start guessing...";
            label3.Text = "Timer: 0.000 seconds";
            Generate();
            label4.Text = "Guesses: " + tries;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeSpan = s1.Elapsed;
            string result = timeSpan.TotalSeconds.ToString();

            if (result.Length > 1)
            {
                label3.Text = "Timer: " + result.Substring(0, result.Length - 4) + " seconds";
            }

            if (timer)
            {
                label6.Text = "Crack in progress...";
            }

            if (seeNumber)
            {
                if (checkBox1.Checked == true)
                {
                    label2.Text = numGenerated.ToString();
                    numShown = true;
                    checkBox1.Enabled = false;
                }
            }

            if (checkBox1.Enabled == true)
            {
                label10.ForeColor = Color.White;
            }
            else
            {
                label10.ForeColor = Color.DarkGray;
            }

            if (numShown)
            {
                label11.Text = "Reliable crack: ✘";
            }
            else
            {
                label11.Text = "Reliable crack: ✔";
            }

        } // Timer

        private void label10_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false && numShown == false && seeNumber == true)
            {
                checkBox1.Checked = true;
            }
        } // Make label selectable

        private void button15_Click(object sender, EventArgs e)
        {
            label3.Focus();
            Form3 f3 = new Form3();
            f3.ShowDialog();
        } // 'ABOUT' Button

        // Change disabled buttons color

        private void button13_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            button13.Text = string.Empty;
            e.Graphics.DrawString("NEW NUMBER\n(space bar)", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        } // 'NEW NUMBER' Paint Event

        private void button13_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            button13.BackColor = btn.Enabled ? Color.White : Color.DarkGray;
        } // 'NEW NUMBER' Color Change

        private void button14_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            button14.Text = string.Empty;
            e.Graphics.DrawString("Settings", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        } // 'Settings' Paint Event

        private void button14_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            button14.BackColor = btn.Enabled ? Color.White : Color.DarkGray;
        } // 'Settings' Color Change

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            button1.Text = string.Empty;
            e.Graphics.DrawString("1", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        } // 'Button 1' Paint Event

        private void button1_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            button1.BackColor = btn.Enabled ? Color.White : Color.DarkGray;
        } // 'Button 1' Color Change

        private void button2_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            button2.Text = string.Empty;
            e.Graphics.DrawString("2", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        } // 'Button 2' Paint Event

        private void button2_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            button2.BackColor = btn.Enabled ? Color.White : Color.DarkGray;
        } // 'Button 2' Color Change

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            button3.Text = string.Empty;
            e.Graphics.DrawString("3", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        } // 'Button 3' Paint Event

        private void button3_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            button3.BackColor = btn.Enabled ? Color.White : Color.DarkGray;
        } // 'Button 3' Color Change

        private void button4_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            button4.Text = string.Empty;
            e.Graphics.DrawString("4", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        } // 'Button 4' Paint Event

        private void button4_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            button4.BackColor = btn.Enabled ? Color.White : Color.DarkGray;
        } // 'Button 4' Color Change

        private void button5_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            button5.Text = string.Empty;
            e.Graphics.DrawString("5", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        } // 'Button 5' Paint Event

        private void button5_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            button5.BackColor = btn.Enabled ? Color.White : Color.DarkGray;
        } // 'Button 5' Color Change

        private void button6_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            button6.Text = string.Empty;
            e.Graphics.DrawString("6", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        } // 'Button 6' Paint Event

        private void button6_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            button6.BackColor = btn.Enabled ? Color.White : Color.DarkGray;
        } // 'Button 6' Color Change

        private void button7_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            button7.Text = string.Empty;
            e.Graphics.DrawString("7", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();

        } // 'Button 7' Paint Event

        private void button7_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            button7.BackColor = btn.Enabled ? Color.White : Color.DarkGray;
        } // 'Button 7' Color Change

        private void button8_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            button8.Text = string.Empty;
            e.Graphics.DrawString("8", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        } // 'Button 8' Paint Event

        private void button8_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            button8.BackColor = btn.Enabled ? Color.White : Color.DarkGray;
        } // 'Button 8' Color Change

        private void button9_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            button9.Text = string.Empty;
            e.Graphics.DrawString("9", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        } // 'Button 9' Paint Event

        private void button9_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            button9.BackColor = btn.Enabled ? Color.White : Color.DarkGray;
        } // 'Button 9' Color Change

        private void button12_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            button12.Text = string.Empty;
            e.Graphics.DrawString("DEL", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        } // 'DEL Button' Paint Event

        private void button12_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            button12.BackColor = btn.Enabled ? Color.White : Color.DarkGray;
        } // 'DEL Button' Color Change

        private void button10_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            button10.Text = string.Empty;
            e.Graphics.DrawString("0", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        } // 'Button 0' Paint Event

        private void button10_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            button10.BackColor = btn.Enabled ? Color.White : Color.DarkGray;
        } // 'Button 0' Color Change

        private void button11_Paint(object sender, PaintEventArgs e)
        {
            dynamic btn = (Button)sender;
            dynamic drawBrush = new SolidBrush(btn.ForeColor);
            dynamic sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            button11.Text = string.Empty;
            e.Graphics.DrawString("GO", btn.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        } // 'GO Button' Paint Event

        private void button11_EnabledChanged(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            button11.BackColor = btn.Enabled ? Color.White : Color.DarkGray;
        } // 'GO Button' Color Change

        // End of "Change disabled buttons color"
    }
}
