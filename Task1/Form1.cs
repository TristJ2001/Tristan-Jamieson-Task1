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
            InitializeComponent();
            GameEngine map1 = new GameEngine();
            
            lblDisplay.Text = map1.MapVariable.ToString();
        }
        
        public void Map()
        {
            
        }
        private void btnStart_Click(object sender, EventArgs e)
        {
         
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            upIsClicked = true;
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
