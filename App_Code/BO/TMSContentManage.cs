using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSContentManage
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetContent(System.Int32? contentId, System.String contentName, System.String contentTitle, System.String contentDescription, System.DateTime? contentDate)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSContentManage_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, contentId, contentName, contentTitle, contentDescription, contentDate);

        return db.ExecuteDataSet(dbCommand);

    }


    public static DataSet GetContent(TMSContentManage searchObject)
    {
        return GetContent(searchObject.ContentId, searchObject.ContentName, searchObject.ContentTitle, searchObject.ContentDescription, searchObject.ContentDate);
    }

    /// <summary>
    /// Returns all TMSContentManage objects.
    /// </summary>
    /// <returns>List of all TMSContentManage objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetContent()
    {
        return GetContent(null, null, null, null, null);
    }

    #endregion
}

