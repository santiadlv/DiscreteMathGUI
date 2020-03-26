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
        public static Image[] problems = new Image[5];

        public static bool[] correctAnswers_1 = new bool[4];
        public static bool[] correctAnswers_2 = new bool[4];
        public static bool[] correctAnswers_3 = new bool[4];
        public static bool[] correctAnswers_4 = new bool[4];
        public static bool[] correctAnswers_5 = new bool[4];

        public static bool[] correctFinals = new bool[5];
        public static int finalsIndex = 0;
        public static int correctCount = 0;

        public static bool[] ans_1 = new bool[4];
        public static bool[] ans_2 = new bool[4];
        public static bool[] ans_3 = new bool[4];
        public static bool[] ans_4 = new bool[4];
        public static bool[] ans_5 = new bool[4];

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

        public static void getProblems()
        {
            problems[0] = Properties.Resources.prob1;
            problems[1] = Properties.Resources.prob2;
            problems[2] = Properties.Resources.prob3;
            problems[3] = Properties.Resources.prob4;
            problems[4] = Properties.Resources.prob5;
        }

        public static void getCorrectAnswers()
        {
            correctAnswers_1[1] = true;
            correctAnswers_2[3] = true;
            correctAnswers_3[0] = true;
            correctAnswers_4[2] = true;
            correctAnswers_5[1] = true;
        }

        public static Image setImages(int index)
        {
            return slides[index]; 
        }

        public static Image setProblem(int index)
        {
            return problems[index];
        }

        public static void checkAnswers(bool[] answers, bool[] correctA)
        {
            bool correct = true;
            for (int i = 0; i < 4; i++)
            {
                if (answers[i] != correctA[i])
                {
                    correct = false;
                }
            }
            correctFinals[finalsIndex] = correct;
            finalsIndex++;
        }

        public static string giveResults()
        {
            string sentence;
            for (int i = 0; i < correctFinals.Length; i++)
            {
                if (correctFinals[i] == true)
                {
                    correctCount++;
                }
            }
            float score = ((float)correctCount / 5) * 100;
            sentence = "¡Felicidades! Obtuviste " + correctCount + " preguntas correctas." + " Tú calificación final es de " + score.ToString() + ". ¡Buen trabajo!";
            return sentence;
        }
    }
}
