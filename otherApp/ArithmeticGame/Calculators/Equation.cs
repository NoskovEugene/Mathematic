// Decompiled with JetBrains decompiler
// Type: ArithmeticGame.Calculators.Equation
// Assembly: ArithmeticGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 625C59E3-BBA8-4182-8131-A80E4A774EB1
// Assembly location: C:\Users\Eugene\Desktop\Ромкин калькулятор\ArithmeticGame.exe

using Arithmetic.Elements;
using System.Collections.Generic;

namespace ArithmeticGame.Calculators
{
  public class Equation
  {
    public int Index { get; set; }

    public List<TreeElement> Elements { get; set; }

    public List<TreeElement> CurrentElements { get; set; }

    public TreeElement Root { get; set; }

    public TreeElement CurrentRoot { get; set; }

    public double EnableAnswer { get; set; }
  }
}
