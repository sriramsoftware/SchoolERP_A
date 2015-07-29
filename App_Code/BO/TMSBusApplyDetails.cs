using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSBusApplyDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? badApplyId, System.Int64? badStudentId, System.Int64? badFacultyId, System.Int64? badBusId, System.String badSeatNumber, System.String badTravelingStatus, System.DateTime? badDate, System.Int32? badStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSBusApplyDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, badApplyId, badStudentId, badFacultyId, badBusId, badSeatNumber, badTravelingStatus, badDate, badStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet GetSearch(TMSBusApplyDetails searchObject)
    {
        return GetSearch(searchObject.BADApplyId, searchObject.BADStudentId, searchObject.BADFacultyId, searchObject.BADBusId, searchObject.BADSeatNumber, searchObject.BADTravelingStatus, searchObject.BADDate, searchObject.BADStatus);
    }
    /// <summary>
    /// Returns all TMSBusApplyDetails objects.
    /// </summary>
    /// <returns>List of all TMSBusApplyDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null);
    }
    public static DataSet GetSeatdetails(System.Int64? BusApplyId, System.Int64? StudentId, System.Int64? FacultyId, System.Int64? BusId, System.String SeatNumber, System.String TravellingStatus, System.Int32? Status, System.String UserName, System.String UserType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillBusSeatnoTeacheStudent";
        dbCommand = db.GetStoredProcCommand(sqlCommand, BusApplyId, StudentId,FacultyId,BusId,SeatNumber,TravellingStatus,Status,UserName,UserType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet FillteacherAccordingTObus(System.Int64? busID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillteacherAccordingTObus";
        dbCommand = db.GetStoredProcCommand(sqlCommand, busID);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet FillstudentAccordingTObus(System.Int64? busID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillstudentAccordingTObus";
        dbCommand = db.GetStoredProcCommand(sqlCommand, busID);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet FillSearchbyDriverbus(System.String BSD_StaffName, System.String BD_BusNumber, System.String BR_StartRoute, System.String BSD_BusStaffId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillSearchbyDriver";
        dbCommand = db.GetStoredProcCommand(sqlCommand, BSD_StaffName, BD_BusNumber, BR_StartRoute, BSD_BusStaffId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    public static DataSet FillSearchbySupporterbus(System.String BSD_StaffName, System.String BD_BusNumber, System.String BR_StartRoute, System.String BSD_BusStaffId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillSearchbySupporter";
        dbCommand = db.GetStoredProcCommand(sqlCommand, BSD_StaffName, BD_BusNumber, BR_StartRoute, BSD_BusStaffId);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet FillQueckserchTeacherBus(System.String BSD_StaffName, System.String BR_StartRoute, System.String BD_BusNumber)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrFillQueckserchTeacher";
        dbCommand = db.GetStoredProcCommand(sqlCommand, BSD_StaffName, BR_StartRoute, BD_BusNumber);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }

    public static DataSet FillBusNumberAccordingtoDriverCondoctorID(System.Int64? DriverID, System.Int64? SupporterIDID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSBusNumberAccordingtoDriverCondoctorID";
        dbCommand = db.GetStoredProcCommand(sqlCommand, DriverID, SupporterIDID);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetBusDetailsID(System.Int64? UserID, System.String Type)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSgetBusDetailsID";
        dbCommand = db.GetStoredProcCommand(sqlCommand, UserID, Type);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetCheckBusSeat(System.Int64? BusID, System.Int64? StudentID, System.Int64? TeacherID)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMS_CheckBusSeat";
        dbCommand = db.GetStoredProcCommand(sqlCommand, BusID, StudentID, TeacherID);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion
}

