using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;

namespace OwnVoca.FORM
{
    public partial class NoticeForm : Form
    {
        private bool _allowClose = false;
        private uint _remainingSeconds;
        public NoticeForm(uint okDelaySecond, string title, string content)
        {
            InitializeComponent();

            _remainingSeconds = okDelaySecond;
            okTimer.Start();

            RefreshUI();
            TitleLabel.Text = title;
            contentLabel.Text = content;
        }
        public void ForceClose()
        {
            _allowClose = true;
            this.Close();
        }
        private void OKButton_Click(object sender, EventArgs e)
        {
            if (_remainingSeconds == 0) ForceClose();
        }

        private void NoticeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !_allowClose;
        }
        private void RefreshUI()
        {
            if (_remainingSeconds > 0)
            {
                OKButton.Text = $"{_remainingSeconds}초 뒤 확인 가능";
                OKButton.BackColor = Color.Gainsboro;
            }
            else
            {
                okTimer.Stop();
                OKButton.Text = "확인";
                OKButton.BackColor = Color.DarkSeaGreen;
            }
        }
        private void okTimer_Tick(object sender, EventArgs e)
        {
            if (_remainingSeconds > 1)
            {
                _remainingSeconds--;
            }
            else
            { 
                _remainingSeconds = 0;
            }
            RefreshUI();
        }
    }
}
