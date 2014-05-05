using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/********************************************************************************
** Class Name:   Enums
** Author：      Spring Yang
** Create date： 2013-3-16
** Modify：      Spring Yang
** Modify Date： 2013-3-16
** Summary：     Enums  class
*********************************************************************************/

namespace BlogDBHelp
{
    using System;

    [Serializable]
    public enum SqlSourceType
    {
        Oracle,
        MSSql,
        MySql,
        SQLite
    }
}

