// Decompiled with JetBrains decompiler
// Type: ArithmeticGame.Validators.Rule
// Assembly: ArithmeticGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 625C59E3-BBA8-4182-8131-A80E4A774EB1
// Assembly location: C:\Users\Eugene\Desktop\Ромкин калькулятор\ArithmeticGame.exe

using Arithmetic.Elements;

namespace ArithmeticGame.Validators
{
  public class Rule
  {
    public ElementTypeEnum ForElement { get; set; }

    public System.Predicate<TreeElement> Predicate { get; set; }
  }
}
