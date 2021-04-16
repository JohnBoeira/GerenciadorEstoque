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

            //if (serie.Length != serie.Distinct().Count()) Console.WriteLine("Série já digitada");
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
                    Console.Clear();
                    int opcaoEquipamento;
                    Console.WriteLine("Digite a opção: \n 1 Para criar \n 2 para editar \n 3 para excluir \n 4 para listar \n 5 para voltar");
                    opcaoEquipamento = Convert.ToInt32(Console.ReadLine());
                    //criar
                    if (opcaoEquipamento == 1)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite número série: ");
                        serie[contadorId] = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite nome do produto: ");
                        nome[contadorId] = Console.ReadLine();

                        Console.WriteLine("Digite fabricante do produto: ");
                        fabricante[contadorId] = Console.ReadLine();

                        Console.WriteLine("Digite preco: ");
                        preco[contadorId] = Convert.ToDouble(Console.ReadLine());


                        Console.WriteLine("Digite data: nesse formato(YYYY,MM,DD)");
                        data[contadorId] = Convert.ToDateTime(Console.ReadLine());

                        contadorId++;

                    }
                    //editar
                    if (opcaoEquipamento == 2)
                    {
                        Console.Clear();

                        Console.WriteLine("Digite a série do produto para edição: ");
                        int serieBusca = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < contadorId; i++)
                        {
                            if (serie[i] == serieBusca)
                            {
                                Console.WriteLine("Digite número série: ");
                                serie[i] = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Digite nome do produto: ");
                                nome[i] = Console.ReadLine();

                                Console.WriteLine("Digite fabricante do produto: ");
                                fabricante[i] = Console.ReadLine();

                                Console.WriteLine("Digite preco: ");
                                preco[i] = Convert.ToDouble(Console.ReadLine());

                                Console.WriteLine("Digite data: nesse formato(YYYY,MM,DD)");
                                data[contadorId] = Convert.ToDateTime(Console.ReadLine());

                            }
                        }
                        //Console.WriteLine("Valor não encontrado");
                    }
                    //excluir
                    if (opcaoEquipamento == 3)
                    {
                        Console.Clear();

                        Console.WriteLine("Digite a série do produto para edição: ");
                        int serieBusca = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < contadorId; i++)
                        {
                            if (serie[i] == serieBusca)
                            {

                                serie[i] = 0;
                                nome[i] = "";
                                fabricante[i] = "";

                                preco[i] = 0;


                                data[i] = Convert.ToDateTime("0000,00,00");
                            }
                        }
                    }
                    //listar
                    if (opcaoEquipamento == 4)
                    {
                        for (int i = 0; i < contadorId; i++)
                        {
                            Console.WriteLine($"Série:{serie[i]} nome: {nome[i]} fabricante: {fabricante[i]} preco: {preco[i]} data: {data[i]}");
                        }
                        Console.ReadLine();
                    }
                    //voltar
                    else if (opcaoEquipamento == 5)
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
                    Console.Clear();
                    int opcaoChamado;
                    Console.WriteLine("Digite a opção: \n 1 Para criar \n 2 para editar \n 3 para excluir \n 4 para listar \n 5 para voltar");
                    opcaoChamado = Convert.ToInt32(Console.ReadLine());
                    //criar 
                    if (opcaoChamado == 1)
                    {
                        Console.Clear();

                        Console.WriteLine("Digite título: ");
                        nome[contadorId] = Console.ReadLine();

                        Console.WriteLine("Digite descricao do produto: ");
                        descricao[contadorId] = Console.ReadLine();

                        Console.WriteLine("Digite equipamento: ");
                        equipamentos[contadorId] = Console.ReadLine();

                        Console.WriteLine("Digite data: nesse formato(YYYY,MM,DD)");
                        data[contadorId] = Convert.ToDateTime(Console.ReadLine());

                        contadorId++;

                    }
                    //editar
                    if (opcaoChamado == 2)
                    {
                        Console.Clear();

                        Console.WriteLine("Digite a titulo para edição: ");
                        string titulo = Console.ReadLine();

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
                                data[contadorId] = Convert.ToDateTime(Console.ReadLine());

                            }
                        }
                        //Console.WriteLine("Valor não encontrado");
                    }
                    //excluir
                    if (opcaoChamado == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("Digite a titulo para EXCLUIR: ");
                        string titulo = Console.ReadLine();

                        for (int i = 0; i < contadorId; i++)
                        {
                            if (nome[i] == titulo)
                            {

                                nome[i] = "";
                                descricao[i] = "";
                                equipamentos[i] = "";
                                data[i] = Convert.ToDateTime("0000,00,00");
                            }
                        }
                        //Console.WriteLine("Valor não encontrado");
                    }
                    //listar
                    if (opcaoChamado == 4)
                    {

                        for (int i = 0; i < contadorId; i++)
                        {
                            string diasDif = (DateTime.Now - data[i]).ToString("dd");
                            Console.WriteLine($"Título:{nome[i]} descrição: {descricao[i]} equipamento: {equipamentos[i]} dias em aberto: {diasDif}");
                        }
                        Console.ReadLine();
                    }
                    //voltar
                    else if (opcaoChamado == 5)
                    {
                        goto Inicio;
                    }
                }
            }

            if (opcao == 3)
            {
                Environment.Exit(0);
            }

        }
    }
}

