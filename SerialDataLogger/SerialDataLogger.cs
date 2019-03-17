using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SerialDataLogger
{
    public partial class SerialDataLogger : Form
    {
        private SerialStream m_serialStream;
        public SerialDataLogger()
        {
            InitializeComponent();
            m_serialPortListCombo.Items.AddRange(GetPorts());
            m_baudRateComboList.Items.AddRange(GetSerialBaudRates());
        }

        private void m_connectBtn_Click(object sender, EventArgs e)
        {
            m_serialStream = new SerialStream(m_serialPortListCombo.SelectedItem.ToString(), Convert.ToInt32(m_baudRateComboList.SelectedItem.ToString()));
           //m_serialPort.DataReceived += SerialPort_DataReceived;
           // m_serialPort.ErrorReceived += SerialPort_ErrorReceived;
        }

        public static string[] GetSerialBaudRates()
        {
            return new string[] { "9600", "38400", "57600", "115200" };
        }

        public static string[] GetPorts()
        {
            return SerialPort.GetPortNames();
        }

    }
}
