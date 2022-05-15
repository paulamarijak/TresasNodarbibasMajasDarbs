
namespace TresasNodarbibasMajasDarbs
{
    public class Mobilais
    {

        public string Marka { get; set; }
        public string Modelis { get; set; }
        public int Izmeri { get; set; }

        public void Call()
        {
            Console.WriteLine($"Lets call: {Marka} ");
        }
        public void SMS()
        {
            Console.WriteLine($"Lets send SMS to: {Marka} ");
        }
    }
}
