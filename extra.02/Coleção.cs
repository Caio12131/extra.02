using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace extra._02
{
    class StringCollection
    {
        private List<string> strings = new List<string>();

        // Função para adicionar uma string à coleção
        public void Adicionar(string texto)
        {
            strings.Add(texto);
        }

        // Função para remover uma string da coleção
        public void Remover(string texto)
        {
            strings.Remove(texto);
        }

        // Função para exibir todas as strings na coleção
        public void ExibirTodas()
        {
            Console.WriteLine("Nomes na lista:");
            foreach (string texto in strings)
            {
                Console.WriteLine(texto);
            }
        }
    }
}

