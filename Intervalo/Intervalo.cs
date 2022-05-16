using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intervalo
{
    public class Interval
    {
        public DateTime DataInicial { get; private set; }
        public DateTime DataFinal { get; private set; }

        public Interval(DateTime dataInicial, DateTime dataFinal)
        {
            DataInicial = dataInicial;
            DataFinal = dataFinal;

            if (DataInicial > DataFinal)
            {
                throw new Exception("Data Inicial deve ser menor que a Data Final");
            }
        }
        public int Duracao
        {
            get {
                TimeSpan interval = DataFinal - DataInicial;
                return (int) interval.TotalDays; }
        }
        public bool TemIntersecao(Interval interval)
        {
            //(StartDate1 <= EndDate2) and (StartDate2 <= EndDate1)
            if (this.DataInicial <= interval.DataFinal && this.DataFinal >= interval.DataFinal)
                return true;
            else return false;
        }
        public override bool Equals(object? obj)
        {
            return obj is Interval interval &&
                this.DataInicial == interval.DataInicial &&
                this.DataFinal == interval.DataFinal;
            Console.WriteLine(DataFinal.Date);
        }

    }
}
