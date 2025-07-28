using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace TamaTika_NEW
{
    public partial class Matematika4 : Form
    {
        private int correctAnswer;
        private int questionNumber = 0;
        private int score = 0;
        private int totalQuestions = 10;
        private Random rand = new Random();

        public Matematika4()
        {
            InitializeComponent();
            LoadQuestion();
        }

        private void LoadQuestion()
        {
            if (questionNumber >= totalQuestions)
            {
                MessageBox.Show($"Selesai!\nSkor akhir kamu: {score} / {totalQuestions * 10}", "Selesai");
                DisableAnswerButtons();
                return;
            }

            questionNumber++;
            label3.Text = $"Soal: {questionNumber} / {totalQuestions}";
            label2.Text = $"Skor: {score}";

            int num1 = rand.Next(100, 1001);   // Angka 100–1000
            int num2 = rand.Next(10, 101);     // Angka 10–100
            int operation = rand.Next(4);      // 0: +, 1: -, 2: ×, 3: ÷

            string questionText = "";

            if (operation == 0)
            {
                correctAnswer = num1 + num2;
                questionText = $"{num1} + {num2} = ?";
            }
            else if (operation == 1)
            {
                if (num1 < num2)
                {
                    int temp = num1;
                    num1 = num2;
                    num2 = temp;
                }
                correctAnswer = num1 - num2;
                questionText = $"{num1} - {num2} = ?";
            }
            else if (operation == 2) // Perkalian
            {
                num1 = rand.Next(10, 51);
                num2 = rand.Next(10, 21);
                correctAnswer = num1 * num2;
                questionText = $"{num1} × {num2} = ?";
            }
            else // Pembagian
            {
                num2 = rand.Next(10, 21); // Pembagi 10–20
                correctAnswer = rand.Next(5, 51); // Hasil 5–50
                num1 = correctAnswer * num2; // Biar hasilnya bulat
                questionText = $"{num1} ÷ {num2} = ?";
            }

            label1.Text = questionText;

            // Generate pilihan jawaban
            List<int> options = new List<int> { correctAnswer };
            while (options.Count < 4)
            {
                int wrong = correctAnswer + rand.Next(-20, 21);
                if (!options.Contains(wrong) && wrong >= 0)
                    options.Add(wrong);
            }

            options = options.OrderBy(x => rand.Next()).ToList();

            button1.Text = options[0].ToString();
            button2.Text = options[1].ToString();
            button3.Text = options[2].ToString();
            button4.Text = options[3].ToString();

            EnableAnswerButtons();
        }


        private void CheckAnswer(int selectedAnswer)
        {
            if (selectedAnswer == correctAnswer)
            {
                score += 10;
            }

            LoadQuestion();
        }


        private void AnswerButton_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            int selected = int.Parse(btn.Text);
            DisableAnswerButtons();
            CheckAnswer(selected);
        }

        private void DisableAnswerButtons()
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void EnableAnswerButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }


        private void Matematika1_Load(object sender, EventArgs e)
        {

        }


        private void button5_Click_1(object sender, EventArgs e)
        {
            score = 0;
            questionNumber = 0;
            LoadQuestion();

        }
    }
}


