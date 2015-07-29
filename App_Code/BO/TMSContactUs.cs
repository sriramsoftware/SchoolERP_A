using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSContactUs
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static  DataSet  GetSearch(System.Int32? contactID, System.String contactName, System.String contactEmail, System.String contactPhone, System.String contactSubject, System.String contactComment, System.String contactReply, System.Int32? contactReplyStatus, System.Int32? contactStatus, System.DateTime? contactDate)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSContactUs_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, contactID, contactName, contactEmail, contactPhone, contactSubject, contactComment, contactReply, contactReplyStatus, contactStatus, contactDate);

        ds = db.ExecuteDataSet(dbCommand);
      
        return ds;
    }


    public static DataSet GetSearch(TMSContactUs searchObject)
    {
        return GetSearch(searchObject.ContactID, searchObject.ContactName, searchObject.ContactEmail, searchObject.ContactPhone, searchObject.ContactSubject, searchObject.ContactComment, searchObject.ContactReply, searchObject.ContactReplyStatus, searchObject.ContactStatus, searchObject.ContactDate);
    }

    /// <summary>
    /// Returns all TMSContactUs objects.
    /// </summary>
    /// <returns>List of all TMSContactUs objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null);
    }
    public static DataSet GetContactUsdetails(System.Int32? cdDetailsId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrGetContactUsdetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, cdDetailsId);

        return db.ExecuteDataSet(dbCommand);

    }
    #endregion

}

