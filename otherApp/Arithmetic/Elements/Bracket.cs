// Decompiled with JetBrains decompiler
// Type: Arithmetic.Elements.Bracket
// Assembly: Arithmetic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AA6CF8E-54A1-41A7-AF96-F89BEC4ED8FF
// Assembly location: C:\Users\Eugene\Desktop\Arithmetic.dll

using Arithmetic.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Arithmetic.Elements
{
  public class Bracket : TreeElement, IElementState
  {
    public TreeElement Root { get; set; }

    public List<TreeElement> Elements { get; set; }

    public bool Synced { get; set; }

    public Bracket()
    {
      this.Priority = 10;
      this.ElementType = ElementTypeEnum.Bracket;
      this.Elements = new List<TreeElement>();
    }

    public int VariablesCount()
    {
      int num = this.Elements.Where<TreeElement>((Func<TreeElement, bool>) (x => x.ElementType == ElementTypeEnum.Variable)).Count<TreeElement>();
      foreach (Bracket bracket in this.Elements.Where<TreeElement>((Func<TreeElement, bool>) (x => x.ElementType == ElementTypeEnum.Bracket)).Select<TreeElement, Bracket>((Func<TreeElement, Bracket>) (x => (Bracket) x)))
        num += bracket.VariablesCount();
      return num;
    }

    public int SyncCollection(int sourceVariableCount)
    {
      foreach (Variable variable in this.Elements.Where<TreeElement>((Func<TreeElement, bool>) (x => x.ElementType == ElementTypeEnum.Variable)).Select<TreeElement, Variable>((Func<TreeElement, Variable>) (x => (Variable) x)))
      {
        variable.Sync(sourceVariableCount);
        ++sourceVariableCount;
      }
      foreach (Bracket bracket in this.Elements.Where<TreeElement>((Func<TreeElement, bool>) (x => x.ElementType == ElementTypeEnum.Bracket)).Select<TreeElement, Bracket>((Func<TreeElement, Bracket>) (x => (Bracket) x)))
        sourceVariableCount += bracket.SyncCollection(sourceVariableCount);
      return sourceVariableCount;
    }

    public override object Clone()
    {
      Bracket bracket = new Bracket();
      bracket.Index = this.Index;
      bracket.Elements = this.Elements.Select<TreeElement, TreeElement>((Func<TreeElement, TreeElement>) (x => (TreeElement) x.Clone())).ToList<TreeElement>();
      return (object) bracket;
    }

    public override string ToString() => "(" + string.Join<TreeElement>("", (IEnumerable<TreeElement>) this.Elements) + ")";

    public override List<TreeElement> ToElements() => new List<TreeElement>()
    {
      (TreeElement) this
    };
  }
}
