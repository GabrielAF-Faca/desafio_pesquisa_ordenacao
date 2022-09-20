using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafio
{
    internal class Aluno
    {

        private string nome;
        private string curso;

        public Aluno(string nome, string curso)
        {
            this.nome = nome;
            this.curso = curso;
        }   

        public string get_nome()
        {
            return nome;
        }

        public string get_curso()
        {
            return curso;
        }

    }
}
