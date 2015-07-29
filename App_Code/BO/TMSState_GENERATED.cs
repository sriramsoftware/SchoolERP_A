/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/24/2012 5:14:54 PM                                    */
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
public partial class TMSState
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_State]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _stId;
	private System.Int64? _stCountryID;
	private System.String _stState;
	private System.Int32? _stStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? STId
	{
		get
		{
			return _stId;
		}
		set
		{
			_stId = value;
		}
	}
	
	public System.Int64? STCountryID
	{
		get
		{
			return _stCountryID;
		}
		set
		{
			_stCountryID = value;
		}
	}
	
	public System.String STState
	{
		get
		{
			return _stState;
		}
		set
		{
			_stState = value;
		}
	}
	
	public System.Int32? STStatus
	{
		get
		{
			return _stStatus;
		}
		set
		{
			_stStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("ST_Id", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ST_CountryID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("ST_State", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("ST_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (STId == null)
		dr["ST_Id"] = DBNull.Value;
		else
		dr["ST_Id"] = STId;
		
		if (STCountryID == null)
		dr["ST_CountryID"] = DBNull.Value;
		else
		dr["ST_CountryID"] = STCountryID;
		
		if (STState == null)
		dr["ST_State"] = DBNull.Value;
		else
		dr["ST_State"] = STState;
		
		if (STStatus == null)
		dr["ST_Status"] = DBNull.Value;
		else
		dr["ST_Status"] = STStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		STId = dr["ST_Id"] != DBNull.Value ? Convert.ToInt64(dr["ST_Id"]) : STId = null;
		STCountryID = dr["ST_CountryID"] != DBNull.Value ? Convert.ToInt64(dr["ST_CountryID"]) : STCountryID = null;
		STState = dr["ST_State"] != DBNull.Value ? Convert.ToString(dr["ST_State"]) : STState = null;
		STStatus = dr["ST_Status"] != DBNull.Value ? Convert.ToInt32(dr["ST_Status"]) : STStatus = null;
	}
	
	public static TMSState[] MapFrom(DataSet ds)
	{
		List<TMSState> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSState>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_State] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_State] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSState instance = new TMSState();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSState Get(System.Int64 stId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSState instance;
		
		
		instance = new TMSState();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSState_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, stId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSState ID:" + stId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? stCountryID, System.String stState, System.Int32? stStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSState_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, stCountryID, stState, stStatus);
		
		if (transaction == null)
		this.STId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.STId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? stCountryID, System.String stState, System.Int32? stStatus)
	{
		Insert(stCountryID, stState, stStatus, null);
	}
	/// <summary>
	/// Insert current TMSState to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(STCountryID, STState, STStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSState to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? stId, System.Int64? stCountryID, System.String stState, System.Int32? stStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSState_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@stId"].Value = stId;
		dbCommand.Parameters["@stCountryID"].Value = stCountryID;
		dbCommand.Parameters["@stState"].Value = stState;
		dbCommand.Parameters["@stStatus"].Value = stStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? stId, System.Int64? stCountryID, System.String stState, System.Int32? stStatus)
	{
		Update(stId, stCountryID, stState, stStatus, null);
	}
	
	public static void Update(TMSState tMSState)
	{
		tMSState.Update();
	}
	
	public static void Update(TMSState tMSState, DbTransaction transaction)
	{
		tMSState.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSState_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@stId"].SourceColumn = "ST_Id";
		dbCommand.Parameters["@stCountryID"].SourceColumn = "ST_CountryID";
		dbCommand.Parameters["@stState"].SourceColumn = "ST_State";
		dbCommand.Parameters["@stStatus"].SourceColumn = "ST_Status";
		
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
	public static void Delete(System.Int64? stId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSState_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, stId);
		
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
	public static void Delete(System.Int64? stId)
	{
		Delete(
		stId);
	}
	
	/// <summary>
	/// Delete current TMSState from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSState_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, STId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.STId = null;
	}
	
	/// <summary>
	/// Delete current TMSState from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSState[] Search(System.Int64? stId, System.Int64? stCountryID, System.String stState, System.Int32? stStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSState_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, stId, stCountryID, stState, stStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSState.MapFrom(ds);
	}
	
	
	public static TMSState[] Search(TMSState searchObject)
	{
		return Search ( searchObject.STId, searchObject.STCountryID, searchObject.STState, searchObject.STStatus);
	}
	
	/// <summary>
	/// Returns all TMSState objects.
	/// </summary>
	/// <returns>List of all TMSState objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSState[] Search()
	{
		return Search ( null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

