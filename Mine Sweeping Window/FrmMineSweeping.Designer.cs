namespace Mine_Sweeping_Window
{
    partial class FrmMineSweeping
    {
        /// <summary>
        /// контейнер компонентов
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Очистка
        /// </summary>
        /// <param name="disposing">true\false</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows init

        /// <summary>
        /// Инициализация
        /// Компнонентов
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMineSweeping));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.GToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmStart = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmBegin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmIntermediate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmHigh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmCustom = new System.Windows.Forms.ToolStripMenuItem();
            this.HToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.led3 = new Mine_Sweeping.LED();
            this.led2 = new Mine_Sweeping.LED();
            this.led1 = new Mine_Sweeping.LED();
            this.smileControl1 = new Mine_Sweeping.SmileControl();
            this.sweepingControl1 = new Mine_Sweeping.Sweeping_Container.SweepingControl();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(5, 36);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.led3);
            this.splitContainer1.Panel1.Controls.Add(this.led2);
            this.splitContainer1.Panel1.Controls.Add(this.led1);
            this.splitContainer1.Panel1.Controls.Add(this.smileControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.sweepingControl1);
            this.splitContainer1.Size = new System.Drawing.Size(379, 322);
            this.splitContainer1.SplitterDistance = 59;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 5;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GToolStripMenuItem,
            this.HToolStripMenuItem});
            this.menuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(385, 30);
            this.menuStrip.TabIndex = 6;
            // 
            // GToolStripMenuItem
            // 
            this.GToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStart,
            this.toolStripSeparator1,
            this.tsmBegin,
            this.tsmIntermediate,
            this.tsmHigh,
            this.toolStripSeparator2,
            this.tsmCustom});
            this.GToolStripMenuItem.Name = "GToolStripMenuItem";
            this.GToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.GToolStripMenuItem.Text = "Игра";
            // 
            // tsmStart
            // 
            this.tsmStart.Name = "tsmStart";
            this.tsmStart.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsmStart.Size = new System.Drawing.Size(238, 26);
            this.tsmStart.Text = "Старт";
            this.tsmStart.Click += new System.EventHandler(this.tsmStart_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(235, 6);
            // 
            // tsmBegin
            // 
            this.tsmBegin.Name = "tsmBegin";
            this.tsmBegin.Size = new System.Drawing.Size(238, 26);
            this.tsmBegin.Text = "Новичок";
            this.tsmBegin.Click += new System.EventHandler(this.tsmBegin_Click);
            // 
            // tsmIntermediate
            // 
            this.tsmIntermediate.Name = "tsmIntermediate";
            this.tsmIntermediate.Size = new System.Drawing.Size(238, 26);
            this.tsmIntermediate.Text = "Средний";
            this.tsmIntermediate.Click += new System.EventHandler(this.tsmIntermediate_Click);
            // 
            // tsmHigh
            // 
            this.tsmHigh.Name = "tsmHigh";
            this.tsmHigh.Size = new System.Drawing.Size(238, 26);
            this.tsmHigh.Text = "Про";
            this.tsmHigh.Click += new System.EventHandler(this.tsmHigh_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(235, 6);
            // 
            // tsmCustom
            // 
            this.tsmCustom.CheckOnClick = true;
            this.tsmCustom.Name = "tsmCustom";
            this.tsmCustom.Size = new System.Drawing.Size(238, 26);
            this.tsmCustom.Text = "Создать свой уровень";
            this.tsmCustom.Click += new System.EventHandler(this.tsmCustom_Click);
            // 
            // HToolStripMenuItem
            // 
            this.HToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutAToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.HToolStripMenuItem.Name = "HToolStripMenuItem";
            this.HToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.HToolStripMenuItem.Text = "Помощь";
            // 
            // aboutAToolStripMenuItem
            // 
            this.aboutAToolStripMenuItem.Name = "aboutAToolStripMenuItem";
            this.aboutAToolStripMenuItem.Size = new System.Drawing.Size(179, 26);
            this.aboutAToolStripMenuItem.Text = "О программе";
            this.aboutAToolStripMenuItem.Click += new System.EventHandler(this.aboutAToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // led3
            // 
            this.led3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.led3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.led3.DigitalColor = System.Drawing.Color.Red;
            this.led3.DisplayedDigitalNumber = "0";
            this.led3.IsDrawShadow = true;
            this.led3.Location = new System.Drawing.Point(180, 12);
            this.led3.Margin = new System.Windows.Forms.Padding(4);
            this.led3.Name = "led3";
            this.led3.Size = new System.Drawing.Size(71, 39);
            this.led3.TabIndex = 4;
            // 
            // led2
            // 
            this.led2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.led2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.led2.DigitalColor = System.Drawing.Color.Red;
            this.led2.DisplayedDigitalNumber = "0";
            this.led2.IsDrawShadow = true;
            this.led2.Location = new System.Drawing.Point(259, 12);
            this.led2.Margin = new System.Windows.Forms.Padding(4);
            this.led2.Name = "led2";
            this.led2.Size = new System.Drawing.Size(71, 39);
            this.led2.TabIndex = 3;
            // 
            // led1
            // 
            this.led1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.led1.DigitalColor = System.Drawing.Color.Red;
            this.led1.DisplayedDigitalNumber = "0";
            this.led1.IsDrawShadow = true;
            this.led1.Location = new System.Drawing.Point(101, 12);
            this.led1.Margin = new System.Windows.Forms.Padding(4);
            this.led1.Name = "led1";
            this.led1.Size = new System.Drawing.Size(71, 39);
            this.led1.TabIndex = 3;
            // 
            // smileControl1
            // 
            this.smileControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.smileControl1.BackColor = System.Drawing.Color.Transparent;
            this.smileControl1.Img = ((System.Drawing.Image)(resources.GetObject("smileControl1.Img")));
            this.smileControl1.Location = new System.Drawing.Point(24, 12);
            this.smileControl1.Margin = new System.Windows.Forms.Padding(5);
            this.smileControl1.Name = "smileControl1";
            this.smileControl1.Size = new System.Drawing.Size(72, 22);
            this.smileControl1.TabIndex = 2;
            this.smileControl1.Load += new System.EventHandler(this.smileControl1_Load);
            // 
            // sweepingControl1
            // 
            this.sweepingControl1.ColumnNumbers = 10;
            this.sweepingControl1.EnableThis = true;
            this.sweepingControl1.Location = new System.Drawing.Point(0, 0);
            this.sweepingControl1.Margin = new System.Windows.Forms.Padding(5);
            this.sweepingControl1.Name = "sweepingControl1";
            this.sweepingControl1.RowNumbers = 10;
            this.sweepingControl1.Size = new System.Drawing.Size(375, 237);
            this.sweepingControl1.TabIndex = 4;
            this.sweepingControl1.TheNumbersOfMines = 10;
            this.sweepingControl1.Load += new System.EventHandler(this.sweepingControl1_Load);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.справкаToolStripMenuItem.Text = "Справка";
            this.справкаToolStripMenuItem.Click += new System.EventHandler(this.справкаToolStripMenuItem_Click);
            // 
            // FrmMineSweeping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(385, 361);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(311, 412);
            this.Name = "FrmMineSweeping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Сапёрище";
            this.Load += new System.EventHandler(this.FrmMineSweeping_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Mine_Sweeping.SmileControl smileControl1;
        private Mine_Sweeping.LED led1;
        private Mine_Sweeping.Sweeping_Container.SweepingControl sweepingControl1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem GToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmStart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem tsmCustom;
        private System.Windows.Forms.ToolStripMenuItem tsmBegin;
        private System.Windows.Forms.ToolStripMenuItem tsmIntermediate;
        private System.Windows.Forms.ToolStripMenuItem tsmHigh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem HToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutAToolStripMenuItem;
        private Mine_Sweeping.LED led2;
        private System.Windows.Forms.Timer timer;
        private Mine_Sweeping.LED led3;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
    }
}