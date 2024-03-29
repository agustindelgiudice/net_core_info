﻿//C# VS JAVASCRIPT

//using System;
//using System.Net.Http;
//using System.Threading.Tasks;

//namespace test
//{
//    class Program
//    {
//        static void Main(string[] args)
//        //c sharp define una variable con la palabra var pero define su definicion y tipo a la derecha
//        {   //con el dynamic podemos ponerlo en modo JS al comportamiento de las variables
//            dynamic some = new string("");
//            some = "Agustin";
//            some = 1;
//            some = "Daniel";

//            Console.WriteLine(some);
//        }
//    }
//}
//-------------------------------------------------------------------------------------------//


//SOLICITUDES HTTP EN C SHARP ->

//Al agregar la palabra TASK, estariamos trabajando asincronicamente

//Para agregar el namespace adecuando hacer click derecho, acciones rapidas y refactorizaciones.


//using System.Net.Http;
//using System.Threading.Tasks;
//using System;

//namespace test
//{
//    class Program
//    {
//        static async Task Main(string[] args)
//        {
//            var url = "https://jsonplaceholder.typicode.com/todos/1";

//            var httpClient = new HttpClient();
//            var response = await httpClient.GetAsync(url);
//            string json = await response.Content.ReadAsStringAsync();
//            Console.WriteLine(json);
//        }
//    }
//}


//-------------------------------------------------------------------------------------------//


//using System;

//namespace net_core_prueba
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //palabra reservada para iniciar variable int de tipo entero
//            //podemos colocarle cualquier nombre, el ejemplo es (year)
//            //
//            int year = 10; //variable de tipo entero
//            Console.WriteLine("Hello World!" + ' ' + year);
//            Console.ReadLine();
//        }
//    }
//}

//-------------------------------------------------------------------------------------------//


//FUNCIONES FLECHA


//using System;
//using System.Collections.Generic;
//using System.Net.Http;
//using System.Threading.Tasks;

//namespace test
//{
//    class Program
//    {
//        static async Task Main(string[] args)
//        {
//            var numbers = new List<int> { 1, 2, 4, 5, 6 };

//            numbers.ForEach((n) => Console.WriteLine(n));
//        }
//    }
//}

//-------------------------------------------------------------------------------------------//



//using System;

//namespace net_core_prueba
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            //Variables de tipo string, float, double, decimal, int

//            //despues de la cadena de texto, la variable que se asigne, va a empezar desde la posicion cero

//            int year = Convert.ToInt16("20"); //dato de tipo entero se convierte a 12
//            double doble = 2.5;
//            string nombre = "Agustin"; //variable para crear una variable tipo cadena de texto
//            String nombres = "Alex Joel";
//            decimal decimals = 2.07M;
//            float flotante = 8.0F;
//            bool valor = true;
//            char letra = 'A'; //Almacena solo un caracter //con comillas dobles nos daria error porque solo para datos de tipo string o cadena de texto podemos usar el char
//            Decimal de = 28.6M;
//            Boolean valor2 = false;

//            Console.WriteLine(nombres + " {0} {1} {2}", year, letra, valor2);

//            Console.ReadLine();
//        }


//        //float 7 digitos 32 bits
//        //double 15-16 digitos 64 bits
//        //decimal 28-29 digitos 128 bits
//    }
//}
//-------------------------------------------------------------------------------------------//



//OPERADORES ARITMÉTICOS


//using System;

//namespace net_core_prueba
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            int valor1 = 3;
//            int valor2 = 6;
//            int suma = valor2 * valor1;
//            Console.WriteLine(" {0}", suma);
//            Console.ReadLine();
//        }


//        //float 7 digitos 32 bits
//        //double 15-16 digitos 64 bits
//        //decimal 28-29 digitos 128 bits
//    }
//}



