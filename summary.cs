using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace CycleApplication
{
    public partial class summary : UserControl
    {
        public summary()
        {
            InitializeComponent();
        }
      
        List<double> heartrate = new List<double>();
        List<double> speed = new List<double>();
        List<double> altitude = new List<double>();
        List<double> power = new List<double>();
        List<double> cadence = new List<double>();

        private void summary_Load(object sender, EventArgs e)
        {
            
          
        }

        private void button1_Click(object sender, EventArgs e)
        {
           double distance1 = 0;
           heartrate.Clear();
           speed.Clear();
           cadence.Clear();
           power.Clear();
           altitude.Clear();
           string fileName = values.fileloc;
           try
           {
               bool isData = false;
               using (StreamReader sr = new StreamReader(fileName))
               {
                   string line;
                   while ((line = sr.ReadLine()) != null)
                   {

                     
                       if (isData)
                       {
                           string[] hrdata = line.Split('\t');

                           //storing data in list
                           heartrate.Add(Convert.ToDouble(hrdata[0]));
                           speed.Add(Convert.ToDouble(hrdata[1]));
                           cadence.Add(Convert.ToDouble(hrdata[2]));
                           altitude.Add(Convert.ToDouble(hrdata[3]));
                           power.Add(Convert.ToDouble(hrdata[4]));
                       }
                       if (line == "[HRData]")
                       {
                           isData = true;
                       }
                   }
                  
                   for (int i = 0; i < speed.Count; i++)
                   {
                       distance1 += (speed[i] / 10) / 3600;
                   }


                   //displaying data in label 
                   lbltotaldistance.Text = distance1.ToString("#.##") + "km";

                   lblmaxhr.Text = heartrate.Max().ToString();
                   lblminhr.Text = heartrate.Min().ToString();
                   lblavghr.Text = heartrate.Average().ToString("#.##");

                   double maxspeed = speed.Max()/10;
                   lblmaxspeed.Text = maxspeed.ToString("#.##") +" km/h";

                   double avgspeed = speed.Average() / 10;
                   lblavgspeed.Text = avgspeed.ToString("#.##") + " km/h";

                   lblmaxaltitude.Text = altitude.Max().ToString() + " m";
                   lblavgaltitude.Text = altitude.Average().ToString("#.##") + " m";

                   lblmaxpower.Text = power.Max().ToString() + " watt";
                   lblaveragepower.Text = power.Average().ToString("#.##") + " watt";

               }
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
        }

        private void radioMetric_CheckedChanged(object sender, EventArgs e)
        {
            //changing imperal system to metric system
            double distance1 = 0;
            for (int i = 0; i < speed.Count; i++)
            {
                distance1 += (speed[i] / 10) / 3600;
            }
             lbltotaldistance.Text = distance1.ToString("#.##") + "km";

             double maxspeed = speed.Max() / 10;
             lblmaxspeed.Text = maxspeed.ToString("#.##") + " km/h";

             double avgspeed = speed.Average() / 10;
             lblavgspeed.Text = avgspeed.ToString("#.##") + " km/h";

             lblmaxaltitude.Text = altitude.Max().ToString() + " m";
             lblavgaltitude.Text = altitude.Average().ToString("#.##") + " m";

        }

        private void radioimperial_CheckedChanged(object sender, EventArgs e)
        {
            //average speed
            double avspeed = (speed.Sum() / speed.Count()) * 0.1;
            double avspeedmiles = avspeed / 1.6;
            avspeedmiles = Math.Round(avspeedmiles, 2); //convert and round to 2 decimal places
             lblavgspeed.Text = avspeedmiles + " mph";
            
            
            double distance1 = 0;
            for (int i = 0; i < speed.Count; i++)
             {
                 distance1 += (speed[i] / 10) / 3600;
             }
            double newdistance = distance1 * 0.6;
            lbltotaldistance.Text = newdistance.ToString("#.##") + "miles";

            //max speed
            double speedmph = (speed.Max() * 0.1) / 1.6;
            speedmph = Math.Round(speedmph, 2);
            lblmaxspeed.Text = speedmph + " mph";


            lblmaxaltitude.Text = (altitude.Max() * 3.28084).ToString() + "feet";
            lblavgaltitude.Text = (altitude.Average() * 3.28084).ToString("#.##") + " feet";

        }

       
         
            
        }


    }

