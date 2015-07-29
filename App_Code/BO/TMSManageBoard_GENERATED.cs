/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 6/14/2012 11:12:11 AM                                    */
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
public partial class TMSManageBoard
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_ManageBoard]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _scBoardId;
	private System.String _scBoardName;
	private System.DateTime? _scDate;
	private System.Int32? _scStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? SCBoardId
	{
		get
		{
			return _scBoardId;
		}
		set
		{
			_scBoardId = value;
		}
	}
	
	public System.String SCBoardName
	{
		get
		{
			return _scBoardName;
		}
		set
		{
			_scBoardName = value;
		}
	}
	
	public System.DateTime? SCDate
	{
		get
		{
			return _scDate;
		}
		set
		{
			_scDate = value;
		}
	}
	
	public System.Int32? SCStatus
	{
		get
		{
			return _scStatus;
		}
		set
		{
			_scStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("SC_BoardId", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("SC_BoardName", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("SC_Date", typeof(System.DateTime) );
		ds.Tables[TABLE_NAME].Columns.Add("SC_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (SCBoardId == null)
		dr["SC_BoardId"] = DBNull.Value;
		else
		dr["SC_BoardId"] = SCBoardId;
		
		if (SCBoardName == null)
		dr["SC_BoardName"] = DBNull.Value;
		else
		dr["SC_BoardName"] = SCBoardName;
		
		if (SCDate == null)
		dr["SC_Date"] = DBNull.Value;
		else
		dr["SC_Date"] = SCDate;
		
		if (SCStatus == null)
		dr["SC_Status"] = DBNull.Value;
		else
		dr["SC_Status"] = SCStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		SCBoardId = dr["SC_BoardId"] != DBNull.Value ? Convert.ToInt64(dr["SC_BoardId"]) : SCBoardId = null;
		SCBoardName = dr["SC_BoardName"] != DBNull.Value ? Convert.ToString(dr["SC_BoardName"]) : SCBoardName = null;
		SCDate = dr["SC_Date"] != DBNull.Value ? Convert.ToDateTime(dr["SC_Date"]) : SCDate = null;
		SCStatus = dr["SC_Status"] != DBNull.Value ? Convert.ToInt32(dr["SC_Status"]) : SCStatus = null;
	}
	
	public static TMSManageBoard[] MapFrom(DataSet ds)
	{
		List<TMSManageBoard> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSManageBoard>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_ManageBoard] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_ManageBoard] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSManageBoard instance = new TMSManageBoard();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSManageBoard Get(System.Int64 scBoardId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSManageBoard instance;
		
		
		instance = new TMSManageBoard();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSManageBoard_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, scBoardId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSManageBoard ID:" + scBoardId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String scBoardName, System.DateTime? scDate, System.Int32? scStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSManageBoard_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, scBoardName, scDate, scStatus);
		
		if (transaction == null)
		this.SCBoardId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.SCBoardId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String scBoardName, System.DateTime? scDate, System.Int32? scStatus)
	{
		Insert(scBoardName, scDate, scStatus, null);
	}
	/// <summary>
	/// Insert current TMSManageBoard to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(SCBoardName, SCDate, SCStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSManageBoard to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? scBoardId, System.String scBoardName, System.DateTime? scDate, System.Int32? scStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSManageBoard_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@scBoardId"].Value = scBoardId;
		dbCommand.Parameters["@scBoardName"].Value = scBoardName;
		dbCommand.Parameters["@scDate"].Value = scDate;
		dbCommand.Parameters["@scStatus"].Value = scStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? scBoardId, System.String scBoardName, System.DateTime? scDate, System.Int32? scStatus)
	{
		Update(scBoardId, scBoardName, scDate, scStatus, null);
	}
	
	public static void Update(TMSManageBoard tMSManageBoard)
	{
		tMSManageBoard.Update();
	}
	
	public static void Update(TMSManageBoard tMSManageBoard, DbTransaction transaction)
	{
		tMSManageBoard.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSManageBoard_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@scBoardId"].SourceColumn = "SC_BoardId";
		dbCommand.Parameters["@scBoardName"].SourceColumn = "SC_BoardName";
		dbCommand.Parameters["@scDate"].SourceColumn = "SC_Date";
		dbCommand.Parameters["@scStatus"].SourceColumn = "SC_Status";
		
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
	public static void Delete(System.Int64? scBoardId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSManageBoard_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, scBoardId);
		
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
	public static void Delete(System.Int64? scBoardId)
	{
		Delete(
		scBoardId);
	}
	
	/// <summary>
	/// Delete current TMSManageBoard from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSManageBoard_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, SCBoardId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.SCBoardId = null;
	}
	
	/// <summary>
	/// Delete current TMSManageBoard from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSManageBoard[] Search(System.Int64? scBoardId, System.String scBoardName, System.DateTime? scDate, System.Int32? scStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSManageBoard_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, scBoardId, scBoardName, scDate, scStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSManageBoard.MapFrom(ds);
	}
	
	
	public static TMSManageBoard[] Search(TMSManageBoard searchObject)
	{
		return Search ( searchObject.SCBoardId, searchObject.SCBoardName, searchObject.SCDate, searchObject.SCStatus);
	}
	
	/// <summary>
	/// Returns all TMSManageBoard objects.
	/// </summary>
	/// <returns>List of all TMSManageBoard objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSManageBoard[] Search()
	{
		return Search ( null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

