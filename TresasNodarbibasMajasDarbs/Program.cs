// See https://aka.ms/new-console-template for more information
using TresasNodarbibasMajasDarbs;




Mobilais mobilais = new Mobilais();

mobilais.Marka = "Huawei";
mobilais.Modelis = "P20";
mobilais.Izmeri = 20;

mobilais.Call();
mobilais.SMS();


Masina masina = new Masina();

masina.Marka = "Audi";
masina.Numurzime = "AA-1234";
masina.Atrums = 90;

masina.Start();
masina.Faster();
masina.Stop();
masina.Slower();
masina.Sound();



Prece prece = new Prece(16, 10, 45);

double gar = prece.Garums;
double plat = prece.Platums;
double svar = prece.Svars;


Persona persona = new Persona();

persona.Vards = "Paula";
persona.Uzvards = "Marija";
persona.Dzimsanasgads = 1995;
persona.Hobijs = "dejošana";
persona.Dzimums = "sieviete";

Console.WriteLine($"Hello my name is { persona.Vards } { persona.Uzvards } and I am {persona.YearsOld()}");