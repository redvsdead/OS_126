using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace OS_126
{
    public class Buffer
    {
        Stack<string> Messages { get; set; }
        public static int maxCount = 5;
        //семафоры для чтения и записи, начинаем с чтения, тк изначально буфер пуст
        Semaphore canWrite = new Semaphore(maxCount, maxCount);
        Semaphore canRead = new Semaphore(0, maxCount);
        Mutex mutex = new Mutex();
        public int count => Messages.Count;

        public Buffer()
        {
            Messages = new Stack<string>();
        }

        public bool tryWrite(string mesage)
        {
            bool res = false;
            //если есть место, пишем что нибудь
            canWrite.WaitOne();
            mutex.WaitOne();
            Messages.Push(mesage);
            res = true;
            mutex.ReleaseMutex();
            canRead.Release();
            return res;
        }

        public string tryRead()
        {
            string result = "";
            //читаем, если есть что
            canRead.WaitOne();
            mutex.WaitOne();
            result = Messages.Pop();
            mutex.ReleaseMutex();
            canWrite.Release();
            return result;
        }
    }
}
