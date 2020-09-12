using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            lblDisplay.Visible = false;
            btnUp.Visible = false;
            btnDown.Visible = false;
            btnLeft.Visible = false;
            btnRight.Visible = false;
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            lblDisplay.Visible = true;
            btnUp.Visible = true;
            btnDown.Visible = true;
            btnLeft.Visible = true;
            btnRight.Visible = true;

            lblMapMinWidth.Visible = false;
            lblMapMaxWidth.Visible = false;
            lblMapMinHeight.Visible = false;
            lblMapMaxHeight.Visible = false;
            txtMapMinWidth.Visible = false;
            txtMapMaxWidth.Visible = false;
            txtMapMinHeight.Visible = false;
            txtMapMaxHeight.Visible = false;
            btnStart.Visible = false;
        }
    }
}
