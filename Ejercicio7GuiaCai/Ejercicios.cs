using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio7GuiaCai
{
    class Ejercicios
    {
        public void ej39()
        {
            //39.Solicite el ingreso de una serie de números al usuario y los presente en orden inverso.
            int[] arraynumeros = new int[5];
            int cont;
            for(cont= 0; cont < 5; cont++)
            {
                Console.WriteLine("Ingrese un numero: ");
                int numero = Convert.ToInt32(Console.ReadLine());                
                arraynumeros[cont] = numero;                
            }

            Array.Reverse(arraynumeros);

            for (int i = 0; i < arraynumeros.Length; i++)
            {
                Console.WriteLine(arraynumeros[i]);
            }
        }

        public void ej40()
        {
            //40. Solicite el ingreso de una frase al usuario y presente cada palabra en una línea por separado.

        }

        public void ej41()
        {
                      
                //Solicite el ingreso de una serie de fechas al usuario y las presente ordenadas en forma ascendente.
                DateTime[] arrayfechas = new DateTime[3];
                int cont;
                for (cont = 0; cont < arrayfechas.Length; cont++)
                {
                    Console.WriteLine("Ingrese una fecha: ");
                    DateTime fecha = Convert.ToDateTime((Console.ReadLine()));
                    arrayfechas[cont] = fecha;
                }

                Array.Sort(arrayfechas);

                for (int i = 0; i < arrayfechas.Length; i++)
                {
                    Console.WriteLine(arrayfechas[i].ToLongDateString());
                }            

        }

        public void ej42()
        {
            //42. Solicite el ingreso de una palabra al usuario y la presente escrita al revés.
            Console.WriteLine("Ingrese una palabra: ");
            string palabra = Console.ReadLine();            

            for (int i = 0; i < palabra.Length; i++)
            {
                Console.Write(palabra[palabra.Length - i - 1]);
            }
            
        }

        public void ej43()
        {
            //43. Solicite el ingreso de una serie de números hasta que el usuario ingrese -1.
            //Luego presentar: el máximo, el mínimo,el promedio, la suma.
            //Realizar todos los cálculos una vez finalizado el ingreso.
            
            List<int> listadenumeros = new List<int>();
            while (true)
            {
                Console.WriteLine("ingrese un numero: ");
                int numero = Convert.ToInt32(Console.ReadLine());
                if (numero != -1)
                {
                    listadenumeros.Add(numero);
                }
                if(numero == -1)
                {
                    break;
                }
            }
            Console.WriteLine(listadenumeros.Max());
            Console.WriteLine(listadenumeros.Min());
            Console.WriteLine(listadenumeros.Sum()/listadenumeros.Count());
            Console.WriteLine(listadenumeros.Sum());      
                         
            

        }

        public void ej44()
        {
            //44. Realizar una aplicación que mantenga una lista de nombres.
            //La aplicación debe interpretar los siguientes “comandos”,
            //que el usuario ingresará hasta finalizar. Si el usuario ingresa…
            //a. “alta[nombre]”, se insertará la cadena a la lista(ej.: “alta Pedro”).
            //b. “baja[número entero]”, se eliminará la cadena en la posición indicada por el número ingresado.
            //Debe presentar un mensaje de error si el número está fuera del rango de la lista.
            //c. “baja[nombre]”, se eliminará la cadena de la lista.
            //Debe presentar un mensaje de error si la cadena no existe.
            //d. “mostrar”, mostrará las entradas de la lista, una por línea.
            //e. “fin”, finalizará el programa.
            //f.Cualquier otro ingreso indicará “comando inválido” y continuará.
            List<string>listadenombres = new List<string>();
            while (true)
            {
                
                Console.WriteLine("ingrese comandos: ");
                Console.ReadLine();
                if(Console.ReadLine() == "alta")
                {
                    altanombres();
                }

            }

        }

        public void altanombres()
        {

        }


        /*
        











45. Realizar una aplicación que solicite el ingreso de una serie de números de registro y nombres de alumno, hasta que el usuario ingrese el registro “0”. Luego, solicitará el ingreso de un número de registro y presentará (de existir) el nombre asociado, repitiendo hasta que el usuario ingrese “0” como número de registro.

46. Realizar una aplicación que:

a. Permita ingresar y almacenar una lista de productos. La lista se compone de código de producto y precio.

b. Permita ingresar y almacenar una lista de precios. La lista se compone de código de producto y precio. El ingreso finalizará cuando el usuario ingrese “0” como precio.

c. Permita ingresar una serie de productos (hasta que el usuario ingrese “0”) y presente el monto total de acuerdo a los ingresos anteriores.
        */
    }
}
