using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        
        private string Modelo;
        private string IMEI;
        private int Memoria;


        
        public Smartphone(string numero, string modelo, string IMEI, int memoria)
        {
            
            this.Numero = numero;
            this.Modelo = modelo;
            this.IMEI = IMEI;   
            this.Memoria = memoria; 

        }

        public void Ligar()
        {
            Console.WriteLine($"Modelo {Modelo} - Memória {Memoria}mb");
            Console.WriteLine($"IMEI: {IMEI}");
            Console.WriteLine($"Ligando...{Numero}");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação...{Numero}");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}
