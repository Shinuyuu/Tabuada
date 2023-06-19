using System;

namespace Tabuada
{
    class Program
    {
        
        static void Main(string[] args)
        {
            void Shin(string frase, int fun)
{
    if (fun == 00)
    {
        Console.ForegroundColor = ConsoleColor.DarkMagenta;
    }
    else if (fun == 01)
    {
        Console.ForegroundColor = ConsoleColor.Cyan;
    }
        else if (fun == 02)
    {
        Console.ForegroundColor = ConsoleColor.DarkBlue;
    }
for (int i = 00; i < frase.Length; i++)
{
Console.Write(frase[i]);
Thread.Sleep(45);
}
}
            int contador,numero,tabuada;
            contador = 0;
            Console.Clear();
            Shin("coloque o numero que voce deseja multipicar:",01);
            Console.ForegroundColor = ConsoleColor.White;
            numero = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
             Shin("Pressione qualquer tecla para ver o Resultado",01);
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("<============Tabuada============>");

            while(contador <= 10)

            {
                tabuada = numero * contador;
                Console.WriteLine($"{numero} x {contador} = {tabuada}");
                contador = contador +1;

            }
                            Console.WriteLine("==========================");
        }

    }
}
