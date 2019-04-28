using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;

namespace Converter
{
    public class SevenParam
    {
        /// <summary>根据3个或者3个以上的点的两套坐标系的坐标计算7参数(最小二乘法) 适用于小角度转换 bursa模型</summary> 
        /// <param name="aPtSource">已知点的源坐标系的坐标</param> 
        /// <param name="aPtTo">已知点的新坐标系的坐标</param> 
        /// <param name="sep">输出: 7参数</param> 
        public static void Calc7Para(PointXYZdbl[] aPtSource, PointXYZdbl[] aPtTo, ref SevenP sep) { 
            #region 给A B 矩阵赋值  
            double[,] arrA = new double[aPtSource.Length * 3, 7]; // 如果是4个已知点， 12 * 7矩阵  A*X=B中的矩阵A 
            for (int i = 0; i <= arrA.GetLength(0) - 1; i++)
                { 
                if (i % 3 == 0)
                { 
                    arrA[i, 0] = 1;
                    arrA[i, 1] = 0;
                    arrA[i, 2] = 0; 
                    arrA[i, 3] = aPtSource[i / 3].X;
                    arrA[i, 4] = 0; 
                    arrA[i, 5] = -aPtSource[i / 3].Z;
                    arrA[i, 6] = aPtSource[i / 3].Y;
                } 
                else if (i % 3 == 1)
                { 
                    arrA[i, 0] = 0;
                    arrA[i, 1] = 1;
                    arrA[i, 2] = 0; 
                    arrA[i, 3] = aPtSource[i / 3].Y;
                    arrA[i, 4] = aPtSource[i / 3].Z;
                    arrA[i, 5] = 0; 
                    arrA[i, 6] = -aPtSource[i / 3].X;
                } 
                else if (i % 3 == 2)
                { 
                    arrA[i, 0] = 0;
                    arrA[i, 1] = 0;
                    arrA[i, 2] = 1; 
                    arrA[i, 3] = aPtSource[i / 3].Z;
                    arrA[i, 4] = -aPtSource[i / 3].Y;
                    arrA[i, 5] = aPtSource[i / 3].X;
                    arrA[i, 6] = 0;
                }
            }
            double[,] arrB = new double[aPtSource.Length * 3, 1]; // A * X = B 中的矩阵B, 如果有4个点，就是 12*1矩阵 
            for (int i = 0; i <= arrB.GetLength(0) - 1; i++)
            { 
                if (i % 3 == 0)
                { 
                    arrB[i, 0] = aPtTo[i / 3].X;
                } 
                else if (i % 3 == 1)
                { 
                    arrB[i, 0] = aPtTo[i / 3].Y;
                } 
                else if (i % 3 == 2)
                { 
                    arrB[i, 0] = aPtTo[i / 3].Z; 
                }
            } 

            #endregion 

            Matrix mtrA = new Matrix(arrA); // A矩阵
            Matrix mtrAT = mtrA.Transpose(); // A的转置 
            Matrix mtrB = new Matrix(arrB); // B矩阵
            Matrix mtrATmulA = mtrAT.Multiply(mtrA); // A的转置×A 
            // 求(A的转置×A)的逆矩阵 
            mtrATmulA.InvertGaussJordan(); 
            // A的转置 × B
            Matrix mtrATmulB = mtrAT.Multiply(mtrB); // A的转置 * B 
            // 结果 
            Matrix mtrResult = mtrATmulA.Multiply(mtrATmulB); 
            sep.Xdelta = mtrResult[0, 0];
            sep.Ydelta = mtrResult[1, 0];
            sep.Zdelta = mtrResult[2, 0];
            sep.scale = mtrResult[3, 0]; 
            sep.Ex = mtrResult[4, 0] / sep.scale;
            sep.Ey = mtrResult[5, 0] / sep.scale;
            sep.Ez = mtrResult[6, 0] / sep.scale;       
            // PS: 必须考虑cosA = 0 不能作为分母的情况     // Add code 
        }

        /// <summary> 
        /// 利用7参数求新坐标系的坐标(存在问题!) 
        /// </summary> 
        /// <param name="aPtSource">点的源坐标系的坐标</param> /// <param name="sep">已经知道的7参数</param>
        /// <param name="aPtTo">输出: 点的新坐标系的坐标</param> 
        public static void CalcXYZby7Para(PointXYZdbl[] aPtSource, SevenP sep, ref PointXYZdbl[] aPtTo)
        { 
            double k = sep.scale;
            double a2 = k * sep.Ex;
            double a3 = k * sep.Ey;
            double a4 = k * sep.Ez;  
            aPtTo = new PointXYZdbl[aPtSource.Length];  
            for (int i = 0; i <= aPtSource.Length - 1; i++)
            {
                aPtTo[i] = new PointXYZdbl();
                aPtTo[i].X = sep.Xdelta + k * aPtSource[i].X + 0 - a3 * aPtSource[i].Z + a4 * aPtSource[i].Y;
                aPtTo[i].Y = sep.Ydelta + k * aPtSource[i].Y + a2 * aPtSource[i].Z + 0 - a4 * aPtSource[i].X;
                aPtTo[i].Z = sep.Zdelta + k * aPtSource[i].Z - a2 * aPtSource[i].Y + a3 * aPtSource[i].X + 0;
            } 
        } 
    }
}
