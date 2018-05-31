using System;
using System.Collections.Generic;
using System.Text;

namespace Mine_Sweeping
{
    /// <summary>
    /// Класс хелпер для собсвенного компонента
    /// </summary>
    public class CreateDigitalImage
    {
        public static System.Drawing.Bitmap DrawDigital(System.Drawing.Rectangle destRect, string DisplayedDigitalNumber, System.Drawing.Color thisColor, System.Drawing.Font thisFont)
        {
            System.Drawing.Bitmap m_Bitmap = new System.Drawing.Bitmap(destRect.Width, destRect.Height);

            System.Drawing.Graphics tmpg = System.Drawing.Graphics.FromImage(m_Bitmap);

            tmpg.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;

            tmpg.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAliasGridFit;

            tmpg.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

            LEDDisplay ssd = new LEDDisplay(tmpg);

            System.Drawing.Drawing2D.GraphicsState gs = tmpg.Save();

            tmpg.TranslateTransform(destRect.X, destRect.Y);

            System.Drawing.SizeF sizef = ssd.SizeDesign(DisplayedDigitalNumber, thisFont);

            float fScale = Math.Min(destRect.Width / sizef.Width, destRect.Height / sizef.Height);

            System.Drawing.Font font = new System.Drawing.Font(thisFont.FontFamily, fScale * thisFont.SizeInPoints);

            sizef = ssd.SizeDesign(DisplayedDigitalNumber, font);

            ssd.DrawString(DisplayedDigitalNumber, font, new System.Drawing.SolidBrush(thisColor),(destRect.Width - sizef.Width) / 2, (destRect.Height - sizef.Height) / 2);
                       
            tmpg.Restore(gs);

            return m_Bitmap;
        }
    }
}
