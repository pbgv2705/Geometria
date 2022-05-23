namespace Geometria
{
    public class Vertice
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Vertice(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Vertice()
        {
        }

        public double Distance(Vertice vertice2)
        {
            double sum_x = 0, sum_y = 0, distance = 0;
            sum_x = Math.Pow(this.X - vertice2.X, 2);
            sum_y = Math.Pow(this.Y - vertice2.Y, 2);
            distance = Math.Sqrt(sum_x + sum_y);
            return distance;

            throw new NotImplementedException();
        }
        public void Move(Vertice vertice2)
        {
            double novo_x = 0, novo_y = 0;
            novo_x = this.X + vertice2.X;
            novo_y = this.Y + vertice2.Y;
            Console.WriteLine("O novo ponto é: " + "(" + novo_x + "," + novo_y + ")");
        }

        public override bool Equals(object? obj)
        {
            return obj is Vertice vertice &&
                this.X == vertice.X &&
                this.Y == vertice.Y;
        }

        public static implicit operator Vertice(double v)
        {
            throw new NotImplementedException();
        }
    }
}
