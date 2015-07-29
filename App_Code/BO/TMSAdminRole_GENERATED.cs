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
public partial class TMSAdminRole
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_AdminRole]";
	
	#endregion
	
	
	#region Fields
	private System.Int32? _arId;
	private System.String _arRole;
	private System.Boolean? _arStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int32? ARId
	{
		get
		{
			return _arId;
		}
		set
		{
			_arId = value;
		}
	}
	
	public System.String ARRole
	{
		get
		{
			return _arRole;
		}
		set
		{
			_arRole = value;
		}
	}
	
	public System.Boolean? ARStatus
	{
		get
		{
			return _arStatus;
		}
		set
		{
			_arStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("AR_Id", typeof(System.Int32) );
		ds.Tables[TABLE_NAME].Columns.Add("AR_Role", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("AR_Status", typeof(System.Boolean) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (ARId == null)
		dr["AR_Id"] = DBNull.Value;
		else
		dr["AR_Id"] = ARId;
		
		if (ARRole == null)
		dr["AR_Role"] = DBNull.Value;
		else
		dr["AR_Role"] = ARRole;
		
		if (ARStatus == null)
		dr["AR_Status"] = DBNull.Value;
		else
		dr["AR_Status"] = ARStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		ARId = dr["AR_Id"] != DBNull.Value ? Convert.ToInt32(dr["AR_Id"]) : ARId = null;
		ARRole = dr["AR_Role"] != DBNull.Value ? Convert.ToString(dr["AR_Role"]) : ARRole = null;
		ARStatus = dr["AR_Status"] != DBNull.Value ? Convert.ToBoolean(dr["AR_Status"]) : ARStatus = null;
	}
	
	public static TMSAdminRole[] MapFrom(DataSet ds)
	{
		List<TMSAdminRole> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSAdminRole>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_AdminRole] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_AdminRole] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSAdminRole instance = new TMSAdminRole();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSAdminRole Get(System.Int32 arId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSAdminRole instance;
		
		
		instance = new TMSAdminRole();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdminRole_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, arId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
        if (ds == null || ds.Tables[0].Rows.Count == 0) //throw new ApplicationException("Could not get TMSAdminRole ID:" + arId.ToString()+ " from Database.");
            // Return results.
            return null;
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.String arRole, System.Boolean? arStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdminRole_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, arRole, arStatus);
		
		if (transaction == null)
		this.ARId = Convert.ToInt32(db.ExecuteScalar(dbCommand));
		else
		this.ARId = Convert.ToInt32(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.String arRole, System.Boolean? arStatus)
	{
		Insert(arRole, arStatus, null);
	}
	/// <summary>
	/// Insert current TMSAdminRole to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(ARRole, ARStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSAdminRole to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int32? arId, System.String arRole, System.Boolean? arStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdminRole_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@arId"].Value = arId;
		dbCommand.Parameters["@arRole"].Value = arRole;
		dbCommand.Parameters["@arStatus"].Value = arStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int32? arId, System.String arRole, System.Boolean? arStatus)
	{
		Update(arId, arRole, arStatus, null);
	}
	
	public static void Update(TMSAdminRole tMSAdminRole)
	{
		tMSAdminRole.Update();
	}
	
	public static void Update(TMSAdminRole tMSAdminRole, DbTransaction transaction)
	{
		tMSAdminRole.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSAdminRole_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@arId"].SourceColumn = "AR_Id";
		dbCommand.Parameters["@arRole"].SourceColumn = "AR_Role";
		dbCommand.Parameters["@arStatus"].SourceColumn = "AR_Status";
		
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
	public static void Delete(System.Int32? arId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdminRole_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, arId);
		
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
	public static void Delete(System.Int32? arId)
	{
		Delete(
		arId);
	}
	
	/// <summary>
	/// Delete current TMSAdminRole from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdminRole_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, ARId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.ARId = null;
	}
	
	/// <summary>
	/// Delete current TMSAdminRole from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSAdminRole[] Search(System.Int32? arId, System.String arRole, System.Boolean? arStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSAdminRole_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, arId, arRole, arStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSAdminRole.MapFrom(ds);
	}
	
	
	public static TMSAdminRole[] Search(TMSAdminRole searchObject)
	{
		return Search ( searchObject.ARId, searchObject.ARRole, searchObject.ARStatus);
	}
	
	/// <summary>
	/// Returns all TMSAdminRole objects.
	/// </summary>
	/// <returns>List of all TMSAdminRole objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSAdminRole[] Search()
	{
		return Search ( null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

