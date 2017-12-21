using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ура_новый_вариант
{
    public class CancelCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var apply = parameter as MainWindowsViewModel;
            apply.Surname = "";
            apply.DoPropertyChanged("Surname");
            apply.Name = "";
            apply.DoPropertyChanged("Name");
            apply.Patronymic = "";
            apply.DoPropertyChanged("Patronymic");
            apply.SelectedCity = apply.Cities[0];
            apply.DoPropertyChanged("SelectedCity");
            apply.SelectedStreet = apply.Cities[0].StreetList[0];
            apply.DoPropertyChanged("SelectedStreet");
            apply.Home = null;
            apply.DoPropertyChanged("Home");
            apply.StrK = null;
            apply.DoPropertyChanged("StrK");
            apply.Apartament = null;
            apply.DoPropertyChanged("Apartament");
        }
    }
}
