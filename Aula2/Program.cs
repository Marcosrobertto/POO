using System;

namespace Aula2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instanciando objeto

            Personagem P1 = new Personagem();
            P1.nome = "Marcos";
            P1.idade = 17;
            P1.armadura = "Face-Shield";
            P1.iA = "Pure skill";

            Personagem P2 = new Personagem();
            P2.nome = "Tony Stark";
            P2.idade = 35;
            P2.armadura = "MK3";

            Console.Clear();
            Console.WriteLine($"Partidada {P1.nome} VS {P2.nome}");
            Console.WriteLine($"Jogador 1 Armadura: = {P1.armadura} || Jogador 2 Armadura: {P2.armadura}");
            Console.WriteLine($"Jogador 1 IA: = {P1.iA} || Jogador 2 IA: {P2.iA}");

            // Iniciando a luta

            int vidaDoJogador2 = P2.Defender(P2.Atacar1());
            if(vidaDoJogador2 <= 0){
                Console.WriteLine($"O jogador morreu");
            }else{
                Console.WriteLine($"Jogador 2 depois do ataque ficou com {P2.vida}");
            }


            
        }
    }
}
