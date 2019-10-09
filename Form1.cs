using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.IO;

namespace LogReader
{
    public partial class Form1 : Form
    {
        private LogReader _reader;
        private Thread _readLogThread;
        private int _sleepIntervalMS;
        public Form1()
        {
            InitializeComponent();
            _reader = new LogReader();
            _readLogThread = new Thread(ReadFromLogFile);

            SleepIntervalUpDown.Value = 1;
            _sleepIntervalMS = (int)(SleepIntervalUpDown.Value * 1000);
        }

        private void OpenLogFileButton_Click(object sender, EventArgs e)
        {
            if (OpenLogFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    //open file and start reader thread
                    _reader.LogFilePath = OpenLogFileDialog.FileName;
                    WriteStatus($"Opened log file {_reader.LogFilePath}.");
                    this.Text = _reader.LogFilePath;
                    if (!_readLogThread.IsAlive)
                    {
                        _readLogThread.Start();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error opening file: {ex.ToString()}", "Error");
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_readLogThread.IsAlive)
            {
                _readLogThread.Abort();
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            try
            {
                if (e.Data.GetDataPresent(DataFormats.FileDrop))
                {
                    e.Effect = DragDropEffects.Copy;
                }
                else
                {
                    e.Effect = DragDropEffects.None;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening file: {ex.ToString()}", "Error");
            }
        }

        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                //open file and start reader thread
                _reader.LogFilePath = ((string[])e.Data.GetData(DataFormats.FileDrop, false))[0];

                WriteStatus($"Opened log file {_reader.LogFilePath}.");
                this.Text = _reader.LogFilePath;

                if (!_readLogThread.IsAlive)
                {
                    _readLogThread.Start();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error opening file: {ex.ToString()}", "Error");
            }
        }

        private void ReadFromLogFile()
        {
            while (true)
            {
                //need to run textbox updates on UI thread
                this.Invoke((MethodInvoker)delegate()
                {
                    try
                    {
                        //write log contents to textbox and update status textbox
                        LogFileTextBox.Text = _reader.ReadLogFile();
                        LogFileTextBox.SelectionStart = LogFileTextBox.Text.Length;
                        LogFileTextBox.ScrollToCaret();

                        UpdateReadTimeLabel();
                        //WriteStatus($"Read from log file (thread status: {_readLogThread.ThreadState}).");
                    }
                    catch (Exception ex)
                    {
                        WriteStatus($"EXCEPTION: { ex.Message} (thread status: { _readLogThread.ThreadState}).");
                    }
                });
                Thread.Sleep(_sleepIntervalMS);
            }
        }

        private void UpdateReadTimeLabel()
        {
            LastReadTimeLabel.Text = $"Last Read Time: {DateTime.Now}";
        }

        private void WriteStatus(string text)
        {
            StatusTextBox.AppendText($"[{DateTime.Now}]: {text}{Environment.NewLine}");
        }

        private void PauseCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            //kill the thread if it's alive
            if (PauseCheckBox.Checked && _readLogThread.IsAlive)
            {
                _readLogThread.Abort();
            }
            else
            {
                //restart the thread
                _readLogThread = new Thread(ReadFromLogFile);
                _readLogThread.Start();
            }
        }

        private void SleepIntervalUpDown_ValueChanged(object sender, EventArgs e)
        {
            _sleepIntervalMS = (int)(SleepIntervalUpDown.Value * 1000);
        }
    }
}
