using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;


public partial class TMSSpecialAnnouncement
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? saAnnoucementId, System.String saTitle, System.String saDescription, System.String saDescription1, System.Int64? saReplyId, System.DateTime? saDate, System.Int32? saStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSSpecialAnnouncement_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, saAnnoucementId, saTitle, saDescription, saDescription1, saReplyId, saDate, saStatus);

        return db.ExecuteDataSet(dbCommand);

    }


    public static DataSet GetSearch(TMSSpecialAnnouncement searchObject)
    {
        return GetSearch(searchObject.SAAnnoucementId, searchObject.SATitle, searchObject.SADescription, searchObject.SADescription1, searchObject.SAReplyId, searchObject.SADate, searchObject.SAStatus);
    }

    /// <summary>
    /// Returns all TMSSpecialAnnouncement objects.
    /// </summary>
    /// <returns>List of all TMSSpecialAnnouncement objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null);
    }

    #endregion
}

