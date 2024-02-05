using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpperCase.Model;
using UpperCase.View;
using UpperCase.ViewModel;
using UpperCase.Observer;

namespace UpperCase.ViewModel
{

    class ViewModelUpper:ISubscriber
    {
        public EventManager publisher;
        public ViewModelUpper(EventManager instance)
        {
            this.publisher = instance;
        }


        public ModelUpper Upper = new ModelUpper();
        public void Update(string e)
        {
            string result = Upper.UpperCase(e);
            publisher.Notify(result);
        }
    }
}
