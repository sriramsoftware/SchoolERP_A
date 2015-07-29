using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSTransportStaff
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? tpId, System.Int64? tpLoginID, System.Int64? tpUsertype, System.String tpFirstName, System.String tpMiddleName, System.String tpLastName, System.String tpPhoto, System.DateTime? tpDob, System.String tpCaste, System.String tpSubCaste, System.String tpBirthPlace, System.String tpGender, System.String tpBloodGroup, System.String tpMotherTongue, System.DateTime? tpDoj, System.String tpHighestDegree, System.String tpCompletedYear, System.String tpUniversity, System.Int64? tpAddressId, System.String tpAgeproof, System.String tpReleavingLetter, System.String tpResume, System.Int32? tpStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSTransportStaff_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, tpId, tpLoginID, tpUsertype, tpFirstName, tpMiddleName, tpLastName, tpPhoto, tpDob, tpCaste, tpSubCaste, tpBirthPlace, tpGender, tpBloodGroup, tpMotherTongue, tpDoj, tpHighestDegree, tpCompletedYear, tpUniversity, tpAddressId, tpAgeproof, tpReleavingLetter, tpResume, tpStatus);

        return ds = db.ExecuteDataSet(dbCommand);

    }


    public static DataSet GetSearch(TMSTransportStaff searchObject)
    {
        return GetSearch(searchObject.TpId, searchObject.TPLoginID, searchObject.TPUsertype, searchObject.TPFirstName, searchObject.TPMiddleName, searchObject.TPLastName, searchObject.TPPhoto, searchObject.TpDob, searchObject.TPCaste, searchObject.TPSubCaste, searchObject.TPBirthPlace, searchObject.TPGender, searchObject.TPBloodGroup, searchObject.TPMotherTongue, searchObject.TpDoj, searchObject.TPHighestDegree, searchObject.TPCompletedYear, searchObject.TPUniversity, searchObject.TPAddressId, searchObject.TPAgeproof, searchObject.TPReleavingLetter, searchObject.TPResume, searchObject.TPStatus);
    }

    /// <summary>
    /// Returns all TMSTransportStaff objects.
    /// </summary>
    /// <returns>List of all TMSTransportStaff objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion




    //public static DataSet GetTransportdetails(System.Int64? TP_LoginID)
    //{
    //    DataSet ds;
    //    Database db;
    //    string sqlCommand;
    //    DbCommand dbCommand;


    //    db = DatabaseFactory.CreateDatabase();
    //    sqlCommand = "[dbo].gspTMSTransportStaff_Data";
    //    dbCommand = db.GetStoredProcCommand(sqlCommand, TP_LoginID);

    //    return ds = db.ExecuteDataSet(dbCommand);

    //}


    public static DataSet GetAllTransportdetails(System.Int64? TP_LoginID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSTransportStaffAllDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, TP_LoginID);

        return ds = db.ExecuteDataSet(dbCommand);

    }

    public static DataSet GetTransportdetails(System.Int64? TP_LoginID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSTransportStaff_Data";
        dbCommand = db.GetStoredProcCommand(sqlCommand, TP_LoginID);

        return ds = db.ExecuteDataSet(dbCommand);

    }

    public static DataSet GetDriverSupporterBusDetails(System.Int64? BAD_BusDriverId, System.Int64? BAD_BusConductorId, System.Int64? BAD_BusId, System.String BSD_StaffType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrGetDriverSupporterBusDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, BAD_BusDriverId, BAD_BusConductorId, BAD_BusId, BSD_StaffType);
        return ds = db.ExecuteDataSet(dbCommand);

    }


}

