using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDeEquipamentos.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            Inicio:
            Console.Clear();
            Console.WriteLine("Digite a opção: \n 1 Para equipamentos, \n 2 para chamados, \n 3 para sair");
            opcao = Convert.ToInt32(Console.ReadLine());
            //equipamentos
            if (opcao == 1)
            {
                Console.Clear();
                DateTime[] data = new DateTime[100];
                string[] nome = new string[100], fabricante = new string[100];
                int contadorId = 0;
                double[] preco = new double[100];
                int[] serie = new int[100];

                Console.Clear();

                while (true)
                {
                    int opcao2 = PedirOpcao();

                    //criar
                    if (opcao2 == 1)
                    {
                        contadorId = criarEquipamento(data, nome, fabricante, contadorId, preco, serie);

                    }
                    //editar
                    if (opcao2 == 2)
                    {
                        editarEquipamento(data, nome, fabricante, contadorId, preco, serie);
                    }
                    //excluir
                    if (opcao2 == 3)
                    {
                        excluirEquipamento(data, nome, fabricante, contadorId, preco, serie);

                    }
                    //listar
                    if (opcao2 == 4)
                    {
                        for (int i = 0; i < contadorId; i++)
                        {
                            if (nome[i] != null)
                            {
                                Console.WriteLine($"Série:{serie[i]} nome: {nome[i]} fabricante: {fabricante[i]} preco: {preco[i]} data: {data[i].ToShortDateString()}");
                            }

                        }
                        Console.ReadLine();
                    }
                    //voltar
                    else if (opcao2 == 5)
                    {
                        goto Inicio;
                    }

                }
            }
            //chamados
            if (opcao == 2)
            {
                Console.Clear();
                DateTime[] data = new DateTime[100];
                string[] nome = new string[100], descricao = new string[100], equipamentos = new string[100];
                int contadorId = 0;
                Console.Clear();

                while (true)
                {
                    int opcao2 = PedirOpcao();
                    //criar 
                    if (opcao2 == 1)
                    {
                        contadorId = criarChamado(data, nome, descricao, equipamentos, contadorId);
                    }
                    //editar
                    if (opcao2 == 2)
                    {
                        editarChamado(data, nome, descricao, equipamentos, contadorId);
                    }
                    //excluir
                    if (opcao2 == 3)
                    {
                        excluirChamado(data, nome, descricao, equipamentos, contadorId);
                    }
                    //listar
                    if (opcao2 == 4)
                    {
                        for (int i = 0; i < contadorId; i++)
                        {
                            if (nome[i] != null)
                            {
                                string diasDif = (DateTime.Now - data[i]).ToString("dd");
                                Console.WriteLine($"Título:{nome[i]} equipamento: {equipamentos[i]} data: {data[i].ToShortDateString()} dias em aberto: {diasDif}");
                            }
                        }
                        Console.ReadLine();
                    }
                    //voltar
                    else if (opcao2 == 5)
                    {
                        goto Inicio;
                    }
                }
            }
            //fecha app
            if (opcao == 3)
            {
                Environment.Exit(0);
            }
        }

        private static int PedirOpcao()
        {
            Console.Clear();
            int opcao2;
            Console.WriteLine("Digite a opção: \n 1 Para criar \n 2 para editar \n 3 para excluir \n 4 para listar \n 5 para voltar");
            opcao2 = Convert.ToInt32(Console.ReadLine());
            return opcao2;
        }

        private static void excluirEquipamento(DateTime[] data, string[] nome, string[] fabricante, int contadorId, double[] preco, int[] serie)
        {
            Console.Clear();
            bool valorEncontrado = false;
            Console.WriteLine("Digite a série do produto para edição: ");
            int serieBusca = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < contadorId; i++)
            {
                if (serie[i] == serieBusca)
                {
                    serie[i] = 0;
                    nome[i] = null;
                    fabricante[i] = null;
                    preco[i] = 0;
                    data[i] = DateTime.MinValue;
                    valorEncontrado = true;
                }
            }
            if (valorEncontrado == false)
            {
                Console.WriteLine("Valor não encontrado!");
                Console.ReadLine();
            }
        }

        private static void editarEquipamento(DateTime[] data, string[] nome, string[] fabricante, int contadorId, double[] preco, int[] serie)
        {
            bool valorEncontrado = false;
            Console.Clear();
            Console.WriteLine("Digite a série do produto para edição: ");
            int serieBusca = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < contadorId; i++)
            {
                if (serie[i] == serieBusca)
                {
                    Console.WriteLine("Digite número série: ");
                    serie[i] = Convert.ToInt32(Console.ReadLine());

                    bool nomeValido = false;
                    string nomeAnalise;

                    do
                    {
                        Console.WriteLine("Digite nome do equipamento: ");
                        nomeAnalise = Console.ReadLine();
                        if (nomeAnalise.Length < 6)
                        {
                            nomeValido = true;
                            Console.WriteLine("Nome inválido");

                        }
                        else
                        {
                            nomeValido = false;
                        }
                    } while (nomeValido);

                    nome[contadorId] = nomeAnalise;

                    Console.WriteLine("Digite fabricante do produto: ");
                    fabricante[i] = Console.ReadLine();

                    Console.WriteLine("Digite preco: ");
                    preco[i] = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Digite data: nesse formato(YYYY,MM,DD)");
                    data[contadorId] = Convert.ToDateTime(Console.ReadLine());
                    valorEncontrado = true;

                }

            }
            if (valorEncontrado == false)
            {
                Console.WriteLine("Valor não encontrado!");
                Console.ReadLine();
            }
        }

        private static int criarEquipamento(DateTime[] data, string[] nome, string[] fabricante, int contadorId, double[] preco, int[] serie)
        {
            Console.Clear();
            Console.WriteLine("Digite número série: ");
            serie[contadorId] = Convert.ToInt32(Console.ReadLine());

            bool nomeValido = false;
            string nomeAnalise;

            do
            {
                Console.WriteLine("Digite nome do equipamento: ");
                nomeAnalise = Console.ReadLine();
                if (nomeAnalise.Length < 6)
                {
                    nomeValido = true;
                    Console.WriteLine("Nome inválido");

                }
                else
                {
                    nomeValido = false;
                }
            } while (nomeValido);

            nome[contadorId] = nomeAnalise;

            Console.WriteLine("Digite fabricante do produto: ");
            fabricante[contadorId] = Console.ReadLine();

            Console.WriteLine("Digite preco: ");
            preco[contadorId] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite data: nesse formato(YYYY,MM,DD)");
            data[contadorId] = Convert.ToDateTime(Console.ReadLine());

            contadorId++;
            return contadorId;
        }

        private static void excluirChamado(DateTime[] data, string[] nome, string[] descricao, string[] equipamentos, int contadorId)
        {
            Console.Clear();
            Console.WriteLine("Digite a titulo para EXCLUIR: ");
            string titulo = Console.ReadLine();
            bool valorEncontrado = false;
            for (int i = 0; i < contadorId; i++)
            {
                if (nome[i] == titulo)
                {

                    nome[i] = null;
                    descricao[i] = null;
                    equipamentos[i] = null;
                    data[i] = DateTime.MinValue;
                    valorEncontrado = true;
                }
            }
            if (valorEncontrado != true)
            {
                Console.WriteLine("Valor não encontrado!");
                Console.ReadLine();
            }
        }

        private static void editarChamado(DateTime[] data, string[] nome, string[] descricao, string[] equipamentos, int contadorId)
        {
            Console.Clear();

            Console.WriteLine("Digite a titulo para edição: ");
            string titulo = Console.ReadLine();
            bool valorEncontrado = false;
            for (int i = 0; i < contadorId; i++)
            {
                if (nome[i] == titulo)
                {
                    Console.Clear();

                    Console.WriteLine("Digite título: ");
                    nome[i] = Console.ReadLine();

                    Console.WriteLine("Digite descricao do produto: ");
                    descricao[i] = Console.ReadLine();

                    Console.WriteLine("Digite equipamento: ");
                    equipamentos[i] = Console.ReadLine();

                    Console.WriteLine("Digite data: nesse formato(YYYY,MM,DD)");
                    data[i] = Convert.ToDateTime(Console.ReadLine());
                    valorEncontrado = true;
                }
            }
            if (valorEncontrado == false)
            {
                Console.WriteLine("Valor não encontrado!");
                Console.ReadLine();
            }
        }

        private static int criarChamado(DateTime[] data, string[] nome, string[] descricao, string[] equipamentos, int contadorId)
        {
            Console.Clear();

            Console.WriteLine("Digite título: ");
            nome[contadorId] = Console.ReadLine();

            Console.WriteLine("Digite descricao do equipamento: ");
            descricao[contadorId] = Console.ReadLine();

            Console.WriteLine("Digite equipamento: ");
            equipamentos[contadorId] = Console.ReadLine();

            Console.WriteLine("Digite data: nesse formato(YYYY,MM,DD)");
            data[contadorId] = Convert.ToDateTime(Console.ReadLine());

            contadorId++;
            return contadorId;
        }
    }
}

