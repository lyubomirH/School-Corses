namespace Tennis_Score_App
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LVRanking = new ListView();
            LabRanking = new Label();
            LabLastGame = new Label();
            LVLatestGames = new ListView();
            LVLName = new ColumnHeader();
            LVLScore = new ColumnHeader();
            LABRank = new Label();
            LabTennis = new Label();
            BUTNewGame = new Button();
            LABNolt = new Label();
            COLLGNameOne = new ColumnHeader();
            COLLGNameTwo = new ColumnHeader();
            COLLGWin = new ColumnHeader();
            COLLGScore = new ColumnHeader();
            SuspendLayout();
            // 
            // LVRanking
            // 
            LVRanking.Anchor = AnchorStyles.Top;
            LVRanking.Columns.AddRange(new ColumnHeader[] { LVLName, LVLScore });
            LVRanking.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LVRanking.Location = new Point(32, 194);
            LVRanking.Margin = new Padding(8, 7, 8, 7);
            LVRanking.Name = "LVRanking";
            LVRanking.Size = new Size(1183, 138);
            LVRanking.TabIndex = 0;
            LVRanking.UseCompatibleStateImageBehavior = false;
            LVRanking.View = View.Details;
            // 
            // LabRanking
            // 
            LabRanking.Anchor = AnchorStyles.Top;
            LabRanking.AutoSize = true;
            LabRanking.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LabRanking.Location = new Point(-201, 128);
            LabRanking.Margin = new Padding(8, 0, 8, 0);
            LabRanking.Name = "LabRanking";
            LabRanking.Size = new Size(152, 46);
            LabRanking.TabIndex = 1;
            LabRanking.Text = "Ranking";
            // 
            // LabLastGame
            // 
            LabLastGame.AutoSize = true;
            LabLastGame.Location = new Point(32, 377);
            LabLastGame.Name = "LabLastGame";
            LabLastGame.Size = new Size(229, 46);
            LabLastGame.TabIndex = 2;
            LabLastGame.Text = "Latest Games";
            // 
            // LVLatestGames
            // 
            LVLatestGames.Columns.AddRange(new ColumnHeader[] { COLLGNameOne, COLLGNameTwo, COLLGWin, COLLGScore });
            LVLatestGames.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LVLatestGames.Location = new Point(32, 430);
            LVLatestGames.Margin = new Padding(8, 7, 8, 7);
            LVLatestGames.Name = "LVLatestGames";
            LVLatestGames.Size = new Size(1183, 167);
            LVLatestGames.TabIndex = 3;
            LVLatestGames.UseCompatibleStateImageBehavior = false;
            LVLatestGames.View = View.Details;
            // 
            // LVLName
            // 
            LVLName.Text = "Name";
            // 
            // LVLScore
            // 
            LVLScore.Text = "Score";
            // 
            // LABRank
            // 
            LABRank.AutoSize = true;
            LABRank.Location = new Point(32, 126);
            LABRank.Name = "LABRank";
            LABRank.Size = new Size(152, 46);
            LABRank.TabIndex = 4;
            LABRank.Text = "Ranking";
            // 
            // LabTennis
            // 
            LabTennis.AutoSize = true;
            LabTennis.Location = new Point(614, 34);
            LabTennis.Name = "LabTennis";
            LabTennis.Size = new Size(219, 46);
            LabTennis.TabIndex = 5;
            LabTennis.Text = "Tennis Score";
            // 
            // BUTNewGame
            // 
            BUTNewGame.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BUTNewGame.Location = new Point(1051, 371);
            BUTNewGame.Name = "BUTNewGame";
            BUTNewGame.Size = new Size(164, 49);
            BUTNewGame.TabIndex = 6;
            BUTNewGame.Text = "Add New Game";
            BUTNewGame.UseVisualStyleBackColor = true;
            // 
            // LABNolt
            // 
            LABNolt.AutoSize = true;
            LABNolt.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LABNolt.Location = new Point(36, 336);
            LABNolt.Name = "LABNolt";
            LABNolt.Size = new Size(556, 23);
            LABNolt.TabIndex = 7;
            LABNolt.Text = "* click on a player's name to see more information about their matches.";
            // 
            // COLLGNameOne
            // 
            COLLGNameOne.Text = "First Player";
            // 
            // COLLGNameTwo
            // 
            COLLGNameTwo.Text = "Second Player";
            // 
            // COLLGWin
            // 
            COLLGWin.Text = "Winner";
            // 
            // COLLGScore
            // 
            COLLGScore.Text = "Score";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(20F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 639);
            Controls.Add(LABNolt);
            Controls.Add(BUTNewGame);
            Controls.Add(LabTennis);
            Controls.Add(LABRank);
            Controls.Add(LVLatestGames);
            Controls.Add(LabLastGame);
            Controls.Add(LabRanking);
            Controls.Add(LVRanking);
            Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(8, 7, 8, 7);
            Name = "Main";
            Text = "Tennis App";
            Load += Main_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView LVRanking;
        private Label LabRanking;
        private Label LabLastGame;
        private ListView LVLatestGames;
        private ColumnHeader LVLName;
        private ColumnHeader LVLScore;
        private Label LABRank;
        private Label LabTennis;
        private Button BUTNewGame;
        private Label LABNolt;
        private ColumnHeader COLLGNameOne;
        private ColumnHeader COLLGNameTwo;
        private ColumnHeader COLLGWin;
        private ColumnHeader COLLGScore;
    }
}