using Dapper.Contrib.Extensions;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignThinking.Base
{
    /// <summary>
    /// Represents the default implementation of the <see cref="IRepository{Key, Entity}"/> to perform the CRUD methods on an entity
    /// 
    /// </summary>
    /// <typeparam name="Key"></typeparam>
    /// <typeparam name="Entity"></typeparam>
    public abstract class SqlRepository<Key, Entity> : IRepository<Key, Entity> where Entity : class
    {
        public abstract ISqlService SqlService { get;}

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public virtual bool Delete(Entity entity)
        {
            using (var con = SqlService.GetConnection())
            {
                return con.Delete<Entity>(entity);
            }

           // var json = JsonConvert.SerializeObject(entity);
           // Client.InvokeDelete(json);
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
