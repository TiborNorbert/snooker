using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace snooker
{
    class Program
    {
        static void Main(string[] args)
        {
            //2.feladat
            StreamReader olvas = new StreamReader("snooker.txt", Encoding.Default);
            List<adatbase> lista = new List<adatbase>();
            string felso = olvas.ReadLine();
            while (!olvas.EndOfStream)
            {
                lista.Add(new adatbase(olvas.ReadLine()));
            }
            //3.feladat
            Console.WriteLine($"3.feladat Versenyzők száma: {lista.Count}.fő");
            //4.feladat
            Console.WriteLine("4.feladat");
            double Onyeremeny = 0;
            for (int i = 0; i < lista.Count; i++)
            {
                Onyeremeny += lista[i].nyeremeny;
            }
            Console.WriteLine($"A versenyzők összesen {(Onyeremeny/lista.Count):N2} fontot szereztek");
            //5.feladat
            Console.WriteLine("5.feladat A legjobban kereső Kínai versenyző:");
            int legjobbk = lista[0].nyeremeny;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Orszag=="Kína"&&lista[i].nyeremeny>legjobbk)
                {
                    legjobbk = lista[i].nyeremeny;
                }
            }
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].nyeremeny==legjobbk)
                {
                    Console.WriteLine($"\tHelyezés:{lista[i].helyezes}");
                    Console.WriteLine($"\tNév:{lista[i].Nev}");
                    Console.WriteLine($"\tOrszág:{lista[i].Orszag}");
                    Console.WriteLine($"\tNyeremény összege:{lista[i].nyeremeny*380:N2}Forint");
                }
            }
            //6.feladat
            Console.WriteLine("6.feladat");
            bool vanenorveg = false;
            for (int i = 0; i < lista.Count; i++)
            {
                if (lista[i].Orszag == "Norvégia")
                {
                    vanenorveg =true;
                }
            }
            if (vanenorveg==true)
            {
                Console.WriteLine("Van a versenyzők között Norvég");
            }
            else
            {
                Console.WriteLine("Nincs ilyen versenyző");
            }
            //7.feladat
            List<string> orszaglista= new List<string>();
            for (int i = 0; i < lista.Count; i++)
            {
                bool nezo = false;
                for (int j = 0; j < orszaglista.Count; j++)
                {
                    if (lista[i].Orszag==orszaglista[j])
                    {
                        nezo = true;
                    }
                }
                if(nezo==false)
                {
                    orszaglista.Add(lista[i].Orszag);
                }
            }
            int[] orszagseged = new int[orszaglista.Count];
            for (int i = 0; i < lista.Count; i++)
            {
                for (int j = 0; j < orszaglista.Count; j++)
                {
                    if (lista[i].Orszag==orszaglista[j])
                    {
                        orszagseged[j]++;
                    }
                }
            }
            Console.WriteLine("Statisztika");
            for (int i = 0; i < orszagseged.Length; i++)
            {
                if (orszagseged[i]>4)
                {
                    Console.WriteLine($"\t{orszaglista[i]} - {orszagseged[i]}fő");
                }
            }
            Console.WriteLine("\nProgram vége");
            Console.ReadKey();
        }
    }
}
