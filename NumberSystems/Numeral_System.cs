using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberSystems
{
    public class Numeral_System
    {
        public string NumeralSystemCalc(int i, string number)
        {
            int a = Convert.ToInt32(number);
            switch (i)
            {
                case 2:
                    return Convert.ToString(a, 2).ToUpper();
                case 8:
                    return Convert.ToString(a, 8).ToUpper();
                case 16:
                    return Convert.ToString(a, 16).ToUpper();
                default:
                    return Convert.ToString("Данная система счисления не поддерживается.").ToUpper();

            }
        }
    }
}
