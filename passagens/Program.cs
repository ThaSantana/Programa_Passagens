using System;

namespace passagens
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Viagem de Fim de Ano");

            Console.WriteLine("Digite a Cia Aérea que deseja viajar: ");
            string cia = Console.ReadLine();
            Console.WriteLine("Cia Aérea escolhida: " + cia);
            Console.WriteLine("Escolha seu destino: ");
            Console.WriteLine("1 - Para o Nordeste");
            Console.WriteLine("2 - Para o Norte");
            Console.WriteLine("3 - Para o Sudeste");
            Console.WriteLine("4 - Para o Sul");
            Console.WriteLine("5 - Para o Centro-Oeste");
            int destino = int.Parse(Console.ReadLine());
            if (destino == 0 && destino > 6)
            {
                Console.WriteLine("Opção Inválida");
            }
            if (destino == 1)
            {
                Console.WriteLine("1 - Bahia");
                Console.WriteLine("2 - Alagoas");
                Console.WriteLine("3 - Piauí");
                Console.WriteLine("4 - Rio Grande do Norte");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("O destino escolhido foi: Bahia");
                    Console.WriteLine("Viagem para a Bahia é de: R$1000,00");
                }
                if (opcao == 2)
                {
                    Console.WriteLine("O destino escolhido foi: Alagoas");
                    Console.WriteLine("Viagem para Alagoas é de: R$900,00");
                }
                if (opcao == 3)
                {
                    Console.WriteLine("O destino escolhido foi: Piauí");
                    Console.WriteLine("Viagem para o Piauí é de: R$800,00");
                }
                if (opcao == 4)
                {
                    Console.WriteLine("O destino escolhido foi: Rio Grande do Norte");
                    Console.WriteLine("Viagem para o Rio Grande do Norte é de: R$1200,00");
                }
            }
            if (destino == 2)
            {
                Console.WriteLine("1 - Amazonia");
                Console.WriteLine("2 - Pará");
                Console.WriteLine("3 - Acre");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("O destino escolhido foi: Amazonia");
                    Console.WriteLine("Viagem para a Amazonia é de : R$1000,00");
                }
                if (opcao == 2)
                {
                    Console.WriteLine("O destino escolhido foi: Pará");
                    Console.WriteLine("Viagem para o Pará é de : R$900,00");
                }
                if (opcao == 3)
                {
                    Console.WriteLine("O destino escolhido foi: Acre");
                    Console.WriteLine("Viagem para o Acre é de: R$600,00");
                }

            }
            if (destino == 3)
            {
                Console.WriteLine("1 - São Paulo");
                Console.WriteLine("2 - Rio de Janeiro");
                Console.WriteLine("3 - Minas Gerais");
                Console.WriteLine("4 - Espírito Santo");
                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("O destino escolhido foi: São Paulo");
                    Console.WriteLine("Viagem para São Paulo é de: R$1000,00");
                }
                if (opcao == 2)
                {
                    Console.WriteLine("O destino escolhido foi: Rio de Janeiro");
                    Console.WriteLine("Viagem para o Rio de Janeiro é de: R$1300,00");
                }
                if (opcao == 3)
                {
                    Console.WriteLine("O destino escolhido foi: Minas Gerais");
                    Console.WriteLine("Viagem para Minas Gerais é de: R$800,00");
                }
                if (opcao == 4)
                {
                    Console.WriteLine("O destino escolhido foi: Espírito Santo");
                    Console.WriteLine("Viagem para o Espírito Santo é de: R$700,00");
                }
            }
            if (destino == 4)
            {
                Console.WriteLine("1 - Paraná");
                Console.WriteLine("2 - Rio Grande do Sul");
                Console.WriteLine("3 - Santa Carina");

                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("O destino escolhido foi: Paraná");
                    Console.WriteLine("Viagem para o Paraná é de: R$800,00");
                }
                if (opcao == 2)
                {
                    Console.WriteLine("O destino escolhido foi: Rio Grande do Sul");
                    Console.WriteLine("Viagem para o Rio Grande do Sul é de: R$1300,00");
                }
                if (opcao == 3)
                {
                    Console.WriteLine("O destino escolhido foi: Santa Catarina");
                    Console.WriteLine("Viagem para Santa Catarina é de: R$900,00");
                }

            }
            if (destino == 5)
            {
                Console.WriteLine("1 - Mato Grosso do Sul");
                Console.WriteLine("2 - Mato Grosso");
                Console.WriteLine("3 - Goias");

                int opcao = int.Parse(Console.ReadLine());
                if (opcao == 1)
                {
                    Console.WriteLine("O destino escolhido foi: Mato Grosso do Sul");
                    Console.WriteLine("Viagem para o Mato Grosso do Sul é de: R$800,00");
                }
                if (opcao == 2)
                {
                    Console.WriteLine("O destino escolhido foi: Mato Grosso");
                    Console.WriteLine("Viagem para o Mato Grosso é de: R$800");
                    if (opcao == 3)
                    {
                        Console.WriteLine("O destino escolhido foi: Goias");
                        Console.WriteLine("Viagem para Goias é de: R$900,00");
                    }
                }
                

            }
            Console.WriteLine("Deseja fazer uma reserva em Hotel:");
            Console.WriteLine("1- SIM");
            Console.WriteLine("2-NÃO");
            int hotel = int.Parse(Console.ReadLine());
            if (hotel == 1)
            {
                Console.WriteLine("Escolha seu hotel:");
                Console.WriteLine("1 - Hotel Malibu - SP");
                Console.WriteLine("2 - Hotel Copacabana - RJ");
                Console.WriteLine("3 - Hotel Reserva da Mata - MG");
                int hotel1 = int.Parse(Console.ReadLine());
                if(hotel1 == 1)
                {
                    Console.WriteLine("você escolheu o Hotel Malibu em São Paulo.");
                    Console.WriteLine("O valor da diária é de R$200,00 , com café da manhã incluso.");

                }
                else if(hotel1 == 2)
                {
                    Console.WriteLine("Você escolheu o Hotel Copacabana no Rio de Janeiro");
                    Console.WriteLine("O valor da diária é de R$350,00 , com café da manhã incluso");

                }
                else if(hotel1 ==3)
                {
                    Console.WriteLine("Você escolheu o Hotel Reserva da Mata em Minas Gerais.");
                    Console.WriteLine("O valor da diária é de R$200,00 com café da manhã incluso.");
                }
            }
            else if (hotel == 2)
            {
                Console.WriteLine("Obrigada por utilizar nossos Serviços!");
            }

        }
    }
} 
