using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Mine_Sweeping_Window
{
    public partial class CustomSettings : Form
    {
        private SettingItems parameterSettings = null;

        public SettingItems ParameterSettings
        {
            get
            {
                if (parameterSettings == null)
                    return new SettingItems(10, 10, 30);
                else
                    return parameterSettings;
            }
            set
            {
                if (value != null)
                    parameterSettings = value;
            }
        }
        public CustomSettings()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            try
            {
                parameterSettings = new SettingItems();

                parameterSettings.RowNumber = int.Parse(txtHeight.Text);

                parameterSettings.ColumnNumber = int.Parse(txtWidth.Text);

                parameterSettings.MineNumber = int.Parse(txtMines.Text);
            }
            catch
            {
                MessageBox.Show("Error!");
            }

            this.Hide();
        }

        private void txtHeight_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void txtHeight_KeyUp(object sender, KeyEventArgs e)
        {
            PreventUnckeckedInput(sender, e);
        }



        private static void PreventUnckeckedInput(object sender, KeyEventArgs e, int val = 15)
        {
            if (sender is TextBox box && string.IsNullOrEmpty(box.Text) == false)
            {
                var textBox = Int32.Parse(box.Text);
                if (textBox > val)
                {
                    box.Text = val.ToString();
                }
                if (textBox <= 0)
                {
                    box.Text = "1";
                }
                e.Handled = true;
                return;

            }
        }

        private static void PreventInvalidInput(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Delete || e.KeyChar == (int)Keys.Back)
            {
                return;
            }
            if (false == char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                return;
            }
        }

        private void txtWidth_KeyUp(object sender, KeyEventArgs e)
        {
            PreventUnckeckedInput(sender, e);
        }

        private void txtMines_KeyUp(object sender, KeyEventArgs e)
        {
            PreventUnckeckedInput(sender, e);
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            PreventInvalidInput(sender, e);
        }

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            PreventInvalidInput(sender, e);
        }

        private void txtMines_KeyPress(object sender, KeyPressEventArgs e)
        {
            PreventInvalidInput(sender, e);
        }
    }
}