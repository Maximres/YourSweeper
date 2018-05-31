using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Windows.Forms;
using System.ComponentModel;

namespace Mine_Sweeping
{
    public partial class LED : UserControl, IObserver
    {
        #region Private Field

        private int ledStringWidth;

        private int ledStringHeight;

        private Color ledColor = Color.Red;

        private bool isDrawShadow = true;

        private Graphics g = null;

        private Bitmap m_Bitmap = null;

        private string displayedDigitalNumber = "0";

        #endregion

        #region Constructor

        public LED()
        {
            InitializeComponent();

            SetStyle(ControlStyles.UserPaint | ControlStyles.DoubleBuffer | ControlStyles.AllPaintingInWmPaint
             | ControlStyles.ResizeRedraw | ControlStyles.SupportsTransparentBackColor, true);

            this.UpdateStyles();

            Init();
        }

        #endregion

        #region Public Attribute

        [Category("LED Settings"), Description("Определяет тень цифры")]
        public bool IsDrawShadow
        {
            get { return this.isDrawShadow; }
            set
            {
                this.isDrawShadow = value;

                this.Invalidate();
            }
        }

        [Category("LED Settings"), Description("Получает или устанавилает цвет цифры")]
        public System.Drawing.Color DigitalColor
        {
            get { return this.ledColor; }
            set
            {
                this.ledColor = value;

                this.Invalidate();
            }
        }

        [Browsable(false)]
        public int LEDStringWidth
        {
            get
            {
                return ledStringWidth;
            }
        }

        [Browsable(false)]
        public int LEDStringHeight
        {
            get
            {
                return ledStringHeight;
            }
        }

        [Category("LED Settings"), Description("Получает или устанавливает цифру")]
        public string DisplayedDigitalNumber
        {
            get
            {
                return this.displayedDigitalNumber;
            }
            set
            {
                this.displayedDigitalNumber = value;
            }
        }

        public Bitmap MyBitmap
        {
            get
            {
                return this.m_Bitmap;
            }
        }

        #endregion

        #region Private & Protected Methods

        private void Init()
        {
            m_Bitmap = new Bitmap(this.Width, this.Height);

            g = Graphics.FromImage(m_Bitmap);

            g.CompositingQuality = CompositingQuality.HighQuality;

            g.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            g.SmoothingMode = SmoothingMode.HighQuality;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            m_Bitmap = DrawLED();

            Graphics gg = e.Graphics;

            gg.CompositingQuality = CompositingQuality.HighQuality;

            gg.DrawImageUnscaled(m_Bitmap, 0, 0);
        }

        private void LEDDisplay_Resize(object sender, System.EventArgs e)
        {
            Init();

            this.Refresh();
        }

        private Bitmap DrawLED()
        {
            return this.DrawDigital(this.ClientRectangle);
        }

        private Bitmap DrawDigital(Rectangle destRect)
        {
            m_Bitmap = new Bitmap(destRect.Width, destRect.Height);

            Graphics tmpg = Graphics.FromImage(m_Bitmap);

            tmpg.CompositingQuality = CompositingQuality.HighQuality;

            tmpg.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            tmpg.SmoothingMode = SmoothingMode.HighQuality;

            LEDDisplay ssd = new LEDDisplay(tmpg);

            ssd.IsDrawShadow = this.isDrawShadow;

            GraphicsState gs = tmpg.Save();

            tmpg.TranslateTransform(destRect.X, destRect.Y);

            SizeF sizef = ssd.SizeDesign(this.DisplayedDigitalNumber, Font);

            float fScale = Math.Min(destRect.Width / sizef.Width, destRect.Height / sizef.Height);

            Font font = new Font(Font.FontFamily, fScale * Font.SizeInPoints);

            sizef = ssd.SizeDesign(this.DisplayedDigitalNumber, font);

            ledStringWidth = (int)sizef.Width;

            ledStringHeight = (int)sizef.Height;

            ssd.DrawString(this.DisplayedDigitalNumber, font, new SolidBrush(this.ledColor), (destRect.Width - sizef.Width) / 2, (destRect.Height - sizef.Height) / 2);

            tmpg.Restore(gs);

            return m_Bitmap;
        }

        #endregion

        #region Public Methods

        public void Update(EventArgs e)
        {
            LEDEventArgs ea = e as LEDEventArgs;

            if (ea != null)
            {
                this.DisplayedDigitalNumber = ea.Number.ToString();

                this.Refresh();
            }
        }
        #endregion
    }
}