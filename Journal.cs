using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Lab2
{
    internal class Journal : Literature, ICloneable, IBurnable
    {
        string series;
        int numberInSeries;

        public delegate void JournalEventHandler();
        public event JournalEventHandler OnBurn;

        public Journal(DateOnly publicDate, string author, string name, string series, int numberInSeries) :
            base(publicDate, author, name)
        {
            this.series = series;
            this.numberInSeries = numberInSeries;
        }

        public Journal(DateOnly publicDate, string author, string name, string series, int numberInSeries, bool readByJhonny) :
        base(publicDate, author, name)
        {
            base.IsReadByJhonny = readByJhonny;
            this.series = series;
            this.numberInSeries = numberInSeries;
        }

        public Journal getPreviousJournal()
        {
            return new Journal(PublicDate, Author, Name, series, numberInSeries);
        }

        override public void getReadByJhonny()
        {
            base.getReadByJhonny();
            Console.WriteLine($"Oh... it was a {series} journal number {numberInSeries}!");
        }

        public object Clone()
        {
            return new Journal(base.PublicDate, base.Author, base.Name, series, numberInSeries, true);
        }

        public void burnToAshes()
        {
            Console.WriteLine($"{numberInSeries} part of {series} burned to ashes! It is not readable anymore!");
            Author = "Illegible";
            Name = "Illegible";
            series = "Illegible";
            numberInSeries = 666;

            OnBurn?.Invoke();
        }
    }
}