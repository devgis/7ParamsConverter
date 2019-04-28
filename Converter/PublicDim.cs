using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Converter
{
    public class PublicDim
    {
        private static string SystemName = "Devgis七参数转换系统";
        public static void ShowInfoMessage(string Message)
        {
            MessageBox.Show(Message, SystemName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ShowErrorMessage(string Message)
        {
            MessageBox.Show(Message, SystemName, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
