using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace WorkingWithAttributes
{
    internal class Task2Beater
    {
        public static void CgangeUnchangable(object @class)
        {
            var type = @class.GetType();

            var fields = type.GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (var field in fields)
            {
                switch (field.GetValue(@class))
                {
                    case bool _:
                        {
                            field.SetValue(@class, !(field.GetValue(@class) as bool?));
                            break;
                        }
                    case int _:
                        {
                            field.SetValue(@class, (field.GetValue(@class) as int?) + 10);
                            break;
                        }
                    case string _:
                        {
                            field.SetValue(@class, (field.GetValue(@class) as string) + " broken");
                            break;
                        }
                }
            }
        }
    }
}
