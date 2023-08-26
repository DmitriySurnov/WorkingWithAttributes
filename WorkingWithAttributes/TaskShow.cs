using System.Reflection;

namespace WorkingWithAttributes
{
    internal class TaskShow
    {
        public static string ShowClassContents(object @class, bool isAttribut = false)
        {
            var type = @class.GetType();
            var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);
            string stroka = "";
            foreach (var field in fields)
            {
                stroka += field.Name + " = ";
                switch (field.GetValue(@class))
                {
                    case bool value:
                        {
                            stroka += value;
                            break;
                        }
                    case int value:
                        {
                            stroka += value;
                            break;
                        }
                    case string value:
                        {
                            stroka += value;
                            break;
                        }
                }
                if (isAttribut)
                {
                    if (field.GetCustomAttribute<ModifyFieldAttribute>() != null)
                    {
                        stroka += " У поля есть атребут";
                    }
                    else
                    {
                        stroka += " У поля нет атребута";
                    }
                }
                stroka += '\n';
            }
            return stroka;
        }
    }
}
