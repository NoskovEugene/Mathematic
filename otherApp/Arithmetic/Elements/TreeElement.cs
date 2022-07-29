// Decompiled with JetBrains decompiler
// Type: Arithmetic.Elements.TreeElement
// Assembly: Arithmetic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AA6CF8E-54A1-41A7-AF96-F89BEC4ED8FF
// Assembly location: C:\Users\Eugene\Desktop\Arithmetic.dll

using System;
using System.Collections.Generic;

namespace Arithmetic.Elements
{
  public abstract class TreeElement : ICloneable
  {
    public int Index { get; set; }

    public ElementTypeEnum ElementType { get; protected set; }

    public int Priority { get; protected set; }

    public abstract object Clone();

    public abstract List<TreeElement> ToElements();

    public abstract override string ToString();
  }
}
