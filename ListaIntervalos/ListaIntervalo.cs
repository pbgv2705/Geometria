using Intervalo;

namespace ListaIntervalos
{
    public class ListaIntervalo
    {
        
        public List<Interval> listInter;

        public Interval Interval { get; set; }
        public DateTime DataInicial { get; private set; }
        public DateTime DataFinal { get; private set; }

        public ListaIntervalo(List<Interval> listInter)
        {
            this.listInter = listInter;
        }
        public ListaIntervalo(List<Interval> listInter, Interval interval) : this (listInter)
        {
            this.Interval = interval;
        }

        public bool AddIntervalo(List<Interval> listinter, Interval interval)
        {
            bool interExiste = false;
            
            for (int i = 0; i < listInter.Count; i++)
            {
                interExiste = listInter[i].TemIntersecao(interval);
            }
            if (!interExiste)
                listInter.Add(interval);
            return interExiste; 
        }
        public void ImprimeIntervalo(List<Interval> listinter)
        {
            IEnumerable<Interval> sortedList = listInter.OrderBy(interval => interval.DataInicial).ToList();
            List<Interval> sortedlistInter = new List<Interval>();
            sortedlistInter = (List<Interval>)sortedList;

            string data = "";
            foreach (var item in sortedlistInter)
            {
                data = item.DataInicial.ToString() + " - " + item.DataFinal.ToString();
                Console.WriteLine(data);
            }
        }
    }
}
