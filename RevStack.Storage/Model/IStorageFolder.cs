using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevStack.Pattern;

namespace RevStack.Storage.Model
{
    public interface IStorageFolder : IStorageEntity
    {
        List<IStorageFile> Files { get; set; }
        List<IStorageFolder> Folders { get; set; }
    }
}
