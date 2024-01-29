﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballastlane.Data
{
    public interface IUpdate<TEntity>
    {
        void Update(TEntity entity);
    }
}