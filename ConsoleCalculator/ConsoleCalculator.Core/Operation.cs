using System;

namespace ConsoleCalculator.Core
{
    public enum OperatorsEnum
    {
        ADD,
        SUBSTRACT,
        MULTIPLY,
        DIVIDE
    }

    public class Operation
    {
        public OperatorsEnum OperatorEnum { get; set; }
        public int LeftValue { get; set; }
        public int RightValue { get; set; }

        public Operation(string operatorString, int leftValue, int rightValue)
        {
            switch (operatorString)
            {
                case "+":
                    OperatorEnum = OperatorsEnum.ADD;
                    break;
                case "-":
                    OperatorEnum = OperatorsEnum.SUBSTRACT;
                    break;
                case "*":
                    OperatorEnum = OperatorsEnum.MULTIPLY;
                    break;
                case "/":
                    OperatorEnum = OperatorsEnum.DIVIDE;
                    break;
                default:
                    throw new Exception("Operator invalid");
            }

            LeftValue = leftValue;
            RightValue = rightValue;
        }

        public int DoOperation()
        {
            switch (OperatorEnum)
            {
                case OperatorsEnum.ADD:
                    return LeftValue + RightValue;
                case OperatorsEnum.SUBSTRACT:
                    return LeftValue - RightValue;
                case OperatorsEnum.MULTIPLY:
                    return LeftValue * RightValue;
                case OperatorsEnum.DIVIDE:
                    return LeftValue / RightValue;
                default:
                    throw new Exception("Operator is not valid");
            }
        }
    }
}
