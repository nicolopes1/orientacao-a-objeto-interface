using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using aula_16_orientacao_a_objeto_interface;
using Classes;

namespace Classes
{
    public class Cliente : Base
    {
        public Cliente(string nome, string telefone, string cpf)
        {
            this.Nome = nome;
            this.Telefone = telefone;
            this.CPF = cpf;

        }
        public Cliente()
        {
        }
    }
}
