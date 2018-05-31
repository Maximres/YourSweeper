namespace Mine_Sweeping
{
    partial class LED
    {
        /// <summary> 
        /// контейнер
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Осовбождение
        /// </summary>
        /// <param name="disposing"> </param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Сгенерированный код конструктора компонентов

        /// <summary> 
        /// Контейнер 
        /// для элементов
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // LED
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Name = "LED";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
