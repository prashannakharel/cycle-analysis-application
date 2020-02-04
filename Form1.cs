using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CycleApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void datA_VIEW1_Load(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            graph1.BringToFront();
            panelHighlight.Height = btnReport.Height;
            panelHighlight.Top = btnReport.Top;
        }

        private void btndataview_Click(object sender, EventArgs e)
        {
            datA_VIEW1.BringToFront();
            panelHighlight.Height = btndataview.Height;
            panelHighlight.Top = btndataview.Top;
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void btnaddprojects_Click(object sender, EventArgs e)
        {
            summary1.BringToFront();
            panelHighlight.Height = btnaddprojects.Height;
            panelHighlight.Top = btnaddprojects.Top;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnselectedinfo_Click(object sender, EventArgs e)
        {
            advancedMetric1.BringToFront();
            panelHighlight.Height = btnselectedinfo.Height;
            panelHighlight.Top = btnselectedinfo.Top;

           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            IntervalDetection i = new IntervalDetection();
            i.Show();
        }
        }
    }

