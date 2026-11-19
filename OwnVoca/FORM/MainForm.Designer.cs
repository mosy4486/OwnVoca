namespace OwnVoca.FORM
{
    partial class MainForm
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
            mainPanel = new Panel();
            panel2 = new Panel();
            levelComboBox = new ComboBox();
            designLabel2 = new Label();
            panel1 = new Panel();
            designLabel = new Label();
            spawnIntervalText = new TextBox();
            controlButton = new Button();
            mainPanel.SuspendLayout();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // mainPanel
            // 
            mainPanel.BackColor = SystemColors.Control;
            mainPanel.Controls.Add(panel2);
            mainPanel.Controls.Add(panel1);
            mainPanel.Controls.Add(controlButton);
            mainPanel.Location = new Point(12, 6);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(631, 159);
            mainPanel.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ScrollBar;
            panel2.Controls.Add(levelComboBox);
            panel2.Controls.Add(designLabel2);
            panel2.Location = new Point(346, 59);
            panel2.Name = "panel2";
            panel2.Size = new Size(273, 85);
            panel2.TabIndex = 3;
            // 
            // levelComboBox
            // 
            levelComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            levelComboBox.Font = new Font("굴림", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            levelComboBox.FormattingEnabled = true;
            levelComboBox.Items.AddRange(new object[] { "1", "2" });
            levelComboBox.Location = new Point(84, 45);
            levelComboBox.Name = "levelComboBox";
            levelComboBox.Size = new Size(121, 20);
            levelComboBox.TabIndex = 4;
            levelComboBox.SelectedIndexChanged += levelComboBox_SelectedIndexChanged;
            // 
            // designLabel2
            // 
            designLabel2.AutoSize = true;
            designLabel2.BackColor = SystemColors.ScrollBar;
            designLabel2.Font = new Font("굴림", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            designLabel2.Location = new Point(100, 17);
            designLabel2.Name = "designLabel2";
            designLabel2.Size = new Size(76, 16);
            designLabel2.TabIndex = 3;
            designLabel2.Text = "문제 레벨";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ScrollBar;
            panel1.Controls.Add(designLabel);
            panel1.Controls.Add(spawnIntervalText);
            panel1.Location = new Point(17, 59);
            panel1.Name = "panel1";
            panel1.Size = new Size(308, 85);
            panel1.TabIndex = 2;
            // 
            // designLabel
            // 
            designLabel.AutoSize = true;
            designLabel.BackColor = SystemColors.ScrollBar;
            designLabel.Font = new Font("굴림", 12F, FontStyle.Regular, GraphicsUnit.Point, 129);
            designLabel.Location = new Point(80, 17);
            designLabel.Name = "designLabel";
            designLabel.Size = new Size(146, 16);
            designLabel.TabIndex = 2;
            designLabel.Text = "문제 소환 간격 (초)";
            // 
            // spawnIntervalText
            // 
            spawnIntervalText.Font = new Font("굴림", 9F, FontStyle.Regular, GraphicsUnit.Point, 129);
            spawnIntervalText.Location = new Point(80, 44);
            spawnIntervalText.Name = "spawnIntervalText";
            spawnIntervalText.Size = new Size(146, 21);
            spawnIntervalText.TabIndex = 1;
            spawnIntervalText.TextAlign = HorizontalAlignment.Center;
            spawnIntervalText.KeyDown += spawnIntervalText_KeyDown;
            // 
            // controlButton
            // 
            controlButton.BackColor = SystemColors.Control;
            controlButton.Font = new Font("굴림", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            controlButton.Location = new Point(17, 6);
            controlButton.Name = "controlButton";
            controlButton.Size = new Size(602, 47);
            controlButton.TabIndex = 0;
            controlButton.UseVisualStyleBackColor = false;
            controlButton.Click += controlButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(657, 176);
            ControlBox = false;
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "MainForm";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += MainForm_FormClosing;
            mainPanel.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel mainPanel;
        private Button controlButton;
        private Panel panel1;
        private TextBox spawnIntervalText;
        private Panel panel2;
        private Label designLabel;
        private Label designLabel2;
        private ComboBox levelComboBox;
    }
}