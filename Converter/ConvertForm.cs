using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Converter
{
    public partial class ConvertForm : Form
    {
        public ConvertForm()
        {
            InitializeComponent();
        }

        #region 事件
        /// <summary>
        /// 添加控制点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btAddPoint_Click(object sender, EventArgs e)
        {
            dgvControlPoint.Rows.Add();

            //刷新标号
            for (int i=0;i<dgvControlPoint.Rows.Count;i++)
            {
                dgvControlPoint.Rows[i].HeaderCell.Value = (i + 1).ToString(); ;
            }
        }

        /// <summary>
        /// 计算7参数
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btComputeSenvenP_Click(object sender, EventArgs e)
        {
            //验证 
            bool bOK = true;
            foreach (DataGridViewRow row in dgvControlPoint.Rows)
            {
                for (int i = 0; i < dgvControlPoint.Columns.Count; i++)
                {
                    try
                    {
                        double d = Convert.ToDouble(row.Cells[i].Value);
                        row.Cells[i].ErrorText = null;
                    }
                    catch
                    {
                        bOK = false;
                        row.Cells[i].ErrorText = "格式不正确，必须为数字";
                    }
                }
            }

            if (dgvControlPoint.Rows.Count < 3)
            {
                PublicDim.ShowErrorMessage("最少需要三条数据！");
                return;
            }

            //初始化数据
            if (bOK)
            {
                //计算七参数
                PointXYZdbl[] aPtSource = new PointXYZdbl[dgvControlPoint.Rows.Count];
                PointXYZdbl[] aPtTo = new PointXYZdbl[dgvControlPoint.Rows.Count];

                for (int i = 0; i < dgvControlPoint.Rows.Count;i++ )
                {
                    DataGridViewRow row = dgvControlPoint.Rows[i];
                    aPtSource[i] = new PointXYZdbl();
                    aPtSource[i].X = Convert.ToDouble(row.Cells["ColSourceX"].Value);
                    aPtSource[i].Y = Convert.ToDouble(row.Cells["ColSourceY"].Value);
                    aPtSource[i].Z = Convert.ToDouble(row.Cells["ColSourceZ"].Value);

                    aPtTo[i] = new PointXYZdbl();
                    aPtTo[i].X = Convert.ToDouble(row.Cells["ColToX"].Value);
                    aPtTo[i].Y = Convert.ToDouble(row.Cells["ColToY"].Value);
                    aPtTo[i].Z = Convert.ToDouble(row.Cells["ColToZ"].Value);
                }

                //计算七参数
                SevenP sp = new SevenP();
                SevenParam.Calc7Para(aPtSource, aPtTo, ref sp);
                if (sp == null)
                {
                    PublicDim.ShowErrorMessage("计算七参数出错，请检查输入点！");
                    return;
                }
                else
                {
                    //显示值
                    tbParamX.Text = sp.Ex.ToString();
                    tbParamY.Text = sp.Ey.ToString();
                    tbParamZ.Text = sp.Ez.ToString();
                    tbParamScale.Text = sp.scale.ToString();
                    tbParamXdelta.Text = sp.Xdelta.ToString();
                    tbParamYdelta.Text = sp.Ydelta.ToString();
                    tbParamZdelta.Text = sp.Zdelta.ToString();
                }

            }
            else
            {
                PublicDim.ShowErrorMessage("验证失败，请检查输入控制点信息！");
            }
        }

        /// <summary>
        /// 转换坐标点
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btConvertPoint_Click(object sender, EventArgs e)
        {
            #region 校验输入条件
            #region △X
            if (string.IsNullOrEmpty(tbParamX.Text.Trim()))
            {
                PublicDim.ShowErrorMessage("△X不能为空！");
                tbParamX.Focus();
                return;
            }
            double ex = 0;
            try
            {
                ex = Convert.ToDouble(tbParamX.Text);
            }
            catch
            {
                PublicDim.ShowErrorMessage("△X必须为数值！");
                tbParamX.Focus();
                return;
            }
            #endregion

            #region△Y
            if (string.IsNullOrEmpty(tbParamY.Text.Trim()))
            {
                PublicDim.ShowErrorMessage("△Y不能为空！");
                tbParamY.Focus();
                return;
            }
            double ey = 0;
            try
            {
                ey = Convert.ToDouble(tbParamY.Text);
            }
            catch
            {
                PublicDim.ShowErrorMessage("△Y必须为数值！");
                tbParamY.Focus();
                return;
            }
            #endregion

            #region △Z
            if (string.IsNullOrEmpty(tbParamZ.Text.Trim()))
            {
                PublicDim.ShowErrorMessage("△Z不能为空！");
                tbParamZ.Focus();
                return;
            }
            double ez = 0;
            try
            {
                ez = Convert.ToDouble(tbParamZ.Text);
            }
            catch
            {
                PublicDim.ShowErrorMessage("△Z必须为数值！");
                tbParamZ.Focus();
                return;
            }
            #endregion

            #region Scale
            if (string.IsNullOrEmpty(tbParamScale.Text.Trim()))
            {
                PublicDim.ShowErrorMessage("Scale不能为空！");
                tbParamScale.Focus();
                return;
            }
            double scale = 0;
            try
            {
                scale = Convert.ToDouble(tbParamScale.Text);
            }
            catch
            {
                PublicDim.ShowErrorMessage("Scale必须为数值！");
                tbParamScale.Focus();
                return;
            }
            #endregion

            #region Xdelta
            if (string.IsNullOrEmpty(tbParamXdelta.Text.Trim()))
            {
                PublicDim.ShowErrorMessage("Xdelta不能为空！");
                tbParamXdelta.Focus();
                return;
            }
            double xdelta = 0;
            try
            {
                xdelta = Convert.ToDouble(tbParamXdelta.Text);
            }
            catch
            {
                PublicDim.ShowErrorMessage("Xdelta必须为数值！");
                tbParamXdelta.Focus();
                return;
            }
            #endregion

            #region Ydelta
            if (string.IsNullOrEmpty(tbParamYdelta.Text.Trim()))
            {
                PublicDim.ShowErrorMessage("Ydelta不能为空！");
                tbParamYdelta.Focus();
                return;
            }
            double ydelta = 0;
            try
            {
                ydelta = Convert.ToDouble(tbParamYdelta.Text);
            }
            catch
            {
                PublicDim.ShowErrorMessage("Ydelta必须为数值！");
                tbParamYdelta.Focus();
                return;
            }
            #endregion

            #region Zdelta
            if (string.IsNullOrEmpty(tbParamZdelta.Text.Trim()))
            {
                PublicDim.ShowErrorMessage("Zdelta不能为空！");
                tbParamZdelta.Focus();
                return;
            }
            double zdelta = 0;
            try
            {
                zdelta = Convert.ToDouble(tbParamZdelta.Text);
            }
            catch
            {
                PublicDim.ShowErrorMessage("Zdelta必须为数值！");
                tbParamZdelta.Focus();
                return;
            }
            #endregion

            #region 源X
            if (string.IsNullOrEmpty(tbSourceX.Text.Trim()))
            {
                PublicDim.ShowErrorMessage("源X不能为空！");
                tbSourceX.Focus();
                return;
            }
            double x = 0;
            try
            {
                x = Convert.ToDouble(tbSourceX.Text);
            }
            catch
            {
                PublicDim.ShowErrorMessage("源X必须为数值！");
                tbSourceX.Focus();
                return;
            }
            #endregion

            #region 源Y
            if (string.IsNullOrEmpty(tbSourceY.Text.Trim()))
            {
                PublicDim.ShowErrorMessage("源Y不能为空！");
                tbSourceY.Focus();
                return;
            }
            double y = 0;
            try
            {
                y = Convert.ToDouble(tbSourceY.Text);
            }
            catch
            {
                PublicDim.ShowErrorMessage("源Y必须为数值！");
                tbSourceY.Focus();
                return;
            }
            #endregion

            #region 源Z
            if (string.IsNullOrEmpty(tbSourceZ.Text.Trim()))
            {
                PublicDim.ShowErrorMessage("源Z不能为空！");
                tbSourceZ.Focus();
                return;
            }
            double z = 0;
            try
            {
                z = Convert.ToDouble(tbSourceZ.Text);
            }
            catch
            {
                PublicDim.ShowErrorMessage("源Z必须为数值！");
                tbSourceZ.Focus();
                return;
            }
            #endregion
            #endregion

            #region 转换
            //坐标转换
            SevenP sp = new SevenP();
            sp.Ex = ex;
            sp.Ey = ey;
            sp.Ez = ez;
            sp.scale = scale;
            sp.Xdelta = xdelta;
            sp.Ydelta = ydelta;
            sp.Zdelta = zdelta;

            PointXYZdbl[] aPtSource2 = new PointXYZdbl[1];
            PointXYZdbl[] aPtTo2 = null;
            aPtSource2[0] = new PointXYZdbl();
            aPtSource2[0].X = x;
            aPtSource2[0].Y = y;
            aPtSource2[0].Z = z;

            SevenParam.CalcXYZby7Para(aPtSource2, sp, ref aPtTo2);
            if (aPtTo2 == null || aPtTo2.Length <= 0)
            {
                PublicDim.ShowErrorMessage("计算出错！");
            }
            else
            {
                tbToX.Text = aPtTo2[0].X.ToString();
                tbToY.Text = aPtTo2[0].Y.ToString();
                tbToZ.Text = aPtTo2[0].Z.ToString();
            }
            #endregion
        }
        #endregion

        #region 私有方法
        #endregion
    }
}
