using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevStack.Pattern;
using RevStack.Storage.Model;

namespace RevStack.Storage.Service
{
    public interface IStorageFolderService
    {
        IStorageFolder Add(string path);
        IStorageFolder Update(int id, string path);
        IStorageFolder Get(int id);
        void Delete(int id);
    }
}
