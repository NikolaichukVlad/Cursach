using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Ура_новый_вариант
{
    public class NotEmptyValidationRule : ValidationRule
    {
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            for(int i = 0; i<value.ToString().Length; i++)
            {
                foreach (char item in value.ToString())
                {
                    if (Char.IsLetter(item))
                        return new ValidationResult(true, String.Empty);
                    else
                    {
                        MessageBox.Show("Вводите только буквы");
                        return new ValidationResult(false, "Строка должна содержать только буквы");
                    }
                }
            }
            if (value != null)
            {
                return new ValidationResult(true, String.Empty);
            }
            else
            {
                MessageBox.Show("Введите значение");
                return new ValidationResult(false, "Значение не должно быть пустым");
            }
        }
    }
}
