using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CycleApplication
{
    public partial class normalized_power : Form
    {
        public normalized_power()
        {
            InitializeComponent();
        }

        private void normalized_power_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        List<double> power = new List<double>();
        void LoadData()
        {
            string fileName = values.fileloc;
            var item = dataparsing.retrieve();
            power = item.Item5;
            double totalrollingavgpower = 0;

            dataparsing d = new dataparsing();
            d.HRDATA();
            int[] power1 = d.Power;
            MessageBox.Show(power1[0].ToString());
                 //dataGridView1.Columns.Add("Moving Avg Power", "Moving Avg Power");
                    for (int i = 0; i < power.Count; i++)
                    {
                        double movingAvg30 = 0;
                        //To calculate moving average of 30 data
                        for (int j = 0; j < 30; j++)
                        {
                            int index = i + j;
                            index %= power.Count;
                            movingAvg30 += power[index];
                        }
                        movingAvg30 /= 30;
                        //add data to grid data 
                        dataGridView1.Rows.Add(movingAvg30);

                        //totalrollingavgpower += Math.Pow(movingAvg30,4.0);
                        totalrollingavgpower = totalrollingavgpower + Math.Pow(movingAvg30,4.0);
                    }
                    double avgpower = totalrollingavgpower / power.Count;
            
            
            
            //Normalized power
                   double normalizedpower = Math.Pow(avgpower,0.25);

                  label2.Text = normalizedpower.ToString();

            //Functional threshold 

                  double avg1power = Convert.ToDouble(power.Average());
                  double FTP = avg1power * 0.95;
                  double totalftp = avg1power - FTP;
           

            //Intensity factor 
                  double intensityFactor = normalizedpower / FTP;

                  label6.Text = intensityFactor.ToString();
            //TSS

                  double TSS = ((3960 * normalizedpower * intensityFactor) / (totalftp * 3600)) * 100;


                  label4.Text = TSS.ToString();


                  MessageBox.Show(power.Count.ToString());
                }
            
         
        }
    
}
