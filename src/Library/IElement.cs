using System.Collections.Generic;
using System.Collections.ObjectModel;
using System;

namespace Library
{
    public interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
