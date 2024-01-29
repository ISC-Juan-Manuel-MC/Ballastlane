using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ballastlane.Data
{
    public interface IGet<TReturn, TID>
    {
        TReturn GetById(TID id);
        IEnumerable<TReturn> GetAll();

    }
}
