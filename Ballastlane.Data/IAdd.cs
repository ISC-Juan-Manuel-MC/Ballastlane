using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballastlane.Data
{
    public interface IAdd<TEntity>
    {
        void Add(TEntity entity);
    }
}
