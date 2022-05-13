using Geometria;

namespace Triangulos
{
    public class Triangulo
    {
        public double V1 { get; private set; }
        public double V2 { get; private set; }
        public double V3 { get; private set; }
        private readonly double ladoA;
        private readonly double ladoB;
        private readonly double ladoC;

        public Triangulo()
        {
        }

        public Triangulo(double v1, double v2, double v3)
        {
            V1 = v1;
            V2 = v2;
            V3 = v3;
        }

        public double Perimetro(Vertice vertice1, Vertice vertice2, Vertice vertice3){

            double sumLados = 0, dist1 = 0, dist2 = 0, dist3 = 0, s = 0;
            dist1 = vertice1.Distance(vertice2);
            dist2 = vertice2.Distance(vertice3);
            dist3 = vertice1.Distance(vertice3);
            sumLados = dist1 + dist2 + dist3;

            s = sumLados / 2;
            Area(dist1, dist2, dist3, s);

            return sumLados;
        }
        public void Area(double d1, double d2, double d3, double s1)
        {
            double area = Math.Sqrt(s1 * (s1 - d1) * (s1 - d2) * (s1 - d3));
            Console.WriteLine("Area do Triangulo é : " + area);
        }
       // public void Semelhantes()
    }
}
