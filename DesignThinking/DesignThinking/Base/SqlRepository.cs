using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignThinking.Base
{
    public abstract class SqlRepository<Key, Entity> : IRepository<Key, Entity> where Entity : class
    {
        public abstract ISqlService SqlService { get;}

        public virtual bool Delete(Entity entity)
        {
            using (var con = SqlService.GetConnection())
            {
                return con.Delete<Entity>(entity);
            }
        }

        public virtual Entity Get(Key key)
        {
            using (var con = SqlService.GetConnection())
            {
                return con.Get<Entity>(key);
            }
        }

        public virtual IEnumerable<Entity> GetAll()
        {
            using (var con = SqlService.GetConnection())
            {
                return con.GetAll<Entity>();
            }
        }

        public virtual bool Save(Entity entity)
        {
            using (var con = SqlService.GetConnection())
            {
                con.Insert<Entity>(entity);
                return true;
            }
        }

        public virtual bool Update(Entity entity, Key key)
        {
            using (var con = SqlService.GetConnection())
            {
                return con.Update<Entity>(entity,null, 0);
            }
        }
    }
}
