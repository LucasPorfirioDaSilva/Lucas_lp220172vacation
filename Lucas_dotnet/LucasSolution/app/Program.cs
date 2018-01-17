using System;
using System.Collections.Generic;
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
            int sel;
            Console.WriteLine("insira 0 para o programa básico \n Insira 1 para testes com listas e 2 para dicionários ");
            sel = Convert.ToInt32(Console.ReadLine());

            if (sel == 0)
            {
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
            else if (sel == 1)
            {
                List<string> listacav = new List<string>();
                int op = 1;
                while (op==1)
                {
                    Console.WriteLine("Digite um nome para inserir na lista:");
                    string nome = Console.ReadLine();
                    //Adiciona o item à lista
                    listacav.Add(nome);
                    Console.WriteLine("Deseja inserir outro nome? 1-SIM | 2-NÃO");
                    op = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("A lista tem " + listacav.Count + " itens:");
                //Imprime cada item da lista
                listacav.ForEach(i => Console.WriteLine(i));
                op = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                String nom;
                int p1=1;
                Dictionary<string, string> dcn = new Dictionary<string, string>();
                dcn.Add("Lucas", "Porfirio");
                dcn.Add("Willian", "Vitorino");
                dcn.Add("Wellington", "Pereira");
                dcn.Add("Joyce", "Quintino");
                dcn.Add("Silas", "Santiago");

                while (p1 == 1)
                {
                    Console.WriteLine("Escreva o Nome do aluno o qual deseja saber o sobrenome da turma");
                    nom = Console.ReadLine();
                    if (dcn.ContainsKey(nom))
                    {
                        Console.WriteLine(dcn[nom]);
                    }
                    else
                        Console.WriteLine("Verifique o nome inserido e tente novamente");

                    Console.WriteLine("deseja buscar outro aluno \n1 Sim - 2 Não");
                    p1 = Convert.ToInt32(Console.ReadLine());

                }

            }


        }
    }
}
