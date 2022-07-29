using System.Reflection;

namespace Common;

public static class EnumHelpers
{
    public static T GetCustomAttribute<T>(this Enum value)
        where T: Attribute
    {
        var fieldInfo = value.GetType().GetField(value.ToString());
        return fieldInfo.GetCustomAttribute<T>();
    }
}