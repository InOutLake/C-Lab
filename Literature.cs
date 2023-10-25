using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab2
{
    internal class Literature: IComparable
    {
        DateOnly publicDate;
        string author;
        string name;
        bool isReadByJhonny;

        public DateOnly PublicDate { get => publicDate; set => publicDate = value; }
        public string Author { get => author; set => author = value; }
        public string Name { get => name; set => name = value; }
        public bool IsReadByJhonny { get => isReadByJhonny; set => isReadByJhonny = value; }

        public Literature(DateOnly publicDate, string author, string name)
        {
            this.PublicDate = publicDate;
            this.Author = author;
            this.Name = name;
            IsReadByJhonny = false;
        }

        virtual public void getReadByJhonny()
        {
            Console.WriteLine($"Jhonny has read something {(IsReadByJhonny ? "again" : "")}...");
            IsReadByJhonny = true;
        }

        override public string ToString()
        {
            return $"{Name}, {Author}, {PublicDate}";
        }

        public int CompareTo(object? obj)
        {
            return this.ToString().CompareTo(obj.ToString());
        }
    }
}
