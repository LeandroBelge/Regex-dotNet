using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Regex_dotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            string moeda1 = "R$9.999,50";
            string moeda2 = "R$8.999,00";
            //remove a moeda
            string reg = @"(^R)(\$)";
            moeda1 = Regex.Replace(moeda1, reg, "");
            moeda2 = Regex.Replace(moeda2, reg, "");
            //Converte e realiza a operação
            double valor = Convert.ToDouble(moeda1) - Convert.ToDouble(moeda2);
            //Formata a moeda de acordo com a máquina.
            Console.WriteLine(valor.ToString("C2", CultureInfo.CurrentCulture));
        }
    }
}
