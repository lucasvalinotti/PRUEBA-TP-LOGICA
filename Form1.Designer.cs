﻿namespace PRUEBA_TP_LOGICA
{
    partial class frmMetodos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gbMetodos = new System.Windows.Forms.GroupBox();
            this.optSelectionSort = new System.Windows.Forms.RadioButton();
            this.optMergeSort = new System.Windows.Forms.RadioButton();
            this.optQuickSort = new System.Windows.Forms.RadioButton();
            this.optBubbleSort = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.nudLimite = new System.Windows.Forms.NumericUpDown();
            this.cmdCrear = new System.Windows.Forms.Button();
            this.cmdOrdenar = new System.Windows.Forms.Button();
            this.cuadro = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.cmdVerOriginal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmdCambiar = new System.Windows.Forms.Button();
            this.optArea = new System.Windows.Forms.RadioButton();
            this.optPuntos = new System.Windows.Forms.RadioButton();
            this.optColumnas = new System.Windows.Forms.RadioButton();
            this.gbMetodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuadro)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbMetodos
            // 
            this.gbMetodos.Controls.Add(this.optSelectionSort);
            this.gbMetodos.Controls.Add(this.optMergeSort);
            this.gbMetodos.Controls.Add(this.optQuickSort);
            this.gbMetodos.Controls.Add(this.optBubbleSort);
            this.gbMetodos.Location = new System.Drawing.Point(12, 12);
            this.gbMetodos.Name = "gbMetodos";
            this.gbMetodos.Size = new System.Drawing.Size(282, 100);
            this.gbMetodos.TabIndex = 0;
            this.gbMetodos.TabStop = false;
            this.gbMetodos.Text = "Seleccionar Metodo";
            // 
            // optSelectionSort
            // 
            this.optSelectionSort.AutoSize = true;
            this.optSelectionSort.Location = new System.Drawing.Point(141, 63);
            this.optSelectionSort.Name = "optSelectionSort";
            this.optSelectionSort.Size = new System.Drawing.Size(88, 17);
            this.optSelectionSort.TabIndex = 4;
            this.optSelectionSort.Text = "SelectionSort";
            this.optSelectionSort.UseVisualStyleBackColor = true;
            // 
            // optMergeSort
            // 
            this.optMergeSort.AutoSize = true;
            this.optMergeSort.Location = new System.Drawing.Point(32, 63);
            this.optMergeSort.Name = "optMergeSort";
            this.optMergeSort.Size = new System.Drawing.Size(74, 17);
            this.optMergeSort.TabIndex = 3;
            this.optMergeSort.Text = "MergeSort";
            this.optMergeSort.UseVisualStyleBackColor = true;
            // 
            // optQuickSort
            // 
            this.optQuickSort.AutoSize = true;
            this.optQuickSort.Location = new System.Drawing.Point(141, 31);
            this.optQuickSort.Name = "optQuickSort";
            this.optQuickSort.Size = new System.Drawing.Size(72, 17);
            this.optQuickSort.TabIndex = 2;
            this.optQuickSort.Text = "QuickSort";
            this.optQuickSort.UseVisualStyleBackColor = true;
            // 
            // optBubbleSort
            // 
            this.optBubbleSort.AutoSize = true;
            this.optBubbleSort.Checked = true;
            this.optBubbleSort.Location = new System.Drawing.Point(32, 31);
            this.optBubbleSort.Name = "optBubbleSort";
            this.optBubbleSort.Size = new System.Drawing.Size(77, 17);
            this.optBubbleSort.TabIndex = 1;
            this.optBubbleSort.TabStop = true;
            this.optBubbleSort.Text = "BubbleSort";
            this.optBubbleSort.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(329, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cantidad de Elementos";
            // 
            // nudLimite
            // 
            this.nudLimite.Location = new System.Drawing.Point(332, 33);
            this.nudLimite.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudLimite.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLimite.Name = "nudLimite";
            this.nudLimite.Size = new System.Drawing.Size(156, 20);
            this.nudLimite.TabIndex = 2;
            this.nudLimite.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cmdCrear
            // 
            this.cmdCrear.Location = new System.Drawing.Point(332, 62);
            this.cmdCrear.Name = "cmdCrear";
            this.cmdCrear.Size = new System.Drawing.Size(75, 23);
            this.cmdCrear.TabIndex = 3;
            this.cmdCrear.Text = "Crear";
            this.cmdCrear.UseVisualStyleBackColor = true;
            this.cmdCrear.Click += new System.EventHandler(this.cmdCrear_Click);
            // 
            // cmdOrdenar
            // 
            this.cmdOrdenar.Location = new System.Drawing.Point(413, 62);
            this.cmdOrdenar.Name = "cmdOrdenar";
            this.cmdOrdenar.Size = new System.Drawing.Size(75, 23);
            this.cmdOrdenar.TabIndex = 4;
            this.cmdOrdenar.Text = "Ordenar";
            this.cmdOrdenar.UseVisualStyleBackColor = true;
            this.cmdOrdenar.Click += new System.EventHandler(this.cmdOrdenar_Click);
            // 
            // cuadro
            // 
            this.cuadro.AntiAliasing = System.Windows.Forms.DataVisualization.Charting.AntiAliasingStyles.None;
            this.cuadro.BackColor = System.Drawing.Color.Transparent;
            this.cuadro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cuadro.BorderSkin.BackColor = System.Drawing.Color.Black;
            chartArea2.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea2.BackColor = System.Drawing.SystemColors.ControlLight;
            chartArea2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            this.cuadro.ChartAreas.Add(chartArea2);
            this.cuadro.IsSoftShadows = false;
            legend2.Enabled = false;
            legend2.ForeColor = System.Drawing.Color.Transparent;
            legend2.HeaderSeparatorColor = System.Drawing.Color.Transparent;
            legend2.ItemColumnSeparatorColor = System.Drawing.Color.Transparent;
            legend2.Name = "Legend1";
            legend2.TitleForeColor = System.Drawing.Color.Transparent;
            legend2.TitleSeparatorColor = System.Drawing.Color.Transparent;
            this.cuadro.Legends.Add(legend2);
            this.cuadro.Location = new System.Drawing.Point(3, 118);
            this.cuadro.Name = "cuadro";
            this.cuadro.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series2.IsVisibleInLegend = false;
            series2.LabelForeColor = System.Drawing.Color.Transparent;
            series2.Legend = "Legend1";
            series2.Name = "Elementos";
            series2.YValuesPerPoint = 6;
            this.cuadro.Series.Add(series2);
            this.cuadro.Size = new System.Drawing.Size(901, 447);
            this.cuadro.TabIndex = 5;
            this.cuadro.Text = "Cuadro";
            // 
            // cmdVerOriginal
            // 
            this.cmdVerOriginal.Location = new System.Drawing.Point(332, 91);
            this.cmdVerOriginal.Name = "cmdVerOriginal";
            this.cmdVerOriginal.Size = new System.Drawing.Size(156, 23);
            this.cmdVerOriginal.TabIndex = 6;
            this.cmdVerOriginal.Text = "Ver Original";
            this.cmdVerOriginal.UseVisualStyleBackColor = true;
            this.cmdVerOriginal.Click += new System.EventHandler(this.cmdVerOriginal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmdCambiar);
            this.groupBox1.Controls.Add(this.optArea);
            this.groupBox1.Controls.Add(this.optPuntos);
            this.groupBox1.Controls.Add(this.optColumnas);
            this.groupBox1.Location = new System.Drawing.Point(532, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 100);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafico";
            // 
            // cmdCambiar
            // 
            this.cmdCambiar.Location = new System.Drawing.Point(53, 57);
            this.cmdCambiar.Name = "cmdCambiar";
            this.cmdCambiar.Size = new System.Drawing.Size(163, 23);
            this.cmdCambiar.TabIndex = 7;
            this.cmdCambiar.Text = "Cambiar";
            this.cmdCambiar.UseVisualStyleBackColor = true;
            this.cmdCambiar.Click += new System.EventHandler(this.cmdCambiar_Click);
            // 
            // optArea
            // 
            this.optArea.AutoSize = true;
            this.optArea.Location = new System.Drawing.Point(190, 31);
            this.optArea.Name = "optArea";
            this.optArea.Size = new System.Drawing.Size(47, 17);
            this.optArea.TabIndex = 4;
            this.optArea.Text = "Area";
            this.optArea.UseVisualStyleBackColor = true;
            // 
            // optPuntos
            // 
            this.optPuntos.AutoSize = true;
            this.optPuntos.Location = new System.Drawing.Point(115, 31);
            this.optPuntos.Name = "optPuntos";
            this.optPuntos.Size = new System.Drawing.Size(58, 17);
            this.optPuntos.TabIndex = 2;
            this.optPuntos.Text = "Puntos";
            this.optPuntos.UseVisualStyleBackColor = true;
            // 
            // optColumnas
            // 
            this.optColumnas.AutoSize = true;
            this.optColumnas.Checked = true;
            this.optColumnas.Location = new System.Drawing.Point(34, 31);
            this.optColumnas.Name = "optColumnas";
            this.optColumnas.Size = new System.Drawing.Size(71, 17);
            this.optColumnas.TabIndex = 1;
            this.optColumnas.TabStop = true;
            this.optColumnas.Text = "Columnas";
            this.optColumnas.UseVisualStyleBackColor = true;
            // 
            // frmMetodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1027, 629);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmdVerOriginal);
            this.Controls.Add(this.cuadro);
            this.Controls.Add(this.cmdOrdenar);
            this.Controls.Add(this.cmdCrear);
            this.Controls.Add(this.nudLimite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbMetodos);
            this.MaximizeBox = false;
            this.Name = "frmMetodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metodos de Ordenamiento";
            this.Load += new System.EventHandler(this.frmMetodos_Load);
            this.gbMetodos.ResumeLayout(false);
            this.gbMetodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuadro)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbMetodos;
        private System.Windows.Forms.RadioButton optSelectionSort;
        private System.Windows.Forms.RadioButton optMergeSort;
        private System.Windows.Forms.RadioButton optQuickSort;
        private System.Windows.Forms.RadioButton optBubbleSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudLimite;
        private System.Windows.Forms.Button cmdCrear;
        private System.Windows.Forms.Button cmdOrdenar;
        private System.Windows.Forms.DataVisualization.Charting.Chart cuadro;
        private System.Windows.Forms.Button cmdVerOriginal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button cmdCambiar;
        private System.Windows.Forms.RadioButton optArea;
        private System.Windows.Forms.RadioButton optPuntos;
        private System.Windows.Forms.RadioButton optColumnas;
    }
}

