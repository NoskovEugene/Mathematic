using System.Runtime.CompilerServices;
using ArithmeticCore.Helpers;
using ArithmeticCore.Models;
using ArithmeticCore.Models.Operators.Binary;

namespace ArithmeticCore;

public class Mathematics
{
    private List<MathElement> _elements;

    private MathElement _generatedTree;
    
    public Mathematics()
    {
        _elements = new();
    }

    public void AddElement(MathElement element)
    {
        element.Index = _elements.Count;
        _elements.Add(element);
    }

    public MathElement ResolveTree(MathElement element, List<MathElement> elements)
    {
        var left = elements.Where(x => x.Index < element.Index).ToList();
        var right = elements.Where(x => x.Index > element.Index).ToList();
        var binOp = element.As<BinaryOperatorBase>();

        if (left.Count == 1)
        {
            var e = left.First();
            if (e.ElementType == MathElementEnum.Random)
            {
                binOp.LeftOperand = e.As<RandomElement>().ComputeValueElement();
            }
        }
        else
        {
            binOp.LeftOperand = ResolveTree(ElementWithMinPriority(left), left);
        }

        if (right.Count == 1)
        {
            var e = right.First();
            if (e.ElementType == MathElementEnum.Random)
            {
                binOp.RightOperand = e.As<RandomElement>().ComputeValueElement();
            }
        }
        else
        {
            binOp.RightOperand = ResolveTree(ElementWithMinPriority(right), right);
        }

        return binOp;
    }

    public MathElement ResolveTree(bool generateNew = true)
    {
        if (!generateNew)
        {
            return _generatedTree;
        }
        
        _generatedTree = ResolveTree(ElementWithMinPriority(_elements), _elements);
        return _generatedTree;
    }
    
    private static MathElement ElementWithMinPriority(List<MathElement> elements)
    {
        var min = elements.Where(x => x.Priority > 0).Min(x => x.Priority);
        return elements.Last(x => x.Priority == min);
    }
}