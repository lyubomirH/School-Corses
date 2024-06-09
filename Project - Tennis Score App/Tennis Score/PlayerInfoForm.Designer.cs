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
            listViewVictories = new ListView();
            colVictoriesCompetitior = new ColumnHeader();
            colVictoriesScore = new ColumnHeader();
            listViewLosses = new ListView();
            colLossesCompetitior = new ColumnHeader();
            colLossesScore = new ColumnHeader();
            listViewDraw = new ListView();
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
            // listViewVictories
            // 
            listViewVictories.Columns.AddRange(new ColumnHeader[] { colVictoriesCompetitior, colVictoriesScore });
            listViewVictories.Location = new Point(74, 198);
            listViewVictories.Name = "listViewVictories";
            listViewVictories.Size = new Size(406, 201);
            listViewVictories.TabIndex = 4;
            listViewVictories.UseCompatibleStateImageBehavior = false;
            listViewVictories.View = View.Details;
            listViewVictories.SelectedIndexChanged += listView1_SelectedIndexChanged;
            // 
            // colVictoriesCompetitior
            // 
            colVictoriesCompetitior.Text = "Competitior";
            // 
            // colVictoriesScore
            // 
            colVictoriesScore.Text = "Score";
            // 
            // listViewLosses
            // 
            listViewLosses.Columns.AddRange(new ColumnHeader[] { colLossesCompetitior, colLossesScore });
            listViewLosses.Location = new Point(505, 198);
            listViewLosses.Name = "listViewLosses";
            listViewLosses.Size = new Size(406, 201);
            listViewLosses.TabIndex = 5;
            listViewLosses.UseCompatibleStateImageBehavior = false;
            listViewLosses.View = View.Details;
            // 
            // colLossesCompetitior
            // 
            colLossesCompetitior.Text = "Competitior";
            // 
            // colLossesScore
            // 
            colLossesScore.Text = "Score";
            // 
            // listViewDraw
            // 
            listViewDraw.Columns.AddRange(new ColumnHeader[] { colDreawCompetitior, colDreawScore });
            listViewDraw.Location = new Point(940, 198);
            listViewDraw.Name = "listViewDraw";
            listViewDraw.Size = new Size(406, 201);
            listViewDraw.TabIndex = 6;
            listViewDraw.UseCompatibleStateImageBehavior = false;
            listViewDraw.View = View.Details;
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
            Controls.Add(listViewDraw);
            Controls.Add(listViewLosses);
            Controls.Add(listViewVictories);
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
        private ListView listViewVictories;
        private ListView listViewLosses;
        private ListView listViewDraw;
        private ColumnHeader colVictoriesCompetitior;
        private ColumnHeader colVictoriesScore;
        private ColumnHeader colLossesCompetitior;
        private ColumnHeader colLossesScore;
        private ColumnHeader colDreawCompetitior;
        private ColumnHeader colDreawScore;
    }
}