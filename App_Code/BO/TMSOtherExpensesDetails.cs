using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
public partial class TMSOtherExpensesDetails
{

    #region SEARCH
    [DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
    public static DataSet GetSearch(System.Int64? spoeDetailsId, System.String spoeTitle, System.String spoeItemName, System.String spoeType, System.String spoeQuantity, System.String spoeDescription, System.Double? spoeTotalAmount, System.String spoeMonth, System.String spoeYear, System.DateTime? spoeTransactionDate, System.Int64? spoeAddedById, System.String spoeAddedByRemark, System.String spoeExtraOne, System.String spoeExtraTwo, System.DateTime? spoeDate, System.Int32? spoeStatus)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSOtherExpensesDetails_SEARCH";
        dbCommand = db.GetStoredProcCommand(sqlCommand, spoeDetailsId, spoeTitle, spoeItemName, spoeType, spoeQuantity, spoeDescription, spoeTotalAmount, spoeMonth, spoeYear, spoeTransactionDate, spoeAddedById, spoeAddedByRemark, spoeExtraOne, spoeExtraTwo, spoeDate, spoeStatus);

        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetSearch(TMSOtherExpensesDetails searchObject)
    {
        return GetSearch(searchObject.SPOEDetailsId, searchObject.SPOETitle, searchObject.SPOEItemName, searchObject.SPOEType, searchObject.SPOEQuantity, searchObject.SPOEDescription, searchObject.SPOETotalAmount, searchObject.SPOEMonth, searchObject.SPOEYear, searchObject.SPOETransactionDate, searchObject.SPOEAddedById, searchObject.SPOEAddedByRemark, searchObject.SPOEExtraOne, searchObject.SPOEExtraTwo, searchObject.SPOEDate, searchObject.SPOEStatus);
    }

    /// <summary>
    /// Returns all TMSOtherExpensesDetails objects.
    /// </summary>
    /// <returns>List of all TMSOtherExpensesDetails objects. </returns>
    [DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch()
    {
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
    }

    #endregion


    public static DataSet GetAllExpensesDetails(System.Int64? spoeDetailsId, System.String spoeTitle, System.String spoeItemName, System.String spoeType, System.String spoeQuantity, System.String spoeMonth, System.String spoeYear, System.DateTime? spoeTransactionDate, System.Int64? spoeAddedById, System.String spoeAddedByRemark)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspGetAllExpensesDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, spoeDetailsId, spoeTitle, spoeItemName, spoeType, spoeQuantity, spoeMonth, spoeYear, spoeTransactionDate, spoeAddedById, spoeAddedByRemark);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet GetExpenseDetailsMonthAndYearWise(System.Int64? spoeAddedById, System.String spoeType, System.String spoeMonth, System.String spoeYear)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspView_OtherExpensesDetails_MonthYearWise";
        dbCommand = db.GetStoredProcCommand(sqlCommand,spoeAddedById,spoeType,spoeMonth,spoeYear);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


    public static DataSet ViewPopUpDetailsMonthAndYearWise(System.Int64? spoeAddedById, System.String spoeType, System.String spoeMonth, System.String spoeYear)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;
        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspView_OtherExpenses_PopUp_Details_MonthYearWise";
        dbCommand = db.GetStoredProcCommand(sqlCommand, spoeAddedById, spoeType, spoeMonth, spoeYear);
        ds = db.ExecuteDataSet(dbCommand);
        return ds;
    }


}

