namespace ClydeArcade
{
    partial class ClydeArcade
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
            this.btn_game1 = new System.Windows.Forms.Button();
            this.btn_game2 = new System.Windows.Forms.Button();
            this.btn_game3 = new System.Windows.Forms.Button();
            this.btn_leaderboard = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.btn_homeScreen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_game1
            // 
            this.btn_game1.BackgroundImage = global::ClydeArcade.Properties.Resources.arcade_button2;
            this.btn_game1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_game1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_game1.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_game1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_game1.Location = new System.Drawing.Point(125, 116);
            this.btn_game1.Name = "btn_game1";
            this.btn_game1.Size = new System.Drawing.Size(196, 91);
            this.btn_game1.TabIndex = 1;
            this.btn_game1.Text = "Flight Frenzy";
            this.btn_game1.UseVisualStyleBackColor = true;
            this.btn_game1.Click += new System.EventHandler(this.btn_game1_Click);
            // 
            // btn_game2
            // 
            this.btn_game2.BackgroundImage = global::ClydeArcade.Properties.Resources.arcade_button2;
            this.btn_game2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_game2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_game2.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_game2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_game2.Location = new System.Drawing.Point(125, 230);
            this.btn_game2.Name = "btn_game2";
            this.btn_game2.Size = new System.Drawing.Size(196, 91);
            this.btn_game2.TabIndex = 2;
            this.btn_game2.Text = "Snake Escape";
            this.btn_game2.UseVisualStyleBackColor = true;
            this.btn_game2.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_game3
            // 
            this.btn_game3.BackgroundImage = global::ClydeArcade.Properties.Resources.arcade_button2;
            this.btn_game3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_game3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_game3.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_game3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_game3.Location = new System.Drawing.Point(125, 347);
            this.btn_game3.Name = "btn_game3";
            this.btn_game3.Size = new System.Drawing.Size(196, 91);
            this.btn_game3.TabIndex = 3;
            this.btn_game3.Text = "Memory Match";
            this.btn_game3.UseVisualStyleBackColor = true;
            this.btn_game3.Click += new System.EventHandler(this.btn_game3_Click);
            // 
            // btn_leaderboard
            // 
            this.btn_leaderboard.AutoSize = true;
            this.btn_leaderboard.BackColor = System.Drawing.SystemColors.Control;
            this.btn_leaderboard.BackgroundImage = global::ClydeArcade.Properties.Resources.arcade_button2;
            this.btn_leaderboard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_leaderboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_leaderboard.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_leaderboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_leaderboard.Location = new System.Drawing.Point(458, 116);
            this.btn_leaderboard.Name = "btn_leaderboard";
            this.btn_leaderboard.Size = new System.Drawing.Size(245, 140);
            this.btn_leaderboard.TabIndex = 4;
            this.btn_leaderboard.TabStop = false;
            this.btn_leaderboard.Text = "Leaderboard";
            this.btn_leaderboard.UseVisualStyleBackColor = false;
            this.btn_leaderboard.Click += new System.EventHandler(this.button5_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackgroundImage = global::ClydeArcade.Properties.Resources.arcade_button2;
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_exit.Location = new System.Drawing.Point(458, 298);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(245, 140);
            this.btn_exit.TabIndex = 5;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_title.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_title.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_title.Image = global::ClydeArcade.Properties.Resources.arcade_button;
            this.lbl_title.Location = new System.Drawing.Point(240, 9);
            this.lbl_title.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Padding = new System.Windows.Forms.Padding(45, 25, 45, 25);
            this.lbl_title.Size = new System.Drawing.Size(319, 96);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "Clyde Arcade";
            // 
            // btn_homeScreen
            // 
            this.btn_homeScreen.AutoSize = true;
            this.btn_homeScreen.BackColor = System.Drawing.SystemColors.Control;
            this.btn_homeScreen.BackgroundImage = global::ClydeArcade.Properties.Resources.arcade_background;
            this.btn_homeScreen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_homeScreen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_homeScreen.Font = new System.Drawing.Font("MV Boli", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_homeScreen.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_homeScreen.Location = new System.Drawing.Point(37, 9);
            this.btn_homeScreen.Name = "btn_homeScreen";
            this.btn_homeScreen.Size = new System.Drawing.Size(740, 429);
            this.btn_homeScreen.TabIndex = 7;
            this.btn_homeScreen.TabStop = false;
            this.btn_homeScreen.Text = "Press To Play!";
            this.btn_homeScreen.UseVisualStyleBackColor = true;
            this.btn_homeScreen.Click += new System.EventHandler(this.btn_homeScreen_Click);
            // 
            // ClydeArcade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClydeArcade.Properties.Resources.arcade_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_homeScreen);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_leaderboard);
            this.Controls.Add(this.btn_game3);
            this.Controls.Add(this.btn_game2);
            this.Controls.Add(this.btn_game1);
            this.DoubleBuffered = true;
            this.Name = "ClydeArcade";
            this.Text = "ClydeArcade";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.arcade_formClosed);
            this.Load += new System.EventHandler(this.ClydeArcade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_game1;
        private System.Windows.Forms.Button btn_game2;
        private System.Windows.Forms.Button btn_game3;
        private System.Windows.Forms.Button btn_leaderboard;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Button btn_homeScreen;
    }
}