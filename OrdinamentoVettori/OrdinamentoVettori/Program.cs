using System;

namespace OrdinamentoVettori
{
    class Program
    {
        static void Main(string[] args)
        {
            //creazione e riempimento del vettore di interi
            int [] vettore = new int [10] { 11, 55, -9, 7, 74, 147, -87, 6, 0, 18};


            //chiamo il metodo per l'ordinamento
            ordina(vettore);

            //stampo a video gli elementi nel vettore
            for (int i = 0; i < 10; i++)
                Console.WriteLine(vettore[i]);

            Console.ReadKey();
        }

        //metodo ordina
        static void ordina (int[] vettore)
        {
            Array.Sort(vettore);
        }

     
    }
}
