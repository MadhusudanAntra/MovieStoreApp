﻿using MovieStoreApp.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieStoreApp.Core.Contract.Repository
{
    public interface ICastRepositoryAsync:IRepositoryAsync<Cast>
    {
        Task<IEnumerable<Cast>> GetLatest10RowsAsync();
    }
}