//-------------------------------------------------------------------------------------------//
/*
LO QUE HARÁ EL OPERADOR DE INCREMENTO SERÁ TOMAR LO QUE ESTÁ EN LA VARIABLE valor2 = 6 LO VA A SUMAR CON EL DATO YA ALMACENADO EN LA VARIABLE valor1,
Y ESE DATO DE ESA SUMA SE LO VA A ASIGNAR NUEVAMENTE A LA VARIALBE VALOR 1, PARA PODER ALMACENAR ESE RESULTADO EN LA VARIABLE valor1, POR ESTE MOTIVO
CONTIENE PRIMERO EL OPERADOR +, PARA PODER REALIZAR ESA SUMA Y LUEGO EL DE ASIGNACIÓN, PARA ASIGNARLE ESE DATO A LA VARIALBE QUE ESTÁ A LA IZQUIERDA
*/

//using System;

//namespace net_core_prueba
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            int valor1 = 3;
//            int valor2 = 6;
//            var data = valor1 <= valor2;
//            Console.WriteLine(" Resultado {0}", data);
//            string v = Console.ReadLine();
//        }

//        //float 7 digitos 32 bits
//        //double 15-16 digitos 64 bits
//        //decimal 28-29 digitos 128 bits
//    }
//}


//-------------------------------------------------------------------------------------------//

//OPERADORES DE IGUALDAD == != 


//using System;

//namespace net_core_prueba
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            int valor1 = 6;
//            int valor2 = 6;
//            bool data = valor1 != valor2;
//            Console.WriteLine(" Resultado {0}", data);
//            Console.ReadLine();
//        }

//    }
//}



//-------------------------------------------------------------------------------------------//


//ESTRUCTURA IF Y LOS OPERADORES CONDICIONALES && || 

//using System;

//namespace net_core_prueba
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            int valor1 = 9;
//            int valor2 = 8;
//            double valor3 = 10;
//            double valor4 = 11;
//            bool data = valor1 != valor2;

//            //Esta estructura solo evalúa los datos, el dato verdadero y el dato falso
//            /*Si nosotros colocamos el valor true dentro de los parentesis de esta condición
//            esto significa que vamos a ejecutar todo lo que se coloque dentro de las llaves.
//            */
//            La diferencia entre el or || y el and && 

//            if (valor1 != valor2 || valor3 == valor4)
//            {
//                Console.WriteLine(" Resultado {0}", "Se cumplió la condición");
//            }
//            else
//            {

//                Console.WriteLine("Resultado {0}", "No se cumplió la condición");
//            }


//            Console.ReadLine();

//        }



//    }
//}






//-------------------------------------------------------------------------------------------//


//ESTRUCTURAS CONDICIONALES ANIDADAS


//using System;

//namespace net_core_prueba
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            int valor1 = 9;
//            int valor2 = 8;
//            double valor3 = 10;
//            double valor4 = 11;
//            bool data = valor1 != valor2;



//            if (data)
//            {
//                if(valor3 == valor4)
//                {
//                    Console.WriteLine("Resultado {0}", "La comparación devolvió un valor");
//                }
//                else
//                {
//                    Console.WriteLine("Resultado {0}", "La comparación devolvió un valor");
//                }
//                Console.WriteLine(" Resultado {0}", "Se cumplió la condición");
//            }
//            else
//            {

//                Console.WriteLine("Resultado {0}", data);
//            }


//            Console.ReadLine();

//        }



//    }
//}



//-------------------------------------------------------------------------------------------//


//OPERADOR CONDICIONAL


//using System;

//namespace net_core_prueba
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            int valor1 = 9;
//            int valor2 = 9;
//            double valor3 = 11;
//            double valor4 = 11;
//            string name;
//            bool data = valor1 != valor2;



//            //if (data)
//            // {
//            //     name = "Agustin";
//            // }
//            // else
//            // {

//            //     name = "Francisco";
//            // }


//            /*Este operador solo lo podremos utilizar cuando haremos un procedimiento como la estructura de arriba
//            Pero si vamos a utilizar una estructura para poder ejecutar mas lineas de código, no lo va a permitir.
//            */
//            //Este operador solo funciona con esta estructura, para asignarle datos a una variable.

