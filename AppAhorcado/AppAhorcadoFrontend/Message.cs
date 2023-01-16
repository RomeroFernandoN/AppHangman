using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AppAhorcado
{
    public partial class Message : Form
    {
        public int leave;
        public Message(string lbl, string one, string two, string three, Image oImage)
        {
            InitializeComponent();
            lblQuestion.Text = lbl;
            btnThree.Visible = false;
            if(oImage != null)
            {
                picBox.BackgroundImage = oImage;
                picBox.BackgroundImageLayout = ImageLayout.Stretch;
            }
            if (one != "" || two != "")
            {
                btnOne.Text = one;
                btnTwo.Text = two;
            }
            else
            {
                btnOne.Visible = false;
                btnTwo.Visible = false;
                btnThree.Visible = true;
                btnThree.Text = three;
            }
        }
        private void Exit_Load(object sender, EventArgs e)
        {
            lblQuestion.Select();
        }

        private void BtnOne_Click(object sender, EventArgs e)
        {
            leave = 1;
            this.Dispose();
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            leave = 0;
            this.Dispose();
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            leave = 1;
            this.Dispose();
        }
    }
}
