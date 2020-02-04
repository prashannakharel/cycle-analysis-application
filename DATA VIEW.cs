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
using System.Text.RegularExpressions;
using System.Collections;
using System.Globalization;


namespace CycleApplication
{
    public partial class DATA_VIEW : UserControl
    {
        public DATA_VIEW()
        {
            InitializeComponent();
        }

        IDictionary<string, string> IDict = new Dictionary<string, string>();
        ArrayList arrayList = new ArrayList();
        private string heart;
        private string speed;
        private string cadence;
        private string altitude;
        private string power;
        private string powerbal;
        public string filePath;

        List<double> lstpower = new List<double>();






        private void btnbrowse_Click(object sender, EventArgs e)
        {


        }


        public void LoadData()
        {

            lblversion.Text = IDict["Version"];
            lblmonitor.Text = IDict["Monitor"];
            lblsmode.Text = IDict["SMode"];
            lbldate.Text = IDict["Date"];
            lblstarttime.Text = IDict["StartTime"];
            lbllength.Text = IDict["Length"];
            lblmaxhr.Text = IDict["MaxHR"];
            lblresthr.Text = IDict["RestHR"];
            lblvo2max.Text = IDict["VO2max"];
            lblweight.Text = IDict["Weight"];
            lblinterval.Text = IDict["Interval"];
            values.interval = IDict["Interval"];

        }

        private void DATA_VIEW_Load(object sender, EventArgs e)
        {


        }

        private void ParseFile(string path)
        {
            
                int speedTotal = 0;
                double mph = 0;

                try
                {

                    // Creating  an instance of StreamReader to read from a file.
                    values.fileloc = path;

                    StreamReader sr = new StreamReader(path);
                    

                    string line;

                    bool isHeader = false; bool isHrDATA = false;//boolena to check whether data exist or not
               
                   
                    string startTimeString = getStartTime(filePath); //getting time as a string from the getStartTime method
                    DateTime startTime = DateTime.ParseExact(startTimeString, "HH:mm:ss.FFF", CultureInfo.InvariantCulture);
                    int interval = 0; //to add the time according to the given interval
                    int i = 0;
                    string dateofRide = getDate(filePath);
                    DateTime ridedate = DateTime.ParseExact(dateofRide, "yyyyMMdd", CultureInfo.InvariantCulture);
                    string dateTime;
                    // Read and display lines from the file until the end of the file is reached.
                    while ((line = sr.ReadLine()) != null)
                    {
                        if (isHeader == true)
                        {
                            //  Console.WriteLine(line);
                            string[] parameter = line.Split('=');
                            if (parameter.Length > 1)
                            {
                                IDict.Add(parameter[0], parameter[1]);

                                if (line.Substring(0, 1) == "[")
                                {
                                    isHeader = false;
                                    break;
                                }
                            }
                        }

                        if (isHrDATA == true)
                        {

                            //code for loading data in grid view
                            heart = line.Split('\t')[0];
                            speed = line.Split('\t')[1];
                            int speedint = Convert.ToInt32(speed);
                            speedTotal += speedint;
                            mph = ((double)speedint / (double)1.6);

                            if (speedint <= 1)
                            {
                                speed = speed.Insert(1, "."); // add point after two numbers
                            }
                            else
                            {
                                if (speedint >= 1)
                                    speed = speed.Insert(2, "."); // add point after two numbers
                            }
                            cadence = line.Split('\t')[2];
                            altitude = line.Split('\t')[3];
                            power = line.Split('\t')[4];
                            powerbal = line.Split('\t')[5];
                            interval = int.Parse(IDict["Interval"]);
                            //adding 1 sec in each interval
                            startTime = startTime.AddSeconds(i);//joining the start time and ride date of the rider
                            dateTime = startTime.ToLongTimeString() + " " + ridedate.ToShortDateString();


                           
                             dataGridView1.Rows.Add(dateTime, heart, speed, cadence, altitude, power, powerbal, "Low Power");

                            i = interval;



                        }

                        if (line == "[Params]")
                        {
                            isHeader = true;
                        }
                        if (line == "[HRData]")
                        {
                            isHrDATA = true;
                            Console.WriteLine("isdata");
                        }

                    }
                    LoadData();//display the header informationn
                    LoadSmodeData();//display SMODE data
                }

                catch (Exception ex)
                {
                    // Let the user know what went wrong.
                    MessageBox.Show(ex.Message);
                }

        }

