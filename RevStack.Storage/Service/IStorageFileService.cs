using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevStack.Pattern;
using RevStack.Storage.Model;

namespace RevStack.Storage.Service
{
    public interface IStorageFileService
    {
        IStorageFile Add(string path, Stream stream);
        IStorageFile Update(int id, string path, Stream stream);
        IStorageFile Get(int id);
        void Delete(int id);
    }
}
