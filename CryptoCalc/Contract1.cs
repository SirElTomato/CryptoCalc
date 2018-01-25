using Neo.SmartContract.Framework;
using Neo.SmartContract.Framework.Services.Neo;
using System;
using System.Numerics;

namespace CryptoCalc
{
    public class Calculator : SmartContract
    {
        public static int Main(string operation, int number1, int number2)
        {
            Runtime.Notify("Operation started: ", number1, number2);
            int result = 0;

            if (operation == "add" || operation == "+")
            {
                result = Add(number1, number2);
            }

            if (operation == "subtract" || operation == "-")
            {
                result = Subtract(number1, number2);
            }

            Runtime.Notify("Calculation finished", operation, result);
            return result;
        }


        static private int Add(int a, int b)
        {
            int sum = a + b;

            Runtime.Notify("Add operation invoked with", a, b);
            Runtime.Notify("Add operation result", sum);

            return sum;
        }

        static private int Subtract(int a, int b)
        {
            int sum = a - b;

            Runtime.Notify("Subtract operation invoked with", a, b);
            Runtime.Notify("Subtract operation result", sum);

            return sum;
        }

        static private int Multiply(int a, int b)
        {
            int sum = a * b;

            Runtime.Notify("Multiply operation invoked with", a, b);
            Runtime.Notify("Multiply operation result", sum);

            return sum;
        }

        static private int Divide(int a, int b)
        {
            int sum = a / b;

            Runtime.Notify("Divide operation invoked with", a, b);
            Runtime.Notify("Divide operation result", sum);

            return sum;
        }
    }
}