        bool hasDataLoaded = false; 

        private void btnbrowse_Click_1(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "HRM files (*.hrm)|*.hrm|All files (*.*)|*.*";//chhosing the type of file to select from the open file dialog
            if (openFileDialog1.ShowDialog() == DialogResult.OK)//when the file is selecting the following block of code will execute
            {
                if (hasDataLoaded)
                {
                    IDict.Clear();
                    dataGridView1.Rows.Clear();
                    dataGridView1.Refresh();

                }
                filePath = openFileDialog1.FileName;
                values.fileloc = filePath;

                ParseFile(filePath);

                hasDataLoaded = true;
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
                Console.WriteLine(e);
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
                Console.WriteLine(e);
            }

            return null;
        }
        private void LoadSmodeData()
        {
            string smode = IDict["SMode"];//converting smode data into characters
            char[] smodeData = smode.ToCharArray();
            char speed = smodeData[0];
            char cadence = smodeData[1];
            char altitude = smodeData[2];
            char power = smodeData[3];
            char powerLRBalance = smodeData[4];
            char PowerPIndex = smodeData[5];
            char hrcc = smodeData[6];
            char usEuroUnit = smodeData[7];
            char airPressure = smodeData[8];


            if (speed == '1') // for speed 
            {
                lblspeed.Text = "On";
            }
            else if (speed == '0')
            {
                lblspeed.Text = "Off";
                dataGridView1.Columns[6].Visible = false;

            }

            if (cadence == '1') // for cadence
            {
                lblcadence.Text = "On";
            }
            else if (cadence == '0')
            {
                lblcadence.Text = "Off";
                dataGridView1.Columns[2].Visible = false;

            }

            if (altitude == '1') // for altitude
            {
                lblaltitude.Text = "On";
            }
            else if (altitude == '0')
            {
                lblaltitude.Text = "Off";
                dataGridView1.Columns[3].Visible = false;

            }

            if (power == '1') // for power
            {
                lblpower.Text = "On";
            }
            else if (power == '0')
            {
                lblpower.Text = "Off";
                dataGridView1.Columns[4].Visible = false;

            }

            if (powerLRBalance == '1') // for power Left Right Balance 
            {
                lblpb.Text = "On";
            }
            else if (powerLRBalance == '0')
            {
                lblpb.Text = "Off";
                dataGridView1.Columns[5].Visible = false;

            }

            if (PowerPIndex == '1') // for Power Pedlling Index 
            {
                lblpi.Text = "On";
            }
            else if (PowerPIndex == '0')
            {
                lblpi.Text = "Off";
            }

            if (hrcc == '1') // for HR/CC Data 
            {
                lblhrcc.Text = "HR + Cycling Data";
            }
            else if (hrcc == '0')
            {
                lblhrcc.Text = "HR Data Only";
            }

            if (usEuroUnit == '1') // for us/euro unit
            {
                lblus.Text = "US Unit";
            }
            else if (usEuroUnit == '0')
            {
                lblus.Text = "Euro Unit";
            }

            if (airPressure == '1') // for Air Pressure
            {
                lblairpressure.Text = "On";
            }
            else if (airPressure == '0')
            {
                lblairpressure.Text = "Off";
            }


        }
        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (dataGridView1.Rows.Count == 1)
                {
                    MessageBox.Show("There is no data");
                }
                else
                {
                    SelectedData d = new SelectedData();
                    int noOFrows = dataGridView1.SelectedRows.Count;
                    string[] timestamp = new string[noOFrows];
                    double[] hr = new double[noOFrows];
                    double[] sp = new double[noOFrows];
                    double[] cd = new double[noOFrows];
                    double[] al = new double[noOFrows];
                    double[] po = new double[noOFrows];

                    int i = 0;
                    foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                    {

                        timestamp[i] = dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
                        hr[i] = Convert.ToDouble(dataGridView1.Rows[rowindex].Cells[1].Value.ToString());
                        sp[i] = Convert.ToDouble(dataGridView1.Rows[rowindex].Cells[2].Value.ToString());
                        cd[i] = Convert.ToDouble(dataGridView1.Rows[rowindex].Cells[3].Value.ToString());
                        al[i] = Convert.ToDouble(dataGridView1.Rows[rowindex].Cells[4].Value.ToString());
                        po[i] = Convert.ToDouble(dataGridView1.Rows[rowindex].Cells[5].Value.ToString());

                        i++;
                        rowindex++;
                    }
                    d.hr = hr;
                    d.timestamp = timestamp;
                    d.sp = sp;
                    d.cd = cd;
                    d.al = al;
                    d.po = po;
                    d.rows = noOFrows;
                    d.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    
        /// <summary>
        /// FOLDER BROWISING BLOCK
        /// </summary>
        string[] path;
        List<string> filenames = new List<string>();

        private void btnbrowsefolder_Click(object sender, EventArgs e)
        {


            FolderBrowserDialog folder = new FolderBrowserDialog();

            if (folder.ShowDialog() == DialogResult.OK)
            {

                path = Directory.GetFiles(folder.SelectedPath);
                DateTime timeDate;
                //devlaing streamreader to read first file of HRM folder
                StreamReader sr1 = new StreamReader(path[0]);
                while (!sr1.EndOfStream)
                {
                    string line = sr1.ReadLine();
                    if (line.Contains("Date"))
                    {
                        string startDate = line.Split('=').Last();
                        timeDate = DateTime.ParseExact(startDate, "yyyyMMdd", CultureInfo.InvariantCulture);
                        string startDateVal = timeDate.ToString();
                    }
                }



                foreach(string fileData in path)
                {
                     string value = fileData;

                    
                StreamReader sr = new StreamReader(value);
                int i = 0;
                   while (!sr.EndOfStream)
                {

                    string line = sr.ReadLine();
                    if (line.Contains("Date"))
                    {
                        string startDate = line.Split('=').Last();
                        timeDate = DateTime.ParseExact(startDate, "yyyyMMdd", CultureInfo.InvariantCulture);
                        string startDateVal = timeDate.ToString();
                        filenames.Add(startDateVal.ToString());


                        monthCalendar1.AddBoldedDate(timeDate);
                        monthCalendar1.UpdateBoldedDates();

                        
                        monthCalendar1.SelectionStart = timeDate;
                    }


                       i++;
                }

                   for (int j = 0; j < filenames.Count(); j++)
                   {
                       lsthrmfiles.Items.Add(filenames[j] + "    |   " + path[j]);

                   }
                }

             

       


            }


        }

        private void lsthrmfiles_SelectedIndexChanged(object sender, EventArgs e)
        {

            string[] name = lsthrmfiles.SelectedItem.ToString().Split('|');
            if (hasDataLoaded)
            {
                IDict.Clear();//clearing the dictornary
                dataGridView1.Rows.Clear();//clearing data grid view
                dataGridView1.Refresh();

            }
            filePath = name[1].ToString().Trim();//storing the file location 
            ParseFile(filePath);
            hasDataLoaded = true;
           
            
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

            lsthrmfiles.Items.Clear();
            
            for (int i = 0; i < filenames.Count(); i++)
            {
                string[] file = filenames[i].Split(' ');
                DateTime timeDate = DateTime.Parse(file[0].ToString());
                string startDateVal = timeDate.ToString();
                if (timeDate == e.Start.Date)
                {

                    lsthrmfiles.Items.Add(filenames[i] + "    |   " + path[i]);


                }

            }


        }



        int rowindex = 0;


        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            //to get the index of the selected row 
            rowindex = e.RowIndex; 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
