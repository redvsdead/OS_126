using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

/*
 * Задача 126
 * 1 -- стек
 * 2 -- семафоры/мьютексы
 * 6 -- 2 пары читатель-писатель используют разные буферы
 */

namespace OS_126
{
    public partial class Form1 : Form
    {
        Buffer buf1, buf2;
        Writer writer1, writer2;
        Reader reader1, reader2;

        public Form1(Buffer _buf1, Buffer _buf2)
        {
            InitializeComponent();
            buf1 = _buf1;
            buf2 = _buf2;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.buf1cur.Text = "0";
            this.buf1max.Text = Buffer.maxCount.ToString();
            this.buf2cur.Text = "0";
            this.buf2max.Text = Buffer.maxCount.ToString();

            writer1 = new Writer(1, buf1);
            writer2 = new Writer(2, buf2);
            reader1 = new Reader(1, buf1);
            reader2 = new Reader(2, buf2);

            writer1.Action += writer1Action;
            reader1.Action += reader1Action;
            writer2.Action += writer2Action;
            reader2.Action += reader2Action;

        }

        private void reader1Action(string arg1, int arg2)
        {
            richBuf1.Invoke(new Action(() => { richBuf1.Text += arg1 + Environment.NewLine; }));
            buf1cur.Invoke(new Action(() => buf1cur.Text = arg2.ToString()));
        }

        private void writer1Action(string arg1, int arg2)
        {
            richBuf1.Invoke(new Action(() => richBuf1.Text += arg1 + Environment.NewLine));
            buf1cur.Invoke(new Action(() => buf1cur.Text = arg2.ToString()));
        }

        private void reader2Action(string arg1, int arg2)
        {

            richBuf2.Invoke(new Action(() => { richBuf2.Text += arg1 + Environment.NewLine; }));
            buf2cur.Invoke(new Action(() => buf2cur.Text = arg2.ToString()));
        }

        private void writer2Action(string arg1, int arg2)
        {
            richBuf2.Invoke(new Action(() => richBuf2.Text += arg1 + Environment.NewLine));
            buf2cur.Invoke(new Action(() => buf2cur.Text = arg2.ToString()));
        }
    }
}
