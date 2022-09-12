using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Curso_C_Sharp
{
    class Program
    {
        static void Main(string[] args)
        {

            /*

            ACLARACIONES:
            // --> muestra en consola

            CTRL K C PARA COMENTAR

            CTRL K U PARA DESCOMENTAR

            CTRL K D PARA IDENTAR EL CODIGO (NO IDENTA COMMENTS)

            Console.WriteLine("Frase");

            Console.ReadLine(); --> usar esto para que la consola lea la linea ingresada. Tambien convierte un dato a string al asignarle esta linea.

            Console.ReadKey(); --> usar esto para que la consola espere el ingreso de una tecla y cierre la consola


            Variables:

            int = 155, -155, 23523523534534534524(cualquier num)

            double = flotantes como 25,52

            byte = 0 a 255 (se usa en edades por ej)

            char = 'C'(una sola letra)

            string = "sirve para una cadena de texto"

            bool = true / false

            dynamic = detecta el tipo de dato automaticamente(no recomendable)

            ---------------------------------- 

            operadores de asignacion

            byte = 20

            byte += 10 // 30

            byte -= 10 // 10

            byte += 10 // 200

            byte /= 10 // 2


            ----------------------------------

            operadores aritmeticos

            int num = 6, num2 = 5

            Console.WriteLine("El resultado de la suma es: " + (num1 + num2)); // 11 (repetir con los demas operadores)

            Console.ReadLine();



           COMO HACER POTENCIAS:


            double num, pot, resultado;

            Console.WriteLine("Digite el numero que quiere elevar");
            num = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite a la potencia que quiere elevar:");
            pot = Convert.ToDouble(Console.ReadLine());

            resultado = Math.Pow(num, pot);

            Console.WriteLine("El resultado es: " + resultado);

            Console.ReadKey();

           COMO HACER RAIZ CUADRADA:

            Console.WriteLine("La raíz cuadrada de 49 es: " + Math.Sqrt(49));

            Console.ReadKey();

            
           ---------TIPOS DE OPERADORES RELACIONALES-----

           ---- EJERCICIO 1 -----

            double peso;

            Console.WriteLine("Digita tu peso:");
            peso = Convert.ToDouble(Console.ReadLine()); // ACA VUELVE A CONVERTIR A DOUBLE PORQUE READLINE LEE LA LINEA PERO EN FORMA DE STRING, POR LO QUE HAY QUE PASARLA DE NUEVO A DOUBLE. FUNCIONA IGUAL CON LOS DEMAS TIPOS DE VARIABLES.

            if (peso <= 80)
            {
                Console.WriteLine("Tu peso es normal");

            }
            else
            {
                Console.WriteLine("Tenés sobrepeso");
            }
            Console.ReadKey();
   

            ---- EJERCICIO 2 -----
            
            double peso;
            byte edad;

            Console.WriteLine("Digita tu peso:");
            peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digita tu edad:");
            edad = Convert.ToByte(Console.ReadLine());

            if (peso > 100 && edad >= 15) // OPERADOR AND
            {
                Console.WriteLine("Tu peso es normal.");
            }

            if (peso > 100 || edad >= 15) // OPERADOR OR
            {
                Console.WriteLine("Tu peso es normal.");
            }

            Console.ReadLine();


            // ----- ESTRUCTURA IF ELSE ---------

            byte juan, pedro, jorge;

            Console.WriteLine("Que edad tiene Juan?");
            juan = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Que edad tiene Pedro?");
            pedro = Convert.ToByte(Console.ReadLine());

            Console.WriteLine("Que edad tiene Jorge?");
            jorge = Convert.ToByte(Console.ReadLine());

            if (juan > pedro && juan > jorge)
            {
                Console.WriteLine("Juan es mayor que Pedro y Jorge");
            }
            else if (juan < pedro && juan < jorge)
            {
                Console.WriteLine("Juan es menor que Pedro y Jorge");
            }
            else if (juan > pedro && juan < jorge)
            {
                Console.WriteLine("Juan es mayor que pedro pero menor que Jorge");
            }
            else if (juan < pedro && juan > jorge)
            {
                Console.WriteLine("Juan es menor que pedro y mayor que Jorge");
            }


            // Ejemplo 2 if anidado (no valida si pedro es mayor q todos)

            if (juan > pedro)
            {
                if (jorge > juan)
                {
                    Console.WriteLine("Jorge es el mayor de todos");
                }
            }

            Console.ReadKey();


           // ----------- TRY CATCH -----------

            double precio, total;
            int cantidad;

            try
            {
                Console.WriteLine("Cantidad: ");
                cantidad = Convert.ToInt16(Console.ReadLine());

                Console.WriteLine("Precio: ");
                precio = Convert.ToInt16(Console.ReadLine());

                total = cantidad * precio;

                Console.WriteLine("El total es: " + total);

            }
            catch(Exception error) // Exception es una palabra reservada para declarar errores
            {
                Console.WriteLine("Ha ocurrido un error: " + error.Message);
            }

           
            Console.ReadKey();


            
            // ------ SWITCH CASE ---------

            
            Console.WriteLine("Dame un día: ");
            string dia = Console.ReadLine();
  

            switch(dia)
            {
                case "lunes": Console.WriteLine("Haz elegido el lunes"); break;
                case "martes": Console.WriteLine("Haz elegido el martes"); break;
                case "miercoles": Console.WriteLine("Haz elegido el miercoles"); break;
                case "jueves": Console.WriteLine("Haz elegido el jueves"); break;
                case "viernes": Console.WriteLine("Haz elegido el viernes"); break;
                case "sabado": Console.WriteLine("Haz elegido el sabado"); break;
                case "domingo": Console.WriteLine("Haz elegido el domingo"); break;
                default: Console.WriteLine("No es un dia"); break;
                   
            }

            Console.ReadKey();

             // ----------- FOR Y FOR EACH -------------

            //for (int x = 1; x <= 5; x++)
            //{
            //    Console.WriteLine(x);
            //}


            //string nombre = "inftcurso";

            //foreach(char letra in nombre)
            //{
            //    Console.Write(letra + " ");
            //}

            //Console.ReadKey(); 

                // ------- BREAK, CONTINUE y GO TO ----------


            // BREAK ES FACIL Y DIRECTAMENTE CORTA LA EJECUCION
        

            // CONTINUE
            //for (int id = 1; id <= 10; id++)
            //{
            //    Thread.Sleep(800);
                
            //    if (id == 8)
            //    {
            //        continue; // primero entra en el if, si no coincide con 8 pasa al WriteLine de abajo. Si es 8, el programa lo saltea y continua con el WriteLine.
            //    }

            //    Console.WriteLine(id);
            //}

            // GO TO
            //for (int id = 1; id <= 10; id++)
            //{
            //    Thread.Sleep(800);

            //    if (id == 8)
            //    {
            //        goto liquidacion; // entra en el go to y corta la ejecucion
            //    }

            //    Console.WriteLine(id);
            //}

            //liquidacion:
            //Console.WriteLine("Se envio al departamento de contabilidad...");


            //Console.ReadKey();

         */



          





        }
    }
}


