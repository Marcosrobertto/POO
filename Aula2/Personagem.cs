using System;

namespace Aula2
{
    public class Personagem
    {
        public string nome;
        public int idade;
        public string armadura;
        public string iA = "Jarvis";


        public int vida = 100;
        public int Atacar1(){
            return 100;

        }
        public int Atacar2(){
            return 20;

        }
        public int Defender(int ataque){

            this.vida = this.vida - ataque;
            return this.vida = this.vida - ataque;

        }
        
    }
}