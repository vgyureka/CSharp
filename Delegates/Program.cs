namespace Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            PredicateDelegate.IfValid();

            ActionDelegate.Save();

            FuncDelegate.MainFunc();

            DelegatesFunc();

            FuncActionPred.PredicateDemo();
            FuncActionPred.ActionDemo();
            FuncActionPred.FuncDemo();

            //multi cast delegates
            MultiCastDelegates.DelFunc();
            //using lambda
            DelegateEx1.UsingLambda();
            //without lambda
            DelegateEx1.AddData();
        }
        private static void DelegatesFunc()
        {
            DelegatesDemo obj = new DelegatesDemo();
            TestDel td = obj.AddNums;
            td(1, 2, 3);
            SayDel sd = DelegatesDemo.SayHello;
            sd("VISHU");
        }
    }
}
