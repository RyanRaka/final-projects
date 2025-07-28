using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamaTika_NEW
{
    public partial class Matematika5 : Form
    {
        private int correctAnswer;
        private int questionNumber = 0;
        private int score = 0;
        private int totalQuestions = 10;
        private Random rand = new Random();

        public Matematika5()
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

            string questionText = "";
            correctAnswer = 0;

            int soalType = rand.Next(5); // 0-2: hitungan biasa, 3-4: soal cerita

            if (soalType == 0)
            {
                // Penjumlahan besar
                int a = rand.Next(1000, 5000);
                int b = rand.Next(1000, 5000);
                correctAnswer = a + b;
                questionText = $"{a} + {b} = ?";
            }
            else if (soalType == 1)
            {
                // Perkalian
                int a = rand.Next(20, 100);
                int b = rand.Next(5, 20);
                correctAnswer = a * b;
                questionText = $"{a} × {b} = ?";
            }
            else if (soalType == 2)
            {
                // Pembagian
                int b = rand.Next(5, 20);
                correctAnswer = rand.Next(10, 50);
                int a = correctAnswer * b;
                questionText = $"{a} ÷ {b} = ?";
            }
            else if (soalType == 3)
            {
                // Soal cerita 1
                int dus = rand.Next(2, 6); 
                int isi = rand.Next(10, 31); 
                correctAnswer = dus * isi;
                questionText = $"Ibu membeli {dus} dus berisi {isi} botol air mineral. " +
                               $"Berapa jumlah seluruh botol yang dibeli?";
            }
            else if (soalType == 4)
            {
                // Soal cerita 2
                int jam = rand.Next(1, 5);
                int menit = jam * 60;
                correctAnswer = menit;
                questionText = $"Dina belajar selama {jam} jam. " +
                               $"Berapa menit waktu yang digunakan Dina untuk belajar?";
            }

            label1.Text = questionText;

            List<int> options = new List<int> { correctAnswer };
            while (options.Count < 4)
            {
                int wrong = correctAnswer + rand.Next(-25, 26);
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
