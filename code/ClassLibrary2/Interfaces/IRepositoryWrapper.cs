﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2.Interfaces
{
    public interface IRepositoryWrapper
    {
        IAnimeRespository Animes { get;  }
    }
}
