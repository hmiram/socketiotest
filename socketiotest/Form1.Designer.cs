namespace socketiotest
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.rtLog = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.Label();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblDelegate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnS1Start = new System.Windows.Forms.Button();
            this.btnS2Start = new System.Windows.Forms.Button();
            this.lblS1Info = new System.Windows.Forms.Label();
            this.lblS2Info = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblDelegate2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Pripojit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rtLog
            // 
            this.rtLog.Location = new System.Drawing.Point(674, 38);
            this.rtLog.Name = "rtLog";
            this.rtLog.Size = new System.Drawing.Size(444, 364);
            this.rtLog.TabIndex = 1;
            this.rtLog.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.AutoSize = true;
            this.textBox1.Location = new System.Drawing.Point(952, 439);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(54, 15);
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "textBox1";
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(1040, 421);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(78, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblDelegate
            // 
            this.lblDelegate.AutoSize = true;
            this.lblDelegate.Location = new System.Drawing.Point(952, 473);
            this.lblDelegate.Name = "lblDelegate";
            this.lblDelegate.Size = new System.Drawing.Size(70, 15);
            this.lblDelegate.TabIndex = 4;
            this.lblDelegate.Text = "lblDelegate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "S1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "S2";
            // 
            // btnS1Start
            // 
            this.btnS1Start.Location = new System.Drawing.Point(26, 86);
            this.btnS1Start.Name = "btnS1Start";
            this.btnS1Start.Size = new System.Drawing.Size(75, 23);
            this.btnS1Start.TabIndex = 9;
            this.btnS1Start.Text = "S1 Start";
            this.btnS1Start.UseVisualStyleBackColor = true;
            this.btnS1Start.Click += new System.EventHandler(this.btnS1Start_Click);
            // 
            // btnS2Start
            // 
            this.btnS2Start.Location = new System.Drawing.Point(24, 91);
            this.btnS2Start.Name = "btnS2Start";
            this.btnS2Start.Size = new System.Drawing.Size(75, 23);
            this.btnS2Start.TabIndex = 10;
            this.btnS2Start.Text = "S2 Start";
            this.btnS2Start.UseVisualStyleBackColor = true;
            this.btnS2Start.Click += new System.EventHandler(this.btnS2Start_Click);
            // 
            // lblS1Info
            // 
            this.lblS1Info.AutoSize = true;
            this.lblS1Info.Location = new System.Drawing.Point(23, 57);
            this.lblS1Info.Name = "lblS1Info";
            this.lblS1Info.Size = new System.Drawing.Size(55, 15);
            this.lblS1Info.TabIndex = 11;
            this.lblS1Info.Text = "lblS1Info";
            // 
            // lblS2Info
            // 
            this.lblS2Info.AutoSize = true;
            this.lblS2Info.Location = new System.Drawing.Point(21, 62);
            this.lblS2Info.Name = "lblS2Info";
            this.lblS2Info.Size = new System.Drawing.Size(55, 15);
            this.lblS2Info.TabIndex = 12;
            this.lblS2Info.Text = "lblS2Info";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblS1Info);
            this.groupBox1.Controls.Add(this.btnS1Start);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(51, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 135);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "S1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblS2Info);
            this.groupBox2.Controls.Add(this.btnS2Start);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(53, 259);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(584, 143);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "S2";
            // 
            // lblDelegate2
            // 
            this.lblDelegate2.AutoSize = true;
            this.lblDelegate2.Location = new System.Drawing.Point(952, 515);
            this.lblDelegate2.Name = "lblDelegate2";
            this.lblDelegate2.Size = new System.Drawing.Size(77, 15);
            this.lblDelegate2.TabIndex = 15;
            this.lblDelegate2.Text = "lblDelegate2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 556);
            this.Controls.Add(this.lblDelegate2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblDelegate);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.rtLog);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox rtLog;
        private System.Windows.Forms.Label textBox1;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblDelegate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnS1Start;
        private System.Windows.Forms.Button btnS2Start;
        private System.Windows.Forms.Label lblS1Info;
        private System.Windows.Forms.Label lblS2Info;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblDelegate2;
    }
}

