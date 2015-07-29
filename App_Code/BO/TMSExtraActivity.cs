using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSExtraActivity
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? exActivityID, System.Int64? exActyvityType, System.String exActivity, System.String exAddedBy, System.DateTime? exDate, System.Int32? exStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSExtraActivity_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, exActivityID, exActyvityType, exActivity, exAddedBy, exDate, exStatus);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet GetSearch(TMSExtraActivity searchObject)
    {
        return GetSearch(searchObject.ExActivityID, searchObject.EXActyvityType, searchObject.EXActivity, searchObject.EXAddedBy, searchObject.EXDate, searchObject.EXStatus);
    }

    /// <summary>
    /// Returns all TMSExtraActivity objects.
    /// </summary>
    /// <returns>List of all TMSExtraActivity objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null);
    }




    public static DataSet FillExtraActivity(System.String exActivity)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillExtraActivity";
        dbCommand = db.GetStoredProcCommand(sqlCommand, exActivity);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }

    public static DataSet FillExtraCurricularDetails(System.String exActivity, System.Int64? Standard, System.Int64? Division, System.Int64? FacultyLoginID, System.Int64? StudentLoginID, System.Int64? ActiveID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillExtraCurricularDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, exActivity, Standard, Division, FacultyLoginID, StudentLoginID, ActiveID);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

       

    public static DataSet FillProgressTimelineDetails(System.Int64? Standard, System.Int64? StudentLoginID, System.String exActivity)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillProgressTimelineDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, Standard,StudentLoginID, exActivity);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    #endregion

}

