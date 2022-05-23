using Geometria;
using Geometria.Exceptions;
using Triangulos;
using Poligonos;
using Intervalo;
using System.Globalization;
using System.Text.RegularExpressions;
using ListaIntervalos;

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
                        // Módulo Pirámides
                        Console.Write("Favor indicar número de niveles ");
                        int nivel = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine();
                        Piramide piramide = new Piramide(nivel);
                        piramide.Desenha(nivel);
                        break;
                    case 2:
                        // Módulo Vertice
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
                        // Módulo Triangulo
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
                        // Módulo Poligonos
                        bool fin = false;
                        int n = 0;

                        List<Vertice> lista = new List<Vertice>();

                        while (!fin)
                        {
                            n++;
                            Console.WriteLine("Dados do Polígono:");
                            Console.WriteLine($"Favor digite as coordenadas para o vertice {n}: ");
                            Console.Write("Digite o valor de x: ");
                            int xx = int.Parse(Console.ReadLine());
                            Console.Write("Digite o valor de y: ");
                            int yy = int.Parse(Console.ReadLine());
                            var v = new Vertice(xx, yy);
                            lista.Add(v);
                            Console.Write("Desea agregar otro vértice? (S/N) ");
                            string outro = Console.ReadLine();
                            if (outro == "N" || outro == "n")
                                fin = true;
                        }

                        var poligono = new Poligono(lista);

                        int xx1 = 0, yy1 = 0;

                        Console.WriteLine("Deseja Agregar (A) mais um vértice?: ");
                        string resp1 = Console.ReadLine();
                        if (resp1 == "A" || resp1 == "a")
                        {
                            Console.Write("Indique o eixo x: ");
                            xx1 = int.Parse(Console.ReadLine());
                            Console.Write("Indique o eixo y: ");
                            yy1 = int.Parse(Console.ReadLine());
                            var vv1 = new Vertice(xx1, yy1);

                            if (resp1 == "A" || resp1 == "a")
                            {
                                poligono.AddVertice(lista, vv1);
                            }
                        }

                        Console.WriteLine("Deseja Remover (R) mais um vértice?: ");
                        string resp2 = Console.ReadLine();
                        if (resp2 == "R" || resp2 == "r")
                        {
                            Console.Write("Indique o eixo x: ");
                            xx1 = int.Parse(Console.ReadLine());
                            Console.Write("Indique o eixo y: ");
                            yy1 = int.Parse(Console.ReadLine());
                            var vv2 = new Vertice(xx1, yy1);
                            if (resp1 == "R" || resp1 == "r")
                            {
                                poligono.RemoveVertice(lista, vv2);
                            }

                        }
                        Console.WriteLine();
                        Console.WriteLine("O perímetro do polígono é: " + poligono.Perimetro(lista));
                        Console.WriteLine($"O polígono tem {poligono.Nro_Vertices} vértices");
                        break;

                    case 5:
                        // Intervalo
                        DateTime date1 = new DateTime(2022, 04, 21, 8, 0, 15);
                        DateTime date2 = new DateTime(2022, 06, 30, 13, 30, 30);
                        var inter1 = new Interval(date1, date2);

                        Console.WriteLine("Duração: " + (int)inter1.Duracao);

                        DateTime date3 = new DateTime(2022, 01, 15, 8, 20, 15);
                        DateTime date4 = new DateTime(2022, 02, 19, 15, 45, 30);

                        // Para testar se tem interseção ou são iguais:
                        //DateTime date3 = new DateTime(2022, 04, 21, 8, 0, 15);
                        //DateTime date4 = new DateTime(2022, 06, 30, 13, 30, 30);


                        var inter2 = new Interval(date3, date4);

                        Console.WriteLine("Intervalo 1: " + date1 + "," + date2);
                        Console.WriteLine("Intervalo 2: " + date3 + "," + date4);
                        Console.WriteLine("Os intervalos tem interseção?: " + inter1.TemIntersecao(inter2));
                        Console.WriteLine("Os intervalos são iguais?: " + inter1.Equals(inter2));
                        break;

                    case 6:
                        // Modulo ListaIntervalo
                        List<Interval> listInter = new List<Interval>();
                        DateTime date5 = new DateTime(2022, 04, 21, 8, 0, 15);
                        DateTime date6 = new DateTime(2022, 06, 30, 13, 30, 30);
                        var inter3 = new Interval(date5, date6);
                        listInter.Add(inter3);
                        DateTime date7 = new DateTime(2022, 02, 15, 8, 0, 15);
                        DateTime date8 = new DateTime(2022, 03, 27, 0, 30, 30);
                        var inter4 = new Interval(date7, date8);
                        listInter.Add(inter4);
                        DateTime date9 = new DateTime(2022, 07, 05, 0, 0, 0);
                        DateTime date10 = new DateTime(2022, 08, 02, 0, 0, 0);
                        var inter5 = new Interval(date9, date10);
                        listInter.Add(inter5);

                        ListaIntervalo lIntervalo = new ListaIntervalo(listInter);
                        Console.WriteLine();
                        Console.WriteLine("-------------------------------------------------");
                        Console.Write("Deseja agregar um novo intervalo? (S/N): ");
                        string str = Console.ReadLine();
                        if (str == "S" || str == "s" || str == "N" || str == "n")
                        {
                            Console.Write("Favor indicar a data de inicio: ");
                            DateTime dataA = DateTime.Parse(Console.ReadLine());
                            Console.Write("Favor indicar a data de fin: ");
                            DateTime dataB = DateTime.Parse(Console.ReadLine());
                            var inter6 = new Interval(dataA, dataB);

                            if (lIntervalo.AddIntervalo(listInter, inter6))
                            {
                                Console.WriteLine("O novo intervalo não pode ser adicionado. Tem interseção");
                            }
                            else
                                Console.WriteLine("O novo intervalo foi adicionado com sucesso");
                        }
                        Console.WriteLine();
                        Console.WriteLine("---------------------------------------------------------");
                        Console.WriteLine("Lista ordenada de Intervalos:");
                        Console.WriteLine();

                        lIntervalo.ImprimeIntervalo(listInter);
                        break;

                    case 7:
                        // Módulo Cliente
                        bool ok = false;
                        string nome = "", data_str = "", edoCivil = "";
                        long cpf = 0;
                        double renda = 0.0f;
                        int depend = 0;

                        Console.WriteLine("Bem-vindos ao Módulo de Clientes!");
                        Console.WriteLine("==========================================================");
                        Console.WriteLine("Favor indique os seguintes dados:");
                        while (!ok)
                        {
                            Console.Write("Nome: ");
                            nome = Console.ReadLine();
                            if (nome == null || nome.Length >= 5)
                                ok = true;
                            else Console.WriteLine("O nome deve ter ao menos 5 letras");
                        }
                        ok = false;
                        while (!ok)
                        {
                            Console.Write("CPF: ");
                            cpf = long.Parse(Console.ReadLine());
                            int digitos = (int)Math.Floor(Math.Log10(cpf) + 1);
                            if (digitos != 11)
                                Console.WriteLine("O CPF deve ter 11 digitos");
                            else ok = true;
                        }
                        ok = false;
                        while (!ok)
                        {
                            Console.Write("Data de Nascimento: ");
                            data_str = Console.ReadLine();
                            string pattern = "dd/MM/yyyy";
                            DateTime data;
                            // Formato?????
                            if (DateTime.TryParseExact(data_str, pattern, null,
                                                               DateTimeStyles.None, out data))
                                ok = true;
                            else
                                Console.WriteLine("Favor indicar DD/MM/YYYY",
                                                  data_str);
                            // Edad mínima
                            if (DateTime.Today.Year - data.Year >= 18 && ok == true)
                                ok = true;
                            else if (DateTime.Today.Year - data.Year < 18)
                            {
                                Console.WriteLine("O cliente deve ter pelo menos 18 anos");
                                ok = false;
                            }
                        }
                        ok = false;
                        while (!ok)
                        {
                            Console.Write("Renda Mensal: ");
                            renda = double.Parse(Console.ReadLine());
                            Regex rendex = new System.Text.RegularExpressions.Regex(@"^(\d|-)?(\d|.)*\,?\d*$");
                            // No funciona 
                            if (rendex.IsMatch(renda.ToString()))
                            {
                                ok = true;
                            }
                            else
                                Console.WriteLine("Favor indicar vírgula e 2 casas decimais");
                        }
                        ok = false;
                        while (!ok)
                        {
                            Console.Write("Estado Civil (C/S/V/D): ");
                            edoCivil = Console.ReadLine();
                            // Regex rx = new System.Text.RegularExpressions.Regex(@"^([c][s][v][d]).IgnoreCase{1}$");
                            if (edoCivil == "c" || edoCivil == "s" || edoCivil == "d" || edoCivil == "v" ||
                                edoCivil == "C" || edoCivil == "S" || edoCivil == "D" || edoCivil == "V")
                                ok = true;
                            else
                                Console.WriteLine("Formato incorrecto. Favor indicar (C/S/V/D): ");
                        }
                        ok = false;
                        while (!ok)
                        {
                            Console.Write("Dependentes: ");
                            depend = int.Parse(Console.ReadLine());
                            if (depend < 0 || depend > 10)
                            {
                                Console.WriteLine("Dependentes não podem ser menor que 0 nem maior que 10");
                            }
                            else
                                ok = true;
                        }

                        Console.WriteLine();
                        Console.WriteLine("*************************************************");
                        Console.WriteLine("DADOS DO CLIENTE:");
                        Console.WriteLine("Nome: " + nome);
                        Console.WriteLine("CPF: " + cpf);
                        Console.WriteLine("Data Nascimento: " + data_str);
                        Console.WriteLine("Renda: " + renda.ToString("F2"));
                        Console.WriteLine("Estado Civil: " + edoCivil);
                        Console.WriteLine("Dependentes: " + depend);
                        Console.WriteLine("*************************************************");

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
