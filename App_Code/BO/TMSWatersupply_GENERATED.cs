/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 11/17/2012 11:44:35 AM                                    */
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
public partial class TMSWatersupply
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_Watersupply]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _wsWsid;
	private System.Double? _wsBillAmount;
	private System.Double? _wsLateFees;
	private System.String _wsMonth;
	private System.String _wsYear;
	private System.DateTime? _wsLastDate;
	private System.DateTime? _wsBillPaidDate;
	private System.Double? _wsTotalAmount;
	private System.String _wsPaidStatus;
	private System.String _wsBillNumber;
	private System.String _wsExtra1;
	private System.DateTime? _wsDate;
	private System.Int32? _wsStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? WsWsid
	{
		get
		{
			return _wsWsid;
		}
		set
		{
			_wsWsid = value;
		}
	}
	
	public System.Double? WSBillAmount
	{
		get
		{
			return _wsBillAmount;
		}
		set
		{
			_wsBillAmount = value;
		}
	}
	
	public System.Double? WSLateFees
	{
		get
		{
			return _wsLateFees;
		}
		set
		{
			_wsLateFees = value;
		}
	}
	
	public System.String WSMonth
	{
		get
		{
			return _wsMonth;
		}
		set
		{
			_wsMonth = value;
		}
	}
	
	public System.String WSYear
	{
		get
		{
			return _wsYear;
		}
		set
		{
			_wsYear = value;
		}
	}
	
	public System.DateTime? WSLastDate
	{
		get
		{
			return _wsLastDate;
		}
		set
		{
			_wsLastDate = value;
		}
	}
	
	public System.DateTime? WSBillPaidDate
	{
		get
		{
			return _wsBillPaidDate;
		}
		set
		{
			_wsBillPaidDate = value;
		}
	}
	
	public System.Double? WSTotalAmount
	{
		get
		{
			return _wsTotalAmount;
		}
		set
		{
			_wsTotalAmount = value;
		}
	}
	
	public System.String WSPaidStatus
	{
		get
		{
			return _wsPaidStatus;
		}
		set
		{
			_wsPaidStatus = value;
		}
	}
	
	public System.String WSBillNumber
	{
		get
		{
			return _wsBillNumber;
		}
		set
		{
			_wsBillNumber = value;
		}
	}
	
	public System.String WSExtra1
	{
		get
		{
			return _wsExtra1;
		}
		set
		{
			_wsExtra1 = value;
		}
	}
	
	public System.DateTime? WSDate
	{
		get
		{
			return _wsDate;
		}
		set
		{
			_wsDate = value;
		}
	}
	
	public System.Int32? WSStatus
	{
		get
		{
			return _wsStatus;
		}
		set
		{
			_wsStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("WS_WSID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("WS_BillAmount", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("WS_LateFees", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("WS_Month", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("WS_Year", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("WS_LastDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("WS_BillPaidDate", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("WS_TotalAmount", typeof(System.Double) );
		ds.Tables[TABLE_NAME].Columns.Add("WS_PaidStatus", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("WS_BillNumber", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("WS_Extra1", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("WS_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("WS_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (WsWsid == null)
		dr["WS_WSID"] = DBNull.Value;
		else
		dr["WS_WSID"] = WsWsid;
		
		if (WSBillAmount == null)
		dr["WS_BillAmount"] = DBNull.Value;
		else
		dr["WS_BillAmount"] = WSBillAmount;
		
		if (WSLateFees == null)
		dr["WS_LateFees"] = DBNull.Value;
		else
		dr["WS_LateFees"] = WSLateFees;
		
		if (WSMonth == null)
		dr["WS_Month"] = DBNull.Value;
		else
		dr["WS_Month"] = WSMonth;
		
		if (WSYear == null)
		dr["WS_Year"] = DBNull.Value;
		else
		dr["WS_Year"] = WSYear;
		
		if (WSLastDate == null)
		dr["WS_LastDate"] = DBNull.Value;
		else
		dr["WS_LastDate"] = WSLastDate;
		
		if (WSBillPaidDate == null)
		dr["WS_BillPaidDate"] = DBNull.Value;
		else
		dr["WS_BillPaidDate"] = WSBillPaidDate;
		
		if (WSTotalAmount == null)
		dr["WS_TotalAmount"] = DBNull.Value;
		else
		dr["WS_TotalAmount"] = WSTotalAmount;
		
		if (WSPaidStatus == null)
		dr["WS_PaidStatus"] = DBNull.Value;
		else
		dr["WS_PaidStatus"] = WSPaidStatus;
		
		if (WSBillNumber == null)
		dr["WS_BillNumber"] = DBNull.Value;
		else
		dr["WS_BillNumber"] = WSBillNumber;
		
		if (WSExtra1 == null)
		dr["WS_Extra1"] = DBNull.Value;
		else
		dr["WS_Extra1"] = WSExtra1;
		
		if (WSDate == null)
		dr["WS_Date"] = DBNull.Value;
		else
		dr["WS_Date"] = WSDate;
		
		if (WSStatus == null)
		dr["WS_Status"] = DBNull.Value;
		else
		dr["WS_Status"] = WSStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		WsWsid = dr["WS_WSID"] != DBNull.Value ? Convert.ToInt64(dr["WS_WSID"]) : WsWsid = null;
		WSBillAmount = dr["WS_BillAmount"] != DBNull.Value ? Convert.ToDouble(dr["WS_BillAmount"]) : WSBillAmount = null;
		WSLateFees = dr["WS_LateFees"] != DBNull.Value ? Convert.ToDouble(dr["WS_LateFees"]) : WSLateFees = null;
		WSMonth = dr["WS_Month"] != DBNull.Value ? Convert.ToString(dr["WS_Month"]) : WSMonth = null;
		WSYear = dr["WS_Year"] != DBNull.Value ? Convert.ToString(dr["WS_Year"]) : WSYear = null;
		WSLastDate = dr["WS_LastDate"] != DBNull.Value ? Convert.ToDateTime(dr["WS_LastDate"]) : WSLastDate = null;
		WSBillPaidDate = dr["WS_BillPaidDate"] != DBNull.Value ? Convert.ToDateTime(dr["WS_BillPaidDate"]) : WSBillPaidDate = null;
		WSTotalAmount = dr["WS_TotalAmount"] != DBNull.Value ? Convert.ToDouble(dr["WS_TotalAmount"]) : WSTotalAmount = null;
		WSPaidStatus = dr["WS_PaidStatus"] != DBNull.Value ? Convert.ToString(dr["WS_PaidStatus"]) : WSPaidStatus = null;
		WSBillNumber = dr["WS_BillNumber"] != DBNull.Value ? Convert.ToString(dr["WS_BillNumber"]) : WSBillNumber = null;
		WSExtra1 = dr["WS_Extra1"] != DBNull.Value ? Convert.ToString(dr["WS_Extra1"]) : WSExtra1 = null;
		WSDate = dr["WS_Date"] != DBNull.Value ? Convert.ToDateTime(dr["WS_Date"]) : WSDate = null;
		WSStatus = dr["WS_Status"] != DBNull.Value ? Convert.ToInt32(dr["WS_Status"]) : WSStatus = null;
	}
	
	public static TMSWatersupply[] MapFrom(DataSet ds)
	{
		List<TMSWatersupply> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSWatersupply>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_Watersupply] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_Watersupply] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSWatersupply instance = new TMSWatersupply();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSWatersupply Get(System.Int64 wsWsid)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSWatersupply instance;
		
		
		instance = new TMSWatersupply();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSWatersupply_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, wsWsid);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSWatersupply ID:" + wsWsid.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Double? wsBillAmount, System.Double? wsLateFees, System.String wsMonth, System.String wsYear, System.DateTime? wsLastDate, System.DateTime? wsBillPaidDate, System.Double? wsTotalAmount, System.String wsPaidStatus, System.String wsBillNumber, System.String wsExtra1, System.DateTime? wsDate, System.Int32? wsStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSWatersupply_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, wsBillAmount, wsLateFees, wsMonth, wsYear, wsLastDate, wsBillPaidDate, wsTotalAmount, wsPaidStatus, wsBillNumber, wsExtra1, wsDate, wsStatus);
		
		if (transaction == null)
		this.WsWsid = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.WsWsid = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Double? wsBillAmount, System.Double? wsLateFees, System.String wsMonth, System.String wsYear, System.DateTime? wsLastDate, System.DateTime? wsBillPaidDate, System.Double? wsTotalAmount, System.String wsPaidStatus, System.String wsBillNumber, System.String wsExtra1, System.DateTime? wsDate, System.Int32? wsStatus)
	{
		Insert(wsBillAmount, wsLateFees, wsMonth, wsYear, wsLastDate, wsBillPaidDate, wsTotalAmount, wsPaidStatus, wsBillNumber, wsExtra1, wsDate, wsStatus, null);
	}
	/// <summary>
	/// Insert current TMSWatersupply to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(WSBillAmount, WSLateFees, WSMonth, WSYear, WSLastDate, WSBillPaidDate, WSTotalAmount, WSPaidStatus, WSBillNumber, WSExtra1, WSDate, WSStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSWatersupply to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? wsWsid, System.Double? wsBillAmount, System.Double? wsLateFees, System.String wsMonth, System.String wsYear, System.DateTime? wsLastDate, System.DateTime? wsBillPaidDate, System.Double? wsTotalAmount, System.String wsPaidStatus, System.String wsBillNumber, System.String wsExtra1, System.DateTime? wsDate, System.Int32? wsStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSWatersupply_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@wsWsid"].Value = wsWsid;
		dbCommand.Parameters["@wsBillAmount"].Value = wsBillAmount;
		dbCommand.Parameters["@wsLateFees"].Value = wsLateFees;
		dbCommand.Parameters["@wsMonth"].Value = wsMonth;
		dbCommand.Parameters["@wsYear"].Value = wsYear;
		dbCommand.Parameters["@wsLastDate"].Value = wsLastDate;
		dbCommand.Parameters["@wsBillPaidDate"].Value = wsBillPaidDate;
		dbCommand.Parameters["@wsTotalAmount"].Value = wsTotalAmount;
		dbCommand.Parameters["@wsPaidStatus"].Value = wsPaidStatus;
		dbCommand.Parameters["@wsBillNumber"].Value = wsBillNumber;
		dbCommand.Parameters["@wsExtra1"].Value = wsExtra1;
		dbCommand.Parameters["@wsDate"].Value = wsDate;
		dbCommand.Parameters["@wsStatus"].Value = wsStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? wsWsid, System.Double? wsBillAmount, System.Double? wsLateFees, System.String wsMonth, System.String wsYear, System.DateTime? wsLastDate, System.DateTime? wsBillPaidDate, System.Double? wsTotalAmount, System.String wsPaidStatus, System.String wsBillNumber, System.String wsExtra1, System.DateTime? wsDate, System.Int32? wsStatus)
	{
		Update(wsWsid, wsBillAmount, wsLateFees, wsMonth, wsYear, wsLastDate, wsBillPaidDate, wsTotalAmount, wsPaidStatus, wsBillNumber, wsExtra1, wsDate, wsStatus, null);
	}
	
	public static void Update(TMSWatersupply tMSWatersupply)
	{
		tMSWatersupply.Update();
	}
	
	public static void Update(TMSWatersupply tMSWatersupply, DbTransaction transaction)
	{
		tMSWatersupply.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSWatersupply_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@wsWsid"].SourceColumn = "WS_WSID";
		dbCommand.Parameters["@wsBillAmount"].SourceColumn = "WS_BillAmount";
		dbCommand.Parameters["@wsLateFees"].SourceColumn = "WS_LateFees";
		dbCommand.Parameters["@wsMonth"].SourceColumn = "WS_Month";
		dbCommand.Parameters["@wsYear"].SourceColumn = "WS_Year";
		dbCommand.Parameters["@wsLastDate"].SourceColumn = "WS_LastDate";
		dbCommand.Parameters["@wsBillPaidDate"].SourceColumn = "WS_BillPaidDate";
		dbCommand.Parameters["@wsTotalAmount"].SourceColumn = "WS_TotalAmount";
		dbCommand.Parameters["@wsPaidStatus"].SourceColumn = "WS_PaidStatus";
		dbCommand.Parameters["@wsBillNumber"].SourceColumn = "WS_BillNumber";
		dbCommand.Parameters["@wsExtra1"].SourceColumn = "WS_Extra1";
		dbCommand.Parameters["@wsDate"].SourceColumn = "WS_Date";
		dbCommand.Parameters["@wsStatus"].SourceColumn = "WS_Status";
		
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
	public static void Delete(System.Int64? wsWsid, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSWatersupply_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, wsWsid);
		
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
	public static void Delete(System.Int64? wsWsid)
	{
		Delete(
		wsWsid);
	}
	
	/// <summary>
	/// Delete current TMSWatersupply from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSWatersupply_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, WsWsid);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.WsWsid = null;
	}
	
	/// <summary>
	/// Delete current TMSWatersupply from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSWatersupply[] Search(System.Int64? wsWsid, System.Double? wsBillAmount, System.Double? wsLateFees, System.String wsMonth, System.String wsYear, System.DateTime? wsLastDate, System.DateTime? wsBillPaidDate, System.Double? wsTotalAmount, System.String wsPaidStatus, System.String wsBillNumber, System.String wsExtra1, System.DateTime? wsDate, System.Int32? wsStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSWatersupply_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, wsWsid, wsBillAmount, wsLateFees, wsMonth, wsYear, wsLastDate, wsBillPaidDate, wsTotalAmount, wsPaidStatus, wsBillNumber, wsExtra1, wsDate, wsStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSWatersupply.MapFrom(ds);
	}
	
	
	public static TMSWatersupply[] Search(TMSWatersupply searchObject)
	{
		return Search ( searchObject.WsWsid, searchObject.WSBillAmount, searchObject.WSLateFees, searchObject.WSMonth, searchObject.WSYear, searchObject.WSLastDate, searchObject.WSBillPaidDate, searchObject.WSTotalAmount, searchObject.WSPaidStatus, searchObject.WSBillNumber, searchObject.WSExtra1, searchObject.WSDate, searchObject.WSStatus);
	}
	
	/// <summary>
	/// Returns all TMSWatersupply objects.
	/// </summary>
	/// <returns>List of all TMSWatersupply objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSWatersupply[] Search()
	{
		return Search ( null, null, null, null, null, null, null, null, null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

