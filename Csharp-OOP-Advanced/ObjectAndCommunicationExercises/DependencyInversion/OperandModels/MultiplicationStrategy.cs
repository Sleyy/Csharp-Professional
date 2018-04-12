﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DependencyInversion.OperandModels
{
    public class MultiplicationStrategy
    {
        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand * secondOperand;
        }
    }
}
