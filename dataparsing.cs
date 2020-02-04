using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
namespace CycleApplication
{
    class dataparsing
    {

       static List<double> heartrate = new List<double>();
       static List<double> speed = new List<double>();
       static List<double> altitude = new List<double>();
       static List<double> power = new List<double>();
       static List<double> cadence = new List<double>();
       int[] hr = new int[5000];
       int[] sp = new int[5000];
       int[] cad = new int[5000];
       int[] alt = new int[5000];
       int[] pow = new int[5000];
       int[] pb = new int[5000];

       static IDictionary<string, string> IDict = new Dictionary<string, string>();

        
        

        public static Tuple<List<double>,List<double>,List<double>,List<double>,List<double>> retrieve()
        {
            string fileName = values.fileloc;
            heartrate.Clear();
            speed.Clear();
            cadence.Clear();
            altitude.Clear();
            power.Clear();
            try
            {
                bool isData = false;
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    int i = 0;
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
                       
                        i++;
                    }



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Tuple.Create(heartrate, speed, cadence, altitude, power);

          
        }


        public  void HRDATA()
        {
            string fileName = values.fileloc;
          
            try
            {
                bool isData = false;
                using (StreamReader sr = new StreamReader("ASDBExampleCycleComputerData.hrm"))
                {
                    string line;
                    int i = 0;
                  
                    while ((line = sr.ReadLine()) != null)
                    {
                     
                        if (isData)
                        {
                            string[] hrdata = line.Split('\t');

                            hr[i] = Convert.ToInt32(hrdata[0]);

                            sp[i] = int.Parse(hrdata[1]);

                            cad[i] = int.Parse(hrdata[2]);
                            alt[i] = int.Parse(hrdata[3]);
                            pow[i] = int.Parse(hrdata[4]);
                            pb[i] = int.Parse(hrdata[5]);

                            i++;

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
            


        }


        // Properties storing parsed data - get only
        public int[] Speed
        {
            get { return sp; }
        }

        public int[] Cadence
        {
            get { return cad; }
        }

        public int[] Altitude
        {
            get { return alt; }
        }

        public int[] Power
        {
            get { return pow; }
        }

        public int[] PowerBalance
        {
            get { return pb; }
        }

        public static IDictionary<string, string> Header()
        {
            string fileName = values.fileloc;
            IDict.Clear();
            try
            {
                bool isHeader = false;
                using (StreamReader sr = new StreamReader(fileName))
                {
                    string line;
                    int i = 0;
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
                    
                       
                        if (line == "[Params]")
                        {
                            isHeader = true;
                        }
                        i++;
                    }



                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return IDict;
        }

      

       
    }
}
    
