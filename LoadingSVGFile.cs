using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MultiScad
{
    public partial class LoadingSVGFile : Form
    {
        public LoadingSVGFile()
        {
            InitializeComponent();
        }

        public void LoadSVGForm()
        {
            InitializeComponent();
        }

        public string UpdateNameText
        {
            set
            {
                this.inputNameText.Text = value;
                Update();
                Refresh();
            }
        }

        public string UpdateMD5Text
        {
            set
            {
                this.inputMD5Text.Text = value;
                Update();
                Refresh();
            }
        }

        public string UpdateProcessText
        {
            set
            {
                this.processText.Text = value;
                processText.Update();
                processText.Refresh();
            }
        }

  

        private void LoadingSVGFile_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void importProgress_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
