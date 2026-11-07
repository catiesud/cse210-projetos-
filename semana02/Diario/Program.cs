

using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace DiarioPessoal
{
    // Representa um registro individual do diário (Demonstra Abstração)
    public class Registro
    {
        public string Data { get; set; }
        public string Pergunta { get; set; }
        public string Resposta { get; set; }

        public Registro(string data, string pergunta, string resposta)
        {
            Data = data;
            Pergunta = pergunta;
            Resposta = resposta;
        }

        public void ExibirRegistro()
        {
            Console.WriteLine($"--------------------------------------------------");
            Console.WriteLine($"📅 Data: {Data}");
            Console.WriteLine($"❓ Pergunta: {Pergunta}");
            Console.WriteLine($"✍️ Resposta: {Resposta}");
            Console.WriteLine($"--------------------------------------------------");
        }
    }

    // Gerencia a lista de registros e a lógica de perguntas/respostas (Demonstra Abstração)
    public class Diario
    {
        private List<Registro> _registros;
        private List<string> _perguntas;
        private Random _random;

        public Diario()
        {
            _registros = new List<Registro>();
            _random = new Random();

            // Lista de perguntas e  extras)
            _perguntas = new List<string>
            {
                "Quem foi a pessoa mais interessante com quem interagi hoje?",
                "Qual foi a melhor parte do meu dia?",
                "Como vi a mão do Senhor em minha vida hoje?",
                "Qual foi a emoção mais forte que senti hoje?",
                "Se eu pudesse fazer uma coisa hoje, o que seria?",
                "O que aprendi de novo hoje que gostaria de lembrar?",
                "Qual foi o maior desafio que superou no dia de hoje?"
            };
        }

        public void AdicionarNovoRegistro()
        {
            // Seleciona uma pergunta aleatória
            int indiceAleatorio = _random.Next(_perguntas.Count);
            string perguntaEscolhida = _perguntas[indiceAleatorio];

            Console.WriteLine($"\n[Nova Entrada no Diário]");
            Console.WriteLine($"Pergunta: {perguntaEscolhida}");
            Console.Write("Sua resposta: ");
            string respostaUsuario = Console.ReadLine();

            // Pega a data e hora atual formatada
            string dataAtual = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            Registro novoRegistro = new Registro(dataAtual, perguntaEscolhida, respostaUsuario);
            _registros.Add(novoRegistro);

            Console.WriteLine("\n✅ Registro adicionado com sucesso!");
        }

        public void ExibirDiario()
        {
            if (_registros.Count == 0)
            {
                Console.WriteLine("\n📭 O diário está vazio no momento.");
                return;
            }

            Console.WriteLine("\n================== SEU DIÁRIO ==================");
            foreach (var registro in _registros)
            {
                registro.ExibirRegistro();
            }
        }

        public void SalvarEmArquivo(string nomeArquivo)
        {
            try
            {
                // Garante a extensão .json para o arquivo
                if (!nomeArquivo.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                {
                    nomeArquivo += ".json";
                }

                // Serializa a lista de registros para formato JSON
                var opcoes = new JsonSerializerOptions { WriteIndented = true };
                string jsonString = JsonSerializer.Serialize(_registros, opcoes);

                File.WriteAllText(nomeArquivo, jsonString);
                Console.WriteLine($"\n💾 Diário salvo com sucesso no arquivo '{nomeArquivo}'!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n❌ Erro ao salvar o arquivo: {ex.Message}");
            }
        }

        public void CarregarDeArquivo(string nomeArquivo)
        {
            try
            {
                if (!nomeArquivo.EndsWith(".json", StringComparison.OrdinalIgnoreCase))
                {
                    nomeArquivo += ".json";
                }

                if (!File.Exists(nomeArquivo))
                {
                    Console.WriteLine($"\n❌ O arquivo '{nomeArquivo}' não foi encontrado.");
                    return;
                }

                string jsonString = File.ReadAllText(nomeArquivo);
                var registrosCarregados = JsonSerializer.Deserialize<List<Registro>>(jsonString);

                if (registrosCarregados != null)
                {
                    _registros = registrosCarregados;
                    Console.WriteLine($"\n📂 Diário carregado com sucesso de '{nomeArquivo}'! {_registros.Count} registros encontrados.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\n❌ Erro ao carregar o arquivo: {ex.Message}");
            }
        }
    }

    // Classe principal que controla o fluxo do programa e o menu
    class Program
    {
        static void Main(string[] args)
        {
            Diario meuDiario = new Diario();
            int opcao = 0;

            Console.WriteLine("🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻🌻");
            Console.WriteLine("      BEM-VINDO AO SEU DIÁRIO PESSOAL DIGITAL     ");
            Console.WriteLine("⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐⭐");

            do
            {
                Console.WriteLine("\nMenu Principal:");
                Console.WriteLine("1. Escrever um novo registro");
                Console.WriteLine("2. Exibir o diário");
                Console.WriteLine("3. Salvar o diário em um arquivo");
                Console.WriteLine("4. Carregar o diário a partir de um arquivo");
                Console.WriteLine("5. Sair");
                Console.Write("Escolha uma opção (1-5): ");

                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            meuDiario.AdicionarNovoRegistro();
                            break;
                        case 2:
                            meuDiario.ExibirDiario();
                            break;
                        case 3:
                            Console.Write("Digite o nome do arquivo para salvar (ex: meu_diario): ");
                            string arquivoSalvar = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(arquivoSalvar))
                            {
                                meuDiario.SalvarEmArquivo(arquivoSalvar);
                            }
                            else
                            {
                                Console.WriteLine("❌ Nome de arquivo inválido.");
                            }
                            break;
                        case 4:
                            Console.Write("Digite o nome do arquivo para carregar ");
                            string arquivoCarregar = Console.ReadLine();
                            if (!string.IsNullOrWhiteSpace(arquivoCarregar))
                            {
                                meuDiario.CarregarDeArquivo(arquivoCarregar);
                            }
                            else
                            {
                                Console.WriteLine("❌ Nome de arquivo inválido.");
                            }
                            break;
                        case 5:
                            Console.WriteLine("\nObrigado por usar o Diário Pessoal. Até logo!");
                            break;
                        default:
                            Console.WriteLine("\n⚠️ Opção inválida. Escolha um número entre 1 e 5.");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("\n⚠️ Entrada inválida. Por favor, digite um número.");
                }

                if (opcao != 5)
                {
                    Console.WriteLine("\nPressione qualquer tecla para continuar...");
                    Console.ReadKey();
                    Console.Clear();
                }

            } while (opcao != 5);
        }
    }
}
