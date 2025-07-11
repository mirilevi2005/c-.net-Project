﻿using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface ISale
    {
        int Create(Sale item);
        Sale? Read(int id);
        List<Sale?> ReadAll(Func<Sale, bool>? filter = null);
        void Update(Sale item);
        void Delete(int id);
        Sale? Read(Func<Sale, bool>? filter);
    }
}
