using System;
using System.Collections.Generic;
using Dapper;
using DesignThinking.Base;
using DesignThinking.Database;
using DesignThinking.Interfaces;
using DesignThinking.Models;

namespace DesignThinking.Business.Repository
{
    public class TeamRepository : SqlRepository<int, Team>, ITeamRepository
    {
        private ISqlService sqlService;
        public TeamRepository()
        {
            sqlService = new PostgreSqlService();
        }
        public TeamRepository(ISqlService sqlService)
        {
            this.sqlService = sqlService;
        }
        public override ISqlService SqlService { get => sqlService; }
    }
}
