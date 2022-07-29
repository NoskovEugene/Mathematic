// Decompiled with JetBrains decompiler
// Type: ArithmeticGame.Extensions.WindowExtensions
// Assembly: ArithmeticGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 625C59E3-BBA8-4182-8131-A80E4A774EB1
// Assembly location: C:\Users\Eugene\Desktop\Ромкин калькулятор\ArithmeticGame.exe

using System.Windows;

namespace ArithmeticGame.Extensions
{
  public static class WindowExtensions
  {
    public static T Context<T>(this Window window) => (T) window.DataContext;
  }
}
