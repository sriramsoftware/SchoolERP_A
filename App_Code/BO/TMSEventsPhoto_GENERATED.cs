/****************************************************************************/
/* Code Author (written by Xin Zhao)                                        */
/*                                                                          */
/* This file was automatically generated using Code Author.                 */
/* Any manual changes to this file will be overwritten by a automated tool. */
/*                                                                          */
/* Date Generated: 5/25/2012 5:55:53 PM                                    */
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
public partial class TMSEventsPhoto
{
	
	
	#region Constants
	private static readonly string TABLE_NAME = "[dbo].[TMS_EventsPhoto]";
	
	#endregion
	
	
	#region Fields
	private System.Int64? _phId;
	private System.Int64? _phGlid;
	private System.String _phTitle;
	private System.String _phImagePath;
	private System.Int32? _phStatus;
	
	#endregion
	
	
	#region Properties
	public System.Int64? PhId
	{
		get
		{
			return _phId;
		}
		set
		{
			_phId = value;
		}
	}
	
	public System.Int64? PhGlid
	{
		get
		{
			return _phGlid;
		}
		set
		{
			_phGlid = value;
		}
	}
	
	public System.String PHTitle
	{
		get
		{
			return _phTitle;
		}
		set
		{
			_phTitle = value;
		}
	}
	
	public System.String PHImagePath
	{
		get
		{
			return _phImagePath;
		}
		set
		{
			_phImagePath = value;
		}
	}
	
	public System.Int32? PHStatus
	{
		get
		{
			return _phStatus;
		}
		set
		{
			_phStatus = value;
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
		
		ds.Tables[TABLE_NAME].Columns.Add("PH_ID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PH_GLID", typeof(System.Int64) );
		ds.Tables[TABLE_NAME].Columns.Add("PH_Title", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PH_ImagePath", typeof(System.String) );
		ds.Tables[TABLE_NAME].Columns.Add("PH_Status", typeof(System.Int32) );
		
		dr = ds.Tables[TABLE_NAME].NewRow();
		
		if (PhId == null)
		dr["PH_ID"] = DBNull.Value;
		else
		dr["PH_ID"] = PhId;
		
		if (PhGlid == null)
		dr["PH_GLID"] = DBNull.Value;
		else
		dr["PH_GLID"] = PhGlid;
		
		if (PHTitle == null)
		dr["PH_Title"] = DBNull.Value;
		else
		dr["PH_Title"] = PHTitle;
		
		if (PHImagePath == null)
		dr["PH_ImagePath"] = DBNull.Value;
		else
		dr["PH_ImagePath"] = PHImagePath;
		
		if (PHStatus == null)
		dr["PH_Status"] = DBNull.Value;
		else
		dr["PH_Status"] = PHStatus;
		
		
		ds.Tables[TABLE_NAME].Rows.Add(dr);
		
	}
	
	protected void MapFrom(DataRow dr)
	{
		PhId = dr["PH_ID"] != DBNull.Value ? Convert.ToInt64(dr["PH_ID"]) : PhId = null;
		PhGlid = dr["PH_GLID"] != DBNull.Value ? Convert.ToInt64(dr["PH_GLID"]) : PhGlid = null;
		PHTitle = dr["PH_Title"] != DBNull.Value ? Convert.ToString(dr["PH_Title"]) : PHTitle = null;
		PHImagePath = dr["PH_ImagePath"] != DBNull.Value ? Convert.ToString(dr["PH_ImagePath"]) : PHImagePath = null;
		PHStatus = dr["PH_Status"] != DBNull.Value ? Convert.ToInt32(dr["PH_Status"]) : PHStatus = null;
	}
	
	public static TMSEventsPhoto[] MapFrom(DataSet ds)
	{
		List<TMSEventsPhoto> objects;
		
		
		// Initialise Collection.
		objects = new List<TMSEventsPhoto>();
		
		// Validation.
		if (ds == null)
		throw new ApplicationException("Cannot map to dataset null.");
		else if (ds.Tables[TABLE_NAME].Rows.Count == 0)
		return objects.ToArray();
		
		if (ds.Tables[TABLE_NAME] == null)
		throw new ApplicationException("Cannot find table [dbo].[TMS_EventsPhoto] in DataSet.");
		
		if (ds.Tables[TABLE_NAME].Rows.Count < 1)
		throw new ApplicationException("Table [dbo].[TMS_EventsPhoto] is empty.");
		
		// Map DataSet to Instance.
		foreach (DataRow dr in ds.Tables[TABLE_NAME].Rows)
		{
			TMSEventsPhoto instance = new TMSEventsPhoto();
			instance.MapFrom(dr);
			objects.Add(instance);
		}
		
		// Return collection.
		return objects.ToArray();
	}
	
	
	#endregion
	
	
	#region CRUD Methods
	
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSEventsPhoto Get(System.Int64 phId)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		TMSEventsPhoto instance;
		
		
		instance = new TMSEventsPhoto();
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEventsPhoto_SELECT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, phId);
		
		// Get results.
		ds = db.ExecuteDataSet(dbCommand);
		// Verification.
		if (ds == null || ds.Tables[0].Rows.Count == 0) throw new ApplicationException("Could not get TMSEventsPhoto ID:" + phId.ToString()+ " from Database.");
		// Return results.
		ds.Tables[0].TableName = TABLE_NAME;
		
		instance.MapFrom( ds.Tables[0].Rows[0] );
		return instance;
	}
	
