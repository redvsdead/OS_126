using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OS_126
{
    class Reader
    {
        Random rand = new Random();
        public event Action<string, int> Action;
        Thread thread;
        Buffer buf;
        byte bufNum;

        public Reader(byte _bufNum, Buffer _buf)
        {
            buf = _buf;
            bufNum = _bufNum;
            thread = new Thread(Run);
            thread.IsBackground = true;
            thread.Start();
        }

        public string ReadMessage()
        {
            string message = buf.tryRead();
            string res;
            if (message != "")
            {
                res = "Читатель " + bufNum + " прочитал сообщение в " + bufNum + "-м буфере: \'" + message + "\'";
            }
            else
            {
                res = "Читатель " + bufNum + ": " + bufNum + "-й буфер пуст ";
            }
            return res;
        }

        void Run()
        {
            while (true)
            {
                Thread.Sleep(rand.Next(900, 1100));
                string res = ReadMessage();
                Action?.Invoke(res, buf.count);
            }
        }
    }
}
