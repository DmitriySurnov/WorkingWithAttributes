using System.Reflection;

namespace WorkingWithAttributes
{
    internal class Task4Beater
    {
        public static void CgangeUnchangable(object @class)
        {
            var type = @class.GetType();

            var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var field in fields)
            {
                if (field.GetCustomAttribute<ModifyFieldAttribute>() != null)
                {
                    switch (GetModificationValue(type, field.FieldType))
                    {
                        case "add 10":
                            {
                                field.SetValue(@class, (field.GetValue(@class) as int?) + 10);
                                break;
                            }
                        case "add broken":
                            {
                                field.SetValue(@class, (field.GetValue(@class) as string) + " broken");
                                break;
                            }
                        case "inversion":
                            {
                                field.SetValue(@class, !(field.GetValue(@class) as bool?));
                                break;
                            }
                        default: break;
                    }
                }
            }
        }

        private static string? GetModificationValue(Type @class, Type fieldType)
        {
            object[] attrs = @class.GetCustomAttributes(typeof(ModifyFieldAttribute), true);
            foreach (ModifyFieldAttribute attr in attrs.Cast<ModifyFieldAttribute>())
            {
                if (attr.TargetType == fieldType)
                {
                    return attr.TargetModificationValue?.ToString()?.ToLower();
                }
            }
            return null;
        }
    }
}
