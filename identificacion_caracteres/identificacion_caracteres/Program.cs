using System;

namespace identificacion_caracteres
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese el caracter a evaluar: ");
            char dato = char.Parse(Console.ReadLine());
            //char dato2 = dato;
            //string dato3 = dato;

            if (dato >= 'a' && dato <= 'z')
            {
                Console.WriteLine("El caracter es letra minuscula");
            }
            else
            {
                //
                if (dato >= 'A' && dato <= 'Z')
                {
                    Console.WriteLine("El caracter es letra mayuscula");
                }
                else
                {
                    if (dato >= '0' && dato <= '9')
                    {
                        Console.WriteLine("El caracter es numerico");
                    }
                    else
                    {
                        Console.WriteLine("Es caracter");
                    }
                    
                }
            }
           
        }
    }
}
