
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
            Onza = 7,
            Centimetro = 8,
            Metro = 9,
            Kilometro = 10
        }

        //KILOGRAM
        private static double ConvertKgToG(double peso1)
        {
            double newWeight = peso1 * 1000;
            return newWeight;
        }
        private static double ConvertKgToPounds(double peso1)
        {
            double newWeight = peso1 * 2.205;
            return newWeight;
        }
        private static double ConvertKgToOnza(double peso1)
        {
            double newWeight = peso1 * 35.274;
            return newWeight;
        }

        // GRAMO
        private static double ConvertGToKG(double peso1)
        {
            double newWeight = peso1 / 1000;
            return newWeight;
        }
        private static double ConvertGToPounds(double peso1)
        {
            double newWeight = peso1 / 453.592;
            return newWeight;
        }
        private static double ConvertGToOnzas(double peso1)
        {
            double newWeight = peso1 / 28.35;
            return newWeight;
        }

        //LIBRA
        private static double ConvertPoundsToKilograms(double peso1)
        {
            double newWeight = peso1 / 2.205;
            return newWeight;
        }
        private static double ConvertPoundsToGrams(double peso1)
        {
            double newWeight = peso1 * 453.592;
            return newWeight;
        }
        private static double ConvertPoundsToOnzas(double peso1)
        {
            double newWeight = peso1 * 16;
            return newWeight;
        }

        //ONZAS
        private static double ConvertOnzasToKilograms(double peso1)
        {
            double newWeight = peso1 / 35.274;
            return newWeight;
        }

        private static double ConvertOnzasToGrams(double peso1)
        {
            double newWeight = peso1 * 28.35;
            return newWeight;
        }
        private static double ConvertOnzasToPounds(double peso1)
        {
            double newWeight = peso1 / 16;
            return newWeight;
        }
        // TEMPERATURAS
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

        // DISTANCIA
        //CENTIMETRO
        private static double ConvertCMToM(double distance1)
        {
            double newDistance = distance1 / 100;
            return newDistance;
        }


        private static double ConvertCMToKM(double distance1)
        {
            double newDistance = distance1 / 100000;
            return newDistance;
        }

        //METRO

        private static double ConvertMToKM(double distance1)
        {
            double newDistance = distance1 / 1000;
            return newDistance;
        }

        private static double ConvertMToCM(double distance1)
        {
            double newDistance = distance1 * 100;
            return newDistance;
        }

        //KILOMETRO
        private static double ConvertKMToCM(double distance1)
        {
            double newDistance = distance1 * 100000;
            return newDistance;
        }

        private static double ConvertKMToM(double distance1)
        {
            double newDistance = distance1 * 1000;
            return newDistance;
        }

        public static double selectOption(double unitTotal, int uni1, int temp2Unit)
        {
            double result = 0;

            switch (uni1)
            {
                // Celsius
                case 1:
                    // c to k
                    if (temp2Unit == 2)
                        result = ConvertCelsiusToKelvin(unitTotal);
                    // c to f
                    else if (temp2Unit == 3)
                        result = ConvertCelsiusToFahrenheit(unitTotal);
                    break;
                //Kelvin
                case 2:
                    if (temp2Unit == 1)
                        result = ConvertKelvinToCelsius(unitTotal);
                    else if (temp2Unit == 3)
                        result = ConvertKelvinToFarenheit(unitTotal);

                    break;
                // Faren
                case 3:
                    if (temp2Unit == 1)
                        result = ConvertFarenheitToCelsius(unitTotal);
                    else if (temp2Unit == 2)
                        result = ConvertFarenheitToKelvin(unitTotal);
                    break;
                // kilogram
                case 4:
                    // kg to g
                    if (temp2Unit == 5)
                        result = ConvertKgToG(unitTotal);
                    else if (temp2Unit == 6)
                        result = ConvertKgToPounds(unitTotal);
                    else if (temp2Unit == 7)
                        result = ConvertKgToOnza(unitTotal);
                    break;
                case 5:
                    if (temp2Unit == 4)
                        result = ConvertGToKG(unitTotal);
                    else if (temp2Unit == 6)
                        result = ConvertGToPounds(unitTotal);
                    else if (temp2Unit == 7)
                        result = ConvertGToOnzas(unitTotal);
                    break;
                case 6:
                    if (temp2Unit == 4)
                        result = ConvertPoundsToKilograms(unitTotal);
                    else if (temp2Unit == 5)
                        result = ConvertPoundsToGrams(unitTotal);
                    else if (temp2Unit == 7)
                        result = ConvertPoundsToOnzas(unitTotal);
                    break;

                case 7:
                    if (temp2Unit == 4)
                        result = ConvertOnzasToKilograms(unitTotal);
                    else if (temp2Unit == 5)
                        result = ConvertOnzasToGrams(unitTotal);
                    else if (temp2Unit == 6)
                        result = ConvertOnzasToPounds(unitTotal);
                    break;
                case 8:
                    if (temp2Unit == 9)
                        result = ConvertCMToM(unitTotal);
                    else if (temp2Unit == 10)
                        result = ConvertCMToKM(unitTotal);
                    break;
                case 9:
                    if (temp2Unit == 8)
                        result = ConvertMToCM(unitTotal);
                    else if (temp2Unit == 10)
                        result = ConvertMToKM(unitTotal);
                    break;
                case 10:
                    if (temp2Unit == 8)
                        result = ConvertKMToCM(unitTotal);
                    else if (temp2Unit == 9)
                        result = ConvertKMToM(unitTotal);
                    break;
            }

            return result;
        }
        public static void SwitchConverter(string _value)
        {
            _value = _value.Replace("to", "");
            _value = _value.Replace("To", "");
            _value = _value.Replace("TO", "");
            _value = _value.Replace("tO", "");

            if (!String.IsNullOrEmpty(_value))
            {

                string[] arrUx = _value.Split(' ');
                arrUx = arrUx.ToList().Where(p => p != "").ToArray();
                if (arrUx.Count() == 3)
                {
                    string unit1 = arrUx[1];

                    if (unit1.ToLower() == "f" || unit1.ToLower() == "c" || unit1.ToLower() == "k"
                                            || unit1.ToLower() == "kg" || unit1.ToLower() == "g" ||
                                            unit1.ToLower() == "l" || unit1.ToLower() == "oz" || unit1.ToLower() == "cm" || unit1.ToLower() == "m" || unit1.ToLower() == "km")
                    {
                        //ConverterClass obj = new ConverterClass();
                        //obj.TempetureConverter(Convert.ToDouble(arrUx[0]), GetTempUnit(arrUx[1]), GetTempUnit(arrUx[3]));

                        if (!Perteneciente((int)GetUnit(arrUx[1]), (int)GetUnit(arrUx[2])))
                        {
                            leyenda();
                        }
                        double rt = selectOption(Convert.ToDouble(arrUx[0]), (int)GetUnit(arrUx[1]), (int)GetUnit(arrUx[2]));

                        Console.WriteLine(rt.ToString() + " " + arrUx[2]);

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
            else if (_value == "kg")
            {
                return EConvert.Kilogram;
            }
            else if (_value == "g")
            {
                return EConvert.Gram;
            }
            else if (_value == "l")
            {
                return EConvert.Pound;
            }
            else if (_value == "oz")
            {
                return EConvert.Onza;
            }
            else if (_value == "cm")
            {
                return EConvert.Centimetro;
            }
            else if (_value == "m")
            {
                return EConvert.Metro;
            }
            else if (_value == "km")
            {
                return EConvert.Kilometro;
            }
            else
            {
                throw new Exception("Ha ingresado una unidad invalida.");
            }
        }

        static void Main(string[] args)
        {

            string _userInput = String.Empty;
            leyenda();
            while (_userInput.ToLower() != "s")
            {
                Console.WriteLine("Ingresa lo que necesitas convertir: ");
                _userInput = Console.ReadLine();
                SwitchConverter(_userInput);
            }
        }

        public static void leyenda()
        {
            Console.WriteLine("Celcius: C");
            Console.WriteLine("Kelvin: K");
            Console.WriteLine("Farenheit: F");
            Console.WriteLine("Kilogramo: Kg");
            Console.WriteLine("Gramo: G");
            Console.WriteLine("Libra: Lb");
            Console.WriteLine("Onza: Oz");
            Console.WriteLine("Centimetro: Cm");
            Console.WriteLine("Metro: M");
            Console.WriteLine("Kilometro: Km");
            Console.WriteLine("Byte: B");
            Console.WriteLine("Kilobyte: Kb");
            Console.WriteLine("Megabyte: Mb");
            Console.WriteLine("Gigabyte: Gb");
            Console.WriteLine("Presione s para salir");
        }

        public static bool Perteneciente(int u1, int u2)
        {

            if (1 <= u1 && u1 <= 3 && 1 <= u2 && u2 <= 3) { return true; }
            else if (4 <= u1 && u1 <= 7 && 4 <= u2 && u2 <= 7) { return true; }
            else if (8 <= u1 && u1 <= 10 && 8 <= u2 && u2 <= 10) { return true; }
            else if (8 <= u1 && u1 <= 10 && 8 <= u2 && u2 <= 10) { return true; }
            else if (11 <= u1 && u1 <= 14 && 11 <= u2 && u2 <= 14) { return true; }
            return false;
        }
    }
}