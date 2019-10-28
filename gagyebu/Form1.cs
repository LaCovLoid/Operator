using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gagyebu {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

            
        }

        private void label15_Click(object sender, EventArgs e) {
            
        }

        private void save_Click(object sender, EventArgs e) {
            saveFileDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e) {
            openFileDialog1.ShowDialog();
            name1.Text = openFileDialog1.FileName;
            string[] adress = System.IO.File.ReadAllLines( name1.Text );
            for (int i = 0; i < adress.Length; ++i) {
                string Hanyu = adress[i].Split('.')[0];
                int Rika = int.Parse(adress[i].Split('.')[1]);
                if (i == 0) {
                    label1.Text = Hanyu;
                    label2.Text = Rika.ToString();
                }
                if (i == 1) {
                    label3.Text = Hanyu;
                    label4.Text = Rika.ToString();
                }
                if (i == 2) {
                    label5.Text = Hanyu;
                    label6.Text = Rika.ToString();
                }
                if (i == 3) {
                    label7.Text = Hanyu;
                    label8.Text = Rika.ToString();
                }
                if (i == 4) {
                    label9.Text = Hanyu;
                    label10.Text = Rika.ToString();
                }
                if (i == 5) {
                    label11.Text = Hanyu;
                    label12.Text = Rika.ToString();
                }
                if (i == 6) {
                    label13.Text = Hanyu;
                    label14.Text = Rika.ToString();
                }
            }
            name1.Text = openFileDialog1.FileName;

        }

        private void button2_Click(object sender, EventArgs e) {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "txt files(*.txt) | *.txt | All files(*.*) | *.*";
            saveFileDialog1.ShowDialog();
            StreamWriter writer = new StreamWriter(saveFileDialog1.OpenFile());
            if (label1.Text != "") {
                writer.WriteLine(label1.Text + "." + label2.Text);
            }
            if (label3.Text != "") {
                writer.WriteLine(label3.Text + "." + label4.Text);
            }
            if (label5.Text != "") {
                writer.WriteLine(label5.Text + "." + label6.Text);
            }
            if (label7.Text != "") {
                writer.WriteLine(label7.Text + "." + label8.Text);
            }
            if (label9.Text != "") {
                writer.WriteLine(label9.Text + "." + label10.Text);
            }
            if (label11.Text != "") {
                writer.WriteLine(label11.Text + "." + label12.Text);
            }
            if (label13.Text != "") {
                writer.WriteLine(label13.Text + "." + label14.Text);
            }
            writer.Close();
            /*if (saveFileDialog1.FileName != "") {
                System.IO.FileStream fs =(System.IO.FileStream)saveFileDialog1.OpenFile();

                fs.Close();
            }*/
        }

        private void button3_Click(object sender, EventArgs e) {


            /*int a = 0;
            name1.Text = openFileDialog1.FileName;
            string[] adress = System.IO.File.ReadAllLines(name1.Text);
            for (int i = 0; i < adress.Length; ++i) {
                string Hanyu = adress[i].Split('.')[0];
                int Rika = int.Parse(adress[i].Split('.')[1]);
                a += Rika;
            }
            label18.Text = a.ToString();
            */
            if (label1.Text == "") {
                label1.Text = textBox1.Text;
                label2.Text = textBox2.Text;
            }
            if (label3.Text == "") {
                label3.Text = textBox3.Text;
                label4.Text = textBox4.Text;
            }
            if (label5.Text == "") {
                label5.Text = textBox5.Text;
                label6.Text = textBox6.Text;
            }
            if (label7.Text == "") {
                label7.Text = textBox7.Text;
                label8.Text = textBox8.Text;
            }
            if (label9.Text == "") {
                label9.Text = textBox9.Text;
                label10.Text = textBox10.Text;
            }
            if (label11.Text == "") {
                label11.Text = textBox11.Text;
                label12.Text = textBox12.Text;
            }
            if (label13.Text == "") {
                label13.Text = textBox13.Text;
                label14.Text = textBox14.Text;
            }

            if (label1.Text == "") {
                textBox1.Visible = true;
                textBox2.Visible = true;
            } else {
                textBox1.Visible = false;
                textBox2.Visible = false;
            }

            if (label3.Text == "") {
                if (label1.Text != "") {
                    textBox3.Visible = true;
                    textBox4.Visible = true;
                }
            } else {
                textBox3.Visible = false;
                textBox4.Visible = false;
            }
            if (label5.Text == "") {
                if (label3.Text != "") {
                    textBox5.Visible = true;
                    textBox6.Visible = true;
                }
            } else {
                textBox5.Visible = false;
                textBox6.Visible = false;
            }
            if (label7.Text == "") {
                if (label5.Text != "") {
                    textBox7.Visible = true;
                    textBox8.Visible = true;
                }
            } else {
                textBox7.Visible = false;
                textBox8.Visible = false;
            }
            if (label9.Text == "") {
                if (label7.Text != "") {
                    textBox9.Visible = true;
                    textBox10.Visible = true;
                }
            } else {
                textBox9.Visible = false;
                textBox10.Visible = false;
            }
            if (label11.Text == "") {
                if (label9.Text != "") {
                    textBox11.Visible = true;
                    textBox12.Visible = true;
                }
            } else {
                textBox11.Visible = false;
                textBox12.Visible = false;
            }
            if (label13.Text == "") {
                if (label11.Text != "") {
                    textBox13.Visible = true;
                    textBox14.Visible = true;
                }
            } else {
                textBox13.Visible = false;
                textBox14.Visible = false;
            }
            int total = 0;
            if (label2.Text != "") {
                total = total+int.Parse(label2.Text);
                if (label4.Text != "") {
                    total = total + int.Parse(label4.Text);
                    if (label6.Text != "") {
                        total = total + int.Parse(label6.Text);
                        if (label8.Text != "") {
                            total = total + int.Parse(label8.Text);
                            if (label10.Text != "") {
                                total = total + int.Parse(label10.Text);
                                if (label12.Text != "") {
                                    total = total + int.Parse(label12.Text);
                                    if (label14.Text != "") {
                                        total = total + int.Parse(label14.Text);
                                    }
                                }
                            }
                        }
                    }
                }
            }
            label18.Text = "총 합 "+total.ToString()+"원 입니다.";
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e) {
            


        }

        private void button4_Click(object sender, EventArgs e) {
            Form2 gyesangi = new Form2();
            gyesangi.Show();
        }
    }
}
