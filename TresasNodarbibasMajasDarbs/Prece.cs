using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TresasNodarbibasMajasDarbs
{
    public class Prece
    {
        public Prece(double height, double width, double weight)
        {
            Garums = height;
            Platums = width;
            Svars = weight;
        }
        public double Garums { get; }
        public double Platums { get; }
        public double Svars { get; }

    }
}
