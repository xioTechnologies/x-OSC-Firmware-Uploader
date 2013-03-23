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

namespace x_OSC_Firmware_Uploader
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.Text = Assembly.GetExecutingAssembly().GetName().Name + " " + Assembly.GetExecutingAssembly().GetName().Version.Major.ToString() + "." + Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString();
            foreach (string portName in System.IO.Ports.SerialPort.GetPortNames())
            {
                comboBoxSerialPort.Items.Add(portName);
            }
            comboBoxSerialPort.SelectedIndex = 0;
        }

        private void button_browse_Click(object sender, EventArgs e)
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

        private void button_upload_Click(object sender, EventArgs e)
        {
            ProcessStartInfo processInfo = new ProcessStartInfo("ds30LoaderConsole.exe");
            processInfo.Arguments = "\"-f=" + textBoxHexFile.Text + "\"" +
                                    " -d=dsPIC33EP512MC806 " +
                                    "\"-k=" + comboBoxSerialPort.Text + "\"" +
                                    " -r=115200 --writef --ht=30000 --polltime=100 --timeout=3000 -o";
            processInfo.UseShellExecute = false;
            Process process = Process.Start(processInfo);
            process.WaitForExit();
            process.Close();
            this.Close();
        }
    }
}
