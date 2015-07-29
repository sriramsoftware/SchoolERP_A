
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSFeturesManagment
{


    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? fmFutureID, System.Int64? fmFuturedDetailsID, System.String fmTitle, System.String fmSubTitle, System.String fmDescription, System.String fmImage, System.String fmImage2, System.String fmDescrption2, System.DateTime? fmDate, System.Int32? fmStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSFeturesManagment_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, fmFutureID, fmFuturedDetailsID, fmTitle, fmSubTitle, fmDescription, fmImage, fmImage2, fmDescrption2, fmDate, fmStatus);

        ds = db.ExecuteDataSet(dbCommand);
       
        return ds;
    }


    public static DataSet GetSearch(TMSFeturesManagment searchObject)
    {
        return GetSearch(searchObject.FMFutureID, searchObject.FMFuturedDetailsID, searchObject.FMTitle, searchObject.FMSubTitle, searchObject.FMDescription, searchObject.FMImage, searchObject.FMImage2, searchObject.FMDescrption2, searchObject.FMDate, searchObject.FMStatus);
    }

    /// <summary>
    /// Returns all TMSFeturesManagment objects.
    /// </summary>
    /// <returns>List of all TMSFeturesManagment objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null);
    }

    #endregion
    public static DataSet GetFeaturesSubTitle()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSGetFeaturesSubTitle";
        dbCommand = db.GetStoredProcCommand(sqlCommand);

        ds = db.ExecuteDataSet(dbCommand);
       
        return ds;
    }
    
}

