// Decompiled with JetBrains decompiler
// Type: Arithmetic.Elements.Operators.Actions
// Assembly: Arithmetic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AA6CF8E-54A1-41A7-AF96-F89BEC4ED8FF
// Assembly location: C:\Users\Eugene\Desktop\Arithmetic.dll

using Arithmetic.Elements.UnaryOperators;
using Arithmetic.Extensions;
using System;
using System.Collections.Generic;

namespace Arithmetic.Elements.Operators
{
    public static class Actions
    {
        public static Dictionary<ElementTypeEnum, Func<TreeElement, double>> Action =
            new Dictionary<ElementTypeEnum, Func<TreeElement, double>>()
            {
                {
                    ElementTypeEnum.Value,
                    (Func<TreeElement, double>)(x => x.Convert<Value>().Result)
                },
                {
                    ElementTypeEnum.BinaryOperator,
                    (Func<TreeElement, double>)(x =>
                    {
                        BinaryOperator binaryOperator = x.Convert<BinaryOperator>();
                        binaryOperator.Calc();
                        return binaryOperator.Result;
                    })
                },
                {
                    ElementTypeEnum.UnaryOperator,
                    (Func<TreeElement, double>)(x =>
                    {
                        UnaryOperator unaryOperator = x.Convert<UnaryOperator>();
                        unaryOperator.Calc();
                        return unaryOperator.Result;
                    })
                }
            };
    }
}