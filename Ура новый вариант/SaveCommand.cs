using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Ура_новый_вариант
{
    public class SaveCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var apply = parameter as MainWindowsViewModel;
            if (apply.SelectedCity == null || String.IsNullOrWhiteSpace(apply.SelectedCity.Name) || apply.SelectedStreet == null || String.IsNullOrWhiteSpace(apply.SelectedStreet.Name) ||
                apply.Surname == null || apply.Name == null || apply.Patronymic == null || apply.Home == null || apply.Home == 0 ||
                apply.StrK == null || apply.StrK == 0 || apply.Apartament == null || apply.Apartament == 0)
            {
                MessageBox.Show("Данные некорректны, проверьте и введите заново");
            }
            else
            {
                //REVIEW: Вынести строку подключения в настройки
                using (SqlConnection connection = new SqlConnection("Server=Demidoff\\SQLEXPRESS;Database=BDVlad;Trusted_Connection=True;"))
                {
                    //REVIEW: Если соединение не открывается или команда не проходит - будет исключение
                    connection.Open();
                    String query = String.Format("INSERT INTO Table_3(Surname, Name, Patronymic, City, Street, Home, StrK, Apartament) values('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}')", apply.Surname, apply.Name, apply.Patronymic, apply.SelectedCity.Name, apply.SelectedStreet.Name, apply.Home, apply.StrK, apply.Apartament);
                    SqlCommand cmdSave = new SqlCommand(query, connection);
                    cmdSave.ExecuteNonQuery();
                }
                MessageBox.Show("Вы успешно зарегистрированы");
            }
        }
    }
}
