using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpperCase.Model;
using UpperCase.View;
using UpperCase.ViewModel;
using UpperCase.Observer;


namespace UpperCase
{
    class Program
    {
       
        static void Main(string[] args)
        {
            ViewUpper view = new ViewUpper(new EventManager());
            ViewModelUpper viewModel = new ViewModelUpper(new EventManager());

            view.publisher.Subscribe(viewModel);
            viewModel.publisher.Subscribe(view);

            while (true)
            {
                view.Ask();
            }
                
        }

    }
}
