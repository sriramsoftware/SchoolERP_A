using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSManageEmail
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int32? emailId, System.Int32? emailTemplateId, System.String emailType, System.String emailSubject, System.String emailContent, System.Int32? emailUserType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSManageEmail_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, emailId, emailTemplateId, emailType, emailSubject, emailContent, emailUserType);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSManageEmail searchObject)
    {
        return GetSearch(searchObject.EmailId, searchObject.EmailTemplateId, searchObject.EmailType, searchObject.EmailSubject, searchObject.EmailContent, searchObject.EmailUserType);
    }

    /// <summary>
    /// Returns all TMSManageEmail objects.
    /// </summary>
    /// <returns>List of all TMSManageEmail objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null);
    }

    #endregion
}

