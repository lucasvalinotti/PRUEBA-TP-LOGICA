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
                cuadro.Series["Elementos"].Palette = ChartColorPalette.Pastel;
                BubbleSort(duplicado);
                graficar(duplicado);
            }
            else if (optQuickSort.Checked)
            {
                cuadro.Series["Elementos"].Palette = ChartColorPalette.Bright;
                QuickSort(duplicado, 0, duplicado.Length - 1);
                graficar(duplicado);
            }
            else if (optSelectionSort.Checked)
            {
                cuadro.Series["Elementos"].Palette = ChartColorPalette.Berry;
                SelectionSort(duplicado);
                graficar(duplicado);
            }
        }
        private void cmdVerOriginal_Click(object sender, EventArgs e)
        {
            graficar(vector);
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
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length - i - 1; j++)
                {
                    if (data[j] > data[j+1])
                    {
                        int auxNum = data[j];
                        data[j] = data[j+1];
                        data[j+1] = auxNum;
                    }        
                }          
            }
        }

        public void SelectionSort(int[] data) 
        {
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
                int aux = data[i]; // se usa una variable auxiliar
                data[i] = data[posicion];
                data[posicion] = aux;
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
            int pivot = data[high];
            int i = low - 1;

            for (int j = low; j < high; j++)
            {
                if (data[j] <= pivot)
                {
                    i++;
                    int auxUno = data[i];
                    data[i] = data[j];
                    data[j] = auxUno;
                }
            }
            int auxDos = data[i+1];
            data[i + 1] = data[high];
            data[high] = auxDos;
            return i + 1;
        }
    }
}
