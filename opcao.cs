using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace @enum
{
    internal class Program
    {
        enum opcao { criar=1,deletar,atualizar}


        static void Main(string[] args)
        {
            

            Console.WriteLine("Escolha uma das opções");
            Console.WriteLine("1-Criar,\n2-Deletar,\n3-Atualizar");

            int escolhadoU = int.Parse(Console.ReadLine());

            opcao opcaoSelecionada = (opcao)escolhadoU;

            switch (opcaoSelecionada)
            {
                case opcao.criar:
                    Console.WriteLine("Voce criou um gato! >.< ");
                    break;
                case opcao.deletar:
                    Console.WriteLine("Você destruiu o meu ovo!");
                    break; 
                        case opcao.atualizar:
                    Console.WriteLine(".............404");
                    break;
                default:
                    Console.WriteLine("Error 4o4\n" +
                        " item não encontrado");
                    break;
            }
         


            Console.ReadLine();

        }
    }
}
