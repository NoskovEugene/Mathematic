// Decompiled with JetBrains decompiler
// Type: ArithmeticGame.Calculators.TreeCalculator
// Assembly: ArithmeticGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 625C59E3-BBA8-4182-8131-A80E4A774EB1
// Assembly location: C:\Users\Eugene\Desktop\Ромкин калькулятор\ArithmeticGame.exe

using Arithmetic.Elements;
using Arithmetic.Elements.Operators;
using Arithmetic.Extensions;
using System;

namespace ArithmeticGame.Calculators
{
  public class TreeCalculator
  {
    protected Random Generator { get; set; }

    public TreeCalculator(Random random) => this.Generator = random;

    public Equation Calc(Equation equation)
    {
      if (equation.Root == null)
        equation.Root = equation.Elements.PrepareTree();
      BinaryOperator binaryOperator = (BinaryOperator) equation.Root.Clone();
      int right = this.Generator.Next(0, (int) equation.EnableAnswer);
      double num = binaryOperator.Antonym.Invoke(equation.EnableAnswer, (double) right);
      binaryOperator.Right = (TreeElement) binaryOperator.Right.Convert<Variable>().ConvertToValue((double) right);
      binaryOperator.Left = (TreeElement) binaryOperator.Left.Convert<Variable>().ConvertToValue(num);
      equation.CurrentRoot = (TreeElement) binaryOperator;
      equation.CurrentElements = binaryOperator.ToElements();
      return equation;
    }
  }
}
