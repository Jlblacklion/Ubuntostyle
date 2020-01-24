using System;

namespace UbuntoStyle
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string produto;
            string genero;
            string resp;

            Console.WriteLine("         ==================================");
            Console.WriteLine("         =                                =");
            Console.WriteLine("         = Bem vindo a loja Ubunto Style! =");
            Console.WriteLine("         =                                =");
            Console.WriteLine("         ==================================");
            Console.Write("");

            Console.Write("              Digite seu nome! ");
            nome = Console.ReadLine();
            Console.Write("");
            Console.Write("              Digite 1 para masculino e  2 feminino ! ");
            genero = Console.ReadLine();
            Console.Write("");


            if (genero == "1")
            {
                Console.WriteLine("      Ola! Usuário " + nome + " vamos as compras!");
                Console.WriteLine("");

                Console.Write("         Digite 'S' para sim e 'N' para não ! ");
                resp = Console.ReadLine();
                Console.Write("");

                    if (resp == "S" || resp == "s")
                    {
                        Console.WriteLine(" Escolha o produto do menu abaixo !");
                    }
                    else if ((resp == "N" || resp == "n"))
                    {   
                        Console.WriteLine(" Obrigado pela visita, até mais!");
                        return;
                    }

                Console.WriteLine("         =====================================");
                Console.WriteLine("         = Digite Código do produto desejado =");
                Console.WriteLine("         =              1 Calça              =");
                Console.WriteLine("         =              2 Camiseta           =");
                Console.WriteLine("         =              2 Camiseta afro      =");
                Console.WriteLine("         =====================================");

                produto = Console.ReadLine();

                if ( produto == "1")
                {
                    Console.WriteLine("Ola! Usuário! " + nome + " o seu produto é: calça no valor é de R$ 60");
                }

                else if (produto == "2")
                {
                    Console.WriteLine("Ola! Usuário! " + nome + " o seu produto é: Camiseta no valor é de R$ 50");

                }

                else if (produto == "3")
                {
                    Console.WriteLine("Ola! Usuário! " + nome + " o seu produto é: camiseta afro no valor é de R$ 78");

                }
                else
                {
                    Console.Write("Código inválido");
                }

            }

            // Código do Feminino


            if (genero == "2")
            {
                Console.WriteLine("      Ola! Usuária " + nome + " vamos as compras!");
                Console.Write("");

                Console.Write("          Digite 'S' para sim e 'N' para não ! ");
                resp = Console.ReadLine();
                Console.Write("");

                if (resp == "S" || resp == "s")
                {
                    Console.WriteLine(" Escolha o produto do menu abaixo !");
                }
                else if ((resp == "N" || resp == "n"))
                {
                    Console.WriteLine(" Obrigado pela visita, até mais!");
                    return;
                }
                Console.WriteLine("         =====================================");
                Console.WriteLine("         = Digite Código do produto desejado =");
                Console.WriteLine("         =              1 Calça              =");
                Console.WriteLine("         =              2 Camiseta           =");
                Console.WriteLine("         =              2 Camiseta afro      =");
                Console.WriteLine("         =====================================");


                produto = Console.ReadLine();

                if (produto == "1")
                {
                    Console.WriteLine(" Ola! Usuária! " + nome + " o seu produto é: calça no valor é de R$ 60");
                }

                else if (produto == "2")
                {
                    Console.WriteLine("Ola! Usuária! " + nome + " o seu produto é: Camiseta no valor é de R$ 50");

                }

                else if (produto == "3")
                {
                    Console.WriteLine(" Ola! Usuária! " + nome + " o seu produto é: camiseta afro no valor é de R$ 78");

                }
                else
                {
                    Console.Write("Código inválido");
                }

            }


            Console.ReadKey();
        }
    }
}
