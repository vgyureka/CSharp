using System;

namespace CSharp.POLYMORPHISM.Method_Overriding
{
    public class DerviedClass : BaseClass
    {
        public override string VirtualProp { get; set; } = "DERVIED VIRTUAL PROP";
        public string NormalProp { get; set; } = "DERIVED NORMAL PROP";
        public new string NewProp { get; set; } = "DERIVED NEW PROP";
    }
}
