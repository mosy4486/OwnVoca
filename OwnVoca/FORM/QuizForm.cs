using OwnVoca.CS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace OwnVoca.FORM
{
    public partial class QuizForm : Form
    {
        private readonly WordData _data;
        private bool _allowClose = false;
        private OverlayForm? _overlayForm;
        public QuizForm(WordData data)
        {
            InitializeComponent();
            _data = data;
            InitUI();
        }
        private void InitUI()
        {
            if (_overlayForm == null)
            {
                _overlayForm = new OverlayForm();
                _overlayForm.StartPosition = FormStartPosition.CenterScreen;
                _overlayForm.TopMost = true;
                _overlayForm.BringToFront();
                _overlayForm.Show();
                this.Owner = _overlayForm;
            }
            wordLabel.Text = $"단어 : {_data._word}";
            levelLabel.Text = $"레벨 : {_data._level}";

            levelLabel.BackColor = _data._level == 1 ? Color.Ivory : Color.LightCoral;
        }

        private void AnswerInputText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string input = AnswerInputText.Text.Trim().Replace(" ", ""); //Set Comparable New Parameter

                NoticeForm nForm;

                if (_data.IsAnswer(input))
                {
                    nForm = new NoticeForm(0, "정답입니다.",
                        $"단어 : {_data._word}\n\n뜻 : {string.Concat(_data.meaning!.Select(m => "\n" + m))}");
                    nForm.FormClosing += (object? s, FormClosingEventArgs e) => ForceClose();
                }
                else if (_data.IsSimilar(input))
                {
                    nForm = new NoticeForm(0, "유사했습니다.",
                        $"입력한 ' {AnswerInputText.Text.Trim()} '은 정답과 비슷했습니다.");
                }
                else
                {
                    nForm = new NoticeForm(0, "틀렸습니다.",
                        $"입력한 ' {AnswerInputText.Text.Trim()} '은 정답이 아닙니다.");
                }

                nForm.StartPosition = FormStartPosition.CenterScreen;
                nForm.ShowDialog();

                AnswerInputText.Clear();
            }
        }
        public void ForceClose()
        {
            _allowClose = true;
            _overlayForm?.ForceClose();
        }
        private void QuizForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !_allowClose;
        }

        private void hintButton_Click(object sender, EventArgs e)
        {
            NoticeForm nForm;

            nForm = new NoticeForm(3, "힌트",
                        $"단어 : {_data._word}\n\n힌트 : {string.Concat(_data.hintMeaning!.Select(m => "\n" + m))}");
            nForm.StartPosition = FormStartPosition.CenterScreen;
            nForm.ShowDialog();

            AnswerInputText.Clear();
        }

        private void passButton_Click(object sender, EventArgs e)
        {
            NoticeForm nForm;

            nForm = new NoticeForm(10, "패스하였습니다",
                        $"단어 : {_data._word}\n\n뜻 : {string.Concat(_data.meaning!.Select(m => "\n" + m))}");
            nForm.StartPosition = FormStartPosition.CenterScreen;
            nForm.ShowDialog();

            AnswerInputText.Clear();
        }
    }
}
