using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public bool upIsClicked = false;
        public bool downIsClicked = false;
        public bool rightIsClicked = false;
        public bool leftIsClicked = false;
        public Form1()
        {
            Form1 newForm = new Form1();
           /* int minHeight;
            lblDisplay.Visible = false;
            btnUp.Visible = false;
            btnDown.Visible = false;
            btnLeft.Visible = false;
            btnRight.Visible = false;
            */
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
         
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            upIsClicked = true;

            GameEngine.MovePlayer(Character.MovementEnum.North);
        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            downIsClicked = true;
        }

        private void btnLeft_Click(object sender, EventArgs e)
        {
            leftIsClicked = true;
        }

        private void btnRight_Click(object sender, EventArgs e)
        {
            rightIsClicked = true;
        }

        public Form1(bool upIsClicked, bool downIsClicked, bool leftIsClicked, bool rightIsClicked)
        {
            this.upIsClicked = upIsClicked;
            this.downIsClicked = downIsClicked;
            this.leftIsClicked = leftIsClicked;
            this.rightIsClicked = rightIsClicked;
        }
    }
}
