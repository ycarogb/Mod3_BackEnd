using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4_CodeLAB
{

    class Heroi
    {

        public string nome { get; set; }
        public int experiencia { get; set; }
        public int nivel { get; set; }
        public int vida { get; set; }
        public int ataqueBase { get; set; }


        public Heroi(string nome)
        {
            this.nome = nome;
            this.experiencia = 0;
            this.nivel = 1;
            this.vida = 10;
            Random ataqueBase = new Random();
            this.ataqueBase = ataqueBase.Next(1,10);
        }

        public int ganhaXP(int experiencia)
        {
            return this.experiencia += experiencia;
        }
        
    }
}
