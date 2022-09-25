using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
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
                   
        public ICommand Pres1Command { get; }
        private void OnPres1CommandExecute(object p)
        {
            Display = Сalculation.GetStringAfterInputNumb(Display, 1);
        }
        private bool CanPres1CommandExecute(object p)
        {
            return true;
        }

        public ICommand Pres2Command { get; }
        private void OnPres2CommandExecute(object p)
        {
            Display = Сalculation.GetStringAfterInputNumb(Display, 2);
        }
        private bool CanPres2CommandExecute(object p)
        {
            return true;
        }

        public ICommand Pres3Command { get; }
        private void OnPres3CommandExecute(object p)
        {
            Display = Сalculation.GetStringAfterInputNumb(Display, 3);
        }
        private bool CanPres3CommandExecute(object p)
        {
            return true;
        }

        public ICommand Pres4Command { get; }
        private void OnPres4CommandExecute(object p)
        {
            Display = Сalculation.GetStringAfterInputNumb(Display, 4);
        }
        private bool CanPres4CommandExecute(object p)
        {
            return true;
        }

        public ICommand Pres5Command { get; }
        private void OnPres5CommandExecute(object p)
        {
            Display = Сalculation.GetStringAfterInputNumb(Display, 5);
        }
        private bool CanPres5CommandExecute(object p)
        {
            return true;
        }

        public ICommand Pres6Command { get; }
        private void OnPres6CommandExecute(object p)
        {
            Display = Сalculation.GetStringAfterInputNumb(Display, 6);
        }
        private bool CanPres6CommandExecute(object p)
        {
            return true;
        }

        public ICommand Pres7Command { get; }
        private void OnPres7CommandExecute(object p)
        {
            Display = Сalculation.GetStringAfterInputNumb(Display, 7);
        }
        private bool CanPres7CommandExecute(object p)
        {
            return true;
        }

        public ICommand Pres8Command { get; }
        private void OnPres8CommandExecute(object p)
        {
            Display = Сalculation.GetStringAfterInputNumb(Display, 8);
        }
        private bool CanPres8CommandExecute(object p)
        {
            return true;
        }

        public ICommand Pres9Command { get; }
        private void OnPres9CommandExecute(object p)
        {
            Display = Сalculation.GetStringAfterInputNumb(Display, 9);
        }
        private bool CanPres9CommandExecute(object p)
        {
            return true;
        }

        public ICommand Pres0Command { get; }
        private void OnPres0CommandExecute(object p)
        {
            Display = Сalculation.GetStringAfterInputNumb(Display, 0);
        }
        private bool CanPres0CommandExecute(object p)
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
            TypeOperation = "+";
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

        public ICommand PresPlusCommand { get; }
        private void OnPresPlusCommandExecute(object p)
        {
            Сalculation.GetTotal(NumbTemp, Display, TypeOperation, out string displayTemp);
            Сalculation.Аddition(displayTemp, out double numbTemp, out string typeOperation);
            Display = "";
            TypeOperation = typeOperation;
            NumbTemp = numbTemp;
        }
        private bool CanPresPlusCommandExecute(object p)
        {
            return true;
        }

        public ICommand PresMinusCommand { get; }
        private void OnPresMinusCommandExecute(object p)
        {
            Сalculation.GetTotal(NumbTemp, Display, TypeOperation, out string displayTemp);
            Сalculation.Subtraction(displayTemp, out double numbTemp, out string typeOperation);
            Display = "";
            TypeOperation = typeOperation;
            NumbTemp = numbTemp;
        }
        private bool CanPresMinusCommandExecute(object p)
        {
            return true;
        }

        public ICommand PresDivisCommand { get; }
        private void OnPresDivisCommandExecute(object p)
        {
            Сalculation.GetTotal(NumbTemp, Display, TypeOperation, out string displayTemp);
            Сalculation.Division(displayTemp, out double numbTemp, out string typeOperation);
            Display = "";
            TypeOperation = typeOperation;
            NumbTemp = numbTemp;
        }
        private bool CanPresDivisCommandExecute(object p)
        {
            return true;
        }

        public ICommand PresMultipCommand { get; }
        private void OnPresMultipCommandExecute(object p)
        {
            Сalculation.GetTotal(NumbTemp, Display, TypeOperation, out string displayTemp);
            Сalculation.Multiplication(displayTemp, out double numbTemp, out string typeOperation);
            Display = "";
            TypeOperation = typeOperation;
            NumbTemp = numbTemp;
        }
        private bool CanPresMultipCommandExecute(object p)
        {
            return true;
        }

        public ICommand PresCosCommand { get; }
        private void OnPresCosCommandExecute(object p)
        {
            Display = Сalculation.Cos(Display);
            TypeOperation = "";
            NumbTemp = 0;
        }
        private bool CanPresCosCommandExecute(object p)
        {
            return true;
        }

        public ICommand PresSinCommand { get; }
        private void OnPresSinCommandExecute(object p)
        {
            Display = Сalculation.Sin(Display);
            TypeOperation = "";
            NumbTemp = 0;
        }
        private bool CanPresSinCommandExecute(object p)
        {
            return true;
        }

        public ICommand PresTanCommand { get; }
        private void OnPresTanCommandExecute(object p)
        {
            Display = Сalculation.Sin(Display);
            TypeOperation = "";
            NumbTemp = 0;
        }
        private bool CanPresTanCommandExecute(object p)
        {
            return true;
        }

        public ICommand PresSqrtCommand { get; }
        private void OnPresSqrtCommandExecute(object p)
        {
            Display = Сalculation.Sqrt(Display);
            TypeOperation = "";
            NumbTemp = 0;
        }
        private bool CanPresSqrtCommandExecute(object p)
        {
            return true;
            //return Сalculation.StringIsPositive(Display)==true? true: false;
        }

        public ICommand PresPow2Command { get; }
        private void OnPresPow2CommandExecute(object p)
        {
            Display = Сalculation.Pow2(Display);
            TypeOperation = "";
            NumbTemp = 0;
        }
        private bool CanPresPow2CommandExecute(object p)
        {
            return true;
        }

        public ICommand PresReverseCommand { get; }
        private void OnPresReverseCommandExecute(object p)
        {
            Display = Сalculation.Reverse(Display);
            TypeOperation = "";
            NumbTemp = 0;
        }
        private bool CanPresReverseCommandExecute(object p)
        {
            return true;
        }

        public ICommand PresInversionCommand { get; }
        private void OnPresInversionCommandExecute(object p)
        {
            Display = Сalculation.Inversion(Display);
        }
        private bool CanPresInversionCommandExecute(object p)
        {
            return true;
        }

        public MainWindowViewModel()
        {
            //Starting Values
            TypeOperation = "";         
            NumbTemp = 0;

            //Commands
            Pres1Command = new RelayCommand(OnPres1CommandExecute, CanPres1CommandExecute);
            Pres2Command = new RelayCommand(OnPres2CommandExecute, CanPres2CommandExecute);
            Pres3Command = new RelayCommand(OnPres3CommandExecute, CanPres3CommandExecute);
            Pres4Command = new RelayCommand(OnPres4CommandExecute, CanPres4CommandExecute);
            Pres5Command = new RelayCommand(OnPres5CommandExecute, CanPres5CommandExecute);
            Pres6Command = new RelayCommand(OnPres6CommandExecute, CanPres6CommandExecute);
            Pres7Command = new RelayCommand(OnPres7CommandExecute, CanPres7CommandExecute);
            Pres8Command = new RelayCommand(OnPres8CommandExecute, CanPres8CommandExecute);
            Pres9Command = new RelayCommand(OnPres9CommandExecute, CanPres9CommandExecute);
            Pres0Command = new RelayCommand(OnPres0CommandExecute, CanPres0CommandExecute);
            PresDotCommand = new RelayCommand(OnPresDotCommandExecute, CanPresDotCommandExecute);
            PresGetTotalCommand = new RelayCommand(OnPresGetTotalCommandExecute, CanPresGetTotalCommandExecute);
            PresResetCommand = new RelayCommand(OnPresResetCommandExecute, CanPresResetCommandExecute);
            PresPlusCommand = new RelayCommand(OnPresPlusCommandExecute, CanPresPlusCommandExecute);
            PresMinusCommand = new RelayCommand(OnPresMinusCommandExecute, CanPresMinusCommandExecute);
            PresMinusCommand = new RelayCommand(OnPresMinusCommandExecute, CanPresMinusCommandExecute);
            PresDivisCommand = new RelayCommand(OnPresDivisCommandExecute, CanPresDivisCommandExecute);
            PresMultipCommand = new RelayCommand(OnPresMultipCommandExecute, CanPresMultipCommandExecute);
            PresCosCommand = new RelayCommand(OnPresCosCommandExecute, CanPresCosCommandExecute);
            PresSinCommand = new RelayCommand(OnPresSinCommandExecute, CanPresSinCommandExecute);
            PresTanCommand = new RelayCommand(OnPresTanCommandExecute, CanPresTanCommandExecute);
            PresSqrtCommand = new RelayCommand(OnPresSqrtCommandExecute, CanPresSqrtCommandExecute);
            PresPow2Command = new RelayCommand(OnPresPow2CommandExecute, CanPresPow2CommandExecute);
            PresReverseCommand = new RelayCommand(OnPresReverseCommandExecute, CanPresReverseCommandExecute);
            PresInversionCommand = new RelayCommand(OnPresInversionCommandExecute, CanPresInversionCommandExecute);
        }
    }
}
