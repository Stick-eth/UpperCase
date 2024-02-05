using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpperCase.Model;
using UpperCase.ViewModel;


namespace UpperCase
{
    class Program
    {
       
        static void Main(string[] args)
        {
            ModelUpper modelUpper = new ModelUpper();
            ViewModelUpper viewModelUpper = new ViewModelUpper(modelUpper);
            while (true)
            {
                string input = Console.ReadLine();
                Console.WriteLine(viewModelUpper.Update(input));
            }
        }

    }
}
