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

        LinkedList<ciudad> ciudades = new LinkedList<ciudad>();//una linkedlist que almacenara el objeto ciudad que tiene nombre y conexiones
        int size = 0;
        ciudad prueba = new ciudad();

        //=======================================================Start=============================================================
        private void Comenzar_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(1);
        }//Cambia a la primera pestaña
        //=======================================================Start=============================================================


        //====================================================Add Cities=============================================================
        private void AddCities_btm_Add_Click(object sender, EventArgs e)
        {
            if (AddCities_txt_AddCity.Text != "" && !Existe(AddCities_txt_AddCity.Text))
            {
                ciudades.AddLast(new ciudad());
                ciudades.ElementAt(size).setname(AddCities_txt_AddCity.Text);
                AddCities_txt_AddCity.Clear();
                size++;
            }
            else
            {
                MessageBox.Show("Por favor ingrese una ciudad valida");
                AddCities_txt_AddCity.Clear();
            }
        }//añade ciudades al grafo(vertices)

        private void AddCities_btm_Ready_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(2);
            for (int i = 0; i < size; i++)
            {
                Connections_cb_Origin.Items.Add(ciudades.ElementAt(i).getnombre());
                Connections_cb_Destination.Items.Add(ciudades.ElementAt(i).getnombre());
            }//llena los combobox de la siguiente pestaña
        }//Cambia a la siguente pestaña
        //====================================================Add Cities=============================================================


        //====================================================Connections=============================================================
        private void Connections_btm_Add_Click(object sender, EventArgs e)
        {
            if ((Connections_cb_Origin.Text != "" && Connections_cb_Destination.Text != "") && (Connections_cb_Origin.Text != Connections_cb_Destination.Text))
            {
                string origen = Connections_cb_Origin.Text;
                string destino = Connections_cb_Destination.Text;
                Connections_cb_Origin.SelectedIndex = -1;
                Connections_cb_Destination.SelectedIndex = -1;

                if (ciudades.ElementAt(GetIndexSearchingCityByName(origen)).getConectionByName(destino) == null)
                {
                    ciudades.ElementAt(GetIndexSearchingCityByName(origen)).addConection(destino);
                    ciudades.ElementAt(GetIndexSearchingCityByName(destino)).addConection(origen);
                    Prices_cb_Connections.Items.Add(origen + " <--> " + destino);
                }
                else
                    MessageBox.Show("Esa conexion ya existe");
            }
            else
                MessageBox.Show("Por favor seleccione un origen y un destino valido");
        }//añade las conexiones existentes

        private void Connections_btm_Ready_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(3);
        }//Cambia a la siguente pestaña y llena el combobox
        //====================================================Connections=============================================================


        //=======================================================Prices=============================================================
        private void Prices_btm_Add_Click(object sender, EventArgs e)
        {
            try{
                string[] origenYdestino = Prices_cb_Connections.Text.Split(new[] { ' ', '<', '-', '>' }, StringSplitOptions.RemoveEmptyEntries);
                Prices_cb_Connections.Items.Remove(origenYdestino[0] + " <--> " + origenYdestino[1]);
                ciudades.ElementAt(GetIndexSearchingCityByName(origenYdestino[0])).getConectionByName(origenYdestino[1]).setpeso(int.Parse(Prices_txt_Price.Text));
                ciudades.ElementAt(GetIndexSearchingCityByName(origenYdestino[1])).getConectionByName(origenYdestino[0]).setpeso(int.Parse(Prices_txt_Price.Text));
                Prices_txt_Price.Text = "";
            }
            catch
            {
                MessageBox.Show("Ingrese un precio valido");
            }

            if (Prices_cb_Connections.Items.Count == 0)
                tabControl1.SelectTab(4);
        }//Añade el peso a las aristas y cambia cuando se añadieron todos los pesos
        //=======================================================Prices=============================================================


        //===================================================Set First And Last=======================================================
        private void SetFirstAndLast_cb_next_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(5);
        }//Se elije el origen y destino y se calcula Dijkstra
        //===================================================Set First And Last=======================================================


        //=======================================================Resutls=============================================================
        //=======================================================Resutls=============================================================


        //=====================================================Extra Methods=============================================================
        public int GetIndexSearchingCityByName(string name)
        {
            for (int i = 0; i < size; i++)
            {
                if (ciudades.ElementAt(i).getnombre() == name)
                {
                    return i;
                }
            }
            return -1;
        }

        public bool Existe(string name)
        {
            for (int i = 0; i < size; i++)
            {
                if (ciudades.ElementAt(i).getnombre() == name)
                {
                    return true;
                }
            }
            return false;
        }
        //=====================================================Extra Methods=============================================================









        /*Algoritmo que encontre en internet
        private int[] Dijkstra(string start, string end)
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
        */


    }
}


