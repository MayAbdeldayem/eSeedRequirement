using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class start : Form
    {
        public start()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            numberTextBox.MaxLength = Convert.ToInt16(LengthTextBox.Text) * Convert.ToInt16(widthTextBox.Text);
            int length = Convert.ToInt16(LengthTextBox.Text);
            int width = Convert.ToInt16(widthTextBox.Text);
            int number = Convert.ToInt16(numberTextBox.Text);
            new game(length , width  , number).Show();
            this.Hide();
        }

        private void numberTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
