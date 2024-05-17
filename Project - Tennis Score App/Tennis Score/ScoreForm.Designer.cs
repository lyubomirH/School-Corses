namespace Tennis_Score
{
    partial class FormScoreForm
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
            LABName = new Label();
            LAB = new Label();
            LABLastGame = new Label();
            listViewRanking = new ListView();
            colRankPlayerName = new ColumnHeader();
            colRankScore = new ColumnHeader();
            BUTTAddNewGame = new Button();
            listViewLastGame = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            columnHeader4 = new ColumnHeader();
            label1 = new Label();
            SuspendLayout();
            // 
            // LABName
            // 
            LABName.Anchor = AnchorStyles.Top;
            LABName.AutoSize = true;
            LABName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point);
            LABName.Location = new Point(654, 44);
            LABName.Name = "LABName";
            LABName.Size = new Size(206, 46);
            LABName.TabIndex = 0;
            LABName.Text = "Tennis Score";
            // 
            // LAB
            // 
            LAB.AutoSize = true;
            LAB.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            LAB.Location = new Point(116, 93);
            LAB.Name = "LAB";
            LAB.Size = new Size(117, 38);
            LAB.TabIndex = 1;
            LAB.Text = "Ranking";
            // 
            // LABLastGame
            // 
            LABLastGame.AutoSize = true;
            LABLastGame.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            LABLastGame.Location = new Point(116, 314);
            LABLastGame.Name = "LABLastGame";
            LABLastGame.Size = new Size(137, 38);
            LABLastGame.TabIndex = 2;
            LABLastGame.Text = "LastGame";
            LABLastGame.Click += label2_Click;
            // 
            // listViewRanking
            // 
            listViewRanking.Columns.AddRange(new ColumnHeader[] { colRankPlayerName, colRankScore });
            listViewRanking.Location = new Point(116, 134);
            listViewRanking.Name = "listViewRanking";
            listViewRanking.Size = new Size(1235, 123);
            listViewRanking.TabIndex = 3;
            listViewRanking.UseCompatibleStateImageBehavior = false;
            listViewRanking.View = View.Details;
            // 
            // colRankPlayerName
            // 
            colRankPlayerName.Text = "PlayerName";
            // 
            // colRankScore
            // 
            colRankScore.Text = "Score";
            // 
            // BUTTAddNewGame
            // 
            BUTTAddNewGame.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            BUTTAddNewGame.Location = new Point(1191, 324);
            BUTTAddNewGame.Name = "BUTTAddNewGame";
            BUTTAddNewGame.Size = new Size(160, 37);
            BUTTAddNewGame.TabIndex = 4;
            BUTTAddNewGame.Text = "Add New Game";
            BUTTAddNewGame.UseVisualStyleBackColor = true;
            BUTTAddNewGame.Click += button1_Click;
            // 
            // listViewLastGame
            // 
            listViewLastGame.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3, columnHeader4 });
            listViewLastGame.Location = new Point(116, 367);
            listViewLastGame.Name = "listViewLastGame";
            listViewLastGame.Size = new Size(1235, 123);
            listViewLastGame.TabIndex = 5;
            listViewLastGame.UseCompatibleStateImageBehavior = false;
            listViewLastGame.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "First Player";
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Second Player";
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Winner";
            // 
            // columnHeader4
            // 
            columnHeader4.Text = "Score";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(116, 260);
            label1.Name = "label1";
            label1.Size = new Size(476, 20);
            label1.TabIndex = 6;
            label1.Text = "*click on a player's name to see more infoemation about their matches";
            // 
            // FormScoreForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1413, 557);
            Controls.Add(label1);
            Controls.Add(listViewLastGame);
            Controls.Add(BUTTAddNewGame);
            Controls.Add(listViewRanking);
            Controls.Add(LABLastGame);
            Controls.Add(LAB);
            Controls.Add(LABName);
            MaximumSize = new Size(1431, 604);
            MinimumSize = new Size(1431, 604);
            Name = "FormScoreForm";
            Text = "Score Form";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LABName;
        private Label LAB;
        private Label LABLastGame;
        private ListView listViewRanking;
        private ColumnHeader colRankPlayerName;
        private ColumnHeader colRankScore;
        private Button BUTTAddNewGame;
        private ListView listViewLastGame;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private ColumnHeader columnHeader4;
        private Label label1;
    }
}
