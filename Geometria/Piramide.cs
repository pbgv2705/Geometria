using Geometria.Exceptions;

namespace Geometria
{
    internal class Piramide
    {   
        private int n;
        public int N
        {
            get
            {
                return N;
            }
            set
            {
                if (value <= 0)
                {
                    throw new DomainException("A piramide deve ter ao menos 1 nivel");
                }
                else n = value;
            }
        }

        public Piramide(int n)
        {
            this.N = n;

        }

        public virtual void Desenha(int nLin)
        {
            int lactual, esp, aster, z;
            for (lactual = 1; lactual <= nLin; lactual++)  // Controlando salto de linhas
            {
                z = 0;
                for (esp = 0; esp < nLin - lactual; esp++)
                {
                    Console.Write(" ");
                }
                for (aster = 0; aster < (lactual * 2) - 1; aster++)
                {
                    if (aster >= lactual)
                    {
                        z += 1;
                        Console.Write(lactual - z);
                    }
                    else
                    {
                        Console.Write(aster + 1);
                    }
                }
                Console.WriteLine();
            }

        }
    }
}
