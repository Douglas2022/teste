using System;
using System.Globalization;

namespace Conta
{
    class Empregado
    {
        public int Indentidade { get; set; }
        public string Nome { get; set; }
        public double Salario { get; set; }

        public Empregado(int indentidade,string nome,double salario)
        {
            Indentidade = indentidade;
            Nome = nome;
            Salario = salario;
        }
        public void aumentar(double porcetagem)
        {
            Salario += Salario * porcetagem / 100.0;
        }
        public override string ToString()
        {
            return Indentidade
                + ","
                + Nome
                + ","
                + Salario.ToString("F2", CultureInfo.InstalledUICulture);

        }




    }








}



