using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OwnVoca.FORM
{
    public partial class OverlayForm : Form
    {
        private bool _allowClose = false;
        public OverlayForm()
        {
            InitializeComponent();
        }
        public void ForceClose()
        {
            _allowClose = true;
            this.Close();
        }
        private void OverlayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = !_allowClose;
        }

        private void OverlayForm_Load(object sender, EventArgs e)
        {
            
        }
    }
}
