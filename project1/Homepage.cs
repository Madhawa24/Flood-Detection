using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace project1
{
    public partial class Homepage : Form
    {
        private SerialPort serialPort;
        // Clock related fields for connectivity time**
        private DateTime connectionStartTime;
        private Timer connectionTimer;


        public Homepage()
        {
            InitializeComponent();
            // Initialize the Timer for displaying connection time**
            connectionTimer = new Timer();
            connectionTimer.Interval = 1000; // Update every second
            //connectionTimer.Tick += ConnectionTimer_Tick;
            connectionTimer.Tick += new EventHandler(ConnectionTimer_Tick);
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            string selectedPort = cmb_port.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(selectedPort))
            {
                try
                {
                    // Initialize and configure the SerialPort
                    serialPort = new SerialPort(selectedPort);
                    serialPort.BaudRate = 9600;  // Set baud rate or other necessary configurations

                    // Open the serial port
                    serialPort.Open();

                    lbl_status.Text = "Connected to " + selectedPort;
                    serialPort.DataReceived += SerialPort_DataReceived; // Ensure the DataReceived event is hooked up
                   
                    // Record connection start time and start the timer**
                    connectionStartTime = DateTime.Now;
                    connectionTimer.Start();
                }
                catch (Exception ex)
                {
                    lbl_status.Text = "Error: " + ex.Message;
                }
            }
            else
            {
                lbl_status.Text = "Please select a COM port.";
            }
        }
        // Timer event to update connection time
        private void ConnectionTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - connectionStartTime;
            lbl_ststustime.Text = $" {elapsedTime.Hours:D2}:{elapsedTime.Minutes:D2}:{elapsedTime.Seconds:D2}";
        }

        // Event handler for receiving data
        private void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try
            {
                // Read the incoming data
                string data = serialPort.ReadLine();  // Assuming the data comes in as lines

                // Process the data (assuming it's in a known format like "TEMP:25;HUM:60")
                this.Invoke(new Action(() =>
                {
                    ParseAndDisplayData(data);  // Update UI safely using Invoke
                }));
            }
            catch (Exception ex)
            {
                this.Invoke(new Action(() =>
                {
                    lbl_statsens.Text = "Read Error: " + ex.Message;
                }));
            }
        }

        // Method to parse data and update labels
        private void ParseAndDisplayData(string data)
        {
            // Assume data comes in the format "TEMP:25;HUM:60;SPEED:5"
            string[] readings = data.Split(';');

            foreach (string reading in readings)
            {
                if (reading.StartsWith("TEMP:"))
                {
                    float temperature = float.Parse(reading.Replace("TEMP:", ""));
                    lbl_temp.Text = "Temperature: " + temperature + " °C";
                    
                }
            }
        }

  

        private void lbl_connect_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_selectedp.Text = cmb_port.Text;
        }

        private void Homepage_Load(object sender, EventArgs e)
        {
            // Get available COM ports
            string[] ports = SerialPort.GetPortNames();

            // Populate ComboBox with COM ports
            cmb_port.Items.AddRange(ports);
        }

        private void lbl_selectedp_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void lbl_temp_Click(object sender, EventArgs e)
        {

        }

        private void lbl_speed_Click(object sender, EventArgs e)
        {

        }

        private void lbl_hum_Click(object sender, EventArgs e)
        {

        }

        private void lbl_statsens_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
