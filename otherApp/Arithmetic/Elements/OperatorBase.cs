// Decompiled with JetBrains decompiler
// Type: Arithmetic.Elements.OperatorBase
// Assembly: Arithmetic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AA6CF8E-54A1-41A7-AF96-F89BEC4ED8FF
// Assembly location: C:\Users\Eugene\Desktop\Arithmetic.dll

using System.Collections.Generic;

namespace Arithmetic.Elements
{
  public abstract class OperatorBase : TreeElement
  {
    public abstract double Result { get; set; }

    public abstract override List<TreeElement> ToElements();

    public abstract void Calc();
  }
}
