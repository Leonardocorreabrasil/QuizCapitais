using System;
using System.Threading;

namespace QuizCapitais
{
    class Program
    {
        static void Main(string[] args)
        {

            Perguntas();
        }
        static void Perguntas()
        {

            var perguntas = new string[10];
            var count = 0;
            for (int i = 0; i <= 10; i++)
            {
                if (i == 0)
                {
                    Console.Clear();
                    Console.WriteLine("qual a capital da(o) argentina?");
                    Console.WriteLine("A - Lima");
                    Console.WriteLine("B - Montivideu");
                    Console.WriteLine("C - Buenos Aires");
                    Console.WriteLine("D - Santiago");
                    Console.WriteLine("=============================");
                    Console.WriteLine("");
                    var resp = Console.ReadLine();
                    if (resp == "C" || resp == "c")
                    {
                        Console.WriteLine("resposta certa!!!");
                        count++;

                    }
                    else
                    {
                        Console.WriteLine("resposta errada");
                    }
                    Thread.Sleep(3000);
                }
                if (i == 1)
                {
                    Console.Clear();
                    Console.WriteLine("qual a capital da(o) Paraguai?");
                    Console.WriteLine("A - Lima");
                    Console.WriteLine("B - Assunção");
                    Console.WriteLine("C - Ciudad del este");
                    Console.WriteLine("D - Toqui");
                    Console.WriteLine("=============================");
                    Console.WriteLine("");
                    var resp2 = Console.ReadLine();
                    if (resp2 == "B" || resp2 == "b")
                    {
                        Console.WriteLine("resposta certa!!!");
                        count++;

                    }
                    else
                    {
                        Console.WriteLine("resposta errada");
                    }
                    Thread.Sleep(3000);
                }
                if (i == 2)
                {
                    Console.Clear();
                    Console.WriteLine("qual a capital da(o) Bolivia?");
                    Console.WriteLine("A - Cusco");
                    Console.WriteLine("B - Avellaneda");
                    Console.WriteLine("C - Quito");
                    Console.WriteLine("D - Laz Paz");
                    Console.WriteLine("=============================");
                    Console.WriteLine("");
                    var resp3 = Console.ReadLine();
                    if (resp3 == "D" || resp3 == "d")
                    {
                        Console.WriteLine("resposta certa!!!");
                        count++;

                    }
                    else
                    {
                        Console.WriteLine("resposta errada");
                    }
                    Thread.Sleep(3000);
                }
                if (i == 3)
                {
                    Console.Clear();

                    Console.WriteLine("qual a capital da(o) Chile?");
                    Console.WriteLine("A - Santiago");
                    Console.WriteLine("B - Ushuaia");
                    Console.WriteLine("C - Medelin");
                    Console.WriteLine("D - Cartagena");
                    Console.WriteLine("=============================");
                    Console.WriteLine("");
                    var resp4 = Console.ReadLine();
                    if (resp4 == "A" || resp4 == "a")
                    {
                        Console.WriteLine("resposta certa!!!");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("resposta errada");
                    }
                    Thread.Sleep(3000);
                }
                if (i == 4)
                {
                    Console.Clear();
                    Console.WriteLine("qual a capital da(o) Colombia?");
                    Console.WriteLine("A - Lima");
                    Console.WriteLine("B - Bogota");
                    Console.WriteLine("C - Juarez");
                    Console.WriteLine("D - Sinaloa");
                    Console.WriteLine("=============================");
                    Console.WriteLine("");
                    var resp5 = Console.ReadLine();
                    if (resp5 == "B" || resp5 == "b")
                    {
                        Console.WriteLine("resposta certa!!!");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("resposta errada");
                    }
                    Thread.Sleep(5000);
                }
                if (i == 5)
                {
                    Console.Clear();
                    Console.WriteLine("qual a capital da(o) Peru?");
                    Console.WriteLine("A - Lima");
                    Console.WriteLine("B - Bogota");
                    Console.WriteLine("C - Medelin");
                    Console.WriteLine("D - Cuzco");
                    Console.WriteLine("=============================");
                    Console.WriteLine("");
                    var resp6 = Console.ReadLine();
                    if (resp6 == "A" || resp6 == "a")
                    {
                        Console.WriteLine("resposta certa!!!");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("resposta errada");
                    }
                    Thread.Sleep(5000);
                }
                if (i == 6)
                {
                    Console.Clear();
                    Console.WriteLine("qual a capital da(o) Equador?");
                    Console.WriteLine("A - Quito");
                    Console.WriteLine("B - Cordoba");
                    Console.WriteLine("C - Juarez");
                    Console.WriteLine("D - Assunção");
                    Console.WriteLine("=============================");
                    Console.WriteLine("");
                    var resp7 = Console.ReadLine();
                    if (resp7 == "A" || resp7 == "a")
                    {
                        Console.WriteLine("resposta certa!!!");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("resposta errada");
                    }
                    Thread.Sleep(5000);
                }
                if (i == 7)
                {
                    Console.Clear();
                    Console.WriteLine("qual a capital da(o) Estados unidos?");
                    Console.WriteLine("A - Georgia");
                    Console.WriteLine("B - Denver");
                    Console.WriteLine("C - Washington");
                    Console.WriteLine("D - Atlanta");
                    Console.WriteLine("=============================");
                    Console.WriteLine("");
                    var resp8 = Console.ReadLine();
                    if (resp8 == "C" || resp8 == "c")
                    {
                        Console.WriteLine("resposta certa!!!");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("resposta errada");
                    }
                    Thread.Sleep(5000);
                }
                if (i == 8)
                {
                    Console.Clear();
                    Console.WriteLine("qual a capital da(o) Mexico?");
                    Console.WriteLine("A - Cancun");
                    Console.WriteLine("B - Cidade do Mexico");
                    Console.WriteLine("C - Juarez");
                    Console.WriteLine("D - Sinaloa");
                    Console.WriteLine("=============================");
                    Console.WriteLine("");
                    var resp9 = Console.ReadLine();
                    if (resp9 == "B" || resp9 == "b")
                    {
                        Console.WriteLine("resposta certa!!!");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("resposta errada");
                    }
                    Thread.Sleep(5000);
                }
                if (i == 9)
                {
                    Console.Clear();
                    Console.WriteLine("qual a capital da(o) Canada?");
                    Console.WriteLine("A - Calgary");
                    Console.WriteLine("B - Toronto");
                    Console.WriteLine("C - Vancouver");
                    Console.WriteLine("D - Otawa");
                    Console.WriteLine("=============================");
                    Console.WriteLine("");
                    var resp10 = Console.ReadLine();
                    if (resp10 == "D" || resp10 == "d")
                    {
                        Console.WriteLine("resposta certa!!!");
                        count++;
                    }
                    else
                    {
                        Console.WriteLine("resposta errada");
                    }
                    Thread.Sleep(5000);
                }
            }
            Console.Clear();
            Console.WriteLine($"voce acertou {count} respostas");
            if (count == 10)
            {
                Console.WriteLine("Parabéns voce acertou todos!!");
            }
            if (count >= 8)
            {
                Console.WriteLine("Parabéns voce foi muito bem!!");
            }
            if (count >= 6)
            {
                Console.WriteLine("foi bem, mas poderia melhorar!!");
            }
            if (count < 6)
            {
                Console.WriteLine("Estude mais");
            }
        }

    }

}


