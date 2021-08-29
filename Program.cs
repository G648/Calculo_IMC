using System;

namespace AtividadeIMC
{
    // Faça um programa que receba a idade, o peso, altura e o sexo de 10 pessoas. Calcule e Exiba:
    // a.	Total de Homens;
    // b.	Total de Mulheres;
    // c.   média idade homens;
    // d.   média idade mulheres;
    // e.	Quantidade de pessoas que estão acima do peso,
    //  abaixo do peso e com o peso ideal.

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem vindo ao programa; ");
            int idade;
            double peso;
            double altura;
            char sexo;
            int contadorPessoas = 0;
            int homens = 0;
            int mulheres = 0;
            double mediaIdadeHomens = 0;
            double mediaIdadeMulheres = 0;
            int contadorAcimaPeso = 0;
            int contadorAbaixoPeso =0;

            do
            {
                Console.WriteLine("digite sua idade: ");
                idade = int.Parse(Console.ReadLine());

                Console.WriteLine("digite seu peso: ");
                peso = double.Parse(Console.ReadLine());

                Console.WriteLine("digite sua altura: ");
                altura = double.Parse(Console.ReadLine());

                Console.WriteLine("digite seu sexo: ");
                sexo = char.Parse(Console.ReadLine());

                if (sexo == 'm')
                {
                    mediaIdadeHomens = mediaIdadeHomens + idade;
                    homens++;
                }
                else if (sexo == 'f')
                {
                    mediaIdadeMulheres = mediaIdadeMulheres + idade;
                    mulheres++;
                }
                if (peso > 25 )
                { 
                    contadorAcimaPeso++;
                    Console.WriteLine($"seu IMC é de: {peso/(altura*altura)}");
                }
                else if (peso < 18.5)
                {
                    
                    contadorAbaixoPeso ++;               
                    Console.WriteLine($"seu IMC é de: {peso/(altura*altura)}");
                }

                contadorPessoas++;

            } while (contadorPessoas < 2);

             Console.WriteLine($"a quatidade de mulheres é de: {mulheres}, e a quantidade de homens é de: {homens}");

            if (homens != 0)
            {
                Console.WriteLine($"a média de idade dos homens é de {mediaIdadeHomens / homens}");
            }
            else if (mulheres!= 0)
            {

                Console.WriteLine($"a media de idade das mulheres é de: {mediaIdadeMulheres / mulheres}");
            }

            Console.WriteLine($"a quantidade de pessoas com baixo IMC é de: {contadorAbaixoPeso } ");
            Console.WriteLine($"a quantidade de pessoas com alto IMC é de: {contadorAcimaPeso }  ");
        }
    }
}