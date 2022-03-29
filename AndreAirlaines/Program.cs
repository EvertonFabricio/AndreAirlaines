using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Model;
using File;



namespace AndreAirlaines
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(">>>>>>>> BEM VIDO A ANDRE AIRLINES! <<<<<<<<");
            string escolha;
            do
            {
                Console.WriteLine("Escolha a opção desejada:");
                Console.WriteLine("1 - Cadastrar Passageiro");
                Console.WriteLine("2 - Importar arquivos CSV");
                Console.WriteLine("0 - Sair");

                switch (escolha = Console.ReadLine())
                {
                    case "1":
                        Console.Clear();
                        File.File.CadastrarPassageiro();
                        Console.WriteLine("Passageiro cadastrado com sucesso!\nPressione ENTER para voltar...");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    
                    case "2":
                        Console.Clear();
                        Console.WriteLine("Importando arquivos de Passageiros e Endereços. Por favor aguarde...");
                        File.File.LerArquivoEndereco();
                        Console.WriteLine("Arquivos importados com sucesso!\nPressione ENTER para voltar...");
                        Console.ReadLine();
                        Console.Clear();
                        break;

                    case "0":
                        Console.WriteLine("Obrigado por utilizar nossos serviços!");
                        break;

                    default:
                        Console.WriteLine("Opção invalida. Escolha novamente:");
                        break;
                }
            } while (escolha != "0");



        }
    }

}
