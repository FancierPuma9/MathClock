namespace MathClockClass
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.curTimeLabel = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.startAlarm = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.problemLabel = new System.Windows.Forms.Label();
            this.enterButton = new System.Windows.Forms.Button();
            this.answerBox = new System.Windows.Forms.TextBox();
            this.wrongLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // curTimeLabel
            // 
            this.curTimeLabel.AutoSize = true;
            this.curTimeLabel.Location = new System.Drawing.Point(13, 13);
            this.curTimeLabel.Name = "curTimeLabel";
            this.curTimeLabel.Size = new System.Drawing.Size(35, 13);
            this.curTimeLabel.TabIndex = 0;
            this.curTimeLabel.Text = "label1";
            // 
            // timePicker
            // 
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.timePicker.Location = new System.Drawing.Point(12, 66);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(91, 20);
            this.timePicker.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Alarm Time";
            // 
            // startAlarm
            // 
            this.startAlarm.Location = new System.Drawing.Point(16, 104);
            this.startAlarm.Name = "startAlarm";
            this.startAlarm.Size = new System.Drawing.Size(75, 23);
            this.startAlarm.TabIndex = 3;
            this.startAlarm.Text = "Start";
            this.startAlarm.UseVisualStyleBackColor = true;
            this.startAlarm.Click += new System.EventHandler(this.startAlarm_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // problemLabel
            // 
            this.problemLabel.AutoSize = true;
            this.problemLabel.Location = new System.Drawing.Point(16, 134);
            this.problemLabel.Name = "problemLabel";
            this.problemLabel.Size = new System.Drawing.Size(35, 13);
            this.problemLabel.TabIndex = 4;
            this.problemLabel.Text = "label2";
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(16, 215);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 5;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // answerBox
            // 
            this.answerBox.Location = new System.Drawing.Point(16, 189);
            this.answerBox.Name = "answerBox";
            this.answerBox.Size = new System.Drawing.Size(100, 20);
            this.answerBox.TabIndex = 6;
            // 
            // wrongLabel
            // 
            this.wrongLabel.AutoSize = true;
            this.wrongLabel.Location = new System.Drawing.Point(16, 173);
            this.wrongLabel.Name = "wrongLabel";
            this.wrongLabel.Size = new System.Drawing.Size(0, 13);
            this.wrongLabel.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(222, 314);
            this.Controls.Add(this.wrongLabel);
            this.Controls.Add(this.answerBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.problemLabel);
            this.Controls.Add(this.startAlarm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timePicker);
            this.Controls.Add(this.curTimeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label curTimeLabel;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button startAlarm;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label problemLabel;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox answerBox;
        private System.Windows.Forms.Label wrongLabel;
    }
}

