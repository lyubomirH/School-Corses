namespace Tennis_Score
{
    partial class PlayerInfoForm
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
            LABPlayerName = new Label();
            LABLosses = new Label();
            LABVictories = new Label();
            LABDraw = new Label();
            listView1 = new ListView();
            listView2 = new ListView();
            listView3 = new ListView();
            colVictoriesCompetitior = new ColumnHeader();
            colVictoriesScore = new ColumnHeader();
            colLossesCompetitior = new ColumnHeader();
            colLossesScore = new ColumnHeader();
            colDreawCompetitior = new ColumnHeader();
            colDreawScore = new ColumnHeader();
            SuspendLayout();
            // 
            // LABPlayerName
            // 
            LABPlayerName.AutoSize = true;
            LABPlayerName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LABPlayerName.Location = new Point(607, 49);
            LABPlayerName.Name = "LABPlayerName";
            LABPlayerName.Size = new Size(231, 46);
            LABPlayerName.TabIndex = 0;
            LABPlayerName.Text = "Player Name ";
            // 
            // LABLosses
            // 
            LABLosses.AutoSize = true;
            LABLosses.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LABLosses.Location = new Point(688, 156);
            LABLosses.Name = "LABLosses";
            LABLosses.Size = new Size(67, 28);
            LABLosses.TabIndex = 1;
            LABLosses.Text = "Losses";
            // 
            // LABVictories
            // 
            LABVictories.AutoSize = true;
            LABVictories.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LABVictories.Location = new Point(226, 167);
            LABVictories.Name = "LABVictories";
            LABVictories.Size = new Size(87, 28);
            LABVictories.TabIndex = 2;
            LABVictories.Text = "Victories";
            LABVictories.Click += label1_Click;
            // 
            // LABDraw
            // 
            LABDraw.AutoSize = true;
            LABDraw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LABDraw.Location = new Point(1139, 156);
            LABDraw.Name = "LABDraw";
            LABDraw.Size = new Size(57, 28);
            LABDraw.TabIndex = 3;
            LABDraw.Text = "Draw";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { colVictoriesCompetitior, colVictoriesScore });
            listView1.Location = new Point(74, 198);
            listView1.Name = "listView1";
            listView1.Size = new Size(406, 201);
            listView1.TabIndex = 4;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { colLossesCompetitior, colLossesScore });
            listView2.Location = new Point(505, 198);
            listView2.Name = "listView2";
            listView2.Size = new Size(406, 201);
            listView2.TabIndex = 5;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { colDreawCompetitior, colDreawScore });
            listView3.Location = new Point(940, 198);
            listView3.Name = "listView3";
            listView3.Size = new Size(406, 201);
            listView3.TabIndex = 6;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // colVictoriesCompetitior
            // 
            colVictoriesCompetitior.Text = "Competitior";
            // 
            // colVictoriesScore
            // 
            colVictoriesScore.Text = "Score";
            // 
            // colLossesCompetitior
            // 
            colLossesCompetitior.Text = "Competitior";
            // 
            // colLossesScore
            // 
            colLossesScore.Text = "Score";
            // 
            // colDreawCompetitior
            // 
            colDreawCompetitior.Text = "Competitior";
            // 
            // colDreawScore
            // 
            colDreawScore.Text = "Score";
            // 
            // PlayerInfoForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1413, 557);
            Controls.Add(listView3);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(LABDraw);
            Controls.Add(LABVictories);
            Controls.Add(LABLosses);
            Controls.Add(LABPlayerName);
            Name = "PlayerInfoForm";
            Text = "PlayerInfoForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LABPlayerName;
        private Label LABLosses;
        private Label LABVictories;
        private Label LABDraw;
        private ListView listView1;
        private ListView listView2;
        private ListView listView3;
        private ColumnHeader colVictoriesCompetitior;
        private ColumnHeader colVictoriesScore;
        private ColumnHeader colLossesCompetitior;
        private ColumnHeader colLossesScore;
        private ColumnHeader colDreawCompetitior;
        private ColumnHeader colDreawScore;
    }
}