using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace C_Lab2
{
    internal class SchoolBook : Literature, IBurnable, ICloneable
    {
        string subject;
        int classNumber;

        public SchoolBook(DateOnly publicDate, string author, string name, string subject, int classNumber) :
            base(publicDate, author, name)
        {
            this.subject = subject;
            this.classNumber = classNumber;
        }

        public SchoolBook(DateOnly publicDate, string author, string name, string subject, int classNumber, bool readByJhonny) :
        base(publicDate, author, name)
        {
            base.IsReadByJhonny = readByJhonny;
            this.subject = subject;
            this.classNumber = classNumber;
        }

        override public void getReadByJhonny()
        {
            base.getReadByJhonny();
            Console.WriteLine($"Oh... it was a {subject} school book of {classNumber} grade! His wisdom has grown!");
        }

        void IBurnable.burnToAshes()
        {
            Console.WriteLine($"{subject} schoolbook of {classNumber} class burned to ashes! It is not readable anymore!");
            Author = "Illegible";
            Name = "Illegible";
            subject = "Illegible";
            classNumber = 666;
        }

        public object Clone()
        {
            return new SchoolBook(PublicDate, Author, Name, subject, classNumber, true);
        }
    }
}