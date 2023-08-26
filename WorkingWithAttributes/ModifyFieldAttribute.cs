namespace WorkingWithAttributes
{
    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Class, AllowMultiple = true,Inherited =true)]
    internal class ModifyFieldAttribute:Attribute
    {
        public Type? TargetType { get; set; } = null;

        public object? TargetModificationValue { get; set; } = null;
    }
}
