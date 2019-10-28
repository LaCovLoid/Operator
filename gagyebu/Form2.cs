using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gagyebu {
    public partial class Form2 : Form {
        public Form2() {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e) {
            label2.Text = label2.Text+"1";
        }

        private void label4_Click(object sender, EventArgs e) {
            label2.Text = label2.Text + "2";
        }

        private void label5_Click(object sender, EventArgs e) {
            label2.Text = label2.Text + "3";
        }

        private void label6_Click(object sender, EventArgs e) {
            label2.Text = label2.Text + "4";
        }

        private void label7_Click(object sender, EventArgs e) {
            label2.Text = label2.Text + "5";
        }

        private void label8_Click(object sender, EventArgs e) {
            label2.Text = label2.Text + "6";
        }

        private void label9_Click(object sender, EventArgs e) {
            label2.Text = label2.Text + "7";
        }

        private void label10_Click(object sender, EventArgs e) {
            label2.Text = label2.Text + "8";
        }

        private void label11_Click(object sender, EventArgs e) {
            label2.Text = label2.Text + "9";
        }

        private void label12_Click(object sender, EventArgs e) {
            label2.Text = label2.Text + "0";
        }

        private void label13_Click(object sender, EventArgs e) {
            if (label18.Text != "") {
                label18.Text = "";
            }
            if (label2.Text != "") {
                int a = int.Parse(label1.Text) + int.Parse(label2.Text);
                if (label1.Text == "0") {
                    label1.Text = label2.Text;
                    label2.Text = "";
                } else label1.Text = a.ToString();
                label2.Text = "";
            } else label18.Text = "+";
        }

        private void label14_Click(object sender, EventArgs e) {
            if (label18.Text != "") {
                label18.Text = "";
            }
            if (label2.Text != "") {
                int a = int.Parse(label1.Text) - int.Parse(label2.Text);
                if (label1.Text == "0") {
                    label1.Text = "-" + label2.Text;
                    label2.Text = "";
                } else label1.Text = a.ToString();
                label2.Text = "";
            } else label18.Text = "-";
        }

        private void label15_Click(object sender, EventArgs e) {
            if (label18.Text != "") {
                label18.Text = "";
            }
            if (label2.Text != "") {
                int a = int.Parse(label1.Text) * int.Parse(label2.Text);
                if (label1.Text == "0") {
                    label1.Text = label2.Text;
                    label2.Text = "";
                } else label1.Text = a.ToString();
                label2.Text = "";
            } else label18.Text = "x";
        }

        private void label16_Click(object sender, EventArgs e) {
            if (label18.Text != "") {
                label18.Text = "";
            }
            if (label2.Text != "") {
                int a = int.Parse(label1.Text) / int.Parse(label2.Text);
                if (label1.Text == "0") {
                    label1.Text = label2.Text;
                    label2.Text = "";
                } else label1.Text = a.ToString();
                label2.Text = "";
            } else label18.Text = "÷";
        }

        private void push_Click(object sender, EventArgs e) {
            if (label1.Text == "0") {
                label1.Text = label2.Text;
            } else label1.Text = label1.Text + label2.Text;
            label2.Text = "";
        }

        private void label17_Click(object sender, EventArgs e) {
            if(label18.Text == "+") {
                int a = int.Parse(label1.Text) + int.Parse(label2.Text);
                if (label2.Text != "") {
                    if (label1.Text == "0") {
                        label1.Text = label2.Text;
                        label2.Text = "";
                    } else label1.Text = a.ToString();
                    label2.Text = "";
                }
            }
            if (label18.Text == "-") {
                int a = int.Parse(label1.Text) - int.Parse(label2.Text);
                if (label2.Text != "") {
                    if (label1.Text == "0") {
                        label1.Text = "-" + label2.Text;
                        label2.Text = "";
                    } else label1.Text = a.ToString();
                    label2.Text = "";
                }
            }
            if (label18.Text == "x") {
                int a = int.Parse(label1.Text) * int.Parse(label2.Text);
                if (label2.Text != "") {
                    if (label1.Text == "0") {
                        label1.Text = label2.Text;
                        label2.Text = "";
                    } else label1.Text = a.ToString();
                    label2.Text = "";
                }
            }
            if (label18.Text == "÷") {
                int a = int.Parse(label1.Text) / int.Parse(label2.Text);
                if (label2.Text != "") {
                    if (label1.Text == "0") {
                        label1.Text = label2.Text;
                        label2.Text = "";
                    } else label1.Text = a.ToString();
                    label2.Text = "";
                }
            }
            if (label18.Text =="") {
                label1.Text = "0";
            }

            label18.Text = "";

            /*for (int i = 0; i < label1.Text.Length; ++i) {
                string[] gsg = new string[] { label1.Text };
                int first = int.Parse(gsg[i].Split('+')[0]);
                int second = int.Parse(gsg[i].Split('+')[1]);
                label1.Text = first + second.ToString();
            }*/
        }

        private void label19_Click(object sender, EventArgs e) {
            var input = label1.Text;
            var output = input.Substring(0, label1.Text.Length - 1);
            label1.Text = output;

        }
    }
}
