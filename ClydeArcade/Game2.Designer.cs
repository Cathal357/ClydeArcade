namespace ClydeArcade
{
    partial class Game2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game2));
            this.lbl_game2_score = new System.Windows.Forms.Label();
            this.game2_food = new System.Windows.Forms.PictureBox();
            this.game2_head = new System.Windows.Forms.PictureBox();
            this.game2_body = new System.Windows.Forms.PictureBox();
            this.game2_timer = new System.Windows.Forms.Timer(this.components);
            this.game2_border1 = new System.Windows.Forms.PictureBox();
            this.game2_border3 = new System.Windows.Forms.PictureBox();
            this.game2_border2 = new System.Windows.Forms.PictureBox();
            this.game2_border4 = new System.Windows.Forms.PictureBox();
            this.game2_gameOver = new System.Windows.Forms.PictureBox();
            this.lbl_gameOver = new System.Windows.Forms.Label();
            this.btn_gameOverBack = new System.Windows.Forms.Button();
            this.btn_gameOverRetry = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.game2_food)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game2_head)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game2_body)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game2_border1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game2_border3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game2_border2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game2_border4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game2_gameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_game2_score
            // 
            this.lbl_game2_score.AutoSize = true;
            this.lbl_game2_score.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.lbl_game2_score.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game2_score.Location = new System.Drawing.Point(34, 28);
            this.lbl_game2_score.Name = "lbl_game2_score";
            this.lbl_game2_score.Size = new System.Drawing.Size(163, 52);
            this.lbl_game2_score.TabIndex = 1;
            this.lbl_game2_score.Text = "Score: ";
            // 
            // game2_food
            // 
            this.game2_food.Image = ((System.Drawing.Image)(resources.GetObject("game2_food.Image")));
            this.game2_food.Location = new System.Drawing.Point(519, 216);
            this.game2_food.Name = "game2_food";
            this.game2_food.Size = new System.Drawing.Size(37, 33);
            this.game2_food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.game2_food.TabIndex = 2;
            this.game2_food.TabStop = false;
            // 
            // game2_head
            // 
            this.game2_head.Image = ((System.Drawing.Image)(resources.GetObject("game2_head.Image")));
            this.game2_head.Location = new System.Drawing.Point(215, 216);
            this.game2_head.Name = "game2_head";
            this.game2_head.Size = new System.Drawing.Size(37, 33);
            this.game2_head.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.game2_head.TabIndex = 3;
            this.game2_head.TabStop = false;
            // 
            // game2_body
            // 
            this.game2_body.Image = ((System.Drawing.Image)(resources.GetObject("game2_body.Image")));
            this.game2_body.Location = new System.Drawing.Point(172, 216);
            this.game2_body.Name = "game2_body";
            this.game2_body.Size = new System.Drawing.Size(37, 33);
            this.game2_body.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.game2_body.TabIndex = 4;
            this.game2_body.TabStop = false;
            // 
            // game2_timer
            // 
            this.game2_timer.Enabled = true;
            this.game2_timer.Tick += new System.EventHandler(this.GameTimerEvent);
            // 
            // game2_border1
            // 
            this.game2_border1.BackColor = System.Drawing.Color.YellowGreen;
            this.game2_border1.Location = new System.Drawing.Point(-2, 425);
            this.game2_border1.Name = "game2_border1";
            this.game2_border1.Size = new System.Drawing.Size(801, 25);
            this.game2_border1.TabIndex = 5;
            this.game2_border1.TabStop = false;
            // 
            // game2_border3
            // 
            this.game2_border3.BackColor = System.Drawing.Color.YellowGreen;
            this.game2_border3.Location = new System.Drawing.Point(-2, 0);
            this.game2_border3.Name = "game2_border3";
            this.game2_border3.Size = new System.Drawing.Size(801, 25);
            this.game2_border3.TabIndex = 6;
            this.game2_border3.TabStop = false;
            // 
            // game2_border2
            // 
            this.game2_border2.BackColor = System.Drawing.Color.YellowGreen;
            this.game2_border2.Location = new System.Drawing.Point(-2, 0);
            this.game2_border2.Name = "game2_border2";
            this.game2_border2.Size = new System.Drawing.Size(30, 450);
            this.game2_border2.TabIndex = 7;
            this.game2_border2.TabStop = false;
            // 
            // game2_border4
            // 
            this.game2_border4.BackColor = System.Drawing.Color.YellowGreen;
            this.game2_border4.Location = new System.Drawing.Point(769, 0);
            this.game2_border4.Name = "game2_border4";
            this.game2_border4.Size = new System.Drawing.Size(30, 450);
            this.game2_border4.TabIndex = 8;
            this.game2_border4.TabStop = false;
            // 
            // game2_gameOver
            // 
            this.game2_gameOver.Image = global::ClydeArcade.Properties.Resources.arcade_background;
            this.game2_gameOver.Location = new System.Drawing.Point(-2, 0);
            this.game2_gameOver.Name = "game2_gameOver";
            this.game2_gameOver.Size = new System.Drawing.Size(801, 450);
            this.game2_gameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.game2_gameOver.TabIndex = 9;
            this.game2_gameOver.TabStop = false;
            // 
            // lbl_gameOver
            // 
            this.lbl_gameOver.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_gameOver.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_gameOver.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gameOver.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_gameOver.Image = global::ClydeArcade.Properties.Resources.arcade_button;
            this.lbl_gameOver.Location = new System.Drawing.Point(224, 33);
            this.lbl_gameOver.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_gameOver.Name = "lbl_gameOver";
            this.lbl_gameOver.Padding = new System.Windows.Forms.Padding(45, 25, 45, 25);
            this.lbl_gameOver.Size = new System.Drawing.Size(332, 138);
            this.lbl_gameOver.TabIndex = 10;
            this.lbl_gameOver.Text = "Game Over!";
            // 
            // btn_gameOverBack
            // 
            this.btn_gameOverBack.BackgroundImage = global::ClydeArcade.Properties.Resources.arcade_button2;
            this.btn_gameOverBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_gameOverBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gameOverBack.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gameOverBack.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_gameOverBack.Location = new System.Drawing.Point(144, 216);
            this.btn_gameOverBack.Name = "btn_gameOverBack";
            this.btn_gameOverBack.Size = new System.Drawing.Size(196, 91);
            this.btn_gameOverBack.TabIndex = 11;
            this.btn_gameOverBack.Text = "Back To Menu";
            this.btn_gameOverBack.UseVisualStyleBackColor = true;
            this.btn_gameOverBack.Click += new System.EventHandler(this.btn_gameOverBack_Click);
            // 
            // btn_gameOverRetry
            // 
            this.btn_gameOverRetry.BackgroundImage = global::ClydeArcade.Properties.Resources.arcade_button2;
            this.btn_gameOverRetry.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_gameOverRetry.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_gameOverRetry.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_gameOverRetry.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_gameOverRetry.Location = new System.Drawing.Point(436, 216);
            this.btn_gameOverRetry.Name = "btn_gameOverRetry";
            this.btn_gameOverRetry.Size = new System.Drawing.Size(196, 91);
            this.btn_gameOverRetry.TabIndex = 12;
            this.btn_gameOverRetry.Text = "Retry";
            this.btn_gameOverRetry.UseVisualStyleBackColor = true;
            this.btn_gameOverRetry.Click += new System.EventHandler(this.btn_gameOverRetry_Click);
            // 
            // Game2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_gameOverRetry);
            this.Controls.Add(this.btn_gameOverBack);
            this.Controls.Add(this.lbl_gameOver);
            this.Controls.Add(this.game2_gameOver);
            this.Controls.Add(this.game2_border4);
            this.Controls.Add(this.game2_border2);
            this.Controls.Add(this.game2_border3);
            this.Controls.Add(this.game2_border1);
            this.Controls.Add(this.game2_body);
            this.Controls.Add(this.game2_head);
            this.Controls.Add(this.game2_food);
            this.Controls.Add(this.lbl_game2_score);
            this.Name = "Game2";
            this.Text = "Game2";
            this.Load += new System.EventHandler(this.Game2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game2_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.game2_food)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game2_head)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game2_body)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game2_border1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game2_border3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game2_border2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game2_border4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game2_gameOver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_game2_score;
        private System.Windows.Forms.PictureBox game2_food;
        private System.Windows.Forms.PictureBox game2_head;
        private System.Windows.Forms.PictureBox game2_body;
        private System.Windows.Forms.Timer game2_timer;
        private System.Windows.Forms.PictureBox game2_border1;
        private System.Windows.Forms.PictureBox game2_border3;
        private System.Windows.Forms.PictureBox game2_border2;
        private System.Windows.Forms.PictureBox game2_border4;
        private System.Windows.Forms.PictureBox game2_gameOver;
        private System.Windows.Forms.Label lbl_gameOver;
        private System.Windows.Forms.Button btn_gameOverBack;
        private System.Windows.Forms.Button btn_gameOverRetry;
    }
}