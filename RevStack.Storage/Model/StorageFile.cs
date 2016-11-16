using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RevStack.Storage.Model
{
    public class StorageFile : IStorageFile
    {
        public int Id { get; set; }
        public string Path { get; set; }
    }
}
