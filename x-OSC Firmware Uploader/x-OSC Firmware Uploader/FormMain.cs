using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO.Ports;
using System.IO;
using System.Diagnostics;
using System.Threading;

namespace x_OSC_Firmware_Uploader
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Constructor.
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
        }

        /// <summary>
        /// FormMain Load event to set form caption and initial control values.
        /// </summary>
        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = Assembly.GetExecutingAssembly().GetName().Name + " " + Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." + Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString();
            refreshSerialPortList();
            if (comboBoxSerialPort.Items.Count > 0)
            {
                comboBoxSerialPort.SelectedItem = comboBoxSerialPort.Items[0];
            }
        }

        /// <summary>
        /// comboBoxSerialPort DropDown event to refresh serial port list.
        /// </summary>
        private void comboBoxSerialPort_DropDown(object sender, EventArgs e)
        {
            refreshSerialPortList();
        }

        /// <summary>
        /// refresh serial port list in comboBox.
        /// </summary>
        private void refreshSerialPortList()
        {
            comboBoxSerialPort.Items.Clear();
            foreach (string portName in System.IO.Ports.SerialPort.GetPortNames())
            {
                comboBoxSerialPort.Items.Add(portName);
            }
        }

        /// <summary>
        /// buttonBrowse Click event to open file browser dialogue.
        /// </summary>
        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Select Firmware Hex File";
            openFileDialog.Filter = "Hex Files|*.hex";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                textBoxHexFile.Text = openFileDialog.FileName.ToString();
            }
            buttonUpload.Enabled = File.Exists(textBoxHexFile.Text);
        }

        /// <summary>
        /// buttonUpload Click event to start upload.
        /// </summary>
        private void buttonUpload_Click(object sender, EventArgs e)
        {
            // Disable form controls
            foreach (Control control in Controls)
            {
                control.Enabled = false;
            }
            buttonUpload.Text = "Uploading...";

            // Upload hex files
            do
            {
                if (checkBoxCleanUpload.CheckState == CheckState.Checked)
                {
                    if (uploadFirmware("empty.hex", true) == -1)
                    {
                        break;
                    }
                    Thread.Sleep(3500);
                }
                uploadFirmware(textBoxHexFile.Text, false);
            } while (false);

            // Enable form controls
            foreach (Control control in Controls)
            {
                control.Enabled = true;
            }
            buttonUpload.Text = "Upload";
        }

        /// <summary>
        /// Uploads firmware hex file.
        /// </summary>
        /// <param name="filePath">
        /// File path of hex file.
        /// </param>
        /// <returns>
        /// ExitCode.
        /// </returns>
        private int uploadFirmware(string filePath, bool noGotoApp)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("ds30LoaderConsole.exe");
            processInfo.Arguments = "\"-f=" + filePath + "\"" +
                                    " -d=dsPIC33EP512MC806 " +
                                    "\"-k=" + comboBoxSerialPort.Text + "\"" +
                                    " -r=115200 --writef" +
                                    (noGotoApp ? " --no-goto-app" : "") +
                                    " --ht=30000 --polltime=100 --timeout=3000 -o";
            processInfo.UseShellExecute = false;
            Process process = Process.Start(processInfo);
            process.WaitForExit();
            if (process.ExitCode == -1)
            {
                MessageBox.Show("Upload failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return process.ExitCode;
        }
    }
}
