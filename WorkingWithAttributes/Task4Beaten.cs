namespace WorkingWithAttributes
{
    [ModifyField(TargetType = typeof(bool), TargetModificationValue = "Inversion")]
    [ModifyField(TargetType = typeof(int), TargetModificationValue = "Add 10")]
    [ModifyField(TargetType = typeof(string), TargetModificationValue = "Add broken")]
    internal class Task4Beaten
    {
        private int _no0neChangeMe = 555;
        [ModifyField]
        private bool _noOneChangeMeForSure = true;
        [ModifyField]
        private string _noOneChangeMeForSureISay = "NO ONE!!! DO NOT TOUCH THIS!!";
        [ModifyField]
        private int _no0neNoOneChangeMe = 10000000;
        private bool _noOneNoOneChangeMeForSure = false;
        private string _noOneNoOneChangeMeForSureISay = "NO ONE!!! NO ONE!!! NO ONE!!! DO NOT TOUCH THIS!!";
    }
}
