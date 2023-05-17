namespace ClydeArcade
{
    partial class Leaderboard
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
            this.lbl_leaderboard = new System.Windows.Forms.Label();
            this.lbl_game1 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            this.lbl_game1_score1 = new System.Windows.Forms.Label();
            this.lbl_game1_score2 = new System.Windows.Forms.Label();
            this.lbl_game1_score3 = new System.Windows.Forms.Label();
            this.lbl_game2 = new System.Windows.Forms.Label();
            this.lbl_game2_score1 = new System.Windows.Forms.Label();
            this.lbl_game2_score2 = new System.Windows.Forms.Label();
            this.lbl_game2_score3 = new System.Windows.Forms.Label();
            this.lbl_game3 = new System.Windows.Forms.Label();
            this.lbl_game3_score1 = new System.Windows.Forms.Label();
            this.lbl_game3_score2 = new System.Windows.Forms.Label();
            this.lbl_game3_score3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_leaderboard
            // 
            this.lbl_leaderboard.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_leaderboard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_leaderboard.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_leaderboard.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_leaderboard.Image = global::ClydeArcade.Properties.Resources.arcade_button;
            this.lbl_leaderboard.Location = new System.Drawing.Point(235, 32);
            this.lbl_leaderboard.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_leaderboard.Name = "lbl_leaderboard";
            this.lbl_leaderboard.Padding = new System.Windows.Forms.Padding(45, 25, 45, 25);
            this.lbl_leaderboard.Size = new System.Drawing.Size(328, 96);
            this.lbl_leaderboard.TabIndex = 7;
            this.lbl_leaderboard.Text = "Leaderboard";
            // 
            // lbl_game1
            // 
            this.lbl_game1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_game1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_game1.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_game1.Image = global::ClydeArcade.Properties.Resources.arcade_button;
            this.lbl_game1.Location = new System.Drawing.Point(24, 196);
            this.lbl_game1.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_game1.Name = "lbl_game1";
            this.lbl_game1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_game1.Size = new System.Drawing.Size(233, 201);
            this.lbl_game1.TabIndex = 8;
            this.lbl_game1.Text = "Flight Frenzy";
            this.lbl_game1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btn_back
            // 
            this.btn_back.BackgroundImage = global::ClydeArcade.Properties.Resources.arcade_button2;
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.Font = new System.Drawing.Font("MV Boli", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_back.Location = new System.Drawing.Point(53, 45);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(82, 60);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_game1_Click);
            // 
            // lbl_game1_score1
            // 
            this.lbl_game1_score1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game1_score1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_game1_score1.Image = global::ClydeArcade.Properties.Resources.arcade_background;
            this.lbl_game1_score1.Location = new System.Drawing.Point(57, 298);
            this.lbl_game1_score1.Name = "lbl_game1_score1";
            this.lbl_game1_score1.Size = new System.Drawing.Size(166, 29);
            this.lbl_game1_score1.TabIndex = 10;
            this.lbl_game1_score1.Text = "Name: Score";
            this.lbl_game1_score1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_game1_score1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_game1_score2
            // 
            this.lbl_game1_score2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game1_score2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_game1_score2.Image = global::ClydeArcade.Properties.Resources.arcade_background;
            this.lbl_game1_score2.Location = new System.Drawing.Point(57, 327);
            this.lbl_game1_score2.Name = "lbl_game1_score2";
            this.lbl_game1_score2.Size = new System.Drawing.Size(166, 29);
            this.lbl_game1_score2.TabIndex = 11;
            this.lbl_game1_score2.Text = "Name: Score";
            this.lbl_game1_score2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_game1_score3
            // 
            this.lbl_game1_score3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game1_score3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_game1_score3.Image = global::ClydeArcade.Properties.Resources.arcade_background;
            this.lbl_game1_score3.Location = new System.Drawing.Point(57, 356);
            this.lbl_game1_score3.Name = "lbl_game1_score3";
            this.lbl_game1_score3.Size = new System.Drawing.Size(166, 29);
            this.lbl_game1_score3.TabIndex = 12;
            this.lbl_game1_score3.Text = "Name: Score";
            this.lbl_game1_score3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_game2
            // 
            this.lbl_game2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_game2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_game2.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_game2.Image = global::ClydeArcade.Properties.Resources.arcade_button;
            this.lbl_game2.Location = new System.Drawing.Point(279, 196);
            this.lbl_game2.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_game2.Name = "lbl_game2";
            this.lbl_game2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_game2.Size = new System.Drawing.Size(233, 201);
            this.lbl_game2.TabIndex = 13;
            this.lbl_game2.Text = "Snake Escape";
            this.lbl_game2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_game2_score1
            // 
            this.lbl_game2_score1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game2_score1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_game2_score1.Image = global::ClydeArcade.Properties.Resources.arcade_background;
            this.lbl_game2_score1.Location = new System.Drawing.Point(314, 298);
            this.lbl_game2_score1.Name = "lbl_game2_score1";
            this.lbl_game2_score1.Size = new System.Drawing.Size(166, 29);
            this.lbl_game2_score1.TabIndex = 14;
            this.lbl_game2_score1.Text = "Name: Score";
            this.lbl_game2_score1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_game2_score2
            // 
            this.lbl_game2_score2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game2_score2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_game2_score2.Image = global::ClydeArcade.Properties.Resources.arcade_background;
            this.lbl_game2_score2.Location = new System.Drawing.Point(314, 327);
            this.lbl_game2_score2.Name = "lbl_game2_score2";
            this.lbl_game2_score2.Size = new System.Drawing.Size(166, 29);
            this.lbl_game2_score2.TabIndex = 15;
            this.lbl_game2_score2.Text = "Name: Score";
            this.lbl_game2_score2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_game2_score3
            // 
            this.lbl_game2_score3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game2_score3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_game2_score3.Image = global::ClydeArcade.Properties.Resources.arcade_background;
            this.lbl_game2_score3.Location = new System.Drawing.Point(314, 356);
            this.lbl_game2_score3.Name = "lbl_game2_score3";
            this.lbl_game2_score3.Size = new System.Drawing.Size(166, 29);
            this.lbl_game2_score3.TabIndex = 16;
            this.lbl_game2_score3.Text = "Name: Score";
            this.lbl_game2_score3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_game3
            // 
            this.lbl_game3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_game3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_game3.Font = new System.Drawing.Font("MV Boli", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_game3.Image = global::ClydeArcade.Properties.Resources.arcade_button;
            this.lbl_game3.Location = new System.Drawing.Point(542, 196);
            this.lbl_game3.Margin = new System.Windows.Forms.Padding(0);
            this.lbl_game3.Name = "lbl_game3";
            this.lbl_game3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_game3.Size = new System.Drawing.Size(233, 201);
            this.lbl_game3.TabIndex = 17;
            this.lbl_game3.Text = "Memory Match";
            this.lbl_game3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_game3_score1
            // 
            this.lbl_game3_score1.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game3_score1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_game3_score1.Image = global::ClydeArcade.Properties.Resources.arcade_background;
            this.lbl_game3_score1.Location = new System.Drawing.Point(576, 298);
            this.lbl_game3_score1.Name = "lbl_game3_score1";
            this.lbl_game3_score1.Size = new System.Drawing.Size(166, 29);
            this.lbl_game3_score1.TabIndex = 18;
            this.lbl_game3_score1.Text = "Name: Score";
            this.lbl_game3_score1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_game3_score2
            // 
            this.lbl_game3_score2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game3_score2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_game3_score2.Image = global::ClydeArcade.Properties.Resources.arcade_background;
            this.lbl_game3_score2.Location = new System.Drawing.Point(576, 327);
            this.lbl_game3_score2.Name = "lbl_game3_score2";
            this.lbl_game3_score2.Size = new System.Drawing.Size(166, 29);
            this.lbl_game3_score2.TabIndex = 19;
            this.lbl_game3_score2.Text = "Name: Score";
            this.lbl_game3_score2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_game3_score3
            // 
            this.lbl_game3_score3.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_game3_score3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_game3_score3.Image = global::ClydeArcade.Properties.Resources.arcade_background;
            this.lbl_game3_score3.Location = new System.Drawing.Point(576, 356);
            this.lbl_game3_score3.Name = "lbl_game3_score3";
            this.lbl_game3_score3.Size = new System.Drawing.Size(166, 29);
            this.lbl_game3_score3.TabIndex = 20;
            this.lbl_game3_score3.Text = "Name: Score";
            this.lbl_game3_score3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Leaderboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ClydeArcade.Properties.Resources.arcade_background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_game3_score3);
            this.Controls.Add(this.lbl_game3_score2);
            this.Controls.Add(this.lbl_game3_score1);
            this.Controls.Add(this.lbl_game3);
            this.Controls.Add(this.lbl_game2_score3);
            this.Controls.Add(this.lbl_game2_score2);
            this.Controls.Add(this.lbl_game2_score1);
            this.Controls.Add(this.lbl_game2);
            this.Controls.Add(this.lbl_game1_score3);
            this.Controls.Add(this.lbl_game1_score2);
            this.Controls.Add(this.lbl_game1_score1);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.lbl_game1);
            this.Controls.Add(this.lbl_leaderboard);
            this.DoubleBuffered = true;
            this.Name = "Leaderboard";
            this.Text = "Leaderboard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.leaderboard_formClose);
            this.Load += new System.EventHandler(this.Leaderboard_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_leaderboard;
        private System.Windows.Forms.Label lbl_game1;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label lbl_game1_score1;
        private System.Windows.Forms.Label lbl_game1_score2;
        private System.Windows.Forms.Label lbl_game1_score3;
        private System.Windows.Forms.Label lbl_game2;
        private System.Windows.Forms.Label lbl_game2_score1;
        private System.Windows.Forms.Label lbl_game2_score2;
        private System.Windows.Forms.Label lbl_game2_score3;
        private System.Windows.Forms.Label lbl_game3;
        private System.Windows.Forms.Label lbl_game3_score1;
        private System.Windows.Forms.Label lbl_game3_score2;
        private System.Windows.Forms.Label lbl_game3_score3;
    }
}