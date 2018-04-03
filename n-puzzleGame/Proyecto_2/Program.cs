using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;





namespace Proyecto_2
    {
        /// <summary>
        ///                             VERSION MEJORCITA  2...
        /// </summary>


        class Program
        {
            static int[,] matrizTamaño1 = new int[3, 3];
            static int[,] matrizTamaño2 = new int[4, 4];
            static int[,] matrizTamaño3 = new int[5, 5];

            static int[,] matrizObjetivo1 = new int[3, 3];
            static int[,] matrizObjetivo2 = new int[4, 4];
            static int[,] matrizObjetivo3 = new int[5, 5];

            static int[,] matrizCopia1 = new int[3, 3];
            static int[,] matrizCopia2 = new int[4, 4];
            static int[,] matrizCopia3 = new int[5, 5];


            static int[,] matrizTamaño4 = new int[6, 6];
            static int[,] matrizObjetivo4 = new int[6, 6];
            static int[,] matrizCopia4 = new int[6, 6];


            /// <summary>
            /// ////
            /// </summary>

            static List<int[,]> listaDeArbolesGlobalBacktraking = new List<int[,]>();
            static arboles raiz = new arboles();
            static List<arboles> listaDeArbolesGlobales = new List<arboles>();
            static List<arboles> listaDeTodosLosElementos = new List<arboles>();
            static List<int[,]> gn = new List<int[,]>();
            static int contadorVecesGenetico = 0;
            static double asignacionGenetico = 0;
            static double comparacionGenetico = 0;
            static double movimientosGen = 0;
            static double cantMemoriagenet = 0;

        static List<int> papa = new List<int>();
        static List<int> mama2 = new List<int>();
        static List<int> hijo1 = new List<int>();
        static List<int> hijo2 = new List<int>();


        ///
        static int[,] matrizTamaño1Voraz = new int[3, 3];
        static int[,] matrizTamaño2Voraz = new int[4, 4];
        static int[,] matrizTamaño3Voraz = new int[5, 5];
        static int[,] matrizTamaño4Voraz = new int[6, 6];

        static int[,] matrizObjetivo1Voraz = new int[3, 3];
        static int[,] matrizObjetivo2Voraz = new int[4, 4];
        static int[,] matrizObjetivo3Voraz = new int[5, 5];
        static int[,] matrizObjetivo4Voraz = new int[6, 6];

        static int[,] matrizCopia1Voraz = new int[3, 3];
        static int[,] matrizCopia2Voraz = new int[4, 4];
        static int[,] matrizCopia3Voraz = new int[5, 5];
        static int[,] matrizCopia4Voraz = new int[6, 6];


        static void llenarMatrices()
        {
            /////////////////////////////// 3x3
            matrizTamaño1[0, 0] = 2;
            matrizTamaño1[0, 1] = 5;
            matrizTamaño1[0, 2] = 3;


            matrizTamaño1[1, 0] = 1;
            matrizTamaño1[1, 1] = 7;
            matrizTamaño1[1, 2] = 6;


            matrizTamaño1[2, 0] = 4;
            matrizTamaño1[2, 1] = 0;
            matrizTamaño1[2, 2] = 8;

            ///////////////     RESPUESTA      /////////////////////////////

            matrizObjetivo1[0, 0] = 1;
            matrizObjetivo1[0, 1] = 2;
            matrizObjetivo1[0, 2] = 3;

            matrizObjetivo1[1, 0] = 4;
            matrizObjetivo1[1, 1] = 5;
            matrizObjetivo1[1, 2] = 6;

            matrizObjetivo1[2, 0] = 7;
            matrizObjetivo1[2, 1] = 8;
            matrizObjetivo1[2, 2] = 0;



            // 4x4______________________________________________________________________*



            matrizTamaño2[0, 0] = 5;
            matrizTamaño2[0, 1] = 1;
            matrizTamaño2[0, 2] = 3;
            matrizTamaño2[0, 3] = 4;


            matrizTamaño2[1, 0] = 0;
            matrizTamaño2[1, 1] = 2;
            matrizTamaño2[1, 2] = 6;
            matrizTamaño2[1, 3] = 8;

            matrizTamaño2[2, 0] = 9;
            matrizTamaño2[2, 1] = 10;
            matrizTamaño2[2, 2] = 7;
            matrizTamaño2[2, 3] = 11;


            matrizTamaño2[3, 0] = 13;
            matrizTamaño2[3, 1] = 14;
            matrizTamaño2[3, 2] = 15;
            matrizTamaño2[3, 3] = 12;

            ////////////////////////// respuesta 4x4 
            matrizObjetivo2[0, 0] = 1;
            matrizObjetivo2[0, 1] = 2;
            matrizObjetivo2[0, 2] = 3;
            matrizObjetivo2[0, 3] = 4;

            matrizObjetivo2[1, 0] = 5;
            matrizObjetivo2[1, 1] = 6;
            matrizObjetivo2[1, 2] = 7;
            matrizObjetivo2[1, 3] = 8;

            matrizObjetivo2[2, 0] = 9;
            matrizObjetivo2[2, 1] = 10;
            matrizObjetivo2[2, 2] = 11;
            matrizObjetivo2[2, 3] = 12;

            matrizObjetivo2[3, 0] = 13;
            matrizObjetivo2[3, 1] = 14;
            matrizObjetivo2[3, 2] = 15;
            matrizObjetivo2[3, 3] = 0;

            /////////////////////  5x5//////////////////
            matrizTamaño3[0, 0] = 1;
            matrizTamaño3[0, 1] = 2;
            matrizTamaño3[0, 2] = 3;
            matrizTamaño3[0, 3] = 4;
            matrizTamaño3[0, 4] = 5;

            matrizTamaño3[1, 0] = 6;
            matrizTamaño3[1, 1] = 0;
            matrizTamaño3[1, 2] = 8;
            matrizTamaño3[1, 3] = 9;
            matrizTamaño3[1, 4] = 10;

            matrizTamaño3[2, 0] = 11;
            matrizTamaño3[2, 1] = 7;
            matrizTamaño3[2, 2] = 18;
            matrizTamaño3[2, 3] = 13;
            matrizTamaño3[2, 4] = 15;

            matrizTamaño3[3, 0] = 16;
            matrizTamaño3[3, 1] = 12;
            matrizTamaño3[3, 2] = 17;
            matrizTamaño3[3, 3] = 14;
            matrizTamaño3[3, 4] = 20;

            matrizTamaño3[4, 0] = 21;
            matrizTamaño3[4, 1] = 22;
            matrizTamaño3[4, 2] = 23;
            matrizTamaño3[4, 3] = 19;
            matrizTamaño3[4, 4] = 24;


            /////////////////////////// RESPUESTA 5x5


            matrizObjetivo3[0, 0] = 1;
            matrizObjetivo3[0, 1] = 2;
            matrizObjetivo3[0, 2] = 3;
            matrizObjetivo3[0, 3] = 4;
            matrizObjetivo3[0, 4] = 5;

            matrizObjetivo3[1, 0] = 6;
            matrizObjetivo3[1, 1] = 7;
            matrizObjetivo3[1, 2] = 8;
            matrizObjetivo3[1, 3] = 9;
            matrizObjetivo3[1, 4] = 10;

            matrizObjetivo3[2, 0] = 11;
            matrizObjetivo3[2, 1] = 12;
            matrizObjetivo3[2, 2] = 13;
            matrizObjetivo3[2, 3] = 14;
            matrizObjetivo3[2, 4] = 15;

            matrizObjetivo3[3, 0] = 16;
            matrizObjetivo3[3, 1] = 17;
            matrizObjetivo3[3, 2] = 18;
            matrizObjetivo3[3, 3] = 19;
            matrizObjetivo3[3, 4] = 20;

            matrizObjetivo3[4, 0] = 21;
            matrizObjetivo3[4, 1] = 22;
            matrizObjetivo3[4, 2] = 23;
            matrizObjetivo3[4, 3] = 24;
            matrizObjetivo3[4, 4] = 0;



            matrizTamaño1Voraz[0, 0] = 2;
            matrizTamaño1Voraz[0, 1] = 5;
            matrizTamaño1Voraz[0, 2] = 3;


            matrizTamaño1Voraz[1, 0] = 1;
            matrizTamaño1Voraz[1, 1] = 7;
            matrizTamaño1Voraz[1, 2] = 6;


            matrizTamaño1Voraz[2, 0] = 4;
            matrizTamaño1Voraz[2, 1] = 0;
            matrizTamaño1Voraz[2, 2] = 8;

            ///////////////     RESPUESTA      /////////////////////////////

            matrizObjetivo1Voraz[0, 0] = 1;
            matrizObjetivo1Voraz[0, 1] = 2;
            matrizObjetivo1Voraz[0, 2] = 3;

            matrizObjetivo1Voraz[1, 0] = 4;
            matrizObjetivo1Voraz[1, 1] = 5;
            matrizObjetivo1Voraz[1, 2] = 6;

            matrizObjetivo1Voraz[2, 0] = 7;
            matrizObjetivo1Voraz[2, 1] = 8;
            matrizObjetivo1Voraz[2, 2] = 0;



            // 4x4______________________________________________________________________*



            matrizTamaño2Voraz[0, 0] = 5;
            matrizTamaño2Voraz[0, 1] = 1;
            matrizTamaño2Voraz[0, 2] = 3;
            matrizTamaño2Voraz[0, 3] = 4;


            matrizTamaño2Voraz[1, 0] = 0;
            matrizTamaño2Voraz[1, 1] = 2;
            matrizTamaño2Voraz[1, 2] = 6;
            matrizTamaño2Voraz[1, 3] = 8;

            matrizTamaño2Voraz[2, 0] = 9;
            matrizTamaño2Voraz[2, 1] = 10;
            matrizTamaño2Voraz[2, 2] = 7;
            matrizTamaño2Voraz[2, 3] = 11;


            matrizTamaño2Voraz[3, 0] = 13;
            matrizTamaño2Voraz[3, 1] = 14;
            matrizTamaño2Voraz[3, 2] = 15;
            matrizTamaño2Voraz[3, 3] = 12;




            ////////////////////////// respuesta 4x4 

            matrizObjetivo2Voraz[0, 0] = 1;
            matrizObjetivo2Voraz[0, 1] = 2;
            matrizObjetivo2Voraz[0, 2] = 3;
            matrizObjetivo2Voraz[0, 3] = 4;

            matrizObjetivo2Voraz[1, 0] = 5;
            matrizObjetivo2Voraz[1, 1] = 6;
            matrizObjetivo2Voraz[1, 2] = 7;
            matrizObjetivo2Voraz[1, 3] = 8;

            matrizObjetivo2Voraz[2, 0] = 9;
            matrizObjetivo2Voraz[2, 1] = 10;
            matrizObjetivo2Voraz[2, 2] = 11;
            matrizObjetivo2Voraz[2, 3] = 12;

            matrizObjetivo2Voraz[3, 0] = 13;
            matrizObjetivo2Voraz[3, 1] = 14;
            matrizObjetivo2Voraz[3, 2] = 15;
            matrizObjetivo2Voraz[3, 3] = 0;

            /////////////////////  5x5//////////////////
            matrizTamaño3Voraz[0, 0] = 1;
            matrizTamaño3Voraz[0, 1] = 2;
            matrizTamaño3Voraz[0, 2] = 3;
            matrizTamaño3Voraz[0, 3] = 4;
            matrizTamaño3Voraz[0, 4] = 5;

            matrizTamaño3Voraz[1, 0] = 6;
            matrizTamaño3Voraz[1, 1] = 0;
            matrizTamaño3Voraz[1, 2] = 8;
            matrizTamaño3Voraz[1, 3] = 9;
            matrizTamaño3Voraz[1, 4] = 10;

            matrizTamaño3Voraz[2, 0] = 11;
            matrizTamaño3Voraz[2, 1] = 7;
            matrizTamaño3Voraz[2, 2] = 18;
            matrizTamaño3Voraz[2, 3] = 13;
            matrizTamaño3Voraz[2, 4] = 15;

            matrizTamaño3Voraz[3, 0] = 16;
            matrizTamaño3Voraz[3, 1] = 12;
            matrizTamaño3Voraz[3, 2] = 17;
            matrizTamaño3Voraz[3, 3] = 14;
            matrizTamaño3Voraz[3, 4] = 20;

            matrizTamaño3Voraz[4, 0] = 21;
            matrizTamaño3Voraz[4, 1] = 22;
            matrizTamaño3Voraz[4, 2] = 23;
            matrizTamaño3Voraz[4, 3] = 19;
            matrizTamaño3Voraz[4, 4] = 24;


            /////////////////////////// RESPUESTA 5x5


            matrizObjetivo3Voraz[0, 0] = 1;
            matrizObjetivo3Voraz[0, 1] = 2;
            matrizObjetivo3Voraz[0, 2] = 3;
            matrizObjetivo3Voraz[0, 3] = 4;
            matrizObjetivo3Voraz[0, 4] = 5;

            matrizObjetivo3Voraz[1, 0] = 6;
            matrizObjetivo3Voraz[1, 1] = 7;
            matrizObjetivo3Voraz[1, 2] = 8;
            matrizObjetivo3Voraz[1, 3] = 9;
            matrizObjetivo3Voraz[1, 4] = 10;

            matrizObjetivo3Voraz[2, 0] = 11;
            matrizObjetivo3Voraz[2, 1] = 12;
            matrizObjetivo3Voraz[2, 2] = 13;
            matrizObjetivo3Voraz[2, 3] = 14;
            matrizObjetivo3Voraz[2, 4] = 15;

            matrizObjetivo3Voraz[3, 0] = 16;
            matrizObjetivo3Voraz[3, 1] = 17;
            matrizObjetivo3Voraz[3, 2] = 18;
            matrizObjetivo3Voraz[3, 3] = 19;
            matrizObjetivo3Voraz[3, 4] = 20;

            matrizObjetivo3Voraz[4, 0] = 21;
            matrizObjetivo3Voraz[4, 1] = 22;
            matrizObjetivo3Voraz[4, 2] = 23;
            matrizObjetivo3Voraz[4, 3] = 24;
            matrizObjetivo3Voraz[4, 4] = 0;



            //////////////////////////////////////tamaño 6x6


            matrizTamaño4[0, 0] = 1;
            matrizTamaño4[0, 1] = 2;
            matrizTamaño4[0, 2] = 3;
            matrizTamaño4[0, 3] = 4;
            matrizTamaño4[0, 4] = 5;
            matrizTamaño4[0, 5] = 6;

            matrizTamaño4[1, 0] = 7;
            matrizTamaño4[1, 1] = 8;
            matrizTamaño4[1, 2] = 9;
            matrizTamaño4[1, 3] = 10;
            matrizTamaño4[1, 4] = 11;
            matrizTamaño4[1, 5] = 12;

            matrizTamaño4[2, 0] = 13;
            matrizTamaño4[2, 1] = 14;
            matrizTamaño4[2, 2] = 15;
            matrizTamaño4[2, 3] = 16;
            matrizTamaño4[2, 4] = 17;
            matrizTamaño4[2, 5] = 18;

            matrizTamaño4[3, 0] = 19;
            matrizTamaño4[3, 1] = 20;
            matrizTamaño4[3, 2] = 21;
            matrizTamaño4[3, 3] = 0;
            matrizTamaño4[3, 4] = 22;
            matrizTamaño4[3, 5] = 23;

            matrizTamaño4[4, 0] = 25;
            matrizTamaño4[4, 1] = 26;
            matrizTamaño4[4, 2] = 27;
            matrizTamaño4[4, 3] = 28;
            matrizTamaño4[4, 4] = 29;
            matrizTamaño4[4, 5] = 24;

            matrizTamaño4[5, 0] = 31;
            matrizTamaño4[5, 1] = 32;
            matrizTamaño4[5, 2] = 33;
            matrizTamaño4[5, 3] = 34;
            matrizTamaño4[5, 4] = 35;
            matrizTamaño4[5, 5] = 30;


            /////////////////////////// RESPUESTA 6x6


            matrizObjetivo4[0, 0] = 1;
                matrizObjetivo4[0, 1] = 2;
                matrizObjetivo4[0, 2] = 3;
                matrizObjetivo4[0, 3] = 4;
                matrizObjetivo4[0, 4] = 5;
                matrizObjetivo4[0, 5] = 6;

                matrizObjetivo4[1, 0] = 7;
                matrizObjetivo4[1, 1] = 8;
                matrizObjetivo4[1, 2] = 9;
                matrizObjetivo4[1, 3] = 10;
                matrizObjetivo4[1, 4] = 11;
                matrizObjetivo4[1, 5] = 12;

                matrizObjetivo4[2, 0] = 13;
                matrizObjetivo4[2, 1] = 14;
                matrizObjetivo4[2, 2] = 15;
                matrizObjetivo4[2, 3] = 16;
                matrizObjetivo4[2, 4] = 17;
                matrizObjetivo4[2, 5] = 18;

                matrizObjetivo4[3, 0] = 19;
                matrizObjetivo4[3, 1] = 20;
                matrizObjetivo4[3, 2] = 21;
                matrizObjetivo4[3, 3] = 22;
                matrizObjetivo4[3, 4] = 23;
                matrizObjetivo4[3, 5] = 24;

                matrizObjetivo4[4, 0] = 25;
                matrizObjetivo4[4, 1] = 26;
                matrizObjetivo4[4, 2] = 27;
                matrizObjetivo4[4, 3] = 28;
                matrizObjetivo4[4, 4] = 29;
                matrizObjetivo4[4, 5] = 30;

                matrizObjetivo4[5, 0] = 31;
                matrizObjetivo4[5, 1] = 32;
                matrizObjetivo4[5, 2] = 33;
                matrizObjetivo4[5, 3] = 34;
                matrizObjetivo4[5, 4] = 35;
                matrizObjetivo4[5, 5] = 0;


            /////////////////////////////////////////////
            ///////////////  6x6 ///////////////////////



            matrizTamaño4Voraz[0, 0] = 1;
            matrizTamaño4Voraz[0, 1] = 2;
            matrizTamaño4Voraz[0, 2] = 3;
            matrizTamaño4Voraz[0, 3] = 4;
            matrizTamaño4Voraz[0, 4] = 5;
            matrizTamaño4Voraz[0, 5] = 6;

            matrizTamaño4Voraz[1, 0] = 7;
            matrizTamaño4Voraz[1, 1] = 8;
            matrizTamaño4Voraz[1, 2] = 9;
            matrizTamaño4Voraz[1, 3] = 10;
            matrizTamaño4Voraz[1, 4] = 11;
            matrizTamaño4Voraz[1, 5] = 12;

            matrizTamaño4Voraz[2, 0] = 13;
            matrizTamaño4Voraz[2, 1] = 14;
            matrizTamaño4Voraz[2, 2] = 15;
            matrizTamaño4Voraz[2, 3] = 16;
            matrizTamaño4Voraz[2, 4] = 17;
            matrizTamaño4Voraz[2, 5] = 18;

            matrizTamaño4Voraz[3, 0] = 19;
            matrizTamaño4Voraz[3, 1] = 20;
            matrizTamaño4Voraz[3, 2] = 21;
            matrizTamaño4Voraz[3, 3] = 0;
            matrizTamaño4Voraz[3, 4] = 22;
            matrizTamaño4Voraz[3, 5] = 23;

            matrizTamaño4Voraz[4, 0] = 25;
            matrizTamaño4Voraz[4, 1] = 26;
            matrizTamaño4Voraz[4, 2] = 27;
            matrizTamaño4Voraz[4, 3] = 28;
            matrizTamaño4Voraz[4, 4] = 29;
            matrizTamaño4Voraz[4, 5] = 24;

            matrizTamaño4Voraz[5, 0] = 31;
            matrizTamaño4Voraz[5, 1] = 32;
            matrizTamaño4Voraz[5, 2] = 33;
            matrizTamaño4Voraz[5, 3] = 34;
            matrizTamaño4Voraz[5, 4] = 35;
            matrizTamaño4Voraz[5, 5] = 30;


            /////////////////////////// RESPUESTA 6x6


            matrizObjetivo4Voraz[0, 0] = 1;
            matrizObjetivo4Voraz[0, 1] = 2;
            matrizObjetivo4Voraz[0, 2] = 3;
            matrizObjetivo4Voraz[0, 3] = 4;
            matrizObjetivo4Voraz[0, 4] = 5;
            matrizObjetivo4Voraz[0, 5] = 6;

            matrizObjetivo4Voraz[1, 0] = 7;
            matrizObjetivo4Voraz[1, 1] = 8;
            matrizObjetivo4Voraz[1, 2] = 9;
            matrizObjetivo4Voraz[1, 3] = 10;
            matrizObjetivo4Voraz[1, 4] = 11;
            matrizObjetivo4Voraz[1, 5] = 12;

            matrizObjetivo4Voraz[2, 0] = 13;
            matrizObjetivo4Voraz[2, 1] = 14;
            matrizObjetivo4Voraz[2, 2] = 15;
            matrizObjetivo4Voraz[2, 3] = 16;
            matrizObjetivo4Voraz[2, 4] = 17;
            matrizObjetivo4Voraz[2, 5] = 18;

            matrizObjetivo4Voraz[3, 0] = 19;
            matrizObjetivo4Voraz[3, 1] = 20;
            matrizObjetivo4Voraz[3, 2] = 21;
            matrizObjetivo4Voraz[3, 3] = 22;
            matrizObjetivo4Voraz[3, 4] = 23;
            matrizObjetivo4Voraz[3, 5] = 24;

            matrizObjetivo4Voraz[4, 0] = 25;
            matrizObjetivo4Voraz[4, 1] = 26;
            matrizObjetivo4Voraz[4, 2] = 27;
            matrizObjetivo4Voraz[4, 3] = 28;
            matrizObjetivo4Voraz[4, 4] = 29;
            matrizObjetivo4Voraz[4, 5] = 30;

            matrizObjetivo4Voraz[5, 0] = 31;
            matrizObjetivo4Voraz[5, 1] = 32;
            matrizObjetivo4Voraz[5, 2] = 33;
            matrizObjetivo4Voraz[5, 3] = 34;
            matrizObjetivo4Voraz[5, 4] = 35;
            matrizObjetivo4Voraz[5, 5] = 0;



        }


            //------------------------------------------ voraz -----------------------------------------------


            static void imprimirMatriz(int[,] matriz, int tamaño)
            {

                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de imprimier el juego n-puzzle, expresando en pantalla 
                //cada una de las posiciones de la matriz

                Console.WriteLine();


                for (int filas = 0; filas < tamaño; filas++)
                {
                    for (int columnas = 0; columnas < tamaño; columnas++)
                    {
                        Console.Write(matriz[filas, columnas] + "        ");

                    }
                    Console.WriteLine();
                }
                Console.WriteLine();

                //    Console.ReadKey();
            }

            static bool comprobar(int[,] matriz, int tamaño)
            {

                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de comprobar si la combinacion de numeros que tiene el juego se puede
                //solucionar o no, contando el numero de inversiones

                int numeroBuscar = 0;
                int numBuscarInversion = 0;
                bool sumar = false;
                int totalInversion = 0;

                for (int filas = 0; filas < tamaño; filas++)
                {
                    for (int columnas = 0; columnas < tamaño; columnas++)
                    {
                        numeroBuscar = matriz[filas, columnas];

                        for (int filas2 = 0; filas2 < tamaño; filas2++)
                        {

                            for (int columnas2 = 0; columnas2 < tamaño; columnas2++)
                            {


                                if (numeroBuscar == matriz[filas2, columnas2])
                                {
                                    sumar = true;

                                }
                                if (matriz[filas2, columnas2] < numeroBuscar)
                                {

                                    if (sumar == true)
                                    {
                                        if (matriz[filas2, columnas2] != 0)
                                        {

                                            numBuscarInversion++;

                                        }
                                    }
                                }

                            }

                        }
                        sumar = false;
                        totalInversion = totalInversion + numBuscarInversion;
                        numBuscarInversion = 0;
                    }
                }

                Console.WriteLine("Inversion matriz " + tamaño + "x" + tamaño + ": " + totalInversion);
                Console.ReadKey();

                if (totalInversion % 2 == 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }


            static void comprobarMatrices()
            {

                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de llamar al metodo de comprobar encargada de verificar que el juego tenga solucion
                //hace una verificacion de cada uno de los tamaños

                bool tieneSolucionTamaño1 = true;
                bool tieneSolucionTamaño2 = true;
                bool tieneSolucionTamaño3 = true;
                bool tieneSolucionTamaño4 = true;


                tieneSolucionTamaño1 = comprobar(matrizTamaño1, 3);
                tieneSolucionTamaño2 = comprobar(matrizTamaño2, 4);
                tieneSolucionTamaño3 = comprobar(matrizTamaño3, 5);
                tieneSolucionTamaño4 = comprobar(matrizTamaño4, 6);

                if (tieneSolucionTamaño1 == false)
                {
                    Console.WriteLine("El rompecabezas de 3x3 no tiene solucion ");

                }
                else
                {
                    Console.WriteLine("El rompecabezas de 3x3 tiene solucion ");
                }

                if (tieneSolucionTamaño2 == false)
                {
                    Console.WriteLine("El rompecabezas de 4x4 no tiene solucion ");

                }
                else
                {
                    Console.WriteLine("El rompecabezas de 4x4 tiene solucion ");
                }

                if (tieneSolucionTamaño3 == false)
                {
                    Console.WriteLine("El rompecabezas de 5x5 no tiene solucion ");

                }
                else
                {
                    Console.WriteLine("El rompecabezas de 5x5 tiene solucion ");
                }
                if (tieneSolucionTamaño4 == false)
                {
                    Console.WriteLine("El rompecabezas de 6x6 no tiene solucion ");

                }
                else
                {
                    Console.WriteLine("El rompecabezas de 6x6 tiene solucion ");
                }


                if (tieneSolucionTamaño1 == false || tieneSolucionTamaño2 == false || tieneSolucionTamaño3 == false || tieneSolucionTamaño4 == false)
                {
                    Console.WriteLine("\n\nAlgunos datos no son correctos...Intente de nuevo");
                    Console.ReadKey();
                    //salir
                    Environment.Exit(0);
                }
            }

            static double distanciaDeManhattan(int[,] puzzle, int tamaño, int[,] obje)
            {
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * puzzle.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * obje.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32;


                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 96;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 64;

                int num;

                // Algoritmo que calcula la suma de las distancias manhattan
                // hasta la solucion
                double suma = 0;
                medicionCantidadDeAsignacionesVoraz++;

                medicionCantidadDeComparacionesVoraz++;
                medicionCantidadDeAsignacionesVoraz++;
                for (int i = 0; i < tamaño; ++i)
                {
                    medicionCantidadDeComparacionesVoraz++;

                    medicionCantidadDeComparacionesVoraz++;
                    medicionCantidadDeAsignacionesVoraz++;
                    for (int j = 0; j < tamaño; ++j)
                    {
                        medicionCantidadDeComparacionesVoraz++;
                    //   Console.WriteLine("num [i][j]: " + puzzle[i, j]);
                        medicionCantidadDeComparacionesVoraz++;
                        if (puzzle[i, j] != 0)
                        {
                            medicionCantidadDeComparacionesVoraz++;
                            if (obje[i, j] != puzzle[i, j])
                            {
                                //Buscamos la posición correcta para la ficha en puzzle[i][j]
                                int i2 = 0, j2 = 0;
                                medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 2;

                                medicionCantidadDeComparacionesVoraz++;
                                while (i2 < obje.Length && (obje[i2, j2] != puzzle[i, j]))
                                {
                                    medicionCantidadDeComparacionesVoraz= medicionCantidadDeComparacionesVoraz+2;

                                    j2++;
                                    medicionCantidadDeComparacionesVoraz++;
                                    if (j2 >= tamaño) { i2++; j2 = 0; }
                                }
                                num = Math.Abs(i2 - i) + Math.Abs(j2 - j);

                                //  Console.WriteLine("cant: " + num);

                                suma += Math.Abs(i2 - i) + Math.Abs(j2 - j);
                                //En [i2][j2] está la posición correcta

                                medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 2;
                            }
                        }

                    }
                }
                return suma;
            }


            static int obtenerNumeroDelaDerecha(int[,] matriz, int filasEncontrar, int columnasEncontrar, int tamaño)
            {

                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de obtener y retornar el numero que se encuentra a la derecha del espacio vacio

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matriz.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 96;


                medicionCantidadDeAsignacionesVoraz++;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32;
                //puede valer -1;
                int num = ObtenerNumero(matriz, filasEncontrar, columnasEncontrar + 1, tamaño);
                return num;
            }

            static int obtenerNumeroDelaIzquierda(int[,] matriz, int filasEncontrar, int columnasEncontrar, int tamaño)
            {

                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de obtener y retornar el numero que se encuentra a la izquierda del espacio vacio

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matriz.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 96;

                medicionCantidadDeAsignacionesVoraz++;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32;
                //puede valer -1;
                int num = ObtenerNumero(matriz, filasEncontrar, columnasEncontrar - 1, tamaño);
                return num;
            }

            static int obtenerNumeroDeAbajo(int[,] matriz, int filasEncontrar, int columnasEncontrar, int tamaño)
            {

                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de obtener y retornar el numero que se encuentra abajo del espacio vacio

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matriz.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 96;

                medicionCantidadDeAsignacionesVoraz++;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32;
                //puede valer -1;
                int num = ObtenerNumero(matriz, filasEncontrar + 1, columnasEncontrar, tamaño);
                return num;
            }

            static int obtenerNumeroDeArriba(int[,] matriz, int filasEncontrar, int columnasEncontrar, int tamaño)
            {

                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de obtener y retornar el numero que se encuentra arriba del espacio vacio


                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matriz.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 96;

                medicionCantidadDeAsignacionesVoraz++;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32;
                //puede valer -1;
                int num = ObtenerNumero(matriz, filasEncontrar - 1, columnasEncontrar, tamaño);
                return num;
            }


            static int ObtenerNumero(int[,] matriz, int filasEncontrar, int columnasEncontrar, int tamaño)
            {

                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de obtener y retornar el numero que se encuentra en la posicion de filas
                //y columnas enviadas por parametro

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matriz.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 96;

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 64;
                medicionCantidadDeAsignacionesVoraz++;

                int numero = -1;

                medicionCantidadDeComparacionesVoraz++;
                medicionCantidadDeAsignacionesVoraz++;
                for (int filas = 0; filas < tamaño; filas++)
                {
                     medicionCantidadDeComparacionesVoraz++;

                    medicionCantidadDeComparacionesVoraz++;
                    medicionCantidadDeAsignacionesVoraz++;
                    for (int columnas = 0; columnas < tamaño; columnas++)
                    {
                        medicionCantidadDeComparacionesVoraz++;

                        medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                        if (filasEncontrar == filas && columnas == columnasEncontrar)
                        {
                            medicionCantidadDeAsignacionesVoraz++;
                            numero = matriz[filas, columnas];
                        }
                    }
                }

                return numero;
            }

            static bool numeroEstaEnLista;

            static void moverDerecha(int[,] matriz, int tamaño, int numOrdenar, int[,] matrizObjetivo)
            {

                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de verificar si el numero de la derecha se puede mover, y de ser el caso llama 
                //al metodo que se encarga de mover el numero en la posicion deseada

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matriz.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 64;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matrizObjetivo.Length;


                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32;


                obtenerPosicionesVacioNumero(matriz, tamaño, numOrdenar, matrizObjetivo);
                int numero = ObtenerNumero(matriz, filaCero, columnaCero + 1, tamaño);

                numeroEstaEnLista = listaNumerosAcomodados.Contains(numero);

                medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 2;

                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                if (numeroEstaEnLista == false)
                {
                    mover(numero, matriz, tamaño);
                }
                else if (numeroEstaEnLista == true)
                {

                    medicionCantidadDeAsignacionesVoraz++;
                    realizaMovimientosConReglas = false;
                }
            }

            static void moverIzquierda(int[,] matriz, int tamaño, int numOrdenar, int[,] matrizObjetivo)
            {


                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de verificar si el numero de la izquierda se puede mover, y de ser el caso llama 
                //al metodo que se encarga de mover el numero en la posicion deseada

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matriz.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 64;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matrizObjetivo.Length;

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32;


                obtenerPosicionesVacioNumero(matriz, tamaño, numOrdenar, matrizObjetivo);
                int numero = ObtenerNumero(matriz, filaCero, columnaCero - 1, tamaño);

                numeroEstaEnLista = listaNumerosAcomodados.Contains(numero);

                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 2;
                if (numeroEstaEnLista == false)
                {
                    mover(numero, matriz, tamaño);

                }
                else if (numeroEstaEnLista == true)
                {

                    medicionCantidadDeAsignacionesVoraz++;
                    realizaMovimientosConReglas = false;
                }
            }
            static void moverAbajo(int[,] matriz, int tamaño, int numOrdenar, int[,] matrizObjetivo)
            {


                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de verificar si el numero de abajo se puede mover, y de ser el caso llama 
                //al metodo que se encarga de mover el numero en la posicion deseada

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matriz.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 64;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matrizObjetivo.Length;


                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32;

                obtenerPosicionesVacioNumero(matriz, tamaño, numOrdenar, matrizObjetivo);
                int numero = ObtenerNumero(matriz, filaCero + 1, columnaCero, tamaño);

                numeroEstaEnLista = listaNumerosAcomodados.Contains(numero);

                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 2;
                if (numeroEstaEnLista == false)
                {
                    mover(numero, matriz, tamaño);

                }
                else if (numeroEstaEnLista == true)
                {

                    medicionCantidadDeAsignacionesVoraz++;
                    realizaMovimientosConReglas = false;
                }
            }
            static void moverArriba(int[,] matriz, int tamaño, int numOrdenar, int[,] matrizObjetivo)
            {


                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de verificar si el numero de arriba se puede mover, y de ser el caso llama 
                //al metodo que se encarga de mover el numero en la posicion deseada

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matriz.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 64;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matrizObjetivo.Length;


                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32;

                obtenerPosicionesVacioNumero(matriz, tamaño, numOrdenar, matrizObjetivo);
                int numero = ObtenerNumero(matriz, filaCero - 1, columnaCero, tamaño);

                numeroEstaEnLista = listaNumerosAcomodados.Contains(numero);
                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 2;
                if (numeroEstaEnLista == false)
                {

                    mover(numero, matriz, tamaño);

                }
                else if (numeroEstaEnLista == true)
                {

                    medicionCantidadDeAsignacionesVoraz++;
                    realizaMovimientosConReglas = false;
                }
            }

            static void mover(int numeroMover, int[,] matriz, int tamaño)
            {



                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de mover o intercambiar la posicion del espacio vacio, con el numero a mover, en este
                //caso el numero que llega por parametro

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matriz.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 64;



                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 64;

                medicionCantidadDeComparacionesVoraz++;
                medicionCantidadDeAsignacionesVoraz++;
                for (int filas = 0; filas < tamaño; filas++)
                {
                    medicionCantidadDeComparacionesVoraz++;

                    medicionCantidadDeComparacionesVoraz++;
                    medicionCantidadDeAsignacionesVoraz++;
                    for (int columnas = 0; columnas < tamaño; columnas++)
                    {
                        medicionCantidadDeComparacionesVoraz++;

                        medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                        if (matriz[filas, columnas] == 0)
                        {
                            matriz[filas, columnas] = numeroMover;
                        }
                        else if (matriz[filas, columnas] == numeroMover)
                        {
                            matriz[filas, columnas] = 0;
                        }
                    }
                }
            }


            static ArrayList listaNumerosAcomodados = new ArrayList();

            static int medicionCantidadDeMovimientosEfectuadosVoraz;
            static int medicionCantidadDeMemoriaConsumidaVoraz;
            static int medicionCantidadDeAsignacionesVoraz;
            static int medicionCantidadDeComparacionesVoraz;


            static void metodoVoraz(int[,] matriz, int tamaño, int[,] matrizObjetivo, int[,] matrizCopia)
            {

                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de realizar el ordenamiento del juego n -puzzle, este llama a todas las 
                //funciones necesarias para el ordenamiento del mismo. Es el metodo principal


                medicionCantidadDeMovimientosEfectuadosVoraz = 0;
                medicionCantidadDeMemoriaConsumidaVoraz = 0;
                medicionCantidadDeAsignacionesVoraz = 0;
                medicionCantidadDeComparacionesVoraz = 0;

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matriz.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matrizCopia.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matrizObjetivo.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32;


                listaNumerosAcomodados.Clear();

                double distanciaDelNumeroAOrdenar;

                int ordenarColumnaNumArriba;
                int ordenarColumnaNumAbajo;

                int numOrdenar = 1;
                int fila = 0;
                int columna = 0;


                double distancia;

                bool filaEstaOrdenada = false;

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 296;
                medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 4;

                medicionCantidadDeComparacionesVoraz++;
                while (true)
                {
                    medicionCantidadDeComparacionesVoraz++;

                    medicionCantidadDeAsignacionesVoraz++;
                    distancia = distanciaDeManhattan(matriz, tamaño, matrizObjetivo); //matrizOrdenar == matrizObjetivo
                    medicionCantidadDeComparacionesVoraz++;
                    if (distancia == 0)
                    {
                        Console.WriteLine("\n\n\n\n\nEl puzzle esta ordenado");
                        Console.ReadKey();
                        break;
                    }

                    medicionCantidadDeComparacionesVoraz++;
                    while (fila < tamaño - 2) // ordene todas las filas necesarias menos las 2 ultimas filas
                    {
                        medicionCantidadDeComparacionesVoraz++;

                        medicionCantidadDeComparacionesVoraz++;
                        while (true)//se va a hacer hasta que ordene toda la fila correspondiente (la que se esta analizando)
                        {
                            medicionCantidadDeComparacionesVoraz++;

                            medicionCantidadDeAsignacionesVoraz++;
                            distanciaDelNumeroAOrdenar = distanciaDeManhattanDeunNumero(matriz, tamaño, matrizObjetivo, numOrdenar);
                            medicionCantidadDeComparacionesVoraz++;
                            if (distanciaDelNumeroAOrdenar != 0)
                            {
                                ordenarNumeroPosicion(matriz, tamaño, matrizObjetivo, matrizCopia, numOrdenar);

                            }
                            listaNumerosAcomodados.Add(numOrdenar);
                            numOrdenar++; //el numero anterior esta ordenada... se ordena el siguiente

                            //verificacion de que la fila esta ordenada
                            medicionCantidadDeAsignacionesVoraz++;
                            filaEstaOrdenada = filaSeleccionadaEstaIgualAObjetivo(matriz, tamaño, matrizObjetivo, fila);
                            medicionCantidadDeComparacionesVoraz++;
                            if (filaEstaOrdenada == true)
                            {
                                fila++;
                                break;
                            }
                        }
                    }

                    medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32;


                    int varx = tamaño - 2;
                    ordenarColumnaNumArriba = tamaño * varx + 1;
                    ordenarColumnaNumAbajo = ordenarColumnaNumArriba + tamaño;

                    medicionCantidadDeComparacionesVoraz++;
                    medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 3;
                    while (columna < tamaño - 2)//ordenar columnas
                    {
                        medicionCantidadDeComparacionesVoraz++;

                        medicionCantidadDeAsignacionesVoraz++;
                        distanciaDelNumeroAOrdenar = distanciaDeManhattanDeunNumero(matriz, tamaño, matrizObjetivo, ordenarColumnaNumArriba);
                        medicionCantidadDeComparacionesVoraz++;
                        if (distanciaDelNumeroAOrdenar != 0)
                        {
                            ordenarNumeroPosicion(matriz, tamaño, matrizObjetivo, matrizCopia, ordenarColumnaNumArriba);
                        }

                        listaNumerosAcomodados.Add(ordenarColumnaNumArriba);
                        ordenarColumnaNumArriba++;

                        medicionCantidadDeAsignacionesVoraz++;
                        distanciaDelNumeroAOrdenar = distanciaDeManhattanDeunNumero(matriz, tamaño, matrizObjetivo, ordenarColumnaNumAbajo);
                        medicionCantidadDeComparacionesVoraz++;
                        if (distanciaDelNumeroAOrdenar != 0)
                        {
                            ordenarNumeroPosicion(matriz, tamaño, matrizObjetivo, matrizCopia, ordenarColumnaNumAbajo);
                        }
                        listaNumerosAcomodados.Add(ordenarColumnaNumAbajo);
                        ordenarColumnaNumAbajo++;
                        columna++;
                    }

                    girarNumeros(matriz, tamaño, matrizObjetivo, matrizCopia, numOrdenar);

                }
            }

            static double distanciaDelNumeroAOrdenarGerenal;
            static void girarNumeros(int[,] matriz, int tamaño, int[,] matrizObjetivo, int[,] matrizCopia, int numOrdenar)
            {

                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de ordenar los ultimos 4 numeros inferiores, por medio del giro de los mismos
                //Estos giran hasta que los 4 esten en posicion correcta (incluyendo el espacio vacio)

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matriz.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matrizCopia.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matrizObjetivo.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 64;

                medicionCantidadDeComparacionesVoraz++;
                while (true)
                {
                    medicionCantidadDeComparacionesVoraz++;

                    medicionCantidadDeComparacionesVoraz++;
                    if (numOrdenar == tamaño * tamaño)
                    {
                        break;
                    }
                    medicionCantidadDeAsignacionesVoraz++;
                    distanciaDelNumeroAOrdenarGerenal = distanciaDeManhattanDeunNumero(matriz, tamaño, matrizObjetivo, numOrdenar);
                    medicionCantidadDeComparacionesVoraz++;
                    if (distanciaDelNumeroAOrdenarGerenal != 0)
                    {
                        obtenerPosicionesVacioNumero(matriz, tamaño, numOrdenar, matrizObjetivo);
                        int var = tamaño - 1;
                        medicionCantidadDeAsignacionesVoraz++;
                        medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                        if (filaCero == tamaño - 1 && columnaCero == tamaño - 1)
                        {
                            moverIzquierda(matriz, tamaño, numOrdenar, matrizObjetivo);
                            medicionCantidadDeMovimientosEfectuadosVoraz++;
                            Console.Write("- izquierda -");
                        }
                        medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                        if (filaCero == tamaño - 1 && columnaCero != tamaño - 1)
                        {
                            moverArriba(matriz, tamaño, numOrdenar, matrizObjetivo);
                            medicionCantidadDeMovimientosEfectuadosVoraz++;
                            Console.Write("- arriba -");
                        }
                        medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                        if (filaCero != tamaño - 1 && columnaCero == tamaño - 1)
                        {
                            moverAbajo(matriz, tamaño, numOrdenar, matrizObjetivo);
                            medicionCantidadDeMovimientosEfectuadosVoraz++;
                            Console.Write("- abajo -");
                        }
                        medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                        if (filaCero != tamaño - 1 && columnaCero != tamaño - 1)
                        {
                            moverDerecha(matriz, tamaño, numOrdenar, matrizObjetivo);
                            medicionCantidadDeMovimientosEfectuadosVoraz++;
                            Console.Write("- derecha -");
                        }

                    }
                    medicionCantidadDeComparacionesVoraz++;
                    if (distanciaDelNumeroAOrdenarGerenal == 0)
                    {
                        numOrdenar++;
                    }
                }
            }

            static void moverNumeroEnDireccionAObjetivo(int[,] matriz, int tamaño, int[,] matrizObjetivo, int[,] matrizCopia, int numOrdenar)
            {

                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: este se encarga de mover el numero en direcion a su posicion original, por  medio del movimiento
                //hacia el cero o no. Coloca el numero donde esta el cero si este estaba mas cerca o lo deja en la posicion que esta
                //si esa es la posicion mas cercana


                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matriz.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matrizCopia.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matrizObjetivo.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 64;

                obtenerPosicionesVacioNumero(matriz, tamaño, numOrdenar, matrizObjetivo);

                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 4;
                if (filaNumero > filaCero)
                {
                    medicionCantidadDeComparacionesVoraz++;
                    if (filaNumero > filaNumeroVerdaderaPosicion)
                    {
                        medicionCantidadDeMovimientosEfectuadosVoraz++;
                        mover(numOrdenar, matriz, tamaño);

                        Console.Write("- abajo -");
                    }
                    //se va ir hacia abajo
                }
                else if (filaNumero < filaCero)
                {
                    medicionCantidadDeComparacionesVoraz++;
                    if (filaNumero < filaNumeroVerdaderaPosicion)
                    {
                        medicionCantidadDeMovimientosEfectuadosVoraz++;
                        mover(numOrdenar, matriz, tamaño);

                        Console.Write("- arriba -");
                        //darle vuelta al numero y al espacio en blanco (se va ir hacia abajo)
                    }
                    //se va ir hacia arriba
                }
                else if (columnaNumero > columnaCero)
                {
                    medicionCantidadDeComparacionesVoraz++;
                    if (columnaNumero > columnaVeradaderaPosicion)
                    {
                        medicionCantidadDeMovimientosEfectuadosVoraz++;
                        mover(numOrdenar, matriz, tamaño);

                        Console.Write("- derecha -");
                        //darle vuelta al numero y al espacio en blanco (se va ir hacia izq)
                    }
                    //se va ir hacia la derecha
                }
                else if (columnaNumero < columnaCero)
                {
                    medicionCantidadDeComparacionesVoraz++;
                    if (columnaNumero < columnaVeradaderaPosicion)
                    {
                        medicionCantidadDeMovimientosEfectuadosVoraz++;
                        mover(numOrdenar, matriz, tamaño);

                        Console.Write("- izquierda -");
                        //darle vuelta al numero y al espacio en blanco (se va ir hacia der)
                    }
                    //se va ir hacia la izquierda
                }
            }
            static string revisarDireccionHorizontalProximoMovimiento()
            {

                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: establece la direccion de movimientos a las que debe ir el numero a ordenar para que este en su
                //posicion correcta (horizontal)

                medicionCantidadDeComparacionesVoraz++;
                if (columnaVeradaderaPosicion < columnaNumero)
                {
                    return "izquierda";
                }
                else
                {
                    return "derecha";
                }
            }

            static string revisarDireccionVerticalProximoMovimiento()
            {

                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: establece la direccion de movimientos a las que debe ir el numero a ordenar para que este en su
                //posicion correcta (vertical)

                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                if (filaNumeroVerdaderaPosicion < filaNumero)
                {
                    return "arriba";
                }
                else if (filaNumeroVerdaderaPosicion > filaNumero)
                {
                    return "abajo";
                }
                else
                {
                    return "";
                }
            }

            static void copiarListasDeNumerosFormarArrayDeCopia()
            {
                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de restablecer a la lista de numero Acomodados los numeros que realmente estan 
                //acomodados y que cumplan con todas las restricciones de movimientos

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32;

                listaNumerosAcomodados.Clear();

                medicionCantidadDeAsignacionesVoraz++;
                medicionCantidadDeComparacionesVoraz++;
                for (int i = 0; i < listaNumerosAcomodadosCopia.Count; i++)
                {
                    medicionCantidadDeComparacionesVoraz++;
                    listaNumerosAcomodados.Add(listaNumerosAcomodadosCopia[i]);
                }
            }

            static void copiarListasDeNumerosFormarArrayDeOriginal()
            {


                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de hacer una copia de todos los elementos que tiene la lista de numeros acomodados
                //alamcenado cada uno de los numeros que estaba en esta en otra lista

                listaNumerosAcomodadosCopia.Clear();
                medicionCantidadDeAsignacionesVoraz++;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32;

                medicionCantidadDeComparacionesVoraz++;
                for (int i = 0; i < listaNumerosAcomodados.Count; i++)
                {
                    medicionCantidadDeComparacionesVoraz++;
                    listaNumerosAcomodadosCopia.Add(listaNumerosAcomodados[i]);
                }
            }

            static ArrayList listaNumerosAcomodadosCopia = new ArrayList();


            static bool realizaMovimientosConReglas = true;
            static bool hizoMovimiento = false;
            static void ordenarNumeroPosicion(int[,] matriz, int tamaño, int[,] matrizObjetivo, int[,] matrizCopia, int numOrdenar)
            {

                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de hacer todas las restricciones de movimientos y verificaciones necesarias para que el 
                //numero que se quiera ordenar poco a poco se vaya hacercando a su posicion objetivo

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matriz.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matrizCopia.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matrizObjetivo.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 64;


                string horizontal = "";
                string vertical = "";


                int numeroArribaOpcionMovimiento = -1;
                int numeroAbajoOpcionMovimiento = -1;
                int numeroDerechaOpcionMovimiento = -1;
                int numeroIzquierdaOpcionMovimiento = -1;


                double distanciaDeNumeroOrdenar;
                double distancia;

                medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 6;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 256;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 8 * horizontal.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 8 * vertical.Length;

                medicionCantidadDeComparacionesVoraz++;
                while (true)
                {
                    medicionCantidadDeComparacionesVoraz++;

                    hizoMovimiento = false;
                    encontrarCeroYColocarloEnPosicion(matriz, tamaño, matrizObjetivo, matrizCopia1, numOrdenar);
                    moverNumeroEnDireccionAObjetivo(matriz, tamaño, matrizObjetivo, matrizCopia1, numOrdenar);

                    horizontal = "";
                    vertical = "";
                   

                    distancia = distanciaDeManhattanDeunNumero(matriz, tamaño, matrizObjetivo, numOrdenar);

                    medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 4;

                    medicionCantidadDeComparacionesVoraz++;
                    if (distancia == 0)
                    {
                        break;
                    }

                    obtenerPosicionesVacioNumero(matriz, tamaño, numOrdenar, matrizObjetivo);

                    numeroArribaOpcionMovimiento = obtenerNumeroDeArriba(matriz, filaNumero, columnaNumero, tamaño);
                    numeroAbajoOpcionMovimiento = obtenerNumeroDeAbajo(matriz, filaNumero, columnaNumero, tamaño);
                    numeroDerechaOpcionMovimiento = obtenerNumeroDelaDerecha(matriz, filaNumero, columnaNumero, tamaño);
                    numeroIzquierdaOpcionMovimiento = obtenerNumeroDelaIzquierda(matriz, filaNumero, columnaNumero, tamaño);

                    vertical = revisarDireccionVerticalProximoMovimiento();
                    horizontal = revisarDireccionHorizontalProximoMovimiento();

                    medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 6;

                    medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                    if (vertical.Equals("arriba") && hizoMovimiento == false)
                    {
                        medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                        if (numeroAbajoOpcionMovimiento == 0 && hizoMovimiento == false)
                        {
                            medicionCantidadDeAsignacionesVoraz++;
                            realizaMovimientosConReglas = true;
                            medicionCantidadDeComparacionesVoraz++;
                            if (columnaNumero == tamaño - 1)//el numero esta en la ultima columna
                            {

                                copiarListasDeNumerosFormarArrayDeOriginal();
                                listaNumerosAcomodados.Clear();

                                medicionCantidadDeAsignacionesVoraz++;
                                realizaMovimientosConReglas = true;
                                Array.Copy(matriz, 0, matrizCopia, 0, tamaño * tamaño);

                                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                                while (realizaMovimientosConReglas == true && hizoMovimiento == false)
                                {
                                    medicionCantidadDeComparacionesVoraz= medicionCantidadDeComparacionesVoraz+2;

                                    moverArriba(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverArriba(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverIzquierda(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverAbajo(matrizCopia, tamaño, numOrdenar, matrizObjetivo);

                                    moverDerecha(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverAbajo(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverIzquierda(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverArriba(matrizCopia, tamaño, numOrdenar, matrizObjetivo);

                                    moverArriba(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverDerecha(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverAbajo(matrizCopia, tamaño, numOrdenar, matrizObjetivo);

                                    hizoMovimiento = true;
                                    medicionCantidadDeAsignacionesVoraz++;

                                }
                                medicionCantidadDeAsignacionesVoraz++;
                                hizoMovimiento = false;
                                medicionCantidadDeComparacionesVoraz++;
                                if (realizaMovimientosConReglas == true)
                                {
                                    moverArriba(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- arriba -");
                                    moverArriba(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- arriba -");
                                    moverIzquierda(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- izquierda -");
                                    moverAbajo(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- abajo -");

                                    moverDerecha(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- derecha -");
                                    moverAbajo(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- abajo -");
                                    moverIzquierda(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- izquierda -");
                                    moverArriba(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- arriba -");

                                    moverArriba(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- arriba -");
                                    moverDerecha(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- derecha -");
                                    moverAbajo(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- abajo -");

                                    hizoMovimiento = true;

                                    medicionCantidadDeAsignacionesVoraz++;
                                    medicionCantidadDeMovimientosEfectuadosVoraz = medicionCantidadDeMovimientosEfectuadosVoraz + 11;

                                }
                                copiarListasDeNumerosFormarArrayDeCopia();
                            }
                            medicionCantidadDeComparacionesVoraz++;
                            if (columnaNumero != tamaño - 1)
                            {
                                realizaMovimientosConReglas = true;
                                medicionCantidadDeAsignacionesVoraz++;

                                Array.Copy(matriz, 0, matrizCopia, 0, tamaño * tamaño);

                                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                                while (realizaMovimientosConReglas == true && hizoMovimiento == false)
                                {
                                    medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;

                                     moverDerecha(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverArriba(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverArriba(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverIzquierda(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverAbajo(matrizCopia, tamaño, numOrdenar, matrizObjetivo);

                                    hizoMovimiento = true;
                                    medicionCantidadDeAsignacionesVoraz++;
                                }

                                hizoMovimiento = false;
                                medicionCantidadDeAsignacionesVoraz++;
                                medicionCantidadDeComparacionesVoraz++;
                                if (realizaMovimientosConReglas == true)
                                {
                                    moverDerecha(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- derecha -");
                                    moverArriba(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- arriba -");
                                    moverArriba(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- arriba -");
                                    moverIzquierda(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- izquierda -");
                                    moverAbajo(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- abajo -");

                                    hizoMovimiento = true;
                                    medicionCantidadDeAsignacionesVoraz++;

                                    medicionCantidadDeMovimientosEfectuadosVoraz = medicionCantidadDeMovimientosEfectuadosVoraz + 5;
                                }
                            }
                        }

                        medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                        if (numeroDerechaOpcionMovimiento == 0 && hizoMovimiento == false)
                        {
                            realizaMovimientosConReglas = true;
                            medicionCantidadDeAsignacionesVoraz++;
                            Array.Copy(matriz, 0, matrizCopia, 0, tamaño * tamaño);

                            medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                            while (realizaMovimientosConReglas == true && hizoMovimiento == false)
                            {
                                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;

                                moverArriba(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                moverIzquierda(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                moverAbajo(matrizCopia, tamaño, numOrdenar, matrizObjetivo);

                                hizoMovimiento = true;
                                medicionCantidadDeAsignacionesVoraz++;
                            }

                            hizoMovimiento = false;
                            medicionCantidadDeAsignacionesVoraz++;
                            medicionCantidadDeComparacionesVoraz++;
                            if (realizaMovimientosConReglas == true)
                            {
                                moverArriba(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- arriba -");
                                moverIzquierda(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- izquierda -");
                                moverAbajo(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- abajo -");

                                hizoMovimiento = true;
                                medicionCantidadDeAsignacionesVoraz++;

                                medicionCantidadDeMovimientosEfectuadosVoraz = medicionCantidadDeMovimientosEfectuadosVoraz + 3;
                            }
                        }
                        medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                        if (numeroIzquierdaOpcionMovimiento == 0 && hizoMovimiento == false)
                        {
                            realizaMovimientosConReglas = true;
                            medicionCantidadDeAsignacionesVoraz++;
                            Array.Copy(matriz, 0, matrizCopia, 0, tamaño * tamaño);

                            medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                            while (realizaMovimientosConReglas == true && hizoMovimiento == false)
                            {
                                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;

                                moverArriba(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                moverDerecha(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                moverAbajo(matrizCopia, tamaño, numOrdenar, matrizObjetivo);

                                hizoMovimiento = true;
                                medicionCantidadDeAsignacionesVoraz++;
                            }

                            hizoMovimiento = false;
                            medicionCantidadDeAsignacionesVoraz++;
                            medicionCantidadDeComparacionesVoraz++;
                            if (realizaMovimientosConReglas == true)
                            {

                                moverArriba(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- arriba -");
                                moverDerecha(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- derecha -");
                                moverAbajo(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- abajo -");

                                hizoMovimiento = true;
                                medicionCantidadDeAsignacionesVoraz++;

                                medicionCantidadDeMovimientosEfectuadosVoraz = medicionCantidadDeMovimientosEfectuadosVoraz + 3;
                            }

                        }
                        medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                        if (hizoMovimiento == false && numeroAbajoOpcionMovimiento != 0)
                        {

                            realizaMovimientosConReglas = true;
                            medicionCantidadDeAsignacionesVoraz++;
                            Array.Copy(matriz, 0, matrizCopia, 0, tamaño * tamaño);

                            medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                            while (realizaMovimientosConReglas == true && hizoMovimiento == false)
                            {
                                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 4;
                                if (numeroIzquierdaOpcionMovimiento == 0)
                                {
                                    moverAbajo(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverDerecha(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                }
                                else if (numeroDerechaOpcionMovimiento == 0) //creo que no se ocupa tomar precauciones del caso
                                {
                                    moverAbajo(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverIzquierda(matrizCopia, tamaño, numOrdenar, matrizObjetivo);

                                }

                                hizoMovimiento = true;
                                medicionCantidadDeAsignacionesVoraz++;
                            }

                            hizoMovimiento = false;
                            medicionCantidadDeAsignacionesVoraz++;

                            medicionCantidadDeComparacionesVoraz++;
                            if (realizaMovimientosConReglas == true)
                            {
                                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                                if (numeroIzquierdaOpcionMovimiento == 0)
                                {
                                    moverAbajo(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- abajo -");
                                    moverDerecha(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- derecha -");
                                }
                                else if (numeroDerechaOpcionMovimiento == 0) //creo que no se ocupa tomar precauciones del caso
                                {
                                    moverAbajo(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- abajo -");
                                    moverIzquierda(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- izquierda -");
                                }
                                hizoMovimiento = true;
                                medicionCantidadDeAsignacionesVoraz++;

                                medicionCantidadDeMovimientosEfectuadosVoraz = medicionCantidadDeMovimientosEfectuadosVoraz + 2;
                            }
                        }
                    }
                    medicionCantidadDeComparacionesVoraz= medicionCantidadDeComparacionesVoraz+2;
                    if (vertical.Equals("abajo") && hizoMovimiento == false)
                    {
                        medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz+2;
                        if (numeroDerechaOpcionMovimiento == 0 && hizoMovimiento == false)
                        {
                            realizaMovimientosConReglas = true;
                            medicionCantidadDeAsignacionesVoraz++;

                            Array.Copy(matriz, 0, matrizCopia, 0, tamaño * tamaño);
                            medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                            while (realizaMovimientosConReglas == true && hizoMovimiento == false)
                            {
                                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                            //realizar movimientos con matriz copia
                                moverAbajo(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                moverIzquierda(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                moverArriba(matrizCopia, tamaño, numOrdenar, matrizObjetivo);


                                hizoMovimiento = true;
                                medicionCantidadDeAsignacionesVoraz++;
                            }
                            hizoMovimiento = false;
                            medicionCantidadDeAsignacionesVoraz++;
                            medicionCantidadDeComparacionesVoraz++;
                            if (realizaMovimientosConReglas == true)
                            {
                                //va realizar movimientos
                                moverAbajo(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- abajo -");
                                moverIzquierda(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- izquierda -");
                                moverArriba(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- arriba -");

                                hizoMovimiento = true;
                                medicionCantidadDeAsignacionesVoraz++;

                                medicionCantidadDeMovimientosEfectuadosVoraz = medicionCantidadDeMovimientosEfectuadosVoraz + 3;
                            }
                        }
                        medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                        if (numeroIzquierdaOpcionMovimiento == 0 && hizoMovimiento == false)
                        {
                            realizaMovimientosConReglas = true;
                            medicionCantidadDeAsignacionesVoraz++;

                             Array.Copy(matriz, 0, matrizCopia, 0, tamaño * tamaño);

                            medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                            while (realizaMovimientosConReglas == true && hizoMovimiento == false)
                            {
                                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                            //realizar movimientos con matriz copia
                                moverAbajo(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                moverDerecha(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                moverArriba(matrizCopia, tamaño, numOrdenar, matrizObjetivo);

                                hizoMovimiento = true;
                                medicionCantidadDeAsignacionesVoraz++;
                            }
                            hizoMovimiento = false;
                            medicionCantidadDeAsignacionesVoraz++;
                            medicionCantidadDeComparacionesVoraz++;
                            if (realizaMovimientosConReglas == true)
                            {
                                //va realizar movimientos
                                moverAbajo(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- abajo -");
                                moverDerecha(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- derecha -");
                                moverArriba(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- arriba -");

                                hizoMovimiento = true;
                                medicionCantidadDeAsignacionesVoraz++;

                                medicionCantidadDeMovimientosEfectuadosVoraz = medicionCantidadDeMovimientosEfectuadosVoraz + 3;
                            }
                        }
                    }
                    medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                    if (horizontal.Equals("derecha") && hizoMovimiento == false)
                    {
                        medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                        if (numeroAbajoOpcionMovimiento == 0 && hizoMovimiento == false)
                        {
                            realizaMovimientosConReglas = true;
                            medicionCantidadDeAsignacionesVoraz++;

                            Array.Copy(matriz, 0, matrizCopia, 0, tamaño * tamaño);

                            medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                            while (realizaMovimientosConReglas == true && hizoMovimiento == false)
                            {
                                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                            //realizar movimientos con matriz copia
                                 moverDerecha(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                moverArriba(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                moverIzquierda(matrizCopia, tamaño, numOrdenar, matrizObjetivo);

                                hizoMovimiento = true;
                                medicionCantidadDeAsignacionesVoraz++;
                            }
                            hizoMovimiento = false;
                            medicionCantidadDeAsignacionesVoraz++;
                            medicionCantidadDeComparacionesVoraz++;
                            if (realizaMovimientosConReglas == true)
                            {
                                //va realizar movimientos
                                moverDerecha(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- derecha -");
                                moverArriba(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- arriba -");
                                moverIzquierda(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- izquierda -");

                                hizoMovimiento = true;
                                medicionCantidadDeAsignacionesVoraz++;

                                medicionCantidadDeMovimientosEfectuadosVoraz = medicionCantidadDeMovimientosEfectuadosVoraz + 3;
                            }
                        }

                        medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                        if (numeroIzquierdaOpcionMovimiento == 0 && hizoMovimiento == false)
                        {
                            realizaMovimientosConReglas = true;
                            medicionCantidadDeAsignacionesVoraz++;
                            Array.Copy(matriz, 0, matrizCopia, 0, tamaño * tamaño);

                            medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                            while (realizaMovimientosConReglas == true && hizoMovimiento == false)
                            {
                                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;

                                moverAbajo(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                moverDerecha(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                moverDerecha(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                moverArriba(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                moverIzquierda(matrizCopia, tamaño, numOrdenar, matrizObjetivo);

                                hizoMovimiento = true;
                                medicionCantidadDeAsignacionesVoraz++;
                            }

                            hizoMovimiento = false;
                            medicionCantidadDeAsignacionesVoraz++;
                            medicionCantidadDeComparacionesVoraz++;
                            if (realizaMovimientosConReglas == true)
                            {
                                //va realizar movimientos
                                moverAbajo(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- abajo -");
                                moverDerecha(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- derecha -");
                                moverDerecha(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- derecha -");
                                moverArriba(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- arriba -");
                                moverIzquierda(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- izquierda -");

                                hizoMovimiento = true;
                                medicionCantidadDeAsignacionesVoraz++;

                                medicionCantidadDeMovimientosEfectuadosVoraz = medicionCantidadDeMovimientosEfectuadosVoraz + 5;
                            }
                        }


                    }
                    medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                    if (horizontal.Equals("izquierda") && hizoMovimiento == false)
                    {
                        medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                        if (numeroAbajoOpcionMovimiento == 0 && hizoMovimiento == false)
                        {
                            realizaMovimientosConReglas = true;
                            medicionCantidadDeAsignacionesVoraz++;

                            Array.Copy(matriz, 0, matrizCopia, 0, tamaño * tamaño);

                            medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                            while (realizaMovimientosConReglas == true && hizoMovimiento == false)
                            {
                                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                            //realizar movimientos con matriz copia
                                moverIzquierda(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                moverArriba(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                moverDerecha(matrizCopia, tamaño, numOrdenar, matrizObjetivo);

                                hizoMovimiento = true;
                                medicionCantidadDeAsignacionesVoraz++;
                            }
                            hizoMovimiento = false;
                            medicionCantidadDeAsignacionesVoraz++;
                            medicionCantidadDeComparacionesVoraz++;
                            if (realizaMovimientosConReglas == true)
                            {
                                //va realizar movimientos
                                moverIzquierda(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- izquierda -");
                                moverArriba(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- arriba -");
                                moverDerecha(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- derecha -");

                                hizoMovimiento = true;
                                medicionCantidadDeAsignacionesVoraz++;

                                medicionCantidadDeMovimientosEfectuadosVoraz = medicionCantidadDeMovimientosEfectuadosVoraz + 3;
                            }
                        }
                        medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                        if (numeroArribaOpcionMovimiento == 0 && hizoMovimiento == false)
                        {
                            realizaMovimientosConReglas = true;
                            medicionCantidadDeAsignacionesVoraz++;

                            Array.Copy(matriz, 0, matrizCopia, 0, tamaño * tamaño);

                            medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                            while (realizaMovimientosConReglas == true && hizoMovimiento == false)
                            {
                                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                            //realizar movimientos con matriz copia
                                moverIzquierda(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                moverAbajo(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                moverDerecha(matrizCopia, tamaño, numOrdenar, matrizObjetivo);

                                hizoMovimiento = true;
                                medicionCantidadDeAsignacionesVoraz++;
                            }
                            hizoMovimiento = false;
                            medicionCantidadDeAsignacionesVoraz++;
                            medicionCantidadDeComparacionesVoraz++;
                            if (realizaMovimientosConReglas == true)
                            {
                                //va realizar movimientos
                                moverIzquierda(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- izquierda -");
                                moverAbajo(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- abajo -");
                                moverDerecha(matriz, tamaño, numOrdenar, matrizObjetivo);
                                Console.Write("- derecha -");

                                hizoMovimiento = true;
                                medicionCantidadDeAsignacionesVoraz++;

                                medicionCantidadDeMovimientosEfectuadosVoraz = medicionCantidadDeMovimientosEfectuadosVoraz + 3;
                            }

                            medicionCantidadDeComparacionesVoraz++;
                            if (hizoMovimiento == false) // poner cero a la derecha
                            {
                                realizaMovimientosConReglas = true;
                                medicionCantidadDeAsignacionesVoraz++;

                                Array.Copy(matriz, 0, matrizCopia, 0, tamaño * tamaño);

                                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                                while (realizaMovimientosConReglas == true && hizoMovimiento == false)
                                {
                                    medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                                //realizar movimientos con matriz copia
                                    moverDerecha(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverAbajo(matrizCopia, tamaño, numOrdenar, matrizObjetivo);


                                    hizoMovimiento = true;
                                    medicionCantidadDeAsignacionesVoraz++;
                                }
                                hizoMovimiento = false;
                                medicionCantidadDeAsignacionesVoraz++;
                                medicionCantidadDeComparacionesVoraz++;
                                if (realizaMovimientosConReglas == true)
                                {
                                    //va realizar movimientos
                                    moverDerecha(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- derecha -");
                                    moverAbajo(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- abajo -");


                                    hizoMovimiento = true;
                                    medicionCantidadDeAsignacionesVoraz++;

                                    medicionCantidadDeMovimientosEfectuadosVoraz = medicionCantidadDeMovimientosEfectuadosVoraz + 2;
                                }
                            }
                        }
                        medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                        if (numeroDerechaOpcionMovimiento == 0 && hizoMovimiento == false)
                        {
                            medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                            if (filaNumero != tamaño - 1 && hizoMovimiento == false)
                            {
                                realizaMovimientosConReglas = true;
                                medicionCantidadDeAsignacionesVoraz++;
                                Array.Copy(matriz, 0, matrizCopia, 0, tamaño * tamaño);

                                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                                while (realizaMovimientosConReglas == true && hizoMovimiento == false)
                                {
                                    medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;

                                    moverAbajo(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverIzquierda(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverIzquierda(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverArriba(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverDerecha(matrizCopia, tamaño, numOrdenar, matrizObjetivo);

                                    hizoMovimiento = true;
                                    medicionCantidadDeAsignacionesVoraz++;
                                }

                                hizoMovimiento = false;
                                medicionCantidadDeAsignacionesVoraz++;
                                medicionCantidadDeComparacionesVoraz++;
                                if (realizaMovimientosConReglas == true)
                                {
                                    //va realizar movimientos
                                    moverAbajo(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- abajo -");
                                    moverIzquierda(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- izquierda -");
                                    moverIzquierda(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- izquierda -");
                                    moverArriba(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- arriba -");
                                    moverDerecha(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- derecha -");

                                    hizoMovimiento = true;
                                    medicionCantidadDeAsignacionesVoraz++;
                                    medicionCantidadDeMovimientosEfectuadosVoraz = medicionCantidadDeMovimientosEfectuadosVoraz + 5;
                                }
                            }
                            medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                            if (filaNumero == tamaño - 1 && hizoMovimiento == false)
                            {

                                realizaMovimientosConReglas = true;
                                medicionCantidadDeAsignacionesVoraz++;
                                Array.Copy(matriz, 0, matrizCopia, 0, tamaño * tamaño);

                                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                                while (realizaMovimientosConReglas == true && hizoMovimiento == false)
                                {
                                    medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;

                                    moverArriba(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverIzquierda(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverIzquierda(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverAbajo(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                    moverDerecha(matrizCopia, tamaño, numOrdenar, matrizObjetivo);

                                    hizoMovimiento = true;
                                    medicionCantidadDeAsignacionesVoraz++;
                                }

                                hizoMovimiento = false;
                                medicionCantidadDeAsignacionesVoraz++;
                                medicionCantidadDeComparacionesVoraz++;
                                if (realizaMovimientosConReglas == true)
                                {
                                    //va realizar movimientos
                                    moverArriba(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- arriba -");
                                    moverIzquierda(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- izquierda -");
                                    moverIzquierda(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- izquierda -");
                                    moverAbajo(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- abajo -");
                                    moverDerecha(matriz, tamaño, numOrdenar, matrizObjetivo);
                                    Console.Write("- derecha -");

                                    hizoMovimiento = true;
                                    medicionCantidadDeAsignacionesVoraz++;

                                    medicionCantidadDeMovimientosEfectuadosVoraz = medicionCantidadDeMovimientosEfectuadosVoraz + 5;
                                }
                                medicionCantidadDeComparacionesVoraz++;
                                if (hizoMovimiento == false)
                                {
                                    copiarListasDeNumerosFormarArrayDeOriginal();
                                    listaNumerosAcomodados.Clear();

                                    realizaMovimientosConReglas = true;
                                    medicionCantidadDeAsignacionesVoraz++;
                                    Array.Copy(matriz, 0, matrizCopia, 0, tamaño * tamaño);

                                    medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                                    while (realizaMovimientosConReglas == true && hizoMovimiento == false)
                                    {
                                        medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;

                                        moverIzquierda(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                        moverIzquierda(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                        moverArriba(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                        moverDerecha(matrizCopia, tamaño, numOrdenar, matrizObjetivo);

                                        moverAbajo(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                        moverDerecha(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                        moverArriba(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                        moverIzquierda(matrizCopia, tamaño, numOrdenar, matrizObjetivo);

                                        moverIzquierda(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                        moverAbajo(matrizCopia, tamaño, numOrdenar, matrizObjetivo);
                                        moverDerecha(matrizCopia, tamaño, numOrdenar, matrizObjetivo);

                                        hizoMovimiento = true;
                                        medicionCantidadDeAsignacionesVoraz++;
                                    }

                                    hizoMovimiento = false;
                                    medicionCantidadDeAsignacionesVoraz++;
                                    medicionCantidadDeComparacionesVoraz++;
                                    if (realizaMovimientosConReglas == true)
                                    {
                                        //va realizar movimientos
                                        moverIzquierda(matriz, tamaño, numOrdenar, matrizObjetivo);
                                        Console.Write("- izquierda -");
                                        moverIzquierda(matriz, tamaño, numOrdenar, matrizObjetivo);
                                        Console.Write("- izquierda -");
                                        moverArriba(matriz, tamaño, numOrdenar, matrizObjetivo);
                                        Console.Write("- arriba -");
                                        moverDerecha(matriz, tamaño, numOrdenar, matrizObjetivo);
                                        Console.Write("- derecha -");


                                        moverAbajo(matriz, tamaño, numOrdenar, matrizObjetivo);
                                        Console.Write("- abajo -");
                                        moverDerecha(matriz, tamaño, numOrdenar, matrizObjetivo);
                                        Console.Write("- derecha -");
                                        moverArriba(matriz, tamaño, numOrdenar, matrizObjetivo);
                                        Console.Write("- arriba -");
                                        moverIzquierda(matriz, tamaño, numOrdenar, matrizObjetivo);
                                        Console.Write("- izquierda -");

                                        moverIzquierda(matriz, tamaño, numOrdenar, matrizObjetivo);
                                        Console.Write("- izquierda -");
                                        moverAbajo(matriz, tamaño, numOrdenar, matrizObjetivo);
                                        Console.Write("- abajo -");
                                        moverDerecha(matriz, tamaño, numOrdenar, matrizObjetivo);
                                        Console.Write("- derecha -");

                                        hizoMovimiento = true;
                                        medicionCantidadDeAsignacionesVoraz++;

                                        medicionCantidadDeMovimientosEfectuadosVoraz = medicionCantidadDeMovimientosEfectuadosVoraz + 11;
                                    }
                                    copiarListasDeNumerosFormarArrayDeCopia();
                                }
                            }
                        }
                    }
                    medicionCantidadDeAsignacionesVoraz++;
                    distanciaDeNumeroOrdenar = distanciaDeManhattanDeunNumero(matriz, tamaño, matrizObjetivo, numOrdenar);
                    medicionCantidadDeComparacionesVoraz++;
                    if (distanciaDeNumeroOrdenar == 0)
                    {
                        break;
                    }
                }
            }

            static int filaCero = 0;
            static int columnaCero = 0;
            static int filaNumero = 0;
            static int columnaNumero = 0;

            static int filaNumeroVerdaderaPosicion = 0;
            static int columnaVeradaderaPosicion = 0;




            static void obtenerPosicionesVacioNumero(int[,] matriz, int tamaño, int numOrdenar, int[,] matrizObjetivo)
            {

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matriz.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matrizObjetivo.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 64;

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 64;

                medicionCantidadDeComparacionesVoraz++;
                medicionCantidadDeAsignacionesVoraz++;
                for (int filas = 0; filas < tamaño; filas++)
                {
                    medicionCantidadDeComparacionesVoraz++;

                    medicionCantidadDeComparacionesVoraz++;
                    medicionCantidadDeAsignacionesVoraz++;
                    for (int columnas = 0; columnas < tamaño; columnas++)
                    {
                        medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 4;
                        if (matriz[filas, columnas] == 0)
                        {
                            filaCero = filas;
                            columnaCero = columnas;

                            medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 2;
                        }
                        else if (matriz[filas, columnas] == numOrdenar)
                        {
                            filaNumero = filas;
                            columnaNumero = columnas;

                            medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 2;
                        }
                        else if (matrizObjetivo[filas, columnas] == numOrdenar)
                        {
                            filaNumeroVerdaderaPosicion = filas;
                            columnaVeradaderaPosicion = columnas;

                            medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 2;
                        }
                    }
                }
            }


            static void encontrarCeroYColocarloEnPosicion(int[,] matriz, int tamaño, int[,] matrizObjetivo, int[,] matrizCopia, int numOrdenar)
            {


                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matriz.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matrizCopia.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matrizObjetivo.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 64;

                int numeroAbajo;
                int numeroIzquierda;
                int numeroArriba;
                int numeroDerecha;
                bool elNumeroEstaEnLaLista;
                bool entro = false;

                bool estanALaPar = false;

                medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 2;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 152;

                medicionCantidadDeComparacionesVoraz++;
                while (true)
                {
                    medicionCantidadDeComparacionesVoraz++;

                    obtenerPosicionesVacioNumero(matriz, tamaño, numOrdenar, matrizObjetivo);
                    medicionCantidadDeAsignacionesVoraz++;
                    estanALaPar = revisarSiEstanALaPar(filaCero, columnaCero, numOrdenar, matriz, tamaño);
                    medicionCantidadDeComparacionesVoraz++;
                    if (estanALaPar == true)
                    {
                        break;
                    }
                    else
                    {
                        medicionCantidadDeComparacionesVoraz++;
                        if (filaNumero > filaCero)//primer metodo.....//mover abajo
                        {
                            numeroAbajo = ObtenerNumero(matriz, filaCero + 1, columnaCero, tamaño);
                            elNumeroEstaEnLaLista = listaNumerosAcomodados.Contains(numeroAbajo);

                            medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 2;
                            medicionCantidadDeComparacionesVoraz++;
                            if (elNumeroEstaEnLaLista == false)
                            {
                                medicionCantidadDeMovimientosEfectuadosVoraz++;
                                mover(numeroAbajo, matriz, tamaño);

                                Console.Write("- abajo -");

                                entro = true;
                                medicionCantidadDeAsignacionesVoraz++;
                            }
                        }
                        medicionCantidadDeComparacionesVoraz++;
                        if (filaNumero < filaCero) // segundo metodo.....//mover arriba
                        {

                            numeroArriba = ObtenerNumero(matriz, filaCero - 1, columnaCero, tamaño);

                            elNumeroEstaEnLaLista = listaNumerosAcomodados.Contains(numeroArriba);

                            medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 2;
                            medicionCantidadDeComparacionesVoraz++;
                            if (elNumeroEstaEnLaLista == false)
                            {
                                medicionCantidadDeMovimientosEfectuadosVoraz++;
                                mover(numeroArriba, matriz, tamaño);

                                Console.Write("- arriba -");

                                entro = true;
                                medicionCantidadDeAsignacionesVoraz++;
                            }

                        }
                        medicionCantidadDeComparacionesVoraz++;
                        if (entro == false)//estan en la misma fila
                        {
                            medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                            if (columnaNumero < columnaCero)  //moverIzquierda
                            {

                                numeroIzquierda = ObtenerNumero(matriz, filaCero, columnaCero - 1, tamaño);

                                elNumeroEstaEnLaLista = listaNumerosAcomodados.Contains(numeroIzquierda);

                                medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 2;
                                medicionCantidadDeComparacionesVoraz++;
                                if (elNumeroEstaEnLaLista == false)
                                {
                                    medicionCantidadDeMovimientosEfectuadosVoraz++;
                                    mover(numeroIzquierda, matriz, tamaño);

                                    Console.Write("- izquierda -");
                                }
                            }
                            else if (columnaNumero > columnaCero)//moverDerecha
                            {


                                numeroDerecha = ObtenerNumero(matriz, filaCero, columnaCero + 1, tamaño);

                                elNumeroEstaEnLaLista = listaNumerosAcomodados.Contains(numeroDerecha);

                                medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 2;
                                medicionCantidadDeComparacionesVoraz++;
                                if (elNumeroEstaEnLaLista == false)
                                {
                                    medicionCantidadDeMovimientosEfectuadosVoraz++;
                                    mover(numeroDerecha, matriz, tamaño);

                                    Console.Write("- derecha -");
                                }
                            }
                        }
                        medicionCantidadDeAsignacionesVoraz++;
                        entro = false;
                    }
                }
            }


            static bool revisarSiEstanALaPar(int filaCero, int columnaCero, int numOrdenar, int[,] matriz, int tamaño)
            {
                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de verificar si el numero que se quiere ordenenar esta a par del espacio vacio, de 
                //esta manera se puede mover con libertad el numero hacia donde se desee


                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matriz.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 128;


                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 136;

                bool estanALaPar = false;
                //se analiza los numeros que estan alrededor del vacio, para verificar que el numeroOrdenar esta a la par

                int numeroArribaOpcionMovimiento = obtenerNumeroDeArriba(matriz, filaNumero, columnaNumero, tamaño);
                int numeroAbajoOpcionMovimiento = obtenerNumeroDeAbajo(matriz, filaNumero, columnaNumero, tamaño);
                int numeroDerechaOpcionMovimiento = obtenerNumeroDelaDerecha(matriz, filaNumero, columnaNumero, tamaño);
                int numeroIzquierdaOpcionMovimiento = obtenerNumeroDelaIzquierda(matriz, filaNumero, columnaNumero, tamaño);


                medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 5;

                
                if (numeroArribaOpcionMovimiento == 0)
                {
                    medicionCantidadDeAsignacionesVoraz++;
                    estanALaPar = true;
                }
                if (numeroDerechaOpcionMovimiento == 0)
                {
                    medicionCantidadDeAsignacionesVoraz++;
                    estanALaPar = true;
                }
                if (numeroIzquierdaOpcionMovimiento == 0)
                {
                    medicionCantidadDeAsignacionesVoraz++;
                    estanALaPar = true;
                }
                if (numeroAbajoOpcionMovimiento == 0)
                {
                    medicionCantidadDeAsignacionesVoraz++;
                    estanALaPar = true;

                }
                medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 4;
               

                return estanALaPar;
            }
            static double distanciaDeManhattanDeunNumero(int[,] puzzle, int tamaño, int[,] obje, int numOrdenar)
            {

                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de veriricar la distancia de manhattan de un numero en especifico,
                //de esta manera se puede conocer si este esta acomodado o no

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * puzzle.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * obje.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 64;


                medicionCantidadDeAsignacionesVoraz++;
                double suma = 0;
                int num;

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 96;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 64;

                medicionCantidadDeComparacionesVoraz++;
                medicionCantidadDeAsignacionesVoraz++;
                for (int i = 0; i < tamaño; ++i)
                {
                    medicionCantidadDeComparacionesVoraz++;

                    medicionCantidadDeComparacionesVoraz++;
                    medicionCantidadDeAsignacionesVoraz++;
                    for (int j = 0; j < tamaño; ++j)
                    {
                        medicionCantidadDeComparacionesVoraz++;
                    //  Console.WriteLine("num [i][j]: " + puzzle[i, j]);
                        medicionCantidadDeComparacionesVoraz++;
                        if (puzzle[i, j] != 0)
                        {
                            medicionCantidadDeComparacionesVoraz++;
                            if (puzzle[i, j] == numOrdenar)
                            {
                                medicionCantidadDeComparacionesVoraz++;
                                if (obje[i, j] != puzzle[i, j])
                                {
                                    //Buscamos la posición correcta para la ficha en puzzle[i][j]
                                    int i2 = 0, j2 = 0;
                                    medicionCantidadDeAsignacionesVoraz= medicionCantidadDeAsignacionesVoraz +2;

                                medicionCantidadDeComparacionesVoraz= medicionCantidadDeComparacionesVoraz+2;
                                while (i2 < obje.Length && (obje[i2, j2] != puzzle[i, j]))
                                    {
                                        medicionCantidadDeComparacionesVoraz = medicionCantidadDeComparacionesVoraz + 2;
                                        j2++;
                                        medicionCantidadDeComparacionesVoraz++;
                                        if (j2 >= tamaño) { i2++; j2 = 0; }
                                    }
                                    num = Math.Abs(i2 - i) + Math.Abs(j2 - j);

                                    //  Console.WriteLine("cant: " + num);

                                    suma = Math.Abs(i2 - i) + Math.Abs(j2 - j);

                                    medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 2;
                                    //En [i2][j2] está la posición correcta
                                }
                                else
                                {
                                    medicionCantidadDeAsignacionesVoraz++;
                                    suma = 0;
                                }

                            }

                        }

                    }
                }

                return suma;

            }

            static bool filaSeleccionadaEstaIgualAObjetivo(int[,] matriz, int tamaño, int[,] matrizObjetivo, int filaEnviada)
            {

                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: se encarga de verificar que la fila que se esta ordenando este igual a la fila objetivo
                // de esta manera se puede determinar cuando la fila esta realmente ordenada

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matriz.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 32 * matrizObjetivo.Length;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 64;


                bool estaOrdenada = true;
                medicionCantidadDeAsignacionesVoraz++;

                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 8;
                medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 64;

                medicionCantidadDeComparacionesVoraz++;
                medicionCantidadDeAsignacionesVoraz++;
                for (int filas = 0; filas < tamaño; filas++)
                {
                    medicionCantidadDeComparacionesVoraz++;

                    medicionCantidadDeComparacionesVoraz++;
                    medicionCantidadDeAsignacionesVoraz++;
                    for (int columnas = 0; columnas < tamaño; columnas++)
                    {
                        medicionCantidadDeComparacionesVoraz++;

                        medicionCantidadDeComparacionesVoraz++;
                        if (filas == filaEnviada)
                        {
                            medicionCantidadDeComparacionesVoraz++;
                            if (matriz[filas, columnas] != matrizObjetivo[filas, columnas])
                            {
                                medicionCantidadDeAsignacionesVoraz++;
                                estaOrdenada = false;
                                break;
                            }
                        }

                    }
                }
                return estaOrdenada;
            }
            // ---------------------------------------- fin voraz -----------------------------------------------










            ///.................................................. GENETICO ..........................................

            static void imprimirTodaLaInfo()
            {

                Console.WriteLine("\n\ncomparaciones:          " + comparacionGenetico);
                Console.WriteLine("asignaciones:           " + asignacionGenetico);
                Console.WriteLine("cantidad de memoria:    " + cantMemoriagenet);
                Console.WriteLine("movimientos para la solucion:    " + movimientosGen);
                Console.WriteLine("\n________________________________________________________________________\n");
                Console.ReadKey();
            }

            static void inicializaInfoGne()
            {
                comparacionGenetico = 0;
                asignacionGenetico = 0;
                cantMemoriagenet = 0;
                movimientosGen = 0;
                gn.Clear();
            }

            static void imprimirHtod(List<int> lista)
            {
            cantMemoriagenet += lista.Count * 32;
            cantMemoriagenet += 32;
            for (int i = 0; i < lista.Count; i++)
                {
                    Console.Write(lista[i] + ", ");
                }
            }

            static bool verificarNoIguales(List<int[,]> gn, int capacidadDeMatriz, int[,] madre)
            {
            //fecha inicio: 09/05/16
            //fecha final: 07/06/16
            //descripcion: verifica que las matrices que recibe no este dentro de la lista de gn

            cantMemoriagenet += (32 * capacidadDeMatriz * 2) * gn.Count;
            cantMemoriagenet += 32;
            cantMemoriagenet += madre.Length * 32;


            int m = 0;
            cantMemoriagenet += 32;
            asignacionGenetico++;// a
            cantMemoriagenet += 32;//m
            for (int o = 0; o < gn.Count; o++)
            {
                comparacionGenetico++;//c
                m = 0;
                asignacionGenetico++;//a
                cantMemoriagenet += 32;//m
                for (int i = 0; i < capacidadDeMatriz; i++)
                {
                    comparacionGenetico++;//c
                    cantMemoriagenet += 32;//m
                    for (int j = 0; j < capacidadDeMatriz; j++)
                    {
                        comparacionGenetico += 2;//c
                                               
                        if (gn[o][i, j] == madre[i, j])
                        {
                            m = m + 1;
                            asignacionGenetico++;//a
                        }
                    }
                    comparacionGenetico += 2;//c
                    asignacionGenetico++; //a                  
                    if (m >= capacidadDeMatriz * capacidadDeMatriz)
                    {
                        return true;
                    }
                }
                asignacionGenetico++;//a
                comparacionGenetico++;//c
            }
            asignacionGenetico++;//a
            comparacionGenetico++;//c
            return false;
        }

            static int[,] madre(int[,] padre, int capacidadDeMatriz, int[,] obje, int[,] geneticoMadre)
            {
                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: genera o contrute a la madre. 

                cantMemoriagenet += 32 * padre.Length*3;
                cantMemoriagenet += 32;

                generarMadre(padre, capacidadDeMatriz, obje, geneticoMadre);
                int[,] madre = gn[gn.Count - 1];
                cantMemoriagenet += 32 * madre.Length;
                contadorVecesGenetico = 0;
                asignacionGenetico += 2;//a
                return madre;

            }

            static void generarMadre(int[,] padre, int capacidadDeMatriz, int[,] obje, int[,] geneticoMadre)
            {
                //fecha inicio: 09/05/16
                //fecha final: 07/06/16
                //descripcion: genera los movimietnos para crear a la madre.
                cantMemoriagenet += padre.Length * 32*3;
                cantMemoriagenet += 32;

                

                int[,] madre = raiz.insertarEnCopia(capacidadDeMatriz, padre);
                double numeroDist = 999999;
                double numero = 999999;

                cantMemoriagenet += 32 * madre.Length;
                cantMemoriagenet += 64 * 2;
                asignacionGenetico += 3;//a
                gn.Add(padre);
                comparacionGenetico++;//c
                if (contadorVecesGenetico >= 5)
                {
                    return;
                }
                cantMemoriagenet += 32;
                for (int i = 0; i < capacidadDeMatriz; i++)
                {
                    comparacionGenetico++;//c
                    cantMemoriagenet += 32;
                    for (int j = 0; j < capacidadDeMatriz; j++)
                    {
                        comparacionGenetico += 2;
                        if (padre[i, j] == 0)
                        {
                            comparacionGenetico++;//c
                            if (i - 1 >= 0)//mover arriba
                            {
                                int numeroCambioDePos = madre[i - 1, j];
                                cantMemoriagenet += 32;
                                madre[i - 1, j] = madre[i, j];
                                madre[i, j] = numeroCambioDePos;
                                numeroDist = distanciaDeManhattan(padre, capacidadDeMatriz, obje);
                                asignacionGenetico += 4;//a
                            }
                            comparacionGenetico += 2;//c
                            if (numeroDist < numero && verificarNoIguales(gn, capacidadDeMatriz, madre) == false)
                            {
                                numero = numeroDist;
                                geneticoMadre = raiz.insertarEnCopia(capacidadDeMatriz, madre);
                                asignacionGenetico += 2;//a
                            }
                            comparacionGenetico++;//c
                            if (i + 1 < capacidadDeMatriz)// mover abajo
                            {
                                madre = raiz.insertarEnCopia(capacidadDeMatriz, padre);
                                int numeroCambioDePos = madre[i + 1, j];                                
                                cantMemoriagenet += 32;
                                madre[i + 1, j] = madre[i, j];
                                madre[i, j] = numeroCambioDePos;
                                numeroDist = distanciaDeManhattan(padre, capacidadDeMatriz, obje);
                                asignacionGenetico += 5;//a
                            }
                            comparacionGenetico += 2;//c
                            if (numeroDist < numero && verificarNoIguales(gn, capacidadDeMatriz, madre) == false)
                            {
                                numero = numeroDist;
                                geneticoMadre = raiz.insertarEnCopia(capacidadDeMatriz, madre);
                                asignacionGenetico += 2;// a
                            }

                            comparacionGenetico++;//c
                            if (j - 1 >= 0)//mover izquierda
                            {
                                madre = raiz.insertarEnCopia(capacidadDeMatriz, padre);
                                int numeroCambioDePos = madre[i, j - 1];
                                cantMemoriagenet += 32;
                                madre[i, j - 1] = madre[i, j];
                                madre[i, j] = numeroCambioDePos;
                                numeroDist = distanciaDeManhattan(padre, capacidadDeMatriz, obje);
                                asignacionGenetico += 5;
                            }
                            comparacionGenetico+=2;//c
                            if (numeroDist < numero && verificarNoIguales(gn, capacidadDeMatriz, madre) == false)
                            {
                                numero = numeroDist;
                                geneticoMadre = raiz.insertarEnCopia(capacidadDeMatriz, madre);
                                asignacionGenetico += 2;//a
                            }

                            comparacionGenetico++;//c
                            if (j + 1 < capacidadDeMatriz)//mover derecha
                            {
                                madre = raiz.insertarEnCopia(capacidadDeMatriz, padre);
                                int numeroCambioDePos = madre[i, j + 1];
                                cantMemoriagenet += 32;
                                madre[i, j + 1] = madre[i, j];
                                madre[i, j] = numeroCambioDePos;
                                numeroDist = distanciaDeManhattan(padre, capacidadDeMatriz, obje);
                                asignacionGenetico += 5;//a
                            }

                            comparacionGenetico += 2;//c
                            if (numeroDist < numero && verificarNoIguales(gn, capacidadDeMatriz, madre) == false)
                            {
                                numero = numeroDist;
                                geneticoMadre = raiz.insertarEnCopia(capacidadDeMatriz, madre);
                                asignacionGenetico += 2;//a
                            }
                            contadorVecesGenetico = contadorVecesGenetico + 1;
                            asignacionGenetico++;//a

                            generarMadre(geneticoMadre, capacidadDeMatriz, obje, geneticoMadre);
                        }

                        comparacionGenetico++;//c
                        asignacionGenetico++;//a
                    }
                    comparacionGenetico++;//c
                    asignacionGenetico++;//a
                }
                comparacionGenetico++;//c
                asignacionGenetico++;//a
                return;
            }

            static ArrayList desacomodados = new ArrayList();
            
            static void verificarMatrizCampo(int[,] matriz, int capacidadDeMatriz, int[,] obje)
            {
            //fecha inicio: 09/05/16
            //fecha final: 07/06/16
            //descripcion: verifica y crea nuevos campos de la madre.
            cantMemoriagenet += 32 * matriz.Length * 2;
            cantMemoriagenet += 32;


            listaNumerosAcomodados.Clear();
            desacomodados.Clear();
            cantMemoriagenet += 32;
            for (int i = 0; i < capacidadDeMatriz; i++)
            {
                comparacionGenetico++;// c
                cantMemoriagenet += 32;
                for (int j = 0; j < capacidadDeMatriz; j++)
                {
                    comparacionGenetico += 2;//c
                    if (matriz[i, j] == obje[i, j])
                    {
                        listaNumerosAcomodados.Add(matriz[i, j]);
                    }
                    else if (matriz[i, j] != obje[i, j] && matriz[i, j] != 0)
                    {
                        desacomodados.Add(matriz[i, j]);
                    }
                    comparacionGenetico+=2;//c
                }

                comparacionGenetico++;//c
                asignacionGenetico++;//a
            }

            comparacionGenetico++;//c
            asignacionGenetico++;//a
        }

            static bool verificarMatriz(int[,] matriz, int capacidadDeMatriz, int[,] obje, int[,] copiaM)
            {
            //fecha inicio: 09/05/16
            //fecha final: 07/06/16
            //descripcion: realiza el proceso de mutacion
            listaNumerosAcomodados.Clear();
            desacomodados.Clear();
            verificarMatrizCampo(matriz, capacidadDeMatriz, obje);

            comparacionGenetico++;//c                                  
            if (desacomodados.Count <= capacidadDeMatriz * capacidadDeMatriz / 2)
            {
                metodoVoraz(matriz, capacidadDeMatriz, obje, copiaM);
                for (int i = 0; i < capacidadDeMatriz; i++) //preguntar a prof
                {
                    cantMemoriagenet += 64;
                    for (int j = 0; j < capacidadDeMatriz; j++)
                    {
                        Console.Write(matriz[i, j] + "   ");
                    }
                }
                return true;
            }
            else
            {
                return false;
            }
        }

            static int[,] madreCruce(int[,] mamaMat, int[,] geneticoMadre, int capacidadDeMatriz, int division)
            {
            //fecha inicio: 09/05/16
            //fecha final: 07/06/16
            //descripcion: realiza el proceso cruce en la madre

                hijo1.Clear();                
                mama2.Clear();
                papa.Clear();
                int[,] hijo1Matriz = new int[capacidadDeMatriz, capacidadDeMatriz];
                int[,] hijo2Matriz = new int[capacidadDeMatriz, capacidadDeMatriz];
                
                cantMemoriagenet += 2 *32* hijo1.Count;
                asignacionGenetico += 2;//a
                cantMemoriagenet += 32;
                for (int i = 0; i < capacidadDeMatriz; i++)
                {
                    comparacionGenetico++;// c
                    cantMemoriagenet += 32;
                    for (int j = 0; j < capacidadDeMatriz; j++)
                    {
                        comparacionGenetico++;//c
                        mama2.Add(geneticoMadre[i, j]);
                        papa.Add(mamaMat[i, j]);
                    }
                    comparacionGenetico++;//c
                    asignacionGenetico++;//a
                }
                comparacionGenetico++;//c
                asignacionGenetico++;//a
                cantMemoriagenet += 32;
                for (int i = 0; i < geneticoMadre.Length; i++)
                {
                    comparacionGenetico += 2;//c
                    if (i <= geneticoMadre.Length / division)
                    {
                        hijo1.Add(mama2[i]);

                    }
                    else
                    {
                        cantMemoriagenet += 32;
                        for (int p = 0; p < geneticoMadre.Length; p++)
                        {
                            comparacionGenetico += 2;//c
                            if (!hijo1.Contains(papa[p]))
                            {
                                hijo1.Add(papa[p]);
                            }
                        }
                        comparacionGenetico++;//c
                        asignacionGenetico++;//a
                    }
                }
                comparacionGenetico++;//c
                asignacionGenetico++;//a

                int pos = 0;
                asignacionGenetico++;//a
                cantMemoriagenet += 32*2;
                for (int i = 0; i < capacidadDeMatriz; i++)
                {
                    comparacionGenetico++;//c
                    cantMemoriagenet += 32;
                    for (int j = 0; j < capacidadDeMatriz; j++)
                    {
                        comparacionGenetico++;//c
                        asignacionGenetico++;//a
                        hijo1Matriz[i, j] = hijo1[pos];
                        pos++;
                    }
                    comparacionGenetico++;//c
                    asignacionGenetico++;//a
                }
                comparacionGenetico++;//c
                asignacionGenetico++;//a
                return hijo1Matriz;
           }

            static int maxCicloGenetico = 2;

            static void cruceGenetico(int[,] padre, int capacidadDeMatriz, int[,] mamaMat, int[,] geneticoMadre, int ciclo, int[,] copiaM)
            {

            //fecha inicio: 09/05/16
            //fecha final: 07/06/16
            //descripcion: realiza el proceso cruce de las siguientes generaciones

                int[,] mama = madre(padre, capacidadDeMatriz, mamaMat, geneticoMadre);
                double hijo1Apadre = distanciaDeManhattan(mama, capacidadDeMatriz, mamaMat);
                double hijo2Apadre = distanciaDeManhattan(padre, capacidadDeMatriz, mamaMat);
                asignacionGenetico += 3;//a
                cantMemoriagenet += 32*mama.Length;
                cantMemoriagenet += 64*2;
                comparacionGenetico++;//c
                if (ciclo == (capacidadDeMatriz * capacidadDeMatriz))
                {
                    ciclo = 0;
                    bool sePuede = comprobar(padre, capacidadDeMatriz);
                    cantMemoriagenet+=8;
                    asignacionGenetico += 2;//a 
                    comparacionGenetico++;//c
                    if (sePuede == true)
                    {
                        sePuede = verificarMatriz(padre, capacidadDeMatriz, mamaMat, copiaM);
                        asignacionGenetico++;//a
                        comparacionGenetico++;//c
                        if (sePuede == true)
                        {
                            return;
                        }
                    }

                    mama = madreCruce(mamaMat, mama, capacidadDeMatriz, maxCicloGenetico);
                    maxCicloGenetico = maxCicloGenetico + 1;                    
                    asignacionGenetico += 2;//a

                    }

                    comparacionGenetico += 2;//c
                    if (hijo1Apadre == 0 || hijo2Apadre == 0)
                    {
                    cantMemoriagenet += 32;
                    for (int i = 0; i < capacidadDeMatriz; i++)
                    {
                        cantMemoriagenet += 32;
                        comparacionGenetico++;//c
                        for (int j = 0; j < capacidadDeMatriz; j++)
                        {
                            comparacionGenetico++;//c
                            Console.WriteLine(mama[i, j] + "     " + padre[i, j]);
                        }
                        comparacionGenetico++;//c
                        asignacionGenetico++;//a
                    }
                    comparacionGenetico++;//c
                    asignacionGenetico++;//a
                    Console.ReadKey();
                    return;
                }

                hijo1.Clear();
                hijo2.Clear();
                mama2.Clear();
                papa.Clear();
                int division = padre.Length / 2;                
                int[,] hijo1Matriz = new int[capacidadDeMatriz, capacidadDeMatriz];
                int[,] hijo2Matriz = new int[capacidadDeMatriz, capacidadDeMatriz];                
                asignacionGenetico += 3;//a
                cantMemoriagenet += 32*2*hijo2Matriz.Length;
                cantMemoriagenet += 32*2;
                for (int i = 0; i < capacidadDeMatriz; i++)
                {
                    comparacionGenetico++;//c
                    cantMemoriagenet += 32;
                    for (int j = 0; j < capacidadDeMatriz; j++)
                    {
                        comparacionGenetico++;//c
                        mama2.Add(mama[i, j]);
                        papa.Add(padre[i, j]);
                    }
                    comparacionGenetico++;//c
                    asignacionGenetico++;//a
                }
                comparacionGenetico++;//c
                asignacionGenetico++;//a
                cantMemoriagenet += 32;
                for (int i = 0; i < padre.Length; i++)
                {
                    comparacionGenetico += 2;//c
                    if (i <= division)
                    {
                        hijo1.Add(mama2[i]);
                        hijo2.Add(papa[i]);
                    }
                    else
                    {   cantMemoriagenet += 32;
                        for (int p = 0; p < padre.Length; p++)
                        {
                            comparacionGenetico += 3;//c
                       
                            if (!hijo1.Contains(papa[p]))
                            {
                                hijo1.Add(papa[p]);
                            }
                            if (!hijo2.Contains(mama2[p]))
                            {
                                hijo2.Add(mama2[p]);
                            }
                        }
                        comparacionGenetico++;//c
                        asignacionGenetico++;//a
                    }
                }
                comparacionGenetico++;//c
                asignacionGenetico++;//a           
                int pos = 0;
                asignacionGenetico++;//a
                cantMemoriagenet += 32*2;
                for (int i = 0; i < capacidadDeMatriz; i++)
                {
                    comparacionGenetico++;//c
                    cantMemoriagenet += 32;
                    for (int j = 0; j < capacidadDeMatriz; j++)
                    {
                        comparacionGenetico++;//c
                        hijo1Matriz[i, j] = hijo1[pos];
                        hijo2Matriz[i, j] = hijo2[pos];
                        asignacionGenetico += 2;//a
                        pos++;
                    }
                }
                comparacionGenetico++;//c
                asignacionGenetico++;//a

                Console.WriteLine("\n\n\nImprimiendo Cruce:\n");
                Console.WriteLine("\nPapa   ");
                imprimirHtod(papa);
                Console.WriteLine("\n\nmama    ");
                imprimirHtod(mama2);
                Console.WriteLine("\n\nHijo1    ");
                imprimirHtod(hijo1);
                Console.WriteLine("\n\nHijo2    ");
                imprimirHtod(hijo2);
                Console.WriteLine("\n");
                movimientosGen += 2;
                hijo1Apadre = distanciaDeManhattan(hijo1Matriz, capacidadDeMatriz, mamaMat);
                hijo2Apadre = distanciaDeManhattan(hijo2Matriz, capacidadDeMatriz, mamaMat);
                asignacionGenetico += 2;//a
                comparacionGenetico++;                
                if (hijo1Apadre < hijo2Apadre)
                {
                    hijo2Apadre = distanciaDeManhattan(padre, capacidadDeMatriz, mamaMat);
                    asignacionGenetico++;//a
                    comparacionGenetico++;//c
                    if (hijo2Apadre >= hijo1Apadre)
                    {
                        padre = raiz.insertarEnCopia(capacidadDeMatriz, hijo1Matriz);
                        asignacionGenetico++;//a
                    }

                }
                else if (hijo2Apadre < hijo1Apadre)
                {

                    hijo1Apadre = distanciaDeManhattan(padre, capacidadDeMatriz, mamaMat);
                    asignacionGenetico++;// a
                    comparacionGenetico++;//c
                    if (hijo1Apadre >= hijo2Apadre)
                    {
                        asignacionGenetico++; //a
                        padre = raiz.insertarEnCopia(capacidadDeMatriz, hijo2Matriz);
                    }
                }
                comparacionGenetico++;//c
                ciclo = ciclo + 1;
                asignacionGenetico++;//a
                cruceGenetico(padre, capacidadDeMatriz, mamaMat, geneticoMadre, ciclo, copiaM);
            }

            ///.................................................. FIN GENETICO ..........................................

            static void GuardarEnArbol(int capacidadDeMatriz, int[,] matrizAInsertar, int[,] matrizGane)
            {
                if (listaDeArbolesGlobalBacktraking.Count == 0)
                {
                    raiz.setCapacidad(capacidadDeMatriz, matrizAInsertar, matrizGane);
                    listaDeArbolesGlobales.Add(raiz);
                    listaDeTodosLosElementos.Add(raiz);
                    return;
                }
                else
                {
                    listaDeArbolesGlobales.Clear();
                    GuardarEnArbol(capacidadDeMatriz, matrizAInsertar, matrizGane);
                }
            }


            static void Main(string[] args)
            {

            int capacidad = 3;
            llenarMatrices();
            comprobarMatrices();


            
            
           
            Console.WriteLine("\n\n***********************Matriz de 3x3*******************************\n\n");
            Console.WriteLine("_______VORAZ________\n\n");
            Console.ReadKey();
            Console.WriteLine("Matriz desordenada\n\n");
            imprimirMatriz(matrizTamaño1Voraz, 3);
            Console.WriteLine("\nPasos:");
            metodoVoraz(matrizTamaño1Voraz, 3, matrizObjetivo1Voraz, matrizCopia1Voraz);
            Console.WriteLine("\nMatriz ordenada\n\n");
            imprimirMatriz(matrizTamaño1Voraz, 3);
            Console.WriteLine("cantidad de movimientos: " + medicionCantidadDeMovimientosEfectuadosVoraz);
            medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 408;
            Console.WriteLine("cantidad de memoria (bits): " + medicionCantidadDeMemoriaConsumidaVoraz);
            medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 8;
            Console.WriteLine("cantidad de Asignaciones: " + medicionCantidadDeAsignacionesVoraz);
            Console.WriteLine("cantidad de Comparaciones: " + medicionCantidadDeComparacionesVoraz);
            Console.ReadLine();
            Console.ReadLine();



            Console.ReadKey();
            Console.WriteLine("\n\n***********************Matriz de 4x4*******************************\n\n");
            Console.WriteLine("_______VORAZ________\n\n");
            Console.ReadKey();
            Console.WriteLine("Matriz desordenada\n\n");
            imprimirMatriz(matrizTamaño2Voraz, 4);
            Console.WriteLine("\nPasos:");
            metodoVoraz(matrizTamaño2Voraz, 4, matrizObjetivo2Voraz, matrizCopia2Voraz);
            Console.WriteLine("\nMatriz ordenada\n\n");
            imprimirMatriz(matrizTamaño2Voraz, 4);
            Console.WriteLine("cantidad de movimientos: " + medicionCantidadDeMovimientosEfectuadosVoraz);
            medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 408;
            Console.WriteLine("cantidad de memoria (bits): " + medicionCantidadDeMemoriaConsumidaVoraz);
            medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 8;
            Console.WriteLine("cantidad de Asignaciones: " + medicionCantidadDeAsignacionesVoraz);
            Console.WriteLine("cantidad de Comparaciones: " + medicionCantidadDeComparacionesVoraz);
            Console.ReadLine();
            Console.ReadLine();




            Console.ReadKey();
            Console.WriteLine("\n\n***********************Matriz de 5x5*******************************\n\n");
            Console.WriteLine("_______VORAZ________\n\n");
            Console.ReadKey();
            Console.WriteLine("Matriz desordenada\n\n");
            imprimirMatriz(matrizTamaño3, 5);
            Console.WriteLine("\nPasos:");
            metodoVoraz(matrizTamaño3Voraz, 5, matrizObjetivo3Voraz, matrizCopia3Voraz);
            Console.WriteLine("\nMatriz ordenada\n\n");
            imprimirMatriz(matrizTamaño3, 5);
            Console.WriteLine("cantidad de movimientos: " + medicionCantidadDeMovimientosEfectuadosVoraz);
            medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 408;
            Console.WriteLine("cantidad de memoria (bits): " + medicionCantidadDeMemoriaConsumidaVoraz);
            medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 8;
            Console.WriteLine("cantidad de Asignaciones: " + medicionCantidadDeAsignacionesVoraz);
            Console.WriteLine("cantidad de Comparaciones: " + medicionCantidadDeComparacionesVoraz);
            Console.ReadLine();
            Console.ReadLine();




            Console.ReadKey();
            Console.WriteLine("\n\n***********************Matriz de 6x6*******************************\n\n");
            Console.WriteLine("_______VORAZ________\n\n");
            Console.ReadKey();
            Console.WriteLine("Matriz desordenada\n\n");
            imprimirMatriz(matrizTamaño4Voraz, 6);
            Console.WriteLine("\nPasos:");
            metodoVoraz(matrizTamaño4Voraz, 6, matrizObjetivo4Voraz, matrizCopia4Voraz);
            Console.WriteLine("\nMatriz ordenada\n\n");
            imprimirMatriz(matrizTamaño4Voraz, 6);
            Console.WriteLine("cantidad de movimientos: " + medicionCantidadDeMovimientosEfectuadosVoraz);
            medicionCantidadDeMemoriaConsumidaVoraz = medicionCantidadDeMemoriaConsumidaVoraz + 408;
            Console.WriteLine("cantidad de memoria (bits): " + medicionCantidadDeMemoriaConsumidaVoraz);
            medicionCantidadDeAsignacionesVoraz = medicionCantidadDeAsignacionesVoraz + 8;
            Console.WriteLine("cantidad de Asignaciones: " + medicionCantidadDeAsignacionesVoraz);
            Console.WriteLine("cantidad de Comparaciones: " + medicionCantidadDeComparacionesVoraz);
            Console.ReadLine();
            Console.ReadLine();
            

            // 3x3______________________________________________________________**
            ////////////////////////    RESOLVER    /////////////////////
            //
            Console.WriteLine("\n\n_______Backtraking________\n\n");
            listaDeTodosLosElementos.Clear();
            GuardarEnArbol(capacidad, matrizTamaño1, matrizObjetivo1);
            raiz.limpiarTodo();
            gn.Clear();
            contadorVecesGenetico = 0;
            maxCicloGenetico = 2;
            raiz.setProf(9);
            raiz.posibleSolucion(raiz, listaDeTodosLosElementos, matrizTamaño1, capacidad, 0);
            Console.WriteLine("\nCantidad de nodos de árbol......: " + listaDeTodosLosElementos.Count);
            raiz.imprimirContadoresEinf();
            Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("\n\n_______Genetico________\n\n");
            inicializaInfoGne();
            cruceGenetico(matrizTamaño1, capacidad, matrizObjetivo1, matrizTamaño1, 0, matrizCopia1);
            imprimirTodaLaInfo();
            Console.ReadLine();
            Console.ReadLine();


            /////////////////////////  FIN 3X3   ////////////////////////////////////////////////


            ///////////////////////  4x4 /////////////////////////////////////////////////////////////
            Console.WriteLine("\n\n***********************Matriz de 4x4*******************************\n\n");
            Console.WriteLine("\n\n_______Backtraking________\n\n");
            capacidad = 4;
            listaDeTodosLosElementos.Clear();
            GuardarEnArbol(capacidad, matrizTamaño2, matrizObjetivo2);
            raiz.limpiarTodo();
            gn.Clear();
            contadorVecesGenetico = 0;
            maxCicloGenetico = 2;
            raiz.setProf(9);
            raiz.posibleSolucion(raiz, listaDeTodosLosElementos, matrizTamaño2, capacidad, 0);
            Console.WriteLine("\nCantidad de nodos de árbol......: " + listaDeTodosLosElementos.Count);
            raiz.imprimirContadoresEinf();
            Console.ReadLine();
            Console.ReadLine();

            Console.WriteLine("\n\n***********************Matriz de 4x4*******************************\n\n");
            Console.WriteLine("\n\n_______Genetico________\n\n");
            inicializaInfoGne();
            cruceGenetico(matrizTamaño2, capacidad, matrizObjetivo2, matrizTamaño2, 0, matrizCopia2);
            imprimirTodaLaInfo();
            Console.ReadLine();
            Console.ReadLine();


            /////////////////////////   FIN 4X4   ///////////////////////////////////////////////////////

            /////////// 5x5
            Console.WriteLine("\n\n***********************Matriz de 5x5*******************************\n\n");
            Console.WriteLine("\n\n_______Backtraking________\n\n");
            capacidad = 5;
            listaDeTodosLosElementos.Clear();
            GuardarEnArbol(capacidad, matrizTamaño3, matrizObjetivo3);
            raiz.limpiarTodo();
            gn.Clear();
            contadorVecesGenetico = 0;
            maxCicloGenetico = 2;
            raiz.setProf(9);
            raiz.posibleSolucion(raiz, listaDeTodosLosElementos, matrizTamaño3, capacidad, 0);
            Console.WriteLine("\nCantidad de nodos de árbol......: " + listaDeTodosLosElementos.Count);
            raiz.imprimirContadoresEinf();


            Console.WriteLine("\n\n***********************Matriz de 5x5*******************************\n\n");
            Console.WriteLine("\n\n_______Genetico________\n\n");
            inicializaInfoGne();
            cruceGenetico(matrizTamaño3, capacidad, matrizObjetivo3, matrizTamaño3, 0, matrizCopia3);
            imprimirTodaLaInfo();
            Console.ReadLine();
            Console.ReadLine();





            Console.WriteLine("\n\n***********************Matriz de 6x6*******************************\n\n");
            Console.WriteLine("\n\n_______Backtraking________\n\n");
            capacidad = 6;
            listaDeTodosLosElementos.Clear();
            GuardarEnArbol(capacidad, matrizTamaño4, matrizObjetivo4);
            raiz.limpiarTodo();
            gn.Clear();
            contadorVecesGenetico = 0;
            maxCicloGenetico = 2;
            raiz.setProf(9);
            raiz.posibleSolucion(raiz, listaDeTodosLosElementos, matrizTamaño4, capacidad, 0);
            Console.WriteLine("\nCantidad de nodos de árbol......: " + listaDeTodosLosElementos.Count);
            raiz.imprimirContadoresEinf();


            Console.ReadLine();
            Console.ReadLine();
            Console.WriteLine("\n\n***********************Matriz de 6x6*******************************\n\n");
            Console.WriteLine("\n\n_______Genetico________\n\n");
            inicializaInfoGne();
            cruceGenetico(matrizTamaño4, capacidad, matrizObjetivo4, matrizTamaño4, 0, matrizCopia4);
            imprimirTodaLaInfo();
            Console.ReadLine();

        }
    }
    }
