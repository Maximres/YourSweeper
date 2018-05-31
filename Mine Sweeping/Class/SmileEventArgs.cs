using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace Mine_Sweeping
{
    public class SmileEventArgs : EventArgs
    {
        private Image img;

        public SmileEventArgs(Image im)
        {
            img = im;
        }

        public Image Img
        {
            get
            {
                return this.img;
            }
        }
    }
}
