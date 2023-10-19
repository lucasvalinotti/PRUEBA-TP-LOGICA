namespace PRUEBA_TP_LOGICA
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
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
            this.gbMetodos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimite)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuadro)).BeginInit();
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
            chartArea1.AxisX.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisX2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.AxisY2.Enabled = System.Windows.Forms.DataVisualization.Charting.AxisEnabled.False;
            chartArea1.BackColor = System.Drawing.Color.Silver;
            chartArea1.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.Name = "ChartArea1";
            this.cuadro.ChartAreas.Add(chartArea1);
            this.cuadro.IsSoftShadows = false;
            legend1.ForeColor = System.Drawing.Color.Transparent;
            legend1.HeaderSeparatorColor = System.Drawing.Color.Transparent;
            legend1.ItemColumnSeparatorColor = System.Drawing.Color.Transparent;
            legend1.Name = "Legend1";
            legend1.TitleForeColor = System.Drawing.Color.Transparent;
            legend1.TitleSeparatorColor = System.Drawing.Color.Transparent;
            this.cuadro.Legends.Add(legend1);
            this.cuadro.Location = new System.Drawing.Point(26, 118);
            this.cuadro.Name = "cuadro";
            this.cuadro.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series1.ChartArea = "ChartArea1";
            series1.IsVisibleInLegend = false;
            series1.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.Name = "Elementos";
            series1.YValuesPerPoint = 6;
            this.cuadro.Series.Add(series1);
            this.cuadro.Size = new System.Drawing.Size(775, 326);
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
            // frmMetodos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 461);
            this.Controls.Add(this.cmdVerOriginal);
            this.Controls.Add(this.cuadro);
            this.Controls.Add(this.cmdOrdenar);
            this.Controls.Add(this.cmdCrear);
            this.Controls.Add(this.nudLimite);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbMetodos);
            this.Name = "frmMetodos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Metodos de Ordenamiento";
            this.gbMetodos.ResumeLayout(false);
            this.gbMetodos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLimite)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cuadro)).EndInit();
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
    }
}

