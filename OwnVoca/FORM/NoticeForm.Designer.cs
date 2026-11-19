namespace OwnVoca.FORM
{
    partial class NoticeForm
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
            components = new System.ComponentModel.Container();
            TitleLabel = new Label();
            mainPanel = new Panel();
            OKButton = new Button();
            contentLabel = new Label();
            okTimer = new System.Windows.Forms.Timer(components);
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.BackColor = SystemColors.Window;
            TitleLabel.Font = new Font("굴림", 12F, FontStyle.Bold, GraphicsUnit.Point, 129);
            TitleLabel.ForeColor = SystemColors.WindowText;
            TitleLabel.Location = new Point(0, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(366, 52);
            TitleLabel.TabIndex = 0;
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // mainPanel
            // 
            mainPanel.BackColor = Color.Gray;
            mainPanel.Controls.Add(OKButton);
            mainPanel.Controls.Add(contentLabel);
            mainPanel.Controls.Add(TitleLabel);
            mainPanel.Location = new Point(12, 12);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(346, 396);
            mainPanel.TabIndex = 1;
            // 
            // OKButton
            // 
            OKButton.BackColor = Color.Transparent;
            OKButton.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            OKButton.ForeColor = SystemColors.ControlText;
            OKButton.Location = new Point(0, 357);
            OKButton.Name = "OKButton";
            OKButton.Size = new Size(346, 39);
            OKButton.TabIndex = 2;
            OKButton.UseVisualStyleBackColor = false;
            OKButton.Click += OKButton_Click;
            // 
            // contentLabel
            // 
            contentLabel.BackColor = Color.Gray;
            contentLabel.Font = new Font("굴림", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 129);
            contentLabel.ForeColor = SystemColors.Window;
            contentLabel.Location = new Point(3, 64);
            contentLabel.Name = "contentLabel";
            contentLabel.Size = new Size(343, 290);
            contentLabel.TabIndex = 1;
            contentLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // okTimer
            // 
            okTimer.Enabled = true;
            okTimer.Interval = 1000;
            okTimer.Tick += okTimer_Tick;
            // 
            // NoticeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(367, 421);
            ControlBox = false;
            Controls.Add(mainPanel);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "NoticeForm";
            ShowIcon = false;
            TopMost = true;
            FormClosing += NoticeForm_FormClosing;
            mainPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label TitleLabel;
        private Panel mainPanel;
        private Button OKButton;
        private Label contentLabel;
        private System.Windows.Forms.Timer okTimer;
    }
}