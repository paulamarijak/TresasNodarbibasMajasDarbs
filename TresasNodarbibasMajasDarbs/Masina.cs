using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresasNodarbibasMajasDarbs
{
    public class Masina
    {
        public string Marka { get; set; }
        public string Numurzime { get; set; }
        public int Atrums { get; set; }

        public void Start()
        {
            Console.WriteLine($"Lets ride: {Marka} ");
        }
        public void Faster()
        {
            Console.WriteLine($"Lets go faster: {Marka} ");
        }
        public void Stop()
        {
            Console.WriteLine($"Lets stop: {Marka} ");
        }
        public void Slower()
        {
            Console.WriteLine($"Lets go slower: {Marka} ");
        }
        public void Sound()
        {
            Console.WriteLine("Beep beep");
        }
    }
}
