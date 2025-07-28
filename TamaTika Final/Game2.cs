using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TamaTika_Final
{
    public partial class Game2 : Form
    {
        private const int QUESTIONS_PER_LEVEL = 5;
        private const int MAX_LEVEL = 5;
        private const int SCORE_MULTIPLIER = 10;
        private const int IMAGE_SIZE = 50;
        private const int IMAGE_SPACING = 60;
        private const int IMAGE_MARGIN = 10;

        private readonly Random random = new Random();
        private int correctAnswer;
        private int score = 0;
        private int currentLevel = 1;
        private int questionsAnswered = 0;
        private bool isCountingGame = true;
        private readonly List<string> words;
        private string currentWord;
        private List<string> imageFiles;
        private SoundPlayer correctSound;
        private SoundPlayer wrongSound;
        private bool resourcesLoaded = false;
        private readonly string resourcePath;

        public Game2()
        {
            InitializeComponent();
            resourcePath = Path.Combine(Application.StartupPath, "Resources");
            words = InitializeWordList();
            InitializeGame();
            this.FormClosing += Game3_FormClosing;

            btnOption1.Click += CheckCountingAnswer;
            btnOption2.Click += CheckCountingAnswer;
            btnOption3.Click += CheckCountingAnswer;
            btnOption4.Click += CheckCountingAnswer;

        }

        private List<string> InitializeWordList()
        {
            return new List<string> {
                "apel", "buku", "ceri", "dadu", "ekor",
                "foto", "gula", "hari", "ikan", "jari"
            };
        }

        private void InitializeGame()
        {
            SetupCulture();
            EnsureResourceDirectory();
            if (LoadResources())
            {
                SetupInitialGameState();
                LoadImages();
                StartCountingGame();
            }
        }

        private void SetupCulture()
        {
            System.Threading.Thread.CurrentThread.CurrentUICulture =
                new CultureInfo("id-ID");
        }

        private void EnsureResourceDirectory()
        {
            try
            {
                if (!Directory.Exists(resourcePath))
                {
                    Directory.CreateDirectory(resourcePath);
                    MessageBox.Show($"Please place your image files in: {resourcePath}", "Resource Directory Created");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error creating resource directory: {ex.Message}",
                    "Resource Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool LoadResources()
        {
            try
            {
                LoadSoundResources();
                resourcesLoaded = true;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to load game resources: {ex.Message}\nPlease ensure all required files are in the Resources folder.",
                    "Resource Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void LoadSoundResources()
        {
            string correctPath = Path.Combine(resourcePath, "correct.wav");
            string wrongPath = Path.Combine(resourcePath, "wrong.wav");

            if (!File.Exists(correctPath)) throw new FileNotFoundException("correct.wav tidak ditemukan.");
            if (!File.Exists(wrongPath)) throw new FileNotFoundException("wrong.wav tidak ditemukan.");

            correctSound = new SoundPlayer(correctPath);
            wrongSound = new SoundPlayer(wrongPath);

            correctSound.Load();
            wrongSound.Load();
        }


        private void LoadImages()
        {
            try
            {
                imageFiles = new List<string>();
                string[] supportedExtensions = { "*.png", "*.jpg", "*.jpeg" };

                foreach (string extension in supportedExtensions)
                {
                    string[] files = Directory.GetFiles(resourcePath, extension);
                    foreach (string file in files)
                    {
                        string fileName = Path.GetFileNameWithoutExtension(file).ToLower();
                        if (words.Contains(fileName))
                        {
                            imageFiles.Add(file);
                        }
                    }
                }

                if (imageFiles.Count == 0)
                {
                    throw new FileNotFoundException("Tidak ditemukan gambar yang cocok dalam folder Resources.\nPastikan nama file sesuai daftar kata.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading images: {ex.Message}\nCek kembali folder Resources dan nama file gambarnya.",
                    "Resource Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void SetupInitialGameState()
        {
            btnMenghitung.BackColor = Color.LightGreen;
            btnMembaca.BackColor = SystemColors.Control;
            UpdateGameStatus();
        }

        private void UpdateGameStatus()
        {
            lblCaption.Text = "Game Belajar Menghitung dan Membaca";
            lblScore.Text = $"Skor: {score}";
            lblLevel.Text = $"Level: {currentLevel}";
            lblFeedback.Text = string.Empty;
        }

        private void StartCountingGame()
        {
            if (!resourcesLoaded) return;

            isCountingGame = true;
            questionsAnswered = 0;

            pnlReadingGame.Visible = false;
            pnlCountingGame.Visible = true;

            UpdateGameModeButtons();
            GenerateCountingQuestion();
        }

        private void StartReadingGame()
        {
            if (!resourcesLoaded) return;

            isCountingGame = false;
            questionsAnswered = 0;

            pnlCountingGame.Visible = false;
            pnlReadingGame.Visible = true;

            UpdateGameModeButtons();
            GenerateReadingQuestion();
        }

        private void UpdateGameModeButtons()
        {
            btnMenghitung.BackColor = isCountingGame ? Color.LightGreen : SystemColors.Control;
            btnMembaca.BackColor = isCountingGame ? SystemColors.Control : Color.LightGreen;
        }

        private void GenerateCountingQuestion()
        {
            pnlImages.Controls.Clear();

            int maxObjects = Math.Min(5 + currentLevel, 10);
            correctAnswer = random.Next(1, maxObjects + 1);

            DisplayCountingObjects();
            SetupCountingAnswerOptions();
            lblCountingQuestion.Text = "Berapa banyak objek di atas?";
        }

        private void DisplayCountingObjects()
        {
            pnlImages.Controls.Clear();

            if (imageFiles.Count == 0) return;

            string selectedImage = imageFiles[random.Next(imageFiles.Count)];

            Image originalImage = null;
            try
            {
                using (var stream = new FileStream(selectedImage, FileMode.Open, FileAccess.Read))
                {
                    originalImage = Image.FromStream(stream);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Gagal memuat gambar '{selectedImage}': {ex.Message}");
                return;
            }

            if (originalImage == null) return;


            correctAnswer = random.Next(5, 21);

            int maxPerRow = 10;
            int x = IMAGE_MARGIN;
            int y = IMAGE_MARGIN;

            for (int i = 0; i < correctAnswer; i++)
            {
                PictureBox pb = new PictureBox
                {
                    Image = new Bitmap(originalImage),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Size = new Size(IMAGE_SIZE, IMAGE_SIZE),
                    Location = new Point(x, y)
                };

                pnlImages.Controls.Add(pb);

                x += IMAGE_SIZE + IMAGE_MARGIN;


                if ((i + 1) % maxPerRow == 0)
                {
                    x = IMAGE_MARGIN;
                    y += IMAGE_SIZE + IMAGE_MARGIN;
                }
            }

            originalImage.Dispose();
        }



        private void GenerateReadingQuestion()
        {
            currentWord = words[random.Next(words.Count)];
            DisplayReadingImage();
            SetupReadingAnswerOptions();
            lblReadingQuestion.Text = "Apa nama objek di atas?";
        }

        private void DisplayReadingImage()
        {
            if (picReadingImage.Image != null)
            {
                picReadingImage.Image.Dispose();
                picReadingImage.Image = null;
            }

            try
            {
                string imagePath = imageFiles.Find(path =>
                    Path.GetFileNameWithoutExtension(path).ToLower() == currentWord.ToLower());

                if (imagePath != null && File.Exists(imagePath))
                {
                    picReadingImage.Image = Image.FromFile(imagePath);
                    picReadingImage.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    throw new FileNotFoundException($"Image for '{currentWord}' not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying reading image: {ex.Message}", "Display Error");
                picReadingImage.BackColor = GetRandomColor();
            }
        }

        private void SetupCountingAnswerOptions()
        {
            List<int> options = GenerateCountingOptions();
            ShuffleList(options);

            btnOption1.Text = options[0].ToString();
            btnOption2.Text = options[1].ToString();
            btnOption3.Text = options[2].ToString();
            btnOption4.Text = options[3].ToString();
        }

        private List<int> GenerateCountingOptions()
        {
            HashSet<int> options = new HashSet<int> { correctAnswer };

            while (options.Count < 4)
            {
                int option = random.Next(Math.Max(1, correctAnswer - 3), correctAnswer + 4);
                if (option > 0)
                {
                    options.Add(option);
                }
            }

            return new List<int>(options);
        }

        private void SetupReadingAnswerOptions()
        {
            List<string> options = GenerateReadingOptions();
            ShuffleList(options);

            btnReadingOption1.Text = options[0];
            btnReadingOption2.Text = options[1];
            btnReadingOption3.Text = options[2];
            btnReadingOption4.Text = options[3];
        }

        private List<string> GenerateReadingOptions()
        {
            HashSet<string> options = new HashSet<string> { currentWord };
            List<string> availableWords = new List<string>(words);
            availableWords.Remove(currentWord);
            ShuffleList(availableWords);

            while (options.Count < 4 && availableWords.Count > 0)
            {
                options.Add(availableWords[0]);
                availableWords.RemoveAt(0);
            }

            return new List<string>(options);
        }

        private Color GetRandomColor()
        {
            return Color.FromArgb(
                random.Next(100, 256),
                random.Next(100, 256),
                random.Next(100, 256)
            );
        }

        private void ShuffleList<T>(List<T> list)
        {
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
        }

        private void CheckCountingAnswer(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                bool isCorrect = clickedButton.Text == correctAnswer.ToString();
                ProcessAnswer(isCorrect);
            }
        }


        private void CheckReadingAnswer(object sender, EventArgs e)
        {
            if (sender is Button clickedButton)
            {
                ProcessAnswer(clickedButton.Text == currentWord);
            }
        }

        private void ProcessAnswer(bool isCorrect)
        {
            if (isCorrect)
            {
                HandleCorrectAnswer();
            }
            else
            {
                HandleWrongAnswer();
            }

            questionsAnswered++;
            CheckProgressionAfterQuestion();
        }

        private void HandleCorrectAnswer()
        {
            score += currentLevel * SCORE_MULTIPLIER;
            lblScore.Text = $"Skor: {score}";
            lblFeedback.Text = "Benar!";
            lblFeedback.ForeColor = Color.Green;
            try
            {
                correctSound?.Play();
            }
            catch { }
        }

        private void HandleWrongAnswer()
        {
            string correctAnswerText = isCountingGame ? correctAnswer.ToString() : currentWord;
            lblFeedback.Text = $"Salah, jawaban yang benar adalah {correctAnswerText}";
            lblFeedback.ForeColor = Color.Red;
            try
            {
                wrongSound?.Play();
            }
            catch { }
        }

        private void CheckProgressionAfterQuestion()
        {
            if (questionsAnswered >= QUESTIONS_PER_LEVEL)
            {
                HandleLevelProgression();
            }
            else
            {
                ScheduleNextQuestion();
            }
        }

        private void HandleLevelProgression()
        {
            if (currentLevel < MAX_LEVEL)
            {
                currentLevel++;
                lblLevel.Text = $"Level: {currentLevel}";
                lblFeedback.Text = $"Selamat! Kamu naik ke Level {currentLevel}";
                lblFeedback.ForeColor = Color.Blue;
            }

            if (isCountingGame)
            {
                StartReadingGame();
            }
            else
            {
                StartCountingGame();
            }
        }

        private void ScheduleNextQuestion()
        {
            Timer timer = new Timer
            {
                Interval = 1500
            };

            timer.Tick += (s, args) =>
            {
                timer.Stop();
                timer.Dispose();
                GenerateNextQuestion();
                lblFeedback.Text = string.Empty;
            };

            timer.Start();
        }

        private void GenerateNextQuestion()
        {
            if (isCountingGame)
            {
                GenerateCountingQuestion();
            }
            else
            {
                GenerateReadingQuestion();
            }
        }

        private void btnMenghitung_Click(object sender, EventArgs e)
        {
            StartCountingGame();
        }

        private void btnMembaca_Click(object sender, EventArgs e)
        {
            StartReadingGame();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetGame();
        }

        private void ResetGame()
        {
            score = 0;
            currentLevel = 1;
            UpdateGameStatus();

            if (isCountingGame)
            {
                StartCountingGame();
            }
            else
            {
                StartReadingGame();
            }
        }

        private void Game3_FormClosing(object sender, FormClosingEventArgs e)
        {
            CleanupResources();
        }

        private void CleanupResources()
        {
            try
            {
                correctSound?.Dispose();
                wrongSound?.Dispose();

                foreach (Control control in pnlImages.Controls)
                {
                    if (control is PictureBox pb)
                    {
                        pb.Image?.Dispose();
                        pb.Image = null;
                    }
                }

                if (picReadingImage.Image != null)
                {
                    picReadingImage.Image.Dispose();
                    picReadingImage.Image = null;
                }
            }
            catch { }
        }
    }
}