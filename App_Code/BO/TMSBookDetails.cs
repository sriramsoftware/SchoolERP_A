
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;


public partial class TMSBookDetails
{


    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? bdDetailsId, System.String bdBookId, System.Int64? bdLibraryManagerId, System.String bdBookType, System.Int64? bdSubjectId, System.Int64? bdSchoolId, System.String bdBookName, System.String bdPublication, System.String bdAuthor, System.String bdTotalCopies, System.String bdAvailableCopies, System.String bdPerCopyCost, System.String bdTotalCost, System.String bdFor, System.String bdDescription, System.DateTime? bdDate, System.Int32? bdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSBookDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, bdDetailsId, bdBookId, bdLibraryManagerId, bdBookType, bdSubjectId, bdSchoolId, bdBookName, bdPublication, bdAuthor, bdTotalCopies, bdAvailableCopies, bdPerCopyCost, bdTotalCost, bdFor, bdDescription, bdDate, bdStatus);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet GetSearch(TMSBookDetails searchObject)
    {
        return GetSearch(searchObject.BDDetailsId, searchObject.BDBookId, searchObject.BDLibraryManagerId, searchObject.BDBookType, searchObject.BDSubjectId, searchObject.BDSchoolId, searchObject.BDBookName, searchObject.BDPublication, searchObject.BDAuthor, searchObject.BDTotalCopies, searchObject.BDAvailableCopies, searchObject.BDPerCopyCost, searchObject.BDTotalCost, searchObject.BDFor, searchObject.BDDescription, searchObject.BDDate, searchObject.BDStatus);
    }

    /// <summary>
    /// Returns all TMSBookDetails objects.
    /// </summary>
    /// <returns>List of all TMSBookDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion

    public static DataSet GetBookDetails()
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrGetBookDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }

    public static DataSet GetbooknewArrival(System.Int64? LibrarianID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillNewArriver";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LibrarianID);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    #region Get All Book Details



    public static DataSet GetLibrarianBookDetails_FilterWise(System.String BookTitle, System.String BookAuthor, System.String BookPublication, System.Int64? SubjectId, System.Int64? SchoolId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspLibrarianBookDetails_FilterWise";
        dbCommand = db.GetStoredProcCommand(sqlCommand, BookTitle, BookAuthor, BookPublication, SubjectId, SchoolId);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion

}

