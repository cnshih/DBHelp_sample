using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Common;
using System.Data.SQLite;

/********************************************************************************
** Class Name:   SQLiteHelp
** Author：      Spring Yang
** Create date： 2013-3-16
** Modify：      Spring Yang
** Modify Date： 2013-3-16
** Summary：     SQLiteHelp class
*********************************************************************************/

namespace BlogDBHelp
{
    public class SQLiteHelp : AbstractDBHelp
    {
        #region Protected Method

 

        #endregion

        #region Public Mehtod

        public override DbParameter GetDbParameter(string key, object value)
        {
            return new SQLiteParameter(key, value);
        }

        public override SqlSourceType DataSqlSourceType
        {
            get { return SqlSourceType.SQLite; }
        }

        #endregion
    }

}
