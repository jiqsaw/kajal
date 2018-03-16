using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kajal.DB
{
    public class Context : KajalEntities
    {

        public DbSet<TEntity> GetTable<TEntity>() where TEntity : class
        {
            return this.Set<TEntity>();
        }

    }
}
