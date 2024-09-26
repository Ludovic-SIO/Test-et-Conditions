using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_et_Conditions
{
    internal class Program
    {
        static void Main(string[] args)

        {
            
            

            Console.WriteLine("saisir le prix d’un produit Hors Taxes");
            double horsTaxes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Le prix est de {0} euros", horsTaxes);
            Console.WriteLine("Choisie le taux de taxe entre:\n 1: 20%\n 2: 10 %\n 3: 5,5%\n 4: 0.21% ");
            int choix = Convert.ToInt32
            (Console.ReadLine());
                double taux = 0;
                if (choix == 1) taux = 0.20;
                if (choix == 2) taux = 0.10;
                if (choix == 3) taux = 0.055;
                if (choix == 4) taux = 0.021;


            double taxes= (horsTaxes * taux);
            //Console.WriteLine("Le % est {0}",salaire);
            double TTC = (horsTaxes + taxes);
            Console.WriteLine("Le Prix TTC est {0} DONT {1} EUROS DE TAXES", TTC,taxes);
            Console.ReadKey();

           
        }
    }
}
