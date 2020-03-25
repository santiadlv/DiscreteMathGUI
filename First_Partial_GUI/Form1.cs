using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace First_Partial_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblWelcome.Focus();
        }

        private void bttnTheory_Click(object sender, EventArgs e)
        {
            lblWelcome.Focus();
        }

        private void bttnExercises_Click(object sender, EventArgs e)
        {
            lblWelcome.Focus();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            lblWelcome.Focus();            
        }
    }
}
