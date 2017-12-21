using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Ура_новый_вариант
{
    public class MainWindowsViewModel:INotifyPropertyChanged
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public Int32? Home { get; set; }
        public Int32? StrK { get; set; }
        public Int32? Apartament { get; set; }
        public List<City> Cities { get; set; }
        private City _selectedCity { get; set; }
        public ICommand Save { get; set; }
        public ICommand Cancel { get; set; }
        public City SelectedCity { get { return _selectedCity; }
        set
            {
                _selectedCity = value;
                DoPropertyChanged("SelectedCity");
                this.Streets = _selectedCity.StreetList;
                DoPropertyChanged("Streets");
            }
        }
        public List<Street> Streets { get; set; }
        public Street SelectedStreet { get; set; }

        public MainWindowsViewModel()
        {
            this.Cities = new List<City>()
            {
                new City("Москва", new List<Street>()
                {
                    new Street("Проспект 60-летия Октября"),
                    new Street("Профсоюзная")
                }),
                new City("Брянск", new List<Street>()
                {
                    new Street("Ново-Cоветская"),
                    new Street("Орловская")
                })
            };
            Save = new SaveCommand();
            Cancel = new CancelCommand();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void DoPropertyChanged(String Name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(Name));
            }
        }
    }
}
