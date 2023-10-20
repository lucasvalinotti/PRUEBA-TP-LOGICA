using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Text;

namespace PRUEBA_TP_LOGICA
{
    public partial class frmMetodos : Form
    {
        int[] vector;
        Random r = new Random();
        public frmMetodos()
        {
            InitializeComponent();
        }

        private void cmdCrear_Click(object sender, EventArgs e)
        {
            vector = llenarVector(Convert.ToInt32(nudLimite.Value));
            graficar(vector);
        }
        
        private void cmdOrdenar_Click(object sender, EventArgs e)
        {
            int[] duplicado = new int[vector.Length];
            Array.Copy(vector, duplicado, vector.Length);
            if (optBubbleSort.Checked)
            {
                var bubble = new Task(() => { BubbleSort(duplicado);});
                bubble.Start();
                //BubbleSort(duplicado);
                //graficar(duplicado);
            }
            else if (optQuickSort.Checked)
            {
                var quick = new Task(() => { QuickSort(duplicado, 0, duplicado.Length - 1);});
                quick.Start();

                //QuickSort(duplicado, 0, duplicado.Length - 1);
                //graficar(duplicado);
            }
            else if (optSelectionSort.Checked)
            {
                var selection = new Task(() => { SelectionSort(duplicado); });
                selection.Start();
                //selection = new Thread(new ThreadStart()) ;
                //graficar(duplicado);
            }
            else if (optMergeSort.Checked)
            {
                var merge = new Task(() => { mergeSort(duplicado); });
                merge.Start();
            }
        }
        private void cmdVerOriginal_Click(object sender, EventArgs e)
        {
            graficar(vector);
            cuadro.Palette = ChartColorPalette.Bright;
        }
        
