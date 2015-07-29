/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 11/30/2012 11:26:19 AM                                    */
/*                                                                          */
/* www.CodeAuthor.org                                                       */
/****************************************************************************/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
    
[DataObject]
[Serializable]
public partial class TMSFeesAndPaymentDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_FeesAndPaymentDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _sfpDetailsId;
	private System.Int64? _sfpStudentLoginId;
	private System.Int64? _sfpStandardId;
	private System.Int64? _sfpDivisionId;
	private System.Double? _sfpTotalFees;
	private System.Double? _sftPaidFees;
	private System.Double? _sfpRemainingFees;
	private System.String _sfpMonth;
	private System.String _sfpYear;
	private System.DateTime? _sfpTransactionDate;
	private System.Int64? _sfpAddedById;
	private System.String _sfpAddedByRemark;
	private System.String _sfpOtherRemark;
	private System.DateTime? _sfpDate;
	private System.Int32? _sfpStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? SFPDetailsId
	{
		get
		{
			return _sfpDetailsId;
		}
		set
		{
			_sfpDetailsId = value;
		}
	}
	
	public System.Int64? SFPStudentLoginId
	{
		get
		{
			return _sfpStudentLoginId;
		}
		set
		{
			_sfpStudentLoginId = value;
		}
	}
	
	public System.Int64? SFPStandardId
	{
		get
		{
			return _sfpStandardId;
		}
		set
		{
			_sfpStandardId = value;
		}
	}
	
	public System.Int64? SFPDivisionId
	{
		get
		{
			return _sfpDivisionId;
		}
		set
		{
			_sfpDivisionId = value;
		}
	}
	
	public System.Double? SFPTotalFees
	{
		get
		{
			return _sfpTotalFees;
		}
		set
		{
			_sfpTotalFees = value;
		}
	}
	
	public System.Double? SFTPaidFees
	{
		get
		{
			return _sftPaidFees;
		}
		set
		{
			_sftPaidFees = value;
		}
	}
	
	public System.Double? SFPRemainingFees
	{
		get
		{
			return _sfpRemainingFees;
		}
		set
		{
			_sfpRemainingFees = value;
		}
	}
	
	public System.String SFPMonth
	{
		get
		{
			return _sfpMonth;
		}
		set
		{
			_sfpMonth = value;
		}
	}
	
	public System.String SFPYear
	{
		get
		{
			return _sfpYear;
		}
		set
		{
			_sfpYear = value;
		}
	}
	
	public System.DateTime? SFPTransactionDate
	{
		get
		{
			return _sfpTransactionDate;
		}
		set
		{
			_sfpTransactionDate = value;
		}
	}
	
	public System.Int64? SFPAddedById
	{
		get
		{
			return _sfpAddedById;
		}
		set
		{
			_sfpAddedById = value;
		}
	}
	
	public System.String SFPAddedByRemark
	{
		get
		{
			return _sfpAddedByRemark;
		}
		set
		{
			_sfpAddedByRemark = value;
		}
	}
	
	public System.String SFPOtherRemark
	{
		get
		{
			return _sfpOtherRemark;
		}
		set
		{
			_sfpOtherRemark = value;
		}
	}
	
	public System.DateTime? SFPDate
	{
		get
		{
			return _sfpDate;
		}
		set
		{
			_sfpDate = value;
		}
	}
	
	public System.Int32? SFPStatus
	{
		get
		{
			return _sfpStatus;
		}
		set
		{
			_sfpStatus = value;
		}
	}
	
	#endregion
	
	
	#region Methods
	
	
	#region Mapping Methods
	
	protected void MapTo(DataSet ds)
	{
		DataRow dr;
		
		
		if (ds == null)
		ds = new DataSet();
		
		if (ds.Tables["TABLE_NAME"] == null)
		ds.Tables.Add(TABLE_NAME);
		
		ds.Tables[TABLE_NAME].Columns.Add("SFP_DetailsId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SFP_StudentLoginId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SFP_StandardId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SFP_DivisionId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SFP_TotalFees", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("SFT_PaidFees", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("SFP_RemainingFees", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("SFP_Month", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SFP_Year", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SFP_TransactionDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SFP_AddedById", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SFP_AddedByRemark", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SFP_OtherRemark", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SFP_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SFP_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (SFPDetailsId == null)
		dr["SFP_DetailsId"] = DBNull.Value;
		else
		dr["SFP_DetailsId"] = SFPDetailsId;
		
		if (SFPStudentLoginId == null)
		dr["SFP_StudentLoginId"] = DBNull.Value;
		else
		dr["SFP_StudentLoginId"] = SFPStudentLoginId;
		
		if (SFPStandardId == null)
		dr["SFP_StandardId"] = DBNull.Value;
		else
		dr["SFP_StandardId"] = SFPStandardId;
		
		if (SFPDivisionId == null)
		dr["SFP_DivisionId"] = DBNull.Value;
		else
		dr["SFP_DivisionId"] = SFPDivisionId;
		
		if (SFPTotalFees == null)
		dr["SFP_TotalFees"] = DBNull.Value;
		else
		dr["SFP_TotalFees"] = SFPTotalFees;
		
		if (SFTPaidFees == null)
		dr["SFT_PaidFees"] = DBNull.Value;
		else
		dr["SFT_PaidFees"] = SFTPaidFees;
		
		if (SFPRemainingFees == null)
		dr["SFP_RemainingFees"] = DBNull.Value;
		else
		dr["SFP_RemainingFees"] = SFPRemainingFees;
		
		if (SFPMonth == null)
		dr["SFP_Month"] = DBNull.Value;
		else
		dr["SFP_Month"] = SFPMonth;
		
		if (SFPYear == null)
		dr["SFP_Year"] = DBNull.Value;
		else
		dr["SFP_Year"] = SFPYear;
		
		if (SFPTransactionDate == null)
		dr["SFP_TransactionDate"] = DBNull.Value;
		else
		dr["SFP_TransactionDate"] = SFPTransactionDate;
		
		if (SFPAddedById == null)
		dr["SFP_AddedById"] = DBNull.Value;
		else
		dr["SFP_AddedById"] = SFPAddedById;
		
		if (SFPAddedByRemark == null)
		dr["SFP_AddedByRemark"] = DBNull.Value;
		else
		dr["SFP_AddedByRemark"] = SFPAddedByRemark;
		
		if (SFPOtherRemark == null)
		dr["SFP_OtherRemark"] = DBNull.Value;
		else
		dr["SFP_OtherRemark"] = SFPOtherRemark;
		
		if (SFPDate == null)
		dr["SFP_Date"] = DBNull.Value;
		else
		dr["SFP_Date"] = SFPDate;
		
		if (SFPStatus == null)
		dr["SFP_Status"] = DBNull.Value;
		else
		dr["SFP_Status"] = SFPStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		SFPDetailsId = dr["SFP_DetailsId"] != DBNull.Value ? Convert.ToInt64(dr["SFP_DetailsId"]) : SFPDetailsId = null;
		SFPStudentLoginId = dr["SFP_StudentLoginId"] != DBNull.Value ? Convert.ToInt64(dr["SFP_StudentLoginId"]) : SFPStudentLoginId = null;
		SFPStandardId = dr["SFP_StandardId"] != DBNull.Value ? Convert.ToInt64(dr["SFP_StandardId"]) : SFPStandardId = null;
		SFPDivisionId = dr["SFP_DivisionId"] != DBNull.Value ? Convert.ToInt64(dr["SFP_DivisionId"]) : SFPDivisionId = null;
		SFPTotalFees = dr["SFP_TotalFees"] != DBNull.Value ? Convert.ToDouble(dr["SFP_TotalFees"]) : SFPTotalFees = null;
		SFTPaidFees = dr["SFT_PaidFees"] != DBNull.Value ? Convert.ToDouble(dr["SFT_PaidFees"]) : SFTPaidFees = null;
		SFPRemainingFees = dr["SFP_RemainingFees"] != DBNull.Value ? Convert.ToDouble(dr["SFP_RemainingFees"]) : SFPRemainingFees = null;
		SFPMonth = dr["SFP_Month"] != DBNull.Value ? Convert.ToString(dr["SFP_Month"]) : SFPMonth = null;
		SFPYear = dr["SFP_Year"] != DBNull.Value ? Convert.ToString(dr["SFP_Year"]) : SFPYear = null;
		SFPTransactionDate = dr["SFP_TransactionDate"] != DBNull.Value ? Convert.ToDateTime(dr["SFP_TransactionDate"]) : SFPTransactionDate = null;
		SFPAddedById = dr["SFP_AddedById"] != DBNull.Value ? Convert.ToInt64(dr["SFP_AddedById"]) : SFPAddedById = null;
		SFPAddedByRemark = dr["SFP_AddedByRemark"] != DBNull.Value ? Convert.ToString(dr["SFP_AddedByRemark"]) : SFPAddedByRemark = null;
		SFPOtherRemark = dr["SFP_OtherRemark"] != DBNull.Value ? Convert.ToString(dr["SFP_OtherRemark"]) : SFPOtherRemark = null;
		SFPDate = dr["SFP_Date"] != DBNull.Value ? Convert.ToDateTime(dr["SFP_Date"]) : SFPDate = null;
		SFPStatus = dr["SFP_Status"] != DBNull.Value ? Convert.ToInt32(dr["SFP_Status"]) : SFPStatus = null;
	}
	
	public static TMSFeesAndPaymentDetails[] MapFrom(DataSet ds)
	{
		List<TMSFeesAndPaymentDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSFeesAndPaymentDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_FeesAndPaymentDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_FeesAndPaymentDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSFeesAndPaymentDetails instance = new TMSFeesAndPaymentDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFeesAndPaymentDetails Get(System.Int64 sfpDetailsId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSFeesAndPaymentDetails instance;
		
		
		instance = new TMSFeesAndPaymentDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesAndPaymentDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sfpDetailsId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSFeesAndPaymentDetails ID:" + sfpDetailsId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? sfpStudentLoginId, System.Int64? sfpStandardId, System.Int64? sfpDivisionId, System.Double? sfpTotalFees, System.Double? sftPaidFees, System.Double? sfpRemainingFees, System.String sfpMonth, System.String sfpYear, System.DateTime? sfpTransactionDate, System.Int64? sfpAddedById, System.String sfpAddedByRemark, System.String sfpOtherRemark, System.DateTime? sfpDate, System.Int32? sfpStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesAndPaymentDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sfpStudentLoginId, sfpStandardId, sfpDivisionId, sfpTotalFees, sftPaidFees, sfpRemainingFees, sfpMonth, sfpYear, sfpTransactionDate, sfpAddedById, sfpAddedByRemark, sfpOtherRemark, sfpDate, sfpStatus);
		
		if (transaction == null)
		this.SFPDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.SFPDetailsId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? sfpStudentLoginId, System.Int64? sfpStandardId, System.Int64? sfpDivisionId, System.Double? sfpTotalFees, System.Double? sftPaidFees, System.Double? sfpRemainingFees, System.String sfpMonth, System.String sfpYear, System.DateTime? sfpTransactionDate, System.Int64? sfpAddedById, System.String sfpAddedByRemark, System.String sfpOtherRemark, System.DateTime? sfpDate, System.Int32? sfpStatus)
	{
		Insert(sfpStudentLoginId, sfpStandardId, sfpDivisionId, sfpTotalFees, sftPaidFees, sfpRemainingFees, sfpMonth, sfpYear, sfpTransactionDate, sfpAddedById, sfpAddedByRemark, sfpOtherRemark, sfpDate, sfpStatus, null);
	}
	/// <summary>
	/// Insert current TMSFeesAndPaymentDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(SFPStudentLoginId, SFPStandardId, SFPDivisionId, SFPTotalFees, SFTPaidFees, SFPRemainingFees, SFPMonth, SFPYear, SFPTransactionDate, SFPAddedById, SFPAddedByRemark, SFPOtherRemark, SFPDate, SFPStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSFeesAndPaymentDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? sfpDetailsId, System.Int64? sfpStudentLoginId, System.Int64? sfpStandardId, System.Int64? sfpDivisionId, System.Double? sfpTotalFees, System.Double? sftPaidFees, System.Double? sfpRemainingFees, System.String sfpMonth, System.String sfpYear, System.DateTime? sfpTransactionDate, System.Int64? sfpAddedById, System.String sfpAddedByRemark, System.String sfpOtherRemark, System.DateTime? sfpDate, System.Int32? sfpStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesAndPaymentDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@sfpDetailsId"].Value = sfpDetailsId;
		dbCommand.Parameters["@sfpStudentLoginId"].Value = sfpStudentLoginId;
		dbCommand.Parameters["@sfpStandardId"].Value = sfpStandardId;
		dbCommand.Parameters["@sfpDivisionId"].Value = sfpDivisionId;
		dbCommand.Parameters["@sfpTotalFees"].Value = sfpTotalFees;
		dbCommand.Parameters["@sftPaidFees"].Value = sftPaidFees;
		dbCommand.Parameters["@sfpRemainingFees"].Value = sfpRemainingFees;
		dbCommand.Parameters["@sfpMonth"].Value = sfpMonth;
		dbCommand.Parameters["@sfpYear"].Value = sfpYear;
		dbCommand.Parameters["@sfpTransactionDate"].Value = sfpTransactionDate;
		dbCommand.Parameters["@sfpAddedById"].Value = sfpAddedById;
		dbCommand.Parameters["@sfpAddedByRemark"].Value = sfpAddedByRemark;
		dbCommand.Parameters["@sfpOtherRemark"].Value = sfpOtherRemark;
		dbCommand.Parameters["@sfpDate"].Value = sfpDate;
		dbCommand.Parameters["@sfpStatus"].Value = sfpStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? sfpDetailsId, System.Int64? sfpStudentLoginId, System.Int64? sfpStandardId, System.Int64? sfpDivisionId, System.Double? sfpTotalFees, System.Double? sftPaidFees, System.Double? sfpRemainingFees, System.String sfpMonth, System.String sfpYear, System.DateTime? sfpTransactionDate, System.Int64? sfpAddedById, System.String sfpAddedByRemark, System.String sfpOtherRemark, System.DateTime? sfpDate, System.Int32? sfpStatus)
	{
		Update(sfpDetailsId, sfpStudentLoginId, sfpStandardId, sfpDivisionId, sfpTotalFees, sftPaidFees, sfpRemainingFees, sfpMonth, sfpYear, sfpTransactionDate, sfpAddedById, sfpAddedByRemark, sfpOtherRemark, sfpDate, sfpStatus, null);
	}
	
	public static void Update(TMSFeesAndPaymentDetails tMSFeesAndPaymentDetails)
	{
		tMSFeesAndPaymentDetails.Update();
	}
	
	public static void Update(TMSFeesAndPaymentDetails tMSFeesAndPaymentDetails, DbTransaction transaction)
	{
		tMSFeesAndPaymentDetails.Update(transaction);
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Update(DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesAndPaymentDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@sfpDetailsId"].SourceColumn = "SFP_DetailsId";
		dbCommand.Parameters["@sfpStudentLoginId"].SourceColumn = "SFP_StudentLoginId";
		dbCommand.Parameters["@sfpStandardId"].SourceColumn = "SFP_StandardId";
		dbCommand.Parameters["@sfpDivisionId"].SourceColumn = "SFP_DivisionId";
		dbCommand.Parameters["@sfpTotalFees"].SourceColumn = "SFP_TotalFees";
		dbCommand.Parameters["@sftPaidFees"].SourceColumn = "SFT_PaidFees";
		dbCommand.Parameters["@sfpRemainingFees"].SourceColumn = "SFP_RemainingFees";
		dbCommand.Parameters["@sfpMonth"].SourceColumn = "SFP_Month";
		dbCommand.Parameters["@sfpYear"].SourceColumn = "SFP_Year";
		dbCommand.Parameters["@sfpTransactionDate"].SourceColumn = "SFP_TransactionDate";
		dbCommand.Parameters["@sfpAddedById"].SourceColumn = "SFP_AddedById";
		dbCommand.Parameters["@sfpAddedByRemark"].SourceColumn = "SFP_AddedByRemark";
		dbCommand.Parameters["@sfpOtherRemark"].SourceColumn = "SFP_OtherRemark";
		dbCommand.Parameters["@sfpDate"].SourceColumn = "SFP_Date";
		dbCommand.Parameters["@sfpStatus"].SourceColumn = "SFP_Status";
		
		ds = new DataSet();
		this.MapTo( ds );
		ds.AcceptChanges();
		ds.Tables[0].Rows[0].SetModified();
		if (transaction == null)
		db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, UpdateBehavior.Standard);
		else
		db.UpdateDataSet(ds, TABLE_NAME, null, dbCommand, null, transaction);
		return;
	}
	
	/// <summary>
	/// Updates changes to the database.
	/// </summary>
	public void Update()
	{
		this.Update((DbTransaction)null);
	}
	#endregion
	
	
	#region DELETE
	[DataObjectMethodAttribute(DataObjectMethodType.Delete, false)]
	public static void Delete(System.Int64? sfpDetailsId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesAndPaymentDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sfpDetailsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Delete, true)]
	public static void Delete(System.Int64? sfpDetailsId)
	{
		Delete(
		sfpDetailsId);
	}
	
	/// <summary>
	/// Delete current TMSFeesAndPaymentDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesAndPaymentDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, SFPDetailsId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.SFPDetailsId = null;
	}
	
	/// <summary>
	/// Delete current TMSFeesAndPaymentDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSFeesAndPaymentDetails[] Search(System.Int64? sfpDetailsId, System.Int64? sfpStudentLoginId, System.Int64? sfpStandardId, System.Int64? sfpDivisionId, System.Double? sfpTotalFees, System.Double? sftPaidFees, System.Double? sfpRemainingFees, System.String sfpMonth, System.String sfpYear, System.DateTime? sfpTransactionDate, System.Int64? sfpAddedById, System.String sfpAddedByRemark, System.String sfpOtherRemark, System.DateTime? sfpDate, System.Int32? sfpStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSFeesAndPaymentDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, sfpDetailsId, sfpStudentLoginId, sfpStandardId, sfpDivisionId, sfpTotalFees, sftPaidFees, sfpRemainingFees, sfpMonth, sfpYear, sfpTransactionDate, sfpAddedById, sfpAddedByRemark, sfpOtherRemark, sfpDate, sfpStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSFeesAndPaymentDetails.MapFrom(ds);
	}
	
	
	public static TMSFeesAndPaymentDetails[] Search(TMSFeesAndPaymentDetails searchObject)
	{
		return Search ( searchObject.SFPDetailsId, searchObject.SFPStudentLoginId, searchObject.SFPStandardId, searchObject.SFPDivisionId, searchObject.SFPTotalFees, searchObject.SFTPaidFees, searchObject.SFPRemainingFees, searchObject.SFPMonth, searchObject.SFPYear, searchObject.SFPTransactionDate, searchObject.SFPAddedById, searchObject.SFPAddedByRemark, searchObject.SFPOtherRemark, searchObject.SFPDate, searchObject.SFPStatus);
	}
	
	/// <summary>
	/// Returns all TMSFeesAndPaymentDetails objects.
	/// </summary>
	/// <returns>List of all TMSFeesAndPaymentDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSFeesAndPaymentDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

