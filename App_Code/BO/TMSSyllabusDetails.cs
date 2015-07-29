using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSSyllabusDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? sdSyllabusId, System.Int64? sdUnitTestId, System.Int64? sdSchoolCatId, System.Int64? sdSubSchoolCatId, System.Int64? sdSubjectId, System.String sdTitle, System.String sdDescription, System.String sdDesription1, System.DateTime? sdDate, System.String sdAddedBy, System.Int64? sdAddedByID, System.Int32? sdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSSyllabusDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sdSyllabusId, sdUnitTestId, sdSchoolCatId, sdSubSchoolCatId, sdSubjectId, sdTitle, sdDescription, sdDesription1, sdDate, sdAddedBy, sdAddedByID, sdStatus);

        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }
    public static DataSet GetSearch(TMSSyllabusDetails searchObject)
    {
        return GetSearch(searchObject.SDSyllabusId, searchObject.SDUnitTestId, searchObject.SDSchoolCatId, searchObject.SDSubSchoolCatId, searchObject.SDSubjectId, searchObject.SDTitle, searchObject.SDDescription, searchObject.SDDesription1, searchObject.SDDate, searchObject.SDAddedBy, searchObject.SDAddedByID, searchObject.SDStatus);
    }
    /// <summary>
    /// Returns all TMSSyllabusDetails objects.
    /// </summary>
    /// <returns>List of all TMSSyllabusDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null);
    }
    #endregion
   public static DataSet GetSyllabusDetails(System.Int64? sdSchoolCatId, System.Int64? sdSubSchoolCatId, System.Int64? sdUnitTestId, System.Int64? sdSubjectId, System.String sdTitle, System.Int32? sdStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].TMS_SearchSyllabusDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sdSchoolCatId, sdSubSchoolCatId, sdUnitTestId, sdSubjectId, sdTitle, sdStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
   public static DataSet GetCorseSyllabusDetails(System.Int64? sdUnitTestId, System.Int64? sdSchoolCatId, System.Int64? sdSubjectId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFetchCourcesylabus";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sdUnitTestId, sdSchoolCatId, sdSubjectId);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
   public static DataSet GetSubjectBystandard(System.Int64? sdstandard, System.Int64? sdfaculty)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillSubjectbyStandurd";
        dbCommand = db.GetStoredProcCommand(sqlCommand, sdstandard, sdfaculty);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

   public static DataSet GetSubjectAccordingTOSchoolandFacultyID(System.Int64? sdstandard, System.Int64? sdfaculty)
   {
       DataSet ds;
       Database db;
       string sqlCommand;
       DbCommand dbCommand;


       db = DatabaseFactory.CreateDatabase();
       sqlCommand = "[dbo].gspTMSrGetSubjectAccordingTOSchoolandFacultyID";
       dbCommand = db.GetStoredProcCommand(sqlCommand, sdstandard, sdfaculty);

       ds = db.ExecuteDataSet(dbCommand);
       return ds;
   }
}

