using System;
using System.Collections.Generic;
using DesignThinking.Base;
using DesignThinking.Database;
using DesignThinking.Interfaces;
using DesignThinking.Models;


namespace DesignThinking.Business.Repository
{
    public class MethodRepository : SqlRepository<int, Method>, IMethodRepository 
    {
        private ISqlService sqlService;

        public MethodRepository()
        {
            sqlService = new PostgreSqlService();
        }
        public MethodRepository(ISqlService sqlService)
        {
            this.sqlService = sqlService;
        }

        public override ISqlService SqlService { get => sqlService; }

       
    }
}
