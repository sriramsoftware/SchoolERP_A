using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSLibrarianDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet  GetSearch(System.Int64? lbId, System.Int64? lbLoginID, System.Int64? lbUsertype, System.String lbFirstName, System.String lbMiddleName, System.String lbLastName, System.String lbPhoto, System.DateTime? lbDob, System.String lbCaste, System.String lbSubCaste, System.String lbBirthPlace, System.String lbGender, System.String lbBloodGroup, System.String lbMotherTongue, System.DateTime? lbDoj, System.String lbHighestDegree, System.String lbCompletedYear, System.String lbUniversity, System.Int64? lbAddressId, System.String lbAgeproof, System.String lbReleavingLetter, System.String lbResume, System.Int32? lbStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSLibrarianDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, lbId, lbLoginID, lbUsertype, lbFirstName, lbMiddleName, lbLastName, lbPhoto, lbDob, lbCaste, lbSubCaste, lbBirthPlace, lbGender, lbBloodGroup, lbMotherTongue, lbDoj, lbHighestDegree, lbCompletedYear, lbUniversity, lbAddressId, lbAgeproof, lbReleavingLetter, lbResume, lbStatus);

       return ds = db.ExecuteDataSet(dbCommand);
        
    }

    public static DataSet GetAllLibrarydetails(System.Int64? TP_LoginID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSLibraryStaffAllDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, TP_LoginID);

        return ds = db.ExecuteDataSet(dbCommand);

    }
    public static DataSet  GetSearch(TMSLibrarianDetails searchObject)
    {
        return GetSearch(searchObject.LbId, searchObject.LBLoginID, searchObject.LBUsertype, searchObject.LBFirstName, searchObject.LBMiddleName, searchObject.LBLastName, searchObject.LBPhoto, searchObject.LbDob, searchObject.LBCaste, searchObject.LBSubCaste, searchObject.LBBirthPlace, searchObject.LBGender, searchObject.LBBloodGroup, searchObject.LBMotherTongue, searchObject.LbDoj, searchObject.LBHighestDegree, searchObject.LBCompletedYear, searchObject.LBUniversity, searchObject.LBAddressId, searchObject.LBAgeproof, searchObject.LBReleavingLetter, searchObject.LBResume, searchObject.LBStatus);
    }

    /// <summary>
    /// Returns all TMSLibrarianDetails objects.
    /// </summary>
    /// <returns>List of all TMSLibrarianDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion


    public static DataSet GetLibrarianDetails(System.Int64? LB_LoginID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSLibrarianStaff_Data";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LB_LoginID);

        return ds = db.ExecuteDataSet(dbCommand);

    }

}

