namespace OS_126
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buf2max = new System.Windows.Forms.TextBox();
            this.buf2cur = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buf1max = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buf1cur = new System.Windows.Forms.TextBox();
            this.buf2Logs = new System.Windows.Forms.TextBox();
            this.buf1Logs = new System.Windows.Forms.TextBox();
            this.richBuf1 = new System.Windows.Forms.RichTextBox();
            this.richBuf2 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(571, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Макс. размер:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(571, 402);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 17);
            this.label4.TabIndex = 23;
            this.label4.Text = "Сейчас занято:";
            // 
            // buf2max
            // 
            this.buf2max.Location = new System.Drawing.Point(706, 453);
            this.buf2max.Name = "buf2max";
            this.buf2max.ReadOnly = true;
            this.buf2max.Size = new System.Drawing.Size(70, 22);
            this.buf2max.TabIndex = 22;
            // 
            // buf2cur
            // 
            this.buf2cur.Location = new System.Drawing.Point(706, 402);
            this.buf2cur.Name = "buf2cur";
            this.buf2cur.ReadOnly = true;
            this.buf2cur.Size = new System.Drawing.Size(70, 22);
            this.buf2cur.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(571, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 20;
            this.label1.Text = "Макс. размер:";
            // 
            // buf1max
            // 
            this.buf1max.Location = new System.Drawing.Point(706, 63);
            this.buf1max.Name = "buf1max";
            this.buf1max.ReadOnly = true;
            this.buf1max.Size = new System.Drawing.Size(70, 22);
            this.buf1max.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(571, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Сейчас занято:";
            // 
            // buf1cur
            // 
            this.buf1cur.Location = new System.Drawing.Point(706, 12);
            this.buf1cur.Name = "buf1cur";
            this.buf1cur.ReadOnly = true;
            this.buf1cur.Size = new System.Drawing.Size(70, 22);
            this.buf1cur.TabIndex = 17;
            // 
            // buf2Logs
            // 
            this.buf2Logs.Location = new System.Drawing.Point(12, 402);
            this.buf2Logs.Multiline = true;
            this.buf2Logs.Name = "buf2Logs";
            this.buf2Logs.ReadOnly = true;
            this.buf2Logs.Size = new System.Drawing.Size(515, 360);
            this.buf2Logs.TabIndex = 16;
            // 
            // buf1Logs
            // 
            this.buf1Logs.Location = new System.Drawing.Point(12, 12);
            this.buf1Logs.Multiline = true;
            this.buf1Logs.Name = "buf1Logs";
            this.buf1Logs.ReadOnly = true;
            this.buf1Logs.Size = new System.Drawing.Size(515, 368);
            this.buf1Logs.TabIndex = 15;
            // 
            // richBuf1
            // 
            this.richBuf1.Location = new System.Drawing.Point(12, 12);
            this.richBuf1.Name = "richBuf1";
            this.richBuf1.Size = new System.Drawing.Size(515, 368);
            this.richBuf1.TabIndex = 25;
            this.richBuf1.Text = "";
            // 
            // richBuf2
            // 
            this.richBuf2.Location = new System.Drawing.Point(12, 399);
            this.richBuf2.Name = "richBuf2";
            this.richBuf2.Size = new System.Drawing.Size(515, 368);
            this.richBuf2.TabIndex = 26;
            this.richBuf2.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 809);
            this.Controls.Add(this.richBuf2);
            this.Controls.Add(this.richBuf1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buf2max);
            this.Controls.Add(this.buf2cur);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buf1max);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buf1cur);
            this.Controls.Add(this.buf2Logs);
            this.Controls.Add(this.buf1Logs);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox buf2max;
        private System.Windows.Forms.TextBox buf2cur;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox buf1max;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox buf1cur;
        private System.Windows.Forms.TextBox buf2Logs;
        private System.Windows.Forms.TextBox buf1Logs;
        private System.Windows.Forms.RichTextBox richBuf1;
        private System.Windows.Forms.RichTextBox richBuf2;
    }
}

