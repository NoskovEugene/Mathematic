// Decompiled with JetBrains decompiler
// Type: ArithmeticGame.Converter.WinOrLoseColorConverter
// Assembly: ArithmeticGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 625C59E3-BBA8-4182-8131-A80E4A774EB1
// Assembly location: C:\Users\Eugene\Desktop\Ромкин калькулятор\ArithmeticGame.exe

using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace ArithmeticGame.Converter
{
  public class WinOrLoseColorConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) => (bool) value ? (object) new SolidColorBrush(Color.FromArgb(byte.MaxValue, (byte) 83, (byte) 112, (byte) 90)) : (object) new SolidColorBrush(Color.FromArgb(byte.MaxValue, (byte) 124, (byte) 67, (byte) 67));

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