        private int[] llenarVector(int limite) 
        {
            int[] data = new int[limite];
            for (int i = 0; i < limite; i++)
            {
                data[i] = r.Next(1, 5000);
            }
            return data;
        }
        private void graficar(int[] data) 
        {
            if (cuadro.InvokeRequired)
            {
                cuadro.Invoke(new MethodInvoker(delegate
                {
                    cuadro.Series["Elementos"].Points.Clear();
                }));
            }
            else
            {
                cuadro.Series["Elementos"].Points.Clear();
            }
            for (int i = 0; i < data.Length; i++)
            {
                if (cuadro.InvokeRequired)
                {
                    cuadro.Invoke(new MethodInvoker(delegate
                    {
                        Thread.Sleep(100);
                        cuadro.Series["Elementos"].Points.Add(data[i]);
                    }));
                }
                else
                {
                    cuadro.Series["Elementos"].Points.Add(data[i]);
                }
            }
        }
        private void BubbleSort(int[] data) 
        {
            Series serie = new Series();

            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length - i - 1; j++)
                {
                    if (cuadro.InvokeRequired)
                    {
                        cuadro.Invoke(new MethodInvoker(delegate
                        {
                            if (data[j] > data[j+1])
                            {
                                int auxNum = data[j];
                                data[j] = data[j+1];
                                cuadro.Series["Elementos"].Points[j] = serie.Points.Add(data[j+1]);
                                data[j+1] = auxNum;
                                cuadro.Series["Elementos"].Points[j+1] = serie.Points.Add(auxNum);
                            }

                        }));
                    }
                    else
                    {
                        if (data[j] > data[j + 1])
                        {
                            int auxNum = data[j];
                            data[j] = data[j + 1];
                            cuadro.Series["Elementos"].Points[j] = serie.Points.Add(data[j + 1]);
                            data[j + 1] = auxNum;
                            cuadro.Series["Elementos"].Points[j + 1] = serie.Points.Add(auxNum);
                        }
                    }
                }          
            }
        }

        public void SelectionSort(int[] data) 
        {
            Series serie = new Series();
            int posicion; // posición del menor valor
            int menor; // menor valor para las comparaciones
                       // con i controlamos la cantidad de repeticiones del proceso
            for (int i = 0; i < data.Length - 1; i++)
            {
                posicion = i;
                menor = data[posicion];
                // con j controlamos las posiciones que se comparan
                for (int j = i; j < data.Length; j++)
                {
                    // comparar el valor de la posición j con menor
                    if (data[j] < menor)
                    {
                        menor = data[j]; // guardar el valor
                        posicion = j; // guardar la posición
                    }
                }
                // intercambiar el elemento menor con el de la posición i

                if (cuadro.InvokeRequired)
                {
                    cuadro.Invoke(new MethodInvoker(delegate
                    {
                        
                        int aux = data[i]; // se usa una variable auxiliar
                        data[i] = data[posicion];
                        cuadro.Series["Elementos"].Points[i] = serie.Points.Add(data[posicion]);
                        data[posicion] = aux;
                        cuadro.Series["Elementos"].Points[posicion] = serie.Points.Add(aux);
                        Thread.Sleep(1);
                    }));
                }
                else
                {
                    int aux = data[i]; // se usa una variable auxiliar
                    data[i] = data[posicion];
                    cuadro.Series["Elementos"].Points[i] = serie.Points.Add(data[posicion]);
                    data[posicion] = aux;
                    cuadro.Series["Elementos"].Points[posicion] = serie.Points.Add(aux);
                    Thread.Sleep(1);
                }
            }
        }

        private void QuickSort(int[] data, int low, int high) 
        {
            if (low < high)
            {
                int pi = Partition(data, low, high);

                QuickSort(data, low, pi-1);
                QuickSort(data, pi + 1, high);
            }
        }

        private int Partition(int[] data, int low, int high) 
        {
            Series serie = new Series();
            int pivot = data[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (cuadro.InvokeRequired)
                {
                    cuadro.Invoke(new MethodInvoker(delegate
                    {

                        if (data[j] <= pivot)
                        {
                            i++;
                            int auxUno = data[i];
                            data[i] = data[j];
                            cuadro.Series["Elementos"].Points[i] = serie.Points.Add(data[j]);
                            data[j] = auxUno;
                            cuadro.Series["Elementos"].Points[j] = serie.Points.Add(auxUno);
                            Thread.Sleep(1);

                        }

                    }));
                }
                else
                {
                    i++;
                    int auxUno = data[i];
                    data[i] = data[j];
                    cuadro.Series["Elementos"].Points[i] = serie.Points.Add(data[j]);
                    data[j] = auxUno;
                    cuadro.Series["Elementos"].Points[j] = serie.Points.Add(auxUno);
                    Thread.Sleep(1);

                }
            }
            if (cuadro.InvokeRequired)
            {
                cuadro.Invoke(new MethodInvoker(delegate
                {

                    int auxDos = data[i+1];
                    data[i + 1] = data[high];
                    cuadro.Series["Elementos"].Points[i + 1] = serie.Points.Add(data[high]);

                    data[high] = auxDos;
                    cuadro.Series["Elementos"].Points[high] = serie.Points.Add(auxDos);
                    Thread.Sleep(1);


                }));
            }
            else
            {
                int auxDos = data[i + 1];
                data[i + 1] = data[high];
                cuadro.Series["Elementos"].Points[data[i + 1]] = serie.Points.Add(data[high]);

                data[high] = auxDos;
                cuadro.Series["Elementos"].Points[data[high]] = serie.Points.Add(auxDos);
                Thread.Sleep(1);

            }
            return i + 1;

        }

        private void mergeSort(int[] array)
        {
            //Thread.Sleep(2000);

            int length = array.Length;
            if (length <= 1) return; //base case

            int middle = length / 2;
            int[] leftArray = new int[middle];
            int[] rightArray = new int[length - middle];

            int i = 0; //left array
            int j = 0; //right array

            for (; i < length; i++)
            {
                if (i < middle)
                {
                    leftArray[i] = array[i];
                }
                else
                {
                    rightArray[j] = array[i];
                    j++;
                }
            }
            mergeSort(leftArray);
            mergeSort(rightArray);
            merge(leftArray, rightArray, array);
        }

        private void merge(int[] leftArray, int[] rightArray, int[] array)
        {
            Series serie1 = new Series();

            int leftSize = array.Length / 2;
            int rightSize = array.Length - leftSize;
            int i = 0, l = 0, r = 0; //indices

            //check the conditions for merging
            while (l < leftSize && r < rightSize)
            {
                if (cuadro.InvokeRequired)
                {
                    cuadro.Invoke(new MethodInvoker(delegate
                    {
                        if (leftArray[l] < rightArray[r])
                        {
                            array[i] = leftArray[l];
                            cuadro.Series["Elementos"].Points[i] = serie1.Points.Add(leftArray[l]);
                            i++;
                            l++;
                            Thread.Sleep(1);
                        }
                        else
                        {
                            array[i] = rightArray[r];
                            cuadro.Series["Elementos"].Points[i] = serie1.Points.Add(rightArray[r]);
                            i++;
                            r++;
                            Thread.Sleep(1);
                        }
                        }));
                }
                else
                {
                    if (leftArray[l] < rightArray[r])
                    {
                        array[i] = leftArray[l];
                        cuadro.Series["Elementos"].Points[i] = serie1.Points.Add(leftArray[l]);
                        i++;
                        l++;
                        Thread.Sleep(1);
                    }
                    else
                    {
                        array[i] = rightArray[r];
                        cuadro.Series["Elementos"].Points[i] = serie1.Points.Add(rightArray[r]);
                        i++;
                        r++;    
                        Thread.Sleep(1);
                    }
                }
            }
            while (l < leftSize)
            {
                if (cuadro.InvokeRequired)
                {
                    cuadro.Invoke(new MethodInvoker(delegate
                    {
                        array[i] = leftArray[l];
                        cuadro.Series["Elementos"].Points[i] = serie1.Points.Add(leftArray[l]);
                        i++;
                        l++;
                        Thread.Sleep(1);
                    }));
                }
                else
                {
                    array[i] = leftArray[l];
                    cuadro.Series["Elementos"].Points[i] = serie1.Points.Add(leftArray[l]);
                    i++;
                    l++;
                    Thread.Sleep(1);
                }
            }
            while (r < rightSize)
            {
                if (cuadro.InvokeRequired)
                {
                    cuadro.Invoke(new MethodInvoker(delegate
                    {
                        array[i] = rightArray[r];
                        cuadro.Series["Elementos"].Points[i] = serie1.Points.Add(rightArray[r]);
                        i++;
                        r++;
                        Thread.Sleep(1);
                    }));
                }
                else
                {
                    array[i] = rightArray[r];
                    cuadro.Series["Elementos"].Points[i] = serie1.Points.Add(rightArray[r]);
                    i++;
                    r++;
                    Thread.Sleep(1);
                }
            }
        }

     
        private void frmMetodos_Load(object sender, EventArgs e)
        {
            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
            cuadro.Size = new Size(1360, 580);
        }

        private void cmdCambiar_Click(object sender, EventArgs e)
        {
            if (optColumnas.Checked)
            {
                cuadro.Series["Elementos"].ChartType = SeriesChartType.Column;
            }
            else if (optPuntos.Checked)
            {
                cuadro.Series["Elementos"].ChartType = SeriesChartType.Point;
            }
            else if (optArea.Checked)
            {
                cuadro.Series["Elementos"].ChartType = SeriesChartType.Area;
            }
        }
    }
}

