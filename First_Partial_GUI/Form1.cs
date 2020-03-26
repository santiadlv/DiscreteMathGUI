using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using First_Partial_GUI.Classes;

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
            this.Hide();
            Form2 frm2 = new Form2();
            frm2.Closed += (s, args) => this.Close();
            GC.Collect();
            frm2.Show();
        }

        private void bttnExercises_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 frm3 = new Form3();
            frm3.Closed += (s, args) => this.Close();
            GC.Collect();
            frm3.Show();
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            lblWelcome.Focus();            
        }
    }
}
