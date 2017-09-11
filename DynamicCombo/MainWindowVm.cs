using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AgentOctal.WpfLib;

namespace DynamicCombo
{
    class MainWindowVm : ViewModel
    {
        public MainWindowVm()
        {
            Functions = new ObservableCollection<FunctionInfo>();
            
            FunctionInfo function = null;

            function = new FunctionInfo();
            function.Name = "Foo";
            function.Arguments.Add(new ArgInfo() { Name = "x", Type = typeof(int) });
            Functions.Add(function);

            function = new FunctionInfo();
            function.Name = "Bar";
            function.Arguments.Add(new ArgInfo() { Name = "y", Type = typeof(int) });
            function.Arguments.Add(new ArgInfo() { Name = "z", Type = typeof(int) });
            Functions.Add(function);

            function = new FunctionInfo();
            function.Name = "HelloWorld";
            function.Arguments.Add(new ArgInfo() { Name = "q", Type = typeof(string) });
            Functions.Add(function);
        }

        public ObservableCollection<FunctionInfo> Functions { get; } 
        
        private FunctionInfo _selectedFunction;
        public FunctionInfo SelectedFunction
        {
            get {return _selectedFunction;}
            set {SetValue(ref _selectedFunction, value);}
        }

    }
}