using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialDataLogger
{
    public class SerialStream : Stream
    {
        private SerialPort m_serialPort;

        public SerialStream(string portName, int baudRate)
        {
            m_serialPort = new SerialPort(portName, baudRate, Parity.None, 8, StopBits.One);
            m_serialPort.Handshake = Handshake.None;
            m_serialPort.RtsEnable = true;
            m_serialPort.DtrEnable = true;
            m_serialPort.DataReceived += SerialPort_DataReceived;
            m_serialPort.ErrorReceived += SerialPort_ErrorReceived;
        }

        public override void Accept()
        {
            Open();
        }

        public override void Open()
        {
            m_serialPort.Open();
        }

        public override bool IsOpen()
        {
            return m_serialPort.IsOpen;
        }

        public override void Close()
        {
            if (m_serialPort.IsOpen)
            {
                m_serialPort.Close();
            }
        }

        public override int Read(byte[] buffer, int offset, int count)
        {
            try
            {
                count = Math.Min(count, m_serialPort.BytesToRead);
                return m_serialPort.Read(buffer, offset, count);
            }
            catch (Exception ex)
            {
                //throw exception here
            }
            return 0;
        }

        public override void Write(byte[] buffer, int offset, int count)
        {
            try
            {
                m_serialPort.Write(buffer, offset, count);
            }
            catch (Exception ex)
            {

            }
        }

        void SerialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            OnDataReceived(EventArgs.Empty);
        }

        void SerialPort_ErrorReceived(object sender, SerialErrorReceivedEventArgs e)
        {

        }

    }
}
