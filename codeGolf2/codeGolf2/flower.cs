using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codeGolf2
{
    class Flower
    {
        int line;
        int column;
        bool faded;
        bool infected;

        public Flower(int ligne, int colonne, bool faded, bool infected)
        {
            this.line = ligne;
            this.column = colonne;
            this.faded = faded;
            this.infected = infected;
        }
        public int Line
        {
            get { return line; }
        }
        public int Column
        {
            get { return column; }
        }
        public bool Faded
        {
            get { return faded; }
            set { faded = value; }
        }
        public bool Infected
        {
            get { return infected; }
            set { infected = value; }
        }
        //Méthodes
        public void Clone(Flower myflower)
        {
            line = myflower.line;
            column = myflower.column;
            faded = myflower.faded;
            infected = myflower.infected;
        }
        public void Display()
        {
            if (faded && !infected)
                Console.Write('F');
            else if(infected && !faded)
                Console.Write('I');
            else if (!faded && !infected)
                Console.Write('H');
            else
                Console.Write('O');
        }
    }   
}
