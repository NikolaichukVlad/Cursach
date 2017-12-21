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
    public class LessThanMaxValidationRule : ValidationRule
    {
        private const Int16 MAX = 1000;
        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {
            int i;
            try
            {
                i = Convert.ToInt16(value);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Вводите тлько числа");
                return new ValidationResult(false, "Введено не число");
            }
            if (i <= MAX)
            {
                return new ValidationResult(true, String.Empty);
            }
            else
            {
                MessageBox.Show("Введите число меньше 1000");
                return new ValidationResult(false, "Число выше нормы");
            }

        }
    }
}
