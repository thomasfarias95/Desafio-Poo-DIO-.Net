using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioPOO.Models
{
    
    public class Nokia : Smartphone
    {

        public Nokia(string numero, string modelo, string IMEI, int memoria) : base(numero, modelo, IMEI, memoria)
        {
            
        }

        public string Numero { get; }
        public string Modelo { get; }
        public string IMEI { get; }
        public int Memoria { get; }

        
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Telefone Nokia Instalando aplicativo: {nomeApp}");
        }
    }
}
