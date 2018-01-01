using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 財務gogo {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {

        }



        private void main() {

            TextBox check = checkTextBoxHaveValue();
            if (check == textBox1) {
                float oldValue = float.Parse(textBox2.Text);
                float percentage = float.Parse(textBox3.Text);
                float result = oldValue * (1+(percentage / 100) );
                textBox1.Text = result.ToString();
            }
            if (check == textBox2) {
                float newValue = float.Parse(textBox1.Text);
                float percentage = float.Parse(textBox3.Text);
                float result = newValue * (1 - (percentage / 100));
                textBox2.Text = result.ToString();
            }
            if (check == textBox3) {
                float newValue = float.Parse(textBox1.Text);
                float oldValue = float.Parse(textBox2.Text);
                float result = newValue - oldValue;
                result /= oldValue;
                result *= 100;
                textBox3.Text = result.ToString();
            }
        }

        private TextBox checkTextBoxHaveValue() {
            int nullValue = 0;
            TextBox textBox = null;
            if (textBox1.Text == "") {
                nullValue++;
                textBox = textBox1;
            }
            if (textBox2.Text == "") {
                nullValue++;
                textBox = textBox2;
            }
            if (textBox3.Text == "") {
                nullValue++;
                textBox = textBox3;
            }

            if (nullValue == 1) {
                return textBox;
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e) {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e) {
            main();
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;

        }
    }
}
