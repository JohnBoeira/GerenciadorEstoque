using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestãoDeEquipamentos.ConsoleApp
{
    /*
     ter um nome com no mínimo 6 caracteres;  •  Deve
     ter um preço de aquisição;  •  Deve
     ter um número de série;  •  Deve
     ter uma data de fabricação;
     
     */

    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            // (DateTime.Now - chamados.data).ToString("dd");

            //if (serie.Length != serie.Distinct().Count()) Console.WriteLine("Série já digitada");
            Inicio:
            Console.Clear();
            Console.WriteLine("Digite a opção: \n 1 Para equipamentos, \n 2 para chamados, \n 3 para sair");
            opcao = Convert.ToInt32(Console.ReadLine());


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

                        //Console.WriteLine("Digite data: ");
                        //data[contadorId] = Convert.ToDateTime(Console.ReadLine());

                        contadorId++;
                                           
                    }

                    if (opcaoEquipamento == 2)
                    {
                        Console.Clear();
                        int serieBusca;
                        Console.WriteLine("Digite a série do produto para edição: ");
                        serieBusca = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < serie.Length; i++)
                        {
                            if (serie[i]==serieBusca)
                            {
                                Console.WriteLine("Digite número série: ");
                                serie[i] = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("Digite nome do produto: ");
                                nome[i] = Console.ReadLine();

                                Console.WriteLine("Digite fabricante do produto: ");
                                fabricante[i] = Console.ReadLine();

                                Console.WriteLine("Digite preco: ");
                                preco[i] = Convert.ToDouble(Console.ReadLine());

                                //Console.WriteLine("Digite data: ");
                                //data[i] = Convert.ToDateTime(Console.ReadLine());

                            }                         
                        }
                        //Console.WriteLine("Valor não encontrado");
                    }
                    
                    if (opcaoEquipamento == 3)
                    {

                    }
                    if (opcaoEquipamento == 4)
                    {
                        for (int i = 0; i < contadorId; i++)
                        {
                            Console.WriteLine($"Série:{serie[i]} nome: {nome[i]} fabricante: {fabricante[i]} preco: {preco[i]}");                          
                        }
                        Console.ReadLine();
                    }
                    else if (opcaoEquipamento == 5)
                    {
                        goto Inicio;
                    }

                }
            }

            if (opcao == 2)
            {

            }
            else
            {
                Environment.Exit(0);
            }





            DateTime dataHoje = new DateTime();





















        }

    }
}
