using System;

namespace CSharp.POLYMORPHISM.Method_Overriding
{
    public class BaseClass : IStatus
    {
        public Guid Key { get; set; }
        public EStatus Status { get; set; }
        public virtual string VirtualProp { get; set; } = "BASE VIRTUAL PROP";
        public string NormalProp { get; set; } = "BASE NORMAL PROP";
        public string NewProp { get; set; } = "BASE NEW PROP";
        public string NoOverride { get; set; } = "BASE NO Override";

        public bool IsChanged { get => Status == EStatus.Added || Status == EStatus.Updated || Status == EStatus.Deleted; }
    }
}
