/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 9/18/2012 12:47:53 PM                                    */
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
public partial class TMSTelephoneBillDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_TelephoneBillDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _tbdBillId;
	private System.Int64? _tbdTelephoneId;
	private System.String _tbdMonth;
	private System.String _tbdYear;
	private System.Double? _tbdBillAmount;
	private System.DateTime? _tbdDate;
	private System.Int64? _tbdAddedById;
	private System.String _tbdAddedByRemark;
	private System.String _tbdPaidStatus;
	private System.Int32? _tbdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? TBDBillId
	{
		get
		{
			return _tbdBillId;
		}
		set
		{
			_tbdBillId = value;
		}
	}
	
	public System.Int64? TBDTelephoneId
	{
		get
		{
			return _tbdTelephoneId;
		}
		set
		{
			_tbdTelephoneId = value;
		}
	}
	
	public System.String TBDMonth
	{
		get
		{
			return _tbdMonth;
		}
		set
		{
			_tbdMonth = value;
		}
	}
	
	public System.String TBDYear
	{
		get
		{
			return _tbdYear;
		}
		set
		{
			_tbdYear = value;
		}
	}
	
	public System.Double? TBDBillAmount
	{
		get
		{
			return _tbdBillAmount;
		}
		set
		{
			_tbdBillAmount = value;
		}
	}
	
	public System.DateTime? TBDDate
	{
		get
		{
			return _tbdDate;
		}
		set
		{
			_tbdDate = value;
		}
	}
	
	public System.Int64? TBDAddedById
	{
		get
		{
			return _tbdAddedById;
		}
		set
		{
			_tbdAddedById = value;
		}
	}
	
	public System.String TBDAddedByRemark
	{
		get
		{
			return _tbdAddedByRemark;
		}
		set
		{
			_tbdAddedByRemark = value;
		}
	}
	
	public System.String TBDPaidStatus
	{
		get
		{
			return _tbdPaidStatus;
		}
		set
		{
			_tbdPaidStatus = value;
		}
	}
	
	public System.Int32? TBDStatus
	{
		get
		{
			return _tbdStatus;
		}
		set
		{
			_tbdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("TBD_BillId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("TBD_TelephoneId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("TBD_Month", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TBD_Year", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TBD_BillAmount", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("TBD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("TBD_AddedById", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("TBD_AddedByRemark", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TBD_PaidStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TBD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (TBDBillId == null)
		dr["TBD_BillId"] = DBNull.Value;
		else
		dr["TBD_BillId"] = TBDBillId;
		
		if (TBDTelephoneId == null)
		dr["TBD_TelephoneId"] = DBNull.Value;
		else
		dr["TBD_TelephoneId"] = TBDTelephoneId;
		
		if (TBDMonth == null)
		dr["TBD_Month"] = DBNull.Value;
		else
		dr["TBD_Month"] = TBDMonth;
		
		if (TBDYear == null)
		dr["TBD_Year"] = DBNull.Value;
		else
		dr["TBD_Year"] = TBDYear;
		
		if (TBDBillAmount == null)
		dr["TBD_BillAmount"] = DBNull.Value;
		else
		dr["TBD_BillAmount"] = TBDBillAmount;
		
		if (TBDDate == null)
		dr["TBD_Date"] = DBNull.Value;
		else
		dr["TBD_Date"] = TBDDate;
		
		if (TBDAddedById == null)
		dr["TBD_AddedById"] = DBNull.Value;
		else
		dr["TBD_AddedById"] = TBDAddedById;
		
		if (TBDAddedByRemark == null)
		dr["TBD_AddedByRemark"] = DBNull.Value;
		else
		dr["TBD_AddedByRemark"] = TBDAddedByRemark;
		
		if (TBDPaidStatus == null)
		dr["TBD_PaidStatus"] = DBNull.Value;
		else
		dr["TBD_PaidStatus"] = TBDPaidStatus;
		
		if (TBDStatus == null)
		dr["TBD_Status"] = DBNull.Value;
		else
		dr["TBD_Status"] = TBDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		TBDBillId = dr["TBD_BillId"] != DBNull.Value ? Convert.ToInt64(dr["TBD_BillId"]) : TBDBillId = null;
		TBDTelephoneId = dr["TBD_TelephoneId"] != DBNull.Value ? Convert.ToInt64(dr["TBD_TelephoneId"]) : TBDTelephoneId = null;
		TBDMonth = dr["TBD_Month"] != DBNull.Value ? Convert.ToString(dr["TBD_Month"]) : TBDMonth = null;
		TBDYear = dr["TBD_Year"] != DBNull.Value ? Convert.ToString(dr["TBD_Year"]) : TBDYear = null;
		TBDBillAmount = dr["TBD_BillAmount"] != DBNull.Value ? Convert.ToDouble(dr["TBD_BillAmount"]) : TBDBillAmount = null;
		TBDDate = dr["TBD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["TBD_Date"]) : TBDDate = null;
		TBDAddedById = dr["TBD_AddedById"] != DBNull.Value ? Convert.ToInt64(dr["TBD_AddedById"]) : TBDAddedById = null;
		TBDAddedByRemark = dr["TBD_AddedByRemark"] != DBNull.Value ? Convert.ToString(dr["TBD_AddedByRemark"]) : TBDAddedByRemark = null;
		TBDPaidStatus = dr["TBD_PaidStatus"] != DBNull.Value ? Convert.ToString(dr["TBD_PaidStatus"]) : TBDPaidStatus = null;
		TBDStatus = dr["TBD_Status"] != DBNull.Value ? Convert.ToInt32(dr["TBD_Status"]) : TBDStatus = null;
	}
	
	public static TMSTelephoneBillDetails[] MapFrom(DataSet ds)
	{
		List<TMSTelephoneBillDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSTelephoneBillDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_TelephoneBillDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_TelephoneBillDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSTelephoneBillDetails instance = new TMSTelephoneBillDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSTelephoneBillDetails Get(System.Int64 tbdBillId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSTelephoneBillDetails instance;
		
		
		instance = new TMSTelephoneBillDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTelephoneBillDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tbdBillId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSTelephoneBillDetails ID:" + tbdBillId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? tbdTelephoneId, System.String tbdMonth, System.String tbdYear, System.Double? tbdBillAmount, System.DateTime? tbdDate, System.Int64? tbdAddedById, System.String tbdAddedByRemark, System.String tbdPaidStatus, System.Int32? tbdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTelephoneBillDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tbdTelephoneId, tbdMonth, tbdYear, tbdBillAmount, tbdDate, tbdAddedById, tbdAddedByRemark, tbdPaidStatus, tbdStatus);
		
		if (transaction == null)
		this.TBDBillId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.TBDBillId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? tbdTelephoneId, System.String tbdMonth, System.String tbdYear, System.Double? tbdBillAmount, System.DateTime? tbdDate, System.Int64? tbdAddedById, System.String tbdAddedByRemark, System.String tbdPaidStatus, System.Int32? tbdStatus)
	{
		Insert(tbdTelephoneId, tbdMonth, tbdYear, tbdBillAmount, tbdDate, tbdAddedById, tbdAddedByRemark, tbdPaidStatus, tbdStatus, null);
	}
	/// <summary>
	/// Insert current TMSTelephoneBillDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(TBDTelephoneId, TBDMonth, TBDYear, TBDBillAmount, TBDDate, TBDAddedById, TBDAddedByRemark, TBDPaidStatus, TBDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSTelephoneBillDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? tbdBillId, System.Int64? tbdTelephoneId, System.String tbdMonth, System.String tbdYear, System.Double? tbdBillAmount, System.DateTime? tbdDate, System.Int64? tbdAddedById, System.String tbdAddedByRemark, System.String tbdPaidStatus, System.Int32? tbdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTelephoneBillDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@tbdBillId"].Value = tbdBillId;
		dbCommand.Parameters["@tbdTelephoneId"].Value = tbdTelephoneId;
		dbCommand.Parameters["@tbdMonth"].Value = tbdMonth;
		dbCommand.Parameters["@tbdYear"].Value = tbdYear;
		dbCommand.Parameters["@tbdBillAmount"].Value = tbdBillAmount;
		dbCommand.Parameters["@tbdDate"].Value = tbdDate;
		dbCommand.Parameters["@tbdAddedById"].Value = tbdAddedById;
		dbCommand.Parameters["@tbdAddedByRemark"].Value = tbdAddedByRemark;
		dbCommand.Parameters["@tbdPaidStatus"].Value = tbdPaidStatus;
		dbCommand.Parameters["@tbdStatus"].Value = tbdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? tbdBillId, System.Int64? tbdTelephoneId, System.String tbdMonth, System.String tbdYear, System.Double? tbdBillAmount, System.DateTime? tbdDate, System.Int64? tbdAddedById, System.String tbdAddedByRemark, System.String tbdPaidStatus, System.Int32? tbdStatus)
	{
		Update(tbdBillId, tbdTelephoneId, tbdMonth, tbdYear, tbdBillAmount, tbdDate, tbdAddedById, tbdAddedByRemark, tbdPaidStatus, tbdStatus, null);
	}
	
	public static void Update(TMSTelephoneBillDetails tMSTelephoneBillDetails)
	{
		tMSTelephoneBillDetails.Update();
	}
	
	public static void Update(TMSTelephoneBillDetails tMSTelephoneBillDetails, DbTransaction transaction)
	{
		tMSTelephoneBillDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSTelephoneBillDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@tbdBillId"].SourceColumn = "TBD_BillId";
		dbCommand.Parameters["@tbdTelephoneId"].SourceColumn = "TBD_TelephoneId";
		dbCommand.Parameters["@tbdMonth"].SourceColumn = "TBD_Month";
		dbCommand.Parameters["@tbdYear"].SourceColumn = "TBD_Year";
		dbCommand.Parameters["@tbdBillAmount"].SourceColumn = "TBD_BillAmount";
		dbCommand.Parameters["@tbdDate"].SourceColumn = "TBD_Date";
		dbCommand.Parameters["@tbdAddedById"].SourceColumn = "TBD_AddedById";
		dbCommand.Parameters["@tbdAddedByRemark"].SourceColumn = "TBD_AddedByRemark";
		dbCommand.Parameters["@tbdPaidStatus"].SourceColumn = "TBD_PaidStatus";
		dbCommand.Parameters["@tbdStatus"].SourceColumn = "TBD_Status";
		
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
	public static void Delete(System.Int64? tbdBillId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTelephoneBillDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tbdBillId);
		
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
	public static void Delete(System.Int64? tbdBillId)
	{
		Delete(
		tbdBillId);
	}
	
	/// <summary>
	/// Delete current TMSTelephoneBillDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTelephoneBillDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, TBDBillId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.TBDBillId = null;
	}
	
	/// <summary>
	/// Delete current TMSTelephoneBillDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSTelephoneBillDetails[] Search(System.Int64? tbdBillId, System.Int64? tbdTelephoneId, System.String tbdMonth, System.String tbdYear, System.Double? tbdBillAmount, System.DateTime? tbdDate, System.Int64? tbdAddedById, System.String tbdAddedByRemark, System.String tbdPaidStatus, System.Int32? tbdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTelephoneBillDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tbdBillId, tbdTelephoneId, tbdMonth, tbdYear, tbdBillAmount, tbdDate, tbdAddedById, tbdAddedByRemark, tbdPaidStatus, tbdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSTelephoneBillDetails.MapFrom(ds);
	}
	
	
	public static TMSTelephoneBillDetails[] Search(TMSTelephoneBillDetails searchObject)
	{
		return Search ( searchObject.TBDBillId, searchObject.TBDTelephoneId, searchObject.TBDMonth, searchObject.TBDYear, searchObject.TBDBillAmount, searchObject.TBDDate, searchObject.TBDAddedById, searchObject.TBDAddedByRemark, searchObject.TBDPaidStatus, searchObject.TBDStatus);
	}
	
	/// <summary>
	/// Returns all TMSTelephoneBillDetails objects.
	/// </summary>
	/// <returns>List of all TMSTelephoneBillDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSTelephoneBillDetails[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

