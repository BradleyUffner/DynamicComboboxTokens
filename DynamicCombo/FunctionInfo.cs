using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentOctal.WpfLib;

namespace DynamicCombo
{
    class FunctionInfo:ViewModel
    {
        private string _name;
        public string Name
        {
            get {return _name;}
            set {SetValue(ref _name, value);}
        }

        public ObservableCollection<ArgInfo> Arguments { get; }=new ObservableCollection<ArgInfo>();

        public string Signature
        {
            get { return $"{Name}({string.Join(", ", Arguments.Select(a => $"{a.Type.Name} {a.Name}"))})"; }
        }
    }
}
