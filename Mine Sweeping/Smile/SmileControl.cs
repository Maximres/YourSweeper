using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Mine_Sweeping
{
    public partial class SmileControl : UserControl, IObserver
    {
        public event EventHandler BtnClick
        {
            add
            {
                this.pictureBox.Click += value;
            }
            remove
            {
                this.pictureBox.Click -= value;
            }
        }

        public Image Img
        {
            get
            {
                return this.pictureBox.Image;
            }
            set
            {
                this.pictureBox.Image = value;
            }
        }

        public SmileControl()
        {
            InitializeComponent();

            this.pictureBox.Image = MyResource.Qoo2;
        }

        public void Reset()
        {
            this.pictureBox.Image = MyResource.Qoo2;
        }

        public void Update(EventArgs brgs)
        {
            SmileEventArgs e = brgs as SmileEventArgs;

            if (e != null && e.Img != null)
                this.pictureBox.Image = e.Img;
        }
    }
}
