using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresasNodarbibasMajasDarbs
{
    public class Persona
    {
        public string Vards { get; set; }
        public string Uzvards { get; set; }
        public int Dzimsanasgads { get; set; }
        public string Hobijs { get; set; }
        public string Dzimums { get; set; }

        public int YearsOld()
        {
            int yearsOld = DateTime.Now.Year - Dzimsanasgads;
            return yearsOld;
        }
    }
}
