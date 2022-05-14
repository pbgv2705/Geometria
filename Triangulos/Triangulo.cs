using Geometria;

namespace Triangulos
{
    public class Triangulo
    {
        public Vertice V1 { get; private set; }
        public Vertice V2 { get; private set; }
        public Vertice V3 { get; private set; }
        private readonly double ladoA;
        private readonly double ladoB;
        private readonly double ladoC;
       
        public Triangulo()
        {
        }

        public Triangulo(Vertice v1, Vertice v2, Vertice v3)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
            ladoA = V1.Distance(V2);
            ladoB = V2.Distance(V3);
            ladoC = V1.Distance(V3);

            if ((ladoA + ladoB <= ladoC) || (ladoA + ladoC <= ladoB) ||
                    (ladoB + ladoC <= ladoA))
                throw new Exception("Os vertices não formam um triangulo");

        }
        public override bool Equals(object? obj)
        {
            return obj is Triangulo triangulo &&
                ladoA == triangulo.ladoA &&
                ladoB == triangulo.ladoB &&
                ladoC == triangulo.ladoC;
        }

        public double Perimetro
        {
            get
            {
                
                return  ladoA + ladoB + ladoC;
            }

        }
        
         public TipoTriangulo Tipo
        {
            get
            {
                if ((ladoA == ladoB) && (ladoA == ladoC) && (ladoB == ladoC))
                    return TipoTriangulo.EQUILATERO;
                else if (ladoA != ladoB && ladoB != ladoC && ladoA != ladoC)
                    return TipoTriangulo.ISOSCELES;
                else
                    return TipoTriangulo.ESCALENO;
            }
        }
        public double Area {
            get
            {
                double s = (ladoA + ladoB + ladoC) / 2;
                return Math.Sqrt(s * (s - ladoA) * (s - ladoB) * (s - ladoC));
            }   

         }

       

    }
}