//            //Operador que nos ayuda a simplificar la condicional.

//            name = data ? "Agustin" : "Joel";
//                Console.WriteLine("Resultado {0}", name);



//                Console.ReadLine();
//            }


//        }



//}


//-------------------------------------------------------------------------------------------//


//ARRAY DE TIPO STRING

//using System;

//namespace net_core_prueba
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            string[] cadenas = new string[5];
//            cadenas[0] = "Agustin";
//            cadenas[1] = "Nacho";
//            cadenas[2] = "Nico";
//            cadenas[3] = "Jose";
//            cadenas[4] = "Joni";
//            cadenas[5] = "Fulano";
//            //Podemos obtener datos de la forma anterior y
//            //podemos crear otro arreglo de esta forma
//            string[] name = { "Agustin", "Nacho", "Nico", "Jose", "Joni", "Fulano" };

//            Console.WriteLine("Resultado {0}", cadenas[0] +" "+ name[3]);

//            Console.ReadLine();


//        }


//    }



//}


//-------------------------------------------------------------------------------------------//


//ARRAY DE TIPO INT

//using System;

//namespace net_core_prueba
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            string[] cadenas = new string[5];
//            cadenas[0] = "Agustin";
//            cadenas[1] = "Nacho";
//            cadenas[2] = "Nico";
//            cadenas[3] = "Jose";
//            cadenas[4] = "Joni";
//            cadenas[5] = "Fulano";
//            /*
//            Podemos obtener datos de la forma anterior y
//            podemos crear otro arreglo de esta forma
//            */
//            string[] name = { "Agustin", "Nacho", "Nico", "Jose", "Joni", "Fulano" };
//            int[] age = new int[5];
//            age[0] = 5;
//            age[1] = 15;
//            age[2] = 50;
//            age[3] = 55;
//            age[4] = 95;
//            int[] ages = { 8, 9, 56, 14, 5 };

//            Console.WriteLine("Resultado {0}", cadenas[0] +" "+ name[3]+" age "+age[2]);

//            Console.ReadLine();


//        }


//    }



//}




//-------------------------------------------------------------------------------------------//


//ARREGLOS MULTIDIMENSIONALES


//using System;

//namespace net_core_prueba
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            //La coma significa que vamos a crear columnas y filas
//            //Le indicamos al array que va a crear 2 filas y 2 columnas.
//            //Dentro de las llaves creamos las filas y las columnas.
//            //Para poder crear las filas nuevamente colocamos las llaves.
//            //Dentro de las llaves creamos las columnas que va a contener datos double y de tipo entero.
//            //tenemos el 6, el primer dato de tipo entero.
//            //3.0 dato double.
//            //De esta forma ya tendriamos creado el array multidimensional.

//            //ARRAY BIDIMENSIONAL
//            double[,] doble2 = new double[2, 2] { { 6, 3.0 }, { 6.3, 5.6 } }; //En el primer corchete, espeficicar cuantas filas hay.
//            //Console.WriteLine("Resultado {0}", doble2[2, 1]); //Al ser multidimensionales, tenemos que especificarle de donde queremos obtener datos.
//                                                              //Aquí le estamos espeficiando que queremos obtener datos de la fila numero 1, en la posicion 0.





//            //ARRAY TRIDIMENSIONAL //Donde vamos a crear [2, 2,3] dos filas, dos columnas y en esas columnas podremos almacenar 3 datos.
//            double[,,] doble3 = new double[2, 2, 3] { { {3.0,6.9,8.9 },{6.8,4.5,7.6 } },{ { 1.0, 2.9, 5.9 }, { 3.8, 3.5, 9.6 } } } ; // { {1 fila} }    { { {la columna } } }
//            Console.WriteLine("Resultado {0}", doble3[0, 1,2]);

//            Console.ReadLine();


