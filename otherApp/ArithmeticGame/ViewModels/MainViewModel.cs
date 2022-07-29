// Decompiled with JetBrains decompiler
// Type: ArithmeticGame.ViewModels.MainViewModel
// Assembly: ArithmeticGame, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 625C59E3-BBA8-4182-8131-A80E4A774EB1
// Assembly location: C:\Users\Eugene\Desktop\Ромкин калькулятор\ArithmeticGame.exe

using Arithmetic.Elements;
using Arithmetic.Extensions;
using ArithmeticGame.Calculators;
using ArithmeticGame.Controllers;
using ArithmeticGame.Enums;
using ArithmeticGame.Validators;
using Prism.Commands;
using Prism.Mvvm;
using System;

namespace ArithmeticGame.ViewModels
{
  public class MainViewModel : BindableBase
  {
    private string title;
    private string winStatText;
    private int winStatCount;
    private string losingStatText;
    private int losingStatCount;
    private string leftImage;
    private string rightImage;
    private string equation;
    private string answerString;
    private string winOrLoseText;
    private bool winOrLoseFlag;
    private bool showTrueAnswer;
    private string trueAnswerText;
    private int trueAnswer;
    private KeysEnum demoKey;
    private readonly DelegateCommand<string> numericClick;
    private readonly DelegateCommand deleteClick;
    private readonly DelegateCommand submitClick;

    public string Title
    {
      get => this.title;
      set => this.SetProperty<string>(ref this.title, value, nameof (Title));
    }

    public string WinStatText
    {
      get => this.winStatText;
      set => this.SetProperty<string>(ref this.winStatText, value, nameof (WinStatText));
    }

    public int WinStatCount
    {
      get => this.winStatCount;
      set => this.SetProperty<int>(ref this.winStatCount, value, nameof (WinStatCount));
    }

    public string LosingStatText
    {
      get => this.losingStatText;
      set => this.SetProperty<string>(ref this.losingStatText, value, nameof (LosingStatText));
    }

    public int LosingStatCount
    {
      get => this.losingStatCount;
      set => this.SetProperty<int>(ref this.losingStatCount, value, nameof (LosingStatCount));
    }

    public string LeftImage
    {
      get => this.leftImage;
      set => this.SetProperty<string>(ref this.leftImage, value, nameof (LeftImage));
    }

    public string RightImage
    {
      get => this.rightImage;
      set => this.SetProperty<string>(ref this.rightImage, value, nameof (RightImage));
    }

    public string Equation
    {
      get => this.equation;
      set => this.SetProperty<string>(ref this.equation, value, nameof (Equation));
    }

    public string AnswerString
    {
      get => this.answerString;
      set => this.SetProperty<string>(ref this.answerString, value, nameof (AnswerString));
    }

    public string WinOrLoseText
    {
      get => this.winOrLoseText;
      set => this.SetProperty<string>(ref this.winOrLoseText, value, nameof (WinOrLoseText));
    }

    public bool WinOrLoseFlag
    {
      get => this.winOrLoseFlag;
      set => this.SetProperty<bool>(ref this.winOrLoseFlag, value, nameof (WinOrLoseFlag));
    }

    public bool ShowTrueAnswer
    {
      get => this.showTrueAnswer;
      set => this.SetProperty<bool>(ref this.showTrueAnswer, value, nameof (ShowTrueAnswer));
    }

    public string TrueAnswerText
    {
      get => this.trueAnswerText;
      set => this.SetProperty<string>(ref this.trueAnswerText, value, nameof (TrueAnswerText));
    }

    public int TrueAnswer
    {
      get => this.trueAnswer;
      set => this.SetProperty<int>(ref this.trueAnswer, value, nameof (TrueAnswer));
    }

    public KeysEnum DemoKey
    {
      get => this.demoKey;
      set => this.SetProperty<KeysEnum>(ref this.demoKey, value, nameof (DemoKey));
    }

