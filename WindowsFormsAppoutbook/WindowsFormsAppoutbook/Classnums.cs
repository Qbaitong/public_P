using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsAppoutbook
{
    class Classnums
    {
        /// <summary>
        /// 返回一个随机生成的string类型随机数
        /// </summary>
        /// <returns></returns>
        public string _uum()
        {
            string a = "";
            Random c = new Random();
            for (int i = 0; i <= 4; i++)
            {
                int r = c.Next(0, 62);
                a = a + _a(r);
            }
            return a;
        }
        //需要生成的随机数
        public string _a(int t)
        {
            string a = "";
            switch (t)
            {
                case 0:
                    a = "0";
                    break;
                case 1:
                    a = "1";
                    break;
                case 2:
                    a = "2";
                    break;
                case 3:
                    a = "3";
                    break;
                case 4:
                    a = "4";
                    break;
                case 5:
                    a = "5";
                    break;
                case 6:
                    a = "6";
                    break;
                case 7:
                    a = "7";
                    break;
                case 8:
                    a = "8";
                    break;
                case 9:
                    a = "9";
                    break;
                case 10:
                    a = "a";
                    break;
                case 11:
                    a = "b";
                    break;
                case 12:
                    a = "c";
                    break;
                case 13:
                    a = "d";
                    break;
                case 14:
                    a = "e";
                    break;
                case 15:
                    a = "f";
                    break;
                case 16:
                    a = "g";
                    break;
                case 17:
                    a = "h";
                    break;
                case 18:
                    a = "i";
                    break;
                case 19:
                    a = "j";
                    break;
                case 20:
                    a = "k";
                    break;
                case 21:
                    a = "l";
                    break;
                case 22:
                    a = "m";
                    break;
                case 23:
                    a = "n";
                    break;
                case 24:
                    a = "o";
                    break;
                case 25:
                    a = "p";
                    break;
                case 26:
                    a = "o";
                    break;
                case 27:
                    a = "r";
                    break;
                case 28:
                    a = "s";
                    break;
                case 29:
                    a = "t";
                    break;
                case 30:
                    a = "u";
                    break;
                case 31:
                    a = "v";
                    break;
                case 32:
                    a = "w";
                    break;
                case 33:
                    a = "x";
                    break;
                case 34:
                    a = "y";
                    break;
                case 35:
                    a = "z";
                    break;
                case 36:
                    a = "A";
                    break;
                case 37:
                    a = "B";
                    break;
                case 38:
                    a = "C";
                    break;
                case 39:
                    a = "D";
                    break;
                case 40:
                    a = "E";
                    break;
                case 41:
                    a = "F";
                    break;
                case 42:
                    a = "G";
                    break;
                case 43:
                    a = "H";
                    break;
                case 44:
                    a = "I";
                    break;
                case 45:
                    a = "G";
                    break;
                case 46:
                    a = "K";
                    break;
                case 47:
                    a = "L";
                    break;
                case 48:
                    a = "M";
                    break;
                case 49:
                    a = "N";
                    break;
                case 50:
                    a = "O";
                    break;
                case 51:
                    a = "P";
                    break;
                case 52:
                    a = "Q";
                    break;
                case 53:
                    a = "R";
                    break;
                case 54:
                    a = "S";
                    break;
                case 55:
                    a = "T";
                    break;
                case 56:
                    a = "U";
                    break;
                case 57:
                    a = "V";
                    break;
                case 58:
                    a = "W";
                    break;
                case 59:
                    a = "X";
                    break;
                case 60:
                    a = "Y";
                    break;
                case 61:
                    a = "Z";
                    break;

            }
            return a;
        }
    }
}
