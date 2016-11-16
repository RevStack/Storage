using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevStack.Storage.Model;

namespace RevStack.Storage.Repository
{
    public interface IFolderRepository
    {
        IFolder Get(string path);
        IFolder Add(string path);
        IFolder Update(string path, string destination);
        void Delete(string path);
    }
}
