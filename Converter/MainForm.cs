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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        Random rd = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            //计算七参数
            PointXYZdbl[] aPtSource = new PointXYZdbl[4];
            PointXYZdbl[] aPtTo = new PointXYZdbl[4];
            PointXYZdbl[] aPtSource2 = new PointXYZdbl[1];
            PointXYZdbl[] aPtTo2 = null;
            try
            {
                //抽样点
                aPtSource[0] = new PointXYZdbl();
                aPtSource[0].X = Convert.ToDouble(tbA_X1.Text);
                aPtSource[0].Y = Convert.ToDouble(tbA_Y1.Text);
                aPtSource[0].Z = Convert.ToDouble(tbA_Z1.Text);

                aPtSource[1] = new PointXYZdbl();
                aPtSource[1].X = Convert.ToDouble(tbA_X2.Text);
                aPtSource[1].Y = Convert.ToDouble(tbA_Y2.Text);
                aPtSource[1].Z = Convert.ToDouble(tbA_Z2.Text);

                aPtSource[2] = new PointXYZdbl();
                aPtSource[2].X = Convert.ToDouble(tbA_X3.Text);
                aPtSource[2].Y = Convert.ToDouble(tbA_Y3.Text);
                aPtSource[2].Z = Convert.ToDouble(tbA_Z3.Text);

                aPtSource[3] = new PointXYZdbl();
                aPtSource[3].X = Convert.ToDouble(tbB_X4.Text);
                aPtSource[3].Y = Convert.ToDouble(tbB_Y4.Text);
                aPtSource[3].Z = Convert.ToDouble(tbB_Z4.Text);

                aPtTo[0] = new PointXYZdbl();
                aPtTo[0].X = Convert.ToDouble(tbB_X1.Text);
                aPtTo[0].Y = Convert.ToDouble(tbB_Y1.Text);
                aPtTo[0].Z = Convert.ToDouble(tbB_Z1.Text);

                aPtTo[1] = new PointXYZdbl();
                aPtTo[1].X = Convert.ToDouble(tbB_X2.Text);
                aPtTo[1].Y = Convert.ToDouble(tbB_Y2.Text);
                aPtTo[1].Z = Convert.ToDouble(tbB_Z2.Text);

                aPtTo[2] = new PointXYZdbl();
                aPtTo[2].X = Convert.ToDouble(tbB_X3.Text);
                aPtTo[2].Y = Convert.ToDouble(tbB_Y3.Text);
                aPtTo[2].Z = Convert.ToDouble(tbB_Z3.Text);

                aPtTo[3] = new PointXYZdbl();
                aPtTo[3].X = Convert.ToDouble(tbB_X4.Text);
                aPtTo[3].Y = Convert.ToDouble(tbB_Y4.Text);
                aPtTo[3].Z = Convert.ToDouble(tbB_Z4.Text);

                //转换点
                aPtSource2[0] = new PointXYZdbl();
                aPtSource2[0].X = Convert.ToDouble(tbA_X.Text);
                aPtSource2[0].Y = Convert.ToDouble(tbA_Y.Text);
                aPtSource2[0].Z = Convert.ToDouble(tbA_Z.Text);
            }
            catch
            {
                MessageBox.Show("输入数据中可能存在为空或者不为数字的情形，请检查！");
                return;
            }

            //for (int i = 0; i < 4; i++)
            //{
            //    aPtSource[i] = new PointXYZdbl();
            //    aPtSource[i].X = rd.Next(0, 1000);
            //    aPtSource[i].Y= rd.Next(1000, 2000);
            //    aPtSource[i].Z = rd.Next(2000, 3000);

            //    aPtTo[i] = new PointXYZdbl();
            //    aPtTo[i].X = rd.Next(0, 1000);
            //    aPtTo[i].Y = rd.Next(1000, 2000);
            //    aPtTo[i].Z = rd.Next(2000, 3000);
            //}

            //计算七参数
            SevenP sp = new SevenP();
            SevenParam.Calc7Para(aPtSource, aPtTo, ref sp);
            if (sp == null)
            {
                MessageBox.Show("计算七参数出错，请检查输入点！");
                return;
            }

            
            //MessageBox.Show(sp.Ey.ToString());

            //坐标转换
            SevenParam.CalcXYZby7Para(aPtSource2, sp, ref aPtTo2);
            if (aPtTo2 == null || aPtTo2.Length <= 0)
            {
                MessageBox.Show("计算出错！");
            }
            else
            {
                tbB_X.Text = aPtTo2[0].X.ToString();
                tbB_Y.Text = aPtTo2[0].Y.ToString();
                tbB_Z.Text = aPtTo2[0].Z.ToString();
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {

        }
    }
}
