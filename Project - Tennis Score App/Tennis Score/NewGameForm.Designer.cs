namespace Tennis_Score
{
    partial class NewGameForm
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
            LABFirstPlayer = new Label();
            LABSecondPlayer = new Label();
            LABNewGame = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            LABPointsFP = new Label();
            LABPointsSP = new Label();
            NUDPointsFP = new NumericUpDown();
            NUDPointsSP = new NumericUpDown();
            LABVS = new Label();
            BUTSave = new Button();
            ((System.ComponentModel.ISupportInitialize)NUDPointsFP).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NUDPointsSP).BeginInit();
            SuspendLayout();
            // 
            // LABFirstPlayer
            // 
            LABFirstPlayer.AutoSize = true;
            LABFirstPlayer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LABFirstPlayer.Location = new Point(228, 90);
            LABFirstPlayer.Name = "LABFirstPlayer";
            LABFirstPlayer.Size = new Size(107, 28);
            LABFirstPlayer.TabIndex = 0;
            LABFirstPlayer.Text = "First Player";
            LABFirstPlayer.Click += LABFirstPlayer_Click;
            // 
            // LABSecondPlayer
            // 
            LABSecondPlayer.AutoSize = true;
            LABSecondPlayer.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LABSecondPlayer.Location = new Point(1044, 98);
            LABSecondPlayer.Name = "LABSecondPlayer";
            LABSecondPlayer.Size = new Size(135, 28);
            LABSecondPlayer.TabIndex = 1;
            LABSecondPlayer.Text = "Second Player";
            // 
            // LABNewGame
            // 
            LABNewGame.AutoSize = true;
            LABNewGame.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            LABNewGame.Location = new Point(654, 35);
            LABNewGame.Name = "LABNewGame";
            LABNewGame.Size = new Size(160, 38);
            LABNewGame.TabIndex = 2;
            LABNewGame.Text = "New Game";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(210, 148);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(1054, 148);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 1;
            // 
            // LABPointsFP
            // 
            LABPointsFP.AutoSize = true;
            LABPointsFP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LABPointsFP.Location = new Point(228, 250);
            LABPointsFP.Name = "LABPointsFP";
            LABPointsFP.Size = new Size(65, 28);
            LABPointsFP.TabIndex = 6;
            LABPointsFP.Text = "Points";
            // 
            // LABPointsSP
            // 
            LABPointsSP.AutoSize = true;
            LABPointsSP.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LABPointsSP.Location = new Point(1044, 250);
            LABPointsSP.Name = "LABPointsSP";
            LABPointsSP.Size = new Size(65, 28);
            LABPointsSP.TabIndex = 7;
            LABPointsSP.Text = "Points";
            // 
            // NUDPointsFP
            // 
            NUDPointsFP.Location = new Point(228, 308);
            NUDPointsFP.Name = "NUDPointsFP";
            NUDPointsFP.Size = new Size(39, 27);
            NUDPointsFP.TabIndex = 9;
            // 
            // NUDPointsSP
            // 
            NUDPointsSP.Location = new Point(1054, 308);
            NUDPointsSP.Name = "NUDPointsSP";
            NUDPointsSP.Size = new Size(39, 27);
            NUDPointsSP.TabIndex = 10;
            // 
            // LABVS
            // 
            LABVS.AutoSize = true;
            LABVS.Font = new Font("Segoe Script", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LABVS.Location = new Point(689, 228);
            LABVS.Name = "LABVS";
            LABVS.Size = new Size(63, 50);
            LABVS.TabIndex = 11;
            LABVS.Text = "VS";
            LABVS.Click += LABVS_Click;
            // 
            // BUTSave
            // 
            BUTSave.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BUTSave.Location = new Point(645, 359);
            BUTSave.Name = "BUTSave";
            BUTSave.Size = new Size(169, 45);
            BUTSave.TabIndex = 12;
            BUTSave.Text = "Save";
            BUTSave.UseVisualStyleBackColor = true;
            // 
            // NewGameForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1413, 557);
            Controls.Add(BUTSave);
            Controls.Add(LABVS);
            Controls.Add(NUDPointsSP);
            Controls.Add(NUDPointsFP);
            Controls.Add(LABPointsSP);
            Controls.Add(LABPointsFP);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LABNewGame);
            Controls.Add(LABSecondPlayer);
            Controls.Add(LABFirstPlayer);
            Name = "NewGameForm";
            Text = "NewGameForm";
            Load += NewGameForm_Load;
            ((System.ComponentModel.ISupportInitialize)NUDPointsFP).EndInit();
            ((System.ComponentModel.ISupportInitialize)NUDPointsSP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LABFirstPlayer;
        private Label LABSecondPlayer;
        private Label LABNewGame;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label LABPointsFP;
        private Label LABPointsSP;
        private NumericUpDown NUDPointsFP;
        private NumericUpDown NUDPointsSP;
        private Label LABVS;
        private Button BUTSave;
    }
}