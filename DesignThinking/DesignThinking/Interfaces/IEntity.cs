using System;
using System.Collections.Generic;
using System.Text;

namespace DesignThinking.Interfaces
{
    public interface IEntity<Key>
    {
        Key ident { get; set; }
    }
}
