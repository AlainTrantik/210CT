using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;
namespace codeGolf2
{
    class Plain
    {
        Flower[,] tab;
        public Plain(int length)
        {
            tab = new Flower[length, length];
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    tab[i, j] = new Flower(i, j, false, false);
                }
            }
        }
        public Plain(string file)
        {
            if ((!File.Exists(file)) || (file == null) || (file.Length == 0))
            {
                Console.WriteLine("File error");
                Thread.Sleep(5000);
                Environment.Exit(0);

            }
            else
            {
                string[] lines = File.ReadAllLines(file);
                tab = new Flower[lines.Length, lines.Length];
                for (int i = 0; i < tab.GetLength(0); i++)
                {
                    for (int j = 0; j < tab.GetLength(1); j++)
                    {
                        if (lines[i][j] == 'I')
                            tab[i, j] = new Flower(i, j, false,true);
                        else if (lines[i][j] == 'F')
                            tab[i,j] = new Flower(i, j, true, false);
                        else
                            tab[i, j] = new Flower(i, j, false, false);
                    }
                }
            }
        }
        public void Display_Plain()
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j].Display();
                }
                Console.WriteLine();
            }
        }
        //Neighboors of the current flower
        public Flower North(Flower myflow)
        {
            if (myflow.Line == 0) //Traiter le cas ou la cellule est à la 1ere ligne
                return tab[tab.GetLength(0) - 1, myflow.Column];
            else
                return tab[myflow.Line - 1, myflow.Column];
        }
        public Flower South(Flower myflow)
        {
            if (myflow.Line == tab.GetLength(0) - 1)
                return tab[0, myflow.Column];
            else
                return tab[myflow.Line + 1, myflow.Column];
        }
        public Flower East(Flower myflow)
        {
            if (myflow.Column == 0)
                return tab[myflow.Line, tab.GetLength(1) - 1];
            else
                return tab[myflow.Line, myflow.Column - 1];
        }
        public Flower West(Flower myflow)
        {
            if (myflow.Column == tab.GetLength(1) - 1)
                return tab[myflow.Line, 0];
            else
                return tab[myflow.Line, myflow.Column + 1];
        }

        public Flower Rules(Flower myflow)  //Rules
        {
            Flower f = new Flower(myflow.Line, myflow.Column, false, false);
            if (myflow.Infected)
            {
                f.Faded = true;
                if (!North(myflow).Infected)
                    North(f).Infected = true;
                if (!South(myflow).Infected)
                    South(f).Infected = true;
                if (!West(myflow).Infected)
                    West(f).Infected = true;
                if (!East(myflow).Infected)
                    East(f).Infected = true;
            }
            if (myflow.Faded)
            {
                f.Faded = false;
            }
            return f;
        }
        public void Clone(Plain plainC) //Copie une grille dans une autre
        {
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tab[i, j].Clone(plainC.tab[i, j]); //utilise la fonction Clone de la classe cellule
                }
            }
        }
        public Plain update() //Retourne une nouvelle grille après y avoir appliqué les règles
        {
            Plain tempPlain = new Plain(tab.GetLength(0));
            for (int i = 0; i < tab.GetLength(0); i++)
            {
                for (int j = 0; j < tab.GetLength(1); j++)
                {
                    tempPlain.tab[i, j] = new Flower((Rules(tab[i, j])).Line, (Rules(tab[i, j])).Column, (Rules(tab[i, j])).Faded, (Rules(tab[i, j])).Infected);
                }
            }
            return tempPlain;
        }
    }
}