namespace ClydeArcade
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
            this.components = new System.ComponentModel.Container();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.btn_card2 = new System.Windows.Forms.Button();
            this.btn_card3 = new System.Windows.Forms.Button();
            this.btn_card5 = new System.Windows.Forms.Button();
            this.btn_card6 = new System.Windows.Forms.Button();
            this.btn_card8 = new System.Windows.Forms.Button();
            this.btn_card9 = new System.Windows.Forms.Button();
            this.btn_card7 = new System.Windows.Forms.Button();
            this.btn_card1 = new System.Windows.Forms.Button();
            this.btn_card4 = new System.Windows.Forms.Button();
            this.btn_gameStart = new System.Windows.Forms.Button();
            this.game3_timer = new System.Windows.Forms.Timer(this.components);
            this.btn_hidden1 = new System.Windows.Forms.Button();
            this.btn_hidden2 = new System.Windows.Forms.Button();
            this.btn_hidden3 = new System.Windows.Forms.Button();
            this.btn_hidden4 = new System.Windows.Forms.Button();
            this.btn_hidden5 = new System.Windows.Forms.Button();
            this.btn_hidden6 = new System.Windows.Forms.Button();
            this.btn_hidden7 = new System.Windows.Forms.Button();
            this.btn_hidden8 = new System.Windows.Forms.Button();
            this.btn_hidden9 = new System.Windows.Forms.Button();
            this.btn_gameOverRetry = new System.Windows.Forms.Button();
            this.btn_gameOverBack = new System.Windows.Forms.Button();
            this.lbl_gameOver = new System.Windows.Forms.Label();
            this.game3_gameOver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.game3_gameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_score
            // 
            this.lbl_score.AutoSize = true;
            this.lbl_score.BackColor = System.Drawing.Color.Bisque;
            this.lbl_score.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_score.Location = new System.Drawing.Point(302, 9);
            this.lbl_score.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_score.Size = new System.Drawing.Size(179, 64);
            this.lbl_score.TabIndex = 15;
            this.lbl_score.Text = "Score: 0";
            this.lbl_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_score.Click += new System.EventHandler(this.lbl_score_Click);
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.BackColor = System.Drawing.Color.Bisque;
            this.lbl_timer.Font = new System.Drawing.Font("Myanmar Text", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_timer.Location = new System.Drawing.Point(331, 60);
            this.lbl_timer.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Padding = new System.Windows.Forms.Padding(10);
            this.lbl_timer.Size = new System.Drawing.Size(124, 78);
            this.lbl_timer.TabIndex = 16;
            this.lbl_timer.Text = "00:00";
            this.lbl_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_timer.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_card2
            // 
            this.btn_card2.BackColor = System.Drawing.Color.Sienna;
            this.btn_card2.BackgroundImage = global::ClydeArcade.Properties.Resources.cardImage1;
            this.btn_card2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_card2.Location = new System.Drawing.Point(332, 124);
            this.btn_card2.Name = "btn_card2";
            this.btn_card2.Size = new System.Drawing.Size(114, 89);
            this.btn_card2.TabIndex = 17;
            this.btn_card2.UseVisualStyleBackColor = false;
            this.btn_card2.Click += new System.EventHandler(this.btn_card2_Click);
            // 
            // btn_card3
            // 
            this.btn_card3.BackColor = System.Drawing.Color.Sienna;
            this.btn_card3.BackgroundImage = global::ClydeArcade.Properties.Resources.cardImage2;
            this.btn_card3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_card3.Location = new System.Drawing.Point(452, 124);
            this.btn_card3.Name = "btn_card3";
            this.btn_card3.Size = new System.Drawing.Size(114, 89);
            this.btn_card3.TabIndex = 19;
            this.btn_card3.UseVisualStyleBackColor = false;
            this.btn_card3.Click += new System.EventHandler(this.btn_card3_Click);
            // 
            // btn_card5
            // 
            this.btn_card5.BackColor = System.Drawing.Color.Sienna;
            this.btn_card5.BackgroundImage = global::ClydeArcade.Properties.Resources.cardImage4;
            this.btn_card5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_card5.Location = new System.Drawing.Point(332, 219);
            this.btn_card5.Name = "btn_card5";
            this.btn_card5.Size = new System.Drawing.Size(114, 89);
            this.btn_card5.TabIndex = 20;
            this.btn_card5.UseVisualStyleBackColor = false;
            this.btn_card5.Click += new System.EventHandler(this.btn_card5_Click);
            // 
            // btn_card6
            // 
            this.btn_card6.BackColor = System.Drawing.Color.Sienna;
            this.btn_card6.BackgroundImage = global::ClydeArcade.Properties.Resources.cardImage4;
            this.btn_card6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_card6.Location = new System.Drawing.Point(452, 219);
            this.btn_card6.Name = "btn_card6";
            this.btn_card6.Size = new System.Drawing.Size(114, 89);
            this.btn_card6.TabIndex = 21;
            this.btn_card6.UseVisualStyleBackColor = false;
            this.btn_card6.Click += new System.EventHandler(this.btn_card6_Click);
            // 
            // btn_card8
            // 
            this.btn_card8.BackColor = System.Drawing.Color.Sienna;
            this.btn_card8.BackgroundImage = global::ClydeArcade.Properties.Resources.cardImage5;
            this.btn_card8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_card8.Location = new System.Drawing.Point(332, 314);
            this.btn_card8.Name = "btn_card8";
            this.btn_card8.Size = new System.Drawing.Size(114, 89);
            this.btn_card8.TabIndex = 23;
            this.btn_card8.UseVisualStyleBackColor = false;
            this.btn_card8.Click += new System.EventHandler(this.btn_card8_Click);
            // 
            // btn_card9
            // 
            this.btn_card9.BackColor = System.Drawing.Color.Sienna;
            this.btn_card9.BackgroundImage = global::ClydeArcade.Properties.Resources.cardImage3;
            this.btn_card9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_card9.Location = new System.Drawing.Point(452, 314);
            this.btn_card9.Name = "btn_card9";
            this.btn_card9.Size = new System.Drawing.Size(114, 89);
            this.btn_card9.TabIndex = 24;
            this.btn_card9.UseVisualStyleBackColor = false;
            this.btn_card9.Click += new System.EventHandler(this.btn_card9_Click);
            // 
            // btn_card7
            // 
            this.btn_card7.BackColor = System.Drawing.Color.Sienna;
            this.btn_card7.BackgroundImage = global::ClydeArcade.Properties.Resources.cardImage5;
            this.btn_card7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_card7.Location = new System.Drawing.Point(214, 314);
            this.btn_card7.Name = "btn_card7";
            this.btn_card7.Size = new System.Drawing.Size(114, 89);
            this.btn_card7.TabIndex = 25;
            this.btn_card7.UseVisualStyleBackColor = false;
            this.btn_card7.Click += new System.EventHandler(this.btn_card7_Click);
            // 
            // btn_card1
            // 
            this.btn_card1.BackColor = System.Drawing.Color.Sienna;
            this.btn_card1.BackgroundImage = global::ClydeArcade.Properties.Resources.cardImage1;
            this.btn_card1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_card1.Location = new System.Drawing.Point(214, 124);
            this.btn_card1.Name = "btn_card1";
            this.btn_card1.Size = new System.Drawing.Size(114, 89);
            this.btn_card1.TabIndex = 18;
            this.btn_card1.UseVisualStyleBackColor = false;
            this.btn_card1.Click += new System.EventHandler(this.btn_card1_Click);
            // 
            // btn_card4
            // 
            this.btn_card4.BackColor = System.Drawing.Color.Sienna;
            this.btn_card4.BackgroundImage = global::ClydeArcade.Properties.Resources.cardImage2;
            this.btn_card4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_card4.Location = new System.Drawing.Point(212, 219);
            this.btn_card4.Name = "btn_card4";
            this.btn_card4.Size = new System.Drawing.Size(114, 89);
            this.btn_card4.TabIndex = 22;
            this.btn_card4.UseVisualStyleBackColor = false;
            this.btn_card4.Click += new System.EventHandler(this.btn_card4_Click);
            // 
            // btn_gameStart
            // 
            this.btn_gameStart.BackColor = System.Drawing.Color.Sienna;
            this.btn_gameStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_gameStart.Font = new System.Drawing.Font("MV Boli", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gameStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_gameStart.Location = new System.Drawing.Point(214, 124);
            this.btn_gameStart.Name = "btn_gameStart";
            this.btn_gameStart.Size = new System.Drawing.Size(352, 279);
            this.btn_gameStart.TabIndex = 26;
            this.btn_gameStart.Text = "Press To Play!";
            this.btn_gameStart.UseVisualStyleBackColor = false;
            this.btn_gameStart.Click += new System.EventHandler(this.btn_gameStart_Click);
            // 
            // game3_timer
            // 
            this.game3_timer.Interval = 1000;
            this.game3_timer.Tick += new System.EventHandler(this.game3_timerTick);
            // 
            // btn_hidden1
            // 
            this.btn_hidden1.BackColor = System.Drawing.Color.Sienna;
            this.btn_hidden1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hidden1.Location = new System.Drawing.Point(214, 124);
            this.btn_hidden1.Name = "btn_hidden1";
            this.btn_hidden1.Size = new System.Drawing.Size(114, 89);
            this.btn_hidden1.TabIndex = 27;
            this.btn_hidden1.UseVisualStyleBackColor = false;
            // 
            // btn_hidden2
            // 
            this.btn_hidden2.BackColor = System.Drawing.Color.Sienna;
            this.btn_hidden2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hidden2.Location = new System.Drawing.Point(332, 124);
            this.btn_hidden2.Name = "btn_hidden2";
            this.btn_hidden2.Size = new System.Drawing.Size(114, 89);
            this.btn_hidden2.TabIndex = 28;
            this.btn_hidden2.UseVisualStyleBackColor = false;
            // 
            // btn_hidden3
            // 
            this.btn_hidden3.BackColor = System.Drawing.Color.Sienna;
            this.btn_hidden3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hidden3.Location = new System.Drawing.Point(452, 124);
            this.btn_hidden3.Name = "btn_hidden3";
            this.btn_hidden3.Size = new System.Drawing.Size(114, 89);
            this.btn_hidden3.TabIndex = 29;
            this.btn_hidden3.UseVisualStyleBackColor = false;
            // 
            // btn_hidden4
            // 
            this.btn_hidden4.BackColor = System.Drawing.Color.Sienna;
            this.btn_hidden4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hidden4.Location = new System.Drawing.Point(214, 219);
            this.btn_hidden4.Name = "btn_hidden4";
            this.btn_hidden4.Size = new System.Drawing.Size(114, 89);
            this.btn_hidden4.TabIndex = 30;
            this.btn_hidden4.UseVisualStyleBackColor = false;
            // 
            // btn_hidden5
            // 
            this.btn_hidden5.BackColor = System.Drawing.Color.Sienna;
            this.btn_hidden5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hidden5.Location = new System.Drawing.Point(332, 219);
            this.btn_hidden5.Name = "btn_hidden5";
            this.btn_hidden5.Size = new System.Drawing.Size(114, 89);
            this.btn_hidden5.TabIndex = 31;
            this.btn_hidden5.UseVisualStyleBackColor = false;
            // 
            // btn_hidden6
            // 
            this.btn_hidden6.BackColor = System.Drawing.Color.Sienna;
            this.btn_hidden6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hidden6.Location = new System.Drawing.Point(452, 219);
            this.btn_hidden6.Name = "btn_hidden6";
            this.btn_hidden6.Size = new System.Drawing.Size(114, 89);
            this.btn_hidden6.TabIndex = 32;
            this.btn_hidden6.UseVisualStyleBackColor = false;
            // 
            // btn_hidden7
            // 
            this.btn_hidden7.BackColor = System.Drawing.Color.Sienna;
            this.btn_hidden7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hidden7.Location = new System.Drawing.Point(214, 314);
            this.btn_hidden7.Name = "btn_hidden7";
            this.btn_hidden7.Size = new System.Drawing.Size(114, 89);
            this.btn_hidden7.TabIndex = 33;
            this.btn_hidden7.UseVisualStyleBackColor = false;
            // 
            // btn_hidden8
            // 
            this.btn_hidden8.BackColor = System.Drawing.Color.Sienna;
            this.btn_hidden8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hidden8.Location = new System.Drawing.Point(334, 314);
            this.btn_hidden8.Name = "btn_hidden8";
            this.btn_hidden8.Size = new System.Drawing.Size(114, 89);
            this.btn_hidden8.TabIndex = 34;
            this.btn_hidden8.UseVisualStyleBackColor = false;
            // 
            // btn_hidden9
            // 
            this.btn_hidden9.BackColor = System.Drawing.Color.Sienna;
            this.btn_hidden9.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_hidden9.Location = new System.Drawing.Point(452, 314);
            this.btn_hidden9.Name = "btn_hidden9";
            this.btn_hidden9.Size = new System.Drawing.Size(114, 89);
            this.btn_hidden9.TabIndex = 35;
            this.btn_hidden9.UseVisualStyleBackColor = false;
            // 
            // btn_gameOverRetry
            // 
            this.btn_gameOverRetry.BackgroundImage = global::ClydeArcade.Properties.Resources.arcade_button2;
            this.btn_gameOverRetry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_gameOverRetry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gameOverRetry.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gameOverRetry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_gameOverRetry.Location = new System.Drawing.Point(438, 216);
            this.btn_gameOverRetry.Name = "btn_gameOverRetry";
            this.btn_gameOverRetry.Size = new System.Drawing.Size(196, 91);
            this.btn_gameOverRetry.TabIndex = 40;
            this.btn_gameOverRetry.Text = "Retry";
            this.btn_gameOverRetry.UseVisualStyleBackColor = true;
            this.btn_gameOverRetry.Click += new System.EventHandler(this.btn_gameOverRetry_Click);
            // 
            // btn_gameOverBack
            // 
            this.btn_gameOverBack.BackgroundImage = global::ClydeArcade.Properties.Resources.arcade_button2;
            this.btn_gameOverBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_gameOverBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gameOverBack.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gameOverBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_gameOverBack.Location = new System.Drawing.Point(146, 216);
            this.btn_gameOverBack.Name = "btn_gameOverBack";
            this.btn_gameOverBack.Size = new System.Drawing.Size(196, 91);
            this.btn_gameOverBack.TabIndex = 39;
            this.btn_gameOverBack.Text = "Back To Menu";
            this.btn_gameOverBack.UseVisualStyleBackColor = true;
            this.btn_gameOverBack.Click += new System.EventHandler(this.btn_gameOverBack_Click);
            // 
            // lbl_gameOver
            // 
            this.lbl_gameOver.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_gameOver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_gameOver.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameOver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_gameOver.Image = global::ClydeArcade.Properties.Resources.arcade_button;
            this.lbl_gameOver.Location = new System.Drawing.Point(226, 33);
            this.lbl_gameOver.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_gameOver.Name = "lbl_gameOver";
            this.lbl_gameOver.Padding = new System.Windows.Forms.Padding(45, 25, 45, 25);
            this.lbl_gameOver.Size = new System.Drawing.Size(332, 138);
            this.lbl_gameOver.TabIndex = 38;
            this.lbl_gameOver.Text = "Game Over!";
            this.lbl_gameOver.Click += new System.EventHandler(this.lbl_gameOver_Click);
            // 
            // game3_gameOver
            // 
            this.game3_gameOver.Image = global::ClydeArcade.Properties.Resources.arcade_background;
            this.game3_gameOver.Location = new System.Drawing.Point(-1, -1);
            this.game3_gameOver.Name = "game3_gameOver";
            this.game3_gameOver.Size = new System.Drawing.Size(801, 453);
            this.game3_gameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.game3_gameOver.TabIndex = 41;
            this.game3_gameOver.TabStop = false;
            // 
            // Game3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_gameOver);
            this.Controls.Add(this.btn_gameOverBack);
            this.Controls.Add(this.btn_gameOverRetry);
            this.Controls.Add(this.game3_gameOver);
            this.Controls.Add(this.btn_gameStart);
            this.Controls.Add(this.btn_hidden9);
            this.Controls.Add(this.btn_hidden8);
            this.Controls.Add(this.btn_hidden7);
            this.Controls.Add(this.btn_hidden6);
            this.Controls.Add(this.btn_hidden5);
            this.Controls.Add(this.btn_hidden4);
            this.Controls.Add(this.btn_hidden3);
            this.Controls.Add(this.btn_hidden2);
            this.Controls.Add(this.btn_hidden1);
            this.Controls.Add(this.btn_card7);
            this.Controls.Add(this.btn_card9);
            this.Controls.Add(this.btn_card8);
            this.Controls.Add(this.btn_card4);
            this.Controls.Add(this.btn_card6);
            this.Controls.Add(this.btn_card5);
            this.Controls.Add(this.btn_card3);
            this.Controls.Add(this.btn_card1);
            this.Controls.Add(this.btn_card2);
            this.Controls.Add(this.lbl_score);
            this.Controls.Add(this.lbl_timer);
            this.Name = "Game3";
            this.Text = "Game3";
            this.Load += new System.EventHandler(this.Game3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.game3_gameOver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_timer;
        private System.Windows.Forms.Button btn_card2;
        private System.Windows.Forms.Button btn_card1;
        private System.Windows.Forms.Button btn_card3;
        private System.Windows.Forms.Button btn_card5;
        private System.Windows.Forms.Button btn_card6;
        private System.Windows.Forms.Button btn_card4;
        private System.Windows.Forms.Button btn_card8;
        private System.Windows.Forms.Button btn_card9;
        private System.Windows.Forms.Button btn_card7;
        private System.Windows.Forms.Button btn_gameStart;
        private System.Windows.Forms.Timer game3_timer;
        private System.Windows.Forms.Button btn_hidden1;
        private System.Windows.Forms.Button btn_hidden2;
        private System.Windows.Forms.Button btn_hidden3;
        private System.Windows.Forms.Button btn_hidden4;
        private System.Windows.Forms.Button btn_hidden5;
        private System.Windows.Forms.Button btn_hidden6;
        private System.Windows.Forms.Button btn_hidden7;
        private System.Windows.Forms.Button btn_hidden8;
        private System.Windows.Forms.Button btn_hidden9;
        private System.Windows.Forms.Button btn_gameOverRetry;
        private System.Windows.Forms.Button btn_gameOverBack;
        private System.Windows.Forms.Label lbl_gameOver;
        private System.Windows.Forms.PictureBox game3_gameOver;
    }
}