using MVVM_Calculator.Models;
using Prism.Mvvm;
using MVVM_Calculator;
using MVVM_Calculator.ExtensionMethods;
using System.Data;
using System.Collections.Generic;
using Prism.Commands;
using MVVM_Calculator.ViewModels.Bases;
using System;

namespace MVVM_Calculator.ViewModels
{
    class ShellViewModel : ViewModelBase
    {


        /// <summary>
        /// DataBinding für MainWindow Titel
        /// </summary>
        public string Title { get; } = "MVVM - Calculator";

        private string _calculatorText;

        public string CalculatorText
        {
            get => _calculatorText;
            set => SetProperty(ref _calculatorText, value);
        }

        public DelegateCommand<object> AddNumberCommand { get; set; }

        protected override void RegisterCommands()
        {
            AddNumberCommand = new DelegateCommand<object>(AddNumber);
        }

        private void AddNumber(object buttonValue)
        {
            CalculatorText += buttonValue;
        }
    }
}
