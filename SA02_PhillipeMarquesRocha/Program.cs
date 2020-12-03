using System;

namespace SA02_PhillipeMarquesRocha
{
    class Program
    {
        static void Main(string[] args)
        {
        inicio:
           
            
           
            
            Console.WriteLine(" _______________________________________________ ");
            Console.WriteLine("|-----------------------------------------------|");
            Console.WriteLine("|            Receita de culinária               |");
            Console.WriteLine("|-----------------------------------------------|");
            Console.WriteLine("| 1 -  Registrar a culinária                    |");
            Console.WriteLine("| 2 -  Editar a culinária                       |");
            Console.WriteLine("| 3 -  Elimitar receita de culinária            |");
            Console.WriteLine("| 4 -  Sair                                     |");
            Console.WriteLine("|_______________________________________________|");
            goto inicio;

            int A;
            A = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            
            switch (A)
            {
                case 1:
                    Console.WriteLine("Digite o nome da receita: ");
                    string nomereceita = (Console.ReadLine());
                    Console.WriteLine("Digite o tempo de preparação: ");// nao esquecer colocar o tempo --:--
                    double tempopreparacao = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o grau de dificuldade: ");
                    double graudificuldade = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite o número de pessoa para preparação: ");
                    double numpessoa = double.Parse(Console.ReadLine());
                    Console.WriteLine("Digite a categoria: ");
                    string Categolinaria =(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine();
                    Console.WriteLine("Por favor aperta Enter para voltar no menu");
                  break;
            }
            switch (A)
            {
                case 2:
                    
                    {


                        Console.WriteLine("Editar a culinária");
                        Console.WriteLine("Digite as opções abaixo:");
                        Console.WriteLine("1 -Editar a receita.");
                        Console.WriteLine("2 -Editar tempo de preparação");
                        Console.WriteLine("3 -Editar o grau de dificuldade");
                        Console.WriteLine("4 -Editar quantidade da pessoa");
                        Console.WriteLine("5 -Editar a categoria");
                        int B;
                        B = Convert.ToInt32(Console.ReadLine());
                       
                       switch (B)
                       {
                            case 1:
                            Console.WriteLine("");
                            case 2:
                                Console.WriteLine("");
                                break;

                            default:

                                break;
                       }













                        break;
                    }
                    
            }
            switch (A)
            {
                case 3:
                    Console.Clear();
                    break;
            }
            switch (A)
            {
                default:
                    Console.WriteLine("");
                    break;
            }
            Console.ReadLine();

            
            
            


           




        }
    }
}
