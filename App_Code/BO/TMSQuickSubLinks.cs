using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSQuickSubLinks
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int32? qslId, System.Int32? qslLinkId, System.Int32? qslReferID, System.String qslRole, System.String qslImage, System.String qslImage1, System.String qslUrl, System.String qslDescription, System.Boolean? qslStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSQuickSubLinks_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, qslId, qslLinkId, qslReferID, qslRole, qslImage, qslImage1, qslUrl, qslDescription, qslStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSQuickSubLinks searchObject)
    {
        return GetSearch(searchObject.QSLId, searchObject.QSLLinkId, searchObject.QSLReferID, searchObject.QSLRole, searchObject.QSLImage, searchObject.QSLImage1, searchObject.QslUrl, searchObject.QSLDescription, searchObject.QSLStatus);
    }

    /// <summary>
    /// Returns all TMSQuickSubLinks objects.
    /// </summary>
    /// <returns>List of all TMSQuickSubLinks objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null);
    }

    #endregion
}