//        }


//    }



//}

//-------------------------------------------------------------------------------------------//
//BUCLE CICLO FOR


//using System;

//namespace net_core_prueba
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            for (int i = 10; i > 0; i--)// con el i-- estamos decrementando
//            {
//                Console.WriteLine("Resultado {0}", i);


//            }


//            Console.ReadLine();


//        }


//    }



//}






//-------------------------------------------------------------------------------------------//

//LA ESTRUCTURA Bucle ciclo Foreach
/*
 
*/

//using System;

//namespace net_core_prueba
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            string[] name = { "Agu", "Fran", "Nacho" };
//            int[] age = { 52, 42, 65 };
//            //for (int i = 0; i < name.Length; i++) 
//            //{
//            //    Console.WriteLine("Resultado {0}", name[i] + "age" + age[i] );


//            //}

//            /*Estructura que tambien podemos obtener informacion en una coleccion de datos
//             se ha creado este objeto con la palabra var para poder indicar que es un objeto que va a
//            poder recibir cualquier tipo de dato, porque este objeto se va a definir cuando se le asigne un respectivo dato
//            bien sea un dato de tipo string o un dato de tipo entero o cualquier otro tipo de dato*/
//            //La palabra in que con esta palabra estamos indicando que vamos a obtener datos de una coleccion de datos.
//            //La palabra name significa que vamos a poder obtener datos del array name con los nombres indicados.

//            foreach (var item in name) //Este forEach es mas reducido, su sintaxis es mas adecuada para obtener informacion de una coleccion de datos.
//            {
//                Console.WriteLine("Resultado {0}", item);

//            }

//            Console.ReadLine();


//        }


//    }



//}

//-------------------------------------------------------------------------------------------//
////TRIANGULO DE PASCAL /EJERCICIO CON TODO LO QUE VENIMOS VIENDO
//////Mettdos que podemos utilizar
//using System;

//namespace net_core_prueba
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            int pisos = 0;
//            int[] arreglo = new int[1];
//            //Mostramos un mensaje y capturalos el dalo ingresado desde la consola
//            Console.WriteLine("Ingrese el numero de pisos");
//            pisos = Convert.ToInt16(Console.ReadLine());
//            /*Declaramos el primer ciclo for que va a recorrer dependiendo el dato ingresado que está almacenado
//             en la variable pisos*/
//            for (int i = 1; i <= pisos; i++)
//            {
//                /*Creamos otro arreglo dentro del ciclo for, y este arreglo se llamará PASCAL*/
//                /*Colocamos un arreglo y colocamos la variable i del ciclo for que será el tamaño que tendrá el arreglo cada vez
//                 que el ciclo for se ejecute.*/
//                int[] pascal = new int[i]; //de tipo entero
//                                           //Ciclo for que se decrementa para formar el triangulo
//                for (int j = pisos; j < i; j--)
//                {
//                    Console.Write(" ");

//                }
//                for (int k = 0; k < i; k++)
//                {

//                    //Condicion que evalua la variable del ciclo for
//                    if (k == 0 || k == (i - 1))
//                    {
//                        pascal[k] = 1;
//                    }
//                    else
//                    {
//                        //Sumamos los numeros que están en cada posicion del arreglo para formar el triangulo
//                        pascal[k] = arreglo[k] + arreglo[k - 1];
//                    }
//                    Console.WriteLine("[" + pascal[k] + "]");

//                }
//                arreglo = pascal;
//            }


//        }


//    }



//}

//-------------------------------------------------------------------------------------------//
//Introducción de selección switch

//using System;

//namespace net_core_prueba
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            var data = 5;

//            switch (data)
//            {
//                case "Agustin":
//                    Console.WriteLine("Agu {0}", data);
//                    break; 
//                case "Alex":
//                    Console.WriteLine("Del {0}", data);
//                    break;


//                default:
//                    Console.WriteLine("Case {0}", "default");
//                    break;
//            }


