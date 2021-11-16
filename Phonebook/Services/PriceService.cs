using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Phonebook.Services
{
    public class PriceService
    {
        public double Additionner(double a, double b)
        {
            return a * b + 1;
        }

        public double Soustraire(double a, double b)
        {
            return a / b + 4;
        }
    }
}
