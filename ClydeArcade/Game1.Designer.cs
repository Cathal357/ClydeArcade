namespace ClydeArcade
{
    partial class Game1
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
            this.lbl_game1_score = new System.Windows.Forms.Label();
            this.game1_player = new System.Windows.Forms.PictureBox();
            this.game1_ground = new System.Windows.Forms.PictureBox();
            this.game1_enemy1 = new System.Windows.Forms.PictureBox();
            this.game1_enemy2 = new System.Windows.Forms.PictureBox();
            this.game1_timer = new System.Windows.Forms.Timer(this.components);
            this.game1_enemy3 = new System.Windows.Forms.PictureBox();
            this.game1_enemy4 = new System.Windows.Forms.PictureBox();
            this.game1_enemy5 = new System.Windows.Forms.PictureBox();
            this.game1_enemy6 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.game1_player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game1_ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game1_enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game1_enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game1_enemy3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game1_enemy4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game1_enemy5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.game1_enemy6)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_game1_score
            // 
            this.lbl_game1_score.AutoSize = true;
            this.lbl_game1_score.BackColor = System.Drawing.Color.SkyBlue;
            this.lbl_game1_score.Font = new System.Drawing.Font("MV Boli", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game1_score.Location = new System.Drawing.Point(26, 20);
            this.lbl_game1_score.Name = "lbl_game1_score";
            this.lbl_game1_score.Size = new System.Drawing.Size(163, 52);
            this.lbl_game1_score.TabIndex = 0;
            this.lbl_game1_score.Text = "Score: ";
            this.lbl_game1_score.Click += new System.EventHandler(this.label1_Click);
            // 
            // game1_player
            // 
            this.game1_player.Image = global::ClydeArcade.Properties.Resources.game1_player;
            this.game1_player.Location = new System.Drawing.Point(73, 146);
            this.game1_player.Name = "game1_player";
            this.game1_player.Size = new System.Drawing.Size(96, 56);
            this.game1_player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.game1_player.TabIndex = 4;
            this.game1_player.TabStop = false;
            // 
            // game1_ground
            // 
            this.game1_ground.Image = global::ClydeArcade.Properties.Resources.game1_ground;
            this.game1_ground.Location = new System.Drawing.Point(-2, 387);
            this.game1_ground.Name = "game1_ground";
            this.game1_ground.Size = new System.Drawing.Size(1774, 64);
            this.game1_ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.game1_ground.TabIndex = 3;
            this.game1_ground.TabStop = false;
            // 
            // game1_enemy1
            // 
            this.game1_enemy1.Image = global::ClydeArcade.Properties.Resources.game1_enemy;
            this.game1_enemy1.Location = new System.Drawing.Point(349, 303);
            this.game1_enemy1.Name = "game1_enemy1";
            this.game1_enemy1.Size = new System.Drawing.Size(145, 78);
            this.game1_enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.game1_enemy1.TabIndex = 2;
            this.game1_enemy1.TabStop = false;
            // 
            // game1_enemy2
            // 
            this.game1_enemy2.Image = global::ClydeArcade.Properties.Resources.game1_enemy;
            this.game1_enemy2.Location = new System.Drawing.Point(349, -6);
            this.game1_enemy2.Name = "game1_enemy2";
            this.game1_enemy2.Size = new System.Drawing.Size(145, 78);
            this.game1_enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.game1_enemy2.TabIndex = 1;
            this.game1_enemy2.TabStop = false;
            // 
            // game1_timer
            // 
            this.game1_timer.Enabled = true;
            this.game1_timer.Interval = 20;
            this.game1_timer.Tick += new System.EventHandler(this.gameTimerEvent);
            // 
            // game1_enemy3
            // 
            this.game1_enemy3.Image = global::ClydeArcade.Properties.Resources.game1_enemy;
            this.game1_enemy3.Location = new System.Drawing.Point(947, 303);
            this.game1_enemy3.Name = "game1_enemy3";
            this.game1_enemy3.Size = new System.Drawing.Size(145, 78);
            this.game1_enemy3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.game1_enemy3.TabIndex = 5;
            this.game1_enemy3.TabStop = false;
            // 
            // game1_enemy4
            // 
            this.game1_enemy4.Image = global::ClydeArcade.Properties.Resources.game1_enemy;
            this.game1_enemy4.Location = new System.Drawing.Point(1226, 218);
            this.game1_enemy4.Name = "game1_enemy4";
            this.game1_enemy4.Size = new System.Drawing.Size(145, 78);
            this.game1_enemy4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.game1_enemy4.TabIndex = 6;
            this.game1_enemy4.TabStop = false;
            // 
            // game1_enemy5
            // 
            this.game1_enemy5.Image = global::ClydeArcade.Properties.Resources.game1_enemy;
            this.game1_enemy5.Location = new System.Drawing.Point(947, -6);
            this.game1_enemy5.Name = "game1_enemy5";
            this.game1_enemy5.Size = new System.Drawing.Size(145, 78);
            this.game1_enemy5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.game1_enemy5.TabIndex = 7;
            this.game1_enemy5.TabStop = false;
            // 
            // game1_enemy6
            // 
            this.game1_enemy6.Image = global::ClydeArcade.Properties.Resources.game1_enemy;
            this.game1_enemy6.Location = new System.Drawing.Point(651, 73);
            this.game1_enemy6.Name = "game1_enemy6";
            this.game1_enemy6.Size = new System.Drawing.Size(145, 78);
            this.game1_enemy6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.game1_enemy6.TabIndex = 8;
            this.game1_enemy6.TabStop = false;
            // 
            // Game1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(569, 450);
            this.Controls.Add(this.lbl_game1_score);
            this.Controls.Add(this.game1_player);
            this.Controls.Add(this.game1_enemy6);
            this.Controls.Add(this.game1_enemy5);
            this.Controls.Add(this.game1_enemy4);
            this.Controls.Add(this.game1_enemy3);
            this.Controls.Add(this.game1_ground);
            this.Controls.Add(this.game1_enemy1);
            this.Controls.Add(this.game1_enemy2);
            this.Name = "Game1";
            this.Text = "Game1";
            this.Load += new System.EventHandler(this.Game1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.game1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.game1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.game1_player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game1_ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game1_enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game1_enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game1_enemy3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game1_enemy4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game1_enemy5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.game1_enemy6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_game1_score;
        private System.Windows.Forms.PictureBox game1_enemy2;
        private System.Windows.Forms.PictureBox game1_enemy1;
        private System.Windows.Forms.PictureBox game1_ground;
        private System.Windows.Forms.PictureBox game1_player;
        private System.Windows.Forms.Timer game1_timer;
        private System.Windows.Forms.PictureBox game1_enemy3;
        private System.Windows.Forms.PictureBox game1_enemy4;
        private System.Windows.Forms.PictureBox game1_enemy5;
        private System.Windows.Forms.PictureBox game1_enemy6;
    }
}