	#region INSERT
	public void Insert(System.Int64? phGlid, System.String phTitle, System.String phImagePath, System.Int32? phStatus, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEventsPhoto_INSERT";
		dbCommand = db.GetStoredProcCommand(sqlCommand, phGlid, phTitle, phImagePath, phStatus);
		
		if (transaction == null)
		this.PhId = Convert.ToInt64(db.ExecuteScalar(dbCommand));
		else
		this.PhId = Convert.ToInt64(db.ExecuteScalar(dbCommand, transaction));
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Insert, true)]
	public void Insert(System.Int64? phGlid, System.String phTitle, System.String phImagePath, System.Int32? phStatus)
	{
		Insert(phGlid, phTitle, phImagePath, phStatus, null);
	}
	/// <summary>
	/// Insert current TMSEventsPhoto to database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Insert(DbTransaction transaction)
	{
		Insert(PhGlid, PHTitle, PHImagePath, PHStatus, transaction);
	}
	
	/// <summary>
	/// Insert current TMSEventsPhoto to database.
	/// </summary>
	public void Insert()
	{
		this.Insert((DbTransaction)null);
	}
	#endregion
	
	
	#region UPDATE
	public static void Update(System.Int64? phId, System.Int64? phGlid, System.String phTitle, System.String phImagePath, System.Int32? phStatus, DbTransaction transaction)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEventsPhoto_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@phId"].Value = phId;
		dbCommand.Parameters["@phGlid"].Value = phGlid;
		dbCommand.Parameters["@phTitle"].Value = phTitle;
		dbCommand.Parameters["@phImagePath"].Value = phImagePath;
		dbCommand.Parameters["@phStatus"].Value = phStatus;
		
		if (transaction == null)
		db.ExecuteNonQuery(dbCommand);
		else
		db.ExecuteNonQuery(dbCommand, transaction);
		return;
	}
	
	[DataObjectMethodAttribute(DataObjectMethodType.Update, true)]
	public static void Update(System.Int64? phId, System.Int64? phGlid, System.String phTitle, System.String phImagePath, System.Int32? phStatus)
	{
		Update(phId, phGlid, phTitle, phImagePath, phStatus, null);
	}
	
	public static void Update(TMSEventsPhoto tMSEventsPhoto)
	{
		tMSEventsPhoto.Update();
	}
	
	public static void Update(TMSEventsPhoto tMSEventsPhoto, DbTransaction transaction)
	{
		tMSEventsPhoto.Update(transaction);
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
		sqlCommand = "[dbo].gspTMSEventsPhoto_UPDATE";
		dbCommand = db.GetStoredProcCommand(sqlCommand);
		db.DiscoverParameters(dbCommand);
		dbCommand.Parameters["@phId"].SourceColumn = "PH_ID";
		dbCommand.Parameters["@phGlid"].SourceColumn = "PH_GLID";
		dbCommand.Parameters["@phTitle"].SourceColumn = "PH_Title";
		dbCommand.Parameters["@phImagePath"].SourceColumn = "PH_ImagePath";
		dbCommand.Parameters["@phStatus"].SourceColumn = "PH_Status";
		
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
	public static void Delete(System.Int64? phId, DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEventsPhoto_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, phId);
		
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
	public static void Delete(System.Int64? phId)
	{
		Delete(
		phId);
	}
	
	/// <summary>
	/// Delete current TMSEventsPhoto from database.
	/// </summary>
	/// <param name="transaction">optional SQL Transaction</param>
	public void Delete(DbTransaction transaction)
	{
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEventsPhoto_DELETE";
		dbCommand = db.GetStoredProcCommand(sqlCommand, PhId);
		
		// Execute.
		if (transaction != null)
		{
			db.ExecuteNonQuery(dbCommand, transaction);
		}
		else
		{
			db.ExecuteNonQuery(dbCommand);
		}
		this.PhId = null;
	}
	
	/// <summary>
	/// Delete current TMSEventsPhoto from database.
	/// </summary>
	public void Delete()
	{
		this.Delete((DbTransaction)null);
	}
	
	#endregion
	
	
	#region SEARCH
	[DataObjectMethodAttribute(DataObjectMethodType.Select, false)]
	public static TMSEventsPhoto[] Search(System.Int64? phId, System.Int64? phGlid, System.String phTitle, System.String phImagePath, System.Int32? phStatus)
	{
		DataSet ds;
		Database db;
		string sqlCommand;
		DbCommand dbCommand;
		
		
		db = DatabaseFactory.CreateDatabase();
		sqlCommand = "[dbo].gspTMSEventsPhoto_SEARCH";
		dbCommand = db.GetStoredProcCommand(sqlCommand, phId, phGlid, phTitle, phImagePath, phStatus);
		
		ds = db.ExecuteDataSet(dbCommand);
		ds.Tables[0].TableName = TABLE_NAME;
		return TMSEventsPhoto.MapFrom(ds);
	}
	
	
	public static TMSEventsPhoto[] Search(TMSEventsPhoto searchObject)
	{
		return Search ( searchObject.PhId, searchObject.PhGlid, searchObject.PHTitle, searchObject.PHImagePath, searchObject.PHStatus);
	}
	
	/// <summary>
	/// Returns all TMSEventsPhoto objects.
	/// </summary>
	/// <returns>List of all TMSEventsPhoto objects. </returns>
	[DataObjectMethodAttribute(DataObjectMethodType.Select, true)]
	public static TMSEventsPhoto[] Search()
	{
		return Search ( null, null, null, null, null);
	}
	
	#endregion
	
	
	#endregion
	
	
	#endregion
	
	
}

