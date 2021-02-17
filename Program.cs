using System;

namespace LesTableauxExo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Créer un tableau week contenant les jours :
            //Lundi
            //Mardi
            //Mercredi
            //Jedi(garder la faute)
            // Vendredi
            //Samedi
            //Afficher le contenu de l’indice 1 et 4 du tableau dans la console sur 2 lignes différentes. 
            //Afficher le contenu du 1er et du 4ᵉ élément du tableau dans la console sur 2 lignes différentes.
            //Corriger le 4ème jour.
            //Ajouter le 7ème jour.
            //Afficher le tableau dans la console.

            

            string[] week = new string[] { "Lundi", "Mardi", "Mercredi", "Jedi", "Vendredi", "Samedi" };

            Console.WriteLine("Contenu de l'indice 1 : " + week[1] + " \n + " +
                "Contenu de l'indice 4 : " + week[4]);

            Console.WriteLine("Contenu du 1er élément : " + week[0] + " \n + " +
                "Contenu du 4e élément : " + week[3]);

            week[3] = "Jeudi";

            Console.WriteLine("Contenu du 4e élément après correction : " + week[3]);

            Array.Resize<string>(ref week, 7);
            week[6] = "Dimanche";

            Console.WriteLine(" Ajout du 7e jour :" + week[6]);

            for (int index = 0; index < week.Length ; index++)
            {             
                System.Console.WriteLine(week[index]);
            };

        }
    }
}
