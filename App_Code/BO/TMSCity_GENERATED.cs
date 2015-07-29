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
public partial class TMSCity
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_City]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _ctId;
	private System.Int64? _ctStateID;
	private System.String _ctCity;
	private System.Int32? _ctStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? CTId
	{
		get
		{
			return _ctId;
		}
		set
		{
			_ctId = value;
		}
	}
	
	public System.Int64? CTStateID
	{
		get
		{
			return _ctStateID;
		}
		set
		{
			_ctStateID = value;
		}
	}
	
	public System.String CTCity
	{
		get
		{
			return _ctCity;
		}
		set
		{
			_ctCity = value;
		}
	}
	
	public System.Int32? CTStatus
	{
		get
		{
			return _ctStatus;
		}
		set
		{
			_ctStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("CT_Id", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CT_StateID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("CT_City", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("CT_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (CTId == null)
		dr["CT_Id"] = DBNull.Value;
		else
		dr["CT_Id"] = CTId;
		
		if (CTStateID == null)
		dr["CT_StateID"] = DBNull.Value;
		else
		dr["CT_StateID"] = CTStateID;
		
		if (CTCity == null)
		dr["CT_City"] = DBNull.Value;
		else
		dr["CT_City"] = CTCity;
		
		if (CTStatus == null)
		dr["CT_Status"] = DBNull.Value;
		else
		dr["CT_Status"] = CTStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		CTId = dr["CT_Id"] != DBNull.Value ? Convert.ToInt64(dr["CT_Id"]) : CTId = null;
		CTStateID = dr["CT_StateID"] != DBNull.Value ? Convert.ToInt64(dr["CT_StateID"]) : CTStateID = null;
		CTCity = dr["CT_City"] != DBNull.Value ? Convert.ToString(dr["CT_City"]) : CTCity = null;
		CTStatus = dr["CT_Status"] != DBNull.Value ? Convert.ToInt32(dr["CT_Status"]) : CTStatus = null;
	}
	
	public static TMSCity[] MapFrom(DataSet ds)
	{
		List<TMSCity> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSCity>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_City] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_City] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSCity instance = new TMSCity();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSCity Get(System.Int64 ctId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSCity instance;
		
		
		instance = new TMSCity();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCity_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ctId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSCity ID:" + ctId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? ctStateID, System.String ctCity, System.Int32? ctStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCity_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ctStateID, ctCity, ctStatus);
		
		if (transaction == null)
		this.CTId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.CTId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? ctStateID, System.String ctCity, System.Int32? ctStatus)
	{
		Insert(ctStateID, ctCity, ctStatus, null);
	}
	/// <summary>
	/// Insert current TMSCity to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(CTStateID, CTCity, CTStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSCity to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? ctId, System.Int64? ctStateID, System.String ctCity, System.Int32? ctStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCity_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ctId"].Value = ctId;
		dbCommand.Parameters["@ctStateID"].Value = ctStateID;
		dbCommand.Parameters["@ctCity"].Value = ctCity;
		dbCommand.Parameters["@ctStatus"].Value = ctStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? ctId, System.Int64? ctStateID, System.String ctCity, System.Int32? ctStatus)
	{
		Update(ctId, ctStateID, ctCity, ctStatus, null);
	}
	
	public static void Update(TMSCity tMSCity)
	{
		tMSCity.Update();
	}
	
	public static void Update(TMSCity tMSCity, DbTransaction transaction)
	{
		tMSCity.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSCity_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ctId"].SourceColumn = "CT_Id";
		dbCommand.Parameters["@ctStateID"].SourceColumn = "CT_StateID";
		dbCommand.Parameters["@ctCity"].SourceColumn = "CT_City";
		dbCommand.Parameters["@ctStatus"].SourceColumn = "CT_Status";
		
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
	public static void Delete(System.Int64? ctId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCity_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ctId);
		
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
	public static void Delete(System.Int64? ctId)
	{
		Delete(
		ctId);
	}
	
	/// <summary>
	/// Delete current TMSCity from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCity_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, CTId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.CTId = null;
	}
	
	/// <summary>
	/// Delete current TMSCity from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSCity[] Search(System.Int64? ctId, System.Int64? ctStateID, System.String ctCity, System.Int32? ctStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSCity_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ctId, ctStateID, ctCity, ctStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSCity.MapFrom(ds);
	}
	
	
	public static TMSCity[] Search(TMSCity searchObject)
	{
		return Search ( searchObject.CTId, searchObject.CTStateID, searchObject.CTCity, searchObject.CTStatus);
	}
	
	/// <summary>
	/// Returns all TMSCity objects.
	/// </summary>
	/// <returns>List of all TMSCity objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSCity[] Search()
	{
		return Search ( null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

