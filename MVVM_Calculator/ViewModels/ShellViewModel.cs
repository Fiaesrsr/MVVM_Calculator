using MVVM_Calculator.Models;
using Prism.Mvvm;
using MVVM_Calculator;
using MVVM_Calculator.ExtensionMethods;
using System.Data;
using System.Collections.Generic;

namespace MVVM_Calculator.ViewModels
{
    class ShellViewModel : BindableBase
    {


        /// <summary>
        /// DataBinding für MainWindow Titel
        /// </summary>
        public string Title { get; set; } = "MVVM - Calculator";
        

    }
}
