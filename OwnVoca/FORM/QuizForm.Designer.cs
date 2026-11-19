namespace OwnVoca.FORM
{
    partial class QuizForm
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
            TitleLabel = new Label();
            MainPanel = new Panel();
            passButton = new Button();
            hintButton = new Button();
            AnswerInputText = new TextBox();
            levelLabel = new Label();
            wordLabel = new Label();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.BackColor = SystemColors.ControlDarkDark;
            TitleLabel.Font = new Font("Times New Roman", 32F, FontStyle.Bold);
            TitleLabel.ForeColor = Color.WhiteSmoke;
            TitleLabel.Location = new Point(0, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(736, 77);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Own Voca Quiz";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = SystemColors.AppWorkspace;
            MainPanel.Controls.Add(passButton);
            MainPanel.Controls.Add(hintButton);
            MainPanel.Controls.Add(AnswerInputText);
            MainPanel.Controls.Add(levelLabel);
            MainPanel.Controls.Add(wordLabel);
            MainPanel.Controls.Add(TitleLabel);
            MainPanel.Location = new Point(12, 12);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(736, 236);
            MainPanel.TabIndex = 2;
            // 
            // passButton
            // 
            passButton.BackColor = SystemColors.Control;
            passButton.Font = new Font("굴림", 8F);
            passButton.Location = new Point(641, 172);
            passButton.Name = "passButton";
            passButton.Size = new Size(75, 45);
            passButton.TabIndex = 5;
            passButton.Text = "패스하기";
            passButton.UseVisualStyleBackColor = false;
            passButton.Click += passButton_Click;
            // 
            // hintButton
            // 
            hintButton.BackColor = SystemColors.Control;
            hintButton.Font = new Font("굴림", 8F);
            hintButton.Location = new Point(29, 172);
            hintButton.Name = "hintButton";
            hintButton.Size = new Size(75, 45);
            hintButton.TabIndex = 4;
            hintButton.Text = "힌트 보기";
            hintButton.UseVisualStyleBackColor = false;
            hintButton.Click += hintButton_Click;
            // 
            // AnswerInputText
            // 
            AnswerInputText.BackColor = Color.WhiteSmoke;
            AnswerInputText.Font = new Font("굴림", 10F);
            AnswerInputText.ForeColor = SystemColors.Desktop;
            AnswerInputText.Location = new Point(143, 172);
            AnswerInputText.Multiline = true;
            AnswerInputText.Name = "AnswerInputText";
            AnswerInputText.PlaceholderText = "정답을 입력하세요";
            AnswerInputText.Size = new Size(467, 45);
            AnswerInputText.TabIndex = 3;
            AnswerInputText.TextAlign = HorizontalAlignment.Center;
            AnswerInputText.KeyDown += AnswerInputText_KeyDown;
            // 
            // levelLabel
            // 
            levelLabel.BackColor = Color.Ivory;
            levelLabel.Font = new Font("Times New Roman", 21F);
            levelLabel.Location = new Point(434, 92);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new Size(282, 60);
            levelLabel.TabIndex = 2;
            levelLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // wordLabel
            // 
            wordLabel.BackColor = SystemColors.HighlightText;
            wordLabel.Font = new Font("Times New Roman", 21F);
            wordLabel.Location = new Point(29, 92);
            wordLabel.Name = "wordLabel";
            wordLabel.Size = new Size(387, 60);
            wordLabel.TabIndex = 1;
            wordLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // QuizForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.HighlightText;
            ClientSize = new Size(758, 258);
            ControlBox = false;
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "QuizForm";
            ShowIcon = false;
            TopMost = true;
            FormClosing += QuizForm_FormClosing;
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label TitleLabel;
        private Panel MainPanel;
        private Label wordLabel;
        private Label levelLabel;
        private TextBox AnswerInputText;
        private Button passButton;
        private Button hintButton;
    }
}