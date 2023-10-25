using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace C_Lab2
{
    internal class Manuscript: Literature
    {
        string genre;
        string edition;
        bool nobeled;

        public delegate void ManuscriptEventHandler();
        public event ManuscriptEventHandler OnGiveNobel;

        public Manuscript(DateOnly publicDate, string author, string name, string genre, string edition) : 
            base(publicDate, author, name)
        {
            this.genre = genre;
            this.edition = edition;
            nobeled = false;
        }

        public void giveNobel()
        {
            nobeled = true;
            OnGiveNobel?.Invoke();
        }
        override public void getReadByJhonny()
        {
            base.getReadByJhonny();
            Console.WriteLine(string.Format("Oh... it was a {0} book ant it is {1}!", genre,
                                nobeled ? "nobeled piece of art" : "unadmitted piece of art"));
        }
    }
}
