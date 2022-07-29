// Decompiled with JetBrains decompiler
// Type: ArithmeticGame.Validators.IMathValidator
// Assembly: ArithmeticGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 625C59E3-BBA8-4182-8131-A80E4A774EB1
// Assembly location: C:\Users\Eugene\Desktop\Ромкин калькулятор\ArithmeticGame.exe

using Arithmetic.Elements;
using System;
using System.Collections.Generic;

namespace ArithmeticGame.Validators
{
  public interface IMathValidator
  {
    List<Rule> Rules { get; set; }

    IMathValidator ShouldBe(
      Predicate<TreeElement> predicate,
      ElementTypeEnum forElements);

    bool Validate(List<TreeElement> elements);
  }
}
