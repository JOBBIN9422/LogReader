namespace LogReader
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.OpenLogFileButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SleepIntervalUpDown = new System.Windows.Forms.NumericUpDown();
            this.PauseCheckBox = new System.Windows.Forms.CheckBox();
            this.LogFileTextBox = new System.Windows.Forms.TextBox();
            this.LastReadTimeLabel = new System.Windows.Forms.Label();
            this.StatusTextBox = new System.Windows.Forms.TextBox();
            this.OpenLogFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SleepIntervalUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Controls.Add(this.LogFileTextBox);
            this.flowLayoutPanel1.Controls.Add(this.LastReadTimeLabel);
            this.flowLayoutPanel1.Controls.Add(this.StatusTextBox);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1260, 1066);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.OpenLogFileButton);
            this.flowLayoutPanel2.Controls.Add(this.label1);
            this.flowLayoutPanel2.Controls.Add(this.SleepIntervalUpDown);
            this.flowLayoutPanel2.Controls.Add(this.PauseCheckBox);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1245, 27);
            this.flowLayoutPanel2.TabIndex = 5;
            // 
            // OpenLogFileButton
            // 
            this.OpenLogFileButton.Location = new System.Drawing.Point(3, 3);
            this.OpenLogFileButton.Name = "OpenLogFileButton";
            this.OpenLogFileButton.Size = new System.Drawing.Size(90, 23);
            this.OpenLogFileButton.TabIndex = 0;
            this.OpenLogFileButton.Text = "Open Log File";
            this.OpenLogFileButton.UseVisualStyleBackColor = true;
            this.OpenLogFileButton.Click += new System.EventHandler(this.OpenLogFileButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(99, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "Sleep Interval (seconds)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SleepIntervalUpDown
            // 
            this.SleepIntervalUpDown.DecimalPlaces = 2;
            this.SleepIntervalUpDown.Location = new System.Drawing.Point(226, 3);
            this.SleepIntervalUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.SleepIntervalUpDown.Name = "SleepIntervalUpDown";
            this.SleepIntervalUpDown.Size = new System.Drawing.Size(83, 20);
            this.SleepIntervalUpDown.TabIndex = 4;
            this.SleepIntervalUpDown.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            this.SleepIntervalUpDown.ValueChanged += new System.EventHandler(this.SleepIntervalUpDown_ValueChanged);
            // 
            // PauseCheckBox
            // 
            this.PauseCheckBox.AutoSize = true;
            this.PauseCheckBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PauseCheckBox.Location = new System.Drawing.Point(315, 3);
            this.PauseCheckBox.Name = "PauseCheckBox";
            this.PauseCheckBox.Size = new System.Drawing.Size(56, 23);
            this.PauseCheckBox.TabIndex = 1;
            this.PauseCheckBox.Text = "Pause";
            this.PauseCheckBox.UseVisualStyleBackColor = true;
            this.PauseCheckBox.CheckedChanged += new System.EventHandler(this.PauseCheckBox_CheckedChanged);
            // 
            // LogFileTextBox
            // 
            this.LogFileTextBox.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogFileTextBox.Location = new System.Drawing.Point(3, 36);
            this.LogFileTextBox.Multiline = true;
            this.LogFileTextBox.Name = "LogFileTextBox";
            this.LogFileTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogFileTextBox.Size = new System.Drawing.Size(1245, 846);
            this.LogFileTextBox.TabIndex = 1;
            // 
            // LastReadTimeLabel
            // 
            this.LastReadTimeLabel.AutoSize = true;
            this.LastReadTimeLabel.Location = new System.Drawing.Point(3, 885);
            this.LastReadTimeLabel.Name = "LastReadTimeLabel";
            this.LastReadTimeLabel.Size = new System.Drawing.Size(85, 13);
            this.LastReadTimeLabel.TabIndex = 6;
            this.LastReadTimeLabel.Text = "Last Read Time:";
            // 
            // StatusTextBox
            // 
            this.StatusTextBox.Font = new System.Drawing.Font("NSimSun", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTextBox.Location = new System.Drawing.Point(3, 901);
            this.StatusTextBox.Multiline = true;
            this.StatusTextBox.Name = "StatusTextBox";
            this.StatusTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.StatusTextBox.Size = new System.Drawing.Size(1245, 154);
            this.StatusTextBox.TabIndex = 4;
            // 
            // OpenLogFileDialog
            // 
            this.OpenLogFileDialog.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 1066);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SleepIntervalUpDown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button OpenLogFileButton;
        private System.Windows.Forms.TextBox LogFileTextBox;
        private System.Windows.Forms.OpenFileDialog OpenLogFileDialog;
        private System.Windows.Forms.TextBox StatusTextBox;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox PauseCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown SleepIntervalUpDown;
        private System.Windows.Forms.Label LastReadTimeLabel;
    }
}

