/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 11/22/2012 10:38:22 AM                                    */
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
public partial class TMSRentAccountDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_RentAccountDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _racRentId;
	private System.String _racMonth;
	private System.String _racYear;
	private System.Double? _racTotalAmount;
	private System.Double? _racPaidAmount;
	private System.Double? _racAnyDues;
	private System.Int64? _racAddedById;
	private System.String _racPaidStatus;
	private System.DateTime? _racTransactionDate;
	private System.DateTime? _racDate;
	private System.Int32? _racStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? RACRentId
	{
		get
		{
			return _racRentId;
		}
		set
		{
			_racRentId = value;
		}
	}
	
	public System.String RACMonth
	{
		get
		{
			return _racMonth;
		}
		set
		{
			_racMonth = value;
		}
	}
	
	public System.String RACYear
	{
		get
		{
			return _racYear;
		}
		set
		{
			_racYear = value;
		}
	}
	
	public System.Double? RACTotalAmount
	{
		get
		{
			return _racTotalAmount;
		}
		set
		{
			_racTotalAmount = value;
		}
	}
	
	public System.Double? RACPaidAmount
	{
		get
		{
			return _racPaidAmount;
		}
		set
		{
			_racPaidAmount = value;
		}
	}
	
	public System.Double? RACAnyDues
	{
		get
		{
			return _racAnyDues;
		}
		set
		{
			_racAnyDues = value;
		}
	}
	
	public System.Int64? RACAddedById
	{
		get
		{
			return _racAddedById;
		}
		set
		{
			_racAddedById = value;
		}
	}
	
	public System.String RACPaidStatus
	{
		get
		{
			return _racPaidStatus;
		}
		set
		{
			_racPaidStatus = value;
		}
	}
	
	public System.DateTime? RACTransactionDate
	{
		get
		{
			return _racTransactionDate;
		}
		set
		{
			_racTransactionDate = value;
		}
	}
	
	public System.DateTime? RACDate
	{
		get
		{
			return _racDate;
		}
		set
		{
			_racDate = value;
		}
	}
	
	public System.Int32? RacStatus
	{
		get
		{
			return _racStatus;
		}
		set
		{
			_racStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("RAC_RentId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("RAC_Month", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RAC_Year", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RAC_TotalAmount", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("RAC_PaidAmount", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("RAC_AnyDues", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("RAC_AddedById", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("RAC_PaidStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("RAC_TransactionDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("RAC_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("Rac_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (RACRentId == null)
		dr["RAC_RentId"] = DBNull.Value;
		else
		dr["RAC_RentId"] = RACRentId;
		
		if (RACMonth == null)
		dr["RAC_Month"] = DBNull.Value;
		else
		dr["RAC_Month"] = RACMonth;
		
		if (RACYear == null)
		dr["RAC_Year"] = DBNull.Value;
		else
		dr["RAC_Year"] = RACYear;
		
		if (RACTotalAmount == null)
		dr["RAC_TotalAmount"] = DBNull.Value;
		else
		dr["RAC_TotalAmount"] = RACTotalAmount;
		
		if (RACPaidAmount == null)
		dr["RAC_PaidAmount"] = DBNull.Value;
		else
		dr["RAC_PaidAmount"] = RACPaidAmount;
		
		if (RACAnyDues == null)
		dr["RAC_AnyDues"] = DBNull.Value;
		else
		dr["RAC_AnyDues"] = RACAnyDues;
		
		if (RACAddedById == null)
		dr["RAC_AddedById"] = DBNull.Value;
		else
		dr["RAC_AddedById"] = RACAddedById;
		
		if (RACPaidStatus == null)
		dr["RAC_PaidStatus"] = DBNull.Value;
		else
		dr["RAC_PaidStatus"] = RACPaidStatus;
		
		if (RACTransactionDate == null)
		dr["RAC_TransactionDate"] = DBNull.Value;
		else
		dr["RAC_TransactionDate"] = RACTransactionDate;
		
		if (RACDate == null)
		dr["RAC_Date"] = DBNull.Value;
		else
		dr["RAC_Date"] = RACDate;
		
		if (RacStatus == null)
		dr["Rac_Status"] = DBNull.Value;
		else
		dr["Rac_Status"] = RacStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		RACRentId = dr["RAC_RentId"] != DBNull.Value ? Convert.ToInt64(dr["RAC_RentId"]) : RACRentId = null;
		RACMonth = dr["RAC_Month"] != DBNull.Value ? Convert.ToString(dr["RAC_Month"]) : RACMonth = null;
		RACYear = dr["RAC_Year"] != DBNull.Value ? Convert.ToString(dr["RAC_Year"]) : RACYear = null;
		RACTotalAmount = dr["RAC_TotalAmount"] != DBNull.Value ? Convert.ToDouble(dr["RAC_TotalAmount"]) : RACTotalAmount = null;
		RACPaidAmount = dr["RAC_PaidAmount"] != DBNull.Value ? Convert.ToDouble(dr["RAC_PaidAmount"]) : RACPaidAmount = null;
		RACAnyDues = dr["RAC_AnyDues"] != DBNull.Value ? Convert.ToDouble(dr["RAC_AnyDues"]) : RACAnyDues = null;
		RACAddedById = dr["RAC_AddedById"] != DBNull.Value ? Convert.ToInt64(dr["RAC_AddedById"]) : RACAddedById = null;
		RACPaidStatus = dr["RAC_PaidStatus"] != DBNull.Value ? Convert.ToString(dr["RAC_PaidStatus"]) : RACPaidStatus = null;
		RACTransactionDate = dr["RAC_TransactionDate"] != DBNull.Value ? Convert.ToDateTime(dr["RAC_TransactionDate"]) : RACTransactionDate = null;
		RACDate = dr["RAC_Date"] != DBNull.Value ? Convert.ToDateTime(dr["RAC_Date"]) : RACDate = null;
		RacStatus = dr["Rac_Status"] != DBNull.Value ? Convert.ToInt32(dr["Rac_Status"]) : RacStatus = null;
	}
	
	public static TMSRentAccountDetails[] MapFrom(DataSet ds)
	{
		List<TMSRentAccountDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSRentAccountDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_RentAccountDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_RentAccountDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSRentAccountDetails instance = new TMSRentAccountDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSRentAccountDetails Get(System.Int64 racRentId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSRentAccountDetails instance;
		
		
		instance = new TMSRentAccountDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSRentAccountDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, racRentId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSRentAccountDetails ID:" + racRentId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String racMonth, System.String racYear, System.Double? racTotalAmount, System.Double? racPaidAmount, System.Double? racAnyDues, System.Int64? racAddedById, System.String racPaidStatus, System.DateTime? racTransactionDate, System.DateTime? racDate, System.Int32? racStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSRentAccountDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, racMonth, racYear, racTotalAmount, racPaidAmount, racAnyDues, racAddedById, racPaidStatus, racTransactionDate, racDate, racStatus);
		
		if (transaction == null)
		this.RACRentId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.RACRentId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String racMonth, System.String racYear, System.Double? racTotalAmount, System.Double? racPaidAmount, System.Double? racAnyDues, System.Int64? racAddedById, System.String racPaidStatus, System.DateTime? racTransactionDate, System.DateTime? racDate, System.Int32? racStatus)
	{
		Insert(racMonth, racYear, racTotalAmount, racPaidAmount, racAnyDues, racAddedById, racPaidStatus, racTransactionDate, racDate, racStatus, null);
	}
	/// <summary>
	/// Insert current TMSRentAccountDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(RACMonth, RACYear, RACTotalAmount, RACPaidAmount, RACAnyDues, RACAddedById, RACPaidStatus, RACTransactionDate, RACDate, RacStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSRentAccountDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? racRentId, System.String racMonth, System.String racYear, System.Double? racTotalAmount, System.Double? racPaidAmount, System.Double? racAnyDues, System.Int64? racAddedById, System.String racPaidStatus, System.DateTime? racTransactionDate, System.DateTime? racDate, System.Int32? racStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSRentAccountDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@racRentId"].Value = racRentId;
		dbCommand.Parameters["@racMonth"].Value = racMonth;
		dbCommand.Parameters["@racYear"].Value = racYear;
		dbCommand.Parameters["@racTotalAmount"].Value = racTotalAmount;
		dbCommand.Parameters["@racPaidAmount"].Value = racPaidAmount;
		dbCommand.Parameters["@racAnyDues"].Value = racAnyDues;
		dbCommand.Parameters["@racAddedById"].Value = racAddedById;
		dbCommand.Parameters["@racPaidStatus"].Value = racPaidStatus;
		dbCommand.Parameters["@racTransactionDate"].Value = racTransactionDate;
		dbCommand.Parameters["@racDate"].Value = racDate;
		dbCommand.Parameters["@racStatus"].Value = racStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? racRentId, System.String racMonth, System.String racYear, System.Double? racTotalAmount, System.Double? racPaidAmount, System.Double? racAnyDues, System.Int64? racAddedById, System.String racPaidStatus, System.DateTime? racTransactionDate, System.DateTime? racDate, System.Int32? racStatus)
	{
		Update(racRentId, racMonth, racYear, racTotalAmount, racPaidAmount, racAnyDues, racAddedById, racPaidStatus, racTransactionDate, racDate, racStatus, null);
	}
	
	public static void Update(TMSRentAccountDetails tMSRentAccountDetails)
	{
		tMSRentAccountDetails.Update();
	}
	
	public static void Update(TMSRentAccountDetails tMSRentAccountDetails, DbTransaction transaction)
	{
		tMSRentAccountDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSRentAccountDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@racRentId"].SourceColumn = "RAC_RentId";
		dbCommand.Parameters["@racMonth"].SourceColumn = "RAC_Month";
		dbCommand.Parameters["@racYear"].SourceColumn = "RAC_Year";
		dbCommand.Parameters["@racTotalAmount"].SourceColumn = "RAC_TotalAmount";
		dbCommand.Parameters["@racPaidAmount"].SourceColumn = "RAC_PaidAmount";
		dbCommand.Parameters["@racAnyDues"].SourceColumn = "RAC_AnyDues";
		dbCommand.Parameters["@racAddedById"].SourceColumn = "RAC_AddedById";
		dbCommand.Parameters["@racPaidStatus"].SourceColumn = "RAC_PaidStatus";
		dbCommand.Parameters["@racTransactionDate"].SourceColumn = "RAC_TransactionDate";
		dbCommand.Parameters["@racDate"].SourceColumn = "RAC_Date";
		dbCommand.Parameters["@racStatus"].SourceColumn = "Rac_Status";
		
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
	public static void Delete(System.Int64? racRentId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSRentAccountDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, racRentId);
		
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
	public static void Delete(System.Int64? racRentId)
	{
		Delete(
		racRentId);
	}
	
	/// <summary>
	/// Delete current TMSRentAccountDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSRentAccountDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, RACRentId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.RACRentId = null;
	}
	
	/// <summary>
	/// Delete current TMSRentAccountDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSRentAccountDetails[] Search(System.Int64? racRentId, System.String racMonth, System.String racYear, System.Double? racTotalAmount, System.Double? racPaidAmount, System.Double? racAnyDues, System.Int64? racAddedById, System.String racPaidStatus, System.DateTime? racTransactionDate, System.DateTime? racDate, System.Int32? racStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSRentAccountDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, racRentId, racMonth, racYear, racTotalAmount, racPaidAmount, racAnyDues, racAddedById, racPaidStatus, racTransactionDate, racDate, racStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSRentAccountDetails.MapFrom(ds);
	}
	
	
	public static TMSRentAccountDetails[] Search(TMSRentAccountDetails searchObject)
	{
		return Search ( searchObject.RACRentId, searchObject.RACMonth, searchObject.RACYear, searchObject.RACTotalAmount, searchObject.RACPaidAmount, searchObject.RACAnyDues, searchObject.RACAddedById, searchObject.RACPaidStatus, searchObject.RACTransactionDate, searchObject.RACDate, searchObject.RacStatus);
	}
	
	/// <summary>
	/// Returns all TMSRentAccountDetails objects.
	/// </summary>
	/// <returns>List of all TMSRentAccountDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSRentAccountDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

