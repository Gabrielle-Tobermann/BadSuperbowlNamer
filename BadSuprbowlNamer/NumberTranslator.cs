using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BadSuperbowlNamer
{
    public class NumberTranslator
    {
        public string Translate(int numberToTranslate)
        {
            // trying to avoid having lots of cases:

            var numeral = "";

            numeral += new string('L', numberToTranslate / 50);
            numberToTranslate %= 50;

            numeral += numberToTranslate == 40 ? "XL" : "";
            numberToTranslate %= 40;

            numeral += new string('V', numberToTranslate / 5);
            numberToTranslate %= 5;

            numeral += new string('X', numberToTranslate / 10);
            numberToTranslate %= 10;


            numeral += numberToTranslate == 4 ? "IV" : "";
            numberToTranslate %= 4;

            numeral += numberToTranslate == 9 ? "IX" : "";
            numberToTranslate %= 9;

            numeral += new string('I', numberToTranslate);
            return numeral;







            // switch expression is basically the same as normal switch statement
            //return numberToTranslate switch
            //{
            //    1 => "I",
            //    3 => "III",
            //    4 => "IV",
            //    5 => "V",
            //    _ => ""
            //};

            //switch (numberToTranslate)
            //{
            //    case 1:
            //        return "I";
            //    case 3:
            //        return "III";
            //    case 4:
            //        return "IV";
            //}

            //return "";
        }
    }
}
