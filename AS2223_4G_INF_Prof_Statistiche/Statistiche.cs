using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AS2223_4G_INF_Prof_Statistiche
{
    public class Statistiche
    {
        int sommaValori = 0; //salvo i valori SENZA peso
        int numeroValori = 0; //salvo il totale dei numeri SENZA peso
        double sommaValoriConPeso = 0; //salvo il totale dei numeri CON il peso
        double sommaPesoValori = 0; //salvo il totale dei pesi 
        public Statistiche()
        {

        }

        /// <summary>
        /// Aggiungi un valore senza peso per le statistiche (media aritmetica)
        /// </summary>
        /// <param name="valore"></param>
        public void AddValue(int valore)
        {
            sommaValori = sommaValori + valore;
            numeroValori++;
        }

        /// <summary>
        /// Aggiungi un valore con peso per le statistiche (media ponderata)
        /// </summary>
        /// <param name="valore"></param>
        /// <param name="peso"></param>
        public void AddValue(int valore, double peso)
        {
            sommaValori = sommaValori + valore;
            numeroValori++;

            sommaPesoValori = sommaPesoValori + peso;
            sommaValoriConPeso = valore * peso;
            
        }

        /// <summary>
        /// Ritorna la media aritmetica dei valori :
        ///     mediaAritmetica = sommaValori/numeroValori
        /// </summary>
        /// <returns></returns>
        public double MediaAritmetica()
        {
            return sommaValori / numeroValori;
        }

        /// <summary>
        /// Ritorna la media ponderata dei valori :
        ///     mediaPonderata = sommaValoriPerPeso/sommaPesi
        /// </summary>
        /// <returns></returns>
        public double MediaPonderata()
        {
            return sommaValoriConPeso / sommaPesoValori;
        }

        /// <summary>
        /// Azzera i valori inseriti per la statistica
        /// </summary>
        public void ClearValue()
        {
            sommaValori = 0; 
            numeroValori = 0; 
            sommaValoriConPeso = 0; 
            sommaPesoValori = 0;
        }

        /// <summary>
        /// Ritorna il numero di elementi inseriti per la statistica
        /// </summary>
        /// <returns></returns>
        public int CountValue()
        {
            return numeroValori; 
        }

    }
}
