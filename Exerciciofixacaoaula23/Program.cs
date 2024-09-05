using System;
using System.Globalization;
using System.Net;
using System.Security;

namespace ExercicioFixacaoaula23 {

    class Program {
        static void Main(string[] args) {


            Console.WriteLine("Digite seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem na sua casa");
            int quartos = int.Parse(Console.ReadLine());

            Console.WriteLine("Entre com o preço de um produto");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu ultimo nome, idade e altura");
            string[] dados = Console.ReadLine().Split(' ');
            string ultimonome = dados[0];
            string idade = dados[1];
            string alturaCm = dados[2];
            double preco2 = preco / 100;

           

            int idade2 = int.Parse(idade);
            double alturaMetros = double.Parse(alturaCm) / 100.0;




            Console.WriteLine("Seu nome é: " + nome);
            Console.WriteLine("Sua casa tem: " + quartos + " quartos");
            Console.WriteLine("O preço do produto é: " + preco2.ToString("F2", CultureInfo.InvariantCulture));
            Console.WriteLine("Seu ultimo nome é: " + ultimonome + " sua idade é: " + idade + ", sua altura é: " + alturaMetros); 


           
            


          















        }











    }











}