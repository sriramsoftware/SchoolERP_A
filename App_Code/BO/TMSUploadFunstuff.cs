using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSUploadFunstuff
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet   GetSearch(System.Int64? ufFunStuffID, System.Int64? ufSchoolID, System.Int64? ufSchoolSubcategoryID, System.Int64? ufFacultyID, System.String ufFunType, System.String ufTitle, System.String ufDescription1, System.String ufDescription2, System.String ufCoverImage, System.String ufGameLink, System.String ufAddedby, System.String ufExtra2, System.DateTime? ufDate, System.Int32? ufStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSUploadFunstuff_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ufFunStuffID, ufSchoolID, ufSchoolSubcategoryID, ufFacultyID, ufFunType, ufTitle, ufDescription1, ufDescription2, ufCoverImage, ufGameLink, ufAddedby, ufExtra2, ufDate, ufStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds ;
    }


    public static DataSet GetSearch(TMSUploadFunstuff searchObject)
    {
        return GetSearch(searchObject.UFFunStuffID, searchObject.UFSchoolID, searchObject.UFSchoolSubcategoryID, searchObject.UFFacultyID, searchObject.UFFunType, searchObject.UFTitle, searchObject.UFDescription1, searchObject.UFDescription2, searchObject.UFCoverImage, searchObject.UFGameLink, searchObject.UFAddedby, searchObject.UFExtra2, searchObject.UFDate, searchObject.UFStatus);
    }

    /// <summary>
    /// Returns all TMSUploadFunstuff objects.
    /// </summary>
    /// <returns>List of all TMSUploadFunstuff objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }
    



      public static DataSet  GetStories(System.Int64? loginID,System.String Type,System.String subtype,System.String sort)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrGetStories";
        dbCommand = db.GetStoredProcCommand(sqlCommand, loginID, Type, subtype, sort);

        ds = db.ExecuteDataSet(dbCommand);
        return ds ;
    }

      public static DataSet GetSUploadedFunStuyff(System.Int64? loginID, System.String Type, System.String subtype, System.String sort)
      {
          DataSet ds;
          Database db;
          string sqlCommand;
          DbCommand dbCommand;


          db = DatabaseFactory.CreateDatabase();
          sqlCommand = "[dbo].gspTMSUploadedFunStuyff";
          dbCommand = db.GetStoredProcCommand(sqlCommand, loginID, Type, subtype, sort);

          ds = db.ExecuteDataSet(dbCommand);
          return ds;
      }
    #endregion
}

