using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        public enum EConvert
        {
            Celcius = 1,
            Kelvin = 2,
            Farenheit = 3,
            Kilogram = 4,
            Gram = 5,
            Pound = 6,
            Onza = 7
        }

        public static double ConvertCelsiusToFahrenheit(double c)
        {
            return ((9.0 / 5.0) * c) + 32;
        }

        public static double ConvertCelsiusToKelvin(double c)
        {
            return c + 273.15;
        }

        public static double ConvertKelvinToCelsius(double k)
        {
            return k - 273.15;
        }

        private static double ConvertFarenheitToCelsius(double gradoT1)
        {
            double newtemp = (gradoT1 - 32) * 5 / 9;
            return newtemp;
        }
        private static double ConvertFarenheitToKelvin(double gradoT1)
        {
            double newtemp = (gradoT1 - 32) * 5 / 9 + 273.15;
            return newtemp;
        }
        private static double ConvertKelvinToFarenheit(double gradoT1)
        {
            double newtemp = (gradoT1 - 273.15) * 9 / 5 + 32;
            return newtemp;
        }
        public static double selectOption(double temp, int temp1Unit, int temp2Unit)
        {
            double result = 0;

            switch (temp1Unit)
            {
                // Celsius
                case 1:
                    // c to f
                    if (temp2Unit == 2)
                        result = ConvertCelsiusToFahrenheit(temp);
                    else if (temp2Unit == 3)
                        result = ConvertCelsiusToKelvin(temp);
                    break;
                //Kelvin
                case 3:
                    if (temp2Unit == 1)
                        result = ConvertKelvinToCelsius(temp);
                    break;
            }

            return result;
        }

        public static void SwitchConverter(string _value)
        {

            if (!String.IsNullOrEmpty(_value))
            {
                string[] arrUx = _value.Split(' ');
                if (arrUx.Count() != 3)
                {
                    string unit1 = arrUx[1];

                    if (unit1.ToLower() == "f" || unit1.ToLower() == "c" || unit1.ToLower() == "k" || unit1.ToLower() == "kg" || unit1.ToLower() == "g" || unit1.ToLower() == "l" || unit1.ToLower() == "oz")
                    {
                        //ConverterClass obj = new ConverterClass();
                        //obj.TempetureConverter(Convert.ToDouble(arrUx[0]), GetTempUnit(arrUx[1]), GetTempUnit(arrUx[3]));
                        double rt = selectOption(Convert.ToDouble(arrUx[0]), (int)GetUnit(arrUx[1]), (int)GetUnit(arrUx[2]));

                        Console.WriteLine(rt.ToString() + " " + arrUx[2]);

                    }
                }
                else
                {
                    Console.WriteLine("Ingrese una entrada valida.");
                }
            }
            else
            {
                Console.WriteLine("Ingrese una entrada valida.");
            }
        }

        public static EConvert GetUnit(string _value)
        {
            if (_value == "c")
            {
                return EConvert.Celcius;
            }
            else if (_value == "k")
            {
                return EConvert.Kelvin;
            }
            else if (_value == "f")
            {
                return EConvert.Farenheit;
            }
            else
            {
                throw new Exception("Ha ingresado una unidad invalida.");
            }
        }

        static void Main(string[] args)
        {
            string _userInput = String.Empty;

            Console.WriteLine("Ingresa lo que necesitas convertir: ");
            _userInput = Console.ReadLine();
            SwitchConverter(_userInput);
            Console.ReadLine();
        }
    }
}