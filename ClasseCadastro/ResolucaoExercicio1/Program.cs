using System;


namespace CadastroCarneiro
{
    /*
     Conceitos de Orientação a Objetos usados
     Classes, Instância, Método
     */
    
    class Program
    {
        
        static void Main(string[] args)
        {
            Carneiro carneiro = new Carneiro();
            Console.WriteLine("Preencha o Numero do Animal:");
            carneiro.numero = Console.ReadLine();
            Console.WriteLine("Digite o Numero da Mãe:");
            carneiro.numero_mae = Console.ReadLine();
            Console.WriteLine("Digite o Nome do Pai:");
            carneiro.nome_pai = Console.ReadLine();
            //pessoa.numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Preencha o Sexo/Genero:");
            carneiro.sexo = Console.ReadLine();
            Console.WriteLine("Preencha a Data de Nascimento:");
            carneiro.data_nascimento = Console.ReadLine();
            MostrarDadosCarneiro(carneiro);
        }

        static void MostrarDadosCarneiro(Carneiro carneiro)
        {
            Console.WriteLine("\n Número: {0}\n Número da Mãe: {1}\n Nome do Pai: {2}\n Sexo: {3}\n Data de Nascimento: {4}",
              carneiro.numero, carneiro.numero_mae, carneiro.nome_pai, carneiro.sexo, carneiro.data_nascimento);
            Console.ReadKey();
        }
    }
}