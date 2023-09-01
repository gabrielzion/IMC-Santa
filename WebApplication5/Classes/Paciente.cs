using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Classes
{
    public class Paciente : Object
    {

       


        public string codigo { get; } 
        public string nome { get; }
        public char sexo { get; }
        public IMC imc { get; set; }

        public Paciente(String codigo, String nome, char sexo, IMC imc)
        {
             

          

            this.codigo = codigo;
            this.nome = nome;   
            this.sexo = sexo;   
            this.imc = imc;
        }

        public override string ToString()
        {
            return String.Concat(
               "Código: " , codigo , ", ",
               "Nome: ", nome, ", ",
               "Sexo: ", sexo, ", ",
               "Peso: ", imc.Peso, ", ",
               "Altura: ", imc.Altura, ", ",
               "IMC: ", imc.diagnostico()
                );  
        }

    }
}