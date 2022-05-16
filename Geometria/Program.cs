using Geometria;
using Geometria.Exceptions;
using Triangulos;
using Poligonos;
using Intervalo;

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
                        if (vertice1.Equals(vertice2))
                        {
                            Console.WriteLine("Os vertices são iguais");
                        }
                        else
                            Console.WriteLine("Os vertices são diferentes");

                        break;
                    case 3:
                        // Triangulo

                        var v1 = new Vertice(2, 4);
                        var v2 = new Vertice(-1, 1);
                        var v3 = new Vertice(4, -1);

                        var triangul1 = new Triangulo(v1, v2, v3);

                        var v12 = new Vertice(-3, 4);
                        var v22 = new Vertice(0, -2);
                        var v32 = new Vertice(2, 2);


                        var triangul2 = new Triangulo(v12, v22, v32);

                        TipoTriangulo tipo = triangul1.Tipo;

                        Console.WriteLine();
                        Console.WriteLine("=========================================================");
                        Console.WriteLine("Perimetro: " + triangul1.Perimetro);
                        Console.WriteLine("Area: " + triangul1.Area);
                        Console.WriteLine(" Os triangulos são iguais?: " + triangul1.Equals(triangul2));
                        Console.WriteLine("=========================================================");
                       
                        break;
                    case 4:
                        // Poligonos
                        var v4 = new Vertice(2, 4);
                        var v5 = new Vertice(-1, 1);
                        var v6 = new Vertice(4, -1);

                       // var polig = new Poligono(v4, v5, v6);


                        break;
                    case 5:
                        // Intervalo
                        DateTime date1 = new DateTime(2022, 04, 21, 8, 0, 15);
                        DateTime date2 = new DateTime(2022, 06, 30, 13, 30, 30);
                        var inter1 = new Interval(date1, date2);
                        
                        Console.WriteLine("Duración: " + (int)inter1.Duracao);

                        DateTime date3 = new DateTime(2022, 05, 15,8, 20, 15);
                        DateTime date4 = new DateTime(2022, 06, 19, 15, 45, 30);
                        var inter2 = new Interval(date3, date4);
                        
                        Console.WriteLine("Intervalo 1: " + date1 + "," + date2);
                        Console.WriteLine("Intervalo 2: " + date3 + "," + date4);
                        Console.WriteLine("Los intervalos se intersectam?: " + inter1.TemIntersecao(inter2));

                       

                        //var in1 = new Intervalo(date1, date2);

                        //Console.WriteLine("   {0,-35} {1,20}", "Value of Days Component:", intervalo.Days);
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
