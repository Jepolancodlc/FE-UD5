using System;
using System.Collections.Generic;
using System.Text;

namespace UD5
{
    class Menu
    {
        public void menu()
        {
            Console.WriteLine("Seleccione el numero del ejercicio al que desea acceder (1-21) ");
            string e = Console.ReadLine();

            switch (e)
            {
                case "1":
                    e1 e1 = new e1();
                    e1.exe1();
                    break;
                case "2":
                    e2 e2 = new e2();
                    e2.exe2();
                    break;
                case "3":
                    e3 e3 = new e3();
                    e3.exe3();
                    break;
                case "4":
                    e4 e4 = new e4();
                    e4.exe4();
                    break;
                case "5":
                    e5 e5 = new e5();
                    e5.exe5();
                    break;
                case "6":
                    e6 e6 = new e6();
                    e6.exe6();
                    break;
                case "7":
                    e7 e7 = new e7();
                    e7.exe7(0, "");
                    break;
                case "8":
                    e8 e8 = new e8();
                    e8.exe8();
                    break;
                case "9":
                    e9 e9 = new e9();
                    e9.exe9();
                    break;
                case "10":
                       e10 e10 = new e10();
                       e10.exe10();
                       break;
                   case "11":
                       e11 e11 = new e11();
                       e11.exe11();
                       break;
                   case "12":
                       e12 e12 = new e12();
                       e12.exe12();
                       break;
                   case "13":
                       e13 e13= new e13();
                       e13.exe13();
                       break;
                   case "14":
                       e14 e14 = new e14();
                       e14.exe14();
                       break;
                case "15":
                    e15 e15 = new e15();
                    e15.exe15();
                    break;
                case "16":
                    e16 e16 = new e16();
                    e16.exe16();
                    break;
                case "17":
                    e17 e17 = new e17();
                    e17.exe17();
                    break;
                case "18":
                    e18 e18 = new e18();
                    e18.exe18();
                    break;
                case "19":
                    e19 e19 = new e19();
                    e19.exe19();
                    break; 
               case "20":
                    e20 e20 = new e20();
                    e20.exe20();
                    break; 
                case "21": 
                    e21 e21 = new e21();
                    e21.exe21();
                    break;


                default: Console.WriteLine("Numero incorrecto");
                    break;

            }
        }
    }
}
