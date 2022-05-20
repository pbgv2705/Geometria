using Geometria;

namespace Poligonos
{
    public class Poligono
    {
        private readonly List<Poligono> listaVertices;

        //public static List<Vertice> Vertices = new List<Vertice>()
        //{
        //public Vertice V1 { get; private set; }
        //public Vertice V2 { get; private set; }
        //public Vertice V3 { get; private set; }
        //public List<Poligono> listaVertices;

        public Poligono(List<Poligono> listaVertices)
        {
            if (listaVertices.Count < 3)
            {
                throw new Exception("O poligono deve ter ao menos 3 vertices");
            }
        }
        public int Nro_Vertices
        {
            get
            {
                int n = 0;
                foreach (Poligono poligono in listaVertices)
                {
                    n++;
                }
                return listaVertices.Count;
            }
        }
        public Poligono Vertice()
        {
            throw new NotImplementedException();
        }

        public bool AddVertice(List<Poligono> listaVertices)
        {
            List<Poligono> lista1 = listaVertices.FindAll(delegate (Poligono p) { return p == Vertice(); });
            if (lista1.Count == 0)
                listaVertices.Add(Vertice());
            else
                throw new Exception("O vertice ja existe");
            //
            return true;
            
        }

        public bool RemoveVertice(List<Poligono> listaVertices)
        {
            listaVertices.Remove(Vertice());
            if (listaVertices.Count < 3)
            {
                throw new Exception("O poligono ficou com menos de 3 vértices");
            }
            
            return true;
        }
        //public double Perimetro (List<Poligono> listaVertices)
        //{
        //    double[] lado = new double[listaVertices.Count];
        //    foreach (var item in listaVertices)
        //    {

        //    }
        //}
        
	

	}
     
}
    