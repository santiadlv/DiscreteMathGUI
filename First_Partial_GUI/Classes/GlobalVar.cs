using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace First_Partial_GUI.Classes
{
    public static class GlobalVar
    {
        public static Image[] slides = new Image[7];

        public static void getImages()
        {
            slides[0] = Properties.Resources.img1;
            slides[1] = Properties.Resources.img2;
            slides[2] = Properties.Resources.img3;
            slides[3] = Properties.Resources.img4;
            slides[4] = Properties.Resources.img5;
            slides[5] = Properties.Resources.img6;
            slides[6] = Properties.Resources.img7;
        }

        public static Image setImages(int index)
        {
            return slides[index]; 
        }

        public static Form getForm(Form frm)
        {
            return frm;
        }
    }
}
