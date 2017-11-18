using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoDiscreta2
{
    class Grafo
    {
            private Vertice[] Vertices;
            private int[,] Matriz;
            public static int Indice = 0;
            private static int cont = 0;

            public Grafo(int cantVertices)
            {
                Vertices = new Vertice[cantVertices];

                for (int i = 0; i < cantVertices; i++)
                {
                    Vertices[i] = new Vertice();
                    Vertices[i].Etiqueta = i;
                }
                Matriz = new int[cantVertices, cantVertices];
            }

            public bool RevisarVertices(Vertice[] Vert1)
            {
                for (var i = 0; i < Vert1.Length; i++)
                {
                    if (Vert1[i].lleno == true)
                    {
                        cont++;
                    }
                }
                if (cont == Vert1.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public string EtiquetaVertice()
            {
                string nombre = "";

                for (int i = 0; i < Vertices.Length; i++)
                {
                    nombre += i.ToString() + ",";
                }
                return nombre;
            }

            public Vertice ObtenerInicioFin(int posicion)
            {
                return Vertices[posicion];
            }

            private void CrearMatriz()
            {
                foreach (Vertice vertice in Vertices)
                {
                    for (int i = 0; i < vertice.Fin.Count; i++)
                    {
                        Matriz[vertice.Etiqueta, vertice.Fin[i]] = 1;
                    }
                }
            }

            public void AgregarVertices(List<int> inicio, List<int> final)
            {
                for (int i = 0; i < inicio.Count; i++)
                {
                    Vertices[inicio[i]].Fin.Add(final[i]);
                    Vertices[final[i]].Fin.Add(inicio[i]);
                    Vertices[inicio[i]].nombre = i.ToString();
                }
                foreach (Vertice vertice in Vertices)
                {
                    for (int i = 0; i < vertice.Fin.Count; i++)
                    {
                        Vertices[vertice.Etiqueta].Destino.Add(Vertices[vertice.Fin[i]]);
                    }
                }
                CrearMatriz();
            }

            private int[] GradoVertice(Grafo grafo)
            {
                int[] ordenInts = new int[grafo.Vertices.Length];

                for (int i = 0; i < ordenInts.Length; i++)
                {
                    ordenInts[i] = grafo.Vertices[i].Grado();
                }
                Array.Sort(ordenInts);
                return ordenInts;
            }

            private bool GradosIguales(int[] aInts, int[] bInts)
            {
                for (int i = 0; i < aInts.Length; i++)
                {
                    if (aInts[i] == bInts[i])
                    {
                        continue;
                    }
                    else
                    {
                        return false;
                    }
                }
                return true;
            }

            public string posibles(Vertice[] vertices1, Vertice[] vertices2)
            {
                string resultado = "";

                for (int i = 0; i < vertices1.Length; i++)
                {
                    resultado += "(" + vertices1[i].Etiqueta + "," + vertices2[i].Etiqueta + ")" + " ";
                }
                return resultado;
            }

            private bool AristasIguales(Grafo grafo1, Grafo grafo2)
            {
                int t1 = 0;
                int t2 = 0;

                foreach (Vertice vertice in grafo1.Vertices)
                {
                    t1 += vertice.Grado();
                }

                foreach (Vertice vertice in grafo2.Vertices)
                {
                    t2 += vertice.Grado();
                }

                if ((t1 / 2) == (t2 / 2))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            private bool VerticesIguales(Grafo grafo1, Grafo grafo2)
            {
                if (grafo1.Vertices.Length == grafo2.Vertices.Length)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool KCompleto(Vertice[] graVertices1, Vertice[] graVertices2)
            {
                bool etiqueta = true;
                int Kcompleto = graVertices1.Length - 1;

                for (int i = 0; i < graVertices2.Length; i++)
                {
                    if (graVertices1[i].Grado() == Kcompleto)
                    {
                        if (graVertices2[i].Grado() == Kcompleto)
                        {
                            etiqueta = true;
                        }
                    }
                    else
                    {
                        etiqueta = false;
                    }
                }
                return etiqueta;
            }

            private string GrafoCompleto(Grafo grafo1, Grafo grafo2)
            {
                string resultado = "";

                for (int i = 0; i < grafo1.Vertices.Length; i++)
                {
                    resultado += "(" + grafo1.Vertices[i].Etiqueta + "," + grafo2.Vertices[i].Etiqueta + ") ,";
                }
                return resultado;
            }

            private Vertice[] Sort(Vertice[] vertices)
            {
                Vertice auxVertice = null;
                bool etiqueta = true;

                for (int i = 0; i < (vertices.Length - 1) && etiqueta; i++)
                {
                    etiqueta = false;
                    for (int j = 0; j < (vertices.Length - 1) && etiqueta; j++)
                    {
                        if (vertices[j + 1].Grado() > vertices[j].Grado())
                        {
                            auxVertice = vertices[j];
                            vertices[j] = vertices[j + 1];
                            vertices[j + 1] = auxVertice;
                            etiqueta = true;
                        }
                    }
                }
                return vertices;
            }

            public string Isomorfo(Grafo grafo1, Grafo grafo2)
            {
                if (!VerticesIguales(grafo1, grafo2))
                {
                    return "Los grafos no tienen la misma cantidad de vertices";
                }
                else
                {
                    if (!GradosIguales(grafo1.GradoVertice(grafo1), grafo2.GradoVertice(grafo2)))
                    {
                        return "Los grados de los vértices de los grafos no coiciden";
                    }
                    else
                    {
                        if (!AristasIguales(grafo1, grafo2))
                        {
                            return "Los grafos no tiene la misma cantidad de arístas";
                        }
                        else
                        {
                            if (KCompleto(grafo1.Vertices, grafo2.Vertices))
                            {
                                return GrafoCompleto(grafo1, grafo2);
                            }
                            else
                            {
                                Vertice[] vertices1 = Sort(grafo1.Vertices);
                                Vertice[] vertices2 = Sort(grafo2.Vertices);
                                return posibles(vertices1, vertices2);
                            }
                        }
                    }
                }
            }

            private void ObtenerMatriz()
            {
                foreach (Vertice vertice in Vertices)
                {
                    for (int i = 0; i < vertice.Fin.Count; i++)
                    {
                        Matriz[vertice.Etiqueta, vertice.Fin[i]] = 1;
                    }
                }
            }
        }
    }
}
