using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpperCase.View;
using UpperCase.ViewModel;
using UpperCase.Observer;

namespace UpperCase.Model
{
    class ModelUpper
    {
        public string UpperCase(string input)
        {
            return input.ToUpper();
        }   
    }
}
