// Decompiled with JetBrains decompiler
// Type: ArithmeticGame.Validators.MathValidator
// Assembly: ArithmeticGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 625C59E3-BBA8-4182-8131-A80E4A774EB1
// Assembly location: C:\Users\Eugene\Desktop\Ромкин калькулятор\ArithmeticGame.exe

using Arithmetic.Elements;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ArithmeticGame.Validators
{
  public class MathValidator : IMathValidator
  {
    public List<Rule> Rules { get; set; }

    public MathValidator() => this.Rules = new List<Rule>();

    public bool Validate(List<TreeElement> elements)
    {
      if (elements == null || elements.Count == 0)
        return false;
      foreach (Rule rule1 in this.Rules)
      {
        Rule rule = rule1;
        foreach (TreeElement treeElement in elements.Where<TreeElement>((Func<TreeElement, bool>) (x => x.ElementType == rule.ForElement)))
        {
          if (!rule.Predicate(treeElement))
            return false;
        }
      }
      return true;
    }

    public IMathValidator ShouldBe(
      Predicate<TreeElement> predicate,
      ElementTypeEnum forElements)
    {
      this.Rules.Add(new Rule()
      {
        ForElement = forElements,
        Predicate = predicate
      });
      return (IMathValidator) this;
    }
  }
}
