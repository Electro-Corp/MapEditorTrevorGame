using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrevorGridThingy
{
    public partial class Form2 : Form
    {
        MainWindow og = null;
        public Form2(MainWindow og)
        {
            InitializeComponent();
            this.og = og;

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (yellowSpeedUpDown.Value > tickUpDown.Value - 1)
            {
                MessageBox.Show("Your Yellow speed is higher than your tick count MINUS one? Change that.");
                return;
            }
            if (speedUpDown.Value > tickUpDown.Value - 1)
            {
                MessageBox.Show("Your speed is higher than your tick count MINUS one? Change that.");
                return;
            }
            this.Hide();
            og.generateNewMap((int)widthUpDown.Value, (int)heightUpDown.Value, (int)tickUpDown.Value, (int)yellowSpeedUpDown.Value, (int)speedUpDown.Value);
        }

        private void tickUpDown_ValueChanged(object sender, EventArgs e)
        {
            yellowSpeedUpDown.Maximum = (int)tickUpDown.Value - 1;
            speedUpDown.Maximum = (int)tickUpDown.Value - 1;
        }
    }
}
