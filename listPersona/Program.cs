using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace listPersona
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Persona> persone = new List<Persona>();
            AggiungiPersona(persone);

            static void AggiungiPersona(List<Persona> persone)
            {

            
            for(int i=0; i<5; i++)
            {
                    Persona nuovaP = new Persona;
                Console.WriteLine("inserisci nome:");
                nuovaP.Nome= Console.ReadLine();
                
                Console.WriteLine("inserisci età:");
                    
                    nuovaP.Eta=int.Parse(Console.ReadLine());   

                persone.Add(nuovaP);
            }
            }
            static void Maggiorenne(List<Persona> persone);
            {
                foreach(Persona persona in persone)
                {
                    if (persona.Eta >= 18)
                        Console.WriteLine("Nome: {0}, Eta: {1}", persona.Nome, persona.Eta);
                }

            }
           
        }
    }
}
