using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OS_126
{
    class Writer 
    {
        Random rand = new Random();
        public event Action<string, int> Action;
        Thread thread;
        Buffer buf;
        byte bufNum;
        int count = 0;

        public Writer(byte _bufNum, Buffer _buf)
        {
            buf = _buf;
            bufNum = _bufNum;
            thread = new Thread(Run);
            thread.IsBackground = true;
            thread.Start();

        }

        public string WriteMessage()
        {
            count++;
            string ms = "Сообщение " + count + " от писателя " + bufNum + " в " + bufNum + "-й буфер";
            if (!buf.tryWrite(ms)) 
                ms+=" не было доставлено, так как " + bufNum +  "-й буфер полон";
            return ms;
        }

        void Run()
        {
            while (true)
            {
                Thread.Sleep(rand.Next(500, 700));
                string res = WriteMessage();
                Action?.Invoke(res, buf.count);    
            }
        }
        
    }
}
