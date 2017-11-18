using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDiscreta2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Calcular_Btm_Click(object sender, EventArgs e)
        {
        }


        private int[] Dijkstra(int start, int end)
        {
            bool[] done = new bool[8];
            int[] parent = new int[8];
            int[] distances = new int[8];

            for (int i = 0; i < done.Length; i++)
                done[i] = false;
            for (int i = 0; i < parent.Length; i++)
                parent[i] = -1;
            for (int i = 0; i < distances.Length; i++)
                distances[i] = int.MaxValue;

            distances[start] = 0;
            int current = start;

            while (!done[current])
            {
                done[current] = true;
                for (int i = 0; i < 8; i++)
                {
                    if (graph[current, i] != int.MaxValue)
                    {
                        int dist = graph[current, i] + distances[current];
                        if (dist < distances[i])
                        {
                            distances[i] = dist;
                            parent[i] = current;
                        }
                    }
                }
                int min = int.MaxValue;
                for (int i = 0; i < 8; i++)
                {
                    if (distances[i] < min && !done[i])
                    {
                        current = i;
                        min = distances[i];
                    }
                }
            }
            return parent;
        }
}


