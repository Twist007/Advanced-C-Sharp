namespace _03.Calculator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Calculator
    {
        static void Main()
        {
            Console.Write("Insert your expression (operands and operators separated by space) = ");
            List<string> list = Console.ReadLine()
                .Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            decimal result = 0;

            while (list.Contains("*") || list.Contains("/"))
            {
                for (int i = 0; i < list.Count; i++)
                {
                    string token = list[i];
                    if (token == "*" || token == "/")
                    {
                        decimal leftOperand = decimal.Parse(list[i - 1]);
                        decimal rightOperand = decimal.Parse(list[i + 1]);
                        string op = token;

                        result = CalculateMulDiv(leftOperand, rightOperand, op);
                        list.RemoveRange(i - 1, 3);
                        list.Insert(i - 1, result.ToString());
                    }
                }
            }

            while (list.Count > 1)
            {
                decimal leftOperand = decimal.Parse(list[0]);
                decimal rightOperand = decimal.Parse(list[2]);
                string op = list[1];

                result = CalculateAddSub(leftOperand, rightOperand, op);
                list.RemoveRange(0, 3);
                list.Insert(0, result.ToString());
            }

            Console.WriteLine("Result = {0}", result);
        }

        static decimal CalculateAddSub(decimal left, decimal right, string op)
        {
            switch (op)
            {
                case "+":
                    return left + right;
                default:
                    return left - right;
            }
        }

        static decimal CalculateMulDiv(decimal left, decimal right, string op)
        {
            switch (op)
            {
                case "*":
                    return left * right;
                default:
                    return left / right;
            }
        }
    }
}
