namespace Tennis_Score_App
{
    partial class New_Game
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
            LEBNewGameName = new Label();
            LABpOne = new Label();
            LABpTwo = new Label();
            LABPintPOne = new Label();
            LABPintsPTwo = new Label();
            UpNumOne = new NumericUpDown();
            UpNumTwo = new NumericUpDown();
            LABVS = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            BUTSaveButon = new Button();
            ((System.ComponentModel.ISupportInitialize)UpNumOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UpNumTwo).BeginInit();
            SuspendLayout();
            // 
            // LEBNewGameName
            // 
            LEBNewGameName.Anchor = AnchorStyles.Top;
            LEBNewGameName.AutoSize = true;
            LEBNewGameName.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            LEBNewGameName.Location = new Point(606, 9);
            LEBNewGameName.Name = "LEBNewGameName";
            LEBNewGameName.Size = new Size(192, 46);
            LEBNewGameName.TabIndex = 0;
            LEBNewGameName.Text = "New Game";
            // 
            // LABpOne
            // 
            LABpOne.AutoSize = true;
            LABpOne.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LABpOne.Location = new Point(175, 73);
            LABpOne.Name = "LABpOne";
            LABpOne.Size = new Size(125, 31);
            LABpOne.TabIndex = 1;
            LABpOne.Text = "First Player";
            LABpOne.Click += LABpOne_Click;
            // 
            // LABpTwo
            // 
            LABpTwo.AutoSize = true;
            LABpTwo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LABpTwo.Location = new Point(878, 73);
            LABpTwo.Name = "LABpTwo";
            LABpTwo.Size = new Size(157, 31);
            LABpTwo.TabIndex = 2;
            LABpTwo.Text = "Second Player";
            LABpTwo.Click += LABpTwo_Click;
            // 
            // LABPintPOne
            // 
            LABPintPOne.AutoSize = true;
            LABPintPOne.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LABPintPOne.Location = new Point(224, 295);
            LABPintPOne.Name = "LABPintPOne";
            LABPintPOne.Size = new Size(76, 31);
            LABPintPOne.TabIndex = 3;
            LABPintPOne.Text = "Points";
            // 
            // LABPintsPTwo
            // 
            LABPintsPTwo.AutoSize = true;
            LABPintsPTwo.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            LABPintsPTwo.Location = new Point(959, 295);
            LABPintsPTwo.Name = "LABPintsPTwo";
            LABPintsPTwo.Size = new Size(76, 31);
            LABPintsPTwo.TabIndex = 4;
            LABPintsPTwo.Text = "Points";
            LABPintsPTwo.Click += LABPintsPTwo_Click;
            // 
            // UpNumOne
            // 
            UpNumOne.Location = new Point(224, 348);
            UpNumOne.Name = "UpNumOne";
            UpNumOne.Size = new Size(76, 27);
            UpNumOne.TabIndex = 1;
            // 
            // UpNumTwo
            // 
            UpNumTwo.Location = new Point(959, 348);
            UpNumTwo.Name = "UpNumTwo";
            UpNumTwo.Size = new Size(76, 27);
            UpNumTwo.TabIndex = 1;
            // 
            // LABVS
            // 
            LABVS.AutoSize = true;
            LABVS.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            LABVS.Location = new Point(659, 295);
            LABVS.Name = "LABVS";
            LABVS.Size = new Size(57, 39);
            LABVS.TabIndex = 5;
            LABVS.Text = "VS";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 117);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(343, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(878, 117);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(343, 27);
            textBox2.TabIndex = 7;
            // 
            // BUTSaveButon
            // 
            BUTSaveButon.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            BUTSaveButon.Location = new Point(606, 422);
            BUTSaveButon.Name = "BUTSaveButon";
            BUTSaveButon.Size = new Size(153, 49);
            BUTSaveButon.TabIndex = 8;
            BUTSaveButon.Text = "Save";
            BUTSaveButon.UseVisualStyleBackColor = true;
            // 
            // New_Game
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1335, 606);
            Controls.Add(BUTSaveButon);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(LABVS);
            Controls.Add(UpNumTwo);
            Controls.Add(UpNumOne);
            Controls.Add(LABPintsPTwo);
            Controls.Add(LABPintPOne);
            Controls.Add(LABpTwo);
            Controls.Add(LABpOne);
            Controls.Add(LEBNewGameName);
            Name = "New_Game";
            Text = "New_Game";
            ((System.ComponentModel.ISupportInitialize)UpNumOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)UpNumTwo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LEBNewGameName;
        private Label LABpOne;
        private Label LABpTwo;
        private Label LABPintPOne;
        private Label LABPintsPTwo;
        private NumericUpDown UpNumOne;
        private NumericUpDown UpNumTwo;
        private Label LABVS;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button BUTSaveButon;
    }
}