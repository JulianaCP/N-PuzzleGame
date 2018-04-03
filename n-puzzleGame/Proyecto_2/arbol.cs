using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_2
{
    //Proyecto más cerca de ganar..

    class arboles
    {
        int[,] matrizDeArbol = new int[0, 0];
        static int profundidadArbol = 0;
        List<arboles> listaDeArbolesHijos = new List<arboles>();
        string direccion = "";


        double contBytes = 0;
        List<arboles> movimientos = new List<arboles>();
        static int[,] matrizGane = new int[0, 0];
        static int encontroRespuesta = 99999999;
        static double cantidadDeMemoria = 0;
        static double asignacion = 0;
        static long comparacion = 0;
        static double mov = 0;
        static double cantDeMemoriaBytes = 0;
        double res = Math.Pow(2, 64) - 100;


        public void setProf(int p)
        {
            profundidadArbol = p;
        }



        public void imprimirContadoresEinf()
        {
            Console.WriteLine("\n\ncomparaciones:          " + comparacion);
            Console.WriteLine("asignaciones:           " + asignacion);
            Console.WriteLine("cantidad de memoria:    " + cantDeMemoriaBytes + "   Bytes y " + contBytes * 100 + "  Bits");
            Console.WriteLine("movimientos para la solucion:    " + mov);
            Console.WriteLine("\n________________________________________________________________________\n");
            Console.ReadKey();
        }

        public void setCapacidad(int capacidadParametro, int[,] matrizNueva, int[,] matrizFin)
        {
            matrizGane = new int[capacidadParametro, capacidadParametro];
            this.matrizDeArbol = new int[capacidadParametro, capacidadParametro];
            this.matrizDeArbol = matrizNueva;
            matrizGane = matrizFin;
            cantidadDeMemoria += 32 * matrizGane.Length * 2;
            asignacion += 4;
        }

        public int[,] getM()
        {
            return matrizDeArbol;// 
        }

        public void limpiarTodo()
        {
            listaDeArbolesHijos.Clear();
            movimientos.Clear();
            cantDeMemoriaBytes = 0;
            encontroRespuesta = 99999999;
            cantidadDeMemoria = 0;
            asignacion = 0;
            comparacion = 0;
            mov = 0;
        }


        ///______rrr_____________________________________________ BACK-TRAKING___________________________________________


        //fecha inicio: 09/05/16
        //fecha final: 07/06/16
        //descripcion: se encarda de verificar que la matriz a insertar no se encuentra repetida 
        //en el arbol a menos que sea la matriz gane.

        public static bool revisarNoRepetidos(List<arboles> listaDeTodosLosElementos, int[,] matriz, int capacidad)
        {
            cantidadDeMemoria += (32 * matrizGane.Length + 9 + 32) * listaDeTodosLosElementos.Count;
            cantidadDeMemoria += matriz.Length * 32;
            cantidadDeMemoria += 32;

            cantidadDeMemoria += 32;
            for (int i = 0; i < listaDeTodosLosElementos.Count; i++)
            {
                comparacion++;//comp
                int numero = 0;
                int numeroGane = 0;
                asignacion = asignacion + 2; //asig
                cantidadDeMemoria += 32 * 3;//m
                for (int k = 0; k < capacidad; k++)
                {
                    comparacion++;
                    cantidadDeMemoria += 32;//m
                    for (int j = 0; j < capacidad; j++)
                    {
                        comparacion += 2;     //comp
                        if (matriz[k, j] == listaDeTodosLosElementos[i].matrizDeArbol[k, j])
                        {
                            numero++;
                        }

                        comparacion++;// c
                        if (matriz[k, j] == matrizGane[k, j])
                        {
                            numeroGane++;
                        }
                    }
                    asignacion++;//a
                    comparacion++;//c
                }
                asignacion++;//a
                comparacion += 2;//c
                if (numeroGane >= listaDeTodosLosElementos[i].matrizDeArbol.Length)
                {
                    return false;
                }
                comparacion++;//c
                if (numero >= listaDeTodosLosElementos[i].matrizDeArbol.Length)
                {
                    return true;
                }
            }
            asignacion++;//a
            comparacion++;//c
            return false;
        }


        //fecha inicio: 09/05/16
        //fecha final: 07/06/16
        //descripcion: inserta en una copia los elementos que recibe.

        public int[,] insertarEnCopia(int capacidadParametro, int[,] matriz)
        {
            cantidadDeMemoria += 32;
            cantidadDeMemoria += 32 * matriz.Length;

            int[,] copia = new int[capacidadParametro, capacidadParametro];
            cantidadDeMemoria += 32 * copia.Length;
            asignacion++;

            cantidadDeMemoria += 32;// m
            for (int i = 0; i < capacidadParametro; i++)
            {
                comparacion++;//
                cantidadDeMemoria += 32;// memoria
                for (int j = 0; j < capacidadParametro; j++)
                {
                    comparacion++;//c

                    copia[i, j] = matriz[i, j];
                    asignacion++;//a

                }
                asignacion++;//a
                comparacion++;//c
            }
            asignacion++;//a
            comparacion++;//c
            return copia;
        }


        //fecha inicio: 09/05/16
        //fecha final: 07/06/16
        //descripcion: inserta en el arbol un nuevo nodo hijo.
        public void insertarEnArbolNuevoNodoHijo(string direccion, int[,] copia, int estado, List<arboles> listaDeTodosLosElementos, arboles Arbol, int[,] matrix, int capacidadDeMatriz)
        {
            arboles nuevoNodo = new arboles();
            cantidadDeMemoria += (32 * matrizGane.Length + 9 + 32);

            nuevoNodo.setCapacidad(capacidadDeMatriz, copia, matrizGane);
            Arbol.listaDeArbolesHijos.Add(nuevoNodo);
            listaDeTodosLosElementos.Add(nuevoNodo);
            estado = estado + 1;
            Arbol = nuevoNodo;
            Arbol.direccion = direccion;
            asignacion += 3;//a

            posibleSolucion(Arbol, listaDeTodosLosElementos, copia, capacidadDeMatriz, estado);
        }




        //fecha inicio: 09/05/16
        //fecha final: 07/06/16
        //descripcion: verifica que se pueda mover hacia el lugar correspondiente y que este no se encuentre repetido

        public void moverArriba(int estado, List<arboles> listaDeTodosLosElementos, arboles Arbol, int[,] matrix, int capacidadDeMatriz, int i, int j)
        {

            cantidadDeMemoria += (32 * matrizGane.Length + 9 + 32) * listaDeTodosLosElementos.Count;
            cantidadDeMemoria += 32;
            cantidadDeMemoria += (32 * matrizGane.Length + 9 + 32);
            cantidadDeMemoria += matrix.Length * 32;
            cantidadDeMemoria += 32 * 3;

            comparacion++;//a
            if (i - 1 >= 0)
            {
                int[,] copia = insertarEnCopia(capacidadDeMatriz, matrix);
                int numeroCambioDePos = copia[i - 1, j];
                cantidadDeMemoria += 32 + 32 * copia.Length;

                copia[i - 1, j] = copia[i, j];
                copia[i, j] = numeroCambioDePos;
                asignacion += 4;// a

                comparacion++;//c
                if (revisarNoRepetidos(listaDeTodosLosElementos, copia, capacidadDeMatriz) == false)
                {
                    string direccion = "arriba";
                    cantidadDeMemoria += direccion.Length;
                    asignacion++;//a
                    insertarEnArbolNuevoNodoHijo(direccion, copia, estado, listaDeTodosLosElementos, Arbol, matrix, capacidadDeMatriz);
                }
            }
            return;
        }



        //fecha inicio: 09/05/16
        //fecha final: 07/06/16
        //descripcion: verifica que se pueda mover hacia el lugar correspondiente y que este no se encuentre repetido

        public void moverAbajo(int estado, List<arboles> listaDeTodosLosElementos, arboles Arbol, int[,] matrix, int capacidadDeMatriz, int i, int j)
        {

            cantidadDeMemoria += (32 * matrizGane.Length + 9 + 32) * listaDeTodosLosElementos.Count;
            cantidadDeMemoria += 32;
            cantidadDeMemoria += (32 * matrizGane.Length + 9 + 32);
            cantidadDeMemoria += matrix.Length * 32;
            cantidadDeMemoria += 32 * 3;

            comparacion++;//a
            if (i + 1 < capacidadDeMatriz)
            {
                int[,] copia = insertarEnCopia(capacidadDeMatriz, matrix);
                int numeroCambioDePos = copia[i + 1, j];
                cantidadDeMemoria += 32 + 32 * copia.Length;

                copia[i + 1, j] = copia[i, j];
                copia[i, j] = numeroCambioDePos;
                asignacion += 4;//a

                comparacion++;// c
                if (revisarNoRepetidos(listaDeTodosLosElementos, copia, capacidadDeMatriz) == false)
                {

                    string direccion = "abajo";
                    asignacion++;// a
                    cantidadDeMemoria += direccion.Length;
                    insertarEnArbolNuevoNodoHijo(direccion, copia, estado, listaDeTodosLosElementos, Arbol, matrix, capacidadDeMatriz);
                }
            }
            return;
        }


        //fecha inicio: 09/05/16
        //fecha final: 07/06/16
        //descripcion: verifica que se pueda mover hacia el lugar correspondiente y que este no se encuentre repetido

        public void moverIzquierda(int estado, List<arboles> listaDeTodosLosElementos, arboles Arbol, int[,] matrix, int capacidadDeMatriz, int i, int j)
        {

            cantidadDeMemoria += (32 * matrizGane.Length + 9 + 32) * listaDeTodosLosElementos.Count;
            cantidadDeMemoria += 32;
            cantidadDeMemoria += (32 * matrizGane.Length + 9 + 32);
            cantidadDeMemoria += matrix.Length * 32;
            cantidadDeMemoria += 32 * 3;

            comparacion++;//c
            if (j - 1 >= 0)
            {
                int[,] copia = insertarEnCopia(capacidadDeMatriz, matrix);
                int numeroCambioDePos = copia[i, j - 1];
                cantidadDeMemoria += 32 + 32 * copia.Length;

                copia[i, j - 1] = copia[i, j];
                copia[i, j] = numeroCambioDePos;
                asignacion += 4; //a

                comparacion++;//c
                if (revisarNoRepetidos(listaDeTodosLosElementos, copia, capacidadDeMatriz) == false)
                {
                    string direccion = "izquierda";
                    cantidadDeMemoria += direccion.Length;
                    asignacion++;
                    insertarEnArbolNuevoNodoHijo(direccion, copia, estado, listaDeTodosLosElementos, Arbol, matrix, capacidadDeMatriz);
                }
            }
            return;
        }

        //fecha inicio: 09/05/16
        //fecha final: 07/06/16
        //descripcion: verifica que se pueda mover hacia el lugar correspondiente y que este no se encuentre repetido

        public void moverDerecha(int estado, List<arboles> listaDeTodosLosElementos, arboles Arbol, int[,] matrix, int capacidadDeMatriz, int i, int j)
        {

            cantidadDeMemoria += (32 * matrizGane.Length + 9 + 32) * listaDeTodosLosElementos.Count;
            cantidadDeMemoria += 32;
            cantidadDeMemoria += (32 * matrizGane.Length + 9 + 32);
            cantidadDeMemoria += matrix.Length * 32;
            cantidadDeMemoria += 32 * 3;

            comparacion++;//c
            if (j + 1 < capacidadDeMatriz)
            {
                int[,] copia = insertarEnCopia(capacidadDeMatriz, matrix);
                int numeroCambioDePos = copia[i, j + 1];
                cantidadDeMemoria += 32 + 32 * copia.Length;

                copia[i, j + 1] = copia[i, j];
                copia[i, j] = numeroCambioDePos;
                asignacion += 4;//a

                comparacion++; //c
                if (revisarNoRepetidos(listaDeTodosLosElementos, copia, capacidadDeMatriz) == false)
                {

                    string direccion = "derecha";
                    cantidadDeMemoria += direccion.Length;
                    asignacion++;
                    insertarEnArbolNuevoNodoHijo(direccion, copia, estado, listaDeTodosLosElementos, Arbol, matrix, capacidadDeMatriz);
                }
            }
            return;
        }


        //fecha inicio: 09/05/16
        //fecha final: 07/06/16
        //descripcion: metodo principal que evalua y recorre al arbol

        public void posibleSolucion(arboles Arbol, List<arboles> listaDeTodosLosElementos, int[,] matrix, int capacidadDeMatriz, int profundidad)
        {

            if (cantidadDeMemoria >= res)
            {
                cantDeMemoriaBytes = cantDeMemoriaBytes + 8;
                cantidadDeMemoria = 0;
                contBytes = contBytes + 1;
            }

            cantidadDeMemoria += (32 * matrizGane.Length + 9 + 32) * listaDeTodosLosElementos.Count;
            cantidadDeMemoria += (32 * matrizGane.Length + 9 + 32);
            cantidadDeMemoria += matrix.Length * 32;
            cantidadDeMemoria += 32 * 2;

            comparacion++;//c
            movimientos.Add(Arbol);
            if (profundidad == profundidadArbol)
            {
                movimientos.Remove(movimientos[movimientos.Count - 1]);
                return;
            }

            cantidadDeMemoria += 32;
            for (int i = 0; i < capacidadDeMatriz; i++)
            {
                comparacion++;// c

                cantidadDeMemoria += 32;
                for (int j = 0; j < capacidadDeMatriz; j++)
                {
                    comparacion += 2;//c

                    if (matrix[i, j] == 0)
                    {
                        recorrerM(capacidadDeMatriz, matrix, matrizGane, profundidad);

                        comparacion++; //c
                        if (encontroRespuesta <= profundidad)
                        {
                            return;
                        }
                        moverAbajo(profundidad, listaDeTodosLosElementos, Arbol, matrix, capacidadDeMatriz, i, j);
                        moverIzquierda(profundidad, listaDeTodosLosElementos, Arbol, matrix, capacidadDeMatriz, i, j);
                        moverArriba(profundidad, listaDeTodosLosElementos, Arbol, matrix, capacidadDeMatriz, i, j);
                        moverDerecha(profundidad, listaDeTodosLosElementos, Arbol, matrix, capacidadDeMatriz, i, j);
                        movimientos.Remove(movimientos[movimientos.Count - 1]);
                        cantidadDeMemoria = cantidadDeMemoria + listaDeArbolesHijos.Count * (32 * matrizGane.Length + 9 + 32);
                        return;

                    }
                }
                asignacion++;//a
                comparacion++;//c
            }
            asignacion++;//a
            comparacion++; //c
            return;
        }

        //fecha inicio: 09/05/16
        //fecha final: 07/06/16
        //descripcion: comprueba que la matriz encontrada es igual a la objetivo

        public void recorrerM(int tamaño, int[,] matrizNueva, int[,] matrizGane, int profundidad)
        {

            cantidadDeMemoria += cantidadDeMemoria += 32 * 2;
            cantidadDeMemoria += 32 * matrizNueva.Length * 2;

            int auxiliar = 0;
            cantidadDeMemoria += 32;
            asignacion++;

            for (int i = 0; i < tamaño; i++)
            {
                comparacion++;//c
                for (int j = 0; j < tamaño; j++)
                {
                    comparacion += 2;//c     
                    if (matrizGane[i, j] == matrizNueva[i, j])
                    {
                        auxiliar++;
                    }
                }
                asignacion++;//a
                comparacion++;//c
            }
            asignacion++;//a
            comparacion++; //c

            comparacion++;//c
            if (auxiliar == tamaño * tamaño)
            {
                auxiliar = 0;
                Console.WriteLine("\n\nRuta:");
                encontroRespuesta = profundidad;
                asignacion += 2;
                Console.ReadKey();
                mov = movimientos.Count - 1;
                for (int u = 0; u < movimientos.Count; u++)
                {
                    Console.Write(movimientos[u].direccion + " - ");
                }
            }
        }
        ///___________________________________________________ FIN DE BACKTRAKING ___________________________________________
    }
}

