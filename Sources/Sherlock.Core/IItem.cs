using System;

namespace Sherlock.Core
{
    public interface IItem : INode, IComparable<IItem>
    {
        string Value
        {
            get;
        }

        bool IsSecret
        {
            get;
        }
    }
}
