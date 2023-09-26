using extra._02;
using System;
using System.Collections.Generic;



class Program
{
    static void Main()
        {
            StringCollection colecao = new StringCollection();
            LeitorInput leitorInput = new LeitorInput();

            Console.WriteLine("Digite nomes para adicionar à coleção (ou digite 'sair' para encerrar a entrada):");

            while (true)
            {
                string entrada = leitorInput.LerString();

                if (entrada.ToLower() == "sair")
                    break;

                colecao.Adicionar(entrada);
            }

            Console.WriteLine("\nNomes adicionados com sucesso!\n");
            
            colecao.ExibirTodas();

            Console.WriteLine("\nDigite uma string para remover da coleção:");
            string textoParaRemover = leitorInput.LerString();
            colecao.Remover(textoParaRemover);

            Console.WriteLine("\nDepois de remover a string:");
            colecao.ExibirTodas();
        }
    }

