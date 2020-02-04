using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CycleApplication
{
    public partial class SelectedInfo : UserControl
    {
        public SelectedInfo()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var data = dataparsing.retrieve();
            List<double> heartrate = data.Item1;

            for( int i =0; i<heartrate.Count; i++)
            {
               
            }
        }

        private void SelectedInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
