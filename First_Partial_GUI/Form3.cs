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
    public partial class Form3 : Form
    {
        public static int probIndex;

        public Form3()
        {
            InitializeComponent();
        }

        private void bttnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 frm1 = new Form1();
            frm1.Closed += (s, args) => this.Close();
            GC.Collect();
            frm1.Show();
        }

        private void bttnNextQ_Click(object sender, EventArgs e)
        {
            chooseArray();
            lblTitle.Focus();
            resetButtons();

            probIndex++;
            changeProblem(probIndex);
          
            if (probIndex == GlobalVar.problems.Length - 1)
            {
                bttnNextQ.Enabled = false;
                bttnCheck.Visible = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            GlobalVar.finalsIndex = 0;
            GlobalVar.correctCount = 0;
            probIndex = 0;
            GlobalVar.getProblems();
            imgProblem.Image = GlobalVar.setProblem(probIndex);
        }

        private void changeProblem(int imgIndex)
        {
            imgProblem.Image = GlobalVar.setProblem(imgIndex);
        }

        private void bttnCheck_Click(object sender, EventArgs e)
        {
            chooseArray();
            GlobalVar.getCorrectAnswers();
            GlobalVar.checkAnswers(GlobalVar.ans_1, GlobalVar.correctAnswers_1);
            GlobalVar.checkAnswers(GlobalVar.ans_2, GlobalVar.correctAnswers_2);
            GlobalVar.checkAnswers(GlobalVar.ans_3, GlobalVar.correctAnswers_3);
            GlobalVar.checkAnswers(GlobalVar.ans_4, GlobalVar.correctAnswers_4);
            GlobalVar.checkAnswers(GlobalVar.ans_5, GlobalVar.correctAnswers_5);
            MessageBox.Show(GlobalVar.giveResults());
            bttnCheck.Enabled = false;
        }

        private void saveAnswers(bool[] arr)
        {
            //GlobalVar.ans_A[probIndex] = rbA.Checked;
            //GlobalVar.ans_B[probIndex] = rbB.Checked;
            //GlobalVar.ans_C[probIndex] = rbC.Checked;
            //GlobalVar.ans_D[probIndex] = rbD.Checked;

            arr[0] = rbA.Checked;
            arr[1] = rbB.Checked;
            arr[2] = rbC.Checked;
            arr[3] = rbD.Checked;
        }

        private void chooseArray()
        {
            if (probIndex == 0) { saveAnswers(GlobalVar.ans_1); }
            if (probIndex == 1) { saveAnswers(GlobalVar.ans_2); }
            if (probIndex == 2) { saveAnswers(GlobalVar.ans_3); }
            if (probIndex == 3) { saveAnswers(GlobalVar.ans_4); }
            if (probIndex == 4) { saveAnswers(GlobalVar.ans_5); }
        }

        private void resetButtons()
        {
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            rbD.Checked = false;
        }
    }
}
