using Geometria;

namespace Poligonos
{
    public class Poligono
    {
        private readonly List<Vertice> listaVertices;
        public Vertice V1 { get; set; }

        public Poligono(List<Vertice> listaVertices)
        {
            this.listaVertices = listaVertices;
            if (listaVertices.Count < 3)
            {
                throw new Exception("O poligono deve ter ao menos 3 vertices");
            }
        }
        public Poligono(List<Vertice> listaVertices, Vertice vertice) : this(listaVertices)
        {
            V1 = vertice;
        }

        public int Nro_Vertices
        {
            get
            {
                return listaVertices.Count;
            }
        }
        public Poligono Vertice()
        {
            throw new NotImplementedException();
        }

        public bool AddVertice(List<Vertice> listaVertices, Vertice vertice)
        {
            bool verticeExiste;
            verticeExiste = listaVertices.Contains(vertice);
            if (!verticeExiste)
            {
                listaVertices.Add(vertice);
                return true;
            }
            else
            {
                throw new Exception("O vertice ja existe");
                return false;
            }

        }

        public bool RemoveVertice(List<Vertice> listaVertices, Vertice vertice)
        {
            listaVertices.Remove(vertice);
            if (listaVertices.Count < 3)
            {
                throw new Exception("O poligono ficou com menos de 3 vértices");
            }

            return true;
        }
        public double Perimetro(List<Vertice> listaVertices)
        {
            double soma = 0;
            for (int i = 0; i < (listaVertices.Count - 1); i++)
            {
                soma += listaVertices[i].Distance(listaVertices[i + 1]);
            }
            soma += listaVertices[0].Distance(listaVertices[listaVertices.Count - 1]);
            return soma;
        }
    }

}
