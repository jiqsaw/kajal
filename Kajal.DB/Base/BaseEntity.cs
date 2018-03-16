using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kajal.DB
{
    public class BaseEntity<T> where T : class, IBaseEntity<T>
    {
    }
}
