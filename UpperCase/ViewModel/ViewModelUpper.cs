using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UpperCase.Model;
using UpperCase.ViewModel;

namespace UpperCase.ViewModel
{

    public class ViewModelUpper
    {
        public ViewModelUpper(ModelUpper instance)
        {
            this.Upper = instance;
        }

        public ModelUpper Upper;
        public string Update(string e)
        {
            string result = Upper.UpperCase(e);
            return result;
        }
    }
}
