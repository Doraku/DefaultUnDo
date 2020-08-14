using System;
using System.Collections.Generic;
using System.Text;

namespace DefaultUnDo
{
    public interface IMergeableUnDo : IUnDo
    {
        bool TryMerge(IUnDo command, out IUnDo mergedCommand);
    }
}
