﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RevStack.Pattern;

namespace RevStack.Storage.Model
{
    public interface IStorageEntity : IEntity<int>
    {
        string Path { get; set; }
    }
}
