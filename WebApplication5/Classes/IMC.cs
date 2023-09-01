using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication5.Classes
{
    public class IMC
    {
        private float peso;
        private float altura;
        private char sexo;
        private float imc;

        public float Peso
        {
            get { return peso; }    
        }
        public float Altura
        {
            get { return altura; }  
        }
        public float Imc
        {
            get { return imc; } 
        }

        public String diagnostico()
        {
            if (imc >= 40) return "Obesidade III";
            if (imc >= 35) return "Obesidade II";
            if (imc >= 30) return "Obesidade I";
            if (imc >= 25) return "Sobrepeso";
            if (imc >= 18.5) return "Normal";
            return "Abaixo do peso";
        }
        public IMC(float peso, float altura, char sexo)
        {
            this.peso = peso;
            this.altura = altura;
            this.sexo = sexo;   

            this.imc = peso / (altura * altura) * (sexo=='F'?0.95F:1F);
        }
    }
}