using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Калькулятор.Models;

namespace Калькулятор.Models
{
    class Сalculation
    {
        //Entering numbers and dot
        public static string GetStringAfterInputNumb(string stringBefore, int numberAdd) => stringBefore + Convert.ToString(numberAdd);

        public static string GetStringAfterInputDot(string stringBefore)
        {
            return stringBefore.Contains(",") == false? stringBefore + ',' : stringBefore;
        }

        //Arithmetic operations

        public static string Inversion(string stringBefore) => Convert.ToString(0 - Convert.ToDouble(stringBefore));

        public static string Cos(string stringBefore) => Convert.ToString(Math.Cos((Convert.ToDouble(stringBefore))* Math.PI/180));

        public static string Tan(string stringBefore) => Convert.ToString(Math.Tan((Convert.ToDouble(stringBefore)) * Math.PI / 180));

        public static string Sin(string stringBefore) => Convert.ToString(Math.Sin((Convert.ToDouble(stringBefore)) * Math.PI / 180));

        public static string Sqrt(string stringBefore) => Convert.ToString(Math.Sqrt(Convert.ToDouble(stringBefore)));

        public static string Pow2(string stringBefore) => Convert.ToString(Math.Pow(Convert.ToDouble(stringBefore), 2));

        public static string Reverse(string stringBefore) => Convert.ToString(Math.Pow(Convert.ToDouble(stringBefore), -1));

        public static bool StringIsPositive(string stringBefore) => (Convert.ToDouble(stringBefore) >= 0)? true: false;


        //Get the total
        public static void GetTotal(double numbTemp, string stringDisp, string typeOperation, out string Total)
        {
            Total = "";
            switch (typeOperation)
            {
                case "-":
                    Total = Convert.ToString(numbTemp - Convert.ToDouble(stringDisp));
                    break;
                case "+":
                    Total = Convert.ToString(numbTemp + Convert.ToDouble(stringDisp));
                    break;
                case "*":
                    Total = Convert.ToString(numbTemp * Convert.ToDouble(stringDisp));
                    break;
                case "/":
                    Total = Convert.ToString(numbTemp / Convert.ToDouble(stringDisp));
                    break;
                default:
                    Total = stringDisp;
                    break;
            }


        }
    }
}