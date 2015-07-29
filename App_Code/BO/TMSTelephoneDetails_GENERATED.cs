/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 9/14/2012 11:34:01 AM                                    */
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
public partial class TMSTelephoneDetails
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_TelephoneDetails]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _tdTelephoneId;
	private System.String _tdTelephoneDepartment;
	private System.String _tdTelephoneNumber;
	private System.DateTime? _tdDate;
	private System.Int32? _tdStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? TDTelephoneId
	{
		get
		{
			return _tdTelephoneId;
		}
		set
		{
			_tdTelephoneId = value;
		}
	}
	
	public System.String TDTelephoneDepartment
	{
		get
		{
			return _tdTelephoneDepartment;
		}
		set
		{
			_tdTelephoneDepartment = value;
		}
	}
	
	public System.String TDTelephoneNumber
	{
		get
		{
			return _tdTelephoneNumber;
		}
		set
		{
			_tdTelephoneNumber = value;
		}
	}
	
	public System.DateTime? TDDate
	{
		get
		{
			return _tdDate;
		}
		set
		{
			_tdDate = value;
		}
	}
	
	public System.Int32? TDStatus
	{
		get
		{
			return _tdStatus;
		}
		set
		{
			_tdStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("TD_TelephoneId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("TD_TelephoneDepartment", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TD_TelephoneNumber", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TD_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("TD_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (TDTelephoneId == null)
		dr["TD_TelephoneId"] = DBNull.Value;
		else
		dr["TD_TelephoneId"] = TDTelephoneId;
		
		if (TDTelephoneDepartment == null)
		dr["TD_TelephoneDepartment"] = DBNull.Value;
		else
		dr["TD_TelephoneDepartment"] = TDTelephoneDepartment;
		
		if (TDTelephoneNumber == null)
		dr["TD_TelephoneNumber"] = DBNull.Value;
		else
		dr["TD_TelephoneNumber"] = TDTelephoneNumber;
		
		if (TDDate == null)
		dr["TD_Date"] = DBNull.Value;
		else
		dr["TD_Date"] = TDDate;
		
		if (TDStatus == null)
		dr["TD_Status"] = DBNull.Value;
		else
		dr["TD_Status"] = TDStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		TDTelephoneId = dr["TD_TelephoneId"] != DBNull.Value ? Convert.ToInt64(dr["TD_TelephoneId"]) : TDTelephoneId = null;
		TDTelephoneDepartment = dr["TD_TelephoneDepartment"] != DBNull.Value ? Convert.ToString(dr["TD_TelephoneDepartment"]) : TDTelephoneDepartment = null;
		TDTelephoneNumber = dr["TD_TelephoneNumber"] != DBNull.Value ? Convert.ToString(dr["TD_TelephoneNumber"]) : TDTelephoneNumber = null;
		TDDate = dr["TD_Date"] != DBNull.Value ? Convert.ToDateTime(dr["TD_Date"]) : TDDate = null;
		TDStatus = dr["TD_Status"] != DBNull.Value ? Convert.ToInt32(dr["TD_Status"]) : TDStatus = null;
	}
	
	public static TMSTelephoneDetails[] MapFrom(DataSet ds)
	{
		List<TMSTelephoneDetails> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSTelephoneDetails>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_TelephoneDetails] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_TelephoneDetails] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSTelephoneDetails instance = new TMSTelephoneDetails();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSTelephoneDetails Get(System.Int64 tdTelephoneId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSTelephoneDetails instance;
		
		
		instance = new TMSTelephoneDetails();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTelephoneDetails_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tdTelephoneId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSTelephoneDetails ID:" + tdTelephoneId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String tdTelephoneDepartment, System.String tdTelephoneNumber, System.DateTime? tdDate, System.Int32? tdStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTelephoneDetails_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tdTelephoneDepartment, tdTelephoneNumber, tdDate, tdStatus);
		
		if (transaction == null)
		this.TDTelephoneId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.TDTelephoneId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String tdTelephoneDepartment, System.String tdTelephoneNumber, System.DateTime? tdDate, System.Int32? tdStatus)
	{
		Insert(tdTelephoneDepartment, tdTelephoneNumber, tdDate, tdStatus, null);
	}
	/// <summary>
	/// Insert current TMSTelephoneDetails to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(TDTelephoneDepartment, TDTelephoneNumber, TDDate, TDStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSTelephoneDetails to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? tdTelephoneId, System.String tdTelephoneDepartment, System.String tdTelephoneNumber, System.DateTime? tdDate, System.Int32? tdStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTelephoneDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@tdTelephoneId"].Value = tdTelephoneId;
		dbCommand.Parameters["@tdTelephoneDepartment"].Value = tdTelephoneDepartment;
		dbCommand.Parameters["@tdTelephoneNumber"].Value = tdTelephoneNumber;
		dbCommand.Parameters["@tdDate"].Value = tdDate;
		dbCommand.Parameters["@tdStatus"].Value = tdStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? tdTelephoneId, System.String tdTelephoneDepartment, System.String tdTelephoneNumber, System.DateTime? tdDate, System.Int32? tdStatus)
	{
		Update(tdTelephoneId, tdTelephoneDepartment, tdTelephoneNumber, tdDate, tdStatus, null);
	}
	
	public static void Update(TMSTelephoneDetails tMSTelephoneDetails)
	{
		tMSTelephoneDetails.Update();
	}
	
	public static void Update(TMSTelephoneDetails tMSTelephoneDetails, DbTransaction transaction)
	{
		tMSTelephoneDetails.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSTelephoneDetails_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@tdTelephoneId"].SourceColumn = "TD_TelephoneId";
		dbCommand.Parameters["@tdTelephoneDepartment"].SourceColumn = "TD_TelephoneDepartment";
		dbCommand.Parameters["@tdTelephoneNumber"].SourceColumn = "TD_TelephoneNumber";
		dbCommand.Parameters["@tdDate"].SourceColumn = "TD_Date";
		dbCommand.Parameters["@tdStatus"].SourceColumn = "TD_Status";
		
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
	public static void Delete(System.Int64? tdTelephoneId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTelephoneDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tdTelephoneId);
		
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
	public static void Delete(System.Int64? tdTelephoneId)
	{
		Delete(
		tdTelephoneId);
	}
	
	/// <summary>
	/// Delete current TMSTelephoneDetails from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTelephoneDetails_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, TDTelephoneId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.TDTelephoneId = null;
	}
	
	/// <summary>
	/// Delete current TMSTelephoneDetails from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSTelephoneDetails[] Search(System.Int64? tdTelephoneId, System.String tdTelephoneDepartment, System.String tdTelephoneNumber, System.DateTime? tdDate, System.Int32? tdStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTelephoneDetails_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, tdTelephoneId, tdTelephoneDepartment, tdTelephoneNumber, tdDate, tdStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSTelephoneDetails.MapFrom(ds);
	}
	
	
	public static TMSTelephoneDetails[] Search(TMSTelephoneDetails searchObject)
	{
		return Search ( searchObject.TDTelephoneId, searchObject.TDTelephoneDepartment, searchObject.TDTelephoneNumber, searchObject.TDDate, searchObject.TDStatus);
	}
	
	/// <summary>
	/// Returns all TMSTelephoneDetails objects.
	/// </summary>
	/// <returns>List of all TMSTelephoneDetails objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSTelephoneDetails[] Search()
	{
		return Search ( null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

