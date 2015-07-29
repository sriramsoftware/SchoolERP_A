using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSContactDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? cdDetailsId, System.String cdTitle, System.String cdName, System.String cdMobile, System.String cdEmailId, System.String cdmsnId, System.String cdgTalkId, System.String cdSkype, System.String cdWebsite, System.String cdExtra1, System.String cdExtra2, System.DateTime? cdDate, System.Int32? cdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSContactDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, cdDetailsId, cdTitle, cdName, cdMobile, cdEmailId, cdmsnId, cdgTalkId, cdSkype, cdWebsite, cdExtra1, cdExtra2, cdDate, cdStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSContactDetails searchObject)
    {
        return GetSearch(searchObject.CDDetailsId, searchObject.CDTitle, searchObject.CDName, searchObject.CDMobile, searchObject.CDEmailId, searchObject.CDMSNId, searchObject.CDGTalkId, searchObject.CDSkype, searchObject.CDWebsite, searchObject.CDExtra1, searchObject.CDExtra2, searchObject.CDDate, searchObject.CDStatus);
    }

    /// <summary>
    /// Returns all TMSContactDetails objects.
    /// </summary>
    /// <returns>List of all TMSContactDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
}

