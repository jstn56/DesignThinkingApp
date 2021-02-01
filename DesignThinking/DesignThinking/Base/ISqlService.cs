using System;
using System.Data;


namespace DesignThinking.Base
{
    public interface ISqlService
    {
        IDbConnection GetConnection();
    }
}
