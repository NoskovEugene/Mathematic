// Decompiled with JetBrains decompiler
// Type: Arithmetic.Extensions.ListExpression
// Assembly: Arithmetic, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 6AA6CF8E-54A1-41A7-AF96-F89BEC4ED8FF
// Assembly location: C:\Users\Eugene\Desktop\Arithmetic.dll

using Arithmetic.Elements;
using Arithmetic.Elements.Operators;
using Arithmetic.Elements.UnaryOperators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Arithmetic.Extensions
{
    public static class ListExpression
    {
        public static Dictionary<string, Action<List<TreeElement>>> Actions =
            new Dictionary<string, Action<List<TreeElement>>>()
            {
                {
                    "+",
                    (Action<List<TreeElement>>)(x => x.Plus())
                },
                {
                    "-",
                    (Action<List<TreeElement>>)(x => x.Minus())
                },
                {
                    "/",
                    (Action<List<TreeElement>>)(x => x.Div())
                },
                {
                    "*",
                    (Action<List<TreeElement>>)(x => x.Mult())
                }
            };

        public static Dictionary<string, Func<BinaryOperator, double, Random, BinaryOperator>> TeachTree =
            new Dictionary<string, Func<BinaryOperator, double, Random, BinaryOperator>>()
            {
                {
                    "+",
                    (Func<BinaryOperator, double, Random, BinaryOperator>)((x, answer, generator) =>
                    {
                        if (x.Right.ElementType == ElementTypeEnum.Value)
                        {
                            double num = answer - x.Right.Convert<Value>().Result;
                            x.Left = (TreeElement)x.Left.Convert<Variable>().ConvertToValue(num);
                        }

                        if (x.Left.ElementType == ElementTypeEnum.Variable)
                        {
                            double num = answer - x.Right.Convert<Value>().Result;
                            x.Right = (TreeElement)x.Right.Convert<Variable>().ConvertToValue(num);
                        }

                        int num1 = generator.Next((int)answer);
                        x.Right = (TreeElement)x.Right.Convert<Variable>().ConvertToValue((double)num1);
                        double num2 = answer - (double)num1;
                        x.Left = (TreeElement)x.Left.Convert<Variable>().ConvertToValue(num2);
                        return x;
                    })
                }
            };

        private static List<TreeElement> Add(
            List<TreeElement> elements,
            TreeElement element)
        {
            element.Index = elements.Count;
            elements.Add(element);
            return elements;
        }

        public static List<TreeElement> Val(
            this List<TreeElement> elements,
            double value)
        {
            Value obj1 = new Value();
            obj1.Index = elements.Count;
            obj1.Result = value;
            Value obj2 = obj1;
            elements.Add((TreeElement)obj2);
            return elements;
        }

        public static List<TreeElement> Var(
            this List<TreeElement> elements,
            bool needCalc = false,
            bool intFlag = false,
            string name = "")
        {
            Variable variable1 = new Variable();
            variable1.Index = elements.Count;
            variable1.Int = intFlag;
            variable1.NeedCalc = needCalc;
            variable1.Name = name;
            variable1.Synced = !string.IsNullOrEmpty(name);
            Variable variable2 = variable1;
            int index = elements.Count<TreeElement>((Func<TreeElement, bool>)(x =>
                x.ElementType == ElementTypeEnum.Variable));
            if (string.IsNullOrEmpty(name))
                variable2.SetNameByIndex(index);
            elements.Add((TreeElement)variable2);
            return elements;
        }

        public static List<TreeElement> Plus(this List<TreeElement> elements)
        {
            Addition addition1 = new Addition();
            addition1.Index = elements.Count;
            Addition addition2 = addition1;
            elements.Add((TreeElement)addition2);
            return elements;
        }

        public static List<TreeElement> Minus(this List<TreeElement> elements)
        {
            Substraction substraction1 = new Substraction();
            substraction1.Index = elements.Count;
            Substraction substraction2 = substraction1;
            elements.Add((TreeElement)substraction2);
            return elements;
        }

        public static List<TreeElement> Mult(this List<TreeElement> elements)
        {
            Multiplication multiplication1 = new Multiplication();
            multiplication1.Index = elements.Count;
            Multiplication multiplication2 = multiplication1;
            elements.Add((TreeElement)multiplication2);
            return elements;
        }

        public static List<TreeElement> Div(this List<TreeElement> elements)
        {
            Division division1 = new Division();
            division1.Index = elements.Count;
            Division division2 = division1;
            elements.Add((TreeElement)division2);
            return elements;
        }

        public static List<TreeElement> Pow(this List<TreeElement> elements)
        {
            Exponent exponent1 = new Exponent();
            exponent1.Index = elements.Count;
            Exponent exponent2 = exponent1;
            elements.Add((TreeElement)exponent2);
            return elements;
        }

        public static List<TreeElement> Sin(
            this List<TreeElement> elements,
            List<TreeElement> payload)
        {
            Sine sine1 = new Sine();
            sine1.Index = elements.Count;
            sine1.Payload = payload;
            sine1.Root = payload.PrepareTree();
            sine1.NeedPrepare = false;
            Sine sine2 = sine1;
            elements.Add((TreeElement)sine2);
            return elements;
        }

        public static List<TreeElement> Sin(
            this List<TreeElement> elements,
            double value)
        {
            Value obj = new Value(value);
            Sine sine1 = new Sine();
            sine1.Index = elements.Count;
            sine1.Payload = new List<TreeElement>()
            {
                (TreeElement)obj
            };
            sine1.Root = (TreeElement)obj;
            sine1.NeedPrepare = false;
            Sine sine2 = sine1;
            elements.Add((TreeElement)sine2);
            return elements;
        }

        public static List<TreeElement> Cos(
            this List<TreeElement> elements,
            double value)
        {
            Cosine cosine = new Cosine();
            cosine.Index = elements.Count;
            cosine.Payload = new List<TreeElement>().Val(value);
            cosine.NeedPrepare = false;
            Cosine element = cosine;
            element.Root = element.Payload.First<TreeElement>();
            return ListExpression.Add(elements, (TreeElement)element);
        }

        public static List<TreeElement> Cos(
            this List<TreeElement> elements,
            List<TreeElement> payload)
        {
            Cosine cosine = new Cosine();
            cosine.Payload = payload;
            cosine.NeedPrepare = false;
            cosine.Root = payload.PrepareTree();
            Cosine element = cosine;
            return ListExpression.Add(elements, (TreeElement)element);
        }

        public static List<TreeElement> Bracket(
            this List<TreeElement> elements,
            List<TreeElement> bracketCollection)
        {
            Arithmetic.Elements.Bracket bracket1 = new Arithmetic.Elements.Bracket();
            bracket1.Index = elements.Count;
            bracket1.Elements = bracketCollection;
            bracket1.Synced = false;
            Arithmetic.Elements.Bracket bracket2 = bracket1;
            int sourceVariableCount = elements
                .Where<TreeElement>((Func<TreeElement, bool>)(x => x.ElementType == ElementTypeEnum.Variable))
                .Count<TreeElement>();
            foreach (Arithmetic.Elements.Bracket bracket3 in elements
                         .Where<TreeElement>((Func<TreeElement, bool>)(x => x.ElementType == ElementTypeEnum.Bracket))
                         .Select<TreeElement, Arithmetic.Elements.Bracket>(
                             (Func<TreeElement, Arithmetic.Elements.Bracket>)(x => (Arithmetic.Elements.Bracket)x)))
                sourceVariableCount += bracket2.VariablesCount();
            bracket2.SyncCollection(sourceVariableCount);
            elements.Add((TreeElement)bracket2);
            return elements;
        }

        public static List<TreeElement> Clone(this List<TreeElement> elements) => elements
            .Select<TreeElement, TreeElement>((Func<TreeElement, TreeElement>)(x => (TreeElement)x.Clone()))
            .ToList<TreeElement>();

        public static string ConvertToString(this List<TreeElement> elements) =>
            string.Join<TreeElement>("", (IEnumerable<TreeElement>)elements);

        private static TreeElement FindNext(List<TreeElement> collection)
        {
            var minPriority = collection.Where(x => x.Priority > 0).Min(x => x.Priority);
            return collection.Last(x => x.Priority == minPriority);
        }

        private static TreeElement PrepareTree(
            TreeElement forElement,
            List<TreeElement> collection)
        {
            List<TreeElement> leftCollection = GetLeftCollection(forElement.Index, collection);
            List<TreeElement> rightCollection = GetRightCollection(forElement.Index, collection);
            BinaryOperator binaryOperator = (BinaryOperator)forElement;
            if (leftCollection.Count == 1)
            {
                TreeElement element = leftCollection.First();
                if (element.ElementType == ElementTypeEnum.Bracket)
                {
                    Bracket bracket = element.Convert<Bracket>();
                    TreeElement next = FindNext(bracket.Elements);
                    binaryOperator.Left = PrepareTree(next, bracket.Elements);
                }
                else
                    binaryOperator.Left = element;
            }
            else
            {
                TreeElement treeElement =
                    PrepareTree(FindNext(leftCollection), leftCollection);
                binaryOperator.Left = treeElement;
            }

            if (rightCollection.Count == 1)
            {
                TreeElement element = rightCollection.First();
                if (element.ElementType == ElementTypeEnum.Bracket)
                {
                    Arithmetic.Elements.Bracket bracket = element.Convert<Arithmetic.Elements.Bracket>();
                    TreeElement next = ListExpression.FindNext(bracket.Elements);
                    binaryOperator.Right = ListExpression.PrepareTree(next, bracket.Elements);
                }
                else
                    binaryOperator.Right = element;
            }
            else
            {
                TreeElement treeElement =
                    ListExpression.PrepareTree(ListExpression.FindNext(rightCollection), rightCollection);
                binaryOperator.Right = treeElement;
            }

            return forElement;
        }

        private static List<TreeElement> GetLeftCollection(
            int index,
            List<TreeElement> collection)
        {
            return collection.Where(x => x.Index < index).ToList();
        }

        private static List<TreeElement> GetRightCollection(
            int index,
            List<TreeElement> collection)
        {
            return collection.Where(x => x.Index > index).ToList();
        }

        public static TreeElement PrepareTree(this List<TreeElement> collection) =>
            ListExpression.PrepareTree(ListExpression.FindNext(collection), collection);

        public static (string input, double result) Digital(string input)
        {
            Match match = new Regex("\\-{0,1}\\d{1,}[.|,]{0,1}\\d{0,}").Match(input);
            double num = !string.IsNullOrEmpty(match.Value)
                ? double.Parse(match.Value)
                : throw new Exception("`" + match.Value + "` is not a double value");
            input = input.Remove(0, match.Length);
            return (input, num);
        }
    }
}