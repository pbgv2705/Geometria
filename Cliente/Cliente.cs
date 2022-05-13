
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
        public void Imprime()
        {
            string str = Nome.Length.ToString();
            if (Nome.Length < 5)
            {
                throw new DomainException("O nome deve ter ao menos 5 carateres");

            }
        }

    }
}
