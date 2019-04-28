namespace Converter
{
    partial class ConvertForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btConvertPoint = new System.Windows.Forms.Button();
            this.tbToZ = new Converter.NumberTextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbToY = new Converter.NumberTextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tbToX = new Converter.NumberTextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tbSourceZ = new Converter.NumberTextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.tbSourceY = new Converter.NumberTextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tbSourceX = new Converter.NumberTextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvControlPoint = new System.Windows.Forms.DataGridView();
            this.ColSourceX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSourceY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSourceZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColToX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColToY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColToZ = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btComputeSenvenP = new System.Windows.Forms.Button();
            this.btAddPoint = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbParamZdelta = new Converter.NumberTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbParamYdelta = new Converter.NumberTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbParamXdelta = new Converter.NumberTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbParamScale = new Converter.NumberTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbParamZ = new Converter.NumberTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbParamY = new Converter.NumberTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbParamX = new Converter.NumberTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlPoint)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dgvControlPoint, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(824, 454);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btConvertPoint);
            this.panel3.Controls.Add(this.tbToZ);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.tbToY);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.tbToX);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.tbSourceZ);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.tbSourceY);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.tbSourceX);
            this.panel3.Controls.Add(this.label17);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(23, 377);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(778, 54);
            this.panel3.TabIndex = 6;
            // 
            // btConvertPoint
            // 
            this.btConvertPoint.Location = new System.Drawing.Point(665, 4);
            this.btConvertPoint.Name = "btConvertPoint";
            this.btConvertPoint.Size = new System.Drawing.Size(110, 23);
            this.btConvertPoint.TabIndex = 19;
            this.btConvertPoint.Text = "坐标转换(&P)";
            this.btConvertPoint.UseVisualStyleBackColor = true;
            this.btConvertPoint.Click += new System.EventHandler(this.btConvertPoint_Click);
            // 
            // tbToZ
            // 
            this.tbToZ.Location = new System.Drawing.Point(489, 29);
            this.tbToZ.Name = "tbToZ";
            this.tbToZ.ReadOnly = true;
            this.tbToZ.Size = new System.Drawing.Size(100, 21);
            this.tbToZ.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(441, 29);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 17;
            this.label11.Text = "目标Z";
            // 
            // tbToY
            // 
            this.tbToY.Location = new System.Drawing.Point(303, 29);
            this.tbToY.Name = "tbToY";
            this.tbToY.ReadOnly = true;
            this.tbToY.Size = new System.Drawing.Size(100, 21);
            this.tbToY.TabIndex = 16;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(252, 29);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 12);
            this.label12.TabIndex = 15;
            this.label12.Text = "目标Y";
            // 
            // tbToX
            // 
            this.tbToX.Location = new System.Drawing.Point(118, 29);
            this.tbToX.Name = "tbToX";
            this.tbToX.ReadOnly = true;
            this.tbToX.Size = new System.Drawing.Size(100, 21);
            this.tbToX.TabIndex = 14;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(65, 29);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 12);
            this.label13.TabIndex = 13;
            this.label13.Text = "目标X";
            // 
            // tbSourceZ
            // 
            this.tbSourceZ.Location = new System.Drawing.Point(489, 5);
            this.tbSourceZ.Name = "tbSourceZ";
            this.tbSourceZ.Size = new System.Drawing.Size(100, 21);
            this.tbSourceZ.TabIndex = 10;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(441, 5);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(23, 12);
            this.label15.TabIndex = 9;
            this.label15.Text = "源Z";
            // 
            // tbSourceY
            // 
            this.tbSourceY.Location = new System.Drawing.Point(303, 5);
            this.tbSourceY.Name = "tbSourceY";
            this.tbSourceY.Size = new System.Drawing.Size(100, 21);
            this.tbSourceY.TabIndex = 8;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(252, 5);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(23, 12);
            this.label16.TabIndex = 7;
            this.label16.Text = "源Y";
            // 
            // tbSourceX
            // 
            this.tbSourceX.Location = new System.Drawing.Point(118, 5);
            this.tbSourceX.Name = "tbSourceX";
            this.tbSourceX.Size = new System.Drawing.Size(100, 21);
            this.tbSourceX.TabIndex = 6;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(65, 5);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 12);
            this.label17.TabIndex = 5;
            this.label17.Text = "源X";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 5);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(65, 12);
            this.label18.TabIndex = 4;
            this.label18.Text = "坐标转换：";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "控制点：";
            // 
            // dgvControlPoint
            // 
            this.dgvControlPoint.AllowUserToAddRows = false;
            this.dgvControlPoint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvControlPoint.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSourceX,
            this.ColSourceY,
            this.ColSourceZ,
            this.ColToX,
            this.ColToY,
            this.ColToZ});
            this.dgvControlPoint.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvControlPoint.Location = new System.Drawing.Point(23, 23);
            this.dgvControlPoint.Name = "dgvControlPoint";
            this.dgvControlPoint.RowTemplate.Height = 23;
            this.dgvControlPoint.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvControlPoint.Size = new System.Drawing.Size(778, 253);
            this.dgvControlPoint.TabIndex = 0;
            // 
            // ColSourceX
            // 
            this.ColSourceX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColSourceX.HeaderText = "源坐标X";
            this.ColSourceX.Name = "ColSourceX";
            // 
            // ColSourceY
            // 
            this.ColSourceY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColSourceY.HeaderText = "源坐标Y";
            this.ColSourceY.Name = "ColSourceY";
            // 
            // ColSourceZ
            // 
            this.ColSourceZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColSourceZ.HeaderText = "源坐标Z";
            this.ColSourceZ.Name = "ColSourceZ";
            // 
            // ColToX
            // 
            this.ColToX.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColToX.HeaderText = "目标坐标X";
            this.ColToX.Name = "ColToX";
            // 
            // ColToY
            // 
            this.ColToY.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColToY.HeaderText = "目标坐标Y";
            this.ColToY.Name = "ColToY";
            // 
            // ColToZ
            // 
            this.ColToZ.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColToZ.HeaderText = "目标坐标Z";
            this.ColToZ.Name = "ColToZ";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btComputeSenvenP);
            this.panel1.Controls.Add(this.btAddPoint);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(23, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(778, 29);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "*要删除坐标点请选中行后按Delete键删除";
            // 
            // btComputeSenvenP
            // 
            this.btComputeSenvenP.Location = new System.Drawing.Point(664, 1);
            this.btComputeSenvenP.Name = "btComputeSenvenP";
            this.btComputeSenvenP.Size = new System.Drawing.Size(110, 23);
            this.btComputeSenvenP.TabIndex = 1;
            this.btComputeSenvenP.Text = "计算七参数(&P)";
            this.btComputeSenvenP.UseVisualStyleBackColor = true;
            this.btComputeSenvenP.Click += new System.EventHandler(this.btComputeSenvenP_Click);
            // 
            // btAddPoint
            // 
            this.btAddPoint.Location = new System.Drawing.Point(537, 1);
            this.btAddPoint.Name = "btAddPoint";
            this.btAddPoint.Size = new System.Drawing.Size(110, 23);
            this.btAddPoint.TabIndex = 0;
            this.btAddPoint.Text = "添加控制点(&A)";
            this.btAddPoint.UseVisualStyleBackColor = true;
            this.btAddPoint.Click += new System.EventHandler(this.btAddPoint_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tbParamZdelta);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.tbParamYdelta);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.tbParamXdelta);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.tbParamScale);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.tbParamZ);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.tbParamY);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbParamX);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(23, 317);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(778, 54);
            this.panel2.TabIndex = 5;
            // 
            // tbParamZdelta
            // 
            this.tbParamZdelta.Location = new System.Drawing.Point(489, 29);
            this.tbParamZdelta.Name = "tbParamZdelta";
            this.tbParamZdelta.Size = new System.Drawing.Size(100, 21);
            this.tbParamZdelta.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(441, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "Zdelta";
            // 
            // tbParamYdelta
            // 
            this.tbParamYdelta.Location = new System.Drawing.Point(303, 29);
            this.tbParamYdelta.Name = "tbParamYdelta";
            this.tbParamYdelta.Size = new System.Drawing.Size(100, 21);
            this.tbParamYdelta.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(252, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 15;
            this.label9.Text = "Ydelta";
            // 
            // tbParamXdelta
            // 
            this.tbParamXdelta.Location = new System.Drawing.Point(118, 29);
            this.tbParamXdelta.Name = "tbParamXdelta";
            this.tbParamXdelta.Size = new System.Drawing.Size(100, 21);
            this.tbParamXdelta.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(65, 29);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "Xdelta";
            // 
            // tbParamScale
            // 
            this.tbParamScale.Location = new System.Drawing.Point(672, 5);
            this.tbParamScale.Name = "tbParamScale";
            this.tbParamScale.Size = new System.Drawing.Size(100, 21);
            this.tbParamScale.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(628, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 11;
            this.label7.Text = "Scale";
            // 
            // tbParamZ
            // 
            this.tbParamZ.Location = new System.Drawing.Point(489, 5);
            this.tbParamZ.Name = "tbParamZ";
            this.tbParamZ.Size = new System.Drawing.Size(100, 21);
            this.tbParamZ.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(441, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "△Z";
            // 
            // tbParamY
            // 
            this.tbParamY.Location = new System.Drawing.Point(303, 5);
            this.tbParamY.Name = "tbParamY";
            this.tbParamY.Size = new System.Drawing.Size(100, 21);
            this.tbParamY.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(252, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "△Y";
            // 
            // tbParamX
            // 
            this.tbParamX.Location = new System.Drawing.Point(118, 5);
            this.tbParamX.Name = "tbParamX";
            this.tbParamX.Size = new System.Drawing.Size(100, 21);
            this.tbParamX.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(65, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "△X";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "七参数：";
            // 
            // ConvertForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 454);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConvertForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvControlPoint)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dgvControlPoint;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSourceX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSourceY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSourceZ;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColToX;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColToY;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColToZ;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btComputeSenvenP;
        private System.Windows.Forms.Button btAddPoint;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private NumberTextBox tbParamZdelta;
        private System.Windows.Forms.Label label8;
        private NumberTextBox tbParamYdelta;
        private System.Windows.Forms.Label label9;
        private NumberTextBox tbParamXdelta;
        private System.Windows.Forms.Label label10;
        private NumberTextBox tbParamScale;
        private System.Windows.Forms.Label label7;
        private NumberTextBox tbParamZ;
        private System.Windows.Forms.Label label6;
        private NumberTextBox tbParamY;
        private System.Windows.Forms.Label label5;
        private NumberTextBox tbParamX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private NumberTextBox tbToZ;
        private System.Windows.Forms.Label label11;
        private NumberTextBox tbToY;
        private System.Windows.Forms.Label label12;
        private NumberTextBox tbToX;
        private System.Windows.Forms.Label label13;
        private NumberTextBox tbSourceZ;
        private System.Windows.Forms.Label label15;
        private NumberTextBox tbSourceY;
        private System.Windows.Forms.Label label16;
        private NumberTextBox tbSourceX;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btConvertPoint;
    }
}