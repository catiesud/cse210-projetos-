using System;
using System.Collections.Generic;

/*
 *  Criatividade extras 
 * - Biblioteca com várias escrituras e do livro de Mormom.
 * - Seleção aleatória da escritura exibida.
 * - Oculta apenas palavras que ainda não foram ocultadas.
 */

class Program
{
    static void Main(string[] args)
    {
        Random random = new Random();

        List<Scripture> scriptures = new List<Scripture>()
        {
            new Scripture(
                 new Reference("1 Néfi", 3, 7),
                 "Irei e cumprirei as ordens do Senhor porque sei que o Senhor nunca dá mandamentos aos filhos dos homens sem antes preparar um caminho para que cumpram aquilo que lhes ordena."
            ),


            new Scripture(
                new Reference("João", 3, 16),
                "Porque Deus amou o mundo de tal maneira que deu o seu Filho unigênito para que todo aquele que nele crê não pereça mas tenha a vida eterna."
            ),

            new Scripture(
                new Reference("Mosias", 2, 17),
                   "Quando estais a serviço de vosso próximo estais somente a serviço de vosso Deus."
            ),

            new Scripture(
                new Reference("Lucas", 18,16),
                 "Deixai vir a mim os pequeninos e não os impeçais porque dos tais é o reino de Deus."     
            ),

            new Scripture(
                new Reference("Provérbios", 3, 5, 6),
                "Confia no Senhor de todo o teu coração e não te estribes no teu próprio entendimento. Reconhece o em todos os teus caminhos e ele endireitará as tuas veredas."
            ),

            new Scripture(
                new Reference("Filipenses", 4, 13),
                "Posso todas as coisas naquele que me fortalece."
            )
        };

        Scripture scripture = scriptures[random.Next(scriptures.Count)];

        while (true)
        {
            Console.Clear();

            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();

            if (scripture.IsCompletelyHidden())
            {
                Console.WriteLine("Todas as palavras foram ocultadas.");
                break;
            }

            Console.Write("Pressione ENTER para continuar ou digite 'sair': ");
            string input = Console.ReadLine();

            if (input.ToLower() == "sair")
            {
                break;
            }

            scripture.HideRandomWords(3);
        }
    }
}