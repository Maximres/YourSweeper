using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Mine_Sweeping_Window
{
    public partial class FrmMineSweeping : Form
    {
        private object curSender = null;

        GameLevel level = new GameLevel();

        private DateTime current = new DateTime();

        public FrmMineSweeping()
        {
            InitializeComponent();

            FormInitialization();
        }

        private void FormInitialization()
        {
            this.sweepingControl1.ControlInitialization();

            this.sweepingControl1.Register(this.led1);

            this.sweepingControl1.Register(this.smileControl1);

            this.smileControl1.BtnClick += SmileControl1_BtnClick; ;

            int width, height;



            width = this.sweepingControl1.Width + 1;

            height = this.sweepingControl1.Height + splitContainer1.Panel1.Height + 75;

            //this.Size = new Size(width, height);

            this.Height = height;
            this.Width = width;
            this.timer.Enabled = true;



            this.current = DateTime.Now;

        }

        private void SmileControl1_BtnClick(object sender, EventArgs e)
        {
            Rebuild(this, e);
        }

        private void Rebuild(object sender, EventArgs e)
        {
            this.sweepingControl1.Enabled = true;

            this.sweepingControl1.ControlInitialization();

            this.smileControl1.Reset();

            this.led1.DisplayedDigitalNumber = "0";

            this.led1.Refresh();

            this.timer.Enabled = true;

            this.current = DateTime.Now;

            switch (level)
            {
                case GameLevel.easy:
                    this.Width = 311;
                    this.Height = 412;
                    break;
                case GameLevel.medium:
                    this.Width = 535;
                    this.Height = 622;
                    break;
                case GameLevel.hard:
                    this.Width = 983;
                    this.Height = 622;
                    break;
                case GameLevel.custom:
                    break;
                default:
                    break;
            }

            AlignControls();

        }

        private void AlignControls()
        {
            this.led1.Left = this.splitContainer1.Left + 10;

            this.led2.Left = this.splitContainer1.Width - 65;

            this.led3.Left = this.led2.Left - this.led2.Width - 5;

            this.smileControl1.Left = this.splitContainer1.Width / 2 - smileControl1.Width;
        }

        private void tsmBegin_Click(object sender, EventArgs e)
        {
            curSender = sender;

            this.sweepingControl1.ColumnNumbers = 9;

            this.sweepingControl1.RowNumbers = 9;

            this.sweepingControl1.TheNumbersOfMines = 10;

            FormInitialization();

            this.level = GameLevel.easy;

            Rebuild(sender, null);
        }

        private void tsmIntermediate_Click(object sender, EventArgs e)
        {
            curSender = sender;

            this.sweepingControl1.ColumnNumbers = 16;

            this.sweepingControl1.RowNumbers = 16;

            this.sweepingControl1.TheNumbersOfMines = 40;

            FormInitialization();

            this.level = GameLevel.medium;

            Rebuild(sender, null);
        }

        private void tsmHigh_Click(object sender, EventArgs e)
        {
            curSender = sender;

            this.sweepingControl1.ColumnNumbers = 30;

            this.sweepingControl1.RowNumbers = 16;

            this.sweepingControl1.TheNumbersOfMines = 99;

            FormInitialization();

            this.level = GameLevel.hard;

            Rebuild(sender, null);
        }

        private void tsmStart_Click(object sender, EventArgs e)
        {
            Rebuild(sender, null);
        }

        private void aboutAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutIt ab = new AboutIt();

            ab.ShowDialog();
        }

        private void tsmCustom_Click(object sender, EventArgs e)
        {
            curSender = sender;

            CustomSettings custom = new CustomSettings();

            custom.ShowDialog();

            this.level = GameLevel.custom;

            if (custom.ParameterSettings != null)
            {
                this.sweepingControl1.ColumnNumbers = custom.ParameterSettings.ColumnNumber;

                this.sweepingControl1.RowNumbers = custom.ParameterSettings.RowNumber;

                this.sweepingControl1.TheNumbersOfMines = custom.ParameterSettings.MineNumber;

                FormInitialization();

                Rebuild(sender, null);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (!this.sweepingControl1.Enabled)
            {
                this.timer.Enabled = false;
            }

            TimeSpan span = DateTime.Now - current;

            this.led3.DisplayedDigitalNumber = span.Minutes.ToString();

            this.led2.DisplayedDigitalNumber = span.Seconds.ToString();

            this.led3.Refresh();
            this.led2.Refresh();
        }

        private void sweepingControl1_Load(object sender, EventArgs e)
        {

        }

        private void FrmMineSweeping_Load(object sender, EventArgs e)
        {
            this.splitContainer1.Dock = DockStyle.Fill;
            this.level = GameLevel.easy;
            this.tsmBegin_Click(sender, e);
        }

        private void smileControl1_Load(object sender, EventArgs e)
        {

        }

        private void справкаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var extenstionName = string.Empty;
                var path = Path.Combine(Directory.GetCurrentDirectory(), "Info");
                var fileName = Directory.GetFiles(path);
                if (fileName.Length != 0)
                {
                    extenstionName = Path.GetExtension(fileName[0]);
                }
                else
                {
                    throw new Exception($"Нет файлов по пути {path}");
                }
                string filePath;

                if (extenstionName.Equals(".chm"))
                {
                    filePath = fileName[0];
                }
                else
                {
                    throw new Exception("Неверное расширение для справки. Доступные расширения: .chm");
                }

                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при открытии справки", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}