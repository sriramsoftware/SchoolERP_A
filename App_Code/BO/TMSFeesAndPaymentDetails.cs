using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;

public partial class TMSFeesAndPaymentDetails
{

    #region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static DataSet GetSearch(System.Int64? sfpDetailsId, System.Int64? sfpStudentLoginId, System.Int64? sfpStandardId, System.Int64? sfpDivisionId, System.Double? sfpTotalFees, System.Double? sftPaidFees, System.Double? sfpRemainingFees, System.String sfpMonth, System.String sfpYear, System.DateTime? sfpTransactionDate, System.Int64? sfpAddedById, System.String sfpAddedByRemark, System.String sfpOtherRemark, System.DateTime? sfpDate, System.Int32? sfpStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesAndPaymentDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sfpDetailsId, sfpStudentLoginId, sfpStandardId, sfpDivisionId, sfpTotalFees, sftPaidFees, sfpRemainingFees, sfpMonth, sfpYear, sfpTransactionDate, sfpAddedById, sfpAddedByRemark, sfpOtherRemark, sfpDate, sfpStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
	
		return ds;
	}


    public static DataSet GetSearch(TMSFeesAndPaymentDetails searchObject)
	{
        return GetSearch(searchObject.SFPDetailsId, searchObject.SFPStudentLoginId, searchObject.SFPStandardId, searchObject.SFPDivisionId, searchObject.SFPTotalFees, searchObject.SFTPaidFees, searchObject.SFPRemainingFees, searchObject.SFPMonth, searchObject.SFPYear, searchObject.SFPTransactionDate, searchObject.SFPAddedById, searchObject.SFPAddedByRemark, searchObject.SFPOtherRemark, searchObject.SFPDate, searchObject.SFPStatus);
	}
	
	/// <summary>
	/// Returns all TMSFeesAndPaymentDetails objects.
	/// </summary>
	/// <returns>List of all TMSFeesAndPaymentDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
    public static DataSet GetSearch ()
	{
        return GetSearch(null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}


    public static DataSet GetStudentFeesDetails(System.Int64? StudentLoginId, System.Int64? StandardId, System.Int64? DivisionId, System.Int64? DetailsId, System.String Month, System.String Year, System.String View)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSGetStudentFeesDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StudentLoginId, StandardId, DivisionId, DetailsId, Month, Year, View);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet GetManageStudentFeesDetails(System.Int64? StudentLoginId, System.Int64? StandardId, System.Int64? DivisionId, System.Int64? DetailsId, System.String Month, System.String Year, System.String View)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSGetManageStudentFeesDetails";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StudentLoginId, StandardId, DivisionId, DetailsId, Month, Year, View);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }


    public static DataSet GetStudentName(System.Int64? StudentLoginId, System.Int64? StandardId, System.Int64? DivisionId)
    {
        DataSet ds;
        Database db;
        string sqlCommand;
        DbCommand dbCommand;


        db = DatabaseFactory.CreateDatabase();
        sqlCommand = "[dbo].gspTMSGetStudentName";
        dbCommand = db.GetStoredProcCommand(sqlCommand, StudentLoginId, StandardId, DivisionId);
        ds = db.ExecuteDataSet(dbCommand);

        return ds;
    }

    #endregion
}

