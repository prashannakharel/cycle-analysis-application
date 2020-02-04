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
using ZedGraph;
using System.Globalization;

namespace CycleApplication
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        List<double> heartrate = new List<double>();
        List<double> speed = new List<double>();
        List<double> altitude = new List<double>();
        List<double> power = new List<double>();
        List<double> cadence = new List<double>();


        private LineItem heartRateLine;
        private LineItem speedLine;
        private LineItem cadenceLine;
        private LineItem altitudeLine;
        private LineItem powerLine; 


        private void Form2_Load(object sender, EventArgs e)
        {
            string fileName = values.fileloc;
            try
            {
                bool isData = false;
                using (StreamReader sr = new StreamReader("ASDBExampleCycleComputerData.hrm"))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {


                        if (isData)
                        {
                            string[] hrdata = line.Split('\t');


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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            GraphPane myPane = zedGraphControl1.GraphPane;
            // Setting the Titles
            //myPane.Title.Text = "Graph Analytics for Speed, Cadence, Altitude, Heart Rate and Power&quot";
            //myPane.YAxis.Title.Text = "Individual Units of Measurements";
          
            //myPane.XAxis.Scale.Min = 0.0;
            //myPane.XAxis.Scale.Max = 4000.0;
            //myPane.YAxis.Scale.Min = 0.0;
            //myPane.YAxis.Scale.Max = 600.0;

            //kusal
            myPane.Title.Text = "Cycle Data Graph";
            myPane.XAxis.Title.Text = "Time (HH:MM:SS)";
            myPane.YAxis.Title.Text = "Heart Rate,Speed,Cadence,Altitude,Power";
            myPane.Y2Axis.Title.Text = "Speed (km/h)";

            myPane.XAxis.Type = AxisType.Date;
            myPane.XAxis.Scale.Format = "HH:mm:ss";
            myPane.XAxis.Scale.MajorUnit = DateUnit.Second; //scales up by the Second

    


            string dateTime = getDate("ASDBExampleCycleComputerData.hrm") + " " + getStartTime("ASDBExampleCycleComputerData.hrm");
            DateTime dateTimeScale = DateTime.ParseExact(dateTime, "yyyyMMdd HH:mm:ss.FFF", CultureInfo.InvariantCulture);

            // Move the legend location
            myPane.Legend.Position = ZedGraph.LegendPos.Bottom;

            PointPairList HeartRatePairList = new PointPairList();
            PointPairList SpeedPairList = new PointPairList();
            PointPairList CadencePairList = new PointPairList();
            PointPairList PowerPairList = new PointPairList();
            PointPairList AltitudePairList = new PointPairList();


            //PLOT HEART RATE POINTS
            for (int i = 0; i < heartrate.Count;i++)
            {
                double heartrateY = heartrate[i];
                HeartRatePairList.Add(new XDate(dateTimeScale.AddSeconds(i)), heartrateY); //adds the time and date scale and adds a second each time
            }
            heartRateLine = myPane.AddCurve("Heart Rate", HeartRatePairList, Color.Red, SymbolType.None);

            for (int i = 0; i < speed.Count; i++)
            {
                double speedY = speed[i]*0.1;
                SpeedPairList.Add(new XDate(dateTimeScale.AddSeconds(i)), speedY); //adds the time and date scale and adds a second each time
            }
            speedLine = myPane.AddCurve("Speed", SpeedPairList, Color.Blue, SymbolType.None);
            //speedLine.IsY2Axis = true; //assigns curve to the y2 speed axis.

            for (int i = 0; i < cadence.Count; i++)
            {
                CadencePairList.Add(new XDate(dateTimeScale.AddSeconds(i)), cadence[i]);
            }
            cadenceLine = myPane.AddCurve("Cadence", CadencePairList, Color.Green, SymbolType.None);

            for (int i = 0; i < power.Count; i++)
            {
                PowerPairList.Add(new XDate(dateTimeScale.AddSeconds(i)), power[i]);
            }
            powerLine = myPane.AddCurve("Power", PowerPairList, Color.Pink, SymbolType.None);

            for (int i = 0; i < altitude.Count; i++)
            {
                AltitudePairList.Add(new XDate(dateTimeScale.AddSeconds(i)), altitude[i]);
            }
            altitudeLine = myPane.AddCurve("Altitude", AltitudePairList, Color.Black, SymbolType.None);
            //for (int i = 0; i < heartrate.Count; i++)
            //{
             
            //    HeartRatePairList.Add(i, heartrate[i]);
            //}
            //for (int i = 0; i < speed.Count; i++)
            //{
            //    SpeedPairList.Add(i, speed[i] * 0.1);
            //}
            //for (int i = 0; i < power.Count; i++)
            //{
            //    PowerPairList.Add(i, power[i]);

            //}
            //for (int i = 0; i < cadence.Count; i++)
            //{
            //    CadencePairList.Add(i, cadence[i]);
            //}
            //for (int i = 0; i < altitude.Count; i++)
            //{
            //    AltitudePairList.Add(i, altitude[i]);
            //}

            //heartRateLine = myPane.AddCurve("Heart Rate", HeartRatePairList, Color.Red, SymbolType.None);
            //speedLine = myPane.AddCurve("Speed", SpeedPairList, Color.Blue, SymbolType.None);
            //powerLine = myPane.AddCurve("Power", PowerPairList, Color.Purple, SymbolType.None);
            //cadenceLine = myPane.AddCurve("Cadence", CadencePairList, Color.Brown, SymbolType.None);
            //altitudeLine = myPane.AddCurve("Altitude", AltitudePairList, Color.Green, SymbolType.None);



            myPane.AxisChange();
            zedGraphControl1.Refresh();
        }


        private string getStartTime(String filePath)
        {
            string line;

            try
            {
                using (StreamReader rdr = new StreamReader(filePath))
                {
                    while ((line = rdr.ReadLine()) != null)
                    {
                        if (line.Contains("StartTime"))
                        {

                            string[] words = line.Split('=');
                            return words[1];
                        }
                    }

                    rdr.Close();
                }
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }

            return null;
        }

        private string getDate(String filePath)
        {
            string line;


            try
            {
                StreamReader rdr = new StreamReader(filePath);

                while ((line = rdr.ReadLine()) != null)
                {
                    if (line.Contains("Date"))
                    {
                        string[] words = line.Split('=');

                        string dateString = words[1]; //1st index, after the equals sign is the date string
                        DateTime date = DateTime.ParseExact(dateString, "yyyyMMdd", CultureInfo.InvariantCulture); //parsing the date
                        return words[1];

                    }
                }

                rdr.Close();
            }
            catch (IOException e)
            {
                Console.WriteLine(e);
            }

            return null;
        }
    }
}
