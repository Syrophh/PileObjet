using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilitaires;

namespace MesOutils
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestePileVidePleine(5);
            //TestePileVidePleine(0);
            //TesteEmpiler(5);
            //TesteEmpiler(2);
            //TestEmpilerDepiler(5);
            int nbSaisi = Utilitaire.SaisirNb();
            Console.WriteLine("Nombre saisi : " + nbSaisi);
            nbSaisi = Utilitaire.SaisirNb(10);
            Console.WriteLine("Nombre saisi : " + nbSaisi);
            nbSaisi = Utilitaire.SaisirNb(10, 30);
            Console.WriteLine("Nombre saisi : " + nbSaisi);
            Console.WriteLine("Fin du programme");

            Console.ReadKey();
        }

        static void TestePileVidePleine(int nbElements)
        {
            Pile pUnePile = new Pile(nbElements);
            if (pUnePile.PileVide())
            {
                Console.WriteLine("La pile est vide");
            }
            else
            {
                Console.WriteLine("La pile n'est pas vide");
            }
            if (pUnePile.PilePleine())
            {
                Console.WriteLine("La pile est pleine");
            }
            else
            {
                Console.WriteLine("La pile n'est pas pleine");
            }
        }

        static void TesteEmpiler(int nbElements)
        {
            Pile unePile = new Pile(nbElements);
            try
            {
                unePile.Empiler(2);
                unePile.Empiler(14);
                unePile.Empiler(6);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        static void TestEmpilerDepiler(int nbElements)
        {
            try
            {
                Pile unePile = new Pile(nbElements);
                unePile.Empiler(2);
                unePile.Empiler(22);
                int valeurDepilee = (int)unePile.Depiler();
                Console.WriteLine("valeur dépilée : " + valeurDepilee);
                unePile.Empiler(17);
                valeurDepilee = (int)unePile.Depiler();
                valeurDepilee = (int)unePile.Depiler();
                valeurDepilee = (int)unePile.Depiler();
                valeurDepilee = (int)unePile.Depiler();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
