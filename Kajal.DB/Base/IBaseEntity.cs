using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kajal.DB
{
    public interface IBaseEntity<T> where T : class
    {
        int Id { get; set; }
        bool IsActive { get; set; }
        bool IsDeleted { get; set; }
        DateTime CreateDate { get; set; }
    }
}
