using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_oop_shop
{
    
    public class Prodotto
    {
        private Random rnd = new Random();
        private int codice { get; }
        public string nome { get; set; }
        public string descrizione { get; set; }
        public float prezzo { get; set; }
        public int iva { get; set; } = 22;
        public Prodotto(string _nome, string _descrizione, float _prezzo) { 
            this.codice = rnd.Next();
            this.nome = _nome;
            this.descrizione = _descrizione;
            this.prezzo = _prezzo;
        }
        
        public float GetPriceVAT()
        {
            return this.prezzo + ((this.prezzo / 100) * this.iva);
        }

        public string GetFull()
        {
            return this.codice.ToString()+ " " + this.nome;
        }
    }
}
