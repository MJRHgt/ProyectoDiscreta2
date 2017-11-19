using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiscreta2
{
    class ciudad
    {
        private string nombre;
        private LinkedList<Conexiones> conexiones = new LinkedList<Conexiones>();
        private int numbConections;

        public void setname(string _n)
        {
            nombre = _n;
        }
        public string getnombre()
        {
            return nombre;
        }
        public int getNumbConections()
        {
            return numbConections;
        }

        public void addConection(string destination)
        {
            conexiones.AddLast(new Conexiones());
            conexiones.ElementAt(numbConections).setdestino(destination);
            numbConections++;
        }

        public Conexiones getConectionByIndex(int x)
        {
            return conexiones.ElementAt(x);
        }

        public Conexiones getConectionByName(string x)
        {
            for (int i = 0; i < numbConections; i++)
            {
                if (conexiones.ElementAt(i).getdestino() == x)
                {
                    return conexiones.ElementAt(i);
                }
            }
            return null;
        }
    }
}
