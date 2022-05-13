using Geometria;
using Geometria.Exceptions;
using Triangulos;

namespace ProjetoGeometria
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Sistema de Geometria");

            try
            {
                Console.WriteLine("Favor indicar qual processo deseja realizar: ");
                Console.WriteLine("Desenho de Piramide ................ 1");
                Console.WriteLine("Trabalhar com Vertices ............. 2");
                Console.WriteLine("Trabalhar com Triangulos ........... 3");
                Console.WriteLine("Trabalhar com Poligonos ............ 4");
                Console.WriteLine("Trabalhar com Intervalos ........... 5");
                Console.WriteLine("Trabalhar com ListaIntervalo ....... 6");
                Console.WriteLine("Cadastro de Clientes ............... 7");
                Console.Write("Processo a realizar: ");
                int sw = int.Parse(Console.ReadLine());

                switch (sw)
                {
                    case 1:
                        Console.Write("Favor indicar número de niveles ");
                        int nivel = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Piramide piramide = new Piramide(nivel);
                        piramide.Desenha(nivel);
                        break;
                    case 2:
                        // Vertice
                        double dist_euclid = 0;

                        Console.WriteLine("Favor indicar eixo x1: ");
                        double x1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Favor indicar eixo y1: ");
                        double y1 = double.Parse(Console.ReadLine());

                        Vertice vertice1 = new Vertice(x1, y1);

                        Console.WriteLine("Favor indicar eixo x2: ");
                        double x2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Favor indicar eixo y2: ");
                        double y2 = double.Parse(Console.ReadLine());

                        Vertice vertice2 = new Vertice(x2, y2);

                        dist_euclid = vertice1.Distance(vertice2);
                        Console.WriteLine("Distancia = " + dist_euclid);
                        vertice1.Move(vertice2);
                        vertice1.Equals(vertice2);
                        break;
                    case 3:
                        // Triangulo
                        Console.WriteLine("Favor indicar eixo x1: ");
                        double xx1 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Favor indicar eixo y1: ");
                        double yy1 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Favor indicar eixo x2: ");
                        double xx2 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Favor indicar eixo y2: ");
                        double yy2 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Favor indicar eixo x3: ");
                        double xx3 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Favor indicar eixo y3: ");
                        double yy3 = double.Parse(Console.ReadLine());

                        Vertice vert1 = new Vertice(xx1, yy1);
                        Vertice vert2 = new Vertice(xx2, yy2);
                        Vertice vert3 = new Vertice(xx3, yy3);

                        Triangulo triangul1 = new();
                        double perim = triangul1.Perimetro(vert1, vert2, vert3);
                        Console.WriteLine("Perimetro = " + perim);

                        Console.WriteLine("Favor indicar eixo x1: ");
                        double xx12 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Favor indicar eixo y1: ");
                        double yy12 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Favor indicar eixo x2: ");
                        double xx22 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Favor indicar eixo y2: ");
                        double yy22 = double.Parse(Console.ReadLine());

                        Console.WriteLine("Favor indicar eixo x3: ");
                        double xx32 = double.Parse(Console.ReadLine());
                        Console.WriteLine("Favor indicar eixo y3: ");
                        double yy32 = double.Parse(Console.ReadLine());

                        Triangulo triangul2 = new();
                        Vertice vert12 = new Vertice(xx12, yy12);
                        Vertice vert22 = new Vertice(xx22, yy22);
                        Vertice vert32 = new Vertice(xx32, yy32);

                        //double perim2 = triangul2.Perimetro(vert1, vert2, vert3);
                        //Console.WriteLine("Perimetro = " + perim);




                        break;
                    case 4:
                        // Poligonos
                        break;
                    case 5:
                        // Intervalo
                        break;
                    case 6:
                        // ListaIntervalo
                        break;
                    case 7:
                        // Cliente
                        break;
                    default:
                        break;
                }

            }
            catch (DomainException e)
            {
                Console.WriteLine("Error en la piramide " + e.Message);
            }
        }
    }
}
