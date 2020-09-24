using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoMartin
{
    class Pessoas
    {
        private String id;
        private String nome;
        private int idade;
        private String email;
        private float peso;
        private float altura;

        public String ID
        {
            get { return this.id; }
            set { this.id = value; }
        }


        public String Nome
        {
            get { return this.nome; }
            set { this.nome = value; }
        }


        public int Idade
        {
            get { return this.idade; }
            set { this.idade = value; }
        }

        public String Email
        {
            get { return this.email; }
            set { this.email = value; }
        }

        public float Peso
        {
            get { return this.peso; }
            set { this.peso = value; }

        }

        public float Altura
        {
            get { return this.altura; }
            set { this.altura = value; }
        }

        public Pessoas()
        {
            id = string.Empty;
            nome = string.Empty;
            idade = 0;
            email = string.Empty;
            peso = 0;
            altura = 0;
        }

        public Pessoas(String name, int years, String mail, float weight, float height)
        {
            nome = name;
            idade = years;
            email = mail;
            peso = weight;
            altura = height;

        }
    }
}


