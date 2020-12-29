using System;

namespace CSharp.POLYMORPHISM.Method_Overriding
{
    public interface IStatus
    {
        Guid Key { get; set; }

        EStatus Status { get; set; }

        bool IsChanged { get; }
    }
    public enum EStatus
    {
        Added,
        Deleted,
        Updated
    }
}
