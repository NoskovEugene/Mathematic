// Decompiled with JetBrains decompiler
// Type: ArithmeticGame.Calculators.EquationController
// Assembly: ArithmeticGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 625C59E3-BBA8-4182-8131-A80E4A774EB1
// Assembly location: C:\Users\Eugene\Desktop\Ромкин калькулятор\ArithmeticGame.exe

using Arithmetic.Elements;
using Arithmetic.Extensions;
using System;
using System.Collections.Generic;

namespace ArithmeticGame.Calculators
{
  public class EquationController
  {
    public List<Equation> EnabledEquations { get; set; }

    protected Random Random { get; set; }

    public EquationController(Random random)
    {
      this.Random = random;
      this.EnabledEquations = new List<Equation>()
      {
        new Equation()
        {
          Index = 0,
          Elements = new List<TreeElement>().Var(true, true).Plus().Var(true, true),
          EnableAnswer = 10.0
        },
        new Equation()
        {
          Index = 1,
          Elements = new List<TreeElement>().Var(true, true).Minus().Var(true, true),
          EnableAnswer = 10.0
        }
      };
    }

    public Equation GetRandom() => this.EnabledEquations[this.Random.Next(0, this.EnabledEquations.Count)];
  }
}
