using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Mine_Sweeping;

namespace Mine_Sweeping.Sweeping_Container
{
    public partial class SweepingControl : UserControl, IOberverable
    {
        #region Private Field

        private int rowNumbers = 1;

        private int columnNumbers = 1;

        private int minesNumbers = 1;

        private int cubicSize = 30;

        private SweepingMap getSetControl = null;

        private List<IObserver> container = null;

        private bool enableThis = true;

        #endregion

        #region Constructor

        public SweepingControl()
        {
            InitializeComponent();

            this.container = new List<IObserver>();
        }

        #endregion

        #region Public Attributes

        [DefaultValue(1), Browsable(true)]
        [ToolboxItem(true), Category("Sweeping Control"), Description("Получает или устанавливает число строк")]
        public int RowNumbers
        {
            get
            {
                return rowNumbers;
            }
            set
            {
                if (value > 0)
                {
                    rowNumbers = value;
                }
            }
        }

        [DefaultValue(1), Browsable(true)]
        [ToolboxItem(true), Category("Sweeping Control"), Description("Получает или устанавливает число столбцов")]
        public int ColumnNumbers
        {
            get
            {
                return columnNumbers;
            }
            set
            {
                if (value > 0)
                    columnNumbers = value;
            }
        }

        [DefaultValue(1), Browsable(true)]
        [ToolboxItem(true), Category("Sweeping Control"), Description("Получает или устанавливет число мин")]
        public int TheNumbersOfMines
        {
            get
            {
                return minesNumbers;
            }
            set
            {
                if (value > (ColumnNumbers - 1) * (RowNumbers - 1))
                    minesNumbers = (ColumnNumbers - 1) * (RowNumbers - 1);
                else
                    minesNumbers = value;
            }
        }

        [DefaultValue(30)]
        [ToolboxItem(false), Category("Sweeping Control"), Description("Устанавливает или получает размер кубика")]
        public int CubicSize
        {
            get
            {
                return cubicSize;
            }
        }

        public bool EnableThis
        {
            get
            {
                return this.enableThis;
            }
            set
            {
                this.enableThis = value;
            }
        }

        #endregion

        #region Private Methods



        #endregion

        #region Private Methods

        private void SweepingMapInitialization()
        {
            if (getSetControl == null)
                getSetControl = new SweepingMap();

            getSetControl.Lines = this.RowNumbers;

            getSetControl.Columns = this.ColumnNumbers;

            getSetControl.MineNums = this.TheNumbersOfMines;

            getSetControl.Initialization();
        }

        private void SweepingViewInitialization()
        {
            DataGridViewImageColumn[] dc = new DataGridViewImageColumn[this.ColumnNumbers];

            DataGridViewRow[] dr = new DataGridViewRow[this.RowNumbers];

            this.SweeperView.Columns.Clear();

            this.SweeperView.Rows.Clear();

            for (int i = 0; i < dc.GetUpperBound(0) + 1; i++)
            {
                dc[i] = new DataGridViewImageColumn();

                SetColumnStyle(ref dc[i]);

                this.SweeperView.Columns.Add(dc[i]);
            }

            for (int i = 0; i < dr.GetUpperBound(0) + 1; i++)
            {
                dr[i] = new DataGridViewRow();

                dr[i].Height = this.CubicSize;

                this.SweeperView.Rows.Add(dr[i]);
            }

            this.Size = new Size(this.SweeperView.Columns[0].Width * (this.ColumnNumbers + 1), this.SweeperView.Rows[0].Height * (this.RowNumbers + 1));
        }

        private void SetColumnStyle(ref DataGridViewImageColumn dc)
        {
            dc.Image = MyResource.backcolor;

            dc.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dc.Width = this.CubicSize;
        }

        private void SweeperView_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int x = e.RowIndex;

            int y = e.ColumnIndex;


            if (!getSetControl.BothClick(x, y, new Presenter(SetGridImage)))
            {
                SmileEventArgs ee = new SmileEventArgs(MyResource.Qoo1);

                Notify(ee);
            }
        }

        private void SweeperView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            SmileEventArgs ee = new SmileEventArgs(MyResource.Qoo2);

            LEDEventArgs ex = null;

            Notify(ee);

            int x = e.RowIndex;

            int y = e.ColumnIndex;

            if (e.Button == MouseButtons.Left)
            {
                if (!getSetControl.LeftClick(x, y, new Presenter(SetGridImage)))
                {
                    ee = new SmileEventArgs(MyResource.Qoo1);

                    Notify(ee);

                }
            }
            else
                if (e.Button == MouseButtons.Right)
            {

                if (getSetControl.RightClick(x, y, new Presenter(SetFlagImage)))
                {
                    ee = new SmileEventArgs(MyResource.Qoo3);

                    Notify(ee);

                    ex = new LEDEventArgs(getSetControl.Flags.Length);

                    Notify(ex);

                    this.Enabled = this.EnableThis = false;

                    MessageBox.Show("И это победа!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    return;


                }

                ex = new LEDEventArgs(getSetControl.Flags.Length);

                Notify(ex);

            }
        }

        private void SetGridImage(int x, int y, object obj)
        {
            if (x >= 0 && y >= 0)
            {
                DataGridViewImageCell imc = this.SweeperView.Rows[x].Cells[y] as DataGridViewImageCell;



                int height = cubicSize;

                int width = cubicSize;

                if (obj.ToString() != "Mine")
                {
                    Bitmap bitmap = new Bitmap(width, height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

                    Graphics g = Graphics.FromImage(bitmap);

                    g.Clear(Color.LightBlue);

                    if (obj.ToString() == "0")
                        obj = ".";

                    g.DrawString(obj.ToString(), new Font("Arial", 15), new SolidBrush(Color.Red), 6.5f, 1.5f);

                    imc.Value = bitmap;
                }
                else
                {
                    imc.Value = MyResource.wrong;

                    getSetControl.DisplayAllMines(x, y, new Presenter(SetMineImage));

                    this.Enabled = EnableThis = false;
                }
            }
        }

        private void SetFlagImage(int x, int y, object obj)
        {
            DataGridViewImageCell imc = this.SweeperView.Rows[x].Cells[y] as DataGridViewImageCell;

            if (!(bool)obj)
                imc.Value = MyResource.flag;

            if ((bool)obj)
                imc.Value = MyResource.backcolor;
        }

        private void SetMineImage(int x, int y, object obj)
        {
            DataGridViewImageCell imc = this.SweeperView.Rows[x].Cells[y] as DataGridViewImageCell;

            imc.Value = MyResource.Mine;
        }

        #endregion

        #region Public Methods      

        public void Register(IObserver ober)
        {
            if (!this.container.Contains(ober))
                this.container.Add(ober);
        }

        public void UnRegister(IObserver ober)
        {
            if (this.container.Contains(ober))
                this.container.Remove(ober);
        }

        protected void Notify(EventArgs e)
        {
            foreach (IObserver observer in this.container)
            {
                observer.Update(e);
            }
        }

        public void ControlInitialization()
        {
            EnableThis = true;

            this.SweepingMapInitialization();

            this.SweepingViewInitialization();
        }

        #endregion           
    }
}
