
namespace Lab05_kurs_3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tInFilePath = new System.Windows.Forms.TextBox();
            this.tOutFilePath = new System.Windows.Forms.TextBox();
            this.blnFile = new System.Windows.Forms.Button();
            this.bOutFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rB_SHA512 = new System.Windows.Forms.RadioButton();
            this.rB_SHA384 = new System.Windows.Forms.RadioButton();
            this.rB_SHA256 = new System.Windows.Forms.RadioButton();
            this.rB_SHA1 = new System.Windows.Forms.RadioButton();
            this.rB_MD5 = new System.Windows.Forms.RadioButton();
            this.rB_RIPEMD160 = new System.Windows.Forms.RadioButton();
            this.rB_HAVAL = new System.Windows.Forms.RadioButton();
            this.rB_CRC32 = new System.Windows.Forms.RadioButton();
            this.bStart = new System.Windows.Forms.Button();
            this.bClean = new System.Windows.Forms.Button();
            this.label_3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label_time = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вхідний файл:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Вихідний файл:";
            // 
            // tInFilePath
            // 
            this.tInFilePath.Location = new System.Drawing.Point(125, 15);
            this.tInFilePath.Name = "tInFilePath";
            this.tInFilePath.Size = new System.Drawing.Size(301, 22);
            this.tInFilePath.TabIndex = 2;
            // 
            // tOutFilePath
            // 
            this.tOutFilePath.Location = new System.Drawing.Point(125, 41);
            this.tOutFilePath.Name = "tOutFilePath";
            this.tOutFilePath.Size = new System.Drawing.Size(301, 22);
            this.tOutFilePath.TabIndex = 3;
            // 
            // blnFile
            // 
            this.blnFile.Location = new System.Drawing.Point(432, 15);
            this.blnFile.Name = "blnFile";
            this.blnFile.Size = new System.Drawing.Size(34, 23);
            this.blnFile.TabIndex = 4;
            this.blnFile.Text = "...";
            this.blnFile.UseVisualStyleBackColor = true;
            this.blnFile.Click += new System.EventHandler(this.blnFile_Click);
            // 
            // bOutFile
            // 
            this.bOutFile.Location = new System.Drawing.Point(432, 39);
            this.bOutFile.Name = "bOutFile";
            this.bOutFile.Size = new System.Drawing.Size(34, 22);
            this.bOutFile.TabIndex = 5;
            this.bOutFile.Text = "...";
            this.bOutFile.UseVisualStyleBackColor = true;
            this.bOutFile.Click += new System.EventHandler(this.bOutFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rB_SHA512);
            this.groupBox1.Controls.Add(this.rB_SHA384);
            this.groupBox1.Controls.Add(this.rB_SHA256);
            this.groupBox1.Controls.Add(this.rB_SHA1);
            this.groupBox1.Controls.Add(this.rB_MD5);
            this.groupBox1.Controls.Add(this.rB_RIPEMD160);
            this.groupBox1.Controls.Add(this.rB_HAVAL);
            this.groupBox1.Controls.Add(this.rB_CRC32);
            this.groupBox1.Location = new System.Drawing.Point(13, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 149);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Режим роботи:";
            // 
            // rB_SHA512
            // 
            this.rB_SHA512.AutoSize = true;
            this.rB_SHA512.Location = new System.Drawing.Point(117, 119);
            this.rB_SHA512.Name = "rB_SHA512";
            this.rB_SHA512.Size = new System.Drawing.Size(86, 21);
            this.rB_SHA512.TabIndex = 7;
            this.rB_SHA512.TabStop = true;
            this.rB_SHA512.Text = "SHA-512";
            this.rB_SHA512.UseVisualStyleBackColor = true;
            // 
            // rB_SHA384
            // 
            this.rB_SHA384.AutoSize = true;
            this.rB_SHA384.Location = new System.Drawing.Point(117, 92);
            this.rB_SHA384.Name = "rB_SHA384";
            this.rB_SHA384.Size = new System.Drawing.Size(86, 21);
            this.rB_SHA384.TabIndex = 6;
            this.rB_SHA384.TabStop = true;
            this.rB_SHA384.Text = "SHA-384";
            this.rB_SHA384.UseVisualStyleBackColor = true;
            // 
            // rB_SHA256
            // 
            this.rB_SHA256.AutoSize = true;
            this.rB_SHA256.Location = new System.Drawing.Point(117, 64);
            this.rB_SHA256.Name = "rB_SHA256";
            this.rB_SHA256.Size = new System.Drawing.Size(86, 21);
            this.rB_SHA256.TabIndex = 5;
            this.rB_SHA256.TabStop = true;
            this.rB_SHA256.Text = "SHA-256";
            this.rB_SHA256.UseVisualStyleBackColor = true;
            // 
            // rB_SHA1
            // 
            this.rB_SHA1.AutoSize = true;
            this.rB_SHA1.Location = new System.Drawing.Point(118, 36);
            this.rB_SHA1.Name = "rB_SHA1";
            this.rB_SHA1.Size = new System.Drawing.Size(70, 21);
            this.rB_SHA1.TabIndex = 4;
            this.rB_SHA1.TabStop = true;
            this.rB_SHA1.Text = "SHA-1";
            this.rB_SHA1.UseVisualStyleBackColor = true;
            // 
            // rB_MD5
            // 
            this.rB_MD5.AutoSize = true;
            this.rB_MD5.Location = new System.Drawing.Point(4, 120);
            this.rB_MD5.Name = "rB_MD5";
            this.rB_MD5.Size = new System.Drawing.Size(58, 21);
            this.rB_MD5.TabIndex = 3;
            this.rB_MD5.TabStop = true;
            this.rB_MD5.Text = "MD5";
            this.rB_MD5.UseVisualStyleBackColor = true;
            // 
            // rB_RIPEMD160
            // 
            this.rB_RIPEMD160.AutoSize = true;
            this.rB_RIPEMD160.Location = new System.Drawing.Point(5, 92);
            this.rB_RIPEMD160.Name = "rB_RIPEMD160";
            this.rB_RIPEMD160.Size = new System.Drawing.Size(105, 21);
            this.rB_RIPEMD160.TabIndex = 2;
            this.rB_RIPEMD160.TabStop = true;
            this.rB_RIPEMD160.Text = "RIPEMD160";
            this.rB_RIPEMD160.UseVisualStyleBackColor = true;
            // 
            // rB_HAVAL
            // 
            this.rB_HAVAL.AutoSize = true;
            this.rB_HAVAL.Location = new System.Drawing.Point(5, 64);
            this.rB_HAVAL.Name = "rB_HAVAL";
            this.rB_HAVAL.Size = new System.Drawing.Size(74, 21);
            this.rB_HAVAL.TabIndex = 1;
            this.rB_HAVAL.TabStop = true;
            this.rB_HAVAL.Text = "HAVAL";
            this.rB_HAVAL.UseVisualStyleBackColor = true;
            // 
            // rB_CRC32
            // 
            this.rB_CRC32.AutoSize = true;
            this.rB_CRC32.Location = new System.Drawing.Point(6, 36);
            this.rB_CRC32.Name = "rB_CRC32";
            this.rB_CRC32.Size = new System.Drawing.Size(73, 21);
            this.rB_CRC32.TabIndex = 0;
            this.rB_CRC32.TabStop = true;
            this.rB_CRC32.Text = "CRC32";
            this.rB_CRC32.UseVisualStyleBackColor = true;
            // 
            // bStart
            // 
            this.bStart.Location = new System.Drawing.Point(262, 226);
            this.bStart.Name = "bStart";
            this.bStart.Size = new System.Drawing.Size(96, 23);
            this.bStart.TabIndex = 7;
            this.bStart.Text = "Виконати";
            this.bStart.UseVisualStyleBackColor = true;
            this.bStart.Click += new System.EventHandler(this.bStart_Click);
            // 
            // bClean
            // 
            this.bClean.Location = new System.Drawing.Point(378, 226);
            this.bClean.Name = "bClean";
            this.bClean.Size = new System.Drawing.Size(88, 23);
            this.bClean.TabIndex = 8;
            this.bClean.Text = "Очистити";
            this.bClean.UseVisualStyleBackColor = true;
            this.bClean.Click += new System.EventHandler(this.bClean_Click);
            // 
            // label_3
            // 
            this.label_3.AutoSize = true;
            this.label_3.Location = new System.Drawing.Point(259, 185);
            this.label_3.Name = "label_3";
            this.label_3.Size = new System.Drawing.Size(157, 17);
            this.label_3.TabIndex = 10;
            this.label_3.Text = "Тривалість кодування:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(262, 69);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 57);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Оцінка розміру (Мбайт):";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 17);
            this.label5.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Вхідного файлу:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Location = new System.Drawing.Point(262, 133);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(204, 49);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Оцінка розміру (Байти):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(135, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 17);
            this.label7.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Вхідного файлу:";
            // 
            // label_time
            // 
            this.label_time.AutoSize = true;
            this.label_time.Location = new System.Drawing.Point(259, 202);
            this.label_time.Name = "label_time";
            this.label_time.Size = new System.Drawing.Size(0, 17);
            this.label_time.TabIndex = 13;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(262, 185);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(204, 29);
            this.progressBar1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 257);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.label_time);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label_3);
            this.Controls.Add(this.bClean);
            this.Controls.Add(this.bStart);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bOutFile);
            this.Controls.Add(this.blnFile);
            this.Controls.Add(this.tOutFilePath);
            this.Controls.Add(this.tInFilePath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tInFilePath;
        private System.Windows.Forms.TextBox tOutFilePath;
        private System.Windows.Forms.Button blnFile;
        private System.Windows.Forms.Button bOutFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rB_SHA512;
        private System.Windows.Forms.RadioButton rB_SHA384;
        private System.Windows.Forms.RadioButton rB_SHA256;
        private System.Windows.Forms.RadioButton rB_SHA1;
        private System.Windows.Forms.RadioButton rB_MD5;
        private System.Windows.Forms.RadioButton rB_RIPEMD160;
        private System.Windows.Forms.RadioButton rB_HAVAL;
        private System.Windows.Forms.RadioButton rB_CRC32;
        private System.Windows.Forms.Button bStart;
        private System.Windows.Forms.Button bClean;
        private System.Windows.Forms.Label label_3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label_time;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

