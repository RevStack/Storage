using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using RevStack.Pattern;
using RevStack.Storage.Model;

namespace RevStack.Storage.Repository
{
    public interface IStorageFolderRepository
    {
        IStorageFolder Add(IStorageFolder entity);
        void Delete(IStorageFolder entity);
        IEnumerable<IStorageFolder> Get();
        IStorageFolder Get(int id);
        IStorageFolder Update(IStorageFolder entity);
    }
}
