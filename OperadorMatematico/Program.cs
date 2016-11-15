using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperadorMatematico
{
    class Program
    {
        static void Main(string[] args)
        {
            double primerNumero, segundoNumero, var;
            string nombreUsuario;
            Console.WriteLine("Escribe tu nombre:");
            nombreUsuario = Console.ReadLine();
            Console.WriteLine($"Hola {nombreUsuario}");//$ y " { } " añade una variable
            Console.WriteLine("Introduce un número:");
            primerNumero=Convert.ToDouble(Console.ReadLine());//convierte string en double
            Console.WriteLine("Introduce otro número:");
            segundoNumero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"La suma de {primerNumero} y {segundoNumero} es "+$"{primerNumero+segundoNumero}.");
            Console.WriteLine($"La resta de {primerNumero} y {segundoNumero} es " + $"{primerNumero - segundoNumero}.");
            Console.WriteLine($"La multiplicación de {primerNumero} y {segundoNumero} es " + $"{primerNumero * segundoNumero}.");
            Console.WriteLine($"La división de {primerNumero} y {segundoNumero} es " + $"{primerNumero / segundoNumero}.");
            Console.WriteLine($"El resto de la división de {primerNumero} y {segundoNumero} es " + $"{primerNumero % segundoNumero}.");
            Console.WriteLine("\nIncrementos y decrementos");
            Console.WriteLine($"Operador ++ delante, suma 1 unidad. ++primerNumero es " + $"{++primerNumero}.");
            Console.WriteLine($"Operador -- delante, resta 1 unidad. --primerNumero es " + $"{--primerNumero}.");
            Console.WriteLine($"Operador ++ detrás, suma 1 unidad depués de asignar. primerNumero es " + $"{var=primerNumero++}, valor de var {var}, valor de primerNumero {primerNumero}");
            Console.WriteLine($"Operador -- detrás, resta 1 unidad depués de asignar. primerNumero es " + $"{var = primerNumero--}, valor de var {var}, valor de primerNumero {primerNumero}");
            Console.WriteLine("\nAsignaciones, recuerda que se actualiza primerNumero.");
            Console.WriteLine($"primerNumero += segundoNumero, suma ambos y lo guarda en primerNumero: {primerNumero += segundoNumero}");
            Console.WriteLine($"primerNumero -= segundoNumero, resta ambos y lo guarda en primerNumero: {primerNumero -= segundoNumero}");
            Console.WriteLine($"primerNumero *= segundoNumero, multiplica ambos y lo guarda en primerNumero: {primerNumero *= segundoNumero}");
            Console.WriteLine($"primerNumero /= segundoNumero, divide ambos y lo guarda en primerNumero: {primerNumero /= segundoNumero}");
           
            Console.ReadKey();

        }
    }
}
