namespace Tennis_Score_App
{
    partial class PlayerInfoFormControls
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
            PlayerName = new Label();
            LABWins = new Label();
            LABLosses = new Label();
            LABDraw = new Label();
            listView1 = new ListView();
            listView2 = new ListView();
            listView3 = new ListView();
            COLNameW = new ColumnHeader();
            COLScoreW = new ColumnHeader();
            COLNameL = new ColumnHeader();
            COLScoreL = new ColumnHeader();
            COLNameD = new ColumnHeader();
            COLScoreD = new ColumnHeader();
            SuspendLayout();
            // 
            // PlayerName
            // 
            PlayerName.AutoSize = true;
            PlayerName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            PlayerName.Location = new Point(585, 58);
            PlayerName.Name = "PlayerName";
            PlayerName.Size = new Size(222, 46);
            PlayerName.TabIndex = 1;
            PlayerName.Text = "Player Name";
            // 
            // LABWins
            // 
            LABWins.AutoSize = true;
            LABWins.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LABWins.Location = new Point(134, 157);
            LABWins.Name = "LABWins";
            LABWins.Size = new Size(75, 28);
            LABWins.TabIndex = 2;
            LABWins.Text = "Victries";
            // 
            // LABLosses
            // 
            LABLosses.AutoSize = true;
            LABLosses.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            LABLosses.Location = new Point(656, 157);
            LABLosses.Name = "LABLosses";
            LABLosses.Size = new Size(72, 28);
            LABLosses.TabIndex = 3;
            LABLosses.Text = "Losses";
            // 
            // LABDraw
            // 
            LABDraw.AutoSize = true;
            LABDraw.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LABDraw.Location = new Point(1149, 157);
            LABDraw.Name = "LABDraw";
            LABDraw.Size = new Size(57, 28);
            LABDraw.TabIndex = 4;
            LABDraw.Text = "Draw";
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { COLNameW, COLScoreW });
            listView1.Location = new Point(51, 226);
            listView1.Name = "listView1";
            listView1.Size = new Size(248, 257);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new ColumnHeader[] { COLNameL, COLScoreL });
            listView2.Location = new Point(570, 226);
            listView2.Name = "listView2";
            listView2.Size = new Size(248, 257);
            listView2.TabIndex = 6;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new ColumnHeader[] { COLNameD, COLScoreD });
            listView3.Location = new Point(1057, 226);
            listView3.Name = "listView3";
            listView3.Size = new Size(248, 257);
            listView3.TabIndex = 7;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = View.Details;
            // 
            // COLNameW
            // 
            COLNameW.Text = "Competitor";
            // 
            // COLScoreW
            // 
            COLScoreW.Text = "Score";
            // 
            // COLNameL
            // 
            COLNameL.Text = "Competitor";
            // 
            // COLScoreL
            // 
            COLScoreL.Text = "Score";
            // 
            // COLNameD
            // 
            COLNameD.Text = "Competitor";
            // 
            // COLScoreD
            // 
            COLScoreD.Text = "Score";
            // 
            // PlayerInfoFormControls
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1334, 611);
            Controls.Add(listView3);
            Controls.Add(listView2);
            Controls.Add(listView1);
            Controls.Add(LABDraw);
            Controls.Add(LABLosses);
            Controls.Add(LABWins);
            Controls.Add(PlayerName);
            Name = "PlayerInfoFormControls";
            Text = "PlayerInfoFormControls";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label PlayerName;
        private Label LABWins;
        private Label LABLosses;
        private Label LABDraw;
        private ListView listView1;
        private ColumnHeader COLNameW;
        private ColumnHeader COLScoreW;
        private ListView listView2;
        private ColumnHeader COLNameL;
        private ColumnHeader COLScoreL;
        private ListView listView3;
        private ColumnHeader COLNameD;
        private ColumnHeader COLScoreD;
    }
}