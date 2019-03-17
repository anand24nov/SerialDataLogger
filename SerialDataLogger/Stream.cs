using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerialDataLogger
{
    public abstract class Stream
    {
        public abstract void Accept();
        public abstract void Open();
        public abstract bool IsOpen();
        public abstract void Close();
        public abstract int Read(byte[] buffer, int offset, int count);
        public abstract void Write(byte[] buffer, int offset, int count);

        public event EventHandler Closed;

        protected void OnClosed(EventArgs e)
        {
            EventHandler handler = Closed;
            if (null != handler)
            {
                handler(this, e);
            }
        }

        public event EventHandler DataReceived;

        protected void OnDataReceived(EventArgs e)
        {
            EventHandler handler = DataReceived;
            if (null != handler)
            {
                handler(this, e);
            }
        }

    }
}
