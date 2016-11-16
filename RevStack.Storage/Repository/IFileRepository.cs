using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevStack.Storage.Model;

namespace RevStack.Storage.Repository
{
    public interface IFileRepository
    {
        IFile Add(byte[] byteArray, string path);
        IFile Update(byte[] byteArray, string path, string destination);
        void Delete(string path);
        IFile Get(string path);
    }
}