//            Console.ReadLine();


//        }


//    }



//}

//-------------------------------------------------------------------------------------------//

////SWITCH EXPRESSIONS #1

//using System;

//namespace net_core_prueba
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            var data = 3;
//            var result = data switch
//            {
//                1 => "Alex", //Lo que hará esta linea es retornar el dato que está a la derecha.
//                2 => "Joel", //Si colocamos el mismo dato de arriba, nos va a marcar error, tiene que ser un dato distintoç
//                3 => "Agustin"
//            };

//            Console.WriteLine(result);
//            Console.ReadLine();


//        }


//    }




//}

//-------------------------------------------------------------------------------------------//

//SWITCH EXPRESSIONS #1

//using System;

//namespace net_core_prueba
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            var data = 3;
//            var result = data switch
//            {
//                1 => "Alex", //Lo que hará esta linea es retornar el dato que está a la derecha.
//                2 => "Joel", //Si colocamos el mismo dato de arriba, nos va a marcar error, tiene que ser un dato distintoç
//                3 => "Agustin"
//            };

//            Console.WriteLine(result);
//            Console.ReadLine();


//        }

//    }




//}


//-------------------------------------------------------------------------------------------//

//SWITCH EXPRESSIONS #2




//using System;

//namespace net_core_prueba
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {


//            var (a, b, opcion)
// = (2, 6, "-");
//            var result = opcion switch
//            {
//                "+" => a == b,
//                "-" => a < b,
//                "*" => b > a
//            };
//            Console.WriteLine(result);
//            Console.ReadLine();


//        }

//    }




//}


//-------------------------------------------------------------------------------------------//


//LA ESTRUCTURA WHILE

/*En esta estructura lo que hay son dos variables, una con un valor booleano y otra con un valor de 1, 
 cuando la ejecucion de nuestra aplicacion llegue a la siguiente linea de codigo, el dato que esté almacenado en la variable count se va a
incrementar en 1 hasta que llegue a 6.
 */

//using System;

//namespace net_core_prueba
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {

//            var valor = true;
//            var count = 1; //variable de tipo entero, la utilizamos para llevar un conteo
//            while(valor)
//            {
//                if(count == 6 ) //hasta que llegue a 6, se va a ejecutar todo lo que esté dentro de las llaves.
//                {
//                    valor = false;
//                }
//                count++;
//                Console.WriteLine("Ejecución {0}", count);

//            }

//            Console.WriteLine(valor);
//            Console.ReadLine();


//        }

//    }




//}

//-------------------------------------------------------------------------------------------//

//ESTRUCTURA DO WHILE


using System;

namespace net_core_prueba
{
    class Program
    {
        static void Main(string[] args)
        {

            var valor = true;
            var count = 1;
            while (valor)
            {
                if (count == 6)
                {
                    valor = false;
                }
                count++;
                Console.WriteLine("Ejecución del while {0}", count);

            }

            Console.WriteLine(valor);
            Console.ReadLine();


        } //Esta estructura practicamente es identica a la siguiente estructura
        do {

} while (true);

    }




}

//-------------------------------------------------------------------------------------------//

//-------------------------------------------------------------------------------------------//

//-------------------------------------------------------------------------------------------//

//-------------------------------------------------------------------------------------------//

//-------------------------------------------------------------------------------------------//

//-------------------------------------------------------------------------------------------//

//-------------------------------------------------------------------------------------------//

//-------------------------------------------------------------------------------------------//

//-------------------------------------------------------------------------------------------//

//-------------------------------------------------------------------------------------------//

//-------------------------------------------------------------------------------------------//

//-------------------------------------------------------------------------------------------//

//-------------------------------------------------------------------------------------------//

//-------------------------------------------------------------------------------------------//

//-------------------------------------------------------------------------------------------//

//-------------------------------------------------------------------------------------------//

//-------------------------------------------------------------------------------------------//

//-------------------------------------------------------------------------------------------//



