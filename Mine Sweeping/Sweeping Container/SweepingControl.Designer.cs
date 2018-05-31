namespace Mine_Sweeping.Sweeping_Container
{
    partial class SweepingControl
    {
        /// <summary> 
        /// Хранение компонентов
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Дада
        /// </summary>
        /// <param name="disposing">Освобождение</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region DoSomethings

        /// <summary> 
        /// Инициализация
        /// компонентов
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.SweeperView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.SweeperView)).BeginInit();
            this.SuspendLayout();
            // 
            // SweeperView
            // 
            this.SweeperView.AllowUserToAddRows = false;
            this.SweeperView.AllowUserToDeleteRows = false;
            this.SweeperView.AllowUserToResizeColumns = false;
            this.SweeperView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Transparent;
            this.SweeperView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.SweeperView.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SweeperView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.SweeperView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.SweeperView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SweeperView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.SweeperView.ColumnHeadersHeight = 4;
            this.SweeperView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.SweeperView.DefaultCellStyle = dataGridViewCellStyle3;
            this.SweeperView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SweeperView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SweeperView.Location = new System.Drawing.Point(0, 0);
            this.SweeperView.MultiSelect = false;
            this.SweeperView.Name = "SweeperView";
            this.SweeperView.ReadOnly = true;
            this.SweeperView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.SweeperView.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.SweeperView.RowHeadersVisible = false;
            this.SweeperView.RowHeadersWidth = 50;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Control;
            this.SweeperView.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.SweeperView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.SystemColors.Control;
            this.SweeperView.RowTemplate.Height = 23;
            this.SweeperView.ShowCellErrors = false;
            this.SweeperView.ShowCellToolTips = false;
            this.SweeperView.ShowEditingIcon = false;
            this.SweeperView.ShowRowErrors = false;
            this.SweeperView.Size = new System.Drawing.Size(119, 118);
            this.SweeperView.TabIndex = 0;
            this.SweeperView.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SweeperView_CellMouseDown);
            this.SweeperView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SweeperView_CellMouseDoubleClick);
            // 
            // SweepingControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SweeperView);
            this.Name = "SweepingControl";
            this.Size = new System.Drawing.Size(119, 118);
            ((System.ComponentModel.ISupportInitialize)(this.SweeperView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView SweeperView;
    }
}
