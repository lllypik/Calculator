using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;
using Калькулятор.Models;

namespace Калькулятор.ViewModels
{
    
    class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged ([CallerMemberName]string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }

        string TypeOperation { get; set; }
        double NumbTemp { get; set; }

        private string display;
        public string Display
        {
            get => display;

            set
            {
                display = value;
                OnPropertyChanged();
            }
        }
                   
        public ICommand PresNumbCommand { get; }
        private void OnPresNumbCommandExecute(object p)
        {
            Display = Сalculation.GetStringAfterInputNumb(Display, Convert.ToInt32(p));
        }
        private bool CanPresNumbCommandExecute(object p)
        {
            return true;
        }

        public ICommand PresDotCommand { get; }
        private void OnPresDotCommandExecute(object p)
        {
            Display = Сalculation.GetStringAfterInputDot(Display);
        }
        private bool CanPresDotCommandExecute(object p)
        {
            return true;
        }

        public ICommand PresResetCommand { get; }
        private void OnPresResetCommandExecute(object p)
        {
            Display = "";
            TypeOperation = "0";
            NumbTemp = 0;
        }
        private bool CanPresResetCommandExecute(object p)
        {
            return true;
        }

        public ICommand PresGetTotalCommand { get; }
        private void OnPresGetTotalCommandExecute(object p)
        {
            Сalculation.GetTotal(NumbTemp, Display, TypeOperation, out string displayTemp);
            Display = displayTemp;
            TypeOperation = "+";
            NumbTemp = 0;
        }
        private bool CanPresGetTotalCommandExecute(object p)
        {
            return true;
        }

        public ICommand PresTwoOperandCommand { get; }
        private void OnPresTwoOperandCommandExecute(object p)
        {
            Сalculation.GetTotal(NumbTemp, Display, TypeOperation, out string displayTemp);
            TypeOperation = Convert.ToString(p);
            NumbTemp = Convert.ToDouble(Display);
            Display = "";
        }
        private bool CanPresTwoOperandCommandExecute(object p)
        {
            return true;
        }

        public ICommand PresOneOperandCommand { get; }
        private void OnPresOneOperandCommandExecute(object p)
        {
            switch (p as string)
            {
                case "cos":
                    Display = Сalculation.Cos(Display);
                    break;
                case "sin":
                    Display = Сalculation.Sin(Display);
                    break;
                case "tan":
                    Display = Сalculation.Tan(Display);
                    break;
                case "inv":
                    Display = Сalculation.Inversion(Display);
                    break;
                case "sqrt":
                    Display = Сalculation.Sqrt(Display);
                    break;
                case "pow2":
                    Display = Сalculation.Pow2(Display);
                    break;
                case "rev":
                    Display = Сalculation.Reverse(Display);
                    break;
            }
            TypeOperation = "";
            NumbTemp = 0;
        }
        private bool CanPresOneOperandCommandExecute(object p)
        {
            return true;
        }
        
        
        public MainWindowViewModel()
        {
            //Starting Values
            TypeOperation = "";         
            NumbTemp = 0;

            //Commands
            PresNumbCommand = new RelayCommand(OnPresNumbCommandExecute, CanPresNumbCommandExecute);
            PresDotCommand = new RelayCommand(OnPresDotCommandExecute, CanPresDotCommandExecute);
            PresGetTotalCommand = new RelayCommand(OnPresGetTotalCommandExecute, CanPresGetTotalCommandExecute);
            PresResetCommand = new RelayCommand(OnPresResetCommandExecute, CanPresResetCommandExecute);
            PresTwoOperandCommand = new RelayCommand(OnPresTwoOperandCommandExecute, CanPresTwoOperandCommandExecute);
            PresOneOperandCommand = new RelayCommand(OnPresOneOperandCommandExecute, CanPresOneOperandCommandExecute);
        }
    }
}
