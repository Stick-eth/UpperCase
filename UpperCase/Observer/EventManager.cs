using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpperCase.Observer
{
    class EventManager
    {
        // Création de la liste des abonnées associés au topic
        private List<ISubscriber> subscribers = new List<ISubscriber>();
        public void Afficher()
        {
            Console.WriteLine(subscribers);
        }

        public void Subscribe(ISubscriber sub)
        {
            if (!subscribers.Contains(sub))
            {
                subscribers.Add(sub);
            }
            else
            {
                Console.WriteLine($"Subscriber {sub} déjà abonné");
            }
        }

        public void Unsubscribe(ISubscriber sub)
        {
            if (subscribers.Contains(sub))
            {
                subscribers.Remove(sub);
            }
            else
            {
                Console.WriteLine($"Subscriber {sub} n'est pas dans la liste ");
            }
        }

        public void Notify(string e)
        {
            foreach (ISubscriber sub in subscribers)
            {
                sub.Update(e);
            }
        }
    }
    interface ISubscriber
    {
        void Update(string e);
    }
}
