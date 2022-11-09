using System;

namespace ATM 
{
    class Program
    {
        static void Main(string[] args)
        {
            string cartao, senha;
            int saldo, cartaoInt, senhaInt;
            saldo = 1000;

            Console.WriteLine("Bom dia\n Bem vindo ao banco Brasil 2022\n Pressione para prosseguir");
            Console.ReadKey();
            Console.Write("Digite os ultimos numeros do seu cartão: ");
            cartao = Console.ReadLine();
            cartaoInt = Convert.ToInt32(cartao);

            if (cartaoInt!=3883)
            {
                Console.WriteLine("Seu cartão não foi encontrado...");
                return;
            } else
            {

                Console.Write("Parabens Senhor 34, Você poderia informar sua senha?");
                senha = Console.ReadLine();
                senhaInt = Convert.ToInt32(senha);
                Console.Write(senhaInt);




            }
        }
    }


    /*
    1- Checar Cartao
    2- Checar senha; se correto ir pro 3; caso errado reiniciar
    3- mostrar saldo em conta 
    4- Fazer operações; como retirada; limitar a 3 por vez
    5- Fazer o saldo ser em tempo real

     
     
     
     */




}