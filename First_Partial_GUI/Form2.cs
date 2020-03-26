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
    public partial class Form2 : Form
    {
        public static int imgIndex;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            imgIndex = 0;
            GlobalVar.getImages();
            imgSlides.Image = GlobalVar.setImages(imgIndex);
        }

        private void bttnNext_Click(object sender, EventArgs e)
        {
            imgIndex++;
            bttnPrevious.Enabled = true;
            changeSlide(imgIndex);

            if (imgIndex == GlobalVar.slides.Length - 1)
            {
                bttnNext.Enabled = false;
            }
        }

        private void bttnPrevious_Click(object sender, EventArgs e)
        {
            imgIndex--;
            bttnNext.Enabled = true;
            changeSlide(imgIndex);

            if (imgIndex == 0)
            {
                bttnPrevious.Enabled = false;
            }
        }

        private void changeSlide(int imgIndex)
        {
            imgSlides.Image = GlobalVar.setImages(imgIndex);
        }

        private void imgSlides_Click(object sender, EventArgs e)
        {
            lblTitle.Focus();
        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Closed += (s, args) => this.Close();
            GC.Collect();
            frm1.Show();
        }
    }
}
