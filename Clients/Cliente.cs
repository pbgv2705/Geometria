using System.Text.RegularExpressions;

namespace Cliente
{
    internal class Cliente
    {
        public string Nome { get; set; }

        public long CPF { get; set; }
        public DateTime DataNascim { get; set; }
        public double RendaMensal { get; set; }
        public char EdoCivil { get; set; }
        public int Dependentes { get; set; }

        public Cliente(string nome, long cPF, DateTime dataNascim, double rendaMensal, char edoCivil, int dependentes)
        {
            Nome = nome;
            CPF = cPF;
            DataNascim = dataNascim;
            RendaMensal = rendaMensal;
            EdoCivil = edoCivil;
            Dependentes = dependentes;
        }

        //public static bool WithRegEx(string stringToVerify)
        //{
        //    return Regex.IsMatch(stringToVerify, @"^[a-zA-Z]+$");
        //}
    }
}
