using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiscreta2
{
    class Conexiones
    {
        string destino;
        int peso = 0;

        public void setpeso(int _p)
        {
            peso = _p;
        }
        public int getpeso()
        {
            return peso;
        }


        public void setdestino(string _n)
        {
            destino = _n;
        }
        public string getdestino()
        {
            return destino;
        }
    }
}
