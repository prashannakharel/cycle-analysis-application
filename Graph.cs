using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.IO;
using System.Globalization;
namespace CycleApplication
{
    public partial class Graph : UserControl
    {
        public Graph()
        {
            InitializeComponent();
        }

        List<double> heartrate = new List<double>();
        List<double> speed = new List<double>();
        List<double> altitude = new List<double>();
        List<double> power = new List<double>();
        List<double> cadence = new List<double>();


        private LineItem lineItemHeart;
        private LineItem lineItemSpeed;
        private LineItem lineItenCadence;
        private LineItem lineItemAltitude;
        private LineItem lineItemPower;


        PointPairList HeartRatePairList = new PointPairList();
        PointPairList SpeedPairList = new PointPairList();
        PointPairList CadencePairList = new PointPairList();
        PointPairList PowerPairList = new PointPairList();
        PointPairList AltitudePairList = new PointPairList();

        private void zedGraphControl1_Load(object sender, EventArgs e)
        {
         
        }

        private void Graph_Load(object sender, EventArgs e)
        {

        

        }

        private void btnload_Click(object sender, EventArgs e)
        {
            zedGraphControl1.Refresh();
            zedGraphControl1.GraphPane.CurveList.Clear();
            zedGraphControl1.GraphPane.GraphObjList.Clear();
            HeartRatePairList.Clear();
            SpeedPairList.Clear();
            CadencePairList.Clear();
            PowerPairList.Clear();
            AltitudePairList.Clear();
            heartrate.Clear();
            speed.Clear();
            cadence.Clear();
            altitude.Clear();
            power.Clear();
            
            LoadGraph();

        }

        private void LoadGraph()
        {
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

                GraphPane graphPane = zedGraphControl1.GraphPane;

                graphPane.Title.Text = "Cycle Data Graph";
                graphPane.XAxis.Title.Text = "Time (HH:MM:SS)";
                graphPane.YAxis.Title.Text = "Heart Rate,Speed,Cadence,Altitude,Power";
                graphPane.Y2Axis.Title.Text = "Speed (km/h)";

                graphPane.XAxis.Type = AxisType.Date;
                graphPane.XAxis.Scale.Format = "HH:mm:ss";
                graphPane.XAxis.Scale.MajorUnit = DateUnit.Second; //scales up by the Second



                //parsing the date and time in specified format
                string dateTime = getDate(fileName) + " " + getStartTime(fileName);
                DateTime dateTimeScale = DateTime.ParseExact(dateTime, "yyyyMMdd HH:mm:ss.FFF", CultureInfo.InvariantCulture);

                // Move the legend location
                graphPane.Legend.Position = ZedGraph.LegendPos.Bottom;



                //plotting heart rate on the graph
                for (int i = 0; i < heartrate.Count; i++)
                {
                    double heartrateY = heartrate[i];
                    HeartRatePairList.Add(new XDate(dateTimeScale.AddSeconds(i)), heartrateY); //adds the time and date scale and adds a second each time
                }
                lineItemHeart = graphPane.AddCurve("Heart Rate", HeartRatePairList, Color.Red, SymbolType.None);
                //plotting speed on the graph
                for (int i = 0; i < speed.Count; i++)
                {
                    double speedY = speed[i] * 0.1;
                    SpeedPairList.Add(new XDate(dateTimeScale.AddSeconds(i)), speedY); //adds the time and date scale and adds a second each time
                }
                lineItemSpeed = graphPane.AddCurve("Speed", SpeedPairList, Color.Blue, SymbolType.None);
                //plotting cadence on the graph
                for (int i = 0; i < cadence.Count; i++)
                {
                    CadencePairList.Add(new XDate(dateTimeScale.AddSeconds(i)), cadence[i]);
                }
                lineItenCadence = graphPane.AddCurve("Cadence", CadencePairList, Color.Green, SymbolType.None);
                //plotting power on the graph
                for (int i = 0; i < power.Count; i++)
                {
                    PowerPairList.Add(new XDate(dateTimeScale.AddSeconds(i)), power[i]);
                }
                lineItemPower = graphPane.AddCurve("Power", PowerPairList, Color.Pink, SymbolType.None);
                //plotting altitude on the graph
                for (int i = 0; i < altitude.Count; i++)
                {
                    AltitudePairList.Add(new XDate(dateTimeScale.AddSeconds(i)), altitude[i]);
                }
                lineItemAltitude = graphPane.AddCurve("Altitude", AltitudePairList, Color.Black, SymbolType.None);

                graphPane.AxisChange();
                zedGraphControl1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          
        }
        private string getStartTime(String filePath)//returs starttime of the rider
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
                MessageBox.Show(e.Message);
            }

            return null;
        }

        private string getDate(String filePath)//returns date of the ride
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
                MessageBox.Show(e.Message);
            }

            return null;
        }

        private void checkBoxHR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxHR.Checked == true)
            {
                zedGraphControl1.GraphPane.CurveList.Remove(lineItemHeart);
            }
            else
            {
                zedGraphControl1.GraphPane.CurveList.Add(lineItemHeart);

            }
            zedGraphControl1.Refresh();
        }

        private void checkBoxSpeed_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSpeed.Checked == true)
            {
                zedGraphControl1.GraphPane.CurveList.Remove(lineItemSpeed);
            }
            else
            {
                zedGraphControl1.GraphPane.CurveList.Add(lineItemSpeed);

            }
            zedGraphControl1.Refresh();

        }

        private void checkBoxCadence_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxCadence.Checked == true)
            {
                zedGraphControl1.GraphPane.CurveList.Remove(lineItenCadence);
            }
            else
            {
                zedGraphControl1.GraphPane.CurveList.Add(lineItenCadence);

            }
            zedGraphControl1.Refresh();
        }

        private void checkBoxAltitude_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAltitude.Checked == true)
            {
                zedGraphControl1.GraphPane.CurveList.Remove(lineItemAltitude);
            }
            else
            {
                zedGraphControl1.GraphPane.CurveList.Add(lineItemAltitude);

            }
            zedGraphControl1.Refresh();
        }

        private void checkBoxPower_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPower.Checked == true)
            {
                zedGraphControl1.GraphPane.CurveList.Remove(lineItemPower);
            }
            else
            {
                zedGraphControl1.GraphPane.CurveList.Add(lineItemPower);

            }
            zedGraphControl1.Refresh();
        }


        

    }
}
