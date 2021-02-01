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
    public class ProtocolMethodRepository : SqlRepository<int, ProtocolMethod>, IProtocolMethodRepository
    {
        private ISqlService sqlService;

        public ProtocolMethodRepository()
        {
            sqlService = new PostgreSqlService();
        }
        public ProtocolMethodRepository(ISqlService sqlService)
        {
            this.sqlService = sqlService;
        }
        public override ISqlService SqlService { get => sqlService; }

        public Task<IEnumerable<Filestructure>> GetAllAsync()
        {
            using (var con = SqlService.GetConnection())
            {
                return con.QueryAsync<Filestructure>("Select * From filestructure");
            }
        }

        public void LoadImage(ProtocolMethod protocolMethod)
        {
            using (var con = SqlService.GetConnection())
            {
                string sql = "Select \"Image\" From filestructure where \"ProtocolIdent\" = @ident";
                protocolMethod.Image = con.QueryFirstOrDefault<byte[]>(sql, new { ident = protocolMethod.ident });
            }
        }

        public void SaveImage(ProtocolMethod protocolMethod, byte[] arrayImage)
        {
            using (var con = SqlService.GetConnection())
            {
                var file = new Filestructure
                {
                    Image = arrayImage,
                    ProtocolIdent = protocolMethod.ident
                };
                con.Insert<Filestructure>(file);
            }
        }
    }
}
