using DesignThinking.Base;
using DesignThinking.Database;
using DesignThinking.Interfaces;
using DesignThinking.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignThinking.Business.Repository
{
    public class ProtocolRepository : SqlRepository<int, Protocol>, IProtocolRepository
    {
        private ISqlService sqlService;
        public ProtocolRepository()
        {
            sqlService = new PostgreSqlService();
        }
        public ProtocolRepository(ISqlService sqlService)
        {
            this.sqlService = sqlService;
        }
        public override ISqlService SqlService { get => sqlService; }
    }
}
