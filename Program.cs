using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula06__Agoravai_
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Olá, sejam todos(as) bem-vindos(as) ao Conradito Airlines!");
            Console.WriteLine("Só aqui você encontra passagens aéreas, perfeitas para você!");
            Console.WriteLine("Os meses dísponiveis são:");
            Console.WriteLine("→ Agosto-08\n → Setembro-09\n → Outubro-10 \n");

            Console.WriteLine("Digite um mês (sendo um número):");
            int numero = int.Parse(Console.ReadLine());

            if (numero == 08 || numero == 09 || numero == 10)
            {
                Console.WriteLine("Mês preenchido com sucesso!");
                Console.ReadKey();



            }

            else
            {
                Console.WriteLine("Mês inválido!");

            }
            Console.WriteLine("Agora, escolha o dia desejado \n Pode ser entre os dias 06 e 21:");
            int dia = int.Parse(Console.ReadLine());

            if (dia > 6 || dia < 21)
            {
                Console.WriteLine("Dia escolhido com sucesso!");
            }
            else
            {
                Console.WriteLine("Data inválida");
            }
            Console.WriteLine("Por último, escolha o período que você deseja comprar a passagem:");
            string periodo = (Console.ReadLine());
            if (periodo == "Manhã" || periodo == "Tarde" || periodo == "Noite")
            {
                Console.WriteLine("Período escolhido");
            }
            else
            {
                Console.WriteLine("Período inválido");
            }

            Console.WriteLine("Compra realizada com sucesso, aqui estão suas informações, confira se estão corretas:");
            Console.WriteLine($"Sua viajem será no dia: {dia}, no mês: {numero} e no período: {periodo}");

            Console.WriteLine("Agradecemos a sua compra, volte sempre! Equipe Conradito AirLines");








            Console.ReadKey();

        }
    }
}
