using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace Menu
{
    class menu
    {
        static void Main(string[] args)
        {
            int op = 1;
            while (op!=0)
            {
                Console.Clear();    
                Console.WriteLine("---------------------------------------------------------------------------------");
                Console.WriteLine("Bem-Vindo, escolha uma opção:");
                Console.WriteLine("1- Cadastrar seu produto");
                Console.WriteLine("2- Lista dos seus produtos");
                Console.WriteLine("3- Sair");
                Console.WriteLine("---------------------------------------------------------------------------------");
                op = int.Parse(Console.ReadLine());
                
                if (op == 3)
                {
                    break;
                }
                else if(op == 1)
                {
                    Console.Clear();
                    Console.WriteLine("Cadastrar Produto");
                    Console.ReadKey();
                }
                else if (op == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Lista dos seus produtos");
                    Console.ReadKey();
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opção inválida");
                    Console.ReadKey();
                }
            }
        }
    }







}