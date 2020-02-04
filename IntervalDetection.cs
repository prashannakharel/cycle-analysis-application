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
    public partial class IntervalDetection : Form
    {
        public IntervalDetection()
        {
            InitializeComponent();
        }

        private void IntervalDetection_Load(object sender, EventArgs e)
        {
            dataparsing d = new dataparsing();
            d.HRDATA();
            int[] power = d.Power;

            double avgpower = power.Average();

            int counter =0;
            for (int i = 0; i < power.Length; i++)
            {
                if (power[counter] > avgpower)
                {
                    dataGridView1.Rows.Add(power[i].ToString());
                }
                counter++;
            }

        }
    }
}
