namespace GameBelajar
{
    partial class Game3
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCaption = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnMenghitung = new System.Windows.Forms.Button();
            this.btnMembaca = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlCountingGame = new System.Windows.Forms.Panel();
            this.lblCountingQuestion = new System.Windows.Forms.Label();
            this.pnlImages = new System.Windows.Forms.Panel();
            this.btnOption1 = new System.Windows.Forms.Button();
            this.btnOption2 = new System.Windows.Forms.Button();
            this.btnOption3 = new System.Windows.Forms.Button();
            this.btnOption4 = new System.Windows.Forms.Button();
            this.pnlReadingGame = new System.Windows.Forms.Panel();
            this.lblReadingQuestion = new System.Windows.Forms.Label();
            this.picReadingImage = new System.Windows.Forms.PictureBox();
            this.btnReadingOption1 = new System.Windows.Forms.Button();
            this.btnReadingOption2 = new System.Windows.Forms.Button();
            this.btnReadingOption3 = new System.Windows.Forms.Button();
            this.btnReadingOption4 = new System.Windows.Forms.Button();
            this.lblFeedback = new System.Windows.Forms.Label();
            this.pnlCountingGame.SuspendLayout();
            this.pnlReadingGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReadingImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCaption
            // 
            this.lblCaption.AutoSize = true;
            this.lblCaption.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaption.Location = new System.Drawing.Point(13, 14);
            this.lblCaption.Name = "lblCaption";
            this.lblCaption.Size = new System.Drawing.Size(538, 31);
            this.lblCaption.TabIndex = 0;
            this.lblCaption.Text = "Game Belajar Menghitung dan Membaca";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(13, 53);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(75, 25);
            this.lblScore.TabIndex = 1;
            this.lblScore.Text = "Skor: 0";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(120, 53);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(81, 25);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "Level: 1";
            // 
            // btnMenghitung
            // 
            this.btnMenghitung.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenghitung.Location = new System.Drawing.Point(223, 53);
            this.btnMenghitung.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMenghitung.Name = "btnMenghitung";
            this.btnMenghitung.Size = new System.Drawing.Size(117, 31);
            this.btnMenghitung.TabIndex = 3;
            this.btnMenghitung.Text = "Menghitung";
            this.btnMenghitung.UseVisualStyleBackColor = true;
            this.btnMenghitung.Click += new System.EventHandler(this.btnMenghitung_Click);
            // 
            // btnMembaca
            // 
            this.btnMembaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMembaca.Location = new System.Drawing.Point(347, 53);
            this.btnMembaca.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMembaca.Name = "btnMembaca";
            this.btnMembaca.Size = new System.Drawing.Size(117, 31);
            this.btnMembaca.TabIndex = 4;
            this.btnMembaca.Text = "Membaca";
            this.btnMembaca.UseVisualStyleBackColor = true;
            this.btnMembaca.Click += new System.EventHandler(this.btnMembaca_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(471, 53);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(91, 31);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // pnlCountingGame
            // 
            this.pnlCountingGame.Controls.Add(this.lblCountingQuestion);
            this.pnlCountingGame.Controls.Add(this.pnlImages);
            this.pnlCountingGame.Controls.Add(this.btnOption1);
            this.pnlCountingGame.Controls.Add(this.btnOption2);
            this.pnlCountingGame.Controls.Add(this.btnOption3);
            this.pnlCountingGame.Controls.Add(this.btnOption4);
            this.pnlCountingGame.Location = new System.Drawing.Point(12, 100);
            this.pnlCountingGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlCountingGame.Name = "pnlCountingGame";
            this.pnlCountingGame.Size = new System.Drawing.Size(549, 400);
            this.pnlCountingGame.TabIndex = 6;
            // 
            // lblCountingQuestion
            // 
            this.lblCountingQuestion.AutoSize = true;
            this.lblCountingQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountingQuestion.Location = new System.Drawing.Point(11, 10);
            this.lblCountingQuestion.Name = "lblCountingQuestion";
            this.lblCountingQuestion.Size = new System.Drawing.Size(269, 25);
            this.lblCountingQuestion.TabIndex = 0;
            this.lblCountingQuestion.Text = "Berapa banyak objek di atas?";
            // 
            // pnlImages
            // 
            this.pnlImages.AutoScroll = true;
            this.pnlImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlImages.Location = new System.Drawing.Point(11, 39);
            this.pnlImages.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlImages.Name = "pnlImages";
            this.pnlImages.Size = new System.Drawing.Size(530, 200);
            this.pnlImages.TabIndex = 1;
            this.pnlImages.BackColor = System.Drawing.Color.White;
            // 
            // btnOption1
            // 
            this.btnOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption1.Location = new System.Drawing.Point(51, 310);
            this.btnOption1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOption1.Name = "btnOption1";
            this.btnOption1.Size = new System.Drawing.Size(100, 60);
            this.btnOption1.TabIndex = 2;
            this.btnOption1.Text = "1";
            this.btnOption1.UseVisualStyleBackColor = true;
            this.btnOption1.Click += new System.EventHandler(this.CheckCountingAnswer);
            // 
            // btnOption2
            // 
            this.btnOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption2.Location = new System.Drawing.Point(171, 310);
            this.btnOption2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOption2.Name = "btnOption2";
            this.btnOption2.Size = new System.Drawing.Size(100, 60);
            this.btnOption2.TabIndex = 3;
            this.btnOption2.Text = "2";
            this.btnOption2.UseVisualStyleBackColor = true;
            this.btnOption2.Click += new System.EventHandler(this.CheckCountingAnswer);
            // 
            // btnOption3
            // 
            this.btnOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption3.Location = new System.Drawing.Point(291, 310);
            this.btnOption3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOption3.Name = "btnOption3";
            this.btnOption3.Size = new System.Drawing.Size(100, 60);
            this.btnOption3.TabIndex = 4;
            this.btnOption3.Text = "3";
            this.btnOption3.UseVisualStyleBackColor = true;
            this.btnOption3.Click += new System.EventHandler(this.CheckCountingAnswer);
            // 
            // btnOption4
            // 
            this.btnOption4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOption4.Location = new System.Drawing.Point(411, 310);
            this.btnOption4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOption4.Name = "btnOption4";
            this.btnOption4.Size = new System.Drawing.Size(100, 60);
            this.btnOption4.TabIndex = 5;
            this.btnOption4.Text = "4";
            this.btnOption4.UseVisualStyleBackColor = true;
            this.btnOption4.Click += new System.EventHandler(this.CheckCountingAnswer);
            // 
            // pnlReadingGame
            // 
            this.pnlReadingGame.Controls.Add(this.lblReadingQuestion);
            this.pnlReadingGame.Controls.Add(this.picReadingImage);
            this.pnlReadingGame.Controls.Add(this.btnReadingOption1);
            this.pnlReadingGame.Controls.Add(this.btnReadingOption2);
            this.pnlReadingGame.Controls.Add(this.btnReadingOption3);
            this.pnlReadingGame.Controls.Add(this.btnReadingOption4);
            this.pnlReadingGame.Location = new System.Drawing.Point(12, 100);
            this.pnlReadingGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pnlReadingGame.Name = "pnlReadingGame";
            this.pnlReadingGame.Size = new System.Drawing.Size(549, 400);
            this.pnlReadingGame.TabIndex = 7;
            this.pnlReadingGame.Visible = false;
            // 
            // lblReadingQuestion
            // 
            this.lblReadingQuestion.AutoSize = true;
            this.lblReadingQuestion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReadingQuestion.Location = new System.Drawing.Point(11, 10);
            this.lblReadingQuestion.Name = "lblReadingQuestion";
            this.lblReadingQuestion.Size = new System.Drawing.Size(248, 25);
            this.lblReadingQuestion.TabIndex = 0;
            this.lblReadingQuestion.Text = "Apa nama objek di bawah?";
            // 
            // picReadingImage
            // 
            this.picReadingImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picReadingImage.Location = new System.Drawing.Point(125, 39);
            this.picReadingImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picReadingImage.Name = "picReadingImage";
            this.picReadingImage.Size = new System.Drawing.Size(300, 200);
            this.picReadingImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picReadingImage.TabIndex = 1;
            this.picReadingImage.TabStop = false;
            this.picReadingImage.BackColor = System.Drawing.Color.White;
            // btnReadingOption1
            // 
            this.btnReadingOption1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadingOption1.Location = new System.Drawing.Point(51, 265);
            this.btnReadingOption1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadingOption1.Name = "btnReadingOption1";
            this.btnReadingOption1.Size = new System.Drawing.Size(213, 50);
            this.btnReadingOption1.TabIndex = 2;
            this.btnReadingOption1.Text = "apel";
            this.btnReadingOption1.UseVisualStyleBackColor = true;
            this.btnReadingOption1.Click += new System.EventHandler(this.CheckReadingAnswer);
            // 
            // btnReadingOption2
            // 
            this.btnReadingOption2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadingOption2.Location = new System.Drawing.Point(291, 265);
            this.btnReadingOption2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadingOption2.Name = "btnReadingOption2";
            this.btnReadingOption2.Size = new System.Drawing.Size(213, 50);
            this.btnReadingOption2.TabIndex = 3;
            this.btnReadingOption2.Text = "buku";
            this.btnReadingOption2.UseVisualStyleBackColor = true;
            this.btnReadingOption2.Click += new System.EventHandler(this.CheckReadingAnswer);
            // 
            // btnReadingOption3
            // 
            this.btnReadingOption3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadingOption3.Location = new System.Drawing.Point(51, 335);
            this.btnReadingOption3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadingOption3.Name = "btnReadingOption3";
            this.btnReadingOption3.Size = new System.Drawing.Size(213, 50);
            this.btnReadingOption3.TabIndex = 4;
            this.btnReadingOption3.Text = "ceri";
            this.btnReadingOption3.UseVisualStyleBackColor = true;
            this.btnReadingOption3.Click += new System.EventHandler(this.CheckReadingAnswer);
            // 
            // btnReadingOption4
            // 
            this.btnReadingOption4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReadingOption4.Location = new System.Drawing.Point(291, 335);
            this.btnReadingOption4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnReadingOption4.Name = "btnReadingOption4";
            this.btnReadingOption4.Size = new System.Drawing.Size(213, 50);
            this.btnReadingOption4.TabIndex = 5;
            this.btnReadingOption4.Text = "dadu";
            this.btnReadingOption4.UseVisualStyleBackColor = true;
            this.btnReadingOption4.Click += new System.EventHandler(this.CheckReadingAnswer);
            // 
            // lblFeedback
            // 
            this.lblFeedback.AutoSize = true;
            this.lblFeedback.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFeedback.Location = new System.Drawing.Point(12, 510);
            this.lblFeedback.Name = "lblFeedback";
            this.lblFeedback.Size = new System.Drawing.Size(0, 29);
            this.lblFeedback.TabIndex = 8;
            // 
            // Game3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 600);
            this.Controls.Add(this.lblFeedback);
            this.Controls.Add(this.pnlReadingGame);
            this.Controls.Add(this.pnlCountingGame);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnMembaca);
            this.Controls.Add(this.btnMenghitung);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblCaption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Game3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TEMATIKA TRY";
            this.pnlCountingGame.ResumeLayout(false);
            this.pnlCountingGame.PerformLayout();
            this.pnlReadingGame.ResumeLayout(false);
            this.pnlReadingGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picReadingImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label lblCaption;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnMenghitung;
        private System.Windows.Forms.Button btnMembaca;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Panel pnlCountingGame;
        private System.Windows.Forms.Label lblCountingQuestion;
        private System.Windows.Forms.Panel pnlReadingGame;
        private System.Windows.Forms.Label lblFeedback;
        private System.Windows.Forms.Button btnOption2;
        private System.Windows.Forms.Button btnOption1;
        private System.Windows.Forms.Panel pnlImages;
        private System.Windows.Forms.Button btnOption4;
        private System.Windows.Forms.Button btnOption3;
        private System.Windows.Forms.Label lblReadingQuestion;
        private System.Windows.Forms.Button btnReadingOption1;
        private System.Windows.Forms.PictureBox picReadingImage;
        private System.Windows.Forms.Button btnReadingOption3;
        private System.Windows.Forms.Button btnReadingOption2;
        private System.Windows.Forms.Button btnReadingOption4;
    }
}