using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAtleta
{
    class Atleta
    {
        private string nome;
        private DateTime dataNascimento;
        private double altura;
        private double peso;
        private double imc;

        public string Nome
        {
            set
            {
                if(value != string.Empty)
                {
                    this.nome = value;
                }
                else
                {
                    throw new Exception("O nome deve ser obrigatoriamente preenchido!");
                }
            }
            get { return this.nome; }
        }

        public DateTime DataNascimento
        {
            set { this.dataNascimento = value; }
            get { return this.dataNascimento; }
        }

        public double Altura
        {
            set
            {
                if(value >= 1.00)
                {
                    this.altura = value;
                }
                else
                {
                    throw new Exception("A altura mínima deve ser de 1.00m!");
                }
            }
            get { return this.altura; }
        }

        public double Peso
        {
            set
            {
                if (value >= 1.00)
                {
                    this.peso = value;
                }
                else
                {
                    throw new Exception("O peso mínimo deve ser de 1.00Kg!");
                }
            }
            get { return this.peso; }
        }

        public double IMC
        {
            set
            {
                this.imc = peso / (altura * altura);
            }
            get { return this.imc; }
        }

        public string ImprimeDados()
        {
            return "\n\nNome: " + this.nome +
                   "\nData de Nascimento: " + this.dataNascimento.ToString("dd/MM/yyyy") +
                   "\nAltura: " + this.altura.ToString("0.00") + "m" +
                   "\nPeso: " + this.peso.ToString("00.0") + "Kg" +
                   "\n\nIMC: " + this.imc.ToString("00.0");
        }

        public int CalcularIdade()
        {
            return DateTime.Now.Year - this.dataNascimento.Year;
        }
    }
}
