using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using RevStack.Pattern;
using RevStack.Storage.Model;

namespace RevStack.Storage.Repository
{
    public interface IStorageFileRepository 
    {
        IStorageFile Add(IStorageFile entity);
        void Delete(IStorageFile entity);
        IEnumerable<IStorageFile> Get();
        IStorageFile Get(int id);
        IStorageFile Update(IStorageFile entity);
    }
}
