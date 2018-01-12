using System;
using bll;

namespace LucasConsole2LP2av1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            String Nome, SobreNome;
            double Altura, Peso;

            Console.WriteLine("Insira o seu Primeiro Nome");
            Nome = Console.ReadLine();
            Console.WriteLine("Insira o seu SobreNome");
            SobreNome = Console.ReadLine();
            Console.WriteLine("Insira a sua Altura");
            Altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insira o seu Peso");
            Peso = Convert.ToDouble(Console.ReadLine());

            Individuo i1 = new Individuo(Nome, SobreNome, Peso, Altura);

            if (i1.Imc() < 17)
                Console.WriteLine(String.Format("senhor(a){0}{1} o seu imc está {2} portanto o senhor(a) se encontra muito abaixo do peso", i1.Nome, i1.SobreNome, i1.Imc()));
            else if (i1.Imc() >= 17 && i1.Imc() < 18.5)
                Console.WriteLine(String.Format("senhor(a){0}{1} o seu imc está {2} portanto o senhor(a) se encontra abaixo do peso", i1.Nome, i1.SobreNome, i1.Imc()));
            else if (i1.Imc() >= 18.5 && i1.Imc() < 25)
                Console.WriteLine(String.Format("senhor(a){0}{1} o seu imc está {2} portanto o senhor(a) se encontra normal", i1.Nome, i1.SobreNome, i1.Imc()));
            else if (i1.Imc() >= 25 && i1.Imc() < 30)
                Console.WriteLine(String.Format("senhor(a){0}{1} o seu imc está {2} portanto o senhor(a) se encontra acima do peso", i1.Nome, i1.SobreNome, i1.Imc()));
            else if (i1.Imc() >= 30 && i1.Imc() < 35)
                Console.WriteLine(String.Format("senhor(a){0}{1} o seu imc está {2} portanto o senhor(a) se encontra em obesidade 1", i1.Nome, i1.SobreNome, i1.Imc()));
            else if (i1.Imc() >= 35 && i1.Imc() < 40)
                Console.WriteLine(String.Format("senhor(a){0}{1} o seu imc está {2} portanto o senhor(a) se encontra em obesidade 2", i1.Nome, i1.SobreNome, i1.Imc()));
            else
                Console.WriteLine(String.Format("senhor(a){0}{1} o seu imc está {2} portanto o senhor(a) se encontra em obesidade 3 (Mórbida)", i1.Nome, i1.SobreNome, i1.Imc()));
        }
    }
}
