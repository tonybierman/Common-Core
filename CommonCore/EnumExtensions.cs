using System.ComponentModel;
using System.Reflection;

namespace CommonCore
{
    /// <summary>
    /// Returns the string decription for an enum value which has been decorated with the DescriptionAttribute attribute
    /// </summary>
    /// <usage>
    /// MyEnum x = MyEnum.Foo;
    /// string description = x.GetDescription();
    /// </usage>
    public static class EnumExtensions
    {
        public static string? GetDescription(this Enum value)
        {
            Type? type = value.GetType();
            string? name = Enum.GetName(type, value);
            if (name != null)
            {
                FieldInfo? field = type.GetField(name);
                if (field != null)
                {
                    DescriptionAttribute? attr =
                           Attribute.GetCustomAttribute(field,
                             typeof(DescriptionAttribute)) as DescriptionAttribute;
                    if (attr != null)
                    {
                        return attr.Description;
                    }
                }
            }

            return null;
        }
    }
}