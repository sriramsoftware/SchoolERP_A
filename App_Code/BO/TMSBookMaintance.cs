using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSBookMaintance
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? bmMaintainceId, System.Int64? bmBookDetailId, System.Int64? bmLibrarianId, System.Int64? bmDamageById, System.String bmTotalDamageCopies, System.String bmDamageAvailableCopies, System.String bmCostPerCopies, System.String bmTotalCost, System.String bmFor, System.String bmDamageType, System.String bmDamageByName, System.DateTime? bmDate, System.Int32? bmStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSBookMaintance_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, bmMaintainceId, bmBookDetailId, bmLibrarianId, bmDamageById, bmTotalDamageCopies, bmDamageAvailableCopies, bmCostPerCopies, bmTotalCost, bmFor, bmDamageType, bmDamageByName, bmDate, bmStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return  ds;
    }
    public static DataSet GetSearch(TMSBookMaintance searchObject)
    {
        return GetSearch(searchObject.BMMaintainceId, searchObject.BMBookDetailId, searchObject.BMLibrarianId, searchObject.BMDamageById, searchObject.BMTotalDamageCopies, searchObject.BMDamageAvailableCopies, searchObject.BMCostPerCopies, searchObject.BMTotalCost, searchObject.BMFor, searchObject.BMDamageType, searchObject.BMDamageByName, searchObject.BMDate, searchObject.BMStatus);
    }

    /// <summary>
    /// Returns all TMSBookMaintance objects.
    /// </summary>
    /// <returns>List of all TMSBookMaintance objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null);
    }
    #endregion

    public static DataSet GetBookMentainanceDetails()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrGetBookMentainanceDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    public static DataSet GetLibraryAccount(System.String damagetype,System.Int64? bmloginID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrLibraryAccount";
        dbCommand = db.GetStoredProcCommand(sqlCommand, damagetype, bmloginID);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    public static DataSet GetLibrarian_BookMaintenanceDetails(System.String BookTitle, System.String BookAuthor, System.String BookPublication, System.Int64? SubjectId, System.Int64? SchoolId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].[gspLibrarianBookMaintenanceDetails_FilterWise]";
        dbCommand = db.GetStoredProcCommand(sqlCommand, BookTitle, BookAuthor, BookPublication, SubjectId, SchoolId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
}

