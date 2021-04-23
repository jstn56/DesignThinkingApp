using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using Dapper.Contrib.Extensions;
using DesignThinking.Base;
using DesignThinking.Database;
using DesignThinking.Interfaces;
using DesignThinking.Models;

namespace DesignThinking.Business.Repository
{
    public class TaskRepository : SqlRepository<int, Models.Task>, ITaskRepository
    {
        public TaskRepository()
        {
            sqlService = new PostgreSqlService();
        }

        public TaskRepository(ISqlService sqlService)
        {
            this.sqlService = sqlService;
        }

        private ISqlService sqlService;
        public override ISqlService SqlService { get => sqlService; }


        public Task<IEnumerable<Filestructure>> GetAllAsync()
        {
            using (var con = SqlService.GetConnection())
            {
                return con.QueryAsync<Filestructure>("Select * From filestructure");
            }
        }

        public void LoadImage(Models.Task task)
        {
            using (var con = SqlService.GetConnection())
            {
                string sql = "Select \"Image\" From filestructure where \"TaskIdent\" = @ident";
                task.Image = con.QueryFirstOrDefault<byte[]>(sql, new { ident = task.ident });
            }
        }

        public void SaveImage(Models.Task task, byte[] arrayImage)
        {
            using (var con = SqlService.GetConnection())
            {
                var file = new Filestructure
                {
                    Image = arrayImage,
                    TaskIdent = task.ident
                };
                con.Insert<Filestructure>(file);
            }
        }
    }
}
