using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Converter
{
    public class NumberTextBox:System.Windows.Forms.TextBox
    {
        protected override void OnTextChanged(EventArgs e)
        {
            base.OnTextChanged(e);
            try
            {
                if (!string.IsNullOrEmpty(Text))
                {
                    double d = Convert.ToDouble(Text);
                }
            }
            catch
            {
                Text = string.Empty;
            }
        }
    }
}
