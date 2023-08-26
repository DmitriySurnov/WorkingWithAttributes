using System.Reflection;
using System.Security.Claims;

namespace WorkingWithAttributes
{
    internal class Task1Beater
    {
        public static void CgangeUnchangable(object @class)
        {
            var type = @class.GetType();

            var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            fields[0].SetValue(@class, (fields[0].GetValue(@class) as int? ?? 1) * 10);
        }
    }
}
