using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/********************************************************************************
** Class Name:   IDBHelp
** Author：      Spring Yang
** Create date： 2013-3-16
** Modify：      Spring Yang
** Modify Date： 2013-3-16
** Summary：     IDBHelp interface
*********************************************************************************/

namespace BlogDBHelp
{
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;

    public interface IDBHelp
    {
        /// <summary>
        /// Gets the connection string
        /// </summary>
        string ConnectionString { get; set; }

        /// <summary>
        /// Gets or sets the max connection count
        /// </summary>
        int MaxConnectionCount { get; set; }

        /// <summary>
        /// Gets or sets the sql source type
        /// </summary>
        SqlSourceType DataSqlSourceType { get; }

        /// <summary>
        /// Execute query by stored procedure 
        /// </summary>
        /// <param name="cmdText">stored procedure</param>
        /// <returns>DataSet</returns>
        DataSet ExecuteQuery(string cmdText, List<DbParameter> parameters);

        /// <summary>
        /// Execute non query by stored procedure and parameter list
        /// </summary>
        /// <param name="cmdText">stored procedure</param>
        /// <returns>execute count</returns>
        int ExecuteNonQuery(string cmdText, List<DbParameter> parameters);

        /// <summary>
        /// Execute scalar by store procedure
        /// </summary>
        /// <param name="cmdText">store procedure</param>
        /// <returns>return value</returns>
        object ExecuteScalar(string cmdText, List<DbParameter> parameters);

        /// <summary>
        /// Get data base parameter by parameter name and parameter value
        /// </summary>
        /// <param name="key">parameter name</param>
        /// <param name="value">parameter value</param>
        /// <returns>sql parameter</returns>
        DbParameter GetDbParameter(string key, object value);

        /// <summary>
        /// Get data base parameter by parameter name and parameter value
        /// and parameter direction 
        /// </summary>
        /// <param name="key">parameter name</param>
        /// <param name="value">parameter value</param>
        /// <param name="direction">parameter direction </param>
        /// <returns>data base parameter</returns>
        DbParameter GetDbParameter(string key, object value, ParameterDirection direction);

        /// <summary>
        /// Read entity list by  store procedure
        /// </summary>
        /// <typeparam name="T">entity</typeparam>
        /// <param name="cmdText">store procedure</param>
        /// <returns>entity list</returns>
        List<T> ReadEntityList<T>(string cmdText, List<DbParameter> parameters) where T : new();

        /// <summary>
        /// Get dictionary result by store procedure and parameters and string list
        /// </summary>
        /// <param name="cmdText">store procedure</param>
        /// <param name="stringlist">string list</param>
        /// <returns>result list</returns>
        List<Dictionary<string, object>> GetDictionaryList(string cmdText,
                                                           List<string> stringlist);

        /// <summary>
        /// Batch execute ExecuteNonQuery by cmdText list
        /// </summary>
        /// <param name="cmdList">cmd text list</param>
        /// <returns>execute true or not</returns>
        bool BatchExecuteNonQuery(List<string> cmdList);
    }
}

