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

namespace TamaTika_NEW
{
    public partial class Matematika6 : Form
    {
        private int correctAnswer;
        private int questionNumber = 0;
        private int score = 0;
        private int totalQuestions = 10;
        private Random rand = new Random();

        public Matematika6()
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

            int soalType = rand.Next(6); // 0-2 hitungan biasa, 3-5 soal cerita

            switch (soalType)
            {
                case 0:
                    // Perbandingan / skala
                    int skala = rand.Next(2, 6);  // 1: skala 1:x
                    int panjangPeta = rand.Next(5, 21); // cm
                    correctAnswer = panjangPeta * skala;
                    questionText = $"Pada sebuah peta berskala 1:{skala}, panjang jalan adalah {panjangPeta} cm. " +
                                   $"Berapa panjang sebenarnya (dalam cm)?";
                    break;

                case 1:
                    // Persen
                    int totalBarang = rand.Next(100, 301);
                    int persen = rand.Next(10, 51); // 10% - 50%
                    correctAnswer = totalBarang * persen / 100;
                    questionText = $"{persen}% dari {totalBarang} buah mangga yang dibeli Roni adalah mangga muda. " +
                                   $"Berapa buah mangga muda yang dibeli Roni?";
                    break;

                case 2:
                    // Pecahan
                    int totalKue = rand.Next(8, 25);
                    correctAnswer = totalKue / 2;
                    questionText = $"Dari {totalKue} kue, setengahnya dimakan oleh adik. " +
                                   $"Berapa kue yang dimakan adik?";
                    break;

                case 3:
                    // Volume balok
                    int p = rand.Next(4, 11);
                    int l = rand.Next(3, 8);
                    int t = rand.Next(2, 6);
                    correctAnswer = p * l * t;
                    questionText = $"Sebuah balok memiliki panjang {p} cm, lebar {l} cm, dan tinggi {t} cm. " +
                                   $"Berapakah volumenya?";
                    break;

                case 4:
                    // Soal cerita pembagian
                    int siswa = rand.Next(4, 10);
                    int buku = siswa * rand.Next(2, 6);
                    int perSiswa = buku / siswa;
                    correctAnswer = perSiswa;
                    questionText = $"Sekolah membeli {buku} buku tulis untuk dibagikan kepada {siswa} siswa. " +
                                   $"Setiap siswa mendapat berapa buku?";
                    break;

                case 5:
                    // Hitungan campuran
                    int a = rand.Next(100, 301);
                    int b = rand.Next(20, 61);
                    int c = rand.Next(10, 21);
                    correctAnswer = (a + b) - c;
                    questionText = $"{a} + {b} - {c} = ?";
                    break;
            }

            label1.Text = questionText;

            // Generate pilihan jawaban
            List<int> options = new List<int> { correctAnswer };
            while (options.Count < 4)
            {
                int wrong = correctAnswer + rand.Next(-30, 31);
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
