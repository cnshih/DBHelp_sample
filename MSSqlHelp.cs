using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************************************************
** Class Name:   MySqlHelp
** Author：      Spring Yang
** Create date： 2013-3-16
** Modify：      Spring Yang
** Modify Date： 2013-3-16
** Summary：     MySqlHelp class
*********************************************************************************/

namespace BlogDBHelp
{
    using System.Data.Common;
    using System.Data.SqlClient;

    public class MSSqlHelp : AbstractDBHelp
    {
        #region Protected Method



        #endregion

        #region Public Mehtod

        public override SqlSourceType DataSqlSourceType
        {
            get { return SqlSourceType.MSSql; }
        }

        public override DbParameter GetDbParameter(string key, object value)
        {
            return new SqlParameter(key, value);
        }

        #endregion
    }
}

