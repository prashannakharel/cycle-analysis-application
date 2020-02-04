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
    public partial class AdvancedMetric : UserControl
    {
        public AdvancedMetric()
        {
            InitializeComponent();
        }


        List<double> power = new List<double>();

        private void AdvancedMetric_Load(object sender, EventArgs e)
        {
          

        }

        void LoadData()
        {
            power.Clear();
            string fileName = values.fileloc;
            var item = dataparsing.retrieve();
            power = item.Item5;
            double totalrollingavgpower = 0;

            IDictionary<string, string> getLength = dataparsing.Header();
            string length = getLength["Length"];

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
                    

                        //totalrollingavgpower += Math.Pow(movingAvg30,4.0);
                        totalrollingavgpower = totalrollingavgpower + Math.Pow(movingAvg30,4.0);
                    }
                    double avgpower = totalrollingavgpower / power.Count;
            
            
            
            //Normalized power
                   double normalizedpower = Math.Round(Math.Pow(avgpower,0.25));

                  lblnormalizedpower.Text = normalizedpower.ToString();

            //Functional threshold 

                  double avg1power = Convert.ToDouble(power.Average());
                  double FTP = Math.Round(avg1power * 0.95);
                  double totalftp = avg1power - FTP;
                  lblftp.Text = FTP.ToString();

            //Intensity factor 
                  double intensityFactor = Math.Round((normalizedpower / FTP),2);

                  IF.Text = intensityFactor.ToString();
            //TSS

                  double TSS = Math.Round(((3960 * normalizedpower * intensityFactor) / (totalftp * 3600)) * 100);


                  tss.Text = TSS.ToString();

                    

                }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            }
            
         
        }
      
    }

