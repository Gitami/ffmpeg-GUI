using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Threading;


namespace ffmpegGUI
{

    public partial class FFmpegGUI : Form
    {

        // *****************************************
        //  Global variables: START
        // *****************************************
        public static string cmdOutputstr;
        public static string validateErrorMsg;
        // *****************************************
        //  Global variables: END
        // *****************************************

        // *****************************************
        //  Global FILE NAME variables: START
        // *****************************************
        public static string txtFileSettingResolutions = "setting_resolutions.txt";
        public static string txtFileSettingAudiobitrates = "setting_audiobitrates.txt";
        public static string txtFileSettingFilters = "setting_filters.txt";
        public static string txtFileSettingFormats = "setting_formats.txt";
        public static string txtFileLogError = "log_error.txt";
        public static string txtFileLogOutput = "log_output.txt";
        // *****************************************
        //  Global FILE NAME variables: END
        // *****************************************


        // *****************************************
        // INIT++: START
        // *****************************************
        public FFmpegGUI()
        {
            InitializeComponent();


            // ********** LOADING RESOLUTIONS ************

            try
            {
                using (StreamReader sr = new StreamReader(txtFileSettingResolutions)) // Create an instance of StreamReader to read from a file. The using statement also closes the StreamReader.
                {
                    String line;
                    while ((line = sr.ReadLine()) != null) // Read and display lines from the file until the end of the file is reached.
                    {
                        boxOutputResolution.Items.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                string errmsg = "The file could not be read: " + txtFileSettingResolutions + ". ERROR: " + e.Message;
                writeToTxtFile(txtFileLogError, errmsg);
            }


            // ********** LOADING AUDIO BITRATES ************

            try
            {
                using (StreamReader sr = new StreamReader(txtFileSettingAudiobitrates)) // Create an instance of StreamReader to read from a file. The using statement also closes the StreamReader.
                {
                    String line;
                    while ((line = sr.ReadLine()) != null) // Read and display lines from the file until the end of the file is reached.
                    {
                        boxOutputAudiobitrate.Items.Add(line);
                    }
                }
            }
            catch (Exception e)
            {
                string errmsg = "The file could not be read: " + txtFileSettingAudiobitrates + ". ERROR: " + e.Message;
                writeToTxtFile(txtFileLogError, errmsg);
            }


            // ********** LOADING FILTERS ************

            try
            {
                using (StreamReader sr = new StreamReader(txtFileSettingFilters))
                {
                    var items = new BindingList<KeyValuePair<string, string>>();
                    for (; ; )  // This loop has only one exit.
                    {
                        string line = sr.ReadLine();

                        if (line == null)
                            break;

                        string[] splitLines = line.Split(new char[] { '|' });

                        items.Add(new KeyValuePair<string, string>(splitLines[0], splitLines[1]));

                    }
                    boxFilter.DataSource = items;
                    boxFilter.ValueMember = "Key";
                    boxFilter.DisplayMember = "Value";
                }
            }
            catch (Exception e)
            {
                string errmsg = "The file could not be read: " + txtFileSettingFilters + ". ERROR: " + e.Message;
                writeToTxtFile(txtFileLogError, errmsg);
            }

            // ********** LOADING FORMATS ************

            try
            {
                using (StreamReader sr = new StreamReader(txtFileSettingFormats))
                {
                    var items = new BindingList<KeyValuePair<string, string>>();
                    for (; ; )  // This loop has only one exit.
                    {
                        string line = sr.ReadLine();

                        if (line == null)
                            break;

                        string[] splitLines = line.Split(new char[] { '|' });

                        items.Add(new KeyValuePair<string, string>(splitLines[0], splitLines[0] + " (" + splitLines[1] + ")"));

                    }
                    boxOutputformat.DataSource = items;
                    boxOutputformat.ValueMember = "Key";
                    boxOutputformat.DisplayMember = "Value";
                }
            }
            catch (Exception e)
            {
                string errmsg = "The file could not be read: " + txtFileSettingFormats + ". ERROR: " + e.Message;
                writeToTxtFile(txtFileLogError, errmsg);
            }

        }
        // *****************************************
        // INIT++: END
        // *****************************************


        // *****************************************
        // Slider and Slide-counter: START
        // *****************************************
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            boxQualityNumeric.Value = boxQualitySlider.Value;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            boxQualitySlider.Value = (int)boxQualityNumeric.Value;
        }
        // *****************************************
        // Slider and Slide-counter: END
        // *****************************************



        // *****************************************
        // Run Button: START
        // *****************************************
        private void button1_Click(object sender, EventArgs e)
        {

            validateErrorMsg = "";
            if (validateForm() == true)
            {

                // Building CMD command
                cmdOutputstr = "ffmpeg"
                                        + " -i " + "\"" + boxInputFilepath.Text + "\""
                                        + " -crf " + boxQualityNumeric.Value
                                        + " -preset " + "\"" + boxSpeed.Text + "\""
                                        + " -s " + boxOutputResolution.Text
                                        + " -vf " + "\"" + boxFilter.SelectedValue.ToString() + "\""
                                        + " -f " + boxOutputformat.SelectedValue.ToString()
                                        + " -ab " + boxOutputAudiobitrate.Text
                                        + " " + "\"" + boxOutputFilename.Text + "\""
                                        ;

                StatusOutputLabel.Text = "Running..."; // update label
                Application.DoEvents(); // force label update now!


                try
                {

                    ProcessStartInfo ProcessInfo;
                    Process Process;
                    ProcessInfo = new ProcessStartInfo("cmd.exe", "/K " + cmdOutputstr);
                    Process = Process.Start(ProcessInfo);

                    string runtimelog = "Running:" + "\r\n" + cmdOutputstr;
                    writeToTxtFile(txtFileLogOutput, runtimelog);
                }
                catch
                {
                    string errmsg = "Unable to start the command prompt";
                    writeToTxtFile(txtFileLogError, errmsg);
                }

                cmdOutputstr = ""; // clear variable

                Thread.Sleep(1000);

                StatusOutputLabel.Text = "Ready again!"; // reset label

            }
            else {

                StatusOutputLabel.Text = "Missing: " + validateErrorMsg; // reset label
                Application.DoEvents();
            
            }

        }
        // *****************************************
        // Run Button: END
        // *****************************************


        // *****************************************
        // ValidateForm: START
        // *****************************************
        private bool validateForm()
        {

            if (boxInputFilepath.Text == null || boxInputFilepath.Text.Length == 0)
                validateErrorMsg += " Input File,";

            if (boxSpeed.Text == null || boxSpeed.Text.Length == 0)
                validateErrorMsg += " Speed,";

            if (boxOutputResolution.Text == null || boxOutputResolution.Text.Length == 0)
                validateErrorMsg += " Resolution,";

            if (boxFilter.SelectedValue.ToString() == null || boxFilter.SelectedValue.ToString().Length == 0)
                validateErrorMsg += " Filter,";

            if (boxOutputformat.SelectedValue.ToString() == null || boxOutputformat.SelectedValue.ToString().Length == 0)
                validateErrorMsg += " Format,";

            if (boxOutputAudiobitrate.Text == null || boxOutputAudiobitrate.Text.Length == 0)
                validateErrorMsg += " bitRate,";

            if (boxOutputFilename.Text == null || boxOutputFilename.Text.Length == 0)
                validateErrorMsg += " Filename,";

            if (validateErrorMsg == "")
                return true;
            else
                return false;
        }


        // *****************************************
        // ValidateForm: END
        // *****************************************


        // *****************************************
        // LOG FILE: START
        // *****************************************
        public static void writeToTxtFile(string logfilename, string filecontent)
        {
            using (StreamWriter w = File.AppendText(logfilename))
            {
                Log(filecontent, w); // Write a line
                w.Close(); // Close the writer and underlying file.
            }
            // Open and read the file.
            using (StreamReader r = File.OpenText(logfilename))
            {
                DumpLog(r);
            }
        }

        public static void Log(string logMessage, TextWriter w)
        {
            w.Write("\r\nLog Entry : ");
            w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                DateTime.Now.ToLongDateString());
            w.WriteLine("  :");
            w.WriteLine("  :{0}", logMessage);
            w.WriteLine("-------------------------------");
            // Update the underlying file.
            w.Flush();
        }

        public static void DumpLog(StreamReader r)
        {
            // While not at the end of the file, read and write lines.
            string line;
            while ((line = r.ReadLine()) != null)
            {
                Console.WriteLine(line);
            }
            r.Close();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 2;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                boxInputFilepath.Text = openFileDialog1.FileName;
            }

        }
        // *****************************************
        // LOG FILE: END
        // *****************************************


    }
}
