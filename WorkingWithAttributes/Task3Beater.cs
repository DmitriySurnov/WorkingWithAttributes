using System.Reflection;

namespace WorkingWithAttributes
{
    internal class Task3Beater
    {
        public static void CgangeUnchangable(object @class)
        {
            var type = @class.GetType();

            var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var field in fields)
            {
                if (field.GetCustomAttribute<ModifyFieldAttribute>() != null)
                {
                    switch (field.GetValue(@class))
                    {
                        case bool value:
                            {
                                field.SetValue(@class, !value);
                                break;
                            }
                        case int value:
                            {
                                field.SetValue(@class, value + 10);
                                break;
                            }
                        case string value:
                            {
                                field.SetValue(@class, value + " broken");
                                break;
                            }
                        default:
                            break;
                    }
                }
            }
        }
    }
}
