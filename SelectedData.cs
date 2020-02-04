using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.Globalization;

namespace CycleApplication
{
    public partial class SelectedData : Form
    {
        public SelectedData()
        {
            InitializeComponent();
        }
        public int rows;
        public string[] timestamp;
        public double[] hr;
        public double[] sp;
        public double[] cd;
        public double[] al;
        public double[] po;
        PointPairList HeartRatePairList = new PointPairList();
        PointPairList SpeedPairList = new PointPairList();
        PointPairList CadencePairList = new PointPairList();
        PointPairList PowerPairList = new PointPairList();
        PointPairList AltitudePairList = new PointPairList();
        int interval = 0;
        int interval1 = 0;
        private void SelectedData_Load(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < rows; i++)
                {
                    dataGridView1.Rows.Add(timestamp[i], hr[i], sp[i], cd[i], al[i], po[i]);
                }

               


                 IDictionary<string, string> header = dataparsing.Header();
                 string time = header["StartTime"];
                 interval = Convert.ToInt16(header["Interval"]);
               



                string tim1 = dataGridView1.Rows[0].Cells[0].Value.ToString();

                string[] getTime = tim1.Split(' ');

                string starttime = getTime[0].ToString();

                //  DateTime dateTimeScale = DateTime.ParseExact(starttime, "HH:mm:ss.FFF", CultureInfo.InvariantCulture);
                DateTime dateTimeScale = DateTime.Parse(starttime);

                ZedGraphControl zedGraph = zedGraphControl1;
                GraphPane mypane = zedGraph.GraphPane;

                mypane.CurveList.Clear();

                mypane.Title.Text = "Cycle Analysis Software Graph";
                mypane.XAxis.Title.Text = "No. Of Data";
                mypane.YAxis.Title.Text = "Rate";



                mypane.XAxis.Type = AxisType.Date;
                mypane.XAxis.Scale.Format = "HH:mm:ss";
                mypane.XAxis.Scale.MajorUnit = DateUnit.Second; //scales up by the Second

                for (int j = 0; j < rows; j++)
                {
                    HeartRatePairList.Add(new XDate(dateTimeScale.AddSeconds(interval1)), (hr[j]));
                    SpeedPairList.Add(new XDate(dateTimeScale.AddSeconds(interval1)), (sp[j]));
                    CadencePairList.Add(new XDate(dateTimeScale.AddSeconds(interval1)), (cd[j]));
                    AltitudePairList.Add(new XDate(dateTimeScale.AddSeconds(interval1)), (al[j]));
                    PowerPairList.Add(new XDate(dateTimeScale.AddSeconds(interval1)), (po[j]));

                    interval1 = interval +interval1;
                }


                LineItem Curve1 = mypane.AddCurve("heart rate", HeartRatePairList, Color.Red);
                LineItem Curve2 = mypane.AddCurve("Speed", SpeedPairList, Color.Blue);
                LineItem Curve3 = mypane.AddCurve("Cadence", CadencePairList, Color.Green);
                LineItem Curve4 = mypane.AddCurve("Altitude", AltitudePairList, Color.Yellow);
                LineItem Curve5 = mypane.AddCurve("Power", PowerPairList, Color.Purple);


                zedGraph.AxisChange();
                zedGraph.Invalidate();
                LoadAdvancemetric();
                LoadSummary();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void LoadSummary()
        {
            double distance1 = 0;
            for (int i = 0; i < sp.Length; i++)
            {
                distance1 += (sp[i] / 10) / 3600;
            }


            //displaying data in label 
            lbltotaldistance.Text = distance1.ToString("#.#####") + "km";

            lblmaxhr.Text = hr.Max().ToString();
            lblminhr.Text = hr.Min().ToString();
            lblavghr.Text = hr.Average().ToString("#.##");

            double maxspeed = sp.Max() / 10;
            lblmaxspeed.Text = maxspeed.ToString("#.##") + " km/h";

            double avgspeed = sp.Average() / 10;
            lblavgspeed.Text = avgspeed.ToString("#.##") + " km/h";

            lblmaxaltitude.Text = al.Max().ToString() + " m";
            lblavgaltitude.Text = al.Average().ToString("#.##") + " m";

            lblmaxpower.Text = po.Max().ToString() + " watt";
            lblaveragepower.Text = po.Average().ToString("#.##") + " watt";

        }
        private void LoadAdvancemetric()
        {
            double totalrollingavgpower = 0;

            //dataGridView1.Columns.Add("Moving Avg Power", "Moving Avg Power");
            for (int i = 0; i < po.Length; i++)
            {
                double movingAvg30 = 0;
                //To calculate moving average of 30 data
                for (int j = 0; j < 30; j++)
                {
                    int index = i + j;
                    index %= po.Length;
                    movingAvg30 += po[index];
                }
                movingAvg30 /= 30;


                //totalrollingavgpower += Math.Pow(movingAvg30,4.0);
                totalrollingavgpower = totalrollingavgpower + Math.Pow(movingAvg30, 4.0);
            }
            double avgpower = totalrollingavgpower / po.Length;



            //Normalized power
            double normalizedpower = Math.Round(Math.Pow(avgpower, 0.25));

            lblnormalizedpower.Text = normalizedpower.ToString();

            //Functional threshold 

            double avg1power = Convert.ToDouble(po.Average());
            double FTP = Math.Round(avg1power * 0.95);
            double totalftp = avg1power - FTP;
            lblftp.Text = FTP.ToString();

            //Intensity factor 
            double intensityFactor = Math.Round((normalizedpower / FTP), 2);

            IF.Text = intensityFactor.ToString();
            //TSS

            double TSS = Math.Round(((3960 * normalizedpower * intensityFactor) / (totalftp * 3600)) * 100);


            tss.Text = TSS.ToString();
        }
       
    }
}
