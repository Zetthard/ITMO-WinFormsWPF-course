using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFCalculator
{
    class CalcEngine
    {

        //
        // Operation Constants.
        //
        public enum Operator : int
        {
            eUnknown = 0,
            eAdd = 1,
            eSubtract = 2,
            eMultiply = 3,
            eDivide = 4,
            ePow = 5
        }

        //
        // Module-Level Constants
        //

        private static readonly double negativeConverter = -1;
        private static readonly string versionInfo = "Calculator v3.0.1.1";

        //
        // Module-level Variables.
        //

        private static double numericAnswer;
        private static string stringAnswer;
        private static Operator calcOperation;
        private static double firstNumber;
        private static double secondNumber;
        private static bool secondNumberAdded;
        private static bool decimalAdded;

        //
        // Class Constructor.
        //

        public CalcEngine()
        {
            decimalAdded = false;
            secondNumberAdded = false;
        }

        //
        // Returns the custom version string to the caller.
        //

        public static string GetVersion()
        {
            return (versionInfo);
        }
        //
        // Called when the Date key is pressed.
        //

        public static string GetDate()
        {
            DateTime curDate = new DateTime();
            curDate = DateTime.Now;

            stringAnswer = String.Concat(curDate.ToShortDateString(), " ", curDate.ToLongTimeString());

            return (stringAnswer);
        }

        //
        // Called when a number key is pressed on the keypad.
        //

        public static string CalcNumber(string KeyNumber)
        {
            stringAnswer += KeyNumber;
            return (stringAnswer);
        }

        //
        // Called when an operator is selected (+, -, *, /)
        //

        public static void CalcOperation(Operator calcOper)
        {
            if (stringAnswer != "" && !secondNumberAdded)
            {
                firstNumber = Convert.ToDouble(stringAnswer);
                calcOperation = calcOper;
                stringAnswer = "";
                decimalAdded = false;
            }
        }

        //
        // Called when the +/- key is pressed.
        //

        public static string CalcSign()
        {
            double numHold;

            if (stringAnswer != "")
            {
                numHold = Convert.ToDouble(stringAnswer);
                stringAnswer = Convert.ToString(numHold * negativeConverter);
            }

            return (stringAnswer);
        }

        //
        // Called when the . key is pressed.
        //

        public static string CalcDecimal()
        {
            if (!decimalAdded && !secondNumberAdded)
            {
                if (stringAnswer != "")
                    stringAnswer += ",";
                else
                    stringAnswer = "0,";

                decimalAdded = true;
            }

            return (stringAnswer);
        }

        //
        // Called when = is pressed.
        //

        public static string CalcEqual()
        {
            if (stringAnswer != "")
            {
                secondNumber = Convert.ToDouble(stringAnswer);
                secondNumberAdded = true;

                switch (calcOperation)
                {
                    case Operator.eUnknown:
                        break;

                    case Operator.eAdd:
                        numericAnswer = firstNumber + secondNumber;
                        break;

                    case Operator.eSubtract:
                        numericAnswer = firstNumber - secondNumber;
                        break;

                    case Operator.eMultiply:
                        numericAnswer = firstNumber * secondNumber;
                        break;

                    case Operator.eDivide:
                        numericAnswer = firstNumber / secondNumber;
                        break;
                    case Operator.ePow:
                        numericAnswer = Math.Pow(firstNumber, secondNumber);
                        break;

                    default:
                        break;
                }
                decimalAdded = true;
            }
            return Convert.ToString(numericAnswer);
        }

        public static string CalcPercent()
        {
            if (stringAnswer != "" && !secondNumberAdded)
            {
                firstNumber = Convert.ToDouble(stringAnswer);
                stringAnswer = Convert.ToString(firstNumber / 100);
            }
            return stringAnswer;
        }

        public static string CalcSquare()
        {
            if (stringAnswer != "")
            {
                firstNumber = Convert.ToDouble(stringAnswer);
                stringAnswer = Convert.ToString(firstNumber * firstNumber);
            }
            return (stringAnswer);
        }

        public static string CalcCube()
        {
            if (stringAnswer != "")
            {
                firstNumber = Convert.ToDouble(stringAnswer);
                stringAnswer = Convert.ToString(firstNumber * firstNumber * firstNumber);
            }
            return (stringAnswer);
        }

        public static string CalcSqrt()
        {
            if (stringAnswer != "")
            {
                firstNumber = Convert.ToDouble(stringAnswer);
                stringAnswer = Convert.ToString(Math.Sqrt(firstNumber));
            }
            return (stringAnswer);
        }

        public static string CalcCubert()
        {
            if (stringAnswer != "")
            {
                firstNumber = Convert.ToDouble(stringAnswer);
                stringAnswer = Convert.ToString(Math.Pow(firstNumber, (double) 1/3));
            }
            return (stringAnswer);
        }

        public static string CalcOneOverX()
        {
            if (stringAnswer != "")
            {
                firstNumber = Convert.ToDouble(stringAnswer);
                stringAnswer = Convert.ToString(1 / firstNumber);
            }
            return (stringAnswer);
        }

        public static int CalcFact()
        {
            int fact = 1;
            if (int.TryParse(stringAnswer, out int number))
            {
                for (int x = 1; x <= number; x++)
                    fact *= x;
            }
            return fact;
        }

        internal static double QuadForm(int a, int b, int c, Boolean pos)
        {
            double x;
            if (pos)
                x = (-b + Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            else
                x = (-Math.Abs(b) - Math.Sqrt(b * b - 4 * a * c)) / (2 * a);
            return x;
        }

        //
        // Resets the various module-level variables for the next calculation.
        //

        public static void CalcReset()
        {
            numericAnswer = 0;
            firstNumber = 0;
            secondNumber = 0;
            stringAnswer = "";
            calcOperation = Operator.eUnknown;
            decimalAdded = false;
            secondNumberAdded = false;
        }

        public static void CalcEqualPressed()
        {
            stringAnswer = Convert.ToString(numericAnswer);
            secondNumber = 0;
            calcOperation = Operator.eUnknown;
            secondNumberAdded = false;
        }
    }
}