    public DelegateCommand<string> NumericClick => this.numericClick ?? new DelegateCommand<string>(new Action<string>(this.OnNumberClick));

    public DelegateCommand DeleteClick => this.deleteClick ?? new DelegateCommand(new Action(this.OnDeleteClick));

    public DelegateCommand SubmitClick => this.submitClick ?? new DelegateCommand(new Action(this.Submit));

    protected MathValidator MathValidator { get; set; }

    protected EquationController EquationController { get; set; }

    protected TreeCalculator TreeCalculator { get; set; }

    private Random Generator { get; set; }

    private ArithmeticGame.Calculators.Equation CurrentEquation { get; set; }

    public ImageController ImageController { get; set; }

    public bool GameStarted { get; set; }

    public MainViewModel() => this.Initialize();

    private void Initialize()
    {
      this.Generator = new Random();
      this.ImageController = new ImageController(this.Generator);
      this.TreeCalculator = new TreeCalculator(this.Generator);
      this.MathValidator = new MathValidator();
      this.EquationController = new EquationController(this.Generator);
      this.MathValidator.ShouldBe((Predicate<TreeElement>) (x => x.Convert<Value>().Result <= 10.0), ElementTypeEnum.Value);
      this.MathValidator.ShouldBe((Predicate<TreeElement>) (x => x.Convert<Value>().Result >= 0.0), ElementTypeEnum.Value);
      this.Equation = "";
      this.AnswerString = "";
      this.Title = "Arithmetic";
      this.WinStatText = "Победы:";
      this.LosingStatText = "Поражения:";
      this.TrueAnswerText = "Правильный ответ:";
      this.ShowTrueAnswer = false;
      this.DemoKey = KeysEnum.Null;
    }

    public void NextRound()
    {
      this.LeftImage = "";
      this.RightImage = "";
      this.WinOrLoseText = "";
      this.ShowTrueAnswer = false;
      this.AnswerString = "";
      ArithmeticGame.Calculators.Equation equation = this.EquationController.GetRandom();
      equation.EnableAnswer = (double) this.Generator.Next(0, 10);
      this.TreeCalculator.Calc(equation);
      while (!this.MathValidator.Validate(equation.CurrentElements))
        equation = this.TreeCalculator.Calc(equation);
      this.Equation = equation.CurrentElements.ConvertToString() + "= ";
      this.CurrentEquation = equation;
      this.GameStarted = true;
    }

    public void Win()
    {
      this.WinOrLoseFlag = true;
      this.WinOrLoseText = "Победа";
      this.ResetImages();
      this.CalcStat();
      this.GameStarted = false;
    }

    public void Lose()
    {
      this.WinOrLoseFlag = false;
      this.WinOrLoseText = "Поражение";
      this.ResetImages();
      this.CalcStat();
      this.TrueAnswer = (int) this.CurrentEquation.EnableAnswer;
      this.ShowTrueAnswer = true;
      this.GameStarted = false;
    }

    public void ResetImages()
    {
      (string image1, string image2) = this.ImageController.GetRandom(!this.WinOrLoseFlag);
      this.LeftImage = image1;
      this.RightImage = image2;
    }

    public void CalcStat()
    {
      if (this.WinOrLoseFlag)
        ++this.WinStatCount;
      else
        ++this.LosingStatCount;
    }

    private bool CheckhAnswer()
    {
      int num = 0;
      if (!string.IsNullOrEmpty(this.answerString))
        num = int.Parse(this.answerString);
      return (double) num == this.CurrentEquation.EnableAnswer;
    }

    public void Submit()
    {
      if (!this.GameStarted)
        this.NextRound();
      else if (this.CheckhAnswer())
        this.Win();
      else
        this.Lose();
    }

    public void OnDeleteClick()
    {
      if (this.answerString.Length <= 0)
        return;
      this.AnswerString = this.AnswerString.Remove(this.AnswerString.Length - 1, 1);
    }

    public void OnNumberClick(string input) => this.AnswerString += input;
  }
}
