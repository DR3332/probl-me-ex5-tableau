using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problème_ex5_tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            Le programme doit permettre de saisir un vecteur d'entiers de n cases (il faut saisir la taille du vecteur au
            préalable) puis de saisir une valeur à chercher.
            On part du principe que le vecteur est saisi dans l'ordre.
            La recherche doit être dichotomique.
            Un message doit préciser si la valeur a été trouvée ou non. Dans le cas où elle a été trouvée, il faut préciser
            la position dans le vecteur.
            On ne s'inquiètera pas du problème lié à une saisie erronée au niveau du type d'une variable.*/

            Console.Write("Veuillez saisir la taille du vecteur : ");
            int[] vec = new int[int.Parse(Console.ReadLine())];

            for (int a = 0; a < vec.Length; a++)
            {
                Console.Write("Veuillez remplir le vecteur, valeur n° " + (a + 1) + " = ");
                vec[a] = int.Parse(Console.ReadLine());
            }

            // tri du vecteur

            for (int b = 0; b < vec.Length; b++)
            {
                int numcase = b;
                for (int c = b + 1; c < vec.Length; c++)
                {
                    if (vec[c] < vec[numcase])
                    {
                        numcase = c;
                    }
                }
                int sauv = vec[numcase];
                vec[numcase] = vec[b];
                vec[b] = sauv;
            }

            Console.Write("Veuillez saisir une valeur à chercher dans le vecteur : ");
            int valeur_a_chercher = int.Parse(Console.ReadLine());

            //recherche de la position

            int min = 0, max = vec.Length;
            int milieu = (min + max) / 2;
            while (valeur_a_chercher != vec[milieu] && min < max)
            {
                if (valeur_a_chercher < vec[milieu])
                {
                    max = milieu - 1;
                }
                else
                {
                    max = milieu + 1;
                }
                milieu = (min + max) / 2;
            }
            if (valeur_a_chercher == vec[milieu])
            {
                Console.Write("La valeur recherchée " + valeur_a_chercher + " a été trouvée dans le vecteur à la position " + (milieu + 1));
            }
            else
            {
                Console.Write("La valeur recherchée " + valeur_a_chercher + " n'a pas été trouvée...");
            }
            Console.ReadLine();

        }
    }
}
