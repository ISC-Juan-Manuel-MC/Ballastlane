﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballastlane.Data
{
    public interface IDeactivate<TId>
    {
        void Deactivate(TId Id);
    }
}
