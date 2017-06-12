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
    public partial class win : Form
    {
        public win()
        {
            InitializeComponent();
        }

        public win(int score)
        {
            InitializeComponent();
            ScoreLabel.Text = score.ToString();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new start().Show();
            this.Hide();

        }
    }
}
