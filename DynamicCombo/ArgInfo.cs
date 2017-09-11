using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentOctal.WpfLib;

namespace DynamicCombo
{
    class ArgInfo : ViewModel
    {
        private string _name;
        public string Name
        {
            get {return _name;}
            set {SetValue(ref _name, value);}
        }

        private Type _type;
        public Type Type
        {
            get {return _type;}
            set {SetValue(ref _type, value);}
        }

    }
}
