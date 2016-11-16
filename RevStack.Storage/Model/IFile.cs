using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevStack.Storage.Model
{
    public interface IFile
    {
        string Name { get; set; }
        string Url { get; set; }
        long Size { get; set; }
    }
}
