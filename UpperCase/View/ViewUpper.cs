using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpperCase.Model;
using UpperCase.Observer;
using UpperCase.ViewModel;

namespace UpperCase.View
{
     class ViewUpper : ISubscriber
    {
        public EventManager publisher;
        public ViewUpper(EventManager instance)
        {
            this.publisher = instance;
        }
        public void Ask()
        {
            Console.WriteLine("Bienvenue, Entrez votre texte");
            string prompt = Console.ReadLine();
            publisher.Notify(prompt);
        }

        public void Update(string e)
        {
            Console.WriteLine($"Votre texte converti donne : {e}");
        }
    }
}
