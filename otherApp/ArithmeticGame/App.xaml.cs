// Decompiled with JetBrains decompiler
// Type: ArithmeticGame.App
// Assembly: ArithmeticGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 625C59E3-BBA8-4182-8131-A80E4A774EB1
// Assembly location: C:\Users\Eugene\Desktop\Ромкин калькулятор\ArithmeticGame.exe

using ArithmeticGame.ViewModels;
using Prism.Ioc;
using Prism.Unity;
using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Windows;

namespace ArithmeticGame
{
  public partial class App : PrismApplication
  {
    private bool _contentLoaded;

    protected override Window CreateShell() => (Window) this.Container.Resolve<MainWindow>();

    protected override void RegisterTypes(IContainerRegistry containerRegistry) => containerRegistry.Register<MainViewModel>();

    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public void InitializeComponent()
    {
      if (this._contentLoaded)
        return;
      this._contentLoaded = true;
      Application.LoadComponent((object) this, new Uri("/ArithmeticGame;component/app.xaml", UriKind.Relative));
    }

    [STAThread]
    [DebuggerNonUserCode]
    [GeneratedCode("PresentationBuildTasks", "4.0.0.0")]
    public static void Main()
    {
      App app = new App();
      app.InitializeComponent();
      app.Run();
    }
  }
}
