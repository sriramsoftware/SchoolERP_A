/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/24/2012 2:53:46 PM                                    */
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
public partial class TMSTitleType
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_TitleType]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _ttTitleId;
	private System.String _ttTitleName;
	private System.Int32? _ttStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? TTTitleId
	{
		get
		{
			return _ttTitleId;
		}
		set
		{
			_ttTitleId = value;
		}
	}
	
	public System.String TTTitleName
	{
		get
		{
			return _ttTitleName;
		}
		set
		{
			_ttTitleName = value;
		}
	}
	
	public System.Int32? TTStatus
	{
		get
		{
			return _ttStatus;
		}
		set
		{
			_ttStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("TT_TitleId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("TT_TitleName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("TT_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (TTTitleId == null)
		dr["TT_TitleId"] = DBNull.Value;
		else
		dr["TT_TitleId"] = TTTitleId;
		
		if (TTTitleName == null)
		dr["TT_TitleName"] = DBNull.Value;
		else
		dr["TT_TitleName"] = TTTitleName;
		
		if (TTStatus == null)
		dr["TT_Status"] = DBNull.Value;
		else
		dr["TT_Status"] = TTStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		TTTitleId = dr["TT_TitleId"] != DBNull.Value ? Convert.ToInt64(dr["TT_TitleId"]) : TTTitleId = null;
		TTTitleName = dr["TT_TitleName"] != DBNull.Value ? Convert.ToString(dr["TT_TitleName"]) : TTTitleName = null;
		TTStatus = dr["TT_Status"] != DBNull.Value ? Convert.ToInt32(dr["TT_Status"]) : TTStatus = null;
	}
	
	public static TMSTitleType[] MapFrom(DataSet ds)
	{
		List<TMSTitleType> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSTitleType>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_TitleType] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_TitleType] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSTitleType instance = new TMSTitleType();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSTitleType Get(System.Int64 ttTitleId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSTitleType instance;
		
		
		instance = new TMSTitleType();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTitleType_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ttTitleId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSTitleType ID:" + ttTitleId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String ttTitleName, System.Int32? ttStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTitleType_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ttTitleName, ttStatus);
		
		if (transaction == null)
		this.TTTitleId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.TTTitleId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String ttTitleName, System.Int32? ttStatus)
	{
		Insert(ttTitleName, ttStatus, null);
	}
	/// <summary>
	/// Insert current TMSTitleType to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(TTTitleName, TTStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSTitleType to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? ttTitleId, System.String ttTitleName, System.Int32? ttStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTitleType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ttTitleId"].Value = ttTitleId;
		dbCommand.Parameters["@ttTitleName"].Value = ttTitleName;
		dbCommand.Parameters["@ttStatus"].Value = ttStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? ttTitleId, System.String ttTitleName, System.Int32? ttStatus)
	{
		Update(ttTitleId, ttTitleName, ttStatus, null);
	}
	
	public static void Update(TMSTitleType tMSTitleType)
	{
		tMSTitleType.Update();
	}
	
	public static void Update(TMSTitleType tMSTitleType, DbTransaction transaction)
	{
		tMSTitleType.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSTitleType_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@ttTitleId"].SourceColumn = "TT_TitleId";
		dbCommand.Parameters["@ttTitleName"].SourceColumn = "TT_TitleName";
		dbCommand.Parameters["@ttStatus"].SourceColumn = "TT_Status";
		
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
	public static void Delete(System.Int64? ttTitleId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTitleType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ttTitleId);
		
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
	public static void Delete(System.Int64? ttTitleId)
	{
		Delete(
		ttTitleId);
	}
	
	/// <summary>
	/// Delete current TMSTitleType from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTitleType_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, TTTitleId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.TTTitleId = null;
	}
	
	/// <summary>
	/// Delete current TMSTitleType from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSTitleType[] Search(System.Int64? ttTitleId, System.String ttTitleName, System.Int32? ttStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSTitleType_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ttTitleId, ttTitleName, ttStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSTitleType.MapFrom(ds);
	}
	
	
	public static TMSTitleType[] Search(TMSTitleType searchObject)
	{
		return Search ( searchObject.TTTitleId, searchObject.TTTitleName, searchObject.TTStatus);
	}
	
	/// <summary>
	/// Returns all TMSTitleType objects.
	/// </summary>
	/// <returns>List of all TMSTitleType objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSTitleType[] Search()
	{
		return Search ( null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

