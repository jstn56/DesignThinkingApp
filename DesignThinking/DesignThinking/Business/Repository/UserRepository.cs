using System;
using DesignThinking.Base;
using DesignThinking.Database;
using DesignThinking.Interfaces;
using DesignThinking.Models;
using Dapper.Contrib.Extensions;

namespace DesignThinking.Business.Repository
{
    public class UserRepository : SqlRepository<int, User>, IUserRepository
    {
        private ISqlService sqlService;
        /// <summary>
        /// Constructor
        /// </summary>
        public UserRepository()
        {
            sqlService = new PostgreSqlService();
        }
        public UserRepository(ISqlService sqlService)
        {
            this.sqlService = sqlService;
        }
        public override ISqlService SqlService { get => sqlService; }

      
    }
}
