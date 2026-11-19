using OwnVoca.CS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OwnVoca.FORM
{
    public partial class MainForm : Form
    {
        private OVSystem ovs;
        public MainForm()
        {
            InitializeComponent();
            ovs = new OVSystem();
            RefreshUI();
        }
        private void RefreshUI()
        {
            spawnIntervalText.Text = ovs.quizIntervalSecond.ToString();
            levelComboBox.SelectedIndex = levelComboBox.Items.IndexOf(ovs.quizLevel.ToString());

            if (ovs.State == OVState.Ready)
            {
                controlButton.Text = "시작";
                controlButton.BackColor = Color.YellowGreen;
            }
            else if (ovs.State == OVState.Running)
            {
                controlButton.Text = "중지";
                controlButton.BackColor = Color.LightCoral;
            }
        }
        private void controlButton_Click(object sender, EventArgs e)
        {
            if (ovs.State == OVState.Ready) ovs.Start();

            else if (ovs.State == OVState.Running) ovs.Stop();

            RefreshUI();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (ovs._curQF == null) //End Quiz
            {
                ovs.Stop();
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void spawnIntervalText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int interval;

                if (int.TryParse(spawnIntervalText.Text, out interval))
                {
                    if (interval >= 0)
                    {
                        ovs.quizIntervalSecond = (uint)interval;
                    }
                    else
                    {
                        //Default
                        ovs.quizIntervalSecond = 60;
                    }
                }
                RefreshUI();
            }
        }

        private void levelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ovs.quizLevel = ushort.Parse(levelComboBox.Text);
            RefreshUI();
        }
    }
}
