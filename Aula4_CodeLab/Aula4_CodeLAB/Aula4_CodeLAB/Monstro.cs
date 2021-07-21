using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula4_CodeLAB
{
    class Monstro
    {
        public string nome { get; set;}
        public int vida { get; set;}
        public int experiencia { get; set;}
        public int ataque { get; set;}

        public Monstro(string nome, int vida, int experiencia, int ataque)
        {
            this.nome = nome;
            this.vida = vida;
            this.experiencia = experiencia;
            this.ataque = ataque;

        }
    }
}
