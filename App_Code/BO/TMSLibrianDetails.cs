using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSLibrianDetails
{
    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? ldLibrianId, System.Int64? ldLibraryId, System.Int64? ldLibraryManagerId, System.String ldSchoolType, System.String ldName, System.String ldImage, System.Int64? ldAddressId, System.DateTime? ldDateOfJoining, System.DateTime? ldDate, System.Int32? ldStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSLibrianDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ldLibrianId, ldLibraryId, ldLibraryManagerId, ldSchoolType, ldName, ldImage, ldAddressId, ldDateOfJoining, ldDate, ldStatus);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSLibrianDetails searchObject)
    {
        return GetSearch(searchObject.LDLibrianId, searchObject.LDLibraryId, searchObject.LDLibraryManagerId, searchObject.LDSchoolType, searchObject.LDName, searchObject.LDImage, searchObject.LDAddressId, searchObject.LDDateOfJoining, searchObject.LDDate, searchObject.LDStatus);
    }

    /// <summary>
    /// Returns all TMSLibrianDetails objects.
    /// </summary>
    /// <returns>List of all TMSLibrianDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null);
    }

    #endregion

    #region Add Librarian details

    public static bool AddLibrariandetails(TMSLibrianDetails objLib, TMSAddressDetails objAddress)
    {
        ConnectionHelper CHelper = new ConnectionHelper();
        DbTransaction _SqlTrans = null;
        SqlConnection _connection = null; ;
        bool flag = false;
        try
        {
            _connection = CHelper.GetConnection();
            _SqlTrans = _connection.BeginTransaction();
            objAddress.Insert(_SqlTrans);

            objLib.LDAddressId = objAddress.ADAddressId;
            objLib.Insert(_SqlTrans);
            flag = true;
            _SqlTrans.Commit();
        }
        catch (Exception ex)
        {
            flag = false;
            _SqlTrans.Rollback();
        }
        finally
        {
            CHelper.CloseConnection(_connection);
        }
        return flag;
    }
    #endregion

    #region Update Librarian details

    public static bool UpdateLibrariandetails(TMSLibrianDetails objLib, TMSAddressDetails objAddress)
    {
        ConnectionHelper CHelper = new ConnectionHelper();
        DbTransaction _SqlTrans = null;
        SqlConnection _connection = null; ;
        bool flag = false;
        try
        {
            _connection = CHelper.GetConnection();
            _SqlTrans = _connection.BeginTransaction();
            objAddress.Update(_SqlTrans);
            objLib.LDAddressId = objAddress.ADAddressId;
            objLib.Update(_SqlTrans);
            flag = true;
            _SqlTrans.Commit();
        }
        catch (Exception ex)
        {
            flag = false;
            _SqlTrans.Rollback();
        }
        finally
        {
            CHelper.CloseConnection(_connection);
        }
        return flag;
    }
    #endregion

    #region

    public static DataSet GetLibraryDetailsh(System.Int64? ldLibraryManagerId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSrGetLibraryDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ldLibraryManagerId);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion


    #region Get Librarian Details FilterWise

    public static DataSet GetLibrarianDetailsFilterWise(System.String LibraryId, System.Int64? LibraryManagerId, System.String SchoolType, System.String Name)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspLibrarianDetails_FilterWise";
        dbCommand = db.GetStoredProcCommand(sqlCommand, LibraryId, LibraryManagerId, SchoolType, Name);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }
    #endregion



    public static DataSet ViewAllLibrarianDetails(System.Int64? ldLibrianId, System.Int64? ldLibraryId, System.Int64? ldLibraryManagerId, System.String ldImage, System.Int64? ldAddressId, System.DateTime? ldDateOfJoining, System.DateTime? ldDate, System.String ldName,System.String ldSchoolType)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspViewAllLibrarianDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, ldLibrianId, ldLibraryId, ldLibraryManagerId, ldImage, ldAddressId, ldDateOfJoining, ldDate, ldName, ldSchoolType);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }



}

