// Decompiled with JetBrains decompiler
// Type: ArithmeticGame.Converter.KeyEnumToEffectConverter
// Assembly: ArithmeticGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 625C59E3-BBA8-4182-8131-A80E4A774EB1
// Assembly location: C:\Users\Eugene\Desktop\Ромкин калькулятор\ArithmeticGame.exe

using System;
using System.Globalization;
using System.Windows.Data;

namespace ArithmeticGame.Converter
{
  public class KeyEnumToEffectConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
      int num = int.Parse(parameter.ToString());
      return (int) value == num ? (object) 5 : (object) 0;
    }

    public object ConvertBack(
      object value,
      Type targetType,
      object parameter,
      CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
