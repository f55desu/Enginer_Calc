using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Enginer_Calc
{
    class ExSetting
    {
        private string language;
        public string Language
        {
            get 
            { 
                return language; 
            }
            set
            {
                language = value;
            }
        }
    }
}